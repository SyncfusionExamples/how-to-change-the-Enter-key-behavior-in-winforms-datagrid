# how-to-change-the-Enter-key-behavior-in-winforms-datagrid

This example illustrates how to change the Enter key behavior in [WinForms DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid).

When pressing the Enter key, the current cell will be moved to the next row in [DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid), by default. You can change this behavior like, Tab key that moves the current cell to the next cell on the same row by writing a custom SelectionController and overriding the [HandleKeyOperations](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.Interactivity.SelectionControllerBase.html#Syncfusion_WinForms_DataGrid_Interactivity_SelectionControllerBase_HandleKeyOperations_System_Windows_Forms_KeyEventArgs_) method, which Handles selection when any of the Key operations such as Up, Down, Left, Right, Enter, etc., are performed in [DataGrid](https://www.syncfusion.com/winforms-ui-controls/datagrid).

KB article: https://support.syncfusion.com/kb/article/8625/how-to-change-the-enter-key-behavior-in-winforms-datagrid-sfdatagrid