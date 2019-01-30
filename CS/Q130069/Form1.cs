using DevExpress.Utils;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using System;
using System.Data;
using System.Windows.Forms;

namespace Q130069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bandedGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys != (Keys.Shift | Keys.Control)) return;
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hInfo = view.CalcHitInfo(e.Location);
            if (hInfo.InColumn)
            {
                view.ClearSelection();
                SelectCells(hInfo.Column);
            }
            else if (hInfo.InBandPanel && hInfo.Band != null)
            {
                view.ClearSelection();
                SelectCells(hInfo.Band);
            }
            else
                return;
            ((DXMouseEventArgs)e).Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = GetPersonDataTable();

        }
        DataTable GetPersonDataTable()
        {
            DataTable table = new DataTable();
            table.TableName = "Persons";
            table.Columns.Add(new DataColumn("FirstName", typeof(string)));
            table.Columns.Add(new DataColumn("SecondName", typeof(string)));
            table.Columns.Add(new DataColumn("Age", typeof(int)));
            table.Columns.Add(new DataColumn("ID", typeof(int)));
            for (int i = 0; i < 50; i++)
                table.Rows.Add("FirstName " + i, "SecondName " + i, 20 + i / 2, i);
            return table;
        }

        private void SelectCells(BandedGridColumn column)
        {
            for (int i = 0; i < column.View.RowCount; i++)
                column.View.SelectCell(i, column);
        }

        private void SelectCells(GridBand band)
        {
            foreach (BandedGridColumn column in band.Columns)
                SelectCells(column);
        }
    }
}