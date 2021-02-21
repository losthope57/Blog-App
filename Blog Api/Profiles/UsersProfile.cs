using AutoMapper;
using Blog_Api.DTOs.UsersDTOs;
using Blog_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.Profiles
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<User, UserReadDTO>();
            CreateMap<UserCreateDTO, User>();
            CreateMap<User, UserWithTokenDTO>();
            CreateMap<UserEditDTO, User>();
        }
    }
}
