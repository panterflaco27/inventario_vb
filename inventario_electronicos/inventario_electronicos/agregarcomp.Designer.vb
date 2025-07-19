<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregarcomp
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtnombrecomp = New TextBox()
        txtdescripcioncomp = New TextBox()
        txtcantidadcomp = New TextBox()
        cboxestado = New ComboBox()
        cboxcategoria = New ComboBox()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(947, 35)
        Panel1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(911, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 29)
        Button1.TabIndex = 9
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 12
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(143, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 13
        Label2.Text = "Descripción"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(430, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 14
        Label3.Text = "Cantidad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(505, 49)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 15
        Label4.Text = "Estado"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(662, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 16
        Label5.Text = "Categoria"
        ' 
        ' txtnombrecomp
        ' 
        txtnombrecomp.Location = New Point(12, 80)
        txtnombrecomp.Name = "txtnombrecomp"
        txtnombrecomp.Size = New Size(125, 27)
        txtnombrecomp.TabIndex = 17
        ' 
        ' txtdescripcioncomp
        ' 
        txtdescripcioncomp.Location = New Point(143, 80)
        txtdescripcioncomp.Multiline = True
        txtdescripcioncomp.Name = "txtdescripcioncomp"
        txtdescripcioncomp.Size = New Size(281, 78)
        txtdescripcioncomp.TabIndex = 18
        ' 
        ' txtcantidadcomp
        ' 
        txtcantidadcomp.Location = New Point(430, 80)
        txtcantidadcomp.Name = "txtcantidadcomp"
        txtcantidadcomp.Size = New Size(69, 27)
        txtcantidadcomp.TabIndex = 19
        ' 
        ' cboxestado
        ' 
        cboxestado.FormattingEnabled = True
        cboxestado.Items.AddRange(New Object() {"Reutilizable", "Desechable"})
        cboxestado.Location = New Point(505, 80)
        cboxestado.Name = "cboxestado"
        cboxestado.Size = New Size(151, 28)
        cboxestado.TabIndex = 21
        ' 
        ' cboxcategoria
        ' 
        cboxcategoria.FormattingEnabled = True
        cboxcategoria.Items.AddRange(New Object() {"Componentes Eléctricos y Electrónicos Básicos", "Fuentes de energía y Regulación", "Microcontroladores y Placas de Desarrollo", "Módulos de Comunicación", "Pantallas y Visualización", "Sensores y Actuadores", "Herramientas de Prueba y Medición", "Hardware de Computadora", "Periféricos y Accesorios"})
        cboxcategoria.Location = New Point(662, 80)
        cboxcategoria.Name = "cboxcategoria"
        cboxcategoria.Size = New Size(278, 28)
        cboxcategoria.TabIndex = 22
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(482, 129)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 24
        Button2.Text = "Cancelar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(582, 129)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 25
        Button3.Text = "Agregar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' agregarcomp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(947, 170)
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
        Name = "agregarcomp"
        StartPosition = FormStartPosition.CenterScreen
        Text = "agregarcomp"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnombrecomp As TextBox
    Friend WithEvents txtdescripcioncomp As TextBox
    Friend WithEvents txtcantidadcomp As TextBox
    Friend WithEvents cboxestado As ComboBox
    Friend WithEvents cboxcategoria As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
