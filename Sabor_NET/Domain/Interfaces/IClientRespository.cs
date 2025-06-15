
using Sabor_NET.Domain.Entities;

namespace Sabor_NET.Domain.Interfaces;

public interface IClientRepository
{
    Task<Clients> GetClientByIdAsync(int clientId);
}