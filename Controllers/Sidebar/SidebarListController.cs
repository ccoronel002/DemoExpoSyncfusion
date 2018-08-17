﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class SidebarController : Controller
    {
        // GET: SidebarList
        public ActionResult SidebarList()
        {
            List<object> dataList = new List<object>();
            dataList.Add(new { text = "Home" });
            dataList.Add(new { text = "About" });
            dataList.Add(new { text = "Careers" });
            dataList.Add(new { text = "FAQs" });
            dataList.Add(new { text = "Blog" });
            dataList.Add(new { text = "Uses" });
            dataList.Add(new { text = "Contact" });
            ViewBag.dataSource = dataList;
            return View();
        }
    }
}