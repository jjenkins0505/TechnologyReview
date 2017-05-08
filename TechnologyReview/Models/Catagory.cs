using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnologyReview.Models
{
    public class Catagory
    {

        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        
   

        
      


        //ICollection 
        public virtual ICollection<Reviews> Reviews { get; set; }


    }


}