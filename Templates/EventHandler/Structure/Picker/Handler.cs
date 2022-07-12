﻿using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picker
{
	public class Handler : IExternalEventHandler
	{
		public void Execute(UIApplication app)
		{
			TaskDialog.Show("External Event", "Click Close to close.");
		}

		public string GetName()
		{
			return "External Event Example";
		}
	}
}
