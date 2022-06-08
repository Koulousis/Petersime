#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace FramingSelector
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // Get the Structure Framing of the current document.            
            FilteredElementCollector structureFramingCollector = new FilteredElementCollector(doc);
            structureFramingCollector.OfCategory(BuiltInCategory.OST_StructuralFraming);

            ICollection<ElementId> structureFramings = structureFramingCollector.ToElementIds();
            uidoc.Selection.SetElementIds(structureFramings);

            //Transaction
            //Transaction curTrans = new Transaction(doc, "Structure Framing Selector");
            //curTrans.Start();
            ////add code
            //curTrans.Commit();
            //curTrans.Dispose();

            return Result.Succeeded;
        }
    }
}
