using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModel
{
    public class UserViewModel
    {
        [Key]
        public string Id { get; set; }
        public string  Email { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        public string Role { get; set; }
    }
}
