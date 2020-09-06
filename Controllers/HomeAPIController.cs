using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apsnetproject.Models;
using apsnetproject.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apsnetproject.Controllers
{

    
    [ApiController]
    [Route("[controller]")]
    public class HomeAPIController: ControllerBase
    {
         private readonly ModelsDBContext _context;
        public HomeAPIController(ModelsDBContext context)
        {
            this._context = context;
        }

        [HttpGet("/")]
        public async Task<IEnumerable<Make>> Get(){
             
             return await _context.Makes.Include(m => m.Models).ToListAsync();

        }

         [HttpGet("/api/offices")]
        public async Task<IEnumerable<Office>> GetOffices(){
             
             return await _context.Offices.Include(m => m.Makes).ToListAsync();

        }
        
    }
}