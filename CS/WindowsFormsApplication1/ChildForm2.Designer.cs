namespace DragDataBetweenMdiTabbedForms
{
	partial class ChildForm2
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
			this.listBoxControl1.AllowDrop = true;
			this.listBoxControl1.Location = new System.Drawing.Point(12, 12);
			this.listBoxControl1.Name = "listBoxControl1";
			this.listBoxControl1.Size = new System.Drawing.Size(186, 157);
			this.listBoxControl1.TabIndex = 1;
			this.listBoxControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.listBoxControl1_DragOver);
			this.listBoxControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxControl1_DragDrop);
			// 
			// ChildForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 287);
			this.Controls.Add(this.listBoxControl1);
			this.Name = "ChildForm2";
			this.Text = "ChildForm2";
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.ListBoxControl listBoxControl1;

	}
}