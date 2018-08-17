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
        // GET: LineZone
        public ActionResult LineZone()
        {
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };

            List<ChartSegment> segments = new List<ChartSegment>();
            ChartSegment segment1 = new ChartSegment();
            segment1.Value = 450;
            segment1.Color = "red";
            segments.Add(segment1);

            ChartSegment segment2 = new ChartSegment();
            segment2.Value = 500;
            segment2.Color = "green";
            segments.Add(segment2);

            ChartSegment segment3 = new ChartSegment();
            segment3.Color = "blue";
            segments.Add(segment3);

            ViewBag.segment = segments;
            ViewBag.content = "<div style='width:80px; padding: 5px;'><table style='width: 100%'>" +
    "<tr> <td><div style='width: 10px; height: 10px; background:blue;border-radius: 15px;'></div>" +
    "</td> <td style='padding-left: 5px;'>High</td></tr><tr><td>" +
    "<div style='width: 10px; height: 10px; background:green;;border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Medium </td></tr><tr><td>" +
    "<div style='width: 10px; height: 10px; background:red;;border-radius: 15px;'></div>" +
    "</td><td style='padding-left: 5px;'>Low</td></tr></table></div>";
            return View();
        }
    }
}