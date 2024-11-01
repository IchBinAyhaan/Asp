using Asp_task2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Asp_task2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<ChooseUs> ChooseUss { get; set; }
        public DbSet<HomeWork> HomeWorks { get; set; }
        public DbSet<PricingCard> PricingCards { get; set; }
        public DbSet<ContactCard> ContactCards { get; set; }
    }
}
