﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.ListView
{
    public partial class ListViewController : Controller
    {
        // GET: ListView
        public ActionResult GroupTemplate()
        {
            List<object> listdata = new List<object>();
            listdata.Add(new { Name = "WI-FI", content = "Disabled", id = "1", css = "wifi", category = "Wireless & networks", order = "0" });
            listdata.Add(new { Name = "Bluetooth", content = "Disabled", id = "2", css = "bluetooth", category = "Wireless & networks", order = "0" });
            listdata.Add(new { Name = "SIM cards", id = "3", css = "sim", category = "Wireless & networks", order = "0" });
            listdata.Add(new { Name = "Display", content = "Adaptive brightness is OFF", id = "4", css = "display", category = "Device", order = "1" });
            listdata.Add(new { Name = "Sound", content = "Ringer volume at 50%", id = "5", css = "sound", category = "Device", order = "1" });
            listdata.Add(new { Name = "Battery", content = "85%", id = "5", css = "battery", category = "Device", order = "1" });
            listdata.Add(new { Name = "Users", content = "Signed in as Albert", id = "6", css = "user", category = "Device", order = "1" });
            listdata.Add(new { Name = "Location", content = "ON / High accuracy", id = "7", css = "location", category = "Personal", order = "2" });
            listdata.Add(new { Name = "Security", id = "8", css = "security", category = "Personal", order = 2 });
            listdata.Add(new { Name = "Languages & input", content = "English (US)", id = "9", css = "language", category = "Personal", order = "2" });
            ViewBag.dataSource = listdata;
            return View();
        }
    }
}