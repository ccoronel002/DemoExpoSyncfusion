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
        // GET: NegativeStack
        public ActionResult NegativeStack()
        {
            List<NegativeStackChartData> chartData = new List<NegativeStackChartData>
            {
                    new NegativeStackChartData { x= "4.5", y= 31 },
                    new NegativeStackChartData { x= "4.8", y= 37 },
                    new NegativeStackChartData { x= "5.1", y= 49 },
                    new NegativeStackChartData { x= "5.4", y= 57 },
                    new NegativeStackChartData { x= "5.7", y= 63 },
                    new NegativeStackChartData { x= "6", y= 69 }
            };
            ViewBag.dataSource = chartData;
            List<NegativeStackChartData> chartData1 = new List<NegativeStackChartData>
            {
                new NegativeStackChartData { x= "4.5", y= -31, text= "31 KG" },
                new NegativeStackChartData { x= "4.8", y= -39, text= "39 KG" },
                new NegativeStackChartData { x= "5.1", y= -52, text= "52 KG" },
                new NegativeStackChartData { x= "5.4", y= -64, text= "64 KG" },
                new NegativeStackChartData { x= "5.7", y= -70, text= "70 KG" },
                new NegativeStackChartData { x= "6", y= -74, text= "74 KG" }
            };
            ViewBag.dataSource1 = chartData1;
            ViewBag.marker = new ChartMarkerSettings
            {
                DataLabel = new ChartDataLabelSettings
                {
                    Visible = true,
                    Position = LabelPosition.Top,
                    Font = new { fontWeight = "600", color = "#ffffff" }
                }
            };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.minorGridLines = new { width = 0.00001 };
            ViewBag.minorTickLines = new { width = 0.00001 };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.labelStyle = new {
                color = "transparent"
            };
            return View();
        }
        public class NegativeStackChartData
        {
            public string x;
            public double y;
            public string text;
        }
    }
}