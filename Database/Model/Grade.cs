using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Grade
    {
        [Key] public int GradeId { get; set; } // Primary Key
        [Required] public string? SectionWiseStudentId { get; set; }
        [Required] public int SemesterId { get; set; } // Foreign Key to Semester
        [Required] public string? GradeLetter { get; set; } // Grade (A, B)
        [Required] public decimal GradePoint { get; set; } // Grade Point (4.0, 3.5)
    }
}
