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
        // GET: RTL
        public ActionResult RTL()
        {
            ViewBag.lineWidth = new { width = 0.00001 };
            ViewBag.border = new ChartBorder { Width = 0.00001 };
            ViewBag.Cross = new { enable=true };
            return View();
        }
    }
}