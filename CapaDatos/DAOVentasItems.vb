Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports CapaEntidad

Public Class DAOVentaIntem
    Dim objCon As New Conexion
    Dim cn As SqlConnection
    Dim da As SqlDataAdapter

    Public Function listadoVentasItems() As DataSet
        Dim ds As New DataSet
        cn = objCon.conectar

        da = New SqlDataAdapter("SELECT * FROM ventasitems", cn)
        da.Fill(ds, "Ventasitems")
        Return ds
        ds.Dispose()
        da.Dispose()
        cn.Dispose()


    End Function

    Public Sub eliminarVentaItem(ByVal ventaID As Integer)
        cn = objCon.conectar()
        Try
            cn.Open()
            da = New SqlDataAdapter("DELETE FROM ventasitems WHERE ID = @ID", cn)
            da.SelectCommand.CommandType = CommandType.Text

            With da.SelectCommand.Parameters
                .Add("@ID", SqlDbType.Int).Value = ventaID
            End With
            da.SelectCommand.ExecuteNonQuery()
            MsgBox("Item de la Venta Eliminado Correctamente...!!")

        Catch ex As Exception
            MsgBox("Error al eliminar el Item de la Venta: " & ex.Message, MsgBoxStyle.Critical)

        Finally
            If da IsNot Nothing Then da.Dispose()
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
End Class
