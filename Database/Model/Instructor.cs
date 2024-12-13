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
        [Key] public string? InstructorId { get; set; }
        [Required] public string? InstructorName { get; set; }
        [Required] public string? InstructorEmail { get; set; }
        [Required] public int PhoneNumber { get; set; }
        [Required] public bool IsInstructorAvailable { get; set; }
        [Required] public string? DepartmentId { get; set; }
        [Required] public string? UserId { get; set; }
        [Required] public string? CourseId { get; set; }
    }
}
