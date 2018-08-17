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
        public ActionResult Views()
        {
            ViewBag.datasource = new ScheduleData().GetZooEventData();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Month }
            };
            ViewBag.view = viewOption;
            ViewBag.ddl = GetViewData();
            return View();
        }

        public List<ViewData> GetViewData()
        {
            List<ViewData> view = new List<ViewData>();
            view.Add(new ViewData { Name = "Day", Value = "Day" });
            view.Add(new ViewData { Name = "Week", Value = "Week" });
            view.Add(new ViewData { Name = "Work Week", Value = "WorkWeek" });
            view.Add(new ViewData { Name = "Month", Value = "Month" });
            return view;
        }
    }

    public class ViewData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}