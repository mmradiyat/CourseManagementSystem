using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class BaseClass
    {
        [Key] public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime UpdateDate { get; set;} = DateTime.Now;
        public string? UpdatedBy { get; set;}
    }
}
