using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShineTicket.TicketManagement.Identity.Models;

namespace ShineTicket.TicketManagement.Identity
{
    public static class IdentityServiceExtensions
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(IdentityConstants.ApplicationScheme).AddIdentityCookies();

            services.AddAuthorizationBuilder();

            services.AddDbContext<ShineTicketIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ShineTicketTicketManagementConnectionString")));

            services.AddIdentityCore<ApplicationUser>()
                .AddEntityFrameworkStores<ShineTicketIdentityDbContext>()
                .AddApiEndpoints();
        }
    }
}
