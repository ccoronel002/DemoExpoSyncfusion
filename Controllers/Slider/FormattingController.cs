﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SliderController : Controller
    {
        public ActionResult Formatting()
        {
            ViewBag.currencyValue = new int[] { 20, 80 };
            ViewBag.kilometerValue = new int[] { 1100, 1850 };
            ViewBag.timeValue = new decimal[] { 1373697000000, 1373718600000 };
            return View();
        }
    }
}
