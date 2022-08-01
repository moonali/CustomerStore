using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CustomersDetail
    {
        public int Id { get; set; }
        [Required]
        [Display(Name= "Customer Name")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        [Display(Name = "Post code")]
        [Required]
        public string Postcode { get; set; }
        [Required]
        [Display(Name = "Contact Email")]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }
        [Display(Name = "Contact Phone Number")]
        public string ContactPhoneNumber { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}
