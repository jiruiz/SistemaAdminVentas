<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoCliente
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
        txtCodigo = New TextBox()
        txtCliente = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        btnRegistrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(247, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(246, 30)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRO DE CLIENTES"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(35, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 25)
        Label2.TabIndex = 1
        Label2.Text = "CODIGO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(35, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 25)
        Label3.TabIndex = 2
        Label3.Text = "CLIENTE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(35, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 25)
        Label4.TabIndex = 3
        Label4.Text = "TELEFONO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(35, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 25)
        Label5.TabIndex = 4
        Label5.Text = "CORREO"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCodigo.Location = New Point(140, 70)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.ReadOnly = True
        txtCodigo.Size = New Size(46, 33)
        txtCodigo.TabIndex = 5
        ' 
        ' txtCliente
        ' 
        txtCliente.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCliente.Location = New Point(140, 110)
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(242, 33)
        txtCliente.TabIndex = 6
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtTelefono.Location = New Point(140, 147)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(242, 33)
        txtTelefono.TabIndex = 7
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        txtCorreo.Location = New Point(140, 200)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(242, 33)
        txtCorreo.TabIndex = 8
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btnRegistrar.Location = New Point(146, 295)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(221, 34)
        btnRegistrar.TabIndex = 9
        btnRegistrar.Text = "REGISTRAR CLIENTE"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' frmNuevoCliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRegistrar)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtCliente)
        Controls.Add(txtCodigo)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNuevoCliente"
        Text = "frmNuevoCliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnRegistrar As Button
End Class
