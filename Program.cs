using DotNetEnv;
using FestfullApi.data;
using FestfullApi.Repositories;
using FestfullApi.services;
using Microsoft.EntityFrameworkCore;

namespace FestfullApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        Env.Load();
        var FestFullModuleConection = $"server={Environment.GetEnvironmentVariable("PGHOST")};" +
                                   $"port={Environment.GetEnvironmentVariable("PGPORT")};" +
                                   $"database={Environment.GetEnvironmentVariable("PGDATABASE")};" +
                                   $"uid={Environment.GetEnvironmentVariable("PGUSER")};" +
                                   $"password={Environment.GetEnvironmentVariable("PGPASSWORD")}";
        builder.Services.AddDbContext<FestFullApiDbContext>(options =>options.UseNpgsql(FestFullModuleConection));
            


        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddScoped<ICompanionRepository,CompanionServices>();
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

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
