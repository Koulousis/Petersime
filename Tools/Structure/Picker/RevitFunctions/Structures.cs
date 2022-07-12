using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picker.RevitFunctions
{
	public static class Structures
	{		
		//Columns
		public static FilteredElementCollector GetColumns(Document document)
		{
			FilteredElementCollector columnsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralColumns); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			return columnsFiltered;
		}

		public static List<string> GetColumnsGroupedNames(Document document)
		{
			FilteredElementCollector columnsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralColumns); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			List<string> columnsGroupNames = new List<string>();
			foreach (Element column in columnsFiltered)
			{
				if (!columnsGroupNames.Contains(column.Name))
				{
					columnsGroupNames.Add(column.Name);
				}
			}
			return columnsGroupNames;
		}

		//Connections
		public static FilteredElementCollector GetConnections(Document document)
		{
			FilteredElementCollector connectionsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralConnectionHandler_Deprecated); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			return connectionsFiltered;
		}

		public static List<string> GetConnectionsGroupedNames(Document document)
		{
			FilteredElementCollector connectionsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralConnectionHandler_Deprecated); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));			
            List<string> connectionsGroupNames = new List<string>();
            foreach (Element connection in connectionsFiltered)
            {
                if (!connectionsGroupNames.Contains(connection.Name))
                {
                    connectionsGroupNames.Add(connection.Name);
                }
            }
			return connectionsGroupNames;
		}

		//Foundations
		public static FilteredElementCollector GetFoundations(Document document)
		{
			FilteredElementCollector foundationsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralFoundation); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			return foundationsFiltered;
		}
		public static List<string> GetFoundationsGroupedNames(Document document)
		{
			FilteredElementCollector foundationsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralFoundation); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			List<string> foundationsGroupNames = new List<string>();
			foreach (Element foundation in foundationsFiltered)
			{
				if (!foundationsGroupNames.Contains(foundation.Name))
				{
					foundationsGroupNames.Add(foundation.Name);
				}
			}
			return foundationsGroupNames;
		}

		//Framings
		public static FilteredElementCollector GetFramings(Document document)
		{
			FilteredElementCollector framingsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralFraming); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			return framingsFiltered;
		}
		public static List<string> GetFramingsGroupedNames(Document document)
		{
			FilteredElementCollector framingsFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralFraming); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			List<string> framingsGroupNames = new List<string>();
			foreach (Element framing in framingsFiltered)
			{
				if (!framingsGroupNames.Contains(framing.Name))
				{
					framingsGroupNames.Add(framing.Name);
				}
			}
			return framingsGroupNames;
		}

		//Stiffeners
		public static FilteredElementCollector GetStiffeners(Document document)
		{
			FilteredElementCollector stiffenersFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralStiffener); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			return stiffenersFiltered;
		}
		public static List<string> GetStiffenersGroupedNames(Document document)
		{
			FilteredElementCollector stiffenersFiltered = new FilteredElementCollector(document, document.ActiveView.Id).OfCategory(BuiltInCategory.OST_StructuralStiffener); //.WherePasses(new ElementStructuralTypeFilter(StructuralType.NonStructural));
			List<string> stiffenersGroupNames = new List<string>();
			foreach (Element stiffener in stiffenersFiltered)
			{
				if (!stiffenersGroupNames.Contains(stiffener.Name))
				{
					stiffenersGroupNames.Add(stiffener.Name);
				}
			}
			return stiffenersGroupNames;
		}


	}
}
