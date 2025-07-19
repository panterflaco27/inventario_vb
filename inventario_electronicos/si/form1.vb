Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'validar la seleccion del tipo
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione un tipo de usuario", MsgBoxStyle.Exclamation)
        End If

        'obtener el tipo de usuario seleccionado (1=administrador, 2=cliente)
        Dim tiposelec As Integer = ComboBox1.SelectedIndex + 1

        'conexion a la base de datos y consulta de usuario
        Dim cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")
        Dim sql As String = "SELECT Tipo, Nickname FROM Users WHERE Nickname = @usuario AND Pass = @pass"
        Dim cmd As New SqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@usuario", txtusuario.Text)
        cmd.Parameters.AddWithValue("@pass", txtpass.Text)
        Dim dr As SqlDataReader

        Try
            cn.Open()
            dr = cmd.ExecuteReader()

            If dr.Read() Then
                'obtener el tipo de usuario de la db
                Dim tipodb As Integer = Convert.ToInt32(dr("Tipo"))

                'obtener el nombre de usuario
                Dim username As String = dr("Nickname").ToString()

                'verificar si coincide con la seleccion
                If tipodb = tiposelec Then
                    MsgBox("Bienvenido al sistema", MsgBoxStyle.Information)

                    ' abrir el formulario segun el tipo de usuario
                    If tipodb = 1 Then
                        ' formulario de administrador
                        Dim adminForm As New invadmin()
                        'asignar nombre a una etiqueta
                        adminForm.Label1.Text = " Bienvenido: " & username
                        adminForm.Show()
                    Else
                        ' formulario de cliente
                        Dim clienteForm As New invcliente()
                        clienteForm.Label1.Text = " Bienvenido: " & username
                        clienteForm.Show()
                    End If
                    ' ocultar el login
                    Me.Hide()
                Else
                    MsgBox("No tiene permiso para ingresar como " & ComboBox1.Text, MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try

        txtusuario.Text = ""
        txtpass.Text = ""
    End Sub

    ' ... (resto del código permanece igual)
End Class