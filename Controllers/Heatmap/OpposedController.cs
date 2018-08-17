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
        // GET: Inversed
        public ActionResult Opposed()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = 500,
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewBag.border = new { width = 0 };
            string[] xlabels = new string[11] {"2007", "2008", "2009", "2010", "2011",
                "2012", "2013", "2014", "2015", "2016", "2017"};
            ViewBag.xLabels = xlabels;
            string[] yLabels = new string[12] { "Jan", "Feb", "Mar", "Apr", "May",
                "Jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            ViewBag.yLabels = yLabels;
            ViewBag.dataSource = new HeatMapData().GetOpposedData();
            return View();
        }
    }
}