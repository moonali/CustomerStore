using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModel
{
    public class LoginViewModel
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="User Name")]
        public string Emial { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
