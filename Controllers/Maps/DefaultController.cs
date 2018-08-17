﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Default
        public ActionResult Default()
        {                       
            List<DataSource> data = new List<DataSource>();
            data.Add(new DataSource("North America", "#71B081"));
            data.Add(new DataSource("South America", "#5A9A77"));
            data.Add(new DataSource("Africa", "#498770"));
            data.Add(new DataSource("Europe", "#39776C"));
            data.Add(new DataSource("Asia", "#266665"));
            data.Add(new DataSource("Australia", "#124F5E"));
            ViewBag.shapeData = this.GetWorldMap();
            ViewBag.dataSource = data;
            return View();
        }
        public object GetWorldMap()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/WorldMap.json"));
            return JsonConvert.DeserializeObject(allText, typeof(object));
        }
    }
    [Serializable]
    public class DataSource
    {
        public DataSource(string cont, string col)
        {
            this.continent = cont;
            this.color = col;
        }
        public string continent
        {
            get;
            set;
        }
        public string color
        {
            get;
            set;
        }        

    }

    public class marketData
    {
        public marketData(double lat, double lon, string name) {
            this.latitude = lat;
            this.longitude = lon;
            this.name = name;
        }
        public double latitude
        {
            get;set;
        }
        public double longitude
        {
            get;set;
        }
        public string name
        {
            get;set;
        }
    }
}