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
        // GET: AccumulationDistribution
        public ActionResult AccumulationDistribution()
        {
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.crosshairTooltip = new { enable = true };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            List<ChartStripLine> striplines = new List<ChartStripLine>();
            ChartStripLine one = new ChartStripLine();
            one.Start = "-7000000000";
            one.End = "6000000000";
            one.Text = "";
            one.Color = "black";
            one.Visible = true;
            one.Opacity = 0.03;
            one.ZIndex = ZIndex.Behind;
            striplines.Add(one);
            ViewBag.xAxisStripLine = striplines;
            return View();
        }
    }
}