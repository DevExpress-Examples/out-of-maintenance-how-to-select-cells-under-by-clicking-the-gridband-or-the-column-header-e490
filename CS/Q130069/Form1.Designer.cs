namespace Q130069 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carsDBDataSet = new Q130069.CarsDBDataSet();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTrademark = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colModel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTransmissAutomatic = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTransmissSpeedCount = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colLiter = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCyl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colCategory = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.carsTableAdapter = new Q130069.CarsDBDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.bandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(954, 452);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Cars";
            this.bindingSource1.DataSource = this.carsDBDataSet;
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colID,
            this.colTrademark,
            this.colModel,
            this.colLiter,
            this.colCyl,
            this.colTransmissSpeedCount,
            this.colTransmissAutomatic,
            this.colCategory,
            this.colPrice});
            this.bandedGridView1.GridControl = this.gridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsSelection.MultiSelect = true;
            this.bandedGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bandedGridView1_MouseDown);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "General Info";
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colTrademark);
            this.gridBand1.Columns.Add(this.colModel);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 150;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colTrademark
            // 
            this.colTrademark.Caption = "Trademark";
            this.colTrademark.FieldName = "Trademark";
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.Visible = true;
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Model";
            this.colModel.Name = "colModel";
            this.colModel.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Engine Info";
            this.gridBand2.Columns.Add(this.colTransmissAutomatic);
            this.gridBand2.Columns.Add(this.colTransmissSpeedCount);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 150;
            // 
            // colTransmissAutomatic
            // 
            this.colTransmissAutomatic.Caption = "TransmissAutomatic";
            this.colTransmissAutomatic.FieldName = "TransmissAutomatic";
            this.colTransmissAutomatic.Name = "colTransmissAutomatic";
            this.colTransmissAutomatic.Visible = true;
            // 
            // colTransmissSpeedCount
            // 
            this.colTransmissSpeedCount.Caption = "TransmissSpeedCount";
            this.colTransmissSpeedCount.FieldName = "TransmissSpeedCount";
            this.colTransmissSpeedCount.Name = "colTransmissSpeedCount";
            this.colTransmissSpeedCount.Visible = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Transmission Info";
            this.gridBand3.Columns.Add(this.colLiter);
            this.gridBand3.Columns.Add(this.colCyl);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 150;
            // 
            // colLiter
            // 
            this.colLiter.Caption = "Liter";
            this.colLiter.FieldName = "Liter";
            this.colLiter.Name = "colLiter";
            this.colLiter.Visible = true;
            // 
            // colCyl
            // 
            this.colCyl.Caption = "Cyl";
            this.colCyl.FieldName = "Cyl";
            this.colCyl.Name = "colCyl";
            this.colCyl.Visible = true;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Misc Info";
            this.gridBand4.Columns.Add(this.colCategory);
            this.gridBand4.Columns.Add(this.colPrice);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 150;
            // 
            // colCategory
            // 
            this.colCategory.Caption = "Category";
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 452);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Q130069.CarsDBDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTrademark;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colModel;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTransmissAutomatic;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTransmissSpeedCount;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLiter;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCyl;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCategory;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPrice;
    }
}

