using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET: Shapes
        public ActionResult Shapes()
        {
             
            List<Shape> shape = new List<Shape>();
            shape.Add(new Shape() { shapeName = "Basic Shapes", shapeId = "Basic" });
            shape.Add(new Shape() { shapeName = "Flow Shapes", shapeId = "Flow" });
            shape.Add(new Shape() { shapeName = "BPMN Shapes", shapeId = "Bpmn" });

            ViewBag.shape = shape;
           
            return View();
        }
    }

    public class Shape
    {
        public string shapeName;
        public string shapeId;
    }

}