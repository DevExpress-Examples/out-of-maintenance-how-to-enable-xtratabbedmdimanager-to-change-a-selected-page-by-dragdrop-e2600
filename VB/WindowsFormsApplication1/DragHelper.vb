Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Mdi
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports DevExpress.XtraTabbedMdi

Namespace DragDataBetweenMdiTabbedForms
	Public Class DragHelper
		Private manager As XtraTabbedMdiManager

		Public Sub New(ByVal manager As XtraTabbedMdiManager)
			Me.manager = manager
		End Sub

		Public WriteOnly Property SelectNewPageOnDrag() As Boolean
			Set(ByVal value As Boolean)
				RemoveHandler MdiClient.DragOver, AddressOf OnMdiClientDragOver
				If value Then
					AddHandler MdiClient.DragOver, AddressOf OnMdiClientDragOver
				End If
			End Set
		End Property

		Private ReadOnly Property MdiClient() As MdiClient
			Get
				Return MdiClientSubclasser.GetMdiClient(manager.MdiParent)
			End Get
		End Property

		Protected Sub OnMdiClientDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			Dim xtraTab As IXtraTab = TryCast(manager, IXtraTab)
			Dim p As Point = xtraTab.ScreenPointToControl(New Point(e.X, e.Y))
			Dim hitInfo As BaseTabHitInfo = manager.CalcHitInfo(p)
			If hitInfo.HitTest = XtraTabHitTest.PageHeader Then
				manager.SelectedPage = CType(hitInfo.Page, XtraMdiTabPage)
			End If
		End Sub
	End Class
End Namespace
