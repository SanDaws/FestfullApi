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
    [Column("guest_id")]
    public uint GuestId{get;set;}
    [Column("phone")]
    public required string Phone{get;set;}
    [Column("b_day")]
    public required DateOnly BirthDay{get;set;}  
    [Column("alcohol_checker")]
    public bool Alcoholchecker{get;set;}
    [Column("alergies")]
    [Required(AllowEmptyStrings =true)]
    public List<string>? Alergies{get;set;}
    [Column("pass_word")]
    public required string Password{get;set;}
    [Column("evetn_id")]
    public uint EventId{get;set;}

    [ForeignKey("EventId")]
    public required Event EventFK {get;set;}

    public Guest(string FirstName, string SecondName, string FirstLastName, string SecondLastName, string Email,string Phone,DateOnly BirthDay, string Alcoholchecker,List<string> Alergies, string Password)
    : base(FirstName, SecondName, FirstLastName, SecondLastName, Email)
    {
        this.Phone=Phone;
        this.BirthDay=BirthDay;
        this.Alcoholchecker=(Alcoholchecker.ToLower()== "si")?true:false;
        this.Alergies=Alergies;
        this.Password=Password;
    }
    
    
}
