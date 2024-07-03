Imports System.Data
Imports CapaDatos
Imports CapaEntidad

Public Class CNVentaItem
    Private objVentasItems As New DAOVentaIntem

    Public Function ListarVentasItems() As DataSet
        Return objVentasItems.ListadoVentasItems()
    End Function

    Public Sub EliminarVentaItem(ByVal objVentaItem As CEVentaItem)
        objVentasItems.EliminarVentaItem(objVentaItem.id)
    End Sub

End Class
