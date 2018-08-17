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
        // GET: StockData
        public ActionResult StockData()
        {
            ViewBag.lineWidth = new { width = 0.00001 };
            ViewBag.format = "${point.x}<br/>High : <b>${point.high}</b><br/>Low :" +
                "<b>${point.low}</b><br/>Open : <b>${point.open}</b><br/>Close : <b>${point.close}</b><br/>Volume : <b>${point.volume}</b>";
            ViewBag.border = new ChartBorder { Width = 1, Color= "whitesmoke" };
            ViewBag.Cross = new { enable = true };
            ViewBag.animation = new ChartAnimation { Enable = true };
            ViewBag.marker = new ChartMarkerSettings { Visible = true };
            ViewBag.margin = new ChartMargin { Top = 0};
            ViewBag.toolbaritems = new string[] { };

            List<RangeNavigatorPeriod> periods = new List<RangeNavigatorPeriod>();
            RangeNavigatorPeriod one = new RangeNavigatorPeriod();
            one.Text = "1M";
            one.IntervalType = RangeIntervalType.Months;
            one.Interval = 1;
            RangeNavigatorPeriod two = new RangeNavigatorPeriod();
            two.Text = "3M";
            two.IntervalType = RangeIntervalType.Months;
            two.Interval = 3;
            RangeNavigatorPeriod three = new RangeNavigatorPeriod();
            three.Text = "6M";
            three.IntervalType = RangeIntervalType.Months;
            three.Interval = 6;
            RangeNavigatorPeriod four = new RangeNavigatorPeriod();
            four.Text = "YTD";
            RangeNavigatorPeriod five = new RangeNavigatorPeriod();
            five.Text = "1Y";
            five.Interval = 1;
            RangeNavigatorPeriod six = new RangeNavigatorPeriod();
            six.Text = "2Y";
            six.Interval = 2;
            six.Selected = true;
            RangeNavigatorPeriod seven = new RangeNavigatorPeriod();
            seven.Text = "ALL";
            periods.Add(one);
            periods.Add(two);
            periods.Add(three);
            periods.Add(four);
            periods.Add(five);
            periods.Add(six);
            periods.Add(seven);
            ViewBag.periods = periods;
            return View();
        }
    }
}