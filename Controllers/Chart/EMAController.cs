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
        // GET: EMA
        public ActionResult EMA()
        {
            ViewBag.border = new { width = 0.001};
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            return View();
        }
    }
}