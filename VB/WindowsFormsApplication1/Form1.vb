Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Mdi
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTabbedMdi

Namespace DragDataBetweenMdiTabbedForms
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private helper As DragHelper
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim childForm1 As New ChildForm1()
			childForm1.MdiParent = Me
			childForm1.Show()

			Dim childForm2 As New ChildForm2()
			childForm2.MdiParent = Me
			childForm2.Show()
			childForm1.BringToFront()

			helper = New DragHelper(xtraTabbedMdiManager1)
			helper.SelectNewPageOnDrag = True
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			helper.SelectNewPageOnDrag = False
		End Sub
	End Class

End Namespace
