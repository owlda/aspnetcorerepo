using System.Threading.Tasks;
using apsnetproject.Controllers.Resources;
using apsnetproject.Models;
using apsnetproject.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apsnetproject.Controllers
{
    [Route("/api/vehicle")]
    public class ProductAPIController: Controller
    {
        private readonly IMapper _mapper;
        private readonly ModelsDBContext _context;
         public ProductAPIController(IMapper mapper, ModelsDBContext context)
         {
             this._mapper = mapper;
             this._context = context;
         }


        [HttpPost]
        [Route("private")]
        [Authorize]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicle){

                 if(!ModelState.IsValid){

                     return BadRequest(ModelState);
                 }
                 else{

                    var productVehicle = _mapper.Map<VehicleResource, Vehicle>(vehicle);
                    _context.Vehicles.Add(productVehicle);
                    await _context.SaveChangesAsync();
                 
                    var res = _mapper.Map<Vehicle, VehicleResource>(productVehicle);
                    return Ok(res);

                 }
                 
                 

        }
    }
}