using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hw_1.Models
{
    public class Starters
    {
        [Key]

        public int StarterId { get; set; }
        public string StarterName { get; set;}
        public string Price{ get; set;}
    }
}