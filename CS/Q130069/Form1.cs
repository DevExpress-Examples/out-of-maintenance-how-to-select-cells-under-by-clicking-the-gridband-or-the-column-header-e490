using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.Utils;

namespace Q130069 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);

        }

        private void bandedGridView1_MouseDown(object sender, MouseEventArgs e) {
            if (Control.ModifierKeys != (Keys.Shift | Keys.Control)) return;
            BandedGridView view = (BandedGridView)sender;
            BandedGridHitInfo hInfo = view.CalcHitInfo(e.Location);
            if (hInfo.InColumn) {
                view.ClearSelection();
                SelectCells(hInfo.Column);
            } else if (hInfo.InBandPanel && hInfo.Band != null) {
                view.ClearSelection();
                SelectCells(hInfo.Band);
            } else
                return;
            ((DXMouseEventArgs)e).Handled = true;
        }

        private void SelectCells(BandedGridColumn column) {
            for (int i = 0; i < column.View.RowCount; i++)
                column.View.SelectCell(i, column);
        }

        private void SelectCells(GridBand band) {
            foreach (BandedGridColumn column in band.Columns)
                SelectCells(column);
        }
    }
}