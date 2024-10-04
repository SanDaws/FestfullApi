using System.Text;
using DotNetEnv;
using FestfullApi.config;
using FestfullApi.data;
using FestfullApi.Repositories;
using FestfullApi.services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
        builder.Services.AddSingleton<JWT>();
        builder.Services.AddAuthentication(config =>
        {
            config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            config.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(config =>
        {
            config.RequireHttpsMetadata = false;
            config.SaveToken = true;
            config.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = Environment.GetEnvironmentVariable("JWTISSUER"),
                ValidateAudience = false,
                ValidAudience = Environment.GetEnvironmentVariable("JWTAUDIENCE"),
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY")!))
            };
        });

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
