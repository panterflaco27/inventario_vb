'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Pedido
    Dim cn As New SqlConnection("Server=DESKTOP-60A92PU\SQLEXPRESS;Database=inventario_electronicos;Integrated Security=True;")
    Dim componentesSeleccionados As New Dictionary(Of Integer, Integer) ' ID Componente, Cantidad

    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarcomps()
    End Sub

    Private Sub cargarcomps()
        Try
            Dim consulta As String = "select id, Nombre, Cantidad from inventario where Cantidad > 0"
            Dim adaptador As New SqlDataAdapter(consulta, cn)
            Dim dt As New DataTable
            adaptador.Fill(dt)

            cboxcomp.dataSource = dt
            cboxcomp.DisplayMember = "Nombre"
            cboxcomp.ValueMember = "id"

            'mostrar precio y cantidad disponible
            If dt.Rows.Count > 0 Then
                txtdisponible.Text = dt.Rows(0)("Cantidad").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar componentes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cboxcomp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxcomp.SelectedIndexChanged
        If cboxcomp.SelectedValue IsNot Nothing AndAlso IsNumeric(cboxcomp.SelectedValue) Then
            Try
                cn.Open()
                Dim query As String = "SELECT Cantidad FROM inventario WHERE ID = @id"
                Dim cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@id", cboxcomp.SelectedValue)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtdisponible.Text = reader("Cantidad").ToString()
                End If
                cn.Close()
            Catch ex As Exception
                cn.Close()
                MessageBox.Show("Error al obtener detalles del componente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cboxcomp.SelectedValue Is Nothing OrElse Not IsNumeric(txtcantidad.Text) Then
            MessageBox.Show("Seleccione un componente y especifique una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idComponente As Integer = CInt(cboxcomp.SelectedValue)
        Dim cantidad As Integer = CInt(txtcantidad.Text)
        Dim disponible As Integer = CInt(txtdisponible.Text)

        If cantidad <= 0 Then
            MessageBox.Show("La cantidad debe ser mayor que cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cantidad > disponible Then
            MessageBox.Show("No hay suficiente stock disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Agregar o actualizar el componente en el pedido
        If componentesSeleccionados.ContainsKey(idComponente) Then
            componentesSeleccionados(idComponente) += cantidad
        Else
            componentesSeleccionados.Add(idComponente, cantidad)
        End If
        ' Actualizar lista de componentes seleccionados
        actualizarcomps()

        ' Limpiar campos
        txtcantidad.Text = "1"
    End Sub

    Private Sub Actualizarcomps()
        listcomps.Items.Clear()
        For Each kvp As KeyValuePair(Of Integer, Integer) In componentesSeleccionados
            Dim nombreComponente As String = ObtenerNombreComponente(kvp.Key)
            listcomps.Items.Add($"{nombreComponente} x {kvp.Value}")
        Next
    End Sub

    Private Function ObtenerNombreComponente(id As Integer) As String
        Try
            cn.Open()
            Dim query As String = "SELECT Nombre FROM inventario WHERE ID = @id"
            Dim cmd As New SqlCommand(query, cn)
            cmd.Parameters.AddWithValue("@id", id)

            Dim nombre As String = cmd.ExecuteScalar().ToString()
            cn.Close()
            Return nombre
        Catch ex As Exception
            cn.Close()
            Return "Componente"
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If listcomps.SelectedIndex = -1 Then Return

        Dim selectedItem As String = listcomps.SelectedItem.ToString()
        Dim idComponente As Integer = componentesSeleccionados.Keys.ToList()(listcomps.SelectedIndex)

        Dim cantidad As Integer = componentesSeleccionados(idComponente)

        ' Eliminar del diccionario
        componentesSeleccionados.Remove(idComponente)

        ' Actualizar lista
        Actualizarcomps()
    End Sub

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
        Dim cn As New SqlConnection("Server=DESKTOP-60A92PU\SQLEXPRESS;Database=inventario_electronicos;Integrated Security=True;")

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class