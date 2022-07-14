using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Picker.RevitFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picker
{
	public class Handler : IExternalEventHandler
	{
		public List<ElementId> structures = new List<ElementId>();
		public void Execute(UIApplication uiapp)
		{
			Document document = uiapp.ActiveUIDocument.Document;			
			Selection selection = uiapp.ActiveUIDocument.Selection;

			
			string checkBoxName = MainForm.checkBoxSelectedName;
			bool checkBoxStatus = MainForm.checkBoxSelectedStatus;
			string checkBoxTag = MainForm.checkBoxSelectedTag;

			if (checkBoxStatus == true)
			{
				if (checkBoxTag == "Columns")
				{
					FilteredElementCollector columnsFiltered = Structures.GetColumns(document);
					foreach (var item in columnsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Add(item.Id);
						}
					}
				}
				else if (checkBoxTag == "Connections")
				{
					FilteredElementCollector connectionsFiltered = Structures.GetConnections(document);
					foreach (var item in connectionsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Add(item.Id);
						}
					}
				}
				else if (checkBoxTag == "Foundations")
				{
					FilteredElementCollector foundationsFiltered = Structures.GetFoundations(document);
					foreach (var item in foundationsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Add(item.Id);
						}
					}
				}
				else if (checkBoxTag == "Framings")
				{
					FilteredElementCollector framingsFiltered = Structures.GetFramings(document);
					foreach (var item in framingsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Add(item.Id);
						}
					}
				}
				else
				{
					FilteredElementCollector stiffenersFiltered = Structures.GetStiffeners(document);
					foreach (var item in stiffenersFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Add(item.Id);
						}
					}
				}

				selection.SetElementIds(structures);
			} 
			else
			{
				//structures.Clear();
				if (checkBoxTag == "Columns")
				{
					FilteredElementCollector columnsFiltered = Structures.GetColumns(document);
					foreach (var item in columnsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Remove(item.Id);
						}
					}
				}
				else if (checkBoxTag == "Connections")
				{
					FilteredElementCollector connectionsFiltered = Structures.GetConnections(document);
					foreach (var item in connectionsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Remove(item.Id);
						}
					}
				}
				else if (checkBoxTag == "Foundations")
				{
					FilteredElementCollector foundationsFiltered = Structures.GetFoundations(document);
					foreach (var item in foundationsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Remove(item.Id);
						}
					}
				}
				else if (checkBoxTag == "Framings")
				{
					FilteredElementCollector framingsFiltered = Structures.GetFramings(document);
					foreach (var item in framingsFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Remove(item.Id);
						}
					}
				}
				else
				{
					FilteredElementCollector stiffenersFiltered = Structures.GetStiffeners(document);
					foreach (var item in stiffenersFiltered)
					{
						if (item.Name == checkBoxName)
						{
							structures.Remove(item.Id);
						}
					}
				}
				selection.SetElementIds(structures);
			}
			

		}

		public string GetName()
		{
			return "External Event Example";
		}
	}
}
