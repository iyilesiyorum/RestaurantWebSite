using Api.WebApi.Context;
using Api.WebApi.Dtos.ContactDtos;
using Api.WebApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ContactsController(ApiContext context)
        {
            _context = context;           
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _context.Contacts.ToList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact();

            contact.Email = createContactDto.Email;
            contact.Adress = createContactDto.Adress;
            contact.Phone = createContactDto.Phone;
            contact.MapLocation = createContactDto.MapLocation;
            contact.OpenHours = createContactDto.OpenHours;
            
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return Ok("Ekleme işlemi başarılı ");

        }
    }
}
