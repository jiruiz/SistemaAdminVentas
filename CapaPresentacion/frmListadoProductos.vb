Imports CapaEntidad
Imports CapaNegocio
Public Class frmListadoProductos
    Private listaProductos As New DataSet()
    Private Sub frmListadoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each column As DataGridViewColumn In dgProductos.Columns
            column.ReadOnly = False
        Next

        Call cargaProductos()
    End Sub
    Sub cargaProductos()
        Dim capaNegocio As New CNProducto
        listaProductos = capaNegocio.listadoProductos()

        dgProductos.DataSource = capaNegocio.listadoProductos.Tables("Productos")
        lblTotalProductos.Text = capaNegocio.listadoProductos.Tables("Productos").Rows.Count
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If dgProductos.SelectedRows.Count > 0 Then
            Dim productpoID As Integer = Convert.ToInt32(dgProductos.SelectedRows(0).Cells("ID").Value)
            Dim capaNegocio As New CNProducto

            Dim producto As New CEProducto With {
                .id = productpoID
            }

            capaNegocio.elimiarProducto(producto)

            Call cargaProductos()
        Else
            MsgBox("Por favor, seleccione la fila para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnGuardarCambiosProducto_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosProducto.Click
        For Each row As DataGridViewRow In dgProductos.Rows
            If Not row.IsNewRow Then
                Dim productoID As Integer = Convert.ToInt32(row.Cells("ID").Value)
                Dim productoNombre As String = row.Cells("Nombre").Value.ToString()
                Dim precio As Double = Convert.ToDouble(row.Cells("Precio").Value)
                Dim categoria As String = row.Cells("Categoria").Value.ToString()

                Dim producto As New CEProducto With {
                    .id = productoID,
                    .nombre = productoNombre,
                    .precio = precio,
                    .categoria = categoria
                }

                Dim capaNegocio As New CNProducto
                capaNegocio.modificarProducto(producto)
            End If
        Next

        Call cargaProductos()
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try
            If listaProductos IsNot Nothing AndAlso listaProductos.Tables.Contains("productos") Then
                Dim filtro As String = txtBusqueda.Text.Trim()

                If filtro <> "" Then
                    Dim productosFiltrados = From row In listaProductos.Tables("productos").AsEnumerable()
                                             Where row.Field(Of String)("Nombre").ToLower().Contains(filtro.ToLower()) OrElse
                                               row.Field(Of String)("Categoria").ToLower().Contains(filtro.ToLower())
                                             Select row

                    Dim productosFiltradosDataTable As DataTable = productosFiltrados.CopyToDataTable()

                    dgProductos.DataSource = productosFiltradosDataTable

                    lblTotalProductos.Text = productosFiltradosDataTable.Rows.Count.ToString()
                Else
                    dgProductos.DataSource = listaProductos.Tables("productos")
                    lblTotalProductos.Text = listaProductos.Tables("productos").Rows.Count.ToString()
                End If
            Else
                MessageBox.Show("Error: listaProductos no está inicializado correctamente o no contiene la tabla 'productos'.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub



End Class