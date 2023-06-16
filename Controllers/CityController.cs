using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using travel_agency_back.Data;
using travel_agency_back.Data.Models;

namespace travel_agency_back.Controllers
{
    /* decoradores: dan informacion sobre la clase o sobre lo que realiza la clase */
    [ApiController]
    [Route("api/city")]
    public class CityController : ControllerBase
    {
        private readonly TravelAgencyContext context;
        /* Inyeccion de dependecias: */
        public CityController(TravelAgencyContext context)
        {
          this.context = context;
        }
        /* SELECT, INSERT, UPDATE, DELETE */
        /* Peticiones http: GET, POST, PUT, DELETE */
        [HttpGet("cities") ]
        public async Task<ActionResult> Get(){
            List<City> cities = await context.Cities.ToListAsync();
            /* Metodo Ok pone a nuestra respuesta el status 200 */
            return Ok(cities);
        }

        [HttpGet("destinies") ]
        public async Task<ActionResult> GetDestinies(){
           var destinies = await context.Destinies
            .Where( x => x.IdCity == 2 )
            .ToListAsync();  
            return Ok(destinies);
        }
    }
}