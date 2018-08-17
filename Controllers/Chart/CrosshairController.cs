using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Charts;

namespace EJ2MVCSampleBrowser.Controllers.Chart
{
    public partial class ChartController : Controller
    {
        // GET: Crosshair
        public ActionResult Crosshair()
        {

            ViewBag.Line = new
            {
                width = 0.0001
            };
            ViewBag.Style = new
            {
                color = "transparent"
            };
            ViewBag.Cross = new
            {
                enable = true
          };
            ViewBag.Marker = new ChartMarkerSettings
            {
               Visible = true
            };
            return View();
        }
    }
}