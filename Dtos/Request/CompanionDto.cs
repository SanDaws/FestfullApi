using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Dtos.Request
{
    //to send
    public class CompanionDto
    {
        
    public required string FirstName{get;set;}
    
    public string? SecondName{get;set;}
    
    public string? FirstLastName{get;set;}
    
    public string? SecondLastName{get;set;}

    public string? Email{get;set;}
    
    public string DogCkeker{get;set;}
    
    public required uint GuestId{get;set;}
        
    }
}