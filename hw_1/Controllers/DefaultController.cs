using hw_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw_1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db = new Context();
        public ActionResult Index()
        {

            List<Starters> Starterslist = db.Starter.ToList();
            List<MainCourses> MainCourseslist = db.MainCourse.ToList();
            List<Desserts> Dessertslist = db.Dessert.ToList();

            // Combine the lists into a single model object
            var combinedModel = new CombinedViewModel
            {
                Starter = Starterslist,
                MainCourse = MainCourseslist,
                Dessert = Dessertslist
            };

            return View(combinedModel);
        }

    }
}
public class CombinedViewModel
{
    public List<Starters> Starter { get; set; }
    public List<MainCourses> MainCourse { get; set; }
    public List<Desserts> Dessert { get; set; }

}
