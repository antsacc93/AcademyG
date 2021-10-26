using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.MVC.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Insert Code!")]
        [MaxLength(5, ErrorMessage = "Max 5 characters")]
        [Display(Name = "Code")]
        public string EmployeeCode { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; } = DateTime.Today;
    }
}
