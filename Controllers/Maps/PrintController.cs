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
        public ActionResult Print()
        {
            ViewBag.shapeData = this.getusMap();
            ViewBag.data = this.getUsPopulation();
            return View();
        }
        public object getUsPopulation()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/UsPopulation.js"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }

}