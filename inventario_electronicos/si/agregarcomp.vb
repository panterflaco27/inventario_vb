Imports System.Data.SqlClient
Public Class agregarcomp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'buscar formulario existente
        Dim adminform As invadmin = Application.OpenForms.OfType(Of invadmin)().FirstOrDefault()
        If adminform IsNot Nothing Then
            adminform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'buscar formulario existente
        Dim adminform As invadmin = Application.OpenForms.OfType(Of invadmin)().FirstOrDefault()
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
        Dim cn As String = "Server=localhost;Database=inventario_electronicos;Integrated Security=True;"

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
                        Dim adminform As invadmin = Application.OpenForms.OfType(Of invadmin)().FirstOrDefault()
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

    ' ... (resto del código permanece igual)
End Class