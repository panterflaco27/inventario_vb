<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modcomp
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
        Button3 = New Button()
        Button2 = New Button()
        cboxcategoria = New ComboBox()
        cboxestado = New ComboBox()
        txtcantidadcomp = New TextBox()
        txtdescripcioncomp = New TextBox()
        txtnombrecomp = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Button1 = New Button()
        txtid = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(580, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 40
        Button3.Text = "Modificar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(480, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 39
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' cboxcategoria
        ' 
        cboxcategoria.FormattingEnabled = True
        cboxcategoria.Items.AddRange(New Object() {"Componentes Eléctricos y Electrónicos Básicos", "Fuentes de energía y Regulación", "Microcontroladores y Placas de Desarrollo", "Módulos de Comunicación", "Pantallas y Visualización", "Sensores y Actuadores", "Herramientas de Prueba y Medición", "Hardware de Computadora", "Periféricos y Accesorios"})
        cboxcategoria.Location = New Point(660, 75)
        cboxcategoria.Name = "cboxcategoria"
        cboxcategoria.Size = New Size(278, 28)
        cboxcategoria.TabIndex = 37
        ' 
        ' cboxestado
        ' 
        cboxestado.FormattingEnabled = True
        cboxestado.Items.AddRange(New Object() {"Reutilizable", "Desechable"})
        cboxestado.Location = New Point(503, 75)
        cboxestado.Name = "cboxestado"
        cboxestado.Size = New Size(151, 28)
        cboxestado.TabIndex = 36
        ' 
        ' txtcantidadcomp
        ' 
        txtcantidadcomp.Location = New Point(428, 75)
        txtcantidadcomp.Name = "txtcantidadcomp"
        txtcantidadcomp.Size = New Size(69, 27)
        txtcantidadcomp.TabIndex = 34
        ' 
        ' txtdescripcioncomp
        ' 
        txtdescripcioncomp.Location = New Point(141, 75)
        txtdescripcioncomp.Multiline = True
        txtdescripcioncomp.Name = "txtdescripcioncomp"
        txtdescripcioncomp.Size = New Size(281, 78)
        txtdescripcioncomp.TabIndex = 33
        ' 
        ' txtnombrecomp
        ' 
        txtnombrecomp.Location = New Point(10, 75)
        txtnombrecomp.Name = "txtnombrecomp"
        txtnombrecomp.Size = New Size(125, 27)
        txtnombrecomp.TabIndex = 32
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(660, 43)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 31
        Label5.Text = "Categoria"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(503, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 30
        Label4.Text = "Estado"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(428, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 29
        Label3.Text = "Cantidad"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(141, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 28
        Label2.Text = "Descripción"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 27
        Label1.Text = "Nombre"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 35)
        Panel1.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(916, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 29)
        Button1.TabIndex = 9
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(736, 120)
        txtid.Name = "txtid"
        txtid.Size = New Size(125, 27)
        txtid.TabIndex = 41
        txtid.Visible = False
        ' 
        ' modcomp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 161)
        Controls.Add(txtid)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(cboxcategoria)
        Controls.Add(cboxestado)
        Controls.Add(txtcantidadcomp)
        Controls.Add(txtdescripcioncomp)
        Controls.Add(txtnombrecomp)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "modcomp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "modcomp"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cboxcategoria As ComboBox
    Friend WithEvents cboxestado As ComboBox
    Friend WithEvents txtcantidadcomp As TextBox
    Friend WithEvents txtdescripcioncomp As TextBox
    Friend WithEvents txtnombrecomp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtid As TextBox
End Class
