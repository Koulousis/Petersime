#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Media.Imaging;

#endregion

namespace Picker
{
	class App : IExternalApplication
	{
		//Class instance
		public static App thisApp = null;
		//ModelessForm instance
		private MainForm _mainForm;

		public Result OnStartup(UIControlledApplication uiapp)
		{
			_mainForm = null; //no dialog needed yet; the command will bring it
			thisApp = this; //static access to this application instance

			RibbonPanel panel = uiapp.CreateRibbonPanel("Petersime V2");
			//AddPushButton(panel);
			AddSplitButton(panel);
			//AddStackedButtons(panel);
			//AddSlideOut(panel);
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
				_mainForm = new MainForm(externalEvent, handler, uiapp);
				_mainForm.Show();
			}
		}

		private void AddPushButton(RibbonPanel panel)
		{
			string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
			PushButton pushButton = panel.AddItem(new PushButtonData("Tools", "Structure Tools", thisAssemblyPath, "Picker.Command")) as PushButton;

			// Set ToolTip and contextual help
			pushButton.ToolTip = "Provides a list of useful tools for the user.";
			// Set the large image shown on button
			pushButton.LargeImage =	new BitmapImage(new Uri(@"J:\Drawings REVIT FAMILIES\02 NEW\Aris\Logos\Tools\Tools32x32.png"));
		}

		private void AddSplitButton(RibbonPanel panel)
		{
			string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

			// create push buttons for split button drop down
			PushButtonData bOne = new PushButtonData("Tools", "Structure Picker", thisAssemblyPath, "Picker.Command");
			bOne.LargeImage = new BitmapImage(new Uri(@"J:\Drawings REVIT FAMILIES\02 NEW\Aris\Logos\Tools\Picker35x35.png"));
			
			SplitButtonData sb1 = new SplitButtonData("Tools", "Tools");
			SplitButton sb = panel.AddItem(sb1) as SplitButton;
			sb.AddPushButton(bOne);
		}
	}
}
