<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaVenta
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnRegistrarVenta = New Button()
        cbClientes = New ComboBox()
        cbProductos = New ComboBox()
        txtPrecioUnitario = New TextBox()
        txtCantidad = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(302, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 15)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRAR UNA VENTA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 15)
        Label2.TabIndex = 1
        Label2.Text = "SELECCIONAR CLIENTE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(39, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 15)
        Label3.TabIndex = 2
        Label3.Text = "SELECCIONAR PRODUCTO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(39, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 15)
        Label4.TabIndex = 3
        Label4.Text = "PRECIO DEL PRODUCTO SELECCIONADO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(39, 283)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 15)
        Label5.TabIndex = 4
        Label5.Text = "CANTIDAD"
        ' 
        ' btnRegistrarVenta
        ' 
        btnRegistrarVenta.Location = New Point(302, 354)
        btnRegistrarVenta.Name = "btnRegistrarVenta"
        btnRegistrarVenta.Size = New Size(247, 23)
        btnRegistrarVenta.TabIndex = 5
        btnRegistrarVenta.Text = "REGISTRAR VENTA"
        btnRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' cbClientes
        ' 
        cbClientes.FormattingEnabled = True
        cbClientes.Location = New Point(335, 119)
        cbClientes.Name = "cbClientes"
        cbClientes.Size = New Size(214, 23)
        cbClientes.TabIndex = 6
        ' 
        ' cbProductos
        ' 
        cbProductos.FormattingEnabled = True
        cbProductos.Location = New Point(335, 174)
        cbProductos.Name = "cbProductos"
        cbProductos.Size = New Size(214, 23)
        cbProductos.TabIndex = 7
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.Location = New Point(335, 224)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.Size = New Size(100, 23)
        txtPrecioUnitario.TabIndex = 8
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(335, 275)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(100, 23)
        txtCantidad.TabIndex = 9
        ' 
        ' frmNuevaVenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCantidad)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(cbProductos)
        Controls.Add(cbClientes)
        Controls.Add(btnRegistrarVenta)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNuevaVenta"
        Text = "frmNuevaVenta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents txtCantidad As TextBox
End Class
