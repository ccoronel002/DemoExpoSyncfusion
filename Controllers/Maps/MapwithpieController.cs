﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using Syncfusion.EJ2.Maps;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Mapwithpie
        public ActionResult Mapwithpie()
        {
            ViewBag.shapeData = this.getWorldMap();
            List<MapsColorMapping> data = new List<MapsColorMapping>();
            data.Add(new MapsColorMapping { From = 1, To = 4, Color = "#634D6F", Label = "0-4 years" });
            data.Add(new MapsColorMapping { From = 5, To = 14, Color = "#B34D6D", Label = "5-14 years" });
            data.Add(new MapsColorMapping { From = 15, To = 59, Color = "#557C5C", Label = "15-59 years" });
            data.Add(new MapsColorMapping { From = 60, To = 64, Color = "#5E55E2", Label = "59-64 years" });
            ViewBag.colormapping = data;
            return View();
        }
    }
}