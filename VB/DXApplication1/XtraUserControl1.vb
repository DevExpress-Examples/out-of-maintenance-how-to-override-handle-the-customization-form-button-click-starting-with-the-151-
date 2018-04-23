Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Customization.Controls
Imports DevExpress.XtraLayout

Namespace DXApplication1
	Partial Public Class XtraUserControl1
		Inherits DevExpress.XtraLayout.Customization.UserCustomizationForm

		Public Sub New()
			InitializeComponent()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Dim lci As LayoutControlItem = layoutControl1.GetItemByControl(buttonsPanel1)
			Dim oldPanel As ButtonsPanel = TryCast(lci.Control, ButtonsPanel)
			Dim newPanel As New MyButtonsPanel()
			oldPanel.UnRegister()
			lci.BeginInit()
			lci.Control = newPanel
			newPanel.Parent = oldPanel.Parent
			oldPanel.Parent = Nothing
			lci.EndInit()
			newPanel.Register()
			lci.Update()
		End Sub
	End Class
	Public Class MyButtonsPanel
		Inherits ButtonsPanel

		Protected Overrides Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Save Layout Button")
			MyBase.OnSaveLayoutButtonClick(sender, e)

		End Sub
		Protected Overrides Sub OnLoadLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Load Layout Button")
			MyBase.OnLoadLayoutButtonClick(sender, e)

		End Sub

		Protected Overrides Sub OnRedoButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Redo Button")
			MyBase.OnRedoButtonClick(sender, e)
		End Sub

		Protected Overrides Sub OnUndoButtonClick(ByVal sender As Object, ByVal e As EventArgs)
			MessageBox.Show("Undo Button")
			MyBase.OnUndoButtonClick(sender, e)
		End Sub

	End Class
End Namespace
