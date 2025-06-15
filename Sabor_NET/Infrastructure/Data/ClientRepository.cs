using Microsoft.Data.Sqlite;
using Sabor_NET.Domain.Entities;
using Sabor_NET.Domain.Interfaces;

public class ClientRepository : IClientRepository
{
    private readonly string _connectionString;

    public ClientRepository(string connectionString)
    {
        _connectionString = $"Data Source={connectionString}";
    }

    public async Task<Clients> GetClientByIdAsync(int clientId)
    {
        using var connection = new SqliteConnection(_connectionString);
        await connection.OpenAsync();

        var command = connection.CreateCommand();
        command.CommandText = @"
            SELECT ClientId, Client_name, Email, Phone1, Phone2, Client_included
            FROM Clients
            WHERE ClientId = @clientId";
        command.Parameters.AddWithValue("@clientId", clientId);

        using var render = await command.ExecuteReaderAsync();
        if (await render.ReadAsync())
        {
            return new Clients
            {
                ClientId = render.GetInt32(0),
                Client_name = render.GetString(1),
                Email = render.GetString(2),
                Phone1 = render.IsDBNull(3) ? null : render.GetInt64(3),
                Phone2 = render.IsDBNull(4) ? null : render.GetInt64(4),
                Client_included = render.GetString(5)
            };
        }
        return null;
    }
}