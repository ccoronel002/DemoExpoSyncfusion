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
        // GET: Column
        public ActionResult Column()
        {
            List<ColumnChartData> chartData = new List<ColumnChartData>
            {
                new ColumnChartData { x= "Cartago", yValue= 46, yValue1=37, yValue2=38 },
                new ColumnChartData { x= "Heredia", yValue= 27, yValue1=23, yValue2=17 },
                new ColumnChartData { x= "San José", yValue= 26, yValue1=18, yValue2=26 }
            };
            ViewBag.dataSource = chartData;

            ViewBag.Line = new
            {
                width = 0.0001
            };
            ViewBag.Style = new
            {
                color = "transparent"
            };
            ViewBag.Marker = new ChartMarkerSettings
            {
                DataLabel = new ChartDataLabelSettings
                {
                    Visible = true,
                    Position = LabelPosition.Top,
                    Font = new { fontWeight = "600", color = "#ffffff" }
                }
            };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class ColumnChartData
        {
            public string x;
            public double yValue;
            public double yValue1;
            public double yValue2;
        }
    }
}