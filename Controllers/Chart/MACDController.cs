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
        // GET: MACD
        public ActionResult MACD()
        {
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.crosshairTooltip = new { enable = true };
            List<ChartStripLine> striplines = new List<ChartStripLine>();
            ChartStripLine one = new ChartStripLine();
            one.Start = "-3.5";
            one.End = "3.5";
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