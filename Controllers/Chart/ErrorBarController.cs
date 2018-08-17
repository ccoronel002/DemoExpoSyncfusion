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
        // GET: ErrorBar
        public ActionResult ErrorBar()
        {
            List<ErrorBarChartData> chartData = new List<ErrorBarChartData>
            {
                new ErrorBarChartData { xValue = "IND", yValue = 24 },
                new ErrorBarChartData { xValue = "AUS", yValue = 20 },
                new ErrorBarChartData { xValue = "USA", yValue = 35 },
                new ErrorBarChartData { xValue = "DEU", yValue = 27 },
                new ErrorBarChartData { xValue = "ITA", yValue = 30 },
                new ErrorBarChartData { xValue = "UK", yValue = 41 },
                new ErrorBarChartData { xValue = "RUS", yValue = 26 }
            };
            ViewBag.dataSource = chartData;
            ViewBag.gridlines = new { width = 0 };
            ViewBag.linestyle = new { width = 0 };
            //ViewBag.border = new { width = 0.001};
            ViewBag.errorBar = new ChartErrorBarSettings { Visible = true, VerticalError = 3, HorizontalError = 3 };
            ViewBag.type = new string[] { "Fixed", "Percentage", "StandardDeviation", "StandardError", "Custom" };
            ViewBag.mode = new string[] { "Vertical", "Horizontal", "Both" };
            ViewBag.direction = new string[] {"Both", "Minus", "Plus" };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class ErrorBarChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}