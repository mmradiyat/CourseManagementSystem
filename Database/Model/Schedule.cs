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
        [Required, MaxLength(10)] public string? SectionWiseCourseId { get; set;}
        [Required, MaxLength(10)] public string? Day { get; set; } //Monday,Tuesday,Wednesday
        [Required] public int RoomNumber { get; set; } //102,202,402
    }
}
