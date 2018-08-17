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
        // GET: Connector
        public ActionResult Connector()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Promotion" });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Lead" });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "Account" });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Information" });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "Security" });

            Nodes.Add(new DiagramNode()
            {
                Id = "node1",
                Annotations = Node1,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
        });
            Nodes.Add(new DiagramNode()
            {
                Id = "node2",
                Annotations = Node2,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node3",
                Annotations = Node3,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node4",
                Annotations = Node4,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node5",
                Annotations = Node5,
                Style = new DiagramStrokeStyle() { StrokeColor = "#6f409f", StrokeWidth = 2 },
                Height = 35,
                Width = 80
            });
            Nodes.Add(new DiagramNode()
            {
                Id = "node6",
                ExcludeFromLayout = true
            });
            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector", SourceID = "node1", TargetID = "node2", });
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "node2", TargetID = "node3", SourcePortID = "port1", TargetPortID = "portin" });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "node2", TargetID = "node4", SourcePortID = "port2", TargetPortID = "portin" });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "node2", TargetID = "node5", SourcePortID = "port3", TargetPortID = "portin" });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "node6", TargetID = "node3", SourcePortID = "port4", TargetPortID = "portOut" });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "node6", TargetID = "node4", SourcePortID = "port5", TargetPortID = "portOut" });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "node6", TargetID = "node5", SourcePortID = "port6", TargetPortID = "portOut" });
            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;
            return View();
        }
    }

}