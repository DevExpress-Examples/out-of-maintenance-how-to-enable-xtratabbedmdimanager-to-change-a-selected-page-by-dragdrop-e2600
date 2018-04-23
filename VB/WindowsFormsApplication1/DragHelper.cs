using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Mdi;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTabbedMdi;

namespace DragDataBetweenMdiTabbedForms
{
    public class DragHelper
    {
        XtraTabbedMdiManager manager;

        public DragHelper(XtraTabbedMdiManager manager)
        {
            this.manager = manager;
        }

        public bool SelectNewPageOnDrag
        {
            set
            {
                MdiClient.DragOver -= OnMdiClientDragOver;
                if (value)
                    MdiClient.DragOver += OnMdiClientDragOver;
            }
        }

        private MdiClient MdiClient
        {
            get
            {
                return MdiClientSubclasser.GetMdiClient(manager.MdiParent);
            }
        }

        protected void OnMdiClientDragOver(object sender, DragEventArgs e)
        {
            IXtraTab xtraTab = manager as IXtraTab;
            Point p = xtraTab.ScreenPointToControl(new Point(e.X, e.Y));
            BaseTabHitInfo hitInfo = manager.CalcHitInfo(p);
            if (hitInfo.HitTest == XtraTabHitTest.PageHeader)
                manager.SelectedPage = (XtraMdiTabPage)hitInfo.Page;
        }
    }
}
