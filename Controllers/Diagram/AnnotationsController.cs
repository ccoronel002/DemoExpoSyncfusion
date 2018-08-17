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
        // GET: Annotations
        public ActionResult Annotations()
        {
            List<DiagramNode> nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Industry Competitors" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Potential Entrants" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Suppliers" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Substitutes" });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Buyers" });

            nodes.Add(new DiagramNode() { Id = "industry",  OffsetX = 280, OffsetY = 250 , Annotations = Node1 });
            nodes.Add(new DiagramNode() { Id = "potential", OffsetX = 280, OffsetY = 110, Annotations = Node2 });
            nodes.Add(new DiagramNode() { Id = "suplier", OffsetX = 90, OffsetY = 250 , Annotations = Node3 });
            nodes.Add(new DiagramNode() { Id = "substitutes", OffsetX = 280, OffsetY = 390, Annotations = Node4 });
            nodes.Add(new DiagramNode() { Id = "buyers", OffsetX = 470, OffsetY = 250, Annotations = Node5 });
            ViewBag.nodes = nodes;

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "potential", TargetID = "industry", Type = Segments.Orthogonal});
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "suplier", TargetID = "industry", Type = Segments.Orthogonal });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "substitutes", TargetID = "industry", Type = Segments.Orthogonal });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "buyers", TargetID = "industry", Type = Segments.Orthogonal });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "potential", TargetID = "buyers", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None} });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "buyers", TargetID = "substitutes", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            Connectors.Add(new DiagramConnector() { Id = "connector7", TargetID = "suplier", SourceID = "substitutes", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });
            Connectors.Add(new DiagramConnector() { Id = "connector8", SourceID = "suplier", TargetID = "potential", Type = Segments.Orthogonal, TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None } });

            List<Font> font = new List<Font>();
            font.Add(new Font() { type = "Arial", text = "Arial" });
            font.Add(new Font() { type = "Aharoni", text = "Aharoni" });
            font.Add(new Font() { type = "Bell MT", text = "Bell MT" });
            font.Add(new Font() { type = "Fantasy", text = "Fantasy" });
            font.Add(new Font() { type = "Times New Roman", text = "Times New Roman" });
            font.Add(new Font() { type = "Segoe UI", text = "Segoe UI" });
            font.Add(new Font() { type = "Verdana", text = "Verdana" });

            ViewBag.font = font;

            ViewBag.connectors = Connectors;
            return View();
        }
    }

    public class Font
    {
        public string type;
        public string text;
    }
}