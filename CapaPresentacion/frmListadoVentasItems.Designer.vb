<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoVentasItems
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
        dgvVentasItems = New DataGridView()
        txtBusqueda = New TextBox()
        lblTotalVentasItem = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnEliminarItem = New Button()
        CType(dgvVentasItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(212, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(323, 30)
        Label1.TabIndex = 0
        Label1.Text = "LISTADO DE ITEMS POR VENTA"
        ' 
        ' dgvVentasItems
        ' 
        dgvVentasItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVentasItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVentasItems.Location = New Point(33, 141)
        dgvVentasItems.Name = "dgvVentasItems"
        dgvVentasItems.RowTemplate.Height = 25
        dgvVentasItems.Size = New Size(715, 162)
        dgvVentasItems.TabIndex = 1
        ' 
        ' txtBusqueda
        ' 
        txtBusqueda.Location = New Point(321, 73)
        txtBusqueda.Name = "txtBusqueda"
        txtBusqueda.Size = New Size(100, 23)
        txtBusqueda.TabIndex = 2
        ' 
        ' lblTotalVentasItem
        ' 
        lblTotalVentasItem.AutoSize = True
        lblTotalVentasItem.Location = New Point(478, 338)
        lblTotalVentasItem.Name = "lblTotalVentasItem"
        lblTotalVentasItem.Size = New Size(0, 15)
        lblTotalVentasItem.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(330, 338)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 15)
        Label3.TabIndex = 4
        Label3.Text = "TOTAL DE ITEMS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(224, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 5
        Label2.Text = "BUSCAR POR ID"
        ' 
        ' btnEliminarItem
        ' 
        btnEliminarItem.Location = New Point(599, 330)
        btnEliminarItem.Name = "btnEliminarItem"
        btnEliminarItem.Size = New Size(123, 23)
        btnEliminarItem.TabIndex = 6
        btnEliminarItem.Text = "ELIMINAR ITEM"
        btnEliminarItem.UseVisualStyleBackColor = True
        ' 
        ' frmListadoVentasItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEliminarItem)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(lblTotalVentasItem)
        Controls.Add(txtBusqueda)
        Controls.Add(dgvVentasItems)
        Controls.Add(Label1)
        Name = "frmListadoVentasItems"
        Text = "frmListadoVentasItems"
        CType(dgvVentasItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvVentasItems As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents lblTotalVentasItem As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminarItem As Button
End Class
