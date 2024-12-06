using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class SectionWiseCourse
    {
        [Key] public string? SectionWiseCourseId { get; set; }
        [Required] public string? SectionId { get; set; }
        [Required] public string? CourseId { get; set; }
        [Required] public string? InstructorId { get; set; }
        [Required] public string? StartTime { get; set; }
        [Required] public string? EndTime { get; set; }

    }
}
