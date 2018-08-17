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
    public class DateTimePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public string Id { get; set; }
    }
    public partial class DateTimePickerController : Controller
    {
        public ActionResult DateTimePickerFor()
        {
            // GET: DateTimePickerFor
            DateTimePickerModel datetimepicker = new DateTimePickerModel();
            datetimepicker.Id = "DateTimePickerFor";
            DateTimePicker datetime = new DateTimePicker();
            datetime.Value = new DateTime(2018, 05, 23, 10, 30, 50);
            ViewData["dateTime"] = datetime;
            return View(new DateTimePickerModel());
        }
        [HttpPost]
        public ActionResult DateTimePickerFor(DateTimePickerModel model)
        {
            // GET: DateTimePickerFor
            DateTimePickerModel datetimepicker = new DateTimePickerModel();
            datetimepicker.Id = "DateTimePickerFor";
            DateTimePicker datetime = new DateTimePicker();
            ViewData["dateTime"] = datetime;
            return View(model);
        }
    }
}