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
        // GET: Double
        public ActionResult Double()
        {
            ViewBag.lineWidth = new { width = 0.00001, color="transparent" };
            ViewBag.border = new ChartBorder { Width = 0.000001 };
            ViewBag.Cross = new
            {
                enable = true
            };
            ViewBag.animation = new ChartAnimation{ Enable = false };
            return View();
        }
    }
}