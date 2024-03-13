using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SistemaInventario.Application.DTOs;
using SistemaInventario.Application.Interfaces;
using SistemaInventario.Application.Models;
using SistemaInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly UserManager<UserApp> _userManager;

        public UserService(IMapper mapper, IConfiguration configuration, UserManager<UserApp> userManager)
        {
            _mapper = mapper;
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<UserServiceResponse> RegisterUserAsync(UserRegisterDto userDto)
        {         
            var userExist = await _userManager.FindByEmailAsync(userDto.Email);
            if (userExist != null)
                return new UserServiceResponse { Success = false, Message = "There is already a registered user with this email" };

            var result = await _userManager.CreateAsync(_mapper.Map<UserApp>(userDto), userDto.Password);
            if (!result.Succeeded)
                return new UserServiceResponse { Success = false, Message = "There was a problem trying to register the user. Please, try again" };

            return new UserServiceResponse { Success = true, Message = "The user was successfully registered" };
        }
        public async Task<UserServiceResponse> LoginUserAsync(UserLoginDto userLoginDto)
        {
            var user = await _userManager.FindByEmailAsync(userLoginDto.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, userLoginDto.Password))
            {
                return new UserServiceResponse { Success = true, Message = "The user was successfully login", User = _mapper.Map<UserDto>(user), Token = CreateToken(user) };
            }

            return new UserServiceResponse { Success = false, Message = "There was a problem trying to login the user. Wrong email or password" };

        }
        public string CreateToken(UserApp user)
        {
            string role = user.Role;
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, role)
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("JWT:Key").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                issuer: _configuration.GetSection("JWT:Issuer").Value,
                claims: claims,
                expires: DateTime.Now.AddDays(double.Parse(_configuration.GetSection("JWT:Lifetime").Value)),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public async Task<UserServiceResponse> GetCurrentUser(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            return new UserServiceResponse { Success = true, Message = "", User = _mapper.Map<UserDto>(user) };
        }
        public async Task<List<UserDto>> GetAllUsers()
        {
            var users =  _userManager.Users.ToList();
            List<UserDto> usersDto = new List<UserDto>();

            foreach (var user in users)
            {
                usersDto.Add(_mapper.Map<UserDto>(user));
            }
            return usersDto;
        }

    }
}
