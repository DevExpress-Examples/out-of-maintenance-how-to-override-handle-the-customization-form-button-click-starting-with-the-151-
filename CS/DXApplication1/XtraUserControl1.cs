using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization.Controls;
using DevExpress.XtraLayout;

namespace DXApplication1
{
    public partial class XtraUserControl1 : DevExpress.XtraLayout.Customization.UserCustomizationForm
    {
        public XtraUserControl1()
        {
            InitializeComponent();
        }
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
