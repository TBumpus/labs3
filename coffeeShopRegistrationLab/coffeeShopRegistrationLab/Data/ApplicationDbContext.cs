using coffeeShopRegistrationLab.Models;
using Microsoft.EntityFrameworkCore;

namespace coffeeShopRegistrationLab.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }


    }
}
