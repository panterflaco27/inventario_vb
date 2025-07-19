<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invadmin
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        txtbuscar = New TextBox()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1091, 35)
        Panel1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1059, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 29)
        Button1.TabIndex = 9
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(977, 41)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 29)
        Button2.TabIndex = 11
        Button2.Text = "Cerrar sesion"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 20)
        Label1.TabIndex = 12
        Label1.Text = "Usuario"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 76)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 13
        Button3.Text = "Buscar:"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(121, 76)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.PlaceholderText = "Nombre del componente"
        txtbuscar.Size = New Size(353, 27)
        txtbuscar.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(480, 76)
        Button4.Name = "Button4"
        Button4.Size = New Size(208, 29)
        Button4.TabIndex = 15
        Button4.Text = "Agregar nuevo componente"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 111)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1073, 448)
        DataGridView1.TabIndex = 16
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(694, 76)
        Button5.Name = "Button5"
        Button5.Size = New Size(91, 29)
        Button5.TabIndex = 17
        Button5.Text = "Modificar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(791, 76)
        Button6.Name = "Button6"
        Button6.Size = New Size(94, 29)
        Button6.TabIndex = 18
        Button6.Text = "Borrar"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(891, 76)
        Button7.Name = "Button7"
        Button7.Size = New Size(94, 29)
        Button7.TabIndex = 19
        Button7.Text = "Ver todo"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(991, 76)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 29)
        Button8.TabIndex = 20
        Button8.Text = "Reportes"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Invadmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1091, 571)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(txtbuscar)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Invadmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "invadmin"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
