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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication6 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
