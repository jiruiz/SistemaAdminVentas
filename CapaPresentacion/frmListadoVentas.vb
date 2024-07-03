Imports CapaEntidad
Imports CapaNegocio

Public Class frmListadoVentas
    Private listaVentas As New DataSet()
    Private Sub frmListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each column As DataGridViewColumn In dgVentas.Columns
            column.ReadOnly = False
        Next

        Call cargaVenta()
    End Sub

    Sub cargaVenta()
        Dim capaNegocio As New CNVenta
        listaVentas = capaNegocio.listadoVentas() ' Asignación de datos al DataSet

        dgVentas.DataSource = capaNegocio.listadoVentas.Tables("Ventas")
        lblTotalVentas.Text = capaNegocio.listadoVentas.Tables("Ventas").Rows.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgVentas.SelectedRows.Count > 0 Then
            Dim clienteID As Integer = Convert.ToInt32(dgVentas.SelectedRows(0).Cells("ID").Value)
            Dim capaNegocio As New CNVenta

            Dim cliente As New CEVenta With {
                .id = clienteID
            }

            capaNegocio.eliminarVenta(cliente)

            Call cargaVenta()
        Else
            MsgBox("Por favor, seleccione una venta para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub
End Class