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
        // GET: DateTimeCategoryAxis
        public ActionResult DateTimeCategoryAxis()
        {
            List<DateTimeCategoryData> chartData = new List<DateTimeCategoryData>
            {
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 20), yValue1 = 21},
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 21), yValue1 = 24 },
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 22), yValue1 = 24},
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 26), yValue1 = 70},
                new DateTimeCategoryData { xValue = new DateTime(2017, 12, 27), yValue1 = 75 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 02), yValue1 = 82 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 03), yValue1 = 53 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 04), yValue1 = 54 },
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 05), yValue1 = 53},
                new DateTimeCategoryData { xValue = new DateTime(2018, 01, 08), yValue1 = 45 },
            };
            ViewBag.dataSource = chartData;
            ViewBag.line = new { width = 0.0001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.content = "<div style='color:#FF0000;font-family: bold; font-weight: 600'>Christmas Offer<br> Dec 2017</div>";
            ViewBag.content1 = "<div style='color:#FF0000;font-family: bold; font-weight: 800'>New Year Offer<br> Jan 2018</div>";
            return View();
        }
        public class DateTimeCategoryData
        {
            public DateTime xValue;
            public double yValue1;
        }
    }
}