using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace StructureSelector
{
    public partial class Selector : System.Windows.Forms.Form
    {        
        public Dictionary<string, int> structurePairsFiltered;
        public List<CheckBox> checkBoxes;
        public bool canceled;
        public Selector(Dictionary<string,int> structurePairs)
        {
            InitializeComponent();
            structurePairsFiltered = structurePairs;
            CreateCheckBox(structurePairs);
        }

        private void CreateCheckBox(Dictionary<string, int> strucurePairs)
        {
            checkBoxes = new List<CheckBox>();
            int cordx = 13;
            int cordy = 13;
            foreach (var item in strucurePairs)
            {
                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(cordx, cordy);
                checkBox.Name = strucurePairs.Keys.ToString();
                checkBox.Size = new System.Drawing.Size(80, 17);
                checkBox.TabIndex = 0;
                checkBox.Text = item.Key;
                checkBox.UseVisualStyleBackColor = true;
                Controls.Add(checkBox);
                cordy += 24;
                checkBoxes.Add(checkBox);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            foreach (var box in checkBoxes)
            {
                if (!box.Checked)
                {
                    structurePairsFiltered.Remove(box.Text);
                }
            }
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            canceled = true;
            Close();
        }
    }
}
