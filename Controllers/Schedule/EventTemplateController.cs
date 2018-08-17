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
        public ActionResult EventTemplate()
        {
            ViewBag.datasource = new ScheduleData().GetWebinarData();
            List<ScheduleViewsModel> viewOption = new List<ScheduleViewsModel>()
            {
                new ScheduleViewsModel {Option = Syncfusion.EJ2.Schedule.View.Week }
            };
            ViewBag.view = viewOption;
            ViewBag.template = "<div class='template-wrap' style='background:${SecondaryColor}'><div class='subject' style='background:${PrimaryColor}'>${Subject}</div><div class='time' style='background:${PrimaryColor}'>Time: ${getTimeString(data.StartTime)} - ${getTimeString(data.EndTime)}</div><div class='image'><img src = './Content/schedule/images/${ImageName}.svg' alt='${ImageName}'/></div><div class='description'>${Description}</div><div class='footer' style='background:${PrimaryColor}'></div></div>";
            return View();
        }
    }
}