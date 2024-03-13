using SistemaInventario.Application.DTOs;
using SistemaInventario.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserServiceResponse> RegisterUserAsync(UserRegisterDto userDto);
        Task<UserServiceResponse> LoginUserAsync(UserLoginDto userLoginDto);
        Task<UserServiceResponse> GetCurrentUser(string email);
        Task<List<UserDto>> GetAllUsers();
    }
}
