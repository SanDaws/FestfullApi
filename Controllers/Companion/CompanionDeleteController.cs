using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FestfullApi.Repositories;

namespace FestfullApi.Controllers.Companion
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanionDeleteController(ICompanionRepository companionRepository) : CompanionConectionController(companionRepository)
    {
        
    }
}