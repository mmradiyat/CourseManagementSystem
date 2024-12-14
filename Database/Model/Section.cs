using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Section
    {
        [Key, MaxLength(10)] public string? SectionId { get; set; } //Section1,Section2,Section3
        [Required, MaxLength(5)] public string? SectionName { get; set; } //A,A1,DayA,DayA1
    }
}
