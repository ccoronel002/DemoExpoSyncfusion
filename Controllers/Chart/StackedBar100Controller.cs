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
        // GET: StackedBar100
        public ActionResult StackedBar100()
        {
            List<StackedBar100ChartData> chartData = new List<StackedBar100ChartData>
            {
                new StackedBar100ChartData { x= "Jan", y= 6 },
                new StackedBar100ChartData { x= "Feb", y= 8 },
                new StackedBar100ChartData { x= "Mar", y= 12 },
                new StackedBar100ChartData { x= "Apr", y= 15.5 },
                new StackedBar100ChartData { x= "May", y= 20 },
                new StackedBar100ChartData { x= "Jun", y= 24 }
            };
            ViewBag.dataSource = chartData;
            List<StackedBar100ChartData> chartData1 = new List<StackedBar100ChartData>
            {
                new StackedBar100ChartData { x= "Jan", y= 6 },
                new StackedBar100ChartData { x= "Feb", y= 8 },
                new StackedBar100ChartData { x= "Mar", y= 11 },
                new StackedBar100ChartData { x= "Apr", y= 16 },
                new StackedBar100ChartData { x= "May", y= 21 },
                new StackedBar100ChartData { x= "Jun", y= 25 }
            };
            ViewBag.dataSource1 = chartData1;
            List<StackedBar100ChartData> chartData2 = new List<StackedBar100ChartData>
            {
                new StackedBar100ChartData { x= "Jan", y= 1 },
                new StackedBar100ChartData { x= "Feb", y= 1.5 },
                new StackedBar100ChartData { x= "Mar", y= 2 },
                new StackedBar100ChartData { x= "Apr", y= 2.5 },
                new StackedBar100ChartData { x= "May", y= 3 },
                new StackedBar100ChartData { x= "Jun", y= 3.5 }
            };
            ViewBag.dataSource2 = chartData2;
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class StackedBar100ChartData
        {
            public string x;
            public double y;
        }
    }
}