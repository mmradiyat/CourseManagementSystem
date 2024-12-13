using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Attendence
    {
        [Key] public string? AttendenceId { get; set; }
        [Required] public string? SectionWiseCourseId { get; set; }
        [Required] public string? SectionId { get; set; }
        [Required] public DateOnly IssueDate { get; set; }
        public bool IsPresent { get; set; }
    }
}
