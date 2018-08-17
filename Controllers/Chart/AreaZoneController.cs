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
        // GET: AreaZone
        public ActionResult AreaZone()
        {
            ViewBag.Line = new
            {
                width = 0.001
            };
            List<ChartSegment> segments = new List<ChartSegment>();
            ChartSegment segment1 = new ChartSegment();
            segment1.Value = new DateTime(2016, 5, 1);
            segment1.Color = "url(#winter)";
            segments.Add(segment1);

            ChartSegment segment2 = new ChartSegment();
            segment2.Value = new DateTime(2016, 8, 1);
            segment2.Color = "url(#summer)";
            segments.Add(segment2);

            ChartSegment segment3 = new ChartSegment();
            segment3.Color = "url(#spring)";
            segments.Add(segment3);

            ViewBag.segment = segments;
            ViewBag.content = "<div style='width:80px; padding: 5px;'> <table style='width: 100%'>" +
    "<tr><td><div style='width: 10px; height: 10px;background:linear-gradient(#4ca1af, #c4e0e5);border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Winter</td></tr>" +
    "<tr><td><div style='width: 10px; height: 10px; background:linear-gradient(#ffa751, #ffe259);border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Summer</td></tr><tr><td>" +
    "<div style='width: 10px; height: 10px; background:linear-gradient(#1d976c, #93f9b9);border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Spring</td></tr></table></div>";
             
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
            
        }
    }
}