using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GlobalYouthWeb.Models
{
    public class Index
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(26)]
        
        public string bannerTitleOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(31)]
       
        public string bannerBodyOne { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(26)]
        
        public string bannerTitleTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(31)]
        public string bannerBodyTwo { get; set; }

        
        [Required(ErrorMessage = "Title is required")]
        [StringLength(26)]
        public string bannerTitleThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(31)]
        public string bannerBodyThree { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [StringLength(40)]
        public string welcomeTitle { get; set; }

        [Required(ErrorMessage = "Sub-Title is required")]
        [StringLength(50)]
        public string welcomeSubTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(500)]
        public string welcomeBody { get; set; }

       
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string welcomeContentTitleOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(300)]
        public string welcomeContentOne { get; set; }


        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string welcomeContentTitleTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(300)]
        public string welcomeContentTwo { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string welcomeContentTitleThree { get; set; }


        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(300)]
        public string welcomeContentThree { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(50)]
        public string welcomeContentTitleFour { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(300)]
        public string welcomeContentFour { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(30)]
        public string eventTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Body is required")]
        [StringLength(400)]
        public string eventBody { get; set; }


        public string eventImagePathOne { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(74)]
        public string eventContentTitleOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(400)]
        public string eventContentOne { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime eventDate { get; set; }


        public string eventImagePathTwo { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string eventTitleTwo { get; set; }


        public string eventImagePathThree { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string eventTitleThree { get; set; }


        public string eventImagePathFour { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string eventTitleFour { get; set; }


        public string eventImagePathFive { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string eventTitleFive { get; set; }


        public string helpImagePath { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(20)]
        public string helpTitle { get; set; }

        [Required(ErrorMessage = "Sub-Title is required")]
        [StringLength(45)]
        public string helpSubTitle { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(400)]
        public string helpContent { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(20)]
        public string teamTitle { get; set; }


        public string teamImagePathOne { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40)]
        public string teamNameOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamNameContentOne { get; set; }


        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Text is required")]
        [StringLength(40)]
        public string teamTextNameOne { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamTextContentOne { get; set; }


        public string teamImagePathTwo { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40)]
        public string teamNameTwo { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamNameContentTwo { get; set; }


        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Text is required")]
        [StringLength(40)]
        public string teamTextNameTwo { get; set; }


        
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamTextContentTwo { get; set; }


        public string teamImagePathThree { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40)]
        public string teamNameThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamNameContentThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Text is required")]
        [StringLength(40)]
        public string teamTextNameThree { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamTextContentThree { get; set; }


        public string teamImagePathFour { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40)]
        public string teamNameFour { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamNameContentFour { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40)]
        public string teamTextNameFour { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(40)]
        public string teamTextContentFour { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30)]
        public string companyName { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Content is required")]
        [StringLength(150)]
        public string addressContent { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Company's Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        
        public string mobileOne { get; set; }

        [Required(ErrorMessage = "Your must provide a PhoneNumber")]
        [Display(Name = "Company's Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string mobileTwo { get; set; }

        [StringLength(40, MinimumLength = 3, ErrorMessage = "Email must be between 3 and 40 char")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
                       ErrorMessage = "Email doesn't look like a valid email address.")]
        public string companyEmail { get; set; }
    }
}
