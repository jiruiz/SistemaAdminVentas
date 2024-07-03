<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemVenta
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
        cbProductos = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtPrecioUnitario = New TextBox()
        Label4 = New Label()
        txtCantidad = New TextBox()
        btnAgregarItem = New Button()
        btnEliminarItem = New Button()
        lblTotalGeneral = New Label()
        dgvItems = New DataGridView()
        btnRegistrarVenta = New Button()
        cbClientes = New ComboBox()
        CLIENTE = New Label()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbProductos
        ' 
        cbProductos.FormattingEnabled = True
        cbProductos.Location = New Point(364, 69)
        cbProductos.Name = "cbProductos"
        cbProductos.Size = New Size(121, 23)
        cbProductos.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(256, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "PRODUCTO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(228, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(306, 30)
        Label2.TabIndex = 2
        Label2.Text = "REGISTRAR VENTA POR ITEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(253, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 15)
        Label3.TabIndex = 3
        Label3.Text = "PRECIO UNITARIO"
        ' 
        ' txtPrecioUnitario
        ' 
        txtPrecioUnitario.CausesValidation = False
        txtPrecioUnitario.Location = New Point(364, 104)
        txtPrecioUnitario.Name = "txtPrecioUnitario"
        txtPrecioUnitario.ReadOnly = True
        txtPrecioUnitario.Size = New Size(100, 23)
        txtPrecioUnitario.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(256, 156)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 5
        Label4.Text = "CANTIDAD"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(364, 148)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(100, 23)
        txtCantidad.TabIndex = 6
        ' 
        ' btnAgregarItem
        ' 
        btnAgregarItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAgregarItem.Location = New Point(233, 194)
        btnAgregarItem.Name = "btnAgregarItem"
        btnAgregarItem.Size = New Size(128, 23)
        btnAgregarItem.TabIndex = 7
        btnAgregarItem.Text = "AGREGAR ITEM"
        btnAgregarItem.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarItem
        ' 
        btnEliminarItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEliminarItem.Location = New Point(434, 194)
        btnEliminarItem.Name = "btnEliminarItem"
        btnEliminarItem.Size = New Size(75, 23)
        btnEliminarItem.TabIndex = 8
        btnEliminarItem.Text = "ELIMINAR ITEM"
        btnEliminarItem.UseVisualStyleBackColor = True
        ' 
        ' lblTotalGeneral
        ' 
        lblTotalGeneral.AutoSize = True
        lblTotalGeneral.Location = New Point(613, 198)
        lblTotalGeneral.Name = "lblTotalGeneral"
        lblTotalGeneral.Size = New Size(0, 15)
        lblTotalGeneral.TabIndex = 9
        ' 
        ' dgvItems
        ' 
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Location = New Point(51, 247)
        dgvItems.Name = "dgvItems"
        dgvItems.RowTemplate.Height = 25
        dgvItems.Size = New Size(655, 150)
        dgvItems.TabIndex = 10
        ' 
        ' btnRegistrarVenta
        ' 
        btnRegistrarVenta.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegistrarVenta.Location = New Point(301, 403)
        btnRegistrarVenta.Name = "btnRegistrarVenta"
        btnRegistrarVenta.Size = New Size(133, 23)
        btnRegistrarVenta.TabIndex = 11
        btnRegistrarVenta.Text = "REGISTRAR VENTA"
        btnRegistrarVenta.UseVisualStyleBackColor = True
        ' 
        ' cbClientes
        ' 
        cbClientes.FormattingEnabled = True
        cbClientes.Location = New Point(364, 39)
        cbClientes.Name = "cbClientes"
        cbClientes.Size = New Size(121, 23)
        cbClientes.TabIndex = 12
        ' 
        ' CLIENTE
        ' 
        CLIENTE.AutoSize = True
        CLIENTE.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CLIENTE.Location = New Point(256, 47)
        CLIENTE.Name = "CLIENTE"
        CLIENTE.Size = New Size(52, 15)
        CLIENTE.TabIndex = 13
        CLIENTE.Text = "CLIENTE"
        ' 
        ' frmItemVenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CLIENTE)
        Controls.Add(cbClientes)
        Controls.Add(btnRegistrarVenta)
        Controls.Add(dgvItems)
        Controls.Add(lblTotalGeneral)
        Controls.Add(btnEliminarItem)
        Controls.Add(btnAgregarItem)
        Controls.Add(txtCantidad)
        Controls.Add(Label4)
        Controls.Add(txtPrecioUnitario)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cbProductos)
        Name = "frmItemVenta"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmItemVenta"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregarItem As Button
    Friend WithEvents btnEliminarItem As Button
    Friend WithEvents lblTotalGeneral As Label
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents CLIENTE As Label
End Class
