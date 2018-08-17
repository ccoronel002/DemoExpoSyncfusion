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
        // GET: Print
        public ActionResult Print()
        {
            List<PrintChartData> chartData = new List<PrintChartData>
            {
                new PrintChartData { xValue = "John",  yValue = 10000 },
                new PrintChartData { xValue = "Jake",  yValue = 12000 },
                new PrintChartData { xValue = "Peter", yValue = 18000 },
                new PrintChartData { xValue = "James", yValue = 11000 },
                new PrintChartData { xValue = "Mary",  yValue = 9700  }
            };
            ViewBag.dataSource = chartData;
            ViewBag.gridlines = new { width = 0.00001};
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class PrintChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}