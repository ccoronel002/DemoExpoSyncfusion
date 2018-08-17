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
        // GET: Trendlines
        public ActionResult Trendlines()
        {
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.000001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.marker = new ChartMarkerSettings { Visible = true };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.trendlineTypes = new string[] { "Linear", "Exponential", "Power", "Logarithmic", "Polynomial", "MovingAverage" };
            List<ChartTrendline> lines = new List<ChartTrendline>();
            ChartTrendline line = new ChartTrendline();
            line.Type = TrendlineTypes.Linear;
            line.Width = 3;
            line.Name = "Linear";
            line.Fill = "#C64A75";
            lines.Add(line);
            ViewBag.trendLines = lines;
            return View();
        }
    }
}