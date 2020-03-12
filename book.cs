using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCtest.Models
{
    public class book
    {
        [Required]
        [Display(Name = "BOOK ID")]
        public int ID { get; set; }
        [Required]
        [Display(Name = "BOOK Title")]
        public String Title { get; set; }
        [Required]
        [Display(Name = "Description")]
        public String Description { get; set; }
        [Required]
        [Display(Name = "Author")]
        public String Author { get; set; }
        [Required]
        [Display(Name = "Publisher")]
        public String Publisher { get; set; }
        [Required]
        [Display(Name = "Date Published")]
        public String DatePublished { get; set; }
        [Required]
        [Display(Name = "Book Format")]
        public String BookFormat { get; set; }


    }
}
