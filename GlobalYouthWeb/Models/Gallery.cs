using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class Gallery
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleOne { get; set; }

        
       
        public string ImagePathOne { get; set; }

      
        public string ImagePathOneTwo { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyTwo { get; set; }

        
        public string ImagePathTwo { get; set; }
        
        public string ImagePathTwoTwo { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyThree { get; set; }

       
        public string ImagePathThree { get; set; }
        
        public string ImagePathThreeTwo { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleFour { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyFour { get; set; }

        
        public string ImagePathFour { get; set; }
       
        public string ImagePathFourThree { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleFive { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyFive { get; set; }
      
        public string ImagePathFive { get; set; }
     
        public string ImagePathFiveFour { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleSix { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodySix { get; set; }

        
        public string ImagePathSix { get; set; }
        
        public string ImagePathSixFive { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleSeven { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodySeven { get; set; }

       
        public string ImagePathSeven { get; set; }
        
        public string ImagePathSevenSix { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleEight { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyEight { get; set; }

        
        public string ImagePathEight { get; set; }
    
        public string ImagePathEightSeven { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleNine { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyNine { get; set; }

        
        public string ImagePathNine { get; set; }
     
        public string ImagePathNineEight { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(15)]
        public string TitleTen { get; set; }

        [Required(ErrorMessage = "Body is required")]
        [StringLength(50)]
        public string BodyTen { get; set; }

       

    }
}
