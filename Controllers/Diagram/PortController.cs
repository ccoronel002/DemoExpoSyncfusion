﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Diagrams;

namespace EJ2MVCSampleBrowser.Controllers.Diagram
{
    public partial class DiagramController : Controller
    {
        // GET= Port
        public ActionResult Port()
        {
            List<DiagramNodeAnnotation> Node1 = new List<DiagramNodeAnnotation>();
            Node1.Add(new DiagramNodeAnnotation() { Content = "Publisher", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13} });
            List<DiagramNodeAnnotation> Node2 = new List<DiagramNodeAnnotation>();
            Node2.Add(new DiagramNodeAnnotation() { Content = "Completed Book", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13 } });
            List<DiagramNodeAnnotation> Node3 = new List<DiagramNodeAnnotation>();
            Node3.Add(new DiagramNodeAnnotation() { Content = "1st Review", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13 } });
            List<DiagramNodeAnnotation> Node4 = new List<DiagramNodeAnnotation>();
            Node4.Add(new DiagramNodeAnnotation() { Content = "Legal Terms", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13 } });
            List<DiagramNodeAnnotation> Node5 = new List<DiagramNodeAnnotation>();
            Node5.Add(new DiagramNodeAnnotation() { Content = "2nd Review", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13 } });
            List<DiagramNodeAnnotation> Node6 = new List<DiagramNodeAnnotation>();
            Node6.Add(new DiagramNodeAnnotation() { Content = "Board", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13 } });
            List<DiagramNodeAnnotation> Node7 = new List<DiagramNodeAnnotation>();
            Node7.Add(new DiagramNodeAnnotation() { Content = "Approval", Style = new DiagramTextStyle() { Color = "Black", FontSize = 13 } });

            List<DiagramPort> ports1 = new List<DiagramPort>();
            ports1.Add(new CustomPort() { Id = "port1", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-1" } }, Offset = new DiagramPoint() { X = 0, Y = 0.5 } });
            ports1.Add(new CustomPort() { Id = "port2", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-1" } }, Offset = new DiagramPoint() { X = 1, Y = 0.5 } });
            ports1.Add(new CustomPort() { Id = "port3", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-2" } },  Offset = new DiagramPoint() { X = 0.25, Y = 1 } });
            ports1.Add(new CustomPort() { Id = "port4", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-2" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });
            ports1.Add(new CustomPort() { Id = "port5", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-3" } }, Offset = new DiagramPoint() { X = 0.75, Y = 1 } });

            List<DiagramPort> ports2 = new List<DiagramPort>();
            ports2.Add(new CustomPort() { Id = "port6", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-1" } }, Offset = new DiagramPoint() { X = 0, Y = 0.5 } });
            ports2.Add(new CustomPort() { Id = "port7", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-1" } }, Offset = new DiagramPoint() { X = 1, Y = 0.35 } });
            ports2.Add(new CustomPort() { Id = "port8", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-2" } }, Offset = new DiagramPoint() { X = 1, Y = 0.70 } });
            ports2.Add(new CustomPort() { Id = "port9", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-2" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });

            List<DiagramPort> ports3 = new List<DiagramPort>();
            ports3.Add(new CustomPort() { Id = "port10", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-1" } }, Offset = new DiagramPoint() { X = 0, Y = 0.5 } });
            ports3.Add(new CustomPort() { Id = "port11", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-1" } }, Offset = new DiagramPoint() { X = 0.5, Y = 0 } });
            ports3.Add(new CustomPort() { Id = "port12", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-2" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });

            List<DiagramPort> ports4 = new List<DiagramPort>();
            ports4.Add(new CustomPort() { Id = "port13", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-1" } }, Offset = new DiagramPoint() { X = 0, Y = 0.5 } });
            ports4.Add(new CustomPort() { Id = "port14", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-2" } }, Offset = new DiagramPoint() { X = 0.5, Y = 0 } });
            ports4.Add(new CustomPort() { Id = "port15", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-1" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });

           
            List<DiagramPort> ports5 = new List<DiagramPort>();
            ports5.Add(new CustomPort() { Id = "port16", AddInfo=new Dictionary<string, object>() { { "text", "Out-1" } }, Shape = PortShapes.Circle, text = "Out-1", Offset = new DiagramPoint() { X = 0, Y = 0.5 } });
            ports5.Add(new CustomPort() { Id = "port17", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-1" } }, Offset = new DiagramPoint() { X = 0.5, Y = 0 } });
            ports5.Add(new CustomPort() { Id = "port18", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-2" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });

            List<DiagramPort> ports6 = new List<DiagramPort>();
            ports6.Add(new CustomPort() { Id = "port19", AddInfo = new Dictionary<string, object>() { { "text", "In-1" } },Shape = PortShapes.Circle, text = "In-1", Offset = new DiagramPoint() { X = 0, Y = 0.35 } });
            ports6.Add(new CustomPort() { Id = "port20", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-1" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });

            List<DiagramPort> ports7 = new List<DiagramPort>();
            ports7.Add(new CustomPort() { Id = "port21", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "In-1" } }, Offset = new DiagramPoint() { X = 0.5, Y = 0 } });
            ports7.Add(new CustomPort() { Id = "port22", Shape = PortShapes.Circle, AddInfo = new Dictionary<string, object>() { { "text", "Out-1" } }, Offset = new DiagramPoint() { X = 0.5, Y = 1 } });

            List<DiagramNode> nodes = new List<DiagramNode>();
            nodes.Add(new NodePorts() { Id = "node1", OffsetX = 110, OffsetY = 100, Ports = ports1, Annotations = Node1 });
            nodes.Add(new NodePorts() { Id = "node2", OffsetX = 310, OffsetY = 100, Ports = ports2, Annotations = Node2 });
            nodes.Add(new NodePorts() { Id = "node3", OffsetX = 310, OffsetY = 200, Ports = ports3, Annotations = Node3 });
            nodes.Add(new NodePorts() { Id = "node4", OffsetX = 310, OffsetY = 300, Ports = ports4, Annotations = Node4 });
            nodes.Add(new NodePorts() { Id = "node5", OffsetX = 310, OffsetY = 400, Ports = ports5, Annotations = Node5 });
            nodes.Add(new NodePorts() { Id = "node6", OffsetX = 510, OffsetY = 100, Ports = ports6, Annotations = Node6 });
            nodes.Add(new NodePorts() { Id = "node7", OffsetX = 510, OffsetY = 200, Ports = ports7, Annotations = Node7 });

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "node1", SourcePortID = "port2", TargetPortID = "port6" ,TargetID = "node2" });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "node1", SourcePortID = "port4", TargetPortID = "port13", TargetID = "node4" });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "node2", SourcePortID = "port9", TargetPortID = "port11", TargetID = "node3" });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "node2", SourcePortID = "port7", TargetPortID = "port19", TargetID = "node6" });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "node3", SourcePortID = "port10", TargetPortID = "port5", TargetID = "node1" });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "node3", SourcePortID = "port12", TargetPortID = "port14", TargetID = "node4" });
            Connectors.Add(new DiagramConnector() { Id = "connector7", SourceID = "node4", SourcePortID = "port15", TargetPortID = "port17", TargetID = "node5" });
            Connectors.Add(new DiagramConnector() { Id = "connector8", SourceID = "node5", SourcePortID = "port18", TargetPortID = "port8", TargetID = "node2" });
            Connectors.Add(new DiagramConnector() { Id = "connector9", SourceID = "node5", SourcePortID = "port16", TargetPortID = "port3", TargetID = "node1" });
            Connectors.Add(new DiagramConnector() { Id = "connector10", SourceID = "node6", SourcePortID = "port20", TargetPortID = "port21", TargetID = "node7" });
            Connectors.Add(new DiagramConnector() { Id = "connector11", SourceID = "node7", SourcePortID = "port22", TargetPortID = "port1", TargetID = "node1" });

            List<Color> color = new List<Color>();
            color.Add(new Color() { text= "White", color= "white" });
            color.Add(new Color() { text= "#008080", color= "#008080" });
            color.Add(new Color() { text= "#E4B123", color= "#E4B123"});
            color.Add(new Color() { text= "#F05023", color= "#F05023" });
            color.Add(new Color() { text= "#3CB549", color= "#3CB549" });
            color.Add(new Color() { text= "#D572AD", color= "#D572AD" });
            color.Add(new Color() { text= "Goldenrod", color= "goldenrod" });
            color.Add(new Color() { text= "Black", color= "black" });
            color.Add(new Color() { text= "Indigo", color= "indigo" });
            color.Add(new Color() { text= "Chocolate", color= "chocolate" });
            color.Add(new Color() { text= "DarkGoldenRod", color= "darkgoldenrod" });
            color.Add(new Color() { text= "FireBrick", color= "firebrick" });
            color.Add(new Color() { text= "DarkRed", color= "darkred" });

            List<Shapee> shape = new List<Shapee>();
            shape.Add(new Shapee() { shape = "X", text = "X" });
            shape.Add(new Shapee() { shape = "Circle", text = "Circle" });
            shape.Add(new Shapee() { shape = "Square", text = "Square" });
            shape.Add(new Shapee() { shape = "Custom", text = "Custom" });

            List<PortVisibilityy> portvisibility = new List<PortVisibilityy>();
            portvisibility.Add(new PortVisibilityy() { text = "Visible", PortVisibility = 1 });
            portvisibility.Add(new PortVisibilityy() { text = "Hidden", PortVisibility = 2 });
            portvisibility.Add(new PortVisibilityy() { text = "Hover", PortVisibility = 4 });
            portvisibility.Add(new PortVisibilityy() { text = "Connect", PortVisibility = 8 });
            ViewBag.PortVisibility = portvisibility;


            ViewBag.shape = shape;
            ViewBag.color = color;
            ViewBag.nodes = nodes;
            ViewBag.connectors = Connectors;
            return View();
        }
    }

    public class CustomPort : DiagramPort
    {

        public string text;
       
    }

    public class NodePorts : DiagramNode
    {
        public NodePorts()
        {
            this.Height = 65;
            this.Width = 100;
        }
    }

    public class Color
    {
        public string text;
        public string color;
    }

    public class Shapee
    {
        public string text;
        public string shape;
    }

    public class PortVisibilityy
    {
        public string text;
        public int PortVisibility;
    }
}