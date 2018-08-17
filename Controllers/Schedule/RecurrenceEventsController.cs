using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Schedule;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        // GET: Recurrence
        public ActionResult RecurrenceEvents()
        {
            ViewBag.datasource = new ScheduleData().GetRecurrenceData();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Month }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}