using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcademyG.Week8.EsercitazioneFinale.MVC.Models
{
    public class UserViewModel
    {
        [Required, DataType(DataType.EmailAddress), DisplayName("Email")]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }



        public string ReturnUrl { get; set; }
    }
}
