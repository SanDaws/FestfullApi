using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.config;
using FestfullApi.data;
using Microsoft.AspNetCore.Mvc;

namespace FestfullApi.Controllers.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
       private readonly FestFullApiDbContext _context;
       private readonly Encript _Encript;
       public LoginController(FestFullApiDbContext context, Encript utilities){
        _context = context;
        _Encript = utilities;

       }
       
    }
}