﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: InversedAxis
        public ActionResult InversedAxis()
        {
            
            List<InversedAxisChartData> chartData = new List<InversedAxisChartData>
            {
                 new InversedAxisChartData { x = "2008", y = 15.1 },
                 new InversedAxisChartData { x = "2009", y = 16 },
                 new InversedAxisChartData { x = "2010", y = 21.4 },
                 new InversedAxisChartData { x = "2011", y = 18 },
                 new InversedAxisChartData { x = "2012", y = 16.2 },
                 new InversedAxisChartData { x = "2013", y = 11 },
                 new InversedAxisChartData { x = "2014", y = 7.6 },
                 new InversedAxisChartData { x = "2015", y = 1.5 }
            };
            ViewBag.dataSource = chartData;
            ViewBag.gridlines = new { width = 0.00001 };
            ViewBag.linestyle = new { width = 0.00001 };
            ViewBag.ticklines = new { width = 0.00001 };
            ViewBag.labelstyle = new { color = "transparent" };
            ViewBag.marker = new ChartMarkerSettings
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
        public class InversedAxisChartData
        {
            public string x;
            public double y;
        }
    }
}