using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Instructor
    {
        [Key, MaxLength(20)] public string? InstructorId { get; set; } //Instructor01,Instructor0123
        [Required, MaxLength(40)] public string? InstructorName { get; set; }
        [Required, MaxLength(255)] public string? InstructorEmail { get; set; }
        [Required, MaxLength(14)] public int PhoneNumber { get; set; }
        [Required] public bool IsInstructorAvailable { get; set; }
        [Required] public string? DepartmentId { get; set; }
        [Required] public string? CourseId { get; set; }
        [Required] public string? UserId { get; set; }
    }
}
