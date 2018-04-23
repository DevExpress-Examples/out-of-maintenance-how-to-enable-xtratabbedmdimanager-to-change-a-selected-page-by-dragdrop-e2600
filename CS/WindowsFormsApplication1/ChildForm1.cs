using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DragDataBetweenMdiTabbedForms
{
	public partial class ChildForm1 : XtraForm
	{
		private Point startPoint;

		public ChildForm1()
		{
			InitializeComponent();
		}

		private void listBoxControl1_MouseDown(object sender, MouseEventArgs e)
		{
			ListBoxControl listBox = sender as ListBoxControl;
			startPoint = new Point(e.X, e.Y);
			int selectedIndex = listBox.IndexFromPoint(startPoint);
			if ( selectedIndex == -1 )
				startPoint = Point.Empty;
		}

		private void listBoxControl1_MouseMove(object sender, MouseEventArgs e)
		{
			ListBoxControl listBox = sender as ListBoxControl;
			if ( e.Button == MouseButtons.Left )
				if ( (startPoint != Point.Empty) && ((Math.Abs(e.X - startPoint.X) > SystemInformation.DragSize.Width) || (Math.Abs(e.Y - startPoint.Y) > SystemInformation.DragSize.Height)) )
					listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Copy);
		}
	}
}