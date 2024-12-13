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
        [Key] public string? UserId { get; set; } = Guid.NewGuid().ToString();
        [Required, MaxLength(40)] public string? UserName { get; set;}
        [Required] public string? UserEmail { get; set;}
        [Required] public string? UserPhone { get; set;}
        [Required] public string? UserType { get; set;}
        [Required] public string? UserPasswordHash { get; set; }
        public bool IsUserActive { get; set; }
    }
}
