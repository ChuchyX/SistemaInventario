using SistemaInventario.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application.Models
{
    public class UserServiceResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
