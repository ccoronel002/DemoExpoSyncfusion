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
        // GET: RoundedColumn
        public ActionResult RoundedColumn()
        {
            List<RoundedColumnChartData> chartData = new List<RoundedColumnChartData>
            {
                  new RoundedColumnChartData { x= "BGD", y= 106, text= "Bangaladesh" },
                  new RoundedColumnChartData { x= "BTN", y= 103, text= "Bhutn" },
                  new RoundedColumnChartData { x= "NPL", y= 198, text= "Nepal" },
                  new RoundedColumnChartData { x= "THA", y= 189, text= "Thiland" },
                  new RoundedColumnChartData { x= "MYS", y= 250, text= "Malaysia" }
            };
            ViewBag.dataSource = chartData;
            ViewBag.labelStyle= new { color=  "#ffffff" };
            ViewBag.labelStyle1 = new { color= "transparent" };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.cornerRadius = new ChartCornerRadius
            {
                BottomLeft = 10,
                BottomRight = 10,
                TopLeft = 10,
                TopRight = 10
            };
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
        public class RoundedColumnChartData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}