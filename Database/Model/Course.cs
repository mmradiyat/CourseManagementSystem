using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Course
    {
        [Key, MaxLength(7)] public string? CourseId { get; set; } //CSC 103
        [Required, MaxLength(50)] public string? CourseName { get; set; }
        [Required] public int CreditHour { get; set; } //1,2,3,4
        [Required, MaxLength(10)] public string? CourseDuration { get; set; } //1.5,2 Hours
        [Required] public string? DepartmentId { get; set; }
        [Required] public DateOnly Date { get;set; }
    }
}
