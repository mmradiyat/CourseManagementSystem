using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Student : BaseClass
    {
        [Key] public int StudenId { get; set; }
        [Required] public string? StudentName { get; set; }
        [Required] public int PhoneNumber { get; set; }
        [Required] public string? StudentEmail { get; set; }
        [Required] public string? Gender { get; set; }
        [Required] public DateTime DateOfBirth{ get; set; }
        [Required] public string? Semester { get; set; }
        [Required] public string? Department { get; set; }
        [Required] public bool IsContinue { get; set; }
        [Required] public string? UserId { get; set; }
    }
}
