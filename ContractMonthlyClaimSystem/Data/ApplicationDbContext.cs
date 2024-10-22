using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContractMonthlyClaimSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lecturer> Lecturer { get; set; }

        public DbSet<Claim> Claims { get; set; }

        public DbSet<Coordinator> Coordinators { get; set;}

        public DbSet<Manager> Managers { get; set; }

        

    }
}
