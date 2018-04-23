using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DragDataBetweenMdiTabbedForms
{
	public partial class ChildForm2 : XtraForm
	{
		public ChildForm2()
		{
			InitializeComponent();
		}

		private void listBoxControl1_DragDrop(object sender, DragEventArgs e)
		{
			if ( e.Data.GetDataPresent(typeof(string)) )
			{
				string str = (string)e.Data.GetData(typeof(string));
				listBoxControl1.Items.Add(str);
			}
		}

		private void listBoxControl1_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}
	}
}