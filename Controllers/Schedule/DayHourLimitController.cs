﻿using System;
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
        public ActionResult DayHourLimit()
        {
            ViewBag.datasource = new ScheduleData().GetEmployeeEventData();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Month }
            };
            ViewBag.view = viewOption;
            return View();
        }
    }
}