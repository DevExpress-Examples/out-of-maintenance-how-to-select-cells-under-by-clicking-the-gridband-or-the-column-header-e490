Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports System
Imports System.Data
Imports System.Windows.Forms


Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub bandedGridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles bandedGridView1.MouseDown
        If Control.ModifierKeys <> (Keys.Shift Or Keys.Control) Then Return
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

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        bindingSource1.DataSource = GetPersonDataTable()
    End Sub

    Private Function GetPersonDataTable() As DataTable
        Dim table As DataTable = New DataTable()
        table.TableName = "Persons"
        table.Columns.Add(New DataColumn("FirstName", GetType(String)))
        table.Columns.Add(New DataColumn("SecondName", GetType(String)))
        table.Columns.Add(New DataColumn("Age", GetType(Integer)))
        table.Columns.Add(New DataColumn("ID", GetType(Integer)))

        For i As Integer = 0 To 50 - 1
            table.Rows.Add("FirstName " & i, "SecondName " & i, 20 + i / 2, i)
        Next

        Return table
    End Function

    Private Sub SelectCells(ByVal column As BandedGridColumn)
        For i As Integer = 0 To column.View.RowCount - 1
            column.View.SelectCell(i, column)
        Next
    End Sub

    Private Sub SelectCells(ByVal band As GridBand)
        For Each column As BandedGridColumn In band.Columns
            SelectCells(column)
        Next
    End Sub
End Class
