﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Popups;

namespace EJ2MVCSampleBrowser.Controllers.Dialog
{
    public partial class DialogController : Controller
    {
        // GET: AjaxContent
        public ActionResult AjaxContent()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new AjaxButtonModel() { content = "MORE DETAILS", isPrimary = true } });
            ViewBag.ajaxbutton = buttons;
            return View();
        }
    }
    public class AjaxButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}