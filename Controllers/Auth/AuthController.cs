using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FestfullApi.config;
using FestfullApi.data;
using FestfullApi.Dtos.Request;
using FestfullApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FestfullApi.Controllers.Auth;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly FestFullApiDbContext _context;
    private readonly Encript _Encript;


    public AuthController(FestFullApiDbContext context, Encript utilities)
    {
        _context = context;
        _Encript = utilities;
    }
    [HttpPost]
    public async Task<ActionResult> CreateToken(Models.Guest guest)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (_context.Guesses.Any(u => u.Email == guest.Email))
        {
            return BadRequest("Email already exists");
        }

        guest.Password = _Encript.EncryptSHA256(guest.Password);

        _context.Guesses.Add(guest);
        await _context.SaveChangesAsync();
        return Ok("User registered successfully");
    }



}

