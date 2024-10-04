using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FestfullApi.Controllers.Companion
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanionConectionController(ICompanionRepository companionRepository) : ControllerBase
    {
        protected readonly ICompanionRepository companion = companionRepository;
    }
}