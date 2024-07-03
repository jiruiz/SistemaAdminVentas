Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmItemVenta
    Public Property ClienteID As Integer
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("cn").ConnectionString
    Dim dtItems As New DataTable()
    Dim dtClientes As New DataTable()
    Dim dtProductos As New DataTable()

    Private Sub frmItemVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarProductos()
        ConfigurarTablaItems()
        dgvItems.DataSource = dtItems
    End Sub

    Private Sub ConfigurarTablaItems()
        dtItems.Columns.Add("IDProducto", GetType(Integer))
        dtItems.Columns.Add("Nombre", GetType(String))
        dtItems.Columns.Add("Cantidad", GetType(Integer))
        dtItems.Columns.Add("PrecioUnitario", GetType(Decimal))
        dtItems.Columns.Add("PrecioTotal", GetType(Decimal))
    End Sub

    Private Sub CargarClientes()
        dtClientes = ObtenerClientes()
        cbClientes.DataSource = dtClientes
        cbClientes.DisplayMember = "Cliente"
        cbClientes.ValueMember = "ID"
        If ClienteID > 0 Then
            cbClientes.SelectedValue = ClienteID
        End If
    End Sub

    Private Function ObtenerClientes() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ID, Cliente FROM clientes", conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using
        Return dt
    End Function

    Private Sub CargarProductos()
        dtProductos = ObtenerProductos()
        cbProductos.DataSource = dtProductos
        cbProductos.DisplayMember = "Nombre"
        cbProductos.ValueMember = "ID"
    End Sub

    Private Function ObtenerProductos() As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT ID, Nombre, Precio FROM productos", conn)
            conn.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            dt.Load(reader)
        End Using
        Return dt
    End Function

    Private Sub cbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProductos.SelectedIndexChanged
        Dim row As DataRowView = DirectCast(cbProductos.SelectedItem, DataRowView)
        txtPrecioUnitario.Text = row("Precio").ToString()
    End Sub

    Private Sub btnAgregarItem_Click(sender As Object, e As EventArgs) Handles btnAgregarItem.Click
        Try
            Dim productoID As Integer = Convert.ToInt32(cbProductos.SelectedValue)
            Dim nombre As String = cbProductos.Text
            Dim precioUnitario As Decimal = Convert.ToDecimal(txtPrecioUnitario.Text)
            Dim cantidad As Integer

            If Integer.TryParse(txtCantidad.Text, cantidad) AndAlso cantidad > 0 Then
                Dim totalItem As Decimal = precioUnitario * cantidad
                dtItems.Rows.Add(productoID, nombre, cantidad, precioUnitario, totalItem)
                ActualizarTotalGeneral()
            Else
                MessageBox.Show("Por favor, ingrese una cantidad válida.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al agregar el ítem: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarItem_Click(sender As Object, e As EventArgs) Handles btnEliminarItem.Click
        If dgvItems.SelectedRows.Count > 0 Then
            dtItems.Rows.RemoveAt(dgvItems.SelectedRows(0).Index)
            ActualizarTotalGeneral()
        Else
            MessageBox.Show("Seleccione un ítem para eliminar.")
        End If
    End Sub

    Private Sub ActualizarTotalGeneral()
        Dim totalGeneral As Decimal = dtItems.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("PrecioTotal"))
        lblTotalGeneral.Text = "Total General $: " & totalGeneral.ToString()
    End Sub

    Private Sub btnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        Try
            Dim fechaVenta As DateTime = DateTime.Now
            Dim totalVenta As Decimal = dtItems.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("PrecioTotal"))

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim tran As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim cmdVenta As New SqlCommand("INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@IDCliente, @Fecha, @Total)", conn, tran)
                    cmdVenta.Parameters.AddWithValue("@IDCliente", Convert.ToInt32(cbClientes.SelectedValue))
                    cmdVenta.Parameters.AddWithValue("@Fecha", fechaVenta)
                    cmdVenta.Parameters.AddWithValue("@Total", totalVenta)
                    Dim ventaID As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())

                    For Each row As DataRow In dtItems.Rows
                        Dim cmdItem As New SqlCommand("INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)", conn, tran)
                        cmdItem.Parameters.AddWithValue("@IDVenta", ventaID)
                        cmdItem.Parameters.AddWithValue("@IDProducto", row("IDProducto"))
                        cmdItem.Parameters.AddWithValue("@PrecioUnitario", row("PrecioUnitario"))
                        cmdItem.Parameters.AddWithValue("@Cantidad", row("Cantidad"))
                        cmdItem.Parameters.AddWithValue("@PrecioTotal", row("PrecioTotal"))
                        cmdItem.ExecuteNonQuery()
                    Next

                    tran.Commit()
                    MessageBox.Show("Venta registrada con éxito.")
                    Me.Close()
                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show("Error al registrar la venta: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
