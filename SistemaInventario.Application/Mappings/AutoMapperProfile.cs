using AutoMapper;
using SistemaInventario.Application.DTOs;
using SistemaInventario.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Application.Mappings
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserRegisterDto, UserApp>();
            CreateMap<UserApp, UserDto>();
        }
    }
}
