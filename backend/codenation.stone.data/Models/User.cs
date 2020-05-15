using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Classe que representa os usuarios salvos no banco de dados
/// </summary>
namespace codenation.stone.data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
