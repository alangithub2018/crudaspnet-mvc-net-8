using CRUDASPNETCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDASPNETCoreMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Add models here (each model belongs to a database table)
        public DbSet<Contact> Contact { get; set; }
    }
}
