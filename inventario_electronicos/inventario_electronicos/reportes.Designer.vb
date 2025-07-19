<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportes
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
        Panel1 = New Panel()
        Button3 = New Button()
        dgvreportes = New DataGridView()
        Button1 = New Button()
        txtbuscar = New TextBox()
        Button2 = New Button()
        Button4 = New Button()
        Panel1.SuspendLayout()
        CType(dgvreportes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 35)
        Panel1.TabIndex = 15
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(768, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 29)
        Button3.TabIndex = 9
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' dgvreportes
        ' 
        dgvreportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvreportes.Location = New Point(12, 141)
        dgvreportes.Name = "dgvreportes"
        dgvreportes.RowHeadersWidth = 51
        dgvreportes.Size = New Size(776, 297)
        dgvreportes.TabIndex = 16
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 52)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 17
        Button1.Text = "Buscar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(112, 52)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.Size = New Size(198, 27)
        txtbuscar.TabIndex = 18
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(316, 52)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 29)
        Button2.TabIndex = 19
        Button2.Text = "Ver detalles"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(426, 52)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 20
        Button4.Text = "Ver todo"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' reportes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(txtbuscar)
        Controls.Add(Button1)
        Controls.Add(dgvreportes)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "reportes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "reportes"
        Panel1.ResumeLayout(False)
        CType(dgvreportes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents dgvreportes As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
