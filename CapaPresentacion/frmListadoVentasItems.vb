Imports CapaEntidad
Imports CapaNegocio

Public Class frmListadoVentasItems
    Private listaVentasItems As New DataSet()

    Private Sub frmListadoVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each column As DataGridViewColumn In dgvVentasItems.Columns
            column.ReadOnly = False
        Next

        CargarVentaItem()
    End Sub

    Private Sub CargarVentaItem()
        Try
            Dim capaNegocio As New CNVentaItem
            listaVentasItems = capaNegocio.ListarVentasItems()

            dgvVentasItems.DataSource = listaVentasItems.Tables("ventasitems")
            lblTotalVentasItem.Text = listaVentasItems.Tables("ventasitems").Rows.Count.ToString()
        Catch ex As Exception
            MsgBox("Error al cargar los items de venta: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnEliminarItem_Click(sender As Object, e As EventArgs) Handles btnEliminarItem.Click
        If dgvVentasItems.SelectedRows.Count > 0 Then
            Dim itemID As Integer = Convert.ToInt32(dgvVentasItems.SelectedRows(0).Cells("ID").Value)
            Dim capaNegocio As New CNVentaItem

            Dim item As New CEVentaItem With {
                .id = itemID
            }

            capaNegocio.EliminarVentaItem(item)
            CargarVentaItem()
        Else
            MsgBox("Por favor, seleccione un item de venta para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try
            Dim filtro As String = txtBusqueda.Text.Trim()

            If filtro <> "" Then
                Dim itemsFiltrados = From row In listaVentasItems.Tables("ventasitems").AsEnumerable()
                                     Where row.Field(Of Integer)("ID").ToString().Contains(filtro) OrElse
                                       row.Field(Of Integer)("IDVenta").ToString().Contains(filtro)
                                     Select row

                Dim itemsFiltradosDataTable As DataTable = itemsFiltrados.CopyToDataTable()

                dgvVentasItems.DataSource = itemsFiltradosDataTable
                lblTotalVentasItem.Text = itemsFiltradosDataTable.Rows.Count.ToString()
            Else
                dgvVentasItems.DataSource = listaVentasItems.Tables("ventasitems")
                lblTotalVentasItem.Text = listaVentasItems.Tables("ventasitems").Rows.Count.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error al filtrar: {ex.Message}")
        End Try
    End Sub


End Class
