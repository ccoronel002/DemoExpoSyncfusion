﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        // GET: TimeScale
        public ActionResult TimeScale()
        {
            ViewBag.datasource = new ScheduleData().GetScheduleData();
            ViewBag.intervals = GetIntervalData();
            ViewBag.slotCounts = GetSlotCounts();
            ViewBag.timeScaleOptions = GetTimeScaleOptions();
            ViewBag.timeScaleTemplateOptions = GetTimeScaleTemplateOptions();
            return View();
        }

        public List<TimeScaleDropDownModel> GetIntervalData()
        {
            List<TimeScaleDropDownModel> intervals = new List<TimeScaleDropDownModel>();
            intervals.Add(new TimeScaleDropDownModel { Text = "30", Value = "30" });
            intervals.Add(new TimeScaleDropDownModel { Text = "60", Value = "60" });
            intervals.Add(new TimeScaleDropDownModel { Text = "90", Value = "90" });
            intervals.Add(new TimeScaleDropDownModel { Text = "120", Value = "120" });
            intervals.Add(new TimeScaleDropDownModel { Text = "150", Value = "150" });
            intervals.Add(new TimeScaleDropDownModel { Text = "180", Value = "180" });
            intervals.Add(new TimeScaleDropDownModel { Text = "240", Value = "240" });
            intervals.Add(new TimeScaleDropDownModel { Text = "300", Value = "300" });
            intervals.Add(new TimeScaleDropDownModel { Text = "720", Value = "720" });
            return intervals;
        }

        public List<TimeScaleDropDownModel> GetSlotCounts()
        {
            List<TimeScaleDropDownModel> slots = new List<TimeScaleDropDownModel>();
            slots.Add(new TimeScaleDropDownModel { Text = "1", Value = "1" });
            slots.Add(new TimeScaleDropDownModel { Text = "2", Value = "2" });
            slots.Add(new TimeScaleDropDownModel { Text = "3", Value = "3" });
            slots.Add(new TimeScaleDropDownModel { Text = "4", Value = "4" });
            slots.Add(new TimeScaleDropDownModel { Text = "5", Value = "5" });
            slots.Add(new TimeScaleDropDownModel { Text = "6", Value = "6" });
            return slots;
        }

        public List<TimeScaleDropDownModel> GetTimeScaleOptions()
        {
            List<TimeScaleDropDownModel> options = new List<TimeScaleDropDownModel>();
            options.Add(new TimeScaleDropDownModel { Text = "Show", Value = "enable" });
            options.Add(new TimeScaleDropDownModel { Text = "Hide", Value = "disable" });
            return options;
        }

        public List<TimeScaleDropDownModel> GetTimeScaleTemplateOptions()
        {
            List<TimeScaleDropDownModel> options = new List<TimeScaleDropDownModel>();
            options.Add(new TimeScaleDropDownModel { Text = "Yes", Value = "yes" });
            options.Add(new TimeScaleDropDownModel { Text = "No", Value = "no" });
            return options;
        }
    }
    public class TimeScaleDropDownModel
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }
}