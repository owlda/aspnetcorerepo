using apsnetproject.Models;
using Microsoft.AspNetCore.Mvc;

namespace apsnetproject.Controllers
{
    [Route("/api/vehicle")]
    public class ProductAPIController: Controller
    {
        [HttpPost]
        public IActionResult CreateVehicle(Vehicle vehicle){

                 return Ok(vehicle);

        }
    }
}