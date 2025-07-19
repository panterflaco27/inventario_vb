<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pedido
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
        cboxcomp = New ComboBox()
        txtdisponible = New TextBox()
        Button1 = New Button()
        txtcantidad = New TextBox()
        listcomps = New ListBox()
        Button2 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(624, 35)
        Panel1.TabIndex = 14
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(592, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 29)
        Button3.TabIndex = 9
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' cboxcomp
        ' 
        cboxcomp.FormattingEnabled = True
        cboxcomp.Location = New Point(19, 106)
        cboxcomp.Name = "cboxcomp"
        cboxcomp.Size = New Size(151, 28)
        cboxcomp.TabIndex = 15
        ' 
        ' txtdisponible
        ' 
        txtdisponible.Enabled = False
        txtdisponible.Location = New Point(332, 106)
        txtdisponible.Name = "txtdisponible"
        txtdisponible.Size = New Size(88, 27)
        txtdisponible.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(526, 71)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 18
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtcantidad
        ' 
        txtcantidad.Location = New Point(426, 106)
        txtcantidad.Name = "txtcantidad"
        txtcantidad.Size = New Size(74, 27)
        txtcantidad.TabIndex = 19
        ' 
        ' listcomps
        ' 
        listcomps.FormattingEnabled = True
        listcomps.Location = New Point(176, 106)
        listcomps.Name = "listcomps"
        listcomps.Size = New Size(150, 104)
        listcomps.TabIndex = 21
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(526, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 22
        Button2.Text = "Quitar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(526, 141)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 23
        Button4.Text = "Finalizar"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(526, 176)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 24
        Button5.Text = "Cancelar"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 20)
        Label1.TabIndex = 25
        Label1.Text = "Componente"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(176, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 26
        Label2.Text = "Lista del pedido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(332, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 27
        Label3.Text = "Disponible"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(426, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 28
        Label4.Text = "Cantidad"
        ' 
        ' Pedido
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 302)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(listcomps)
        Controls.Add(txtcantidad)
        Controls.Add(Button1)
        Controls.Add(txtdisponible)
        Controls.Add(cboxcomp)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pedido"
        StartPosition = FormStartPosition.CenterScreen
        Text = "pedido"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents cboxcomp As ComboBox
    Friend WithEvents txtdisponible As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents listcomps As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
