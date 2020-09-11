using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apsnetproject.Controllers.Resources;
using apsnetproject.Models;
using apsnetproject.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apsnetproject.Controllers
{

    
    [ApiController]
    [Route("[controller]")]
    public class HomeAPIController: ControllerBase
    {
         private readonly ModelsDBContext _context;
         private readonly IMapper _mapper;
        public HomeAPIController(ModelsDBContext context, IMapper imapper)
        {
            this._context = context;
            this._mapper = imapper;
        }

        [HttpGet("/")]
        public async Task<IEnumerable<MakeResource>> Get(){
             
             var listOfMakes = await _context.Makes.Include(m => m.Models).ToListAsync();

             return _mapper.Map<List<Make>, List<MakeResource>>(listOfMakes);

        }
         
        [HttpGet("/api/contacts")]
        public async Task<IEnumerable<ContactResource>> GetContacts(){
             
             var contacts = await _context.Contacts.ToListAsync();

             return _mapper.Map<List<Contact>, List<ContactResource>>(contacts);

        }

        [HttpGet("/api/contact")]
        public async Task<IEnumerable<Contact>> GetContact(){
             
            //var filterObj = _mapper.Map<FilterContactResource, FilterContact>(filter);

            return await _context.Contacts.ToListAsync();

        }

        [HttpPost("/api/addcontact")]
         public async Task<IActionResult> CreateContact([FromBody] ContactResource info){

                 if(!ModelState.IsValid){

                     return BadRequest(ModelState);
                 }
                 
                //  if(!ModelState.IsValid){
                     
                //      ModelState.AddModelError(string.Empty, "Empty String detected");
                //      return BadRequest(ModelState);
                //  }
                 else{
                    
                    var contact = _mapper.Map<ContactResource, Contact>(info);
                    
                    _context.Contacts.Add(contact);                    
                    await _context.SaveChangesAsync();

                    var response = _mapper.Map<Contact, ContactResource>(contact);
                 
                    return Ok(response);

                 }
            }

        [HttpGet("/api/offices")]
        public async Task<IEnumerable<OfficeResource>> GetOffices(){

            
             
             var listOfOffices =  await _context.Offices.Include(m => m.Makes).ToListAsync();

             return _mapper.Map<List<Office>, List<OfficeResource>>(listOfOffices);

        }

        
    }
}