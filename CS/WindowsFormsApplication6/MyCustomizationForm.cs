// Developer Express Code Central Example:
// How to override (handle) the customization form button click
// 
// It is possible to accomplish this task by creating your custom Customization
// Form descendant. In this descendant create a custom ButtonPanel control and
// override its internal methods:
// OnSaveLayoutButtonClick OnLoadLayoutButtonClick
// OnRedoButtonClick OnUndoButtonClick
// Note that inside ButtonPanels methods you
// can access a parent LayoutControl via the code snippet shown below:    protected
// override void OnSaveLayoutButtonClick(object sender, EventArgs e) {
// //((LayoutControl)OwnerControl) - LayoutControl that shows your own
// Customization form      Form form = ((LayoutControl)OwnerControl).FindForm();
// //the form that contains a layout control (Form1 in this sample)
// base.OnSaveLayoutButtonClick(sender, e);    }
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3439

using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Customization.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public class MyCustomizationForm : CustomizationForm
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LayoutControlItem lci = layoutControl1.GetItemByControl(buttonsPanel1);
            ButtonsPanel oldPanel = lci.Control as ButtonsPanel;
            MyButtonsPanel newPanel = new MyButtonsPanel();
            oldPanel.UnRegister();
            lci.BeginInit();
            lci.Control = newPanel;
            newPanel.Parent = oldPanel.Parent;
            oldPanel.Parent = null;
            lci.EndInit();
            newPanel.Register();
            lci.Update();
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsPanelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTreeViewGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTreeViewItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsListItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTemplateItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateListGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesListLCI)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(739, 154, 746, 522);
            this.layoutControl1.Size = new System.Drawing.Size(234, 311);
            this.layoutControl1.Controls.SetChildIndex(this.panelTemplate, 0);
            this.layoutControl1.Controls.SetChildIndex(this.templateList, 0);
            this.layoutControl1.Controls.SetChildIndex(this.buttonsPanel1, 0);
            this.layoutControl1.Controls.SetChildIndex(this.layoutTreeView1, 0);
            this.layoutControl1.Controls.SetChildIndex(this.hiddenItemsList1, 0);
            this.layoutControl1.Controls.SetChildIndex(this.customizationPropertyGrid1, 0);
            // 
            // layoutTreeView1
            // 
            this.layoutTreeView1.Size = new System.Drawing.Size(68, 212);
            // 
            // buttonsPanel1
            // 
            this.buttonsPanel1.Size = new System.Drawing.Size(100, 25);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Size = new System.Drawing.Size(234, 311);
            // 
            // buttonsPanelItem
            // 
            this.buttonsPanelItem.Size = new System.Drawing.Size(214, 29);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Size = new System.Drawing.Size(96, 262);
            // 
            // layoutTreeViewGroup
            // 
            this.layoutTreeViewGroup.Size = new System.Drawing.Size(72, 216);
            // 
            // layoutTreeViewItem
            // 
            this.layoutTreeViewItem.Size = new System.Drawing.Size(72, 216);
            // 
            // hiddenItemsList1
            // 
            this.hiddenItemsList1.Size = new System.Drawing.Size(68, 212);
            // 
            // hiddenItemsListItem
            // 
            this.hiddenItemsListItem.Size = new System.Drawing.Size(72, 216);
            // 
            // customizationPropertyGrid1
            // 
            this.customizationPropertyGrid1.Location = new System.Drawing.Point(113, 172);
            this.customizationPropertyGrid1.Size = new System.Drawing.Size(109, 127);
            // 
            // propertyGridItem
            // 
            this.propertyGridItem.Location = new System.Drawing.Point(101, 160);
            this.propertyGridItem.Size = new System.Drawing.Size(113, 131);
            // 
            // splitterItem1
            // 
            this.splitterItem1.Location = new System.Drawing.Point(96, 29);
            this.splitterItem1.Size = new System.Drawing.Size(5, 262);
            // 
            // hiddenItemsGroup
            // 
            this.hiddenItemsGroup.Size = new System.Drawing.Size(72, 216);
            // 
            // panelTemplateItem
            // 
            this.panelTemplateItem.Location = new System.Drawing.Point(101, 29);
            this.panelTemplateItem.Size = new System.Drawing.Size(113, 131);
            // 
            // templateListGroup
            // 
            this.templateListGroup.Size = new System.Drawing.Size(72, 216);
            // 
            // templateList
            // 
            this.templateList.Size = new System.Drawing.Size(68, 212);
            // 
            // templatesListLCI
            // 
            this.templatesListLCI.Size = new System.Drawing.Size(72, 216);
            // 
            // panelTemplate
            // 
            this.panelTemplate.Location = new System.Drawing.Point(113, 41);
            this.panelTemplate.Size = new System.Drawing.Size(109, 127);
            // 
            // MyCustomizationForm
            // 
            this.ClientSize = new System.Drawing.Size(234, 311);
            this.Name = "MyCustomizationForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsPanelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTreeViewGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutTreeViewItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsListItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenItemsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelTemplateItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateListGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesListLCI)).EndInit();
            this.ResumeLayout(false);

        }
    }
    public class MyButtonsPanel : ButtonsPanel
    {
        protected override void OnSaveLayoutButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Save Layout Button");
            base.OnSaveLayoutButtonClick(sender, e);

        }
        protected override void OnLoadLayoutButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Load Layout Button");
            base.OnLoadLayoutButtonClick(sender, e);

        }

        protected override void OnRedoButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Redo Button");
            base.OnRedoButtonClick(sender, e);
        }

        protected override void OnUndoButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Undo Button");
            base.OnUndoButtonClick(sender, e);
        }

    }
}
