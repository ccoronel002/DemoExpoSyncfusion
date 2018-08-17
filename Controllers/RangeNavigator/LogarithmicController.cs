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
        // GET: Logarithmic
        public ActionResult Logarithmic()
        {
            ViewBag.lineWidth = new { width = 0.00001 };
            ViewBag.border = new ChartBorder { Width = 0.00001 };
            ViewBag.Cross = new { enable = false };
            ViewBag.animation = new ChartAnimation { Enable = false };
            ViewBag.marker = new ChartMarkerSettings { Visible = true };
            return View();
        }
    }
}