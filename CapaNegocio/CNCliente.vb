Imports System.Data
Imports CapaDatos
Imports CapaEntidad

Public Class CNCliente
    Dim objCli As New DAOCliente
    Public Function listadoClientes() As DataSet
        Return objCli.listadoClientes
    End Function

    Public Function nuevoCodigo() As String
        Return objCli.nuevoCodigo
    End Function
    Public Sub nuevoCliente(ByVal objC As CECliente)
        objCli.nuevoCliente(objC)
    End Sub
    Public Sub eliminarCliente(ByVal objC As CECliente)
        objCli.eliminarCliente(objC.id)
    End Sub
    Public Sub modificarCliente(ByVal objC As CECliente)
        objCli.modificarCliente(objC)
    End Sub

End Class
