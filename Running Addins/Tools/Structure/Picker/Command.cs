#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Picker.RevitFunctions;
using System;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace Picker
{
	[Transaction(TransactionMode.Manual)]
	public class Command : IExternalCommand
	{
		public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
		{			
			try
			{
				App.thisApp.ShowForm(commandData.Application);
				return Result.Succeeded;
			}
			catch (Exception ex)
			{
				message = ex.Message;
				return Result.Failed;
			}
		}
	}
}
