﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Toast
{
    public partial class ToastController : Controller
    {
        // GET: Types
        public ActionResult Position()
        {
            ViewBag.data = new Position().Positions();
            return View();
        }
    }
}