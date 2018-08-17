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
        public ActionResult Tooltip()
        {
            ViewBag.datasource = new ScheduleData().GetEventsData();
            ViewBag.template = "<div class='tooltip-wrap'><div class='image ${EventType}'></div><div class='content-area'><div class='name'>${Subject}</></div>" +
           "${if(City !== null && City !== undefined)}<div class='city'>${City}</div>${/if}<div class='time'>From&nbsp;:&nbsp;${StartTime.toLocaleString()} </div>" +
           "<div class='time'>To&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:&nbsp;${EndTime.toLocaleString()} </div></div></div>";
            return View();
        }
    }
}