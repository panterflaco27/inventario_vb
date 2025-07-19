Imports System.Data.SqlClient
Imports System.Text

Public Class Pedido
    Dim cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")
    Dim componentesSeleccionados As New Dictionary(Of Integer, Integer) ' ID Componente, Cantidad

    ' ... (resto del código permanece igual hasta los métodos que usan MySQL)
    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If componentesSeleccionados.Count = 0 Then
            MessageBox.Show("No hay componentes en el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el nombre de usuario del formulario invcliente
        Dim clienteForm As invcliente = Application.OpenForms.OfType(Of invcliente)().FirstOrDefault()
        If clienteForm Is Nothing Then
            MessageBox.Show("No se pudo obtener la información del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim username As String = clienteForm.Label1.Text.Replace("Bienvenido: ", "").Trim()
        Dim transaction As SqlTransaction = Nothing
        Dim cn As New SqlConnection("Server=localhost;Database=inventario_electronicos;Integrated Security=True;")

        Try
            cn.Open()
            transaction = cn.BeginTransaction()

            ' 1. Insertar el reporte principal
            Dim queryReporte As String = "INSERT INTO reportes (usuario, fecha) VALUES (@usuario, @fecha); SELECT SCOPE_IDENTITY();"
            Dim cmdReporte As New SqlCommand(queryReporte, cn, transaction)
            cmdReporte.Parameters.AddWithValue("@usuario", username)
            cmdReporte.Parameters.AddWithValue("@fecha", DateTime.Now)

            Dim idReporte As Integer = Convert.ToInt32(cmdReporte.ExecuteScalar())

            ' 2. Insertar los detalles del pedido y actualizar inventario
            For Each kvp As KeyValuePair(Of Integer, Integer) In componentesSeleccionados
                ' Insertar detalle
                Dim queryDetalle As String = "INSERT INTO detalle_reportes (id_reporte, id_componente, cantidad) VALUES (@id_reporte, @id_componente, @cantidad)"
                Dim cmdDetalle As New SqlCommand(queryDetalle, cn, transaction)
                cmdDetalle.Parameters.AddWithValue("@id_reporte", idReporte)
                cmdDetalle.Parameters.AddWithValue("@id_componente", kvp.Key)
                cmdDetalle.Parameters.AddWithValue("@cantidad", kvp.Value)
                cmdDetalle.ExecuteNonQuery()

                ' Actualizar inventario
                Dim queryUpdate As String = "UPDATE inventario SET Cantidad = Cantidad - @cantidad WHERE ID = @id"
                Dim cmdUpdate As New SqlCommand(queryUpdate, cn, transaction)
                cmdUpdate.Parameters.AddWithValue("@id", kvp.Key)
                cmdUpdate.Parameters.AddWithValue("@cantidad", kvp.Value)
                cmdUpdate.ExecuteNonQuery()
            Next

            ' Confirmar transacción si todo salió bien
            transaction.Commit()

            MessageBox.Show($"Pedido registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Cerrar formulario y actualizar inventario en cliente
            clienteForm.CargarInv()
            Me.Close()
        Catch ex As Exception
            ' Revertir transacción solo si existe y la conexión está abierta
            If transaction IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                Try
                    transaction.Rollback()
                Catch rollbackEx As Exception
                    MessageBox.Show("Error al revertir transacción: " & rollbackEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

            MessageBox.Show("Error al registrar el pedido: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar conexión solo si está abierta
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    ' ... (resto del código permanece igual)
End Class