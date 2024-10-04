using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FestfullApi.Repositories;
using FestfullApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace FestfullApi.Controllers.Companion
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanionCreateController(ICompanionRepository companionRepository) : CompanionConectionController(companionRepository)
    {
        //[Authorize]// for  make it required a jwt

        
    }
}