Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports CapaEntidad
Public Class DAOCliente
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function listadoClientes() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar

        da = New SqlDataAdapter("SELECT * FROM clientes", cn)
        da.Fill(ds, "Clientes")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()


    End Function
    Public Function nuevoCodigo() As String
        Dim cn As SqlConnection = objCon.conectar()
        cn.Open()

        Dim da As New SqlDataAdapter("SELECT MAX(ID) FROM clientes", cn)
        Dim ultimo As Object = da.SelectCommand.ExecuteScalar()

        cn.Close()

        If ultimo IsNot DBNull.Value AndAlso ultimo IsNot Nothing Then
            Dim siguienteID As Integer = Convert.ToInt32(ultimo) + 1
            Return siguienteID.ToString()
        Else
            Return "No se encontró ningún ID."
        End If
    End Function



    Public Sub nuevoCliente(ByVal objC As CECliente)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("INSERT INTO clientes (Cliente, Telefono, Correo) VALUES (@Cliente, @Telefono, @Correo)", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@Cliente", SqlDbType.VarChar).Value = objC.cliente
                .Add("@Telefono", SqlDbType.Char).Value = objC.telefono
                .Add("@Correo", SqlDbType.Char).Value = objC.correo
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Cliente Registrado Correctamente...!!")


        Catch ex As Exception
            MsgBox("Error al registrar Cliente" & ex.Message, MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()

        End Try
    End Sub
    Public Sub eliminarCliente(ByVal clienteID As Integer)
        cn = objCon.conectar()
        Try
            cn.Open()
            da = New SqlDataAdapter("DELETE FROM clientes WHERE ID = @ID", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@ID", SqlDbType.Int).Value = clienteID
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Cliente Eliminado Correctamente...!!")

        Catch ex As Exception
            MsgBox("Error al eliminar Cliente: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            If da IsNot Nothing Then da.Dispose()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub modificarCliente(ByVal objC As CECliente)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("UPDATE clientes SET Cliente = @Cliente, Telefono = @Telefono, Correo = @Correo WHERE ID = @ID", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@ID", SqlDbType.Int).Value = objC.id
                .Add("@Cliente", SqlDbType.VarChar).Value = objC.cliente
                .Add("@Telefono", SqlDbType.Char).Value = objC.telefono
                .Add("@Correo", SqlDbType.Char).Value = objC.correo
            End With
            da.SelectCommand.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox("Error al modificar Cliente: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If da IsNot Nothing Then da.Dispose()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub

End Class
