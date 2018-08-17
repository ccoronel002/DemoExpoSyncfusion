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
        // GET: KeyboardInteraction
        public ActionResult KeyboardInteraction()
        {
            List<KeyboardInformation> data = new List<KeyboardInformation>();
            data.Add(new KeyboardInformation() { id = "A", ancestor = "", fillcolor = "#3498DB" });
            data.Add(new KeyboardInformation() { id = "B", ancestor = "A", fillcolor = "#E74C3C" });
            data.Add(new KeyboardInformation() { id = "C", ancestor = "A", fillcolor = "#E74C3C" });
            data.Add(new KeyboardInformation() { id = "D", ancestor = "A", fillcolor = "#E74C3C" });
            data.Add(new KeyboardInformation() { id = "E", ancestor = "B", fillcolor = "#F39C12" });
            data.Add(new KeyboardInformation() { id = "F", ancestor = "B", fillcolor = "#F39C12" });
            data.Add(new KeyboardInformation() { id = "G", ancestor = "F", fillcolor = "#8E44AD" });
            data.Add(new KeyboardInformation() { id = "H", ancestor = "F", fillcolor = "#8E44AD" });
            data.Add(new KeyboardInformation() { id = "I", ancestor = "G", fillcolor = "#1E8449" });
            data.Add(new KeyboardInformation() { id = "J", ancestor = "G", fillcolor = "#1E8449" });

            List<DiagramCommand> commands = new List<DiagramCommand>();
            commands.Add(new DiagramCommand()
            {
                Name = "customGroup",
                CanExecute = "CanExecutegrouping",
                Execute = "Executegrouping",
                Gesture = new DiagramKeyGesture()
                {
                    Key = Keys.G,
                    KeyModifiers = KeyModifiers.Control
                }
            });
            commands.Add(new DiagramCommand()
            {
                Name = "customUnGroup",
                CanExecute = "CanExecuteungrouping",
                Execute = "Executeungrouping",
                Gesture = new DiagramKeyGesture() { Key = Keys.U, KeyModifiers = KeyModifiers.Control }
            });
            commands.Add(new DiagramCommand()
            {
                Name = "navigationDown",
                CanExecute = "CanExecutenavigationdown",
                Execute = "Executenavigationdown",
                Gesture = new DiagramKeyGesture() { Key = Keys.Down }
            });
            commands.Add(new DiagramCommand()
            {
                Name = "navigationUp",
                CanExecute = "CanExecutenavigationup",
                Execute = "Executenavigationup",
                Gesture = new DiagramKeyGesture() { Key = Keys.Up }
            });
            commands.Add(new DiagramCommand()
            {
                Name = "navigationLeft",
                CanExecute = "CanExecutenavigationleft",
                Execute = "Executenavigationleft",
                Gesture = new DiagramKeyGesture() { Key = Keys.Left }
            });
            commands.Add(new DiagramCommand()
            {
                Name = "navigationRight",
                CanExecute = "CanExecutenavigationright",
                Execute = "Executenavigationright",
                Gesture = new DiagramKeyGesture() { Key = Keys.Right }
            });
            ViewBag.commands = commands;

            ViewBag.Nodes = data;
            return View();
        }
    }

    public class KeyboardInformation
    {
        public string id { get; set; }
        public string ancestor { get; set; }
        public string fillcolor { get; set; }

    }
}