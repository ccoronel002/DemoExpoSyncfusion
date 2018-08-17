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
        public ActionResult GroupByDate()
        {
            ViewBag.datasource = new ScheduleData().GetResourceData();
            
            List<OwnerRes> owners = new List<OwnerRes>();
            owners.Add(new OwnerRes { text = "Alice", id = 1, color = "#1aaa55" });
            owners.Add(new OwnerRes { text = "Smith", id = 2, color = "#7fa900" });
            ViewBag.Owners = owners;
            
            string[] resources = new string[] { "Owners" };
            ViewBag.Resources = resources;
            return View();
        }
    }
    public class OwnerRes
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
    }
}