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
        public ActionResult Candle()
        {
            List<ChartStripLine> yAxisStripline = new List<ChartStripLine>();

            ChartStripLine ystripline1 = new ChartStripLine();
            ystripline1.End = "1300000000";
            ystripline1.Text = "";
            ystripline1.StartFromAxis = true;
            ystripline1.Color = "black";
            ystripline1.Opacity = 0.03;
            ystripline1.ZIndex = ZIndex.Behind;
            ystripline1.Visible = true;
            yAxisStripline.Add(ystripline1);
            ViewBag.yAxisStripLine = yAxisStripline;

            ViewBag.chartBorder = new ChartBorder { Color = "transparent" };
            ViewBag.crosshairTooltip= new { enable=  true };
            ViewBag.majorGridLines= new { width= 0.00001 };
            ViewBag.lineStyle = new { width = 0.00001 };
            ViewBag.animation = new ChartAnimation { Enable =true};

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