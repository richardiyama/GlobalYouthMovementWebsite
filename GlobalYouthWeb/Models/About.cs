using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class About
    {


        public int ID { get; set; }

        [Required(ErrorMessage = "An Title is required")]
        [StringLength(15)]
        public string Title { get; set; }

        
        public string ImagePathOne { get; set; }

        [Required(ErrorMessage = "An Title is required")]
        [StringLength(210)]
        public string SubTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(380)]
        public string BodyOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(190)]
        public string BodyTwo { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(20)]
        public string TitleTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string BodyThree { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string BodyFour { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleFour { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string BodyFive { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleFive { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string BodySix { get; set; }

        public string ImagePathTwo { get; set; }
    }
}