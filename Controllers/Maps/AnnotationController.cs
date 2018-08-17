﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Annotation
        public ActionResult Annotation()
        {
            ViewBag.shapeData = this.getAnnotation();
            
            return View();
        }

        public object getAnnotation() {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/Africa_Continent.js"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
}