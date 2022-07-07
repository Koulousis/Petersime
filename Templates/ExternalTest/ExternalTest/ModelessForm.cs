using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;

namespace ExternalTest
{
	public partial class ModelessForm : Form
	{
		private ExternalEvent m_ExEvent;
		private Event m_Handler;
		public ModelessForm(ExternalEvent exEvent, Event handler)
		{
			InitializeComponent();
			m_ExEvent = exEvent;
			m_Handler = handler;
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			//We own both the event and the handler
			//We should dispose it before we are closed
			m_ExEvent.Dispose();
			m_ExEvent = null;
			m_Handler = null;

			base.OnFormClosed(e);
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void showMessage_Click(object sender, EventArgs e)
		{
			m_ExEvent.Raise();
		}
	}
}
