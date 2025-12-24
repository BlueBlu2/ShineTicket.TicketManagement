using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShineTicket.TicketManagement.Identity.Models;

namespace ShineTicket.TicketManagement.Identity
{
    public class ShineTicketIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShineTicketIdentityDbContext()
        {

        }

        public ShineTicketIdentityDbContext(DbContextOptions<ShineTicketIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
        .LogTo(Console.WriteLine)
        .EnableSensitiveDataLogging();

    }
}
