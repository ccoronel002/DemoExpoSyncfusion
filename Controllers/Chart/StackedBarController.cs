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
        // GET: StackedBar
        public ActionResult StackedBar()
        {
            List<StackedBarChartData> chartData = new List<StackedBarChartData>
            {
                new StackedBarChartData { x= "Jan", y= 6 },
                new StackedBarChartData { x= "Feb", y= 8 },
                new StackedBarChartData { x= "Mar", y= 12 },
                new StackedBarChartData { x= "Apr", y= 15.5 },
                new StackedBarChartData { x= "May", y= 20 },
                new StackedBarChartData { x= "Jun", y= 24 }
            };
            ViewBag.dataSource = chartData;
            List<StackedBarChartData> chartData1 = new List<StackedBarChartData>
            {
                new StackedBarChartData { x= "Jan", y= 6 },
                new StackedBarChartData { x= "Feb", y= 8 },
                new StackedBarChartData { x= "Mar", y= 11 },
                new StackedBarChartData { x= "Apr", y= 16 },
                new StackedBarChartData { x= "May", y= 21 },
                new StackedBarChartData { x= "Jun", y= 25 }
            };
            ViewBag.dataSource1 = chartData1;
            List<StackedBarChartData> chartData2 = new List<StackedBarChartData>
            {
                new StackedBarChartData { x= "Jan", y= -1 },
                new StackedBarChartData { x= "Feb", y= -1.5 },
                new StackedBarChartData { x= "Mar", y= -2 },
                new StackedBarChartData { x= "Apr", y= -2.5 },
                new StackedBarChartData { x= "May", y= -3 },
                new StackedBarChartData { x= "Jun", y= -3.5 }
            };
            ViewBag.dataSource2 = chartData2;
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class StackedBarChartData
        {
            public string x;
            public double y;
        }
    }
}