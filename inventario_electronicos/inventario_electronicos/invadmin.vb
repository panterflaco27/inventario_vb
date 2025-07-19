'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Invadmin
    Dim cn As New SqlConnection("Server=DESKTOP-60A92PU\SQLEXPRESS;Database=inventario_electronicos;Integrated Security=True;")
    Private Sub Invadmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'llamar funcion de cargar inventario
        CargarInv()

    End Sub

    'funcion para cargar los datos en la tabla
    Public Sub CargarInv(Optional filtro As String = "")
        Dim consulta As String = "select * from inventario"

        'si hay un filtro (buscar)
        If Not String.IsNullOrEmpty(filtro) Then
            consulta += " where Nombre like '%" & filtro & "%'"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'llamamos la funcion buscar agregando el filtro del txt
        CargarInv(txtbuscar.Text.Trim())
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim agregarcomponente As New agregarcomp()
        'mostrar el formulario de agregar componentes
        agregarcomponente.Show()
        'ocultar este form
        Me.Hide()
    End Sub

    Private Sub Invadmin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'funcion para mantener el nombre del usuario
        If Not String.IsNullOrEmpty(Label1.Text) Then
            Label1.Text = Label1.Text
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'ver todo el inventario de nuevo
        CargarInv()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'modificar componente
        'verificar si hay un componente seleccionado
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona un componente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'obtener datos de la fila seleccionada
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
        Dim idcomp As Integer = CInt(selectedRow.Cells(0).Value)

        Dim modificar As New modcomp()
        'pasar datos al formulario modcomp
        modificar.txtid.Text = idcomp.ToString()
        modificar.txtnombrecomp.Text = selectedRow.Cells("Nombre").Value.ToString()
        modificar.txtdescripcioncomp.Text = selectedRow.Cells("Descripcion").Value.ToString()
        modificar.txtcantidadcomp.Text = selectedRow.Cells("Cantidad").Value.ToString()

        'combobox
        modificar.cboxestado.SelectedItem = selectedRow.Cells("Estado").Value.ToString()
        modificar.cboxcategoria.SelectedItem = selectedRow.Cells("Categoria").Value.ToString()

        'mostrar formulario
        If modificar.ShowDialog() = DialogResult.OK Then
            'actualizar el datagrid si se guardaron los cambios
            CargarInv()
        End If
    End Sub

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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim reportesForm As New reportes()
        reportesForm.ShowDialog()
    End Sub
End Class