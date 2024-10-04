using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Dtos.Request;
    public class EntranceDto
    {
        public required string FirstName{get;set;}
        public string? SecondName{get;set;}

    public required string FirstLastName{get;set;}
    public string? SecondLastName{get;set;}

    public required string Password { get; set; }

    
    }