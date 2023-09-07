using Microsoft.Extensions.Options;
using ReminderService.Models;

namespace ReminderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.Configure<ReminderDatabaseSettings>(
              builder.Configuration.GetSection(nameof(ReminderDatabaseSettings)));

            builder.Services.AddSingleton<IReminderDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ReminderDatabaseSettings>>().Value);

            builder.Services.AddSingleton<ReminderService>();  // Add services to the container.

            builder.Services.AddControllers().AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}