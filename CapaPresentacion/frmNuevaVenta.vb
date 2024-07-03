Imports CapaNegocio
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmNuevaVenta
    Dim capaNegocio As New CNVenta
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("cn").ConnectionString

    Private Sub frmRegistroVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        CargarProductos()
    End Sub

    Private Sub CargarClientes()
        Dim dtClientes As DataTable = ObtenerClientes()
        cbClientes.DataSource = dtClientes
        cbClientes.DisplayMember = "Cliente"
        cbClientes.ValueMember = "ID"
    End Sub

    Private Sub CargarProductos()
        ' Cargar los productos en el ComboBox
        Dim dtProductos As DataTable = ObtenerProductos()
        cbProductos.DataSource = dtProductos
        cbProductos.DisplayMember = "Nombre"
        cbProductos.ValueMember = "ID"
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

    Private Sub btnRegistrarVenta_Click(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        Try
            Dim clienteID As Integer = Convert.ToInt32(cbClientes.SelectedValue)
            Dim productoID As Integer = Convert.ToInt32(cbProductos.SelectedValue)
            Dim precioUnitario As Decimal = Convert.ToDecimal(txtPrecioUnitario.Text)
            Dim cantidad As Integer

            ' Validar la entrada de cantidad
            Try
                cantidad = Convert.ToInt32(txtCantidad.Text)
            Catch ex As FormatException
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCantidad.Focus()
                Return
            End Try

            Dim totalVenta As Decimal = precioUnitario * cantidad
            Dim fechaVenta As DateTime = DateTime.Now

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim tran As SqlTransaction = conn.BeginTransaction()
                Try
                    Dim cmdVenta As New SqlCommand("INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@IDCliente, @Fecha, @Total)", conn, tran)
                    cmdVenta.Parameters.AddWithValue("@IDCliente", clienteID)
                    cmdVenta.Parameters.AddWithValue("@Fecha", fechaVenta)
                    cmdVenta.Parameters.AddWithValue("@Total", totalVenta)
                    Dim ventaID As Integer = Convert.ToInt32(cmdVenta.ExecuteScalar())

                    tran.Commit()
                    MessageBox.Show("Venta registrada con éxito.")

                    ' Abrir frmItemVenta y pasar el ClienteID
                    Dim frmItemVenta As New frmItemVenta()
                    frmItemVenta.ClienteID = clienteID
                    frmItemVenta.ShowDialog()

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
