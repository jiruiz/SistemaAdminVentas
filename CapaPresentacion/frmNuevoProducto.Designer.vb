<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoProducto
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
        txtIdProducto = New TextBox()
        txtPrecio = New TextBox()
        txtCategoria = New TextBox()
        btnRegistrar = New Button()
        txtNombreProducto = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(250, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 30)
        Label1.TabIndex = 0
        Label1.Text = "REGISTRO DE PRODUCTOS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(90, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "ID PRODUCTO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(90, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 15)
        Label3.TabIndex = 2
        Label3.Text = "NOMBRE PRODUCTO"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(90, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 15)
        Label4.TabIndex = 3
        Label4.Text = "PRECIO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(90, 280)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 15)
        Label5.TabIndex = 4
        Label5.Text = "CATEGORIA"
        ' 
        ' txtIdProducto
        ' 
        txtIdProducto.Location = New Point(221, 97)
        txtIdProducto.Name = "txtIdProducto"
        txtIdProducto.ReadOnly = True
        txtIdProducto.Size = New Size(66, 23)
        txtIdProducto.TabIndex = 5
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(221, 220)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(265, 23)
        txtPrecio.TabIndex = 7
        ' 
        ' txtCategoria
        ' 
        txtCategoria.Location = New Point(221, 277)
        txtCategoria.Name = "txtCategoria"
        txtCategoria.Size = New Size(265, 23)
        txtCategoria.TabIndex = 8
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(221, 354)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(178, 36)
        btnRegistrar.TabIndex = 9
        btnRegistrar.Text = "REGISTRAR PRODUCTO"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' txtNombreProducto
        ' 
        txtNombreProducto.Location = New Point(221, 151)
        txtNombreProducto.Name = "txtNombreProducto"
        txtNombreProducto.Size = New Size(265, 23)
        txtNombreProducto.TabIndex = 11
        ' 
        ' frmNuevoProducto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNombreProducto)
        Controls.Add(btnRegistrar)
        Controls.Add(txtCategoria)
        Controls.Add(txtPrecio)
        Controls.Add(txtIdProducto)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNuevoProducto"
        Text = "frmNuevoProducto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtNombreProducto As TextBox
End Class
