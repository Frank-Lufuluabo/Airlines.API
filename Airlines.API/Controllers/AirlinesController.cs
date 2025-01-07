using Airlines.API.Data;
using Airlines.API.Dtos;
using Airlines.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Airlines.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        
        [HttpPost("CreateAirline", Name = "CreateAirline")]
        public IActionResult CreateAirline([FromBody] CreateAirlineDto payload)
        {
            //Create Airline Object
            var newAirline = new Airline
            {
                Id = FakeDb.allFakeAirlines.Count + 1,
                Name = payload.Name
            };

            FakeDb.AddNewAirline(newAirline);

            return Created();
        }
    }
}
