using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime PostDate { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]
        public string BlogContent { get; set; }
        
        public string BlogImagePath { get; set; }
       

    }
}
