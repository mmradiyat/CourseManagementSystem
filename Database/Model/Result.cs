using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Result
    {
        [Key] public string? ResultId { get; set; }
        [Required] public int StudenId { get; set; }
        [Required] public int SemesterId { get; set; }
        [Required] public decimal SGPA { get; set; }

    }
}
