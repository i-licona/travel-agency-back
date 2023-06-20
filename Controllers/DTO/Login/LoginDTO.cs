using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace travel_agency_back.Controllers.DTO.Login
{
    public class LoginDTO
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}