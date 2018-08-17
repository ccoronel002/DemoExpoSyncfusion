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
        // GET: SmartAxisLabels
        public ActionResult SmartAxisLabels()
        {
            List<SmartAxisLabelsChartData> chartData = new List<SmartAxisLabelsChartData>
            {
                new SmartAxisLabelsChartData { xValue = "South Korea",  yValue = 39 },
                new SmartAxisLabelsChartData { xValue = "India",        yValue = 61 },
                new SmartAxisLabelsChartData { xValue = "Pakistan",     yValue = 20 },
                new SmartAxisLabelsChartData { xValue = "Germany",      yValue = 65 },
                new SmartAxisLabelsChartData { xValue = "Australia",    yValue = 16 },
                new SmartAxisLabelsChartData { xValue = "Italy",        yValue = 29 },
                new SmartAxisLabelsChartData { xValue = "France",       yValue = 45 },
                new SmartAxisLabelsChartData { xValue = "Saudi Arabia", yValue = 10 },
                new SmartAxisLabelsChartData { xValue = "Russia",       yValue = 41 },
                new SmartAxisLabelsChartData { xValue = "Mexico",       yValue = 31 },
                new SmartAxisLabelsChartData { xValue = "Brazil",       yValue = 76 },
                new SmartAxisLabelsChartData { xValue = "China",        yValue = 51 }

            };
            ViewBag.dataSource = chartData;
            ViewBag.data = new string[] { "Hide", "Trim", "Wrap", "MultipleRows", "Rotate45", "Rotate90", "None" };
            ViewBag.data1 = new string[] { "None", "Hide", "Shift" };
            ViewBag.data2 = new string[] { "Outside", "Inside" };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.000001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.labelStyle = new { color = "transparent" };
            ViewBag.marker = new ChartMarkerSettings
             {
                DataLabel = new ChartDataLabelSettings
                {
                    Visible = true,
                        Position = LabelPosition.Top,
                        Font = new { fontWeight= "600", color = "#ffffff" }
                }
            };
           ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
        public class SmartAxisLabelsChartData
        {
            public string xValue;
            public double yValue;
        }
    }
}