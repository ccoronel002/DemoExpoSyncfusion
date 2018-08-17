﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.RangeNavigator
{
    public partial class RangeNavigatorController : Controller
    {
        // GET: Print
        public ActionResult Print()
        {
            ViewBag.lineWidth = new { width = 0.00001 };
            ViewBag.border = new { width = 0.0001 };
            ViewBag.animation = new { enable = false };
            return View();
        }
    }
}