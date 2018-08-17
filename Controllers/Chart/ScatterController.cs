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
        // GET: Scatter
        public ActionResult Scatter()
        {
            ViewBag.majorGridLines = new { width = 0.0001 };
            ViewBag.lineStyle = new { width = 0.0001 };
            ViewBag.majorTickLines = new { width = 0.0001 };
           ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.marker = new ChartMarkerSettings
            {
                Visible = false,
                Width = 12,
                Height = 12,
                Shape = ChartShape.Circle
            };
            ViewBag.marker1 = new ChartMarkerSettings
            {
                Visible = false,
                Width = 12,
                Height = 12,
                Shape = ChartShape.Diamond
            };
            return View();
        }
    }
}