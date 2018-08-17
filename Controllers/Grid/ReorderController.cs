﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
namespace EJ2MVCSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        // GET: Reorder
        public ActionResult Reorder()
        {
            var DataSource = EmployeeView.GetAllRecords();
            ViewBag.dataSource = DataSource;
            List<object> dd = new List<object>();
            dd.Add(new { text = "Employee ID", value = "EmployeeID" });
            dd.Add(new { text = "Name", value = "FirstName" });
            dd.Add(new { text = "Title", value = "Title" });
            dd.Add(new { text = "Hire Date", value = "HireDate" });
            ViewBag.columns = dd;
            List<object> index = new List<object>();
            index.Add(new { text = "1", value = "0" });
            index.Add(new { text = "2", value = "1" });
            index.Add(new { text = "3", value = "2" });
            index.Add(new { text = "4", value = "3" });
            ViewBag.index = index;
            return View();
        }
    }
}