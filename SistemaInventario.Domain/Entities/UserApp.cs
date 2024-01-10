using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Domain.Entities
{
    public class UserApp : IdentityUser
    {
        public int Id { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Rol { get; set; }
    }
}
