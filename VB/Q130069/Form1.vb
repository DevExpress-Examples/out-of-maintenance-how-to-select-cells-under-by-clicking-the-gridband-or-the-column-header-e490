Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.Utils

Namespace Q130069
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet.Cars)

		End Sub

		Private Sub bandedGridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles bandedGridView1.MouseDown
			If Control.ModifierKeys <> (Keys.Shift Or Keys.Control) Then
				Return
			End If
			Dim view As BandedGridView = CType(sender, BandedGridView)
			Dim hInfo As BandedGridHitInfo = view.CalcHitInfo(e.Location)
			If hInfo.InColumn Then
				view.ClearSelection()
				SelectCells(hInfo.Column)
			ElseIf hInfo.InBandPanel AndAlso hInfo.Band IsNot Nothing Then
				view.ClearSelection()
				SelectCells(hInfo.Band)
			Else
				Return
			End If
			CType(e, DXMouseEventArgs).Handled = True
		End Sub

		Private Sub SelectCells(ByVal column As BandedGridColumn)
			For i As Integer = 0 To column.View.RowCount - 1
				column.View.SelectCell(i, column)
			Next i
		End Sub

		Private Sub SelectCells(ByVal band As GridBand)
			For Each column As BandedGridColumn In band.Columns
				SelectCells(column)
			Next column
		End Sub
	End Class
End Namespace