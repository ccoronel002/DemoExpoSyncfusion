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
        // GET: StripLine
        public ActionResult StripLine()
        {
           
            List<StripLineChartData> chartData = new List<StripLineChartData>
            {
               new StripLineChartData { x = "Sun", y = 28 },
               new StripLineChartData { x = "Mon", y = 27 },
               new StripLineChartData { x = "Tue", y = 33 },
               new StripLineChartData { x = "Wed", y = 36 },
               new StripLineChartData { x = "Thu", y = 28 },
               new StripLineChartData { x = "Fri", y = 30 },
               new StripLineChartData { x = "Sat", y = 31 }
            };
            ViewBag.dataSource = chartData;
            ViewBag.marker = new ChartMarkerSettings
            {
                Visible = true,
                Width = 10,
                Height = 10,
                Border = new ChartBorder { Width = 2, Color = "#ffffff" },
                Fill = "#666666"
            };
            ViewBag.majorGridLines = new { width = 0.00001 };
            ViewBag.lineStyle = new { color = "#808080" };
            ViewBag.data = new string[] { "Vertical", "Horizontal" };
            List<ChartStripLine> xAxisStripline = new List<ChartStripLine>();

            ChartStripLine xstripline1 = new ChartStripLine();
            xstripline1.Start = "-1";
            xstripline1.End = "1.5";
            xstripline1.Text = "Winter";
            xstripline1.Color = "url(#winter)";
            xstripline1.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            xstripline1.Border = new ChartBorder { Width = 0.2 };
            xstripline1.Rotation = -90;
            xstripline1.Visible = true;

            ChartStripLine xstripline2 = new ChartStripLine();
            xstripline2.Start = "1.5";
            xstripline2.End = "3.5";
            xstripline2.Text = "Summer";
            xstripline2.Color = "url(#summer)";
            xstripline2.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            xstripline2.Border = new ChartBorder { Width = 0.2 };
            xstripline2.Rotation = -90;
            xstripline2.Visible = true;

            ChartStripLine xstripline3 = new ChartStripLine();
            xstripline3.Start = "3.5";
            xstripline3.End = "4.5";
            xstripline3.Text = "Spring";
            xstripline3.Color = "url(#spring)";
            xstripline3.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            xstripline3.Border = new ChartBorder { Width = 0.2 };
            xstripline3.Rotation = -90;
            xstripline3.Visible = true;

            ChartStripLine xstripline4 = new ChartStripLine();
            xstripline4.Start = "4.5";
            xstripline4.End = "5.5";
            xstripline4.Text = "Autumn";
            xstripline4.Color = "url(#autumn)";
            xstripline4.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            xstripline4.Border = new ChartBorder { Width = 0.2 };
            xstripline4.Rotation = -90;
            xstripline4.Visible = true;

            ChartStripLine xstripline5 = new ChartStripLine();
            xstripline5.Start = "5.5";
            xstripline5.End = "7";
            xstripline5.Text = "Winter";
            xstripline5.Color = "url(#winter)";
            xstripline5.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            xstripline5.Border = new ChartBorder { Width = 0.2 };
            xstripline5.Rotation = -90;
            xstripline5.Visible = true;

            xAxisStripline.Add(xstripline1);
            xAxisStripline.Add(xstripline2);
            xAxisStripline.Add(xstripline3);
            xAxisStripline.Add(xstripline4);
            xAxisStripline.Add(xstripline5);
            ViewBag.xAxisStripLine = xAxisStripline;

            List<ChartStripLine> yAxisStripline = new List<ChartStripLine>();
            ChartStripLine ystripline1 = new ChartStripLine();
            ystripline1.Start = "30";
            ystripline1.End = "40";
            ystripline1.Text = "High Temperature";
            ystripline1.Color = "#ff512f";
            ystripline1.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            ystripline1.Border = new ChartBorder { Width = 0.2 };
            ystripline1.Visible = false;

            ChartStripLine ystripline2 = new ChartStripLine();
            ystripline2.Start = "20";
            ystripline2.End = "30";
            ystripline2.Text = "Average Temperature";
            ystripline2.Color = "#fc902a";
            ystripline2.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            ystripline2.Border = new ChartBorder { Width = 0.2 };
            ystripline2.Visible = false;

            ChartStripLine ystripline3 = new ChartStripLine();
            ystripline3.Start = "10";
            ystripline3.End = "20";
            ystripline3.Text = "Low Temperature";
            ystripline3.Color = "#f9d423";
            ystripline3.TextStyle = new { size = "18px", color = "#ffffff", fontWeight = "600" };
            ystripline3.Border = new ChartBorder { Width = 0.2 };
            ystripline3.Visible = false;

            yAxisStripline.Add(ystripline1);
            yAxisStripline.Add(ystripline2);
            yAxisStripline.Add(ystripline3);
            ViewBag.yAxisStripLine = yAxisStripline;
            return View();
        }
        public class StripLineChartData
        {
            public string x;
            public double y;
        }
    }
}