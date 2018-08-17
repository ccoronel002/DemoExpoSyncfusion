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
        // GET: Bollinger
        public ActionResult Bollinger()
        {
            ViewBag.animation = new ChartAnimation { Enable = true };
            ViewBag.upperline = new { color = "#ffb735", width = 1 };
            ViewBag.lowerline = new { color = "#f2ec2f", width = 1 };
            ViewBag.gridlines = new { width = 0.0001 };
            ViewBag.linestyle = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.crosshairtooltip = new { enable = true };
            return View();
        }
    }
}