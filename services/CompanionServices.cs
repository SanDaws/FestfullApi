using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.data;
using FestfullApi.Models;
using FestfullApi.Repositories;

namespace FestfullApi.services;

public class CompanionServices : ICompanionRepository
{
    private readonly FestFullApiDbContext _context;
    public CompanionServices(FestFullApiDbContext context)
    {
        _context = context;
    }

    public async Task Add(Companion ObjCompanion)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(uint CompanionId)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteLinked(uint guestID)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Companion>> GetByGuestId(uint guestId)
    {
        throw new NotImplementedException();
    }
}
