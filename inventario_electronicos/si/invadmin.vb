Imports System.Data.SqlClient

Public Class Invadmin
    Dim cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")
    
    ' ... (resto del código permanece igual hasta los métodos que usan MySQL)
    
    'funcion para cargar los datos en la tabla
    Public Sub CargarInv(Optional filtro As String = "")
        Dim consulta As String = "SELECT * FROM inventario"

        'si hay un filtro (buscar)
        If Not String.IsNullOrEmpty(filtro) Then
            consulta += " WHERE Nombre LIKE '%' + @filtro + '%'"
        End If
        
        Try
            Dim adaptador As New SqlDataAdapter(consulta, cn)
            If Not String.IsNullOrEmpty(filtro) Then
                adaptador.SelectCommand.Parameters.AddWithValue("@filtro", filtro)
            End If
            
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt

            If dt.Rows.Count = 0 AndAlso Not String.IsNullOrEmpty(filtro) Then
                MessageBox.Show("Error al buscar: " & filtro & ", verifica que el nombre este bien escrito o que exista el componente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ... (resto del código permanece igual hasta el método Button6_Click)
    
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'borrar componente
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un componente para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'obtener el ID del componente seleccionado
        Dim idcomp As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
        Dim nombrecomp As String = DataGridView1.SelectedRows(0).Cells("Nombre").Value.ToString()

        'confirmar la eliminacion
        Dim resp As DialogResult = MessageBox.Show("¿Estás seguro de eliminar el componente: " & nombrecomp & "?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = DialogResult.Yes Then
            Try
                'conectar a la base de datos y eliminar el componente
                cn.Open()
                Dim sql As String = "DELETE FROM inventario WHERE ID = @id"
                Dim cmd As New SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@id", idcomp)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Componente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'recargar el inventario
                CargarInv()
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el componente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    ' ... (resto del código permanece igual)
End Class