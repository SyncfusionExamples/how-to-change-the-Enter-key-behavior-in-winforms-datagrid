# How to Change the Enter Key Behavior in WinForms DataGrid?

This example illustrates how to change the Enter key behavior in [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid) (SfDataGrid).

When pressing the Enter key, the current cell will be moved to the next row in DataGrid, by default. You can change this behavior like, Tab key that moves the current cell to the next cell on the same row by writing a custom [RowSelectionController](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.Interactivity.RowSelectionController.html) overriding method [HandleKeyOperations](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.Interactivity.SelectionControllerBase.html#Syncfusion_WinForms_DataGrid_Interactivity_SelectionControllerBase_HandleKeyOperations_System_Windows_Forms_KeyEventArgs_).

### C#

``` csharp
public Form1()
{
    InitializeComponent();
    this.sfDataGrid.SelectionController = new CustomSelectionController(sfDataGrid);
}
 
public class CustomSelectionController : Syncfusion.WinForms.DataGrid.Interactivity.RowSelectionController
{
    SfDataGrid DataGrid;
 
    public CustomSelectionController(SfDataGrid sfDataGrid) : base(sfDataGrid)
    {
        this.DataGrid = sfDataGrid;
    }
 
    protected override void HandleKeyOperations(KeyEventArgs args)
    {
        if (args.KeyCode == Keys.Enter)
        {
            KeyEventArgs arguments = new KeyEventArgs(Keys.Tab);
            base.HandleKeyOperations(arguments);
            return;
        }
        base.HandleKeyOperations(args);
    }
}
```

### VB

``` vb
Public Sub New()
    InitializeComponent()
    Me.sfDataGrid.SelectionController = New CustomSelectionController(sfDataGrid)
End Sub
 
Public Class CustomSelectionController Inherits Syncfusion.WinForms.DataGrid.Interactivity.RowSelectionController

    Private DataGrid As SfDataGrid
    Public Sub New(ByVal sfDataGrid As SfDataGrid)
        MyBase.New(sfDataGrid)
        Me.DataGrid = sfDataGrid
    End Sub
 
    Protected Overrides Sub HandleKeyOperations(ByVal args As KeyEventArgs)
       If args.KeyCode = Keys.Enter Then
         Dim arguments As New KeyEventArgs(Keys.Tab)
         MyBase.HandleKeyOperations(arguments)
         Return
       End If
       MyBase.HandleKeyOperations(args)
    End Sub
End Class
```