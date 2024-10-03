using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Dtos.Request;

public class guestDto
{
    public uint EventId { get; set; }
    public required string FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? FirstLastName { get; set; }

    public string? SecondLastName { get; set; }

    public string? Email { get; set; }
    public required string Phone { get; set; }

    public required DateOnly BirthDay { get; set; }

    public string Alcoholchecker { get; set; }

    public List<string>? Alergies { get; set; }

    public required string Password { get; set; }



}
