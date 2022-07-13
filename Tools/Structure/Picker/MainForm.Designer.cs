
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelTabStructures.SuspendLayout();
			this.tabStructures.SuspendLayout();
			this.panelPetersimeBanner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTabStructures
			// 
			this.panelTabStructures.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelTabStructures.Controls.Add(this.tabStructures);
			this.panelTabStructures.Location = new System.Drawing.Point(0, 0);
			this.panelTabStructures.Name = "panelTabStructures";
			this.panelTabStructures.Size = new System.Drawing.Size(317, 385);
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
			this.tabStructures.Multiline = true;
			this.tabStructures.Name = "tabStructures";
			this.tabStructures.SelectedIndex = 0;
			this.tabStructures.Size = new System.Drawing.Size(316, 384);
			this.tabStructures.TabIndex = 0;
			// 
			// tabColumns
			// 
			this.tabColumns.AutoScroll = true;
			this.tabColumns.BackColor = System.Drawing.SystemColors.Info;
			this.tabColumns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabColumns.Location = new System.Drawing.Point(4, 22);
			this.tabColumns.Name = "tabColumns";
			this.tabColumns.Padding = new System.Windows.Forms.Padding(3);
			this.tabColumns.Size = new System.Drawing.Size(308, 358);
			this.tabColumns.TabIndex = 0;
			this.tabColumns.Text = "Columns";
			// 
			// tabConnections
			// 
			this.tabConnections.AutoScroll = true;
			this.tabConnections.BackColor = System.Drawing.SystemColors.Info;
			this.tabConnections.Location = new System.Drawing.Point(4, 22);
			this.tabConnections.Name = "tabConnections";
			this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
			this.tabConnections.Size = new System.Drawing.Size(308, 358);
			this.tabConnections.TabIndex = 1;
			this.tabConnections.Text = "Connections";
			// 
			// tabFoundations
			// 
			this.tabFoundations.AutoScroll = true;
			this.tabFoundations.BackColor = System.Drawing.SystemColors.Info;
			this.tabFoundations.Location = new System.Drawing.Point(4, 22);
			this.tabFoundations.Name = "tabFoundations";
			this.tabFoundations.Padding = new System.Windows.Forms.Padding(3);
			this.tabFoundations.Size = new System.Drawing.Size(308, 358);
			this.tabFoundations.TabIndex = 2;
			this.tabFoundations.Text = "Foundations";
			// 
			// tabFramings
			// 
			this.tabFramings.AutoScroll = true;
			this.tabFramings.BackColor = System.Drawing.SystemColors.Info;
			this.tabFramings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabFramings.Location = new System.Drawing.Point(4, 22);
			this.tabFramings.Name = "tabFramings";
			this.tabFramings.Padding = new System.Windows.Forms.Padding(3);
			this.tabFramings.Size = new System.Drawing.Size(308, 358);
			this.tabFramings.TabIndex = 3;
			this.tabFramings.Text = "Framings";
			// 
			// tabStiffeners
			// 
			this.tabStiffeners.AutoScroll = true;
			this.tabStiffeners.BackColor = System.Drawing.SystemColors.Info;
			this.tabStiffeners.Location = new System.Drawing.Point(4, 22);
			this.tabStiffeners.Name = "tabStiffeners";
			this.tabStiffeners.Padding = new System.Windows.Forms.Padding(3);
			this.tabStiffeners.Size = new System.Drawing.Size(308, 358);
			this.tabStiffeners.TabIndex = 4;
			this.tabStiffeners.Text = "Stiffeners";
			// 
			// panelPetersimeBanner
			// 
			this.panelPetersimeBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.panelPetersimeBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelPetersimeBanner.Controls.Add(this.textBox1);
			this.panelPetersimeBanner.Controls.Add(this.pictureBox1);
			this.panelPetersimeBanner.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelPetersimeBanner.Location = new System.Drawing.Point(0, 387);
			this.panelPetersimeBanner.Name = "panelPetersimeBanner";
			this.panelPetersimeBanner.Size = new System.Drawing.Size(317, 59);
			this.panelPetersimeBanner.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(209)))), ((int)(((byte)(139)))));
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(12, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(284, 11);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "© Copyrights - Petersime NV 2022";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Picker.Properties.Resources.petpanel;
			this.pictureBox1.Location = new System.Drawing.Point(10, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(284, 37);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 446);
			this.Controls.Add(this.panelPetersimeBanner);
			this.Controls.Add(this.panelTabStructures);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Structure Picker";
			this.panelTabStructures.ResumeLayout(false);
			this.tabStructures.ResumeLayout(false);
			this.panelPetersimeBanner.ResumeLayout(false);
			this.panelPetersimeBanner.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox textBox1;
	}
}