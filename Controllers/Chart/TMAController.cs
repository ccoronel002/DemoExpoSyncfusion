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
        // GET: TMA
        public ActionResult TMA()
        {
            ViewBag.crosshairTooltip= new { enable=  true };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.animation = new ChartAnimation { Enable = false };
            return View();
        }
    }
}