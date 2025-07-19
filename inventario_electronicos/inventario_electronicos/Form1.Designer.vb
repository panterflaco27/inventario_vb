<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtusuario = New TextBox()
        txtpass = New TextBox()
        ComboBox1 = New ComboBox()
        Panel1 = New Panel()
        Button3 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(128, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 32)
        Button1.TabIndex = 0
        Button1.Text = "Iniciar sesion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(128, 333)
        Button2.Name = "Button2"
        Button2.Size = New Size(183, 32)
        Button2.TabIndex = 1
        Button2.Text = "Registrarse"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(128, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 2
        Label1.Text = "Tipo de usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(128, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 3
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 195)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña"
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(128, 148)
        txtusuario.Name = "txtusuario"
        txtusuario.PlaceholderText = "Nombre de usuario"
        txtusuario.Size = New Size(183, 27)
        txtusuario.TabIndex = 5
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(128, 218)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.PlaceholderText = "Contraseña"
        txtpass.Size = New Size(183, 27)
        txtpass.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Administrador", "Alumno"})
        ComboBox1.Location = New Point(128, 78)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(183, 28)
        ComboBox1.TabIndex = 7
        ComboBox1.Tag = ""
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button3)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(448, 35)
        Panel1.TabIndex = 8
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(416, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(29, 29)
        Button3.TabIndex = 9
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(448, 435)
        Controls.Add(Panel1)
        Controls.Add(ComboBox1)
        Controls.Add(txtpass)
        Controls.Add(txtusuario)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents ComboBox1 As ComboBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
End Class
