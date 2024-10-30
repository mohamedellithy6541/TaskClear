
using Microsoft.EntityFrameworkCore;
using Ticket.Domain.Repository;
using Ticket.Infrastructure.Data;
using Ticket.Infrastructure.Implementation;
using Ticket.services.Implementation;
using Ticket.services.Interfaces;
using Ticket.services.Mapper;

namespace Ticket.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ApplicationContext>();
            builder.Services.AddDbContext<ApplicationContext>(
                options =>
            options.UseMySql(
              builder.Configuration.GetConnectionString("Conf"),
                  new MySqlServerVersion(new Version(8, 0, 33))));
            builder.Services.AddAutoMapper(typeof(TicketProfile));
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddScoped<ITicketServices, ticketServices>();
            builder.Services.AddScoped<ITicketRepository, TicketRepositry>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
