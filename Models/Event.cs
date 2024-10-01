using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Models;
public class Event
{
    [Key]
    [Column("event_id")]
    public uint EventId{get;set;}
    [Column("event_name")]
    public required string EventName{get;set;}
    [Column("tables")]
    public required uint Tables{get;set;}
    [Column("chairs_per_table")]
    public required uint ChairPerTable{get;set;}
    [Column("event_Date")]
    public required DateTime EventDate{get;set;}
    [Timestamp]
    [Column("Event_stamp")]
    public DateOnly CreationEventDate{get;set;}
    

}
