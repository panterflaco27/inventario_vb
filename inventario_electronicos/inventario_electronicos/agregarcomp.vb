'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class agregarcomp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'buscar formulario existente
        Dim adminform As Invadmin = Application.OpenForms.OfType(Of Invadmin)().FirstOrDefault()
        If adminform IsNot Nothing Then
            adminform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'buscar formulario existente
        Dim adminform As Invadmin = Application.OpenForms.OfType(Of Invadmin)().FirstOrDefault()
        If adminform IsNot Nothing Then
            adminform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Validar campos vacíos PRIMERO (incluyendo ComboBox)
        If String.IsNullOrEmpty(txtnombrecomp.Text.Trim()) OrElse
            String.IsNullOrEmpty(txtdescripcioncomp.Text.Trim()) OrElse
            String.IsNullOrEmpty(txtcantidadcomp.Text.Trim()) OrElse
            cboxestado.SelectedIndex = -1 OrElse  ' Verifica si hay ítem seleccionado
            cboxcategoria.SelectedIndex = -1 Then

            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'obtener datos de los textbox de cada elemento
        Dim nombre As String = txtnombrecomp.Text.Trim()
        Dim descripcion As String = txtdescripcioncomp.Text.Trim()
        Dim cantidad As String = txtcantidadcomp.Text.Trim()
        Dim estado As String = cboxestado.SelectedItem.ToString()
        Dim categoria As String = cboxcategoria.SelectedItem.ToString()

        'conexion a la db
        Dim cn As String = "Server=DESKTOP-60A92PU\SQLEXPRESS;Database=inventario_electronicos;Integrated Security=True;"


        Try
            Using connection As New SqlConnection(cn)
                connection.Open()
                'sentencia para agregar datos a inventario
                Dim query As String = "INSERT INTO inventario (Nombre, Descripcion, Cantidad, Estado, Categoria) VALUES (@nombre, @descripcion, @cantidad, @estado, @categoria)"
                Using cmd As New SqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@descripcion", descripcion)
                    cmd.Parameters.AddWithValue("@cantidad", cantidad)
                    cmd.Parameters.AddWithValue("@estado", estado)
                    cmd.Parameters.AddWithValue("@categoria", categoria)

                    'ejecutar la sentencia
                    Dim affect As Integer = cmd.ExecuteNonQuery()

                    If affect > 0 Then
                        MessageBox.Show("Registro exitoso!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'buscar el formulario ecistente
                        Dim adminform As Invadmin = Application.OpenForms.OfType(Of Invadmin)().FirstOrDefault()
                        If adminform IsNot Nothing Then
                            adminform.Show()
                            adminform.CargarInv()
                        End If
                        Me.Close()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Txtcantidadcomp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidadcomp.KeyPress
        Dim cantidad As TextBox = DirectCast(sender, TextBox)
        If Not Char.IsDigit(e.KeyChar) Then
            ' Permitir punto decimal (solo uno)
            If e.KeyChar = "."c Then
                If cantidad.Text.Contains(".") Or cantidad.Text.Length = 0 Then
                    e.Handled = True ' Bloquea si ya hay un punto o si es el primer carácter
                End If
                ' Permitir tecla Backspace
            ElseIf e.KeyChar <> ControlChars.Back Then
                e.Handled = True ' Bloquea cualquier otro carácter
            End If
        End If
    End Sub

End Class