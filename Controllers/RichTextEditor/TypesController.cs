﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{

    public partial class RichTextEditorController : Controller
    {
        // GET: /<controller>/
        public ActionResult Types()
        {
            List<Data> datasource = new List<Data>();
            datasource.Add(new Data() { text = "Expand", value = 1 });
            datasource.Add(new Data() { text = "Multi Row", value = 2 });
            ViewBag.data = datasource;

            ViewBag.value = @"<p>The rich text editor is WYSIWYG ('what you see is what you get') editor useful to create and edit content, and return the valid HTML markup or markdown of the content</p>

                <p><b> Toolbar </b></p>


                <ol>
                <li> <p> Toolbar contains commands to align the text, insert link, insert image, insert list, undo / redo operations, HTML view, etc </p></li>

                        <li> <p> Toolbar is fully customizable </p></li>

                        </ol>


                        <p><b> Links </b></p>

                        <ol>

                        <li><p> You can insert a hyperlink with its corresponding dialog</p> </li>

                            <li> <p> Attach a hyperlink to the displayed text. </p></li>
            
                                <li><p> Customize the quick toolbar based on the hyperlink </p> </li>
                
                                    </ol>
                

                                    <p><b> Validation </b></p>
                
                                    <ul><li><p> The editor’s content can be validated on form submission by applying validation rules and validation message </p></li></ul>
                        

                                            <p><b> Locale.</p></b></p>
                        
                                            <ul><li><p> The editor provides an option to localize its static strings to adapt the editor to a local language.</p></li></ul>
                                

                                                    <p><b> Image.</p></b></p>
                                
                                                    <ol>
                                
                                                    <li><p> Allows you to insert images from an online source as well as the local computer</p> </li>
                                
                                                    <li><p> You can upload an image</p></li>
                                    
                                                        <li> <p> Provides an option to customize quick toolbar for an image </p> </li>
                                        
                                                            </ol>
                                
                                                    <img alt = 'Logo' src = '/Content/images/RichTextEditor/RTEImage-Feather.png' />";
            ViewBag.items = new[] {"Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase", "|",
                "Formats", "Alignments", "OrderedList", "UnorderedList",
                "Outdent", "Indent", "|",
                "CreateLink", "Image", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };

            return View();
        }
    }
}
