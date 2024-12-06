using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Section
    {
        [Key] public string? SectionId { get; set; }
        [Required] public string? SectionName { get; set; }
    }
}
