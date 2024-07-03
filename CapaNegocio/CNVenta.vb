Imports System.Data
Imports CapaDatos
Imports CapaEntidad


Public Class CNVenta
    Dim objVen As New DAOVenta
    Public Function listadoVentas() As DataSet
        Return objVen.listadoVentas
    End Function
    Public Sub eliminarVenta(ByVal objV As CEVenta)
        objVen.eliminarVenta(objV.id)
    End Sub

End Class
