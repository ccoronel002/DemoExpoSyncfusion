﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Navigations;

namespace EJ2MVCSampleBrowser.Controllers.Toolbar
{
    public partial class ToolbarController : Controller
    {
        public ActionResult Alignment()
        {
            List<ToolbarItem> alignItems = new List<ToolbarItem>();
            alignItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-menu-icon tb-icons", TooltipText = "Menu" });
            alignItems.Add(new ToolbarItem { Template = "<div class='e-folder'><div class='e-folder-name'>Inbox(33)</div> <div class='e-mail-id'>user@example.com</div></div>", Align = ItemAlign.Center });
            alignItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-search-icon tb-icons", TooltipText = "Search", Align = ItemAlign.Right });
            alignItems.Add(new ToolbarItem { PrefixIcon = "e-tbar-settings-icon tb-icons", TooltipText = "Popup", Align = ItemAlign.Right });

            ViewBag.alignItems = alignItems;

            return View();
        }
    }

}