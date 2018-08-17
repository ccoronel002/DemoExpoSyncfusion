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
        public ActionResult GroupEditing()
        {
            ViewBag.datasource = new ScheduleData().GetResourceConferenceData();
            var monthEventTemplate = "<div class='subject'>${Subject}</div>";
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Month, EventTemplate = monthEventTemplate},
            };
            ViewBag.view = viewOption;

            List<ConferenceRes> conferences = new List<ConferenceRes>();
            conferences.Add(new ConferenceRes { text = "Margaret", id = 1, color = "#1aaa55" });
            conferences.Add(new ConferenceRes { text = "Robert", id = 2, color = "#357cd2" });
            conferences.Add(new ConferenceRes { text = "Laura", id = 3, color = "#7fa900" });
            ViewBag.Conferences = conferences;

            string[] resources = new string[] { "Conferences" };
            ViewBag.Resources = resources;
            return View();
        }
    }
    public class ConferenceRes
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
    }
}