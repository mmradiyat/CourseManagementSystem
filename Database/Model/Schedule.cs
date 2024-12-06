using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Schedule
    {
        [Key] public string? ScheduleId { get; set; }
        [Required] public string? SectionWiseCourseId { get; set;}
        [Required] public string? Day { get; set; }
        [Required] public string? Room { get; set; }
    }
}
