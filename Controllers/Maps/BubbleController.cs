﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: Bubble
        public ActionResult Bubble()
        {
            ViewBag.shapeData = this.GetWorldMap();
            MapsBubble bubble = new MapsBubble();
            bubble.Visible = true;
            bubble.ValuePath = "value";
            bubble.ColorValuePath = "color";
            bubble.MinRadius = 3;
            bubble.MaxRadius = 70;
            bubble.Opacity = 0.8;
            bubble.TooltipSettings = new MapsTooltipSettings{ Visible = true, ValuePath = "population", Template = "#template" };
            List<MapsBubble> bubbleSettings = new List<MapsBubble>();
            bubbleSettings.Add(bubble);
            ViewBag.bubbleSettings = bubbleSettings;
            return View();
        }
    }
}