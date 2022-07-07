#region Namespaces
using Autodesk.Revit.UI;

#endregion

namespace ExternalTest
{
	public class Event : IExternalEventHandler
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
