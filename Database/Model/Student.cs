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
        [Required, MaxLength(40)] public string? StudentName { get; set; }
        [Required, MaxLength(14)] public string? PhoneNumber { get; set; } //+01xxxxxxxxxxx
        [Required, MaxLength(255)] public string? StudentEmail { get; set; }
        [Required, MaxLength(15)] public string? Gender { get; set; } //Male/Female/Common
        [Required] public DateTime DateOfBirth{ get; set; }
        [Required] public string? SemesterId { get; set; }
        [Required] public string? DepartmentId { get; set; }
        [Required] public bool IsContinue { get; set; }
        [Required] public string? UserId { get; set; }
    }
}
