#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace Picker
{
	class App : IExternalApplication
	{
		//Class instance
		public static App thisApp = null;
		//ModelessForm instance
		private MainForm _mainForm;

		public Result OnStartup(UIControlledApplication a)
		{
			_mainForm = null; //no dialog needed yet; the command will bring it
			thisApp = this; //static access to this application instance
			return Result.Succeeded;
		}

		public Result OnShutdown(UIControlledApplication a)
		{
			if (_mainForm != null && _mainForm.Visible)
			{
				_mainForm.Close();
			}
			return Result.Succeeded;
		}

		public void ShowForm(UIApplication uiapp)
		{
			//if we do not have a dialog yet, create and show it
			if (_mainForm == null || _mainForm.IsDisposed)
			{
				//A new handler to handle request posting by the dialog
				Handler handler = new Handler();

				//External Event for the dialog to use (to post requests)
				ExternalEvent externalEvent = ExternalEvent.Create(handler);

				//We give objects to the new dialog;
				//The dialog becomes the owner responsible for disposing them, eventually
				_mainForm = new MainForm(externalEvent, handler);
				_mainForm.Show();
			}
		}
	}
}
