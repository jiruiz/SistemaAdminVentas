<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadoClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        dgClientes = New DataGridView()
        Label2 = New Label()
        ldlTotalClientes = New Label()
        btnEliminarCliente = New Button()
        btnGuardarCambiosCliente = New Button()
        Label3 = New Label()
        txtBusqueda = New TextBox()
        CType(dgClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(272, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 30)
        Label1.TabIndex = 0
        Label1.Text = "LISTADO DE CLIENTES"
        ' 
        ' dgClientes
        ' 
        dgClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgClientes.Location = New Point(12, 174)
        dgClientes.Name = "dgClientes"
        dgClientes.RowTemplate.Height = 25
        dgClientes.Size = New Size(786, 182)
        dgClientes.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(461, 393)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 15)
        Label2.TabIndex = 2
        Label2.Text = "TOTAL DE CLIENTES"
        ' 
        ' ldlTotalClientes
        ' 
        ldlTotalClientes.AutoSize = True
        ldlTotalClientes.Location = New Point(682, 393)
        ldlTotalClientes.Name = "ldlTotalClientes"
        ldlTotalClientes.Size = New Size(0, 15)
        ldlTotalClientes.TabIndex = 3
        ' 
        ' btnEliminarCliente
        ' 
        btnEliminarCliente.Location = New Point(21, 383)
        btnEliminarCliente.Name = "btnEliminarCliente"
        btnEliminarCliente.Size = New Size(173, 35)
        btnEliminarCliente.TabIndex = 4
        btnEliminarCliente.Text = "ELIMINAR REGISTRO"
        btnEliminarCliente.UseVisualStyleBackColor = True
        ' 
        ' btnGuardarCambiosCliente
        ' 
        btnGuardarCambiosCliente.Location = New Point(235, 384)
        btnGuardarCambiosCliente.Name = "btnGuardarCambiosCliente"
        btnGuardarCambiosCliente.Size = New Size(149, 34)
        btnGuardarCambiosCliente.TabIndex = 5
        btnGuardarCambiosCliente.Text = "GUARDAR CAMBIOS"
        btnGuardarCambiosCliente.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(78, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 6
        Label3.Text = "BUSCAR CLIENTE"
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(182, 105)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(426, 23)
        txtBusqueda.TabIndex = 7
        ' 
        ' frmListadoClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtBusqueda)
        Controls.Add(Label3)
        Controls.Add(btnGuardarCambiosCliente)
        Controls.Add(btnEliminarCliente)
        Controls.Add(ldlTotalClientes)
        Controls.Add(Label2)
        Controls.Add(dgClientes)
        Controls.Add(Label1)
        Name = "frmListadoClientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmListadoClientes"
        CType(dgClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgClientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents ldlTotalClientes As Label
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnGuardarCambiosCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBusqueda As TextBox

End Class
