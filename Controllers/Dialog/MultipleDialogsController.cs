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
        // GET: MultipleDialog
        public ActionResult MultipleDialogs()
        {
            List<DialogDialogButton> button = new List<DialogDialogButton>() { };
            button.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new default1Button() { content = "Next", isPrimary = true } });
            ViewBag.default1Button = button;
            List<DialogDialogButton> button1 = new List<DialogDialogButton>() { };
            button1.Add(new DialogDialogButton() { Click = "dlg2ButtonClick", ButtonModel = new default2Button() { content = "Close", isPrimary = true } });
            ViewBag.default2Button = button1;
            return View();
        }
    }

    public class default1Button
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }
    public class default2Button
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }

    }
}