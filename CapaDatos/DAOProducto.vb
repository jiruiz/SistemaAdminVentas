Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports CapaEntidad

Public Class DAOProducto
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function listadoProductos() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar

        da = New SqlDataAdapter("SELECT * FROM productos", cn)
        da.Fill(ds, "Productos")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()


    End Function

    Public Function nuevoCodigoProducto() As String
        Dim cn As SqlConnection = objCon.conectar()
        cn.Open()

        Dim da As New SqlDataAdapter("SELECT MAX(ID) FROM productos", cn)
        Dim ultimo As Object = da.SelectCommand.ExecuteScalar()

        cn.Close()

        If ultimo IsNot DBNull.Value AndAlso ultimo IsNot Nothing Then
            Dim siguienteID As Integer = Convert.ToInt32(ultimo) + 1
            Return siguienteID.ToString()
        Else
            Return "No se encontró ningún ID del Producto."
        End If
    End Function




    Public Sub nuevoProducto(ByVal objP As CEProducto)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("INSERT INTO productos (nombre, precio, categoria) VALUES (@nombre, @precio, @categoria)", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@nombre", SqlDbType.VarChar).Value = objP.nombre
                .Add("@precio", SqlDbType.Float).Value = objP.precio
                .Add("@categoria", SqlDbType.VarChar).Value = objP.categoria
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Producto Registrado Correctamente...!!")


        Catch ex As Exception
            MsgBox("Error al registrar Producto" & ex.Message, MsgBoxStyle.Critical)
        Finally
            da.Dispose()
            cn.Dispose()

        End Try
    End Sub

    Public Sub eliminarProducto(ByVal productoID As Integer)
        cn = objCon.conectar()
        Try
            cn.Open()
            da = New SqlDataAdapter("DELETE FROM productos WHERE ID = @ID", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@ID", SqlDbType.Int).Value = productoID
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Producto Eliminado Correctamente...!!")

        Catch ex As Exception
            MsgBox("Error al eliminar Producto: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            If da IsNot Nothing Then da.Dispose()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub

    Public Sub modificarProducto(ByVal objP As CEProducto)
        cn = objCon.conectar
        Try
            cn.Open()
            da = New SqlDataAdapter("UPDATE productos SET Nombre = @Nombre, Precio = @Precio, Categoria = @Categoria WHERE ID = @ID", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@ID", SqlDbType.Int).Value = objP.id
                .Add("@Nombre", SqlDbType.VarChar).Value = objP.nombre
                .Add("@Precio", SqlDbType.Float).Value = objP.precio
                .Add("@Categoria", SqlDbType.VarChar).Value = objP.categoria
            End With
            da.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error al modificar Producto: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If da IsNot Nothing Then da.Dispose()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub



End Class
