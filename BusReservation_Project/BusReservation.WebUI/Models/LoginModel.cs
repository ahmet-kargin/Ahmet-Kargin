using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Do not be empty UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please, fill in your password ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
