﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Tooltip
        public ActionResult Tooltip()
        {
            ViewBag.ShapeData = this.getWorldMap();
            ViewBag.DataSource = this.getWorldCup();
            List<MapsColorMapping> colorMapping = new List<MapsColorMapping>();
            colorMapping.Add(new MapsColorMapping{Value = "1", Color = "#b3daff", Label = null});
            colorMapping.Add(new MapsColorMapping{Value = "2", Color = "#80c1ff", Label = null});
            colorMapping.Add(new MapsColorMapping{Value = "3", Color = "#1a90ff", Label = null});
            colorMapping.Add(new MapsColorMapping{Value = "7", Color = "#005cb3", Label = null});
            ViewBag.ColorMapping = colorMapping;
            return View();
        }

        public object getWorldMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/WorldMap.json")));
            return world;
        }

        public object getWorldCup()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/WorldCup.json")));
            return data["DataSource"];
        }
    }
}