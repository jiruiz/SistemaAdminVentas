Imports System.Data
Imports CapaDatos
Imports CapaEntidad

Public Class CNProducto
    Dim objPro As New DAOProducto
    Public Function listadoProductos() As DataSet
        Return objPro.listadoProductos
    End Function
    Public Function nuevoCodigo() As String
        Return objPro.nuevoCodigoProducto
    End Function
    Public Sub nuevoProducto(ByVal objP As CEProducto)
        objPro.nuevoProducto(objP)
    End Sub

    Public Sub elimiarProducto(ByVal objP As CEProducto)
        objPro.eliminarProducto(objP.id)
    End Sub

    Public Sub modificarProducto(ByVal objP As CEProducto)
        objPro.modificarProducto(objP)
    End Sub

End Class
