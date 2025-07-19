Imports System.Data.SqlClient

Public Class invcliente
    Dim cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")
    
    ' ... (resto del código permanece igual)
    
    Public Sub CargarInv(Optional filtro As String = "")
        Dim consulta As String = "SELECT Nombre, Descripcion, Cantidad, Estado, Categoria FROM inventario WHERE Cantidad > 0"

        'si hay un filtro (buscar)
        If Not String.IsNullOrEmpty(filtro) Then
            consulta += " AND Nombre LIKE '%' + @filtro + '%'"
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

    ' ... (resto del código permanece igual)
End Class