
using Microsoft.EntityFrameworkCore;
using Productregistration.Models;

namespace Productregistration.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }       
     public DbSet<Category> Categories { get; set; }
    }
}
