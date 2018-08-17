using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.RangeNavigator
{
    public partial class RangeNavigatorController : Controller
    {
        // GET: DateTime
        public ActionResult DateTime()
        {
            ViewBag.lineWidth = new RangeNavigatorMajorTickLines { Width = 0.000001, Color = "transparent" };
            ViewBag.border = new ChartBorder { Width = 0.000001 };
            ViewBag.Cross = new ChartCrosshairSettings
            {
                Enable = true
            };
            ViewBag.animation = new ChartAnimation { Enable = false };
            return View();
        }
    }
}