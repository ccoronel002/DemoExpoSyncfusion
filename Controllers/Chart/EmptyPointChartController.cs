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
        // GET: EmptyPointChart
        public ActionResult EmptyPointChart()
        {
            List<EmptyPointChartData> chartData = new List<EmptyPointChartData>
            {

                new EmptyPointChartData { xValue = "Rice",  yValue = 80   },
                new EmptyPointChartData { xValue = "Wheat", yValue = null },
                new EmptyPointChartData { xValue = "Oil",   yValue = 70   },
                new EmptyPointChartData { xValue = "Corn",  yValue = 60   },
                new EmptyPointChartData { xValue = "Gram",  yValue = null },
                new EmptyPointChartData { xValue = "Milk",  yValue = 70   },
                new EmptyPointChartData { xValue = "Peas",  yValue = 80   },
                new EmptyPointChartData { xValue = "Fruit", yValue = 60   },
                new EmptyPointChartData { xValue = "Butter",yValue = null },

            };
            ViewBag.dataSource = chartData;
            ViewBag.marker = new ChartMarkerSettings { Visible = true, Width = 10, Height = 10 };
            ViewBag.emptyPointSettings = new ChartEmptyPointSettings
            {
                Fill = "#e6e6e6",
            };
            ViewBag.border = new ChartBorder { Width = 0.00001 };
            ViewBag.data = new string[] { "Column", "Area", "Spline" };
            ViewBag.data1 = new string[] { "Gap", "Drop", "Average", "Zero" };
            return View();
        }
        public class EmptyPointChartData
        {
            public string xValue;
            public Nullable<double> yValue;
        }
    }
}