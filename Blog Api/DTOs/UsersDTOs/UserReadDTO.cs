using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Api.DTOs.UsersDTOs
{
    public class UserReadDTO
    {
        public long Id { get; set; }
        public string Role { get; set; }
    }
}
