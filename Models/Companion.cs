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
    public uint GuestId{get;set;}
    [ForeignKey("GuestId")]
    public Guest guestFK{get;set;}


}
