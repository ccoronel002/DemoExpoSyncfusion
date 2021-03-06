﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.PivotView;
using EJ2MVCSampleBrowser.Models;


namespace EJ2MVCSampleBrowser.Controllers.PivotView
{
    public partial class PivotViewController : Controller
    {

        public ActionResult Aggregation()
        {
            ViewBag.data = new PivotViewData().GetrenewableEnergy();
            ViewBag.drilledMembers = new string[] { "Biomass", "Free Energy" };
            return View();
        }
    }
}
