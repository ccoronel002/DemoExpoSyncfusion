﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Syncfusion.Mvc.Pdf;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using System.IO;

namespace EJ2MVCSampleBrowser.Controllers.PDF
{
    public partial class PdfController : Controller
    {
        //
        // GET: /MergeDocuments/

        public ActionResult MergeDocuments()
        {
            ViewData["Error"] = "";
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult MergeDocuments(string InsideBrowser)
        {

            Stream stream1 = new FileStream(ResolveApplicationDataPath("Essential_Pdf.pdf"), FileMode.Open, FileAccess.Read);
            Stream stream2 = new FileStream(ResolveApplicationDataPath("Essential_XlsIO.pdf"), FileMode.Open, FileAccess.Read);

            //Load the documents as streams
            PdfLoadedDocument doc1 = new PdfLoadedDocument(stream1);
            PdfLoadedDocument doc2 = new PdfLoadedDocument(stream2);

            object[] dobj = { doc1, doc2 };
            PdfDocument doc = new PdfDocument();
            PdfDocument.Merge(doc, dobj);

            if (InsideBrowser == "Browser")
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Open);
            else
                return doc.ExportAsActionResult("sample.pdf", HttpContext.ApplicationInstance.Response, HttpReadType.Save);
        }

    }
}
