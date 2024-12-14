using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Semester
    {
        [Key] public int SemesterId { get; set; }
        [Required] public string? SemesterName { get; set; }
        [Required] public string? SemesterNo { get; set; }
        [Required] public DateOnly StartDate { get; set; }
        [Required] public DateOnly EndDate { get; set; }
    }
}
