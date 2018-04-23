Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DragDataBetweenMdiTabbedForms
	Partial Public Class ChildForm2
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub listBoxControl1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles listBoxControl1.DragDrop
			If e.Data.GetDataPresent(GetType(String)) Then
				Dim str As String = CStr(e.Data.GetData(GetType(String)))
				listBoxControl1.Items.Add(str)
			End If
		End Sub

		Private Sub listBoxControl1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles listBoxControl1.DragOver
			e.Effect = DragDropEffects.Copy
		End Sub
	End Class
End Namespace