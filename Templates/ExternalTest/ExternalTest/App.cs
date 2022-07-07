#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;

#endregion

namespace ExternalTest
{
	class App : IExternalApplication
	{
		//Class instance
		public static App thisApp = null;
		//ModelessForm instance
		private ModelessForm m_MyForm;

		public Result OnShutdown(UIControlledApplication application)
		{
			if (m_MyForm != null && m_MyForm.Visible)
			{
				m_MyForm.Close();
			}
			return Result.Succeeded;
		}

		public Result OnStartup(UIControlledApplication application)
		{
			m_MyForm = null; //no dialog needed yet; the command will bring it
			thisApp = this; //static access to this application instance
			return Result.Succeeded;
		}

		public void ShowForm(UIApplication uiapp)
		{
			//if we do not have a dialog yet, create and show it
			if (m_MyForm == null || m_MyForm.IsDisposed)
			{
				//A new handler to handle request posting by the dialog
				Event handler = new Event();

				//External Event for the dialog to use (to post requests)
				ExternalEvent exEvent = ExternalEvent.Create(handler);

				//We give objects to the new dialog;
				//The dialog becomes the owner responsible for disposing them, eventually
				m_MyForm = new ModelessForm(exEvent, handler);
				m_MyForm.Show();
			}
		}
	}
}
