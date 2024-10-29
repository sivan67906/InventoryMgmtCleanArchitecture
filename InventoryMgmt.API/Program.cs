
using InventoryMgmt.Application.Services;
using InventoryMgmt.Domain.Interfaces;
using InventoryMgmt.Persistence.Data;
using InventoryMgmt.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InventoryMgmt.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<InventoryMgmtDbContext>(
                options => options.UseSqlite(
                builder.Configuration.GetConnectionString("inventoryMgmtCS")));

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IInventoryMgmtServices, InventoryMgmtServices>();
            builder.Services.AddScoped<IInventoryMgmtRepository, InventoryMgmtRepository>();

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
