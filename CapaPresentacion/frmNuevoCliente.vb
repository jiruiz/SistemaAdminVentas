Imports CapaNegocio
Imports CapaEntidad

Public Class frmNuevoCliente
    Dim capaNegocio As New CNCliente

    Private Sub frmNuevoCliente(sender As Object, e As EventArgs) Handles MyBase.Load
        Call generaCodigo()
    End Sub
    Sub generaCodigo()
        txtCodigo.Text = capaNegocio.nuevoCodigo

    End Sub

    Function getCodigo() As String
        Return txtCodigo.Text
    End Function
    Function getCliente() As String
        Return txtCliente.Text

    End Function
    Function getTelefono() As String
        Return txtTelefono.Text
    End Function
    Function getCorreo() As String
        Return txtCorreo.Text
    End Function

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objeto As New CECliente
        objeto.id = getCodigo()
        objeto.cliente = getCliente()
        objeto.telefono = getTelefono()
        objeto.correo = getCorreo()

        capaNegocio.nuevoCliente(objeto)

    End Sub


End Class