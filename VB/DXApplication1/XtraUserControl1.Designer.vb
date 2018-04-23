Namespace DXApplication1
	Partial Public Class XtraUserControl1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.customizationPropertyGrid1 = New DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid()
			Me.hiddenItemsList1 = New DevExpress.XtraLayout.Customization.Controls.HiddenItemsList()
			Me.layoutTreeView1 = New DevExpress.XtraLayout.Customization.Controls.LayoutTreeView()
			Me.buttonsPanel1 = New DevExpress.XtraLayout.Customization.Controls.ButtonsPanel()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.hiddenItemsList1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customizationPropertyGrid1
			' 
			Me.customizationPropertyGrid1.Location = New System.Drawing.Point(341, 12)
			Me.customizationPropertyGrid1.Name = "customizationPropertyGrid1"
			Me.customizationPropertyGrid1.Size = New System.Drawing.Size(159, 364)
			' 
			' hiddenItemsList1
			' 
			Me.hiddenItemsList1.Location = New System.Drawing.Point(12, 43)
			Me.hiddenItemsList1.Name = "hiddenItemsList1"
			Me.hiddenItemsList1.Size = New System.Drawing.Size(325, 113)
			' 
			' layoutTreeView1
			' 
			Me.layoutTreeView1.Location = New System.Drawing.Point(12, 160)
			Me.layoutTreeView1.Name = "layoutTreeView1"
			Me.layoutTreeView1.Role = DevExpress.XtraLayout.Customization.Controls.TreeViewRoles.LayoutTreeView
			Me.layoutTreeView1.ShowHiddenItemsInTreeView = True
			Me.layoutTreeView1.Size = New System.Drawing.Size(325, 216)
			' 
			' buttonsPanel1
			' 
			Me.buttonsPanel1.Location = New System.Drawing.Point(12, 12)
			Me.buttonsPanel1.Name = "buttonsPanel1"
			Me.buttonsPanel1.Size = New System.Drawing.Size(325, 27)
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.hiddenItemsList1)
			Me.layoutControl1.Controls.Add(Me.layoutTreeView1)
			Me.layoutControl1.Controls.Add(Me.customizationPropertyGrid1)
			Me.layoutControl1.Controls.Add(Me.buttonsPanel1)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(960, 192, 450, 400)
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(512, 388)
			Me.layoutControl1.TabIndex = 2
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem2})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "Root"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(512, 388)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.buttonsPanel1
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(329, 31)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.customizationPropertyGrid1
			Me.layoutControlItem2.Location = New System.Drawing.Point(329, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(163, 368)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.layoutTreeView1
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 148)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(329, 220)
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem3.TextVisible = False
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.hiddenItemsList1
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 31)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(329, 117)
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem4.TextVisible = False
			' 
			' XtraUserControl1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(512, 388)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "XtraUserControl1"
			DirectCast(Me.hiddenItemsList1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customizationPropertyGrid1 As DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid
		Private hiddenItemsList1 As DevExpress.XtraLayout.Customization.Controls.HiddenItemsList
		Private layoutTreeView1 As DevExpress.XtraLayout.Customization.Controls.LayoutTreeView
		Private buttonsPanel1 As DevExpress.XtraLayout.Customization.Controls.ButtonsPanel
		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
