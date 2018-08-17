using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;
using System.ComponentModel.DataAnnotations;
using Syncfusion.EJ2.Calendars;

namespace EJ2MVCSampleBrowser.Controllers
{
    public class DateRangePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public string Id { get; set; }
    }
    public partial class DateRangePickerController : Controller
    {
        public ActionResult DateRangePickerFor()
        {
            // GET: DateRangePickerFor
            DateRangePickerModel daterangepicker = new DateRangePickerModel();
            daterangepicker.Id = "DateRangePickerFor";
            DateRangePicker daterange = new DateRangePicker();
            daterange.StartDate = new DateTime(2018, 05, 23, 10, 05, 05);
            daterange.EndDate = new DateTime(2018, 06, 03, 15, 10, 35);
            ViewData["daterange"] = daterange;
            return View(new DateRangePickerModel());
        }
        [HttpPost]
        public ActionResult DateRangePickerFor(DateRangePickerModel model)
        {
            DateRangePickerModel daterangepicker = new DateRangePickerModel();
            daterangepicker.Id = "DateRangePickerFor";
            DateRangePicker daterange = new DateRangePicker();
            daterange.StartDate = new DateTime(2018, 05, 23, 10, 05, 05);
            daterange.EndDate = new DateTime(2018, 06, 03, 15, 10, 35);
            ViewData["daterange"] = daterange;
            return View(model);
        }
    }
}