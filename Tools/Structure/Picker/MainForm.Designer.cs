
namespace Picker
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelTabStructures = new System.Windows.Forms.Panel();
			this.tabStructures = new System.Windows.Forms.TabControl();
			this.tabColumns = new System.Windows.Forms.TabPage();
			this.tabConnections = new System.Windows.Forms.TabPage();
			this.tabFoundations = new System.Windows.Forms.TabPage();
			this.tabFramings = new System.Windows.Forms.TabPage();
			this.tabStiffeners = new System.Windows.Forms.TabPage();
			this.panelPetersimeBanner = new System.Windows.Forms.Panel();
			this.panelTabStructures.SuspendLayout();
			this.tabStructures.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTabStructures
			// 
			this.panelTabStructures.Controls.Add(this.tabStructures);
			this.panelTabStructures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTabStructures.Location = new System.Drawing.Point(0, 0);
			this.panelTabStructures.Name = "panelTabStructures";
			this.panelTabStructures.Size = new System.Drawing.Size(308, 446);
			this.panelTabStructures.TabIndex = 0;
			// 
			// tabStructures
			// 
			this.tabStructures.Controls.Add(this.tabColumns);
			this.tabStructures.Controls.Add(this.tabConnections);
			this.tabStructures.Controls.Add(this.tabFoundations);
			this.tabStructures.Controls.Add(this.tabFramings);
			this.tabStructures.Controls.Add(this.tabStiffeners);
			this.tabStructures.Location = new System.Drawing.Point(0, 0);
			this.tabStructures.Name = "tabStructures";
			this.tabStructures.SelectedIndex = 0;
			this.tabStructures.Size = new System.Drawing.Size(307, 347);
			this.tabStructures.TabIndex = 0;
			// 
			// tabColumns
			// 
			this.tabColumns.AutoScroll = true;
			this.tabColumns.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabColumns.Location = new System.Drawing.Point(4, 22);
			this.tabColumns.Name = "tabColumns";
			this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
			this.tabColumns.Size = new System.Drawing.Size(299, 321);
			this.tabColumns.TabIndex = 0;
			this.tabColumns.Text = "Columns";
			// 
			// tabConnections
			// 
			this.tabConnections.AutoScroll = true;
			this.tabConnections.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabConnections.Location = new System.Drawing.Point(4, 22);
			this.tabConnections.Name = "tabConnections";
			this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
			this.tabConnections.Size = new System.Drawing.Size(299, 349);
			this.tabConnections.TabIndex = 1;
			this.tabConnections.Text = "Connections";
			// 
			// tabFoundations
			// 
			this.tabFoundations.AutoScroll = true;
			this.tabFoundations.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabFoundations.Location = new System.Drawing.Point(4, 22);
			this.tabFoundations.Name = "tabFoundations";
			this.tabFoundations.Padding = new System.Windows.Forms.Padding(3);
			this.tabFoundations.Size = new System.Drawing.Size(299, 349);
			this.tabFoundations.TabIndex = 2;
			this.tabFoundations.Text = "Foundations";
			// 
			// tabFramings
			// 
			this.tabFramings.AutoScroll = true;
			this.tabFramings.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabFramings.Location = new System.Drawing.Point(4, 22);
			this.tabFramings.Name = "tabFramings";
			this.tabFramings.Padding = new System.Windows.Forms.Padding(3);
			this.tabFramings.Size = new System.Drawing.Size(299, 349);
			this.tabFramings.TabIndex = 3;
			this.tabFramings.Text = "Framings";
			// 
			// tabStiffeners
			// 
			this.tabStiffeners.AutoScroll = true;
			this.tabStiffeners.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabStiffeners.Location = new System.Drawing.Point(4, 22);
			this.tabStiffeners.Name = "tabStiffeners";
			this.tabStiffeners.Padding = new System.Windows.Forms.Padding(3);
			this.tabStiffeners.Size = new System.Drawing.Size(299, 349);
			this.tabStiffeners.TabIndex = 4;
			this.tabStiffeners.Text = "Stiffeners";
			// 
			// panelPetersimeBanner
			// 
			this.panelPetersimeBanner.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelPetersimeBanner.Location = new System.Drawing.Point(0, 349);
			this.panelPetersimeBanner.Name = "panelPetersimeBanner";
			this.panelPetersimeBanner.Size = new System.Drawing.Size(308, 97);
			this.panelPetersimeBanner.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 446);
			this.Controls.Add(this.panelPetersimeBanner);
			this.Controls.Add(this.panelTabStructures);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Strucure Picker";
			this.panelTabStructures.ResumeLayout(false);
			this.tabStructures.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTabStructures;
		private System.Windows.Forms.TabControl tabStructures;
		private System.Windows.Forms.TabPage tabColumns;
		private System.Windows.Forms.TabPage tabConnections;
		private System.Windows.Forms.TabPage tabFoundations;
		private System.Windows.Forms.TabPage tabFramings;
		private System.Windows.Forms.TabPage tabStiffeners;
		private System.Windows.Forms.Panel panelPetersimeBanner;
	}
}