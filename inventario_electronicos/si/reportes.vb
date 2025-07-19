Imports System.Data.SqlClient
Imports System.Text

Public Class reportes
    Dim cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")

    ' ... (resto del código permanece igual hasta los métodos que usan MySQL)
    
    Private Sub CargarReportes(Optional filtro As String = "")
        Try
            Dim consulta As String = "SELECT r.id, r.usuario, r.fecha FROM reportes r"

            If Not String.IsNullOrEmpty(filtro) Then
                consulta += " WHERE r.usuario LIKE '%' + @filtro + '%' OR CONVERT(date, r.fecha) = @filtro"
            End If

            consulta += " ORDER BY r.fecha DESC"

            Dim adaptador As New SqlDataAdapter(consulta, cn)
            If Not String.IsNullOrEmpty(filtro) Then
                adaptador.SelectCommand.Parameters.AddWithValue("@filtro", filtro)
            End If
            
            Dim dt As New DataTable
            adaptador.Fill(dt)

            dgvreportes.DataSource = dt

            ' Formatear columnas
            If dt.Columns.Contains("fecha") Then
                dgvreportes.Columns("fecha").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar reportes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgvreportes.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un reporte para ver su detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idReporte As Integer = CInt(dgvreportes.SelectedRows(0).Cells("id").Value)

        Try
            Dim consulta As String = "SELECT i.Nombre, dr.cantidad FROM detalle_reportes dr " &
                        "JOIN inventario i ON dr.id_componente = i.ID " &
                        "WHERE dr.id_reporte = @idReporte"

            Dim adaptador As New SqlDataAdapter(consulta, cn)
            adaptador.SelectCommand.Parameters.AddWithValue("@idReporte", idReporte)

            Dim dt As New DataTable
            adaptador.Fill(dt)

            ' Mostrar detalle en un MessageBox o en otro control
            Dim detalle As New StringBuilder()
            detalle.AppendLine("Detalle del Reporte #" & idReporte)
            detalle.AppendLine("-----------------------------")

            For Each row As DataRow In dt.Rows
                detalle.AppendLine($"{row("Nombre")} x {row("cantidad")}")
            Next

            detalle.AppendLine("-----------------------------")

            MessageBox.Show(detalle.ToString(), "Detalle del Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al obtener detalle: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ... (resto del código permanece igual)
End Class