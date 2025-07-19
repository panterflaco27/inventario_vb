<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invcliente
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        txtbuscar = New TextBox()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
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
        Panel1.Size = New Size(872, 35)
        Panel1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(840, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 29)
        Button1.TabIndex = 9
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 11
        Label1.Text = "Label1"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 109)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(854, 448)
        DataGridView1.TabIndex = 20
        ' 
        ' txtbuscar
        ' 
        txtbuscar.Location = New Point(115, 76)
        txtbuscar.Name = "txtbuscar"
        txtbuscar.PlaceholderText = "Nombre del componente"
        txtbuscar.Size = New Size(353, 27)
        txtbuscar.TabIndex = 19
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(6, 76)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 18
        Button3.Text = "Buscar:"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(761, 37)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 29)
        Button2.TabIndex = 17
        Button2.Text = "Cerrar sesion"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(745, 72)
        Button4.Name = "Button4"
        Button4.Size = New Size(124, 29)
        Button4.TabIndex = 21
        Button4.Text = "Agregar pedido"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' invcliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(872, 566)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(txtbuscar)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "invcliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "invcliente"
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
End Class
