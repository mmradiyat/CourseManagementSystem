using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class SectionWiseStudent
    {
        [Key] public string? SectionWiseStudentId { get; set; }
        [Required] public string? SectionWiseCourseId { get; set; }
        [Required] public string? StudenId { get; set; }
    }
}
