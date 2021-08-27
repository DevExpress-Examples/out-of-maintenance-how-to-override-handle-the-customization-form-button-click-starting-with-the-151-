<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633045/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T243928)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DXApplication1/Form1.cs) (VB: [Form1.vb](./VB/DXApplication1/Form1.vb))
* [XtraUserControl1.cs](./CS/DXApplication1/XtraUserControl1.cs) (VB: [XtraUserControl1.vb](./VB/DXApplication1/XtraUserControl1.vb))
<!-- default file list end -->
# How to override (handle) the customization form button click starting with the 15.1 version


<p>This example is applied to version 15.1 and higher. If you are using an older version, please refer to the <a href="https://www.devexpress.com/Support/Center/Example/Details/E3439">How to override (handle) the customization form button click</a> example.</p>
<p>It is possible to accomplish this task by creating your custom Customization Form descendant. In this descendant create a custom ButtonPanel control and override its internal methods:</p>
<p><strong>OnSaveLayoutButtonClick</strong> <br /><strong>OnLoadLayoutButtonClick</strong> <br /><strong>OnRedoButtonClick</strong> <br /><strong>OnUndoButtonClick</strong></p>
<p>Note that inside ButtonPanels methods you can access a parent LayoutControl via the code snippet shown below:</p>


```cs
        protected override void OnSaveLayoutButtonClick(object sender, EventArgs e) {
            //((LayoutControl)OwnerControl) - LayoutControl that shows your own Customization form
            Form form =  ((LayoutControl)OwnerControl).FindForm(); //the form that contains a layout control (Form1 in this sample)
             base.OnSaveLayoutButtonClick(sender, e);
        }
```



<br/>


