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
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string ProfilePicture { get; set; }
    }
}
