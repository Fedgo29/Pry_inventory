Imports System.Data.OleDb

Public Class Categoria
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edgar\Downloads\Temporaly\Daniel_proyecto\PrototipoSistemaCaducidadProductos\PrototipoSistemaCaducidadProductos.accdb"
    Dim Id_Categoria As String


    Private Sub actualizar()
        Dim connection As New OleDbConnection(connectionString)
        Try
            Dim query As String = "UPDATE CATEGORIA SET Nombre = @newNombre, Descripcion = @newDescripcion, Fecha_creacion = @newFechaCreacion WHERE ID = @ID;"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newDescripcion", OleDbType.VarWChar).Value = tbDescripcion.Text
            cmd.Parameters.Add("@newFechacaducidad", OleDbType.Date).Value = Convert.ToDateTime(dtpFecha_Creacion.Text)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_Categoria)

            connection.Open()

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Registro actualizado correctamente.")
            Else
                MessageBox.Show("No se encontró el registro a actualizar")
            End If

        Catch ex As Exception
            MessageBox.Show("Un error ocurrió: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub guardar()
        Dim connection As New OleDbConnection(connectionString)

        Try
            Dim query As String = "INSERT INTO CATEGORIA (Nombre, Descripcion, Fecha_Creacion) VALUES (@newNombre, @newDescripcion, @newFechaCreacion);"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newDescripcion", OleDbType.VarWChar).Value = tbDescripcion.Text
            cmd.Parameters.Add("@newFechaCreacion", OleDbType.Date).Value = Convert.ToDateTime(dtpFecha_Creacion.Text)

            connection.Open()

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Registro guardado correctamente.")
            End If

        Catch ex As Exception
            MessageBox.Show("Un error ocurrió: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If bguardar.Text = "Guardar" Then
            guardar()
            limpiar_controles()
            cargarInfo()
        Else
            actualizar()
            limpiar_controles()
            cargarInfo()
        End If
    End Sub

    Private Sub cargarInfo()
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query = "SELECT * FROM CATEGORIA WHERE NOMBRE LIKE @PARAMETRO OR DESCRIPCION LIKE @PARAMETRO;"
            Dim cmd As New OleDbCommand(query, connection)
            Dim dt As New DataTable

            cmd.Parameters.Add("@PARAMETRO", OleDbType.VarWChar).Value = tbBuscador.Text

            Dim adapter As New OleDbDataAdapter(cmd)


            adapter.Fill(dt)
            dgvVisor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub bBuscador_Click(sender As Object, e As EventArgs) Handles bBuscador.Click
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query = "SELECT * FROM CATEGORIA WHERE NOMBRE LIKE @PARAMETRO OR DESCRIPCION LIKE @PARAMETRO;"
            Dim cmd As New OleDbCommand(query, connection)
            Dim dt As New DataTable

            cmd.Parameters.Add("@PARAMETRO", OleDbType.VarWChar).Value = tbBuscador.Text

            Dim adapter As New OleDbDataAdapter(cmd)


            adapter.Fill(dt)
            dgvVisor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub limpiar_controles()
        tb_nombre.Clear()
        dtpFecha_Creacion.Text = "11/20/2024"
        tbDescripcion.Clear()
        bguardar.Text = "Guardar"
    End Sub
    Private Sub blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        limpiar_controles()
    End Sub

    Private Sub dgvVisor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisor.CellClick
        Dim connection As New OleDbConnection(connectionString)
        Try
            Id_Categoria = dgvVisor.CurrentRow.Cells("ID").Value.ToString
            If Id_Categoria <> "" Then
                connection.Open()
                Dim query = "SELECT * FROM CATEGORIA WHERE ID=" + Id_Categoria
                Dim command As New OleDbCommand(query, connection)
                Dim reader = command.ExecuteReader


                While reader.Read
                    tb_nombre.Text = reader("NOMBRE").ToString
                    tbDescripcion.Text = reader("DESCRIPCION").ToString
                    tbFecha_Creacion.Text = reader("FECHA_CREACION").ToString
                End While
                bguardar.Text = "Actualizar"
                reader.Close()
            Else
                MessageBox.Show("Error: Registro no encontrado")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim connection As New OleDbConnection(connectionString)
        Try
            Dim query = "DELETE FROM CATEGORIA WHERE ID = @ID;"
            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_Categoria)

            connection.Open()

            Dim rowsAffected = cmd.ExecuteNonQuery

            If rowsAffected > 0 Then
                MessageBox.Show("Registro eliminado correctamente.")
                limpiar_controles()
                cargarInfo()
            End If

        Catch ex As Exception
            MessageBox.Show("Un error ocurrió: " & ex.Message)
        Finally
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class