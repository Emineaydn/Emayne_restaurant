using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace hw_1.Models
{
    public class Context:DbContext
    {
        public DbSet<Starters> Starter { get; set; }

        public DbSet<MainCourses> MainCourse { get; set; }

        public DbSet<Desserts> Dessert { get; set; }

    }
}