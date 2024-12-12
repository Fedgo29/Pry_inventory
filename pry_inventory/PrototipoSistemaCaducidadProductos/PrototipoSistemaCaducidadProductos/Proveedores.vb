Imports System.Data.OleDb

Public Class Proveedores
    Dim connectionString As String = VentanaInicio.connectionString
    Dim Id_proveedores As String


    Private Sub guardar()
        Dim connection As New OleDbConnection(connectionString)

        Try
            Dim query As String = "INSERT INTO PROVEEDOR (NOMBRE_PROVEEDOR, DIRECCION_PROVEEDOR, NOMBRE_CONTACTO, CARGO_CONTACTO) VALUES (@newNombre, @newDireccion, @newNombreContacto, @newCargoContacto);"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newDireccion", OleDbType.VarWChar).Value = tbDireccion.Text
            cmd.Parameters.Add("@newNombreContacto", OleDbType.VarWChar).Value = tbNombreContacto.Text
            cmd.Parameters.Add("@newCargoContacto", OleDbType.VarWChar).Value = tbCargoContacto.Text

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

    Private Sub actualizar()
        Dim connection As New OleDbConnection(connectionString)
        Try
            Dim query As String = "UPDATE PROVEEDOR SET NOMBRE_PROVEEDOR = @newNombre, DIRECCION_PROVEEDOR = @newDireccion, NOMBRE_CONTACTO = @newNombreContacto, CARGO_CONTACTO = @newCargoContacto WHERE ID = @ID;"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newDireccion", OleDbType.VarWChar).Value = tbDireccion.Text
            cmd.Parameters.Add("@newNombreContacto", OleDbType.VarWChar).Value = tbNombreContacto.Text
            cmd.Parameters.Add("@newCargoContacto", OleDbType.VarWChar).Value = tbCargoContacto.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_proveedores)

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

    Private Sub bBuscador_Click(sender As Object, e As EventArgs) Handles bBuscador.Click
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query = "SELECT * FROM PROVEEDOR WHERE NOMBRE_PROVEEDOR LIKE @PARAMETRO OR NOMBRE_CONTACTO LIKE @PARAMETRO;"
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

    Private Sub dgvVisor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisor.CellClick
        Dim connection As New OleDbConnection(connectionString)
        Try
            Id_proveedores = dgvVisor.CurrentRow.Cells("ID").Value.ToString
            If Id_proveedores <> "" Then
                connection.Open()
                Dim query = "SELECT * FROM PROVEEDOR WHERE ID=" + Id_proveedores
                Dim command As New OleDbCommand(query, connection)
                Dim reader = command.ExecuteReader


                While reader.Read
                    tb_nombre.Text = reader("NOMBRE_PROVEEDOR").ToString
                    tbDireccion.Text = reader("DIRECCION_PROVEEDOR").ToString
                    tbNombreContacto.Text = reader("NOMBRE_CONTACTO").ToString
                    tbCargoContacto.Text = reader("CARGO_CONTACTO").ToString
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

    Private Sub limpiar_controles()
        tb_nombre.Clear()
        tbDireccion.Clear()
        tbNombreContacto.Clear()
        tbCargoContacto.Clear()
    End Sub

    Private Sub blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        limpiar_controles()
    End Sub

    Private Sub cargarInfo()
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM PROVEEDOR"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvVisor.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If (Id_proveedores <> "") Then
            Dim connection As New OleDbConnection(connectionString)
            Try
                Dim query = "DELETE FROM PROVEEDOR WHERE ID = @ID;"
                Dim cmd = New OleDbCommand(query, connection)

                cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_proveedores)

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
        End If
    End Sub

    Private Sub PProveedor_Paint(sender As Object, e As PaintEventArgs) Handles PProveedor.Paint

    End Sub
End Class