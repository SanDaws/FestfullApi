using DotNetEnv;
using FestfullApi.data;
using Microsoft.EntityFrameworkCore;

namespace FestfullApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        Env.Load();
        var FestFullModuleConection = $"server={Environment.GetEnvironmentVariable("HOST")};" +
                                   $"port={Environment.GetEnvironmentVariable("PORT")};" +
                                   $"database={Environment.GetEnvironmentVariable("DATABASE")};" +
                                   $"uid={Environment.GetEnvironmentVariable("USER")};" +
                                   $"password={Environment.GetEnvironmentVariable("PASSWORD")}";
        builder.Services.AddDbContext<FestFullApiDbContext>(options =>options.UseNpgsql(FestFullModuleConection));
            


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

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
