using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.Models;

namespace FestfullApi.Repositories;
    public interface IGuestRepository
    {
        Task<IEnumerable<Guest>> GetAll(uint EventId);
        Task Add(Guest guest);
        
    }
