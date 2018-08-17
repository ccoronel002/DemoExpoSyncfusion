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
        // GET: ATR
        public ActionResult ATR()
        {
            ViewBag.Line = new
            {
                width = 0.0001
            };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            List<ChartStripLine> striplines = new List<ChartStripLine>();
            ChartStripLine one = new ChartStripLine();
            one.Start = "0";
            one.End = "14";
            one.Text = "";
            one.Color = "#6063ff";
            one.Visible = true;
            one.Opacity = 0.1;
            one.ZIndex = ZIndex.Behind;
            striplines.Add(one);
            ViewBag.xAxisStripLine = striplines;
            return View();
        }
    }
}