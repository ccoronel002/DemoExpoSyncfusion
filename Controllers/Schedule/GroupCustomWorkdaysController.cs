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
        public ActionResult GroupCustomWorkdays()
        {
            ViewBag.datasource = new ScheduleData().GetDoctorData();
            List<DoctorRes> doctors = new List<DoctorRes>();
            doctors.Add(new DoctorRes { text = "Will Smith", id = 1, color = "#ea7a57", workDays = new List<int> { 1, 2, 4, 5 }, startHour = "08:00", endHour = "13:00" });
            doctors.Add(new DoctorRes { text = "Alice", id = 2, color = "rgb(53, 124, 210)", workDays = new List<int> { 1, 3, 5 }, startHour = "08:00", endHour = "17:00" });
            doctors.Add(new DoctorRes { text = "Robson", id = 3, color = "#7fa900", startHour = "08:00", endHour = "16:00" });
            ViewBag.Doctors = doctors;

            string[] resources = new string[] { "Doctors" };
            ViewBag.Resources = resources;
            return View();
        }
    }
    public class DoctorRes
    {
        public string text { set; get; }
        public int id { set; get; }
        public string color { set; get; }
        public List<int> workDays { set; get; }
        public string startHour { set; get; }
        public string endHour { set; get; }
    }
}