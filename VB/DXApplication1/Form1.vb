Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler Me.Load, AddressOf Form1_Load
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
			layoutControl1.RegisterUserCustomizationForm(GetType(XtraUserControl1))
		End Sub
	End Class
End Namespace
