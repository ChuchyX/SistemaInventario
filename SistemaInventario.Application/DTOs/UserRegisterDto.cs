using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application.DTOs
{
    public  class UserRegisterDto
    {
        [Required]
        [NotNull]
        public string Username { get; set; }

        [Required]
        [NotNull]
        public string Password { get; set; }

        [Required]
        [NotNull]
        public string Email { get; set; }

        [Required]
        [NotNull]
        public int Edad { get; set; }

        [Required]
        [NotNull]
        public string Sexo { get; set; }
        [Required]
        [NotNull]
        public string Rol { get; set; }
    }
}
