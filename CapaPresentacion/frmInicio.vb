Public Class frmInicio
    Private Sub btnIrAListarClientes_Click(sender As Object, e As EventArgs) Handles btnIrAListarClientes.Click
        Dim formListadoClientes As New frmListadoClientes


        formListadoClientes.Show()


    End Sub
    Private Sub btnIrARegistrarClientes_Click(sender As Object, e As EventArgs) Handles btnIrARegistrarCliente.Click
        Dim frmRegistrarCliente As New frmNuevoCliente

        frmNuevoCliente.Show()



    End Sub


    Private Sub btnIrAListarProductos_Click(sender As Object, e As EventArgs) Handles btnIrAListarProductos.Click
        Dim formListadoProducto As New frmListadoProductos

        frmListadoProductos.Show()



    End Sub

    Private Sub btnIrARegistrarProductos_Click(sender As Object, e As EventArgs) Handles btnIrARegistrarProducto.Click
        Dim frmNuevoProducto As New frmNuevoProducto

        frmNuevoProducto.Show()
    End Sub

    Private Sub btnIrAListarVentas_Click(sender As Object, e As EventArgs) Handles btnIrAListarVentas.Click
        Dim formListadoVentas As New frmListadoVentas

        frmListadoVentas.Show()



    End Sub

    Private Sub btnIrARegistrarVenta_Click(sender As Object, e As EventArgs) Handles btnIrARegistrarVenta.Click
        Dim frmNuevaVenta As New frmNuevaVenta

        frmNuevaVenta.Show()
    End Sub

    Private Sub btnRegistrarItems_Click(sender As Object, e As EventArgs) Handles btnIrRegistrarItems.Click
        Dim frmItemVenta As New frmItemVenta

        frmItemVenta.Show()
    End Sub

    Private Sub btnIrEliminarItem_Click(sender As Object, e As EventArgs) Handles btnIrEliminarItem.Click
        Dim frmListadoVentasItems As New frmListadoVentasItems

        frmListadoVentasItems.Show()
    End Sub
End Class