using Microsoft.AspNetCore.Identity;
using System;

namespace VendasWeb.Models
{
    public class Usuario : IdentityUser
    {
        public Usuario() => CriadoEm = DateTime.Now;
        public DateTime CriadoEm { get; set; }
    }
}
