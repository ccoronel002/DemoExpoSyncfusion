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
        // GET: Modal
        public ActionResult Modal()
        {
            List<DialogDialogButton> buttons = new List<DialogDialogButton>() { };
            buttons.Add(new DialogDialogButton() { Click = "dlgButtonClick", ButtonModel = new ModalButtonModel() { content = "OK", isPrimary =true } });
            ViewBag.modalbutton = buttons;
            return View();
        }
    }

    public class ModalButtonModel
    {
        public string content { get; set; }
        public bool isPrimary { get; set; }
    }
}