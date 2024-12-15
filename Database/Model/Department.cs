using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class Department
    {
        [Key, MaxLength(5)] public string? DepartmentId { get; set; } //DEP01, DEP02
        [Required, MaxLength(50)] public string? DepartmentName { get; set; }
    }
}
