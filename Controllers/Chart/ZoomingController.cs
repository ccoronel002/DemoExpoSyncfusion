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
        // GET: Zooming
        public ActionResult Zooming()
        {
            ViewBag.majorGridLines= new { width= 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.border = new ChartBorder { Width = 0.5, Color = "#00bdae" };
            ViewBag.animation= new ChartAnimation { Enable = false };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
    }
}