﻿using EJ2MVCSampleBrowser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: ForeignKey
        public ActionResult ForeignKey()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            var ForeignData = Customer.GetAllRecords();
            ViewBag.dataSource2 = ForeignData;
            return View();
        }
    }
}