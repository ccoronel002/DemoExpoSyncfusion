using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Heatmap
{
    public partial class HeatmapController : Controller
    {
        // GET: Inversed
        public ActionResult Largedata()
        {
            ViewBag.textStyle = new
            {
                size = "15px",
                fontWeight = "500",
                fontStyle = "Normal",
                fontFamily = "Segoe UI"
            };

            string[] yLabels = new string[24] { "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00",
                "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00",
                "22:00", "23:00", "24:00" };
            ViewBag.yLabels = yLabels;
            object border = new
            {
                width = '0'
            };
             ViewBag.border = border;
            ViewBag.dataSource = new HeatMapData().GetLargeData();
            return View();
        }
    }

    internal class Date
    {
        private int v1;
        private int v2;
        private int v3;

        public Date(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}