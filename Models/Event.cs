using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FestfullApi.Models;
public class Event
{
    public string eventName{get;set;}
    public uint Tables{get;set;}
    public uint CahrPerTable{get;set;}
    public DateTime EventDate{get;set;}
    public DateOnly CreationEventDate{get;set;}
    

}
