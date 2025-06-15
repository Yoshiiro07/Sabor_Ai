
using System;
// using System.Collections.Generic;

namespace Sabor_NET.Domain.Entities;
public class Clients
{
    public int ClientId { get; set; }
    public string Client_name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public long? Phone1 { get; set; }
    public long? Phone2 { get; set; }
    public string Client_included { get; set; } = string.Empty;
}