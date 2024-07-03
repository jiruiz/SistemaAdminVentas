<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoProductos
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
        dgProductos = New DataGridView()
        Label2 = New Label()
        lblTotalProductos = New Label()
        btnEliminarProducto = New Button()
        btnGuardarCambiosProducto = New Button()
        txtBusqueda = New TextBox()
        Label3 = New Label()
        CType(dgProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(262, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 30)
        Label1.TabIndex = 0
        Label1.Text = "LISTADO DE PRODUCTOS"
        ' 
        ' dgProductos
        ' 
        dgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgProductos.Location = New Point(23, 129)
        dgProductos.Name = "dgProductos"
        dgProductos.RowTemplate.Height = 25
        dgProductos.Size = New Size(765, 149)
        dgProductos.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(369, 321)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 25)
        Label2.TabIndex = 2
        Label2.Text = "TOTAL DE PRODUCTOS"
        ' 
        ' lblTotalProductos
        ' 
        lblTotalProductos.AutoSize = True
        lblTotalProductos.Location = New Point(642, 312)
        lblTotalProductos.Name = "lblTotalProductos"
        lblTotalProductos.Size = New Size(0, 15)
        lblTotalProductos.TabIndex = 3
        ' 
        ' btnEliminarProducto
        ' 
        btnEliminarProducto.Location = New Point(23, 321)
        btnEliminarProducto.Name = "btnEliminarProducto"
        btnEliminarProducto.Size = New Size(135, 33)
        btnEliminarProducto.TabIndex = 4
        btnEliminarProducto.Text = "ELIMINAR PRODUCTO"
        btnEliminarProducto.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarCambiosProducto
        ' 
        btnGuardarCambiosProducto.Location = New Point(187, 321)
        btnGuardarCambiosProducto.Name = "btnGuardarCambiosProducto"
        btnGuardarCambiosProducto.Size = New Size(146, 33)
        btnGuardarCambiosProducto.TabIndex = 5
        btnGuardarCambiosProducto.Text = "GUARDAR CAMBIOS"
        btnGuardarCambiosProducto.UseVisualStyleBackColor = True
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(235, 89)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(487, 23)
        txtBusqueda.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 15)
        Label3.TabIndex = 7
        Label3.Text = "BUSCAR PRODUCTO:"
        ' 
        ' frmListadoProductos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(txtBusqueda)
        Controls.Add(btnGuardarCambiosProducto)
        Controls.Add(btnEliminarProducto)
        Controls.Add(lblTotalProductos)
        Controls.Add(Label2)
        Controls.Add(dgProductos)
        Controls.Add(Label1)
        Name = "frmListadoProductos"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmListadoProductos"
        CType(dgProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgProductos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalProductos As Label
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnGuardarCambiosProducto As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label3 As Label
End Class
