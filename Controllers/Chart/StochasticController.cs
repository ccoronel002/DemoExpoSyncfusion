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
        // GET: Stochastic
        public ActionResult Stochastic()
        {
            ViewBag.crosshairTooltip = new { enable = true };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.animation = new ChartAnimation { Enable = false };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.upperLine =new { color = "#e74c3d" };
            ViewBag.lowerLine = new { color = "#2ecd71" };
            ViewBag.periodLine =new { color = "#f2ec2f" };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            List<ChartStripLine> striplines = new List<ChartStripLine>();
            ChartStripLine one = new ChartStripLine();
            one.Start = "0";
            one.End = "120";
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