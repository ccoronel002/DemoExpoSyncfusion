using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Schedule;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult GroupByChild()
        {
            ViewBag.datasource = new ScheduleData().GetResourceTeamData();

            List<Projects> projects = new List<Projects>();
            projects.Add(new Projects { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
            projects.Add(new Projects { text = "PROJECT 2", id = 2, color = "#56ca85" });
            ViewBag.Projects = projects;

            List<Categories> categories = new List<Categories>();
            categories.Add(new Categories { text = "Development", id = 1, color = "#1aaa55" });
            categories.Add(new Categories { text = "Testing", id = 2, color = "#7fa900" });
            ViewBag.Categories = categories;

            ViewBag.Resources = new string[] { "Projects", "Categories" };
            return View();
        }
    }
    public class Projects
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
    }
    public class Categories
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
    }
}