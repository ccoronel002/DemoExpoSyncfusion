﻿using Syncfusion.EJ2.CircularGauge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.CircularGauge
{
    public partial class CircularGaugeController : Controller
    {
        // GET: Campass
        public ActionResult DirectionCompass()
        {

            // Pointers //
            List<CircularGaugePointer> pointers = new List<CircularGaugePointer>();
            CircularGaugePointer pointer1 = new CircularGaugePointer();
            pointer1.Value = 7;
            pointer1.Radius = "50%";
            pointer1.Color = "#f03e3e";
            pointer1.PointerWidth = 20;
            pointer1.Cap = new CircularGaugeCap{ Radius = 0 };
            pointer1.Animation = new CircularGaugeAnimation{ Enable = false };
            pointers.Add(pointer1);

            CircularGaugePointer pointer2 = new CircularGaugePointer();
            pointer2.Value = 3;
            pointer2.Radius = "50%";
            pointer2.Color = "#9E9E9E";
            pointer2.PointerWidth = 20;
            pointer2.Cap = new CircularGaugeCap { Radius = 0 };
            pointer2.Animation = new CircularGaugeAnimation { Enable = false };
            pointers.Add(pointer2);
            ViewBag.Pointers = pointers;

            // Ranges //
            List<CircularGaugeRange> ranges = new List<CircularGaugeRange>();
            CircularGaugeRange range1 = new CircularGaugeRange();
            range1.Start = 7;
            range1.End = 7  ;
            range1.Color = "#f03e3e";
            ranges.Add(range1);
            ViewBag.Ranges = ranges;
            return View();
        }
    }
}