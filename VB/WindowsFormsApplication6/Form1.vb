' Developer Express Code Central Example:
' How to override (handle) the customization form button click
' 
' It is possible to accomplish this task by creating your custom Customization
' Form descendant. In this descendant create a custom ButtonPanel control and
' override its internal methods:
' OnSaveLayoutButtonClick OnLoadLayoutButtonClick
' OnRedoButtonClick OnUndoButtonClick
' Note that inside ButtonPanels methods you
' can access a parent LayoutControl via the code snippet shown below:    protected
' override void OnSaveLayoutButtonClick(object sender, EventArgs e) {
' //((LayoutControl)OwnerControl) - LayoutControl that shows your own
' Customization form      Form form = ((LayoutControl)OwnerControl).FindForm();
' //the form that contains a layout control (Form1 in this sample)
' base.OnSaveLayoutButtonClick(sender, e);    }
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3439

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Customization.Controls

Namespace WindowsFormsApplication6
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			layoutControl1.RegisterUserCustomizationForm(GetType(MyCustomizationForm))
		End Sub
	End Class

End Namespace
