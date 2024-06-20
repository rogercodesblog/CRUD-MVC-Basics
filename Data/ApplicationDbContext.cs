using Microsoft.EntityFrameworkCore;
using CrudExample.Models;

namespace CrudExample.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }


    public DbSet<Contact> Contacts { get; set; }
}
