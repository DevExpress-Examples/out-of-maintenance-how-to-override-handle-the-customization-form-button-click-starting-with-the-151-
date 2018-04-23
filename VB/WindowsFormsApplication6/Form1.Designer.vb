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

Namespace WindowsFormsApplication6
	Partial Public Class Form1
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
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText
			Me.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = True
			Me.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText
			Me.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = True
			Me.layoutControl1.Location = New System.Drawing.Point(48, 7)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(409, 243)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Size = New System.Drawing.Size(409, 243)
			Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Text = "layoutControlGroup1"
			Me.layoutControlGroup1.TextVisible = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(494, 354)
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
	End Class
End Namespace

