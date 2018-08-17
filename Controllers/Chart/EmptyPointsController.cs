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
        // GET: EmptyPoints
        public ActionResult EmptyPoints()
        {
            List<EmptyPointsChartData> chartData = new List<EmptyPointsChartData>
            {

                new EmptyPointsChartData { xValue = "Rice",  yValue = 80   },
                new EmptyPointsChartData { xValue = "Wheat", yValue = null },
                new EmptyPointsChartData { xValue = "Oil",   yValue = 70   },
                new EmptyPointsChartData { xValue = "Corn",  yValue = 60   },
                new EmptyPointsChartData { xValue = "Gram",  yValue = null },
                new EmptyPointsChartData { xValue = "Milk",  yValue = 70   },
                new EmptyPointsChartData { xValue = "Peas",  yValue = 80   },
                new EmptyPointsChartData { xValue = "Fruit", yValue = 60   },
                new EmptyPointsChartData { xValue = "Butter",yValue = null },            

            };
            ViewBag.dataSource = chartData;      
            ViewBag.mode = new string[] {"Drop", "Average", "Zero" };
            return View();
        }
        public class EmptyPointsChartData
        {
            public string xValue;
            public Nullable<double> yValue;
        }
    }
}