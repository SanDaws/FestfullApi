using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Models;
public abstract class Participant
{
    
    public required string FirstName{get;set;}
    public string secondName{get;set;}
     public string FirstLastName{get;set;}
    public string secondLastName{get;set;}

    [EmailAddress]
    [Required(AllowEmptyStrings =true)]
    public string email{get;set;}
    [Timestamp]
    protected DateOnly Datestamp=>DateOnly.FromDateTime(DateTime.Now);

        


}
