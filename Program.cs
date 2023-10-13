using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShawlGalore.Data;
using ShawlGalore.Models;
using System;

namespace ShawlGalore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Creating a scope within the application's host services to manage and isolate specific operations, such as database initialization, ensuring proper resource handling and error management.
            using (var scope = host.Services.CreateScope())
            {
                // Getting access to various services.
                var services = scope.ServiceProvider;

                try
                {
                    // Initializing the database with seed data.
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    // In case an error occurs during database seeding, this code will handle error
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }
            }

            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}