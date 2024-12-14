using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class User: BaseClass
    {
        [Key, MaxLength(128)] public string? UserId { get; set; } = Guid.NewGuid().ToString();
        [Required, MaxLength(40)] public string? UserName { get; set;}
        [Required, MaxLength(255)] public string? UserEmail { get; set;}
        [Required, MaxLength(14)] public string? UserPhone { get; set;} //+8801812703580
        [Required, MaxLength(10)] public string? UserType { get; set;} //Admin,Instructor/Student
        [Required, MaxLength(255)] public string? UserPasswordHash { get; set; }
        public bool IsUserActive { get; set; }
    }
}
