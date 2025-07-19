'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class modcomp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'buscar formulario existente
        Dim adminform As Invadmin = Application.OpenForms.OfType(Of Invadmin)().FirstOrDefault()
        If adminform IsNot Nothing Then
            adminform.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'validar campos
        If String.IsNullOrEmpty(txtnombrecomp.Text) OrElse
                String.IsNullOrEmpty(txtdescripcioncomp.Text) OrElse
                String.IsNullOrEmpty(txtcantidadcomp.Text) OrElse
                cboxestado.SelectedIndex = -1 OrElse
                cboxcategoria.SelectedIndex = -1 Then

            MessageBox.Show("Porfavor llena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' validar que cantidad y precio sean números
        If Not IsNumeric(txtcantidadcomp.Text) Then
            MessageBox.Show("Cantidad debe ser números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'actualizar la base de datos
        Try
            Using cn As New SqlConnection("Server=DESKTOP-60A92PU\SQLEXPRESS;Database=inventario_electronicos;Integrated Security=True;")
                cn.Open()
                Dim query As String = "UPDATE inventario SET Nombre = @nombre, Descripcion = @descripcion, Cantidad = @cantidad, Estado = @estado, Categoria = @categoria WHERE id = @id"

                Using cmd As New SqlCommand(query, cn)
                    cmd.Parameters.AddWithValue("@nombre", txtnombrecomp.Text)
                    cmd.Parameters.AddWithValue("@descripcion", txtdescripcioncomp.Text)
                    cmd.Parameters.AddWithValue("@cantidad", txtcantidadcomp.Text)
                    cmd.Parameters.AddWithValue("@estado", cboxestado.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@categoria", cboxcategoria.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@id", txtid.Text)

                    Dim affect As Integer = cmd.ExecuteNonQuery()

                    If affect > 0 Then
                        MessageBox.Show("Componente actualizado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MessageBox.Show("No se pudo actualizar el componente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class