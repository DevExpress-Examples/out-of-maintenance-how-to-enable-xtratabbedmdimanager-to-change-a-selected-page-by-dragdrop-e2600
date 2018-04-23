using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Mdi;
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
        DragHelper helper;
		private void Form1_Load(object sender, EventArgs e)
		{
			ChildForm1 childForm1 = new ChildForm1();
			childForm1.MdiParent = this;
			childForm1.Show();

			ChildForm2 childForm2 = new ChildForm2();
			childForm2.MdiParent = this;
			childForm2.Show();
			childForm1.BringToFront();

            helper = new DragHelper(xtraTabbedMdiManager1);
            helper.SelectNewPageOnDrag = true;
		}

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.SelectNewPageOnDrag = false;
        }
	}
    
}
