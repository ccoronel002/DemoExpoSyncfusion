﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: Arrayrow
        public ActionResult Palette()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = 500,
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewBag.border = new { width = 0 };
            string[] xlabels = new string[11] { "2005", "2006", "2007", "2008", "2009", "2010",
                "2011", "2012", "2013", "2014", "2015"};
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[8] { "Agriculture", "Energy", "Administration", "Health", "Interior",
                "Justice", "NASA", "Transportation"};
            ViewBag.yLabels = yLabels;
            ViewBag.dataSource = new HeatMapData().GetPaletteData();
            return View();
        }
    }
}