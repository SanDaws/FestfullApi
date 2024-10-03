using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Models;
public abstract class Participant
{
    [Column("f_name")]
    public required string FirstName{get;set;}
    [Column("s_name")]
    public string? SecondName{get;set;}
    [Column("f_last_name")]
    public string? FirstLastName{get;set;}
    [Column("s_last_name")]
    public string? SecondLastName{get;set;}

    [EmailAddress]
    [Required(AllowEmptyStrings =true)]
    [Column("email")]
    public string? Email{get;set;}
    [Timestamp]
    [Column("creation_date")]
    protected DateOnly Datestamp{get;set;}

    public Participant(string FirstName,string SecondName,string FirstLastName,string SecondLastName, string Email){
        this.FirstName=FirstName;
        this.SecondName=SecondName;
        this.FirstLastName=FirstLastName;
        this.SecondLastName=SecondLastName;
        this.Email=Email;
        Datestamp= DateOnly.FromDateTime(DateTime.Now);
    }

        


}
