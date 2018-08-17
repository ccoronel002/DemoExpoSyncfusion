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
        // GET: Serialization
        public ActionResult Serialization()
        {
            List<DiagramNode> Nodes = new List<DiagramNode>();
            Nodes.Add(new Serialization()
            {
                Id = "Start",
                OffsetX = 150,
                OffsetY = 80,
                Style = new DiagramShapeStyle() { Fill = "#d0f0f1", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Start" }
                },
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            Nodes.Add(new Serialization()
            {
                Id = "Alarm",
                OffsetX = 150,
                OffsetY = 160,
                Style = new DiagramShapeStyle() { Fill = "#fbfdc5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Alarm Rings" }},
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new Serialization()
            {
                Id = "Ready",
                OffsetX = 150,
                OffsetY = 240,
                Style = new DiagramShapeStyle() { Fill = "#c5efaf", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                    new DiagramNodeAnnotation() { Content = "Ready to Get Up" }
                },
                Shape = new { type = "Flow", shape = "Decision" }
            });
            Nodes.Add(new Serialization()
            {
                Id = "Climb",
                OffsetX = 150,
                OffsetY = 330,
                Style = new DiagramShapeStyle() { Fill = "#fbfdc5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Climb Out of Bed" }},
                Shape = new { type = "Flow", shape = "Process" }
            });
            Nodes.Add(new Serialization()
            {
                Id = "End",
                OffsetX = 150,
                OffsetY = 430,
                Style = new DiagramShapeStyle() { Fill = "#d0f0f1", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "End" }},
                Shape = new { type = "Flow", shape = "Terminator" }
            });
            Nodes.Add(new Serialization()
            {
                Id = "Relay",
                OffsetX = 350,
                OffsetY = 160,
                Style = new DiagramShapeStyle() { Fill = "#f8eee5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Relay" }},
                Shape = new { type = "Flow", shape = "Delay" }
            });
            Nodes.Add(new Serialization()
            {
                Id = "Hit",
                OffsetX = 350,
                OffsetY = 240,
                Style = new DiagramShapeStyle() { Fill = "#fbfdc5", StrokeColor = "#797979" },
                Annotations = new List<DiagramNodeAnnotation>() {
                new DiagramNodeAnnotation() { Content = "Hit Snooze Button", Margin = new DiagramMargin() { Left = 10, Right = 10, Bottom = 10, Top = 10 } }},
                Shape = new { type = "Flow", shape = "Process" }
            });

            List<DiagramConnector> Connectors = new List<DiagramConnector>();
            Connectors.Add(new DiagramConnector() { Id = "connector1", SourceID = "Start", TargetID = "Alarm" });
            Connectors.Add(new DiagramConnector() { Id = "connector2", SourceID = "Alarm", TargetID = "Ready" });
            Connectors.Add(new DiagramConnector() { Id = "connector3", SourceID = "Ready", TargetID = "Climb" });
            Connectors.Add(new DiagramConnector() { Id = "connector4", SourceID = "Climb", TargetID = "End" });
            Connectors.Add(new DiagramConnector() { Id = "connector5", SourceID = "Ready", TargetID = "Hit" });
            Connectors.Add(new DiagramConnector() { Id = "connector6", SourceID = "Hit", TargetID = "Relay" });
            Connectors.Add(new DiagramConnector() { Id = "connector7", SourceID = "Relay", TargetID = "Alarm" });

            ViewBag.nodes = Nodes;
            ViewBag.connectors = Connectors;

            List<DiagramNode> SymbolPaletee = new List<DiagramNode>();
            SymbolPaletee.Add(new FlowShapes() { Id = "Terminator", Shape = new { type = "Flow", shape = "Terminator" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Process", Shape = new { type = "Flow", shape = "Process" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Decision", Shape = new { type = "Flow", shape = "Decision" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Document", Shape = new { type = "Flow", shape = "Document" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "PreDefinedProcess", Shape = new { type = "Flow", shape = "PreDefinedProcess" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "PaperTap", Shape = new { type = "Flow", shape = "PaperTap" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "DirectData", Shape = new { type = "Flow", shape = "DirectData" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "SequentialData", Shape = new { type = "Flow", shape = "SequentialData" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Sort", Shape = new { type = "Flow", shape = "Sort" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "MultiDocument", Shape = new { type = "Flow", shape = "MultiDocument" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Collate", Shape = new { type = "Flow", shape = "Collate" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "SummingJunction", Shape = new { type = "Flow", shape = "SummingJunction" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Or", Shape = new { type = "Flow", shape = "Or" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "InternalStorage", Shape = new { type = "Flow", shape = "InternalStorage" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Extract", Shape = new { type = "Flow", shape = "Extract" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "ManualOperation", Shape = new { type = "Flow", shape = "ManualOperation" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Merge", Shape = new { type = "Flow", shape = "Merge" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "OffPageReference", Shape = new { type = "Flow", shape = "OffPageReference" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "SequentialAccessStorage", Shape = new { type = "Flow", shape = "SequentialAccessStorage" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Annotation", Shape = new { type = "Flow", shape = "Annotation" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Annotation2", Shape = new { type = "Flow", shape = "Annotation2" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Data", Shape = new { type = "Flow", shape = "Data" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Card", Shape = new { type = "Flow", shape = "Card" } });
            SymbolPaletee.Add(new FlowShapes() { Id = "Delay", Shape = new { type = "Flow", shape = "Delay" } });


            List<DiagramConnector> SymbolPaletteConnectors = new List<DiagramConnector>();
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link1",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link2",
                Type = Segments.Orthogonal,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link3",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.Arrow },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link4",
                Type = Segments.Straight,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });
            SymbolPaletteConnectors.Add(new DiagramConnector()
            {
                Id = "Link5",
                Type = Segments.Bezier,
                SourcePoint = new DiagramPoint() { X = 0, Y = 0 },
                TargetPoint = new DiagramPoint() { X = 40, Y = 40 },
                TargetDecorator = new ConnectorTargetDecoratorConnectors() { Shape = DecoratorShapes.None },
                Style = new DiagramStrokeStyle() { StrokeWidth = 2 }
            });

            List<SymbolPalettePalette> Palette = new List<SymbolPalettePalette>();
            Palette.Add(new SymbolPalettePalette() { Id = "flow", Expanded = true, Symbols = SymbolPaletee, IconCss = "shapes", Title = "Flow Shapes" });
            Palette.Add(new SymbolPalettePalette() { Id = "connectors", Expanded = true, Symbols = SymbolPaletteConnectors, IconCss = "shapes", Title = "Connectors" });

            ViewBag.Palette = Palette;

            ViewBag.Spconnectors = SymbolPaletteConnectors;

            double[] intervals = { 1, 9, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75, 0.25, 9.75 };
            DiagramGridlines grIdLines = new DiagramGridlines()
            { LineColor = "#e0e0e0", LineIntervals = intervals };
            ViewBag.gridLines = grIdLines;

            DiagramMargin margin = new DiagramMargin() { Left = 15, Right = 15, Bottom = 15, Top = 15 };
            ViewBag.margin = margin;

            return View();
        }
    }

    public class Serialization : DiagramNode
    {
        public Serialization()
        {
            this.Width = 100;
            this.Height = 50;
        }
    }

    public class FlowShape : DiagramNode
    {
        public FlowShape()
        {
            this.Width = 80;
            this.Height = 40;
        }
    }
}