Imports System.Data.SqlClient
Public Class registro
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'obtener datos de los textbox de cada elemento
        Dim nombre As String = txtnombrereg.Text.Trim()
        Dim primerap As String = txtpapreg.Text.Trim()
        Dim segap As String = txtsapreg.Text.Trim()
        Dim nickname As String = txtnicknamereg.Text.Trim()
        Dim password As String = txtpassreg.Text.Trim()
        Dim tipousuario As Integer = If(CheckBox1.Checked, 1, 2)

        'validar datos obligatorios
        If String.IsNullOrEmpty(nombre) OrElse
                String.IsNullOrEmpty(primerap) OrElse
                String.IsNullOrEmpty(nickname) OrElse
                String.IsNullOrEmpty(password) Then
            MessageBox.Show("Debe completar todos los campos olbigatorios (*)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'validar que la contraseña sea de almenos 8 caracteres, use 1 mayuscula y almenos 1 numero
        Dim errorMEssage As String = ""

        'longitud de almenos 8 caracteres
        If password.Length < 8 Then
            errorMEssage += "- La contraseña debe tener al menos 8 caracteres" & Environment.NewLine
        End If

        'almenos 1 letra mayuscula
        If Not password.Any(Function(c) Char.IsUpper(c)) Then
            errorMEssage += "- Debe contener al menos una letra mayúscula" & Environment.NewLine
        End If

        'almenos 1 numero
        If Not password.Any(Function(c) Char.IsDigit(c)) Then
            errorMEssage += "- Debe contener al menos un número" & Environment.NewLine
        End If

        ' Mostrar errores si existen
        If Not String.IsNullOrEmpty(errorMEssage) Then
            MessageBox.Show("La contraseña no cumple los requisitos:" & Environment.NewLine & errorMEssage,
                           "Contraseña insegura",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning)
            txtpassreg.Focus()
            txtpassreg.SelectAll()
            Return
        End If

        'conexion a la base de datos
        Dim cn As String = "Server=localhost;Database=inventario_electronicos;Integrated Security=True;"
        Try
            Using connection As New SqlConnection(cn)
                connection.Open()

                'consulta sql para insertar datos
                Dim query As String = "INSERT INTO Users (Nickname, Nombre, Pap, Sap, Pass, Tipo) VALUES (@nickname, @nombre, @pap, @sap, @pass, @tipousuario)"

                Using cmd As New SqlCommand(query, connection)
                    'asignar valores a los parametros
                    cmd.Parameters.AddWithValue("@nickname", nickname)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@pap", primerap)
                    'en el segundo apellido puede ser nulo, por lo que se usa un if para validar si hay datos o no
                    cmd.Parameters.AddWithValue("@sap", If(String.IsNullOrEmpty(segap), DBNull.Value, segap))
                    'se recomienda encriptar para mayor seguridad
                    cmd.Parameters.AddWithValue("@pass", password)
                    cmd.Parameters.AddWithValue("@tipousuario", tipousuario)

                    'ejecutar la sentencia
                    Dim affect As Integer = cmd.ExecuteNonQuery()

                    If affect > 0 Then
                        MessageBox.Show("¡Registro exitoso!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim login As New Form1()
                        'mostrar el form1
                        login.Show()
                        'ocultar el form registro
                        Me.Hide()
                    End If
                End Using
            End Using
        Catch ex As SqlException When ex.Number = 2627 'error de nickname duplicado (código de error SQL Server)
            MessageBox.Show("El nombre de usuario ya esta en uso, por favor elija otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnicknamereg.Focus()
        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ... (resto del código permanece igual)
End Class