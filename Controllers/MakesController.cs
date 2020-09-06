using System.Collections.Generic;
using System.Threading.Tasks;
using apsnetproject.Models;
using apsnetproject.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apsnetproject.Controllers
{
    public class MakesController: Controller
    {
        private readonly ModelsDBContext _context;
        public MakesController(ModelsDBContext context)
        {
            this._context = context;
        }
        [HttpGet("/api/makes")]
        public  async Task <IEnumerable<Make>> GetMakes(){

               return await _context.Makes.Include(m => m.Models).ToListAsync();

        }
    }
}