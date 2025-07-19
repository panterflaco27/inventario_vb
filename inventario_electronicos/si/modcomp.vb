Imports System.Data.SqlClient
Public Class modcomp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'buscar formulario existente
        Dim adminform As invadmin = Application.OpenForms.OfType(Of invadmin)().FirstOrDefault()
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
            Using cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")
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

    ' ... (resto del código permanece igual)
End Class