Imports Microsoft.VisualBasic
Imports System
Namespace Q130069
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet = New Q130069.CarsDBDataSet()
			Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colTrademark = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colModel = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colTransmissAutomatic = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colTransmissSpeedCount = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colLiter = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCyl = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colCategory = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.carsTableAdapter = New Q130069.CarsDBDataSetTableAdapters.CarsTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bindingSource1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.bandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(954, 452)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.bandedGridView1})
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Cars"
			Me.bindingSource1.DataSource = Me.carsDBDataSet
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' bandedGridView1
			' 
			Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2, Me.gridBand3, Me.gridBand4})
			Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colID, Me.colTrademark, Me.colModel, Me.colLiter, Me.colCyl, Me.colTransmissSpeedCount, Me.colTransmissAutomatic, Me.colCategory, Me.colPrice})
			Me.bandedGridView1.GridControl = Me.gridControl1
			Me.bandedGridView1.Name = "bandedGridView1"
			Me.bandedGridView1.OptionsSelection.MultiSelect = True
			Me.bandedGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
'			Me.bandedGridView1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.bandedGridView1_MouseDown);
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "General Info"
			Me.gridBand1.Columns.Add(Me.colID)
			Me.gridBand1.Columns.Add(Me.colTrademark)
			Me.gridBand1.Columns.Add(Me.colModel)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 150
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.OptionsColumn.ShowInCustomizationForm = False
			' 
			' colTrademark
			' 
			Me.colTrademark.Caption = "Trademark"
			Me.colTrademark.FieldName = "Trademark"
			Me.colTrademark.Name = "colTrademark"
			Me.colTrademark.Visible = True
			' 
			' colModel
			' 
			Me.colModel.Caption = "Model"
			Me.colModel.FieldName = "Model"
			Me.colModel.Name = "colModel"
			Me.colModel.Visible = True
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Engine Info"
			Me.gridBand2.Columns.Add(Me.colTransmissAutomatic)
			Me.gridBand2.Columns.Add(Me.colTransmissSpeedCount)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 150
			' 
			' colTransmissAutomatic
			' 
			Me.colTransmissAutomatic.Caption = "TransmissAutomatic"
			Me.colTransmissAutomatic.FieldName = "TransmissAutomatic"
			Me.colTransmissAutomatic.Name = "colTransmissAutomatic"
			Me.colTransmissAutomatic.Visible = True
			' 
			' colTransmissSpeedCount
			' 
			Me.colTransmissSpeedCount.Caption = "TransmissSpeedCount"
			Me.colTransmissSpeedCount.FieldName = "TransmissSpeedCount"
			Me.colTransmissSpeedCount.Name = "colTransmissSpeedCount"
			Me.colTransmissSpeedCount.Visible = True
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "Transmission Info"
			Me.gridBand3.Columns.Add(Me.colLiter)
			Me.gridBand3.Columns.Add(Me.colCyl)
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 150
			' 
			' colLiter
			' 
			Me.colLiter.Caption = "Liter"
			Me.colLiter.FieldName = "Liter"
			Me.colLiter.Name = "colLiter"
			Me.colLiter.Visible = True
			' 
			' colCyl
			' 
			Me.colCyl.Caption = "Cyl"
			Me.colCyl.FieldName = "Cyl"
			Me.colCyl.Name = "colCyl"
			Me.colCyl.Visible = True
			' 
			' gridBand4
			' 
			Me.gridBand4.Caption = "Misc Info"
			Me.gridBand4.Columns.Add(Me.colCategory)
			Me.gridBand4.Columns.Add(Me.colPrice)
			Me.gridBand4.Name = "gridBand4"
			Me.gridBand4.Width = 150
			' 
			' colCategory
			' 
			Me.colCategory.Caption = "Category"
			Me.colCategory.FieldName = "Category"
			Me.colCategory.Name = "colCategory"
			Me.colCategory.Visible = True
			' 
			' colPrice
			' 
			Me.colPrice.Caption = "Price"
			Me.colPrice.FieldName = "Price"
			Me.colPrice.Name = "colPrice"
			Me.colPrice.Visible = True
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(954, 452)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private carsDBDataSet As CarsDBDataSet
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private carsTableAdapter As Q130069.CarsDBDataSetTableAdapters.CarsTableAdapter
		Private WithEvents bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTrademark As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colModel As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colTransmissAutomatic As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTransmissSpeedCount As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colLiter As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCyl As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colCategory As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	End Class
End Namespace

