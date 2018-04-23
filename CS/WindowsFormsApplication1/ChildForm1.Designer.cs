namespace DragDataBetweenMdiTabbedForms
{
	partial class ChildForm1
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
			if ( disposing && (components != null) )
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
			this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// listBoxControl1
			// 
			this.listBoxControl1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
			this.listBoxControl1.Location = new System.Drawing.Point(12, 12);
			this.listBoxControl1.Name = "listBoxControl1";
			this.listBoxControl1.Size = new System.Drawing.Size(186, 157);
			this.listBoxControl1.TabIndex = 0;
			this.listBoxControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseMove);
			this.listBoxControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxControl1_MouseDown);
			// 
			// ChildForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 302);
			this.Controls.Add(this.listBoxControl1);
			this.Name = "ChildForm1";
			this.Text = "ChildForm1";
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ListBoxControl listBoxControl1;

	}
}