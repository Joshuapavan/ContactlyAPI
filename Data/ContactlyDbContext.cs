using System;
using ContactlyAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactlyAPI.Data;

public class ContactlyDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Contact> Contacts { get; set; }
}
