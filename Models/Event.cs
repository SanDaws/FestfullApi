using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Models;
public class Event
{
    public required string eventName{get;set;}
    public required uint Tables{get;set;}
    public required uint CahrPerTable{get;set;}
    public required DateTime EventDate{get;set;}
    public DateOnly CreationEventDate{get;set;}
    

}
