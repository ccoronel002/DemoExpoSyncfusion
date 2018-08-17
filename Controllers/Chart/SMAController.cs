using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: SMA
        public ActionResult SMA()
        {
            ViewBag.majorGridLines = new { width = 0.1 };
            ViewBag.lineStyle = new { width = 0.1 };
            ViewBag.animation = new ChartAnimation { Enable = false };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.crosshairTooltip = new { enable = true };
            return View();
        }
    }
}