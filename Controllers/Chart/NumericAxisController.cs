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
        // GET: NumericAxis
        public ActionResult NumericAxis()
        {
            List<DoubleAxisData> chartData = new List<DoubleAxisData>
            {
                new DoubleAxisData { xValue = 16, yValue1 = 2, yValue2= 7},
                new DoubleAxisData { xValue = 17, yValue1 = 14, yValue2 = 7 },
                new DoubleAxisData { xValue = 18, yValue1 = 7, yValue2 = 11 },
                new DoubleAxisData { xValue = 19, yValue1 = 7, yValue2 = 8 },
                new DoubleAxisData { xValue = 20, yValue1 = 10, yValue2 = 24 },
                            };
            ViewBag.dataSource = chartData;
            ViewBag.labelStyle= new {
                color= "transparent"
            };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.marker = new ChartMarkerSettings
            {
                DataLabel = new ChartDataLabelSettings
                {
                    Visible = true,
                    Position = LabelPosition.Top,
                    Font = new { fontWeight = "600", color = "#ffffff" }
                }
            };
            return View();
        }
        public class DoubleAxisData
        {
            public double xValue;
            public double yValue1;
            public double yValue2;
        }
    }
}