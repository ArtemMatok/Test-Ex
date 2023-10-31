using Microsoft.EntityFrameworkCore;
using Test_Ex.Models;

namespace Test_Ex.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
