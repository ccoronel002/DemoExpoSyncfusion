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
        // GET: CategoryAxis
        public ActionResult CategoryAxis()
        {          
            List<CategoryData> chartData = new List<CategoryData>
            {
                new CategoryData { x = "GER", y = 72 },
                new CategoryData { x = "RUS", y = 103.1 },
                new CategoryData { x = "BRZ", y = 139.1 },
                new CategoryData { x = "IND", y = 462.1 },
                new CategoryData { x = "CHN", y = 721.4 },
                new CategoryData { x = "USA", y = 286.9 },
                new CategoryData { x = "GBR", y = 115.1 },
                new CategoryData { x = "NGR", y = 97.2 },
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
                    Font = new
                    {
                        fontWeight = "600",
                        color = "#ffffff"
                    }
                }
            };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();

          
        }
        public class CategoryData
        {
            public string x;
            public double y;
        }
    }
}