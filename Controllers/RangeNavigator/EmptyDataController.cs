using Syncfusion.EJ2.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EJ2MVCSampleBrowser.Controllers.RangeNavigator
{
    public partial class RangeNavigatorController : Controller
    {
        // GET: EmptyData
        public ActionResult EmptyData()
        {
            ViewBag.lineWidth = new RangeNavigatorMajorGridLines { Width = 0.00001 };
            ViewBag.lineWidth1 = new RangeNavigatorMajorTickLines { Width = 0.00001 };
            ViewBag.border = new ChartBorder{ Width = 0.00001 };
            ViewBag.Cross = new { enable = true };
            ViewBag.animation = new ChartAnimation { Enable = false };
            return View();
        }
    }
}