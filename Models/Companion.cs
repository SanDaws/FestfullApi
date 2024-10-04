using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace FestfullApi.Models;
[Table("companions")]
public class Companion : Participant
{
    [Key]
    [Column("companion_id")]
    public uint CompanionId { get; set; }
    [Column("dog_checker")]
    public bool DogCkeker{get;set;}
    [Column("guest_id")]
    public required uint GuestId{get;set;}
    [ForeignKey("GuestId")]
    public Guest guestFK{get;set;}

    public Companion(string FirstName, string SecondName, string FirstLastName, string SecondLastName, string Email,string DogCkeker,uint GuestId) 
    : base(FirstName, SecondName, FirstLastName, SecondLastName, Email)
    {
        this.DogCkeker=(DogCkeker.ToLower()=="si")?true:false;
        this.GuestId= GuestId;
    }


}
