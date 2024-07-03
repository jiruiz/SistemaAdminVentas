Imports CapaNegocio
Imports CapaEntidad

Public Class frmNuevoProducto
    Dim capaNegocio As New CNProducto

    Private Sub frmNuevoProducto(sender As Object, e As EventArgs) Handles MyBase.Load
        Call generaCodigo()
    End Sub
    Sub generaCodigo()
        txtIdProducto.Text = capaNegocio.nuevoCodigo

    End Sub

    Function getCodigo() As String
        Return txtIdProducto.Text
    End Function
    Function getNombre() As String
        Return txtNombreProducto.Text

    End Function
    Function getPrecio() As String
        Return txtPrecio.Text
    End Function
    Function getCateoria() As String
        Return txtCategoria.Text
    End Function



    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim objeto As New CEProducto
        objeto.id = getCodigo()
        objeto.nombre = getNombre()
        objeto.precio = getPrecio()
        objeto.categoria = getCateoria()

        capaNegocio.nuevoProducto(objeto)
    End Sub
End Class