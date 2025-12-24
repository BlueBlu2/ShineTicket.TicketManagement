using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShineTicket.TicketManagement.Api.Middleware;
using ShineTicket.TicketManagement.Api.Services;
using ShineTicket.TicketManagement.Application;
using ShineTicket.TicketManagement.Application.Contracts;
using ShineTicket.TicketManagement.Identity;
using ShineTicket.TicketManagement.Identity.Models;
using ShineTicket.TicketManagement.Infrastructure;
using ShineTicket.TicketManagement.Persistence;
using System.Security.Claims;
namespace ShineTicket.TicketManagement.Api
{
    public static class StartupExtensions
    {
        public static WebApplication ConfigureServices(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddApplicationServices();
            builder.Services.AddInfrastructureServices(builder.Configuration);
            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddIdentityServices(builder.Configuration);

            builder.Services.AddScoped<ILoggedInUserService, LoggedInUserService>();

            builder.Services.AddHttpContextAccessor();

            builder.Services.AddControllers();

            builder.Services.AddCors(
                options => options.AddPolicy(
                    "open",
                    policy => policy.WithOrigins([builder.Configuration["ApiUrl"] ?? "https://localhost:7081",
                        builder.Configuration["BlazorUrl"] ?? "https://localhost:7080"])
            .AllowAnyMethod()
            .SetIsOriginAllowed(pol => true)
            .AllowAnyHeader()
            .AllowCredentials()));

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            app.MapIdentityApi<ApplicationUser>();

            app.MapPost("/Logout", async (ClaimsPrincipal user, SignInManager<ApplicationUser> signInManager) =>
            {
                await signInManager.SignOutAsync();
                return TypedResults.Ok();
            });

            app.UseCors("open");

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCustomExceptionHandler();

            app.UseHttpsRedirection();
            app.MapControllers();

            return app;
        }

        public static async Task ResetDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            try
            {
                var context = scope.ServiceProvider.GetService<ShineTicketDbContext>();
                if (context != null)
                {
                    await context.Database.EnsureDeletedAsync();
                    await context.Database.MigrateAsync();
                }
            }
            catch (Exception ex)
            {
               
            }
        }
    }

}