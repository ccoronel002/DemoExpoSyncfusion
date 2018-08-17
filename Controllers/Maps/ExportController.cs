﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Projection
        public ActionResult Export()
        {
            ViewBag.shapeData = this.WorldMap();
            ViewBag.dataSource = this.getUNOData();
            ViewBag.format = new string[] { "JPEG", "PNG", "SVG", "PDF" };

            return View();
        }
    }

}