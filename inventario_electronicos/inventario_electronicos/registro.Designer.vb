<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        txtnombrereg = New TextBox()
        txtpapreg = New TextBox()
        txtsapreg = New TextBox()
        txtnicknamereg = New TextBox()
        txtpassreg = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Button3 = New Button()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(76, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 1
        Label2.Text = "Primer apellido*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(76, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 20)
        Label3.TabIndex = 2
        Label3.Text = "Segundo apellido"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(76, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 20)
        Label4.TabIndex = 3
        Label4.Text = "Nombre de usuario*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(76, 267)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 20)
        Label5.TabIndex = 4
        Label5.Text = "Contraseña*"
        ' 
        ' txtnombrereg
        ' 
        txtnombrereg.Location = New Point(76, 78)
        txtnombrereg.Name = "txtnombrereg"
        txtnombrereg.PlaceholderText = "nombre(s)"
        txtnombrereg.Size = New Size(314, 27)
        txtnombrereg.TabIndex = 6
        ' 
        ' txtpapreg
        ' 
        txtpapreg.Location = New Point(76, 131)
        txtpapreg.Name = "txtpapreg"
        txtpapreg.PlaceholderText = "Primer apellido"
        txtpapreg.Size = New Size(314, 27)
        txtpapreg.TabIndex = 7
        ' 
        ' txtsapreg
        ' 
        txtsapreg.Location = New Point(76, 184)
        txtsapreg.Name = "txtsapreg"
        txtsapreg.PlaceholderText = "Segundo apellido"
        txtsapreg.Size = New Size(314, 27)
        txtsapreg.TabIndex = 8
        ' 
        ' txtnicknamereg
        ' 
        txtnicknamereg.Location = New Point(76, 237)
        txtnicknamereg.Name = "txtnicknamereg"
        txtnicknamereg.PlaceholderText = "Nombre de usuario"
        txtnicknamereg.Size = New Size(314, 27)
        txtnicknamereg.TabIndex = 9
        ' 
        ' txtpassreg
        ' 
        txtpassreg.Location = New Point(76, 290)
        txtpassreg.Name = "txtpassreg"
        txtpassreg.PasswordChar = "*"c
        txtpassreg.PlaceholderText = "Contraseña"
        txtpassreg.Size = New Size(314, 27)
        txtpassreg.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(76, 368)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 34)
        Button1.TabIndex = 11
        Button1.Text = "Cancelar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(240, 368)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 34)
        Button2.TabIndex = 12
        Button2.Text = "Registrar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(466, 35)
        Panel1.TabIndex = 13
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(434, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 29)
        Button3.TabIndex = 9
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(76, 323)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(126, 24)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Administrador"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' registro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 450)
        Controls.Add(CheckBox1)
        Controls.Add(Panel1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtpassreg)
        Controls.Add(txtnicknamereg)
        Controls.Add(txtsapreg)
        Controls.Add(txtpapreg)
        Controls.Add(txtnombrereg)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "registro"
        StartPosition = FormStartPosition.CenterScreen
        Text = "registro"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnombrereg As TextBox
    Friend WithEvents txtpapreg As TextBox
    Friend WithEvents txtsapreg As TextBox
    Friend WithEvents txtnicknamereg As TextBox
    Friend WithEvents txtpassreg As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
