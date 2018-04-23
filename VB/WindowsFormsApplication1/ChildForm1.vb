Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DragDataBetweenMdiTabbedForms
	Partial Public Class ChildForm1
		Inherits XtraForm
		Private startPoint As Point

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub listBoxControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControl1.MouseDown
			Dim listBox As ListBoxControl = TryCast(sender, ListBoxControl)
			startPoint = New Point(e.X, e.Y)
			Dim selectedIndex As Integer = listBox.IndexFromPoint(startPoint)
			If selectedIndex = -1 Then
				startPoint = Point.Empty
			End If
		End Sub

		Private Sub listBoxControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles listBoxControl1.MouseMove
			Dim listBox As ListBoxControl = TryCast(sender, ListBoxControl)
			If e.Button = MouseButtons.Left Then
				If (startPoint <> Point.Empty) AndAlso ((Math.Abs(e.X - startPoint.X) > SystemInformation.DragSize.Width) OrElse (Math.Abs(e.Y - startPoint.Y) > SystemInformation.DragSize.Height)) Then
					listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Copy)
				End If
			End If
		End Sub
	End Class
End Namespace