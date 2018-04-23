namespace DXApplication1
{
    partial class XtraUserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customizationPropertyGrid1 = new DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid();
            this.hiddenItemsList1 = new DevExpress.XtraLayout.Customization.Controls.HiddenItemsList();
            this.layoutTreeView1 = new DevExpress.XtraLayout.Customization.Controls.LayoutTreeView();
            this.buttonsPanel1 = new DevExpress.XtraLayout.Customization.Controls.ButtonsPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // customizationPropertyGrid1
            // 
            this.customizationPropertyGrid1.Location = new System.Drawing.Point(341, 12);
            this.customizationPropertyGrid1.Name = "customizationPropertyGrid1";
            this.customizationPropertyGrid1.Size = new System.Drawing.Size(159, 364);
            // 
            // hiddenItemsList1
            // 
            this.hiddenItemsList1.Location = new System.Drawing.Point(12, 43);
            this.hiddenItemsList1.Name = "hiddenItemsList1";
            this.hiddenItemsList1.Size = new System.Drawing.Size(325, 113);
            // 
            // layoutTreeView1
            // 
            this.layoutTreeView1.Location = new System.Drawing.Point(12, 160);
            this.layoutTreeView1.Name = "layoutTreeView1";
            this.layoutTreeView1.Role = DevExpress.XtraLayout.Customization.Controls.TreeViewRoles.LayoutTreeView;
            this.layoutTreeView1.ShowHiddenItemsInTreeView = true;
            this.layoutTreeView1.Size = new System.Drawing.Size(325, 216);
            // 
            // buttonsPanel1
            // 
            this.buttonsPanel1.Location = new System.Drawing.Point(12, 12);
            this.buttonsPanel1.Name = "buttonsPanel1";
            this.buttonsPanel1.Size = new System.Drawing.Size(325, 27);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.hiddenItemsList1);
            this.layoutControl1.Controls.Add(this.layoutTreeView1);
            this.layoutControl1.Controls.Add(this.customizationPropertyGrid1);
            this.layoutControl1.Controls.Add(this.buttonsPanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(960, 192, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(512, 388);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(512, 388);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.buttonsPanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(329, 31);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.customizationPropertyGrid1;
            this.layoutControlItem2.Location = new System.Drawing.Point(329, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(163, 368);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.layoutTreeView1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(329, 220);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.hiddenItemsList1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(329, 117);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // XtraUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 388);
            this.Controls.Add(this.layoutControl1);
            this.Name = "XtraUserControl1";
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid customizationPropertyGrid1;
        private DevExpress.XtraLayout.Customization.Controls.HiddenItemsList hiddenItemsList1;
        private DevExpress.XtraLayout.Customization.Controls.LayoutTreeView layoutTreeView1;
        private DevExpress.XtraLayout.Customization.Controls.ButtonsPanel buttonsPanel1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
