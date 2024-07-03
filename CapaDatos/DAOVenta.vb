Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports CapaEntidad

Public Class DAOVenta
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function listadoVentas() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar

        da = New SqlDataAdapter("SELECT * FROM ventas", cn)
        da.Fill(ds, "Ventas")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()


    End Function

    Public Sub eliminarVenta(ByVal ventaID As Integer)
        cn = objCon.conectar()
        Try
            cn.Open()
            da = New SqlDataAdapter("DELETE FROM ventas WHERE ID = @ID", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@ID", SqlDbType.Int).Value = ventaID
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Venta Eliminada Correctamente...!!")

        Catch ex As Exception
            MsgBox("Error al eliminar Venta: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            If da IsNot Nothing Then da.Dispose()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
End Class
