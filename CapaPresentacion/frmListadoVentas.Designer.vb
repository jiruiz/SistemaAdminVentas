<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVentas
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
        dgVentas = New DataGridView()
        Label2 = New Label()
        lblTotalVentas = New Label()
        Button1 = New Button()
        CType(dgVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(275, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(218, 30)
        Label1.TabIndex = 0
        Label1.Text = "LISTADO DE VENTAS"
        ' 
        ' dgVentas
        ' 
        dgVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgVentas.Location = New Point(2, 99)
        dgVentas.Name = "dgVentas"
        dgVentas.RowTemplate.Height = 25
        dgVentas.Size = New Size(786, 150)
        dgVentas.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(365, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 15)
        Label2.TabIndex = 2
        Label2.Text = "TOTAL DE VENTAS"
        ' 
        ' lblTotalVentas
        ' 
        lblTotalVentas.AutoSize = True
        lblTotalVentas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalVentas.Location = New Point(502, 332)
        lblTotalVentas.Name = "lblTotalVentas"
        lblTotalVentas.Size = New Size(0, 15)
        lblTotalVentas.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(29, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 23)
        Button1.TabIndex = 4
        Button1.Text = "ELIMINAR VENTA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmListadoVentas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(lblTotalVentas)
        Controls.Add(Label2)
        Controls.Add(dgVentas)
        Controls.Add(Label1)
        Name = "frmListadoVentas"
        Text = "frmListadoVentas"
        CType(dgVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgVentas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalVentas As Label
    Friend WithEvents Button1 As Button
End Class
