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

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("WindowsFormsApplication6")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("WindowsFormsApplication6")>
<Assembly: AssemblyCopyright("Copyright ©  2009")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("0be61f12-2173-44b0-a4ed-aa0a2507fcc2")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
