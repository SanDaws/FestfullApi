using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.Models;

namespace FestfullApi.Repositories;

    public interface ICompanionRepository
    {
        Task<IEnumerable<Companion>>GetByGuestId(uint guestId);
        Task Delete(uint CompanionId);
        Task DeleteLinked(uint guestID);
        Task Add(Companion ObjCompanion);
    }
