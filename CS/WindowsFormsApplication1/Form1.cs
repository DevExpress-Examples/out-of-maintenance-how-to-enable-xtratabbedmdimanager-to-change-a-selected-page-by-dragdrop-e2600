using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTabbedMdi;

namespace DragDataBetweenMdiTabbedForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ChildForm1 childForm1 = new ChildForm1();
			childForm1.MdiParent = this;
			childForm1.Show();

			ChildForm2 childForm2 = new ChildForm2();
			childForm2.MdiParent = this;
			childForm2.Show();
			childForm1.BringToFront();
			
			MdiClient mdiClient = XtraTabbedMdiManager.GetMdiClient(this);
			mdiClient.DragOver += new DragEventHandler(mdiClient_DragOver);
		}

		protected void mdiClient_DragOver(object sender, DragEventArgs e)
		{
			Point p = (xtraTabbedMdiManager1 as IXtraTab).ScreenPointToControl(new Point(e.X, e.Y));
			BaseTabHitInfo hitInfo = xtraTabbedMdiManager1.CalcHitInfo(p);
			if ( hitInfo.HitTest == XtraTabHitTest.PageHeader )
				xtraTabbedMdiManager1.SelectedPage = (XtraMdiTabPage)hitInfo.Page;
		}
	}
}
