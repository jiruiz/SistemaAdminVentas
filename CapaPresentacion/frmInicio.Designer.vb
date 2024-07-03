<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnIrAListarClientes = New Button()
        btnIrARegistrarCliente = New Button()
        btnIrAListarProductos = New Button()
        btnIrARegistrarProducto = New Button()
        btnIrAListarVentas = New Button()
        btnIrARegistrarVenta = New Button()
        btnIrRegistrarItems = New Button()
        btnIrEliminarItem = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(256, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 32)
        Label1.TabIndex = 0
        Label1.Text = "PANTALLA DE INICIO"
        ' 
        ' btnIrAListarClientes
        ' 
        btnIrAListarClientes.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrAListarClientes.Location = New Point(143, 89)
        btnIrAListarClientes.Name = "btnIrAListarClientes"
        btnIrAListarClientes.Size = New Size(242, 47)
        btnIrAListarClientes.TabIndex = 1
        btnIrAListarClientes.Text = "Listar Clientes"
        btnIrAListarClientes.UseVisualStyleBackColor = True
        ' 
        ' btnIrARegistrarCliente
        ' 
        btnIrARegistrarCliente.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrARegistrarCliente.Location = New Point(403, 89)
        btnIrARegistrarCliente.Name = "btnIrARegistrarCliente"
        btnIrARegistrarCliente.Size = New Size(246, 47)
        btnIrARegistrarCliente.TabIndex = 2
        btnIrARegistrarCliente.Text = "Registrar Cliente"
        btnIrARegistrarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnIrAListarProductos
        ' 
        btnIrAListarProductos.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrAListarProductos.Location = New Point(143, 157)
        btnIrAListarProductos.Name = "btnIrAListarProductos"
        btnIrAListarProductos.Size = New Size(242, 47)
        btnIrAListarProductos.TabIndex = 3
        btnIrAListarProductos.Text = "Listar Productos"
        btnIrAListarProductos.UseVisualStyleBackColor = True
        ' 
        ' btnIrARegistrarProducto
        ' 
        btnIrARegistrarProducto.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrARegistrarProducto.Location = New Point(403, 157)
        btnIrARegistrarProducto.Name = "btnIrARegistrarProducto"
        btnIrARegistrarProducto.Size = New Size(246, 47)
        btnIrARegistrarProducto.TabIndex = 4
        btnIrARegistrarProducto.Text = "Registrar Producto"
        btnIrARegistrarProducto.UseVisualStyleBackColor = True
        ' 
        ' btnIrAListarVentas
        ' 
        btnIrAListarVentas.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrAListarVentas.Location = New Point(143, 236)
        btnIrAListarVentas.Name = "btnIrAListarVentas"
        btnIrAListarVentas.Size = New Size(242, 47)
        btnIrAListarVentas.TabIndex = 5
        btnIrAListarVentas.Text = "Listar Ventas"
        btnIrAListarVentas.UseVisualStyleBackColor = True
        ' 
        ' btnIrARegistrarVenta
        ' 
        btnIrARegistrarVenta.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrARegistrarVenta.Location = New Point(403, 236)
        btnIrARegistrarVenta.Name = "btnIrARegistrarVenta"
        btnIrARegistrarVenta.Size = New Size(246, 47)
        btnIrARegistrarVenta.TabIndex = 6
        btnIrARegistrarVenta.Text = "Registrar Venta"
        btnIrARegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' btnIrRegistrarItems
        ' 
        btnIrRegistrarItems.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrRegistrarItems.Location = New Point(143, 324)
        btnIrRegistrarItems.Name = "btnIrRegistrarItems"
        btnIrRegistrarItems.Size = New Size(242, 47)
        btnIrRegistrarItems.TabIndex = 7
        btnIrRegistrarItems.Text = "Registrar Items en Venta"
        btnIrRegistrarItems.UseVisualStyleBackColor = True
        ' 
        ' btnIrEliminarItem
        ' 
        btnIrEliminarItem.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnIrEliminarItem.Location = New Point(403, 324)
        btnIrEliminarItem.Name = "btnIrEliminarItem"
        btnIrEliminarItem.Size = New Size(242, 47)
        btnIrEliminarItem.TabIndex = 8
        btnIrEliminarItem.Text = "Eliminar Item en Venta"
        btnIrEliminarItem.UseVisualStyleBackColor = True
        ' 
        ' frmInicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnIrEliminarItem)
        Controls.Add(btnIrRegistrarItems)
        Controls.Add(btnIrARegistrarVenta)
        Controls.Add(btnIrAListarVentas)
        Controls.Add(btnIrARegistrarProducto)
        Controls.Add(btnIrAListarProductos)
        Controls.Add(btnIrARegistrarCliente)
        Controls.Add(btnIrAListarClientes)
        Controls.Add(Label1)
        Name = "frmInicio"
        StartPosition = FormStartPosition.CenterParent
        Text = "Inicio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnIrAListarClientes As Button
    Friend WithEvents btnIrARegistrarCliente As Button
    Friend WithEvents btnIrAListarProductos As Button
    Friend WithEvents btnIrARegistrarProducto As Button
    Friend WithEvents btnIrAListarVentas As Button
    Friend WithEvents btnIrARegistrarVenta As Button
    Friend WithEvents btnIrRegistrarItems As Button
    Friend WithEvents btnIrEliminarItem As Button
End Class
