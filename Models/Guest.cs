using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Models;
[Table("guests")]
public class Guest:Participant
{   
    [Key]
    uint GuestId{get;set;}

    public string Phone{get;set;}
    public DateOnly BirthDay{get;set;}  
    public bool Alcoholchecker{get;set;}
    [Required(AllowEmptyStrings =true)]
    public List<string> Alergies{get;set;}
    public string Password{get;set;}
    
    
}
