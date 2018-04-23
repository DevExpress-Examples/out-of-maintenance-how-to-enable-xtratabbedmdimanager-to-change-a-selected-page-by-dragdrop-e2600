Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTabbedMdi

Namespace DragDataBetweenMdiTabbedForms
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim childForm1 As New ChildForm1()
			childForm1.MdiParent = Me
			childForm1.Show()

			Dim childForm2 As New ChildForm2()
			childForm2.MdiParent = Me
			childForm2.Show()
			childForm1.BringToFront()

			Dim mdiClient As MdiClient = XtraTabbedMdiManager.GetMdiClient(Me)
			AddHandler mdiClient.DragOver, AddressOf mdiClient_DragOver
		End Sub

		Protected Sub mdiClient_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			Dim p = CType(Me.XtraTabbedMdiManager1, DevExpress.XtraTab.IXtraTab).ScreenPointToControl(New Point(e.X, e.Y))
			Dim hitInfo As BaseTabHitInfo = xtraTabbedMdiManager1.CalcHitInfo(p)
			If hitInfo.HitTest = XtraTabHitTest.PageHeader Then
				xtraTabbedMdiManager1.SelectedPage = CType(hitInfo.Page, XtraMdiTabPage)
			End If
		End Sub
	End Class
End Namespace
