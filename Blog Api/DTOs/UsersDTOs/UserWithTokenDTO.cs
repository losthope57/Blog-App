using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.DTOs.UsersDTOs
{
    public class UserWithTokenDTO : UserReadDTO
    {
        public string Token { get; set; }
    }
}
