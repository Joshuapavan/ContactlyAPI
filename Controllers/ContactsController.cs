using ContactlyAPI.Models;
using ContactlyAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ContactlyAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class ContactsController(IContactRepository contactRepository) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllContacts()
    {
        return Ok(await contactRepository.GetAllContacts());
    }

    [HttpPost]
    public async Task<IActionResult> AddContact([FromBody] AddContactRequestDTO request)
    {
        var result = await contactRepository.AddContact(request);
        if (request != null)
        {
            return Ok(result);
        }
        else
        {
            return UnprocessableEntity("Error while creating the contact");
        }
    }
}
