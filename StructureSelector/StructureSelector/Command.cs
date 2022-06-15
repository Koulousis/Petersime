#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

#endregion

namespace StructureSelector
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
            Selection sel = uiapp.ActiveUIDocument.Selection;

            //Create key, values pairs with the structure and it's amount
            Dictionary<string, int> structurePairs = new Dictionary<string, int>();
            //Add on this list the structures which has been recorded as 'found'
            List<string> structureList = new List<string>();

            //Create a filter to collect structures only from the current view
            FilteredElementCollector structureFilter = new FilteredElementCollector(doc, doc.ActiveView.Id);
            //Select the filter type
            structureFilter.OfCategory(BuiltInCategory.OST_StructuralFraming);
            //By using the filter assign on a collection the elements which pass the filter
            ICollection<ElementId> structureElementsIds = structureFilter.ToElementIds();
            ICollection<Element> structureElements = structureFilter.ToElements();

            //foreach element of the collection
            foreach (var structure in structureElements)
            {
                string name = structure.Name;
                int counter = 0;
                name = name.Substring(0, name.Length - 2);

                //check if it's exist on the custom list and if it doesn't add it on this list
                if (!(structureList.Contains(name)))
                {
                    structureList.Add(name);

                    //then count how many times it exists on the collection
                    foreach (var subStructure in structureElements)
                    {
                        if (structure.Name == subStructure.Name)
                        {
                            counter++;
                        }
                    }

                    //in the end create a key,value pair of this new element and it's amount
                    structurePairs.Add(name, counter);
                }
            }


            Selector selector = new Selector(commandData, structurePairs);
            selector.ShowDialog();

            structurePairs = selector.structurePairsFiltered;
            foreach (var item in structurePairs)
            {
                if (!structurePairs.ContainsKey(item.Key))
                {
                    structureElements.Remove(structureElements.Contains(item == item.Key);
                }
            }

            foreach (var item in structureElementsIds)
            {
                Element element = doc.GetElement(item);
                if (!structureElements.Contains(element))
                {
                    structureElementsIds.Remove(item);
                }
            }
            
            sel.SetElementIds(structureElementsIds);




            return Result.Succeeded;
        }
    }
}
