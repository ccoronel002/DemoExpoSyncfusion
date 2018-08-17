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
        // GET: RemoteData
        public ActionResult RemoteData()
        {
            ViewBag.labelStyle = new
            {
                color = "transparent"
            };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.animation = new ChartAnimation { Enable = false };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.marker = new ChartMarkerSettings
            {
                DataLabel = new ChartDataLabelSettings
                {
                    Visible = true,
                    Position = LabelPosition.Top,
                    Font = new { fontWeight = "600", color = "#ffffff" }
                }
            };
            return View();
        }
    }
}