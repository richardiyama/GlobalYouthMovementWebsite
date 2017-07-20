using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class Comments
    {

        public int ID { get; set; }
        public string Comment { get; set; }
        public string SenderName { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Email must be between 3 and 40 char")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
                       ErrorMessage = "Email doesn't look like a valid email address.")]
        public string SenderEmail { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Sender's Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string SenderPhoneNumber { get; set; }
    }
}