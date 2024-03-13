using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application.DTOs
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Role { get; set; }
        public string ProfilePicture { get; set; }
    }
}
