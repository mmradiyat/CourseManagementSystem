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
        [Key, MaxLength(10)] public string? SectionWiseStudentId { get; set; }//SWSID01,SWSTD02
        [Required] public string? SectionWiseCourseId { get; set; }
        [Required] public int StudenId { get; set; }
    }
}
