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

            //Instanciate the form window
            Selector selector = new Selector(structurePairs);
            //Show the window
            selector.ShowDialog();

            if (!selector.canceled)
            {
                //Assign the pairs which the user have selected
                structurePairs = selector.structurePairsFiltered;

                //Instanciate a new elements collection and clear it
                FilteredElementCollector newStructureFilter = new FilteredElementCollector(doc, doc.ActiveView.Id);
                newStructureFilter.OfCategory(BuiltInCategory.OST_StructuralFraming);
                ICollection<Element> userSelectedElements = newStructureFilter.ToElements();
                userSelectedElements.Clear();

                //Add to the cleared collection those elements which exist on the
                //list that the user have selected from the form
                foreach (var item in structureElements)
                {
                    bool exist = structurePairs.ContainsKey(item.Name.Substring(0, item.Name.Length - 2));
                    if (exist)
                    {
                        userSelectedElements.Add(item);
                    }
                }

                //Instanciate a new elements id collection and clear it
                FilteredElementCollector newStructureFilterId = new FilteredElementCollector(doc, doc.ActiveView.Id);
                newStructureFilterId.OfCategory(BuiltInCategory.OST_StructuralFraming);
                ICollection<ElementId> userSelectedElementsId = newStructureFilterId.ToElementIds();
                userSelectedElementsId.Clear();

                //Add the element ids which are on the element collection that
                //the user have selected
                foreach (var item in userSelectedElements)
                {
                    userSelectedElementsId.Add(item.Id);
                }

                //Select the elements using the elements id collection
                sel.SetElementIds(userSelectedElementsId);
            }



            return Result.Succeeded;
        }
    }
}
