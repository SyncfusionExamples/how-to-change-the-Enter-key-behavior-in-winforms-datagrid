using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Styles;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;

namespace GettingStarted
{   
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            var data = new OrderInfoCollection();
            sfDataGrid.DataSource = data.OrdersListDetails;

            this.sfDataGrid.SelectionController = new CustomSelectionController(sfDataGrid);
        }

        #endregion 
    }

    public class CustomSelectionController : Syncfusion.WinForms.DataGrid.Interactivity.RowSelectionController
    {
        SfDataGrid DataGrid;

        public CustomSelectionController(SfDataGrid sfDataGrid)
            : base(sfDataGrid)
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
}
