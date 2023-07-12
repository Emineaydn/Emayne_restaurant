using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hw_1.Models
{
    public class Desserts
    {
        [Key]

        public int DessertId { get; set; }
        public string DessertName { get; set; }
        public string Price { get; set; }
    }
}