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
        [Key, MaxLength(20)] public string? ScheduleId { get; set; } //Schedule01,Schedule012
        [Required] public string? SectionWiseCourseId { get; set;}
        [Required] public string? Day { get; set; } //Monday,Tuesday
        [Required] public int RoomNumber { get; set; } //102,202,402
    }
}
