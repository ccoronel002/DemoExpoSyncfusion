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
        // GET: WindRose
        public ActionResult WindRose()
        {
            List<PolarWindRoseData> data = new List<PolarWindRoseData>
            {
                  new PolarWindRoseData { x= "N", y= 1, y1= 0.8, y2= 0.8, y3= 0.3, y4= 0.2, y5= 0.2 },
                  new PolarWindRoseData { x= "NNE", y= 0.9, y1= 0.7, y2= 0.7, y3= 0.3, y4= 0.2, y5= 0.2 },
                  new PolarWindRoseData { x= "NE", y= 0.7, y1= 0.8, y2= 0.5, y3= 1.1, y4= 1.2, y5= 0.5 },
                  new PolarWindRoseData { x= "ENE", y= 0.9, y1= 1, y2= 0.4, y3= 0.9, y4= 1, y5= 0.4 },
                  new PolarWindRoseData { x= "E", y= 0.9, y1= 0.6, y2= 0.9, y3= 0.5, y4= 0.7, y5= 0.4 },
                  new PolarWindRoseData { x= "ESE", y= 0.8, y1= 0.5, y2= 0.7, y3= 0.3, y4= 0.8, y5= 0.3 },
                  new PolarWindRoseData { x= "SE", y= 0.7, y1= 0.4, y2= 0.6, y3= 0.5, y4= 0.5, y5= 0.3 },
                  new PolarWindRoseData { x= "SSE", y= 1.4, y1= 0.4, y2= 0.5, y3= 0.4, y4= 0.6, y5= 0.2 },
                  new PolarWindRoseData { x= "S", y= 2, y1= 1.2, y2= 0.6, y3= 0.6, y4= 0.4, y5= 0.4 },
                  new PolarWindRoseData { x= "SSW", y= 2, y1= 2.5, y2= 2, y3= 1, y4= 0.5, y5= 0.3 },
                  new PolarWindRoseData { x= "SW", y= 2.2, y1= 2, y2= 1.8, y3= 1, y4= 0.4, y5= 0.2 },
                  new PolarWindRoseData { x= "WSW", y= 1.8, y1= 1.1, y2= 0.8, y3= 0.1, y4= 0.4, y5= 0.2 },
                  new PolarWindRoseData { x= "W", y= 1.6, y1= 1.8, y2= 2.1, y3= 1, y4= 0.4, y5= 0.4 },
                  new PolarWindRoseData { x= "WNW", y= 1.2, y1= 1.2, y2= 1.5, y3= 1.3, y4= 1.1, y5= 1.2 },
                  new PolarWindRoseData { x= "NW", y= 2, y1= 2.5, y2= 2, y3= 1, y4= 0.2, y5= 0.7 },
                  new PolarWindRoseData { x= "NNW", y= 1.8, y1= 1.1, y2= 0.8, y3= 0.1, y4= 0.4, y5= 0.2 }
            };
            ViewBag.dataSource = data;
            ViewBag.border = new ChartBorder { Width = 1, Color = "white" };
            ViewBag.data = new string[] {"Polar", "Radar"};
            return View();
        }
        public class PolarWindRoseData
        {
            public string x;
            public double y;
            public double y1;
            public double y2;
            public double y3;
            public double y4;
            public double y5;
        }
    }
}