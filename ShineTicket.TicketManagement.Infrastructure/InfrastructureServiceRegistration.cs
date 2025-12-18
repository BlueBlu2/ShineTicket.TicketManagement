using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShineTicket.TicketManagement.Application.Contracts.Infrastructure;
using ShineTicket.TicketManagement.Application.Models.Mail;
using ShineTicket.TicketManagement.Infrastructure.FileExport;
using ShineTicket.TicketManagement.Infrastructure.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineTicket.TicketManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<ICsvExporter, CsvExporter>();

            return services;
        }
    }
}
