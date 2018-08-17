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
    public class DatePickerModel
    {
        [Required(ErrorMessage = "Value is required")]
        public string Id { get; set; }
    }
    public partial class DatePickerController : Controller
    {
        public ActionResult DatePickerFor()
        {
            // GET: DatePickerFor
            DatePickerModel datepicker = new DatePickerModel();
            datepicker.Id = "DatePickerFor";
            DatePicker date = new DatePicker();
            date.Value = DateTime.Now;
            ViewData["date"] = date;
            return View(new DatePickerModel());
        }
        [HttpPost]
        public ActionResult DatePickerFor(DatePickerModel model)
        {
            // GET: DatePickerFor
            DatePickerModel datepicker = new DatePickerModel();
            datepicker.Id = "DatePickerFor";
            DatePicker date = new DatePicker();
            ViewData["date"] = date;
            return View(model);
        }
    }
}