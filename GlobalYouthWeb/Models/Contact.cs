using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class Contact
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(20)]
        public string TitleOne { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(20)]
        public string TitleTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string Body { get; set; }
    }
}
