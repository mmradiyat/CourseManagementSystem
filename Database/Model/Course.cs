using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Course : BaseClass
    {
        [Key] public string? CourseId { get; set; }
        [Required] public string? CourseName { get; set; }
        [Required] public int CourseCreditHour { get; set; }
        [Required] public string? CourseDuration { get; set; }
        [Required] public string? DepartmentId { get; set; }
    }
}
