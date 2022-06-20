using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusReservation.WebUI.Models
{
    public class UserDetailsModel
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "Have to Fill First Name Text!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Have to Fill Last Name Text!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Have to User Name Text!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Have to Fill Email!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email address!")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
    }
}
