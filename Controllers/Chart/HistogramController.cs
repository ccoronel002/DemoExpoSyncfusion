using Syncfusion.EJ2.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Histogram
        public ActionResult Histogram()
        {
            ViewBag.marker= new ChartMarkerSettings { DataLabel= new ChartDataLabelSettings { Visible= true, Position= LabelPosition.Top, Font= new { fontWeight= "600", color= "#ffffff" } } };
            ViewBag.line = new { width = 0.00001 };
            ViewBag.border = new ChartBorder { Width = 0.00001 };
            return View();
        }
    }
}