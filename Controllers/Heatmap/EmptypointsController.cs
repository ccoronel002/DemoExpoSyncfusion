﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: Emptypoints
        public ActionResult Emptypoints()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = 500,
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };
            ViewBag.border = new { width = 0, color= "white" };
            ViewBag.cellTextStyle = new { color = "white" };
            string[] xlabels = new string[11] { "2007", "2008", "2009", "2010", "2011",
                "2012", "2013", "2014", "2015", "2016", "2017"};
            ViewBag.xLabels = xlabels;
            ViewBag.xTitle = new { text = "XAxis" };
            string[] yLabels = new string[12] { "Jan", "Feb", "Mar", "Apr", "May",
                "Jun", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};
            ViewBag.yLabels = yLabels;
            ViewBag.yTitle = new { text = "YAxis" };
            int?[,] dataSource = new int?[,]
            {
                {8, 5, 2, 6, 8, 2, 9, 3, 7, 8, 7, 6},
                {5, null, 4, 9, 10, null, 11, 7, 3, 7, 8, null},
                {8, 7, 2, null, 5, 3, null, 2, 1, 8, null, 4},
                {10, 2, null, 4, 5, null, 1, 10, 5, 2, 1, null},
                {1, 2, 9, 4, null, 5, 1, null, 12, 1, null, 4},
                {4, null, 3, 5, 2, null, null, null, 5, null, 1, 3},
                {null, null, 4, 10, null, 5, 11, 2, 8, 1, null, 1},
                {1, 4, null, 4, 5, null, 1, 3, null, 1, null, 3},
                {null, 2, 1, 4, null, 5, 1, null, 2, 1, null, 2},
                {1, null, 4, null, null, 2, null, 5, 1, 5, 2, 1},
                {1, null, 2, 1, 5, null, null, null, 5, 2, 1, null}
            };
            ViewBag.dataSource = dataSource;

            return View();
        }
    }
}