using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModel
{
    public class RegisterViewModelcs
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Emial { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Confirm Password")]
        [Compare("Password",ErrorMessage ="Password do not macth !")]
        public string ConfirmPassword { get; set; }

    }
}
