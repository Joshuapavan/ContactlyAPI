using System.Threading.Tasks;
using AutoMapper;
using ContactlyAPI.Data;
using ContactlyAPI.Models;
using ContactlyAPI.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactlyAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ContactsController(ContactlyDbContext context, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllContacts()
    {
        return Ok(await context.Contacts.ToListAsync());
    }

    [HttpPost]
    public async Task<IActionResult> AddContact([FromBody] AddContactRequestDTO request)
    {
        var domainModelContext = mapper.Map<Contact>(request);
        await context.Contacts.AddAsync(domainModelContext);
        if (await context.SaveChangesAsync() > 0)
        {
            return Ok(domainModelContext);
        }
        else
        {
            return UnprocessableEntity("Error while creating the contact");
        }
    }
}
