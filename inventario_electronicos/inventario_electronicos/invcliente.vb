'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class invcliente
    Dim cn As New SqlConnection("Server=DESKTOP-60A92PU\SQLEXPRESS;Database=inventario_electronicos;Integrated Security=True;")
    Private Sub Invcliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        'llamar funcion de cargar inventario
        CargarInv()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim login As New Form1()
        'mostrar el form registro
        login.Show()
        'ocultar el inventario de admin
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'llamamos la funcion buscar agregando el filtro del txt
        CargarInv(txtbuscar.Text.Trim())
    End Sub

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pedidoForm As New Pedido()
        pedidoForm.ShowDialog()
    End Sub
End Class