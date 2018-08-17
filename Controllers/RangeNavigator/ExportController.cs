using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.RangeNavigator
{
    public partial class RangeNavigatorController : Controller
    {
        // GET: Export
        public ActionResult Export()
        {
            ViewBag.data = new string[] { "JPEG", "PNG", "SVG", "PDF" };
            ViewBag.line = new { width = 0.00001, color = "transparent" };
            ViewBag.border = new ChartBorder { Width = 0.00001 };
            ViewBag.Cross = new { enable = true };
            ViewBag.lineWidth = new { width = 0.00001 };
            return View();
        }
    }
}