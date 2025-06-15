using Sabor_NET.Domain.Entities;
using Sabor_NET.Domain.Interfaces;

namespace Sabor_NET.Application.Services;

public class ClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public async Task<Clients?> GetClientByIdAsync(int clientId)
    {
        return await _clientRepository.GetClientByIdAsync(clientId);
    }
}