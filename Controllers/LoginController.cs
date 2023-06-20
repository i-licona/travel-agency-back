
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travel_agency_back.Controllers.DTO.Login;
using travel_agency_back.Data;
using travel_agency_back.Data.Models;

namespace travel_agency_back.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        private readonly TravelAgencyContext context;
        public LoginController(TravelAgencyContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Login([FromBody] LoginDTO customer ){
            var result = await context.Customers
                        .FirstOrDefaultAsync( x => x.Email == customer.Email );
            return Ok(result);
        }    
    }

}