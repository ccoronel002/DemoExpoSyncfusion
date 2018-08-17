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

        public ActionResult Filtering()
        {
            ViewBag.data = new PivotViewData().GetPivot_Data();
            ViewBag.typeData = new string[] { "Include", "Exclude" }; ;
            ViewBag.fieldsData = new string[] { "Country", "Products", "Year" };
            return View();
        }
    }
}
