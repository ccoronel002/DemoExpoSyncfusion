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
        // GET: Area
        public ActionResult Area()
        {
            List<AreaChartData> chartData = new List<AreaChartData>
            {
                new AreaChartData { xValue = new DateTime(2000, 01, 01), yValue = 4, yValue1 = 2.6 },
                new AreaChartData { xValue = new DateTime(2001, 01, 01), yValue = 3.0, yValue1 = 2.8 },
                new AreaChartData { xValue = new DateTime(2002, 01, 01), yValue = 3.8, yValue1 = 2.6 },
                new AreaChartData { xValue = new DateTime(2003, 01, 01), yValue = 3.4, yValue1 = 3 },
                new AreaChartData { xValue = new DateTime(2004, 01, 01), yValue = 3.2, yValue1 = 3.6 },
                new AreaChartData { xValue = new DateTime(2005, 01, 01), yValue = 3.9, yValue1 = 3 },
            };
            ViewBag.dataSource = chartData;
            ViewBag.gridlines = new { width = 0.00001 };
            ViewBag.ticklines = new { width = 0.00001 };
            ViewBag.linestyle = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class AreaChartData
        {
            public DateTime xValue;
            public double yValue;
            public double yValue1;
        }
    }
}