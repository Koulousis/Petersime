using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Picker
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		private ExternalEvent _externalEvent;
		private Handler _handler;
		public static string checkBoxSelectedName;
		public static bool checkBoxSelectedStatus;
		public static string checkBoxSelectedTag;

		public MainForm(ExternalEvent externalEvent, Handler handler, UIApplication uiapp)
		{
			InitializeComponent();
			_externalEvent = externalEvent;
			_handler = handler;
			AddCheckBoxesToTabs(uiapp);
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

		void AddCheckBoxesToTabs(UIApplication uiapp)
		{
			Document document = uiapp.ActiveUIDocument.Document;
			int cordx, cordy;

			//Columns
			List<string> columnsGroupedNames = RevitFunctions.Structures.GetColumnsGroupedNames(document);
			cordx = 13;
			cordy = 13;
			if (columnsGroupedNames.Count > 0)
			{
				foreach (string name in columnsGroupedNames)
				{
					CheckBox checkBox = new CheckBox();
					checkBox.AutoSize = true;
					checkBox.Location = new System.Drawing.Point(cordx, cordy);
					checkBox.Name = name;
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.AutoSize = false;
					checkBox.Appearance = Appearance.Button;
					checkBox.TextAlign = ContentAlignment.MiddleCenter;
					checkBox.Size = new Size(270, 24);				
					checkBox.Tag = "Columns";
					tabColumns.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
				}
			}			

			//Connections
			List<string> connectionsGroupedNames = RevitFunctions.Structures.GetConnectionsGroupedNames(document);
			cordx = 13;
			cordy = 13;
			if (connectionsGroupedNames.Count > 0)
			{
				foreach (string name in connectionsGroupedNames)
				{
					CheckBox checkBox = new CheckBox();
					checkBox.AutoSize = true;
					checkBox.Location = new System.Drawing.Point(cordx, cordy);
					checkBox.Name = name;
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.AutoSize = false;
					checkBox.Appearance = Appearance.Button;
					checkBox.TextAlign = ContentAlignment.MiddleCenter;
					checkBox.Size = new Size(270, 24);
					checkBox.Tag = "Connections";
					tabConnections.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
				}
			}			

			//Foundations
			List<string> foundationsGroupedNames = RevitFunctions.Structures.GetFoundationsGroupedNames(document);
			cordx = 13;
			cordy = 13;
			if (foundationsGroupedNames.Count > 0)
			{
				foreach (string name in foundationsGroupedNames)
				{
					CheckBox checkBox = new CheckBox();
					checkBox.AutoSize = true;
					checkBox.Location = new System.Drawing.Point(cordx, cordy);
					checkBox.Name = name;
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.AutoSize = false;
					checkBox.Appearance = Appearance.Button;
					checkBox.TextAlign = ContentAlignment.MiddleCenter;
					checkBox.Size = new Size(270, 24);
					checkBox.Tag = "Foundations";
					tabFoundations.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
				}
			}			

			//Framings
			List<string> framingsGroupedNames = RevitFunctions.Structures.GetFramingsGroupedNames(document);
			cordx = 13;
			cordy = 13;
			if (framingsGroupedNames.Count > 0)
			{
				foreach (string name in framingsGroupedNames)
				{
					CheckBox checkBox = new CheckBox();
					checkBox.AutoSize = true;
					checkBox.Location = new System.Drawing.Point(cordx, cordy);
					checkBox.Name = name;
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.AutoSize = false;
					checkBox.Appearance = Appearance.Button;
					checkBox.Size = new Size(270, 24);
					checkBox.TextAlign = ContentAlignment.MiddleCenter;					
					checkBox.Tag = "Framings";
					tabFramings.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
				}
			}


			//Stiffeners
			List<string> stiffenersGroupedNames = RevitFunctions.Structures.GetStiffenersGroupedNames(document);
			cordx = 13;
			cordy = 13;
			if (stiffenersGroupedNames.Count > 0)
			{
				foreach (string name in stiffenersGroupedNames)
				{
					CheckBox checkBox = new CheckBox();
					checkBox.AutoSize = true;
					checkBox.Location = new System.Drawing.Point(cordx, cordy);
					checkBox.Name = name;
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.AutoSize = false;
					checkBox.Appearance = Appearance.Button;
					checkBox.TextAlign = ContentAlignment.MiddleCenter;
					checkBox.Size = new Size(270, 24);
					checkBox.Tag = "Stiffeners";
					tabStiffeners.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
				}
			}			
		}

		void CheckBoxSelected(object sender, EventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			checkBoxSelectedName = checkBox.Name;
			checkBoxSelectedStatus = checkBox.Checked;
			checkBoxSelectedTag = checkBox.Tag.ToString();
			_externalEvent.Raise();
		}
	}
}
