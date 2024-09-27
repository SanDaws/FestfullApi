using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FestfullApi.Models;

namespace FestfullApi.data;

public class FestFullApiDbContext : DbContext
{
    public FestFullApiDbContext(DbContextOptions options) : base(options)
    {
    }
    public virtual DbSet<Event> Events{get;set;}
    public virtual DbSet<Guest> Guesses{get;set;}
    public virtual DbSet<Companion> Companions{get;set;}
}
