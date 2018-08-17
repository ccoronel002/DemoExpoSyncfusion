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
    public class TimePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public string Id { get; set; }
    }
    public partial class TimePickerController : Controller
    {
        public ActionResult TimePickerFor()
        {
            // GET: DatePickerFor
            TimePickerModel timepicker = new TimePickerModel();
            timepicker.Id = "TimePickerFor";
            TimePicker time = new TimePicker();
            time.Value = DateTime.Now;
            ViewData["time"] = time;
            return View(new TimePickerModel());
        }
        [HttpPost]
        public ActionResult TimePickerFor(TimePickerModel model)
        {
            TimePickerModel timepicker = new TimePickerModel();
            timepicker.Id = "TimePickerFor";
            TimePicker time = new TimePicker();
            ViewData["time"] = time;
            return View(model);
        }
    }
}