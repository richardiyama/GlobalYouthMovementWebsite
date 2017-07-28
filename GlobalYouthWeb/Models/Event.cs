using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class Event
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(26)]
        public string titleOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string  bodyOne { get; set; }

        
        public string ImagePath { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string titleTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string bodyTwo { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string bodyThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string bodyFour { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string bodyFive { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string bodySix { get; set; }
    }
}
