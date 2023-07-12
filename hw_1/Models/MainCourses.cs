using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hw_1.Models
{
    public class MainCourses
    {
        [Key]

        public int MainId { get; set; }
        public string MainName { get; set; }
        public string Price { get; set; }
    }
}