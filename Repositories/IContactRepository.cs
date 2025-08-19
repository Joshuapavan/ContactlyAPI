using System;
using ContactlyAPI.Models;
using ContactlyAPI.Models.Domain;

namespace ContactlyAPI.Repositories;

public interface IContactRepository
{
    Task<IEnumerable<Contact>> GetAllContacts();
    Task<Contact?> AddContact(AddContactRequestDTO request);
}
