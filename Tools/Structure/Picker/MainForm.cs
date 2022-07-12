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
		//public List<CheckBox> columnsCheckBoxes;
		//public List<CheckBox> connectionsCheckBoxes;
		//public List<CheckBox> foundationsCheckBoxes;
		//public List<CheckBox> framingsCheckBoxes;
		//public List<CheckBox> stiffenersCheckBoxes;

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
					checkBox.Size = new System.Drawing.Size(80, 17);
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.Tag = "Columns";
					tabColumns.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
					//columnsCheckBoxes.Add(checkBox);
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
					checkBox.Size = new System.Drawing.Size(80, 17);
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.Tag = "Connections";
					tabConnections.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
					//connectionsCheckBoxes.Add(checkBox);
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
					checkBox.Size = new System.Drawing.Size(80, 17);
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.Tag = "Foundations";
					tabFoundations.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
					//foundationsCheckBoxes.Add(checkBox);
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
					checkBox.Size = new System.Drawing.Size(80, 17);
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.Tag = "Framings";
					tabFramings.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
					//framingsCheckBoxes.Add(checkBox);
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
					checkBox.Size = new System.Drawing.Size(80, 17);
					checkBox.TabIndex = 0;
					checkBox.Text = name;
					checkBox.UseVisualStyleBackColor = true;
					checkBox.Tag = "Stiffeners";
					tabStiffeners.Controls.Add(checkBox);
					cordy += 24;
					checkBox.CheckedChanged += new EventHandler(this.CheckBoxSelected);
					//stiffenersCheckBoxes.Add(checkBox);
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
