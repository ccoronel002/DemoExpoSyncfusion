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
        // GET: Hilo
        public ActionResult HiloOpenClose()
        {
            ViewBag.line =new {
                width= 0.02,
            };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.majorTickLines = new { width = 0.00001 };
            ViewBag.crosshairTooltip = new { enable = true };
            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            List<RangeNavigatorPeriod> periods = new List<RangeNavigatorPeriod>();
            RangeNavigatorPeriod one = new RangeNavigatorPeriod();
            one.Text = "1M";
            one.IntervalType = RangeIntervalType.Months;
            one.Interval = 1;
            RangeNavigatorPeriod two = new RangeNavigatorPeriod();
            two.Text = "3M";
            two.IntervalType = RangeIntervalType.Months;
            two.Interval = 2;
            RangeNavigatorPeriod three = new RangeNavigatorPeriod();
            three.Text = "2Q";
            three.IntervalType = RangeIntervalType.Quarter;
            three.Interval = 2;
            RangeNavigatorPeriod four = new RangeNavigatorPeriod();
            four.Text = "1Y";
            four.Interval = 1;
            RangeNavigatorPeriod five = new RangeNavigatorPeriod();
            five.Text = "2Y";
            five.Interval = 2;
            five.Selected = true;
            RangeNavigatorPeriod six = new RangeNavigatorPeriod();
            six.Text = "YTD";
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