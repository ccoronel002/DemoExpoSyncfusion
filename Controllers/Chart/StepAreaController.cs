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
        // GET: StepArea
        public ActionResult StepArea()
        {
            List<StepAreaChartData> chartData = new List<StepAreaChartData>
            {
                new StepAreaChartData { xValue = 2000, yValue = 416, yValue1 = 180 },
                new StepAreaChartData { xValue = 2001, yValue = 490, yValue1 = 240 },
                new StepAreaChartData { xValue = 2002, yValue = 470, yValue1 = 370 },
                new StepAreaChartData { xValue = 2003, yValue = 500, yValue1 = 200 },
                new StepAreaChartData { xValue = 2004, yValue = 449, yValue1 = 229 },
                new StepAreaChartData { xValue = 2005, yValue = 470, yValue1 = 210 },
                new StepAreaChartData { xValue = 2006, yValue = 437, yValue1 = 337 },
                new StepAreaChartData { xValue = 2007, yValue = 458, yValue1 = 258 },
                new StepAreaChartData { xValue = 2008, yValue = 500, yValue1 = 300 },
                new StepAreaChartData { xValue = 2009, yValue = 473, yValue1 = 173 },
                new StepAreaChartData { xValue = 2010, yValue = 520, yValue1 = 220 },
                new StepAreaChartData { xValue = 2011, yValue = 509, yValue1 = 309 },
            };
            ViewBag.dataSource = chartData;
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class StepAreaChartData
        {
            public double xValue;
            public double yValue;
            public double yValue1;
        }
    }
}