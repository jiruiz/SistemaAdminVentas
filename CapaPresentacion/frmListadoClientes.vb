Imports CapaEntidad
Imports CapaNegocio
Public Class frmListadoClientes
    Private listaClientes As New DataSet()

    Private Sub frmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each column As DataGridViewColumn In dgClientes.Columns
            column.ReadOnly = False
        Next

        Call cargaClientes()
    End Sub

    Sub cargaClientes()
        Dim capaNegocio As New CNCliente
        listaClientes = capaNegocio.listadoClientes()

        dgClientes.DataSource = capaNegocio.listadoClientes.Tables("Clientes")
        ldlTotalClientes.Text = capaNegocio.listadoClientes.Tables("Clientes").Rows.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        If dgClientes.SelectedRows.Count > 0 Then
            Dim clienteID As Integer = Convert.ToInt32(dgClientes.SelectedRows(0).Cells("ID").Value)
            Dim capaNegocio As New CNCliente

            Dim cliente As New CECliente With {
                .id = clienteID
            }

            capaNegocio.eliminarCliente(cliente)

            Call cargaClientes()
        Else
            MsgBox("Por favor, seleccione un cliente para eliminar.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnGuardarCambiosCliente_Click(sender As Object, e As EventArgs) Handles btnGuardarCambiosCliente.Click
        For Each row As DataGridViewRow In dgClientes.Rows
            If Not row.IsNewRow Then
                Dim clienteID As Integer = Convert.ToInt32(row.Cells("ID").Value)
                Dim clienteNombre As String = row.Cells("Cliente").Value.ToString()
                Dim telefono As String = row.Cells("Telefono").Value.ToString()
                Dim correo As String = row.Cells("Correo").Value.ToString()

                Dim cliente As New CECliente With {
                    .id = clienteID,
                    .cliente = clienteNombre,
                    .telefono = telefono,
                    .correo = correo
                }

                Dim capaNegocio As New CNCliente
                capaNegocio.modificarCliente(cliente)
            End If
        Next

        Call cargaClientes()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        Try
            If listaClientes IsNot Nothing AndAlso listaClientes.Tables.Contains("clientes") Then
                Dim filtro As String = txtBusqueda.Text.Trim()

                If filtro <> "" Then
                    ' Filtrar usando LINQ 
                    Dim productosFiltrados = From row In listaClientes.Tables("clientes").AsEnumerable()
                                             Where row.Field(Of String)("Cliente").ToLower().Contains(filtro.ToLower()) OrElse
                                               row.Field(Of String)("Correo").ToLower().Contains(filtro.ToLower())
                                             Select row

                    Dim productosFiltradosDataTable As DataTable = productosFiltrados.CopyToDataTable()

                    dgClientes.DataSource = productosFiltradosDataTable

                    ldlTotalClientes.Text = productosFiltradosDataTable.Rows.Count.ToString()
                Else
                    dgClientes.DataSource = listaClientes.Tables("clientes")
                    ldlTotalClientes.Text = listaClientes.Tables("clientes").Rows.Count.ToString()
                End If
            Else
                MessageBox.Show("Error: listaClientes no está inicializado correctamente o no contiene la tabla 'productos'.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        End Try
    End Sub


End Class
