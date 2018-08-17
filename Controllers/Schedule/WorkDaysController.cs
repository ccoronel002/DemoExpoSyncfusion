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
        public ActionResult WorkDays()
        {
            ViewBag.workday = new int[] { 1, 3, 5 };
            ViewBag.datasource = new ScheduleData().GetEmployeeEventData();
            ViewBag.dayOfWeek = GetDayOfWeek();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Month }
            };
            ViewBag.view = viewOption;
            return View();
        }

        public List<DropDownData> GetDayOfWeek()
        {
            List<DropDownData> dayOfWeek = new List<DropDownData>();
            dayOfWeek.Add(new DropDownData { Name = "Sunday", Value = "0" });
            dayOfWeek.Add(new DropDownData { Name = "Monday", Value = "1" });
            dayOfWeek.Add(new DropDownData { Name = "Tuesday", Value = "2" });
            dayOfWeek.Add(new DropDownData { Name = "Wednesday", Value = "3" });
            dayOfWeek.Add(new DropDownData { Name = "Thursday", Value = "4" });
            dayOfWeek.Add(new DropDownData { Name = "Friday", Value = "5" });
            dayOfWeek.Add(new DropDownData { Name = "Saturday", Value = "6" });
            return dayOfWeek;
        }
    }

    public class DropDownData
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}