Imports Microsoft.VisualBasic
Imports System
Namespace DragDataBetweenMdiTabbedForms
	Partial Public Class ChildForm2
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.AllowDrop = True
			Me.listBoxControl1.Location = New System.Drawing.Point(12, 12)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(186, 157)
			Me.listBoxControl1.TabIndex = 1
'			Me.listBoxControl1.DragOver += New System.Windows.Forms.DragEventHandler(Me.listBoxControl1_DragOver);
'			Me.listBoxControl1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.listBoxControl1_DragDrop);
			' 
			' ChildForm2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(407, 287)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Name = "ChildForm2"
			Me.Text = "ChildForm2"
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents listBoxControl1 As DevExpress.XtraEditors.ListBoxControl

	End Class
End Namespace