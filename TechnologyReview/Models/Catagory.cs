using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnologyReview.Models
{
    public class Catagory
    {

        [Key]
        public int ID { get; set; }

        public string Phone { get; set; }
        public string LapTop { get; set; }

        [Display(Name = "Smart Watches")]
        public string SmartWatches { get; set; }


        //ICollection is more efficient when setting up a one to many relationship code first. type of collection (cousin to a list)
        public virtual ICollection<Book> Books { get; set; }


    }


}