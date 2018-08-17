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
        // GET: AreaEmptyPoints
        public ActionResult AreaEmptyPoints()
        {
            List<AreaEmptyChartData> chartData = new List<AreaEmptyChartData>
            {
                new AreaEmptyChartData { x= "2002", y= 2 },
                new AreaEmptyChartData { x= "2003", y= 1.7 },
                new AreaEmptyChartData { x= "2004", y= 1.8 },
                new AreaEmptyChartData { x= "2005", y= 2.1 },
                new AreaEmptyChartData { x= "2006", y= 2.3 },
                new AreaEmptyChartData { x= "2007", y= 1.7 },
                new AreaEmptyChartData { x= "2008", y= 1.5 },
                new AreaEmptyChartData { x= "2009", y= 1.8 },
                new AreaEmptyChartData  { x= "2010", y= 2 },
                new AreaEmptyChartData { x= "2011", y= 3.1 }
            };
            ViewBag.dataSource = chartData;
            List<AreaEmptyChartData> chartData1 = new List<AreaEmptyChartData>
            {
                new AreaEmptyChartData { x= "2002", y= 2.2 },
                new AreaEmptyChartData { x= "2003", y= 3.4 },
                new AreaEmptyChartData { x= "2004", y= 2.8 },
                new AreaEmptyChartData { x= "2005", },
                new AreaEmptyChartData { x= "2006", },
                new AreaEmptyChartData { x= "2007", y= 2.5 },
                new AreaEmptyChartData { x= "2008", y= 2.9 },
                new AreaEmptyChartData { x= "2009", y= 3.8 },
                new AreaEmptyChartData  { x= "2010", y= 1.4 },
                new AreaEmptyChartData { x= "2011", y= 3.1 }
            };
            ViewBag.dataSource1 = chartData1;
            ViewBag.gridlines = new { width = 0.00001 };
            ViewBag.ticklines = new { width = 0.00001 };
            ViewBag.linestyle = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class AreaEmptyChartData
        {
            public string x;
            public double y;
        }
    }
}