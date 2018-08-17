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
        // GET: Rendermode
        public ActionResult Rendermode()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewBag.border = new { width = 0 };
            string[] xlabels = new string[11] { "Channel Isl", "Denmark", "Estonia", "Finland",
                "Iceland", "Ireland", "Latvia", "Lithuania", "Norway", "Sweden", "UK"};
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[10] { "1965-1970", "1970-1975", "1975-1980", "1980-1985", "1985-1990",
                "1990-1995", "1995-2000", "2000-2005", "2005-2010", "2010-2015"};
            ViewBag.yLabels = yLabels;    
            ViewBag.dataSource = new HeatMapData().GetRendermodeData();
            return View();
        }
    }
}