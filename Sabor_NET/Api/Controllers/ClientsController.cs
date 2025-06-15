using Microsoft.AspNetCore.Mvc;
using Sabor_NET.Application.Services;
using Sabor_NET.Domain.Entities;

namespace Sabor_NET.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientsController : ControllerBase
{
    private readonly ClientService _clientService;

    public ClientsController(ClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet("{clientId}")]
    public async Task<ActionResult<Clients>> GetClientByIdAsync(int clientId)
    {
        var client = await _clientService.GetClientByIdAsync(clientId);
        if (client == null)
        {
            return NotFound();
        }
        return Ok(client);
    }
}