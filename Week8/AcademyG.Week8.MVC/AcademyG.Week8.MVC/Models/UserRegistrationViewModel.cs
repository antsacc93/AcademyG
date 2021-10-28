using AcademyG.Week8.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.MVC.Models
{
    public class UserRegistrationViewModel
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password), MaxLength(16)]
        public string Password { get; set; }
        [Required]
        public Role Role { get; set; }
        
    }
}
