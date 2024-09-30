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
    public uint Companion_id { get; set; }


}
