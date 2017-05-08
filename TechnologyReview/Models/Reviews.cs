using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechnologyReview.Models
{
    public class Reviews
    {
        [Key]

        public int ID { get; set; }


        public string Name { get; set; }

        [Display(Name = "Review Description")]
        public string ReviewDescription { get; set; }



        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:mm/dd/yyyy}")]
        public DateTime Date { get; set; }





        [ForeignKey("Catagory")]
        public int CatagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }

    }
}