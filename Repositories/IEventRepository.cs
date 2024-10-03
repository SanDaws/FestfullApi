using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.Models;

namespace FestfullApi.Repositories;
    public interface IEventRepository
    {
        Task Add(Event ObjEvent);
        Task Update(Event ObjEvent);
        Task Delete (uint EventId);
        
     
    }
