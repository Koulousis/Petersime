using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picker
{
	public partial class MainForm : Form
	{
		private ExternalEvent _externalEvent;
		private Handler _handler;

		public MainForm(ExternalEvent externalEvent, Handler handler)
		{
			InitializeComponent();
			_externalEvent = externalEvent;
			_handler = handler;
			_externalEvent.Raise();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			//We own both the event and the handler
			//We should dispose it before we are closed
			_externalEvent.Dispose();
			_handler = null;
			_handler = null;

			base.OnFormClosed(e);
		}

	}
}
