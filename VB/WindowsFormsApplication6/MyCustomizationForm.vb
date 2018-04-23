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

Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout.Customization.Controls
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsFormsApplication6
	Public Class MyCustomizationForm
		Inherits CustomizationForm

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

		Private Sub InitializeComponent()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.buttonsPanelItem, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutTreeViewGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutTreeViewItem, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.hiddenItemsList1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.hiddenItemsListItem, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.propertyGridItem, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.hiddenItemsGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.panelTemplateItem, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.templateListGroup, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.templateList, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.templatesListLCI, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(739, 154, 746, 522)
			Me.layoutControl1.Size = New System.Drawing.Size(234, 311)
			Me.layoutControl1.Controls.SetChildIndex(Me.panelTemplate, 0)
			Me.layoutControl1.Controls.SetChildIndex(Me.templateList, 0)
			Me.layoutControl1.Controls.SetChildIndex(Me.buttonsPanel1, 0)
			Me.layoutControl1.Controls.SetChildIndex(Me.layoutTreeView1, 0)
			Me.layoutControl1.Controls.SetChildIndex(Me.hiddenItemsList1, 0)
			Me.layoutControl1.Controls.SetChildIndex(Me.customizationPropertyGrid1, 0)
			' 
			' layoutTreeView1
			' 
			Me.layoutTreeView1.Size = New System.Drawing.Size(68, 212)
			' 
			' buttonsPanel1
			' 
			Me.buttonsPanel1.Size = New System.Drawing.Size(100, 25)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.Size = New System.Drawing.Size(234, 311)
			' 
			' buttonsPanelItem
			' 
			Me.buttonsPanelItem.Size = New System.Drawing.Size(214, 29)
			' 
			' tabbedControlGroup1
			' 
			Me.tabbedControlGroup1.Size = New System.Drawing.Size(96, 262)
			' 
			' layoutTreeViewGroup
			' 
			Me.layoutTreeViewGroup.Size = New System.Drawing.Size(72, 216)
			' 
			' layoutTreeViewItem
			' 
			Me.layoutTreeViewItem.Size = New System.Drawing.Size(72, 216)
			' 
			' hiddenItemsList1
			' 
			Me.hiddenItemsList1.Size = New System.Drawing.Size(68, 212)
			' 
			' hiddenItemsListItem
			' 
			Me.hiddenItemsListItem.Size = New System.Drawing.Size(72, 216)
			' 
			' customizationPropertyGrid1
			' 
			Me.customizationPropertyGrid1.Location = New System.Drawing.Point(113, 172)
			Me.customizationPropertyGrid1.Size = New System.Drawing.Size(109, 127)
			' 
			' propertyGridItem
			' 
			Me.propertyGridItem.Location = New System.Drawing.Point(101, 160)
			Me.propertyGridItem.Size = New System.Drawing.Size(113, 131)
			' 
			' splitterItem1
			' 
			Me.splitterItem1.Location = New System.Drawing.Point(96, 29)
			Me.splitterItem1.Size = New System.Drawing.Size(5, 262)
			' 
			' hiddenItemsGroup
			' 
			Me.hiddenItemsGroup.Size = New System.Drawing.Size(72, 216)
			' 
			' panelTemplateItem
			' 
			Me.panelTemplateItem.Location = New System.Drawing.Point(101, 29)
			Me.panelTemplateItem.Size = New System.Drawing.Size(113, 131)
			' 
			' templateListGroup
			' 
			Me.templateListGroup.Size = New System.Drawing.Size(72, 216)
			' 
			' templateList
			' 
			Me.templateList.Size = New System.Drawing.Size(68, 212)
			' 
			' templatesListLCI
			' 
			Me.templatesListLCI.Size = New System.Drawing.Size(72, 216)
			' 
			' panelTemplate
			' 
			Me.panelTemplate.Location = New System.Drawing.Point(113, 41)
			Me.panelTemplate.Size = New System.Drawing.Size(109, 127)
			' 
			' MyCustomizationForm
			' 
			Me.ClientSize = New System.Drawing.Size(234, 311)
			Me.Name = "MyCustomizationForm"
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.buttonsPanelItem, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutTreeViewGroup, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutTreeViewItem, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.hiddenItemsList1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.hiddenItemsListItem, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.propertyGridItem, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.hiddenItemsGroup, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.panelTemplateItem, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.templateListGroup, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.templateList, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.templatesListLCI, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

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
