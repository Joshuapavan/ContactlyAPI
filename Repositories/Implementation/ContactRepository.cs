using System;
using AutoMapper;
using ContactlyAPI.Data;
using ContactlyAPI.Models;
using ContactlyAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactlyAPI.Repositories.Implementation;

public class ContactRepository(ContactlyDbContext context, IMapper mapper) : IContactRepository
{
    public async Task<Contact?> AddContact(AddContactRequestDTO request)
    {
        var domainModelContext = mapper.Map<Contact>(request);
        await context.Contacts.AddAsync(domainModelContext);
        if (await context.SaveChangesAsync() > 0)
        {
            return domainModelContext;
        }
        return null;
    }

    public async Task<IEnumerable<Contact>> GetAllContacts()
    {
        return await context.Contacts.ToListAsync();
    }
}
