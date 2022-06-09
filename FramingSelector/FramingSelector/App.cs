#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

#endregion

namespace FramingSelector
{
    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication a)
        {
            RibbonPanel ribbonPanel = a.CreateRibbonPanel("Tools");
            string ribbonAssembly = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string ribbonAssemblyPath = System.IO.Path.GetDirectoryName(ribbonAssembly);

            PushButtonData pushButtonData = new PushButtonData("Structure Framing", "Selector", ribbonAssembly, "FramingSelector.Command");
            pushButtonData.LargeImage = new BitmapImage(new Uri(System.IO.Path.Combine(ribbonAssemblyPath, "Tools.png")));
            PushButton pushButton = (PushButton)ribbonPanel.AddItem(pushButtonData);


            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }
}
