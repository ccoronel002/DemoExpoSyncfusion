﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Avatar
{
    public partial class AvatarController : Controller
    {
        public ActionResult Listview()
        {
            List<object> data = new List<object>();
            data.Add(new { text = "Robert", id = "s_01", avatar= "", pic= "pic04" });
            data.Add(new { text = "Nancy", id = "s_02", avatar= "N", pic= "" });
            data.Add(new { text = "John", id = "s_03", pic= "pic01", avatar= "" });
            data.Add(new { text = "Andrew", id = "s_04", avatar= "A", pic= "" });
            data.Add(new { text = "Michael", id = "s_05", pic= "pic02", avatar= "" });
            data.Add(new { text = "Steven", id = "s_06", pic= "pic03", avatar= "" });
            data.Add(new { text = "Margaret", id = "s_07", avatar= "M", pic= "" });
            ViewBag.dataSource = data;
            return View();
        }
    }

}