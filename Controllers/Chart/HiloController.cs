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
        // GET: Hilo
        public ActionResult Hilo()
        {
            ViewBag.line = new
            {
                width = 0.02,
            };
            ViewBag.majorGridLines = new { width = 0.0001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.crosshairTooltip = new { enable = true };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
    }
}