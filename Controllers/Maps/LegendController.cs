﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Legend
        public ActionResult Legend()
        {
            ViewBag.shapeData = this.GetWorldMap();
            ViewBag.data = this.getPopulation();
            return View();
        }

        public object getPopulation() {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/PopulationDensity.js"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}