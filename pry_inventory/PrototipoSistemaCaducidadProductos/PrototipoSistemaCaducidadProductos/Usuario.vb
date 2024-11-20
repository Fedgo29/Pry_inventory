Imports System.Data.OleDb

Public Class Usuario

    ' Definiendo la cadena de conexion.
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edgar\Downloads\Temporaly\Daniel_proyecto\PrototipoSistemaCaducidadProductos\PrototipoSistemaCaducidadProductos.accdb"
    Dim Id_usuario As String

    Private Sub actualizar()
        Dim connection As New OleDbConnection(connectionString)

        Try
            Dim query As String = "UPDATE USUARIO Nombre= @newNombre, Apellido=@newApellido, Nombre_de_usuario=@newNombreUsuario, Correo_electronico=@newCorreo, Contrasenia=@newContrasenia, Activo=@newActivo, Admin=@newAdmin, Fecha_Creacion=@newFechaCreacion WHERE ID=@ID;"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newApellido", OleDbType.VarWChar).Value = tb_apellido.Text
            cmd.Parameters.Add("@newNombreUsuario", OleDbType.VarWChar).Value = tb_nombreusuario.Text
            cmd.Parameters.Add("@newCorreo", OleDbType.VarWChar).Value = tb_correoelectronico.Text
            cmd.Parameters.Add("@newContrasenia", OleDbType.VarWChar).Value = tb_contraseniados.Text
            cmd.Parameters.Add("@newActivo", OleDbType.Boolean).Value = cbactivo.Checked
            cmd.Parameters.Add("@newAdmin", OleDbType.Boolean).Value = cbadmin.Checked
            cmd.Parameters.Add("@newFechaCreacion", OleDbType.Date).Value = Convert.ToDateTime(dtp_ingreso.Text)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_usuario)

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

    Private Sub guardar()
        Dim connection As New OleDbConnection(connectionString)

        Try
            Dim query As String = "INSERT INTO USUARIO (Nombre, Apellido, Nombre_de_usuario, Correo_electronico, Contrasenia, Activo, Admin, Fecha_Creacion) VALUES (@newNombre, @newApellido, @newNombreUsuario, @newCorreo, @newContrasenia, @newActivo, @newAdmin, @newFechaCreacion);"

            Dim cmd = New OleDbCommand(query, connection)

            cmd.Parameters.Add("@newNombre", OleDbType.VarWChar).Value = tb_nombre.Text
            cmd.Parameters.Add("@newApellido", OleDbType.VarWChar).Value = tb_apellido.Text
            cmd.Parameters.Add("@newNombreUsuario", OleDbType.VarWChar).Value = tb_nombreusuario.Text
            cmd.Parameters.Add("@newCorreo", OleDbType.VarWChar).Value = tb_correoelectronico.Text
            cmd.Parameters.Add("@newContrasenia", OleDbType.VarWChar).Value = tb_contraseniados.Text
            cmd.Parameters.Add("@newActivo", OleDbType.Boolean).Value = cbactivo.Checked
            cmd.Parameters.Add("@newAdmin", OleDbType.Boolean).Value = cbadmin.Checked
            cmd.Parameters.Add("@newFechaCreacion", OleDbType.Date).Value = Convert.ToDateTime(dtp_ingreso.Text)

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

    Private Sub limpiar_controles()
        tb_nombre.Clear()
        tb_apellido.Clear()
        tb_correoelectronico.Clear()
        tb_nombreusuario.Clear()
        tb_contraseniauna.Clear()
        tb_contraseniados.Clear()
        cbadmin.Checked = False
        cbactivo.Checked = False
        bguardar.Text = "Guardar"
    End Sub

    Private Sub cargarInfo()
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM USUARIO"
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

    Private Sub bBuscador_Click(sender As Object, e As EventArgs) Handles bBuscador.Click
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query = "SELECT * FROM USUARIO WHERE NOMBRE LIKE @PARAMETRO OR NOMBRE_DE_USUARIO LIKE @PARAMETRO;"
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

    Private Sub blimpiar_Click(sender As Object, e As EventArgs) Handles blimpiar.Click
        limpiar_controles()
    End Sub

    Private Sub dgvVisor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisor.CellClick
        Dim connection As New OleDbConnection(connectionString)
        Try
            Id_usuario = dgvVisor.CurrentRow.Cells("ID").Value.ToString
            If Id_usuario <> "" Then
                connection.Open()
                Dim query = "SELECT * FROM USUARIO WHERE ID=" + Id_usuario
                Dim command As New OleDbCommand(query, connection)
                Dim reader = command.ExecuteReader


                While reader.Read
                    tb_nombre.Text = reader("NOMBRE").ToString
                    tb_apellido.Text = reader("APELLIDO").ToString
                    tb_nombreusuario.Text = reader("NOMBRE_DE_USUARIO").ToString
                    tb_correoelectronico.Text = reader("CORREO_ELECTRONICO").ToString
                    tb_contraseniauna.Text = reader("CONTRASENIA").ToString
                    tb_contraseniados.Text = reader("CONTRASENIA").ToString
                    cbadmin.Checked = reader("ADMIN")
                    cbactivo.Checked = reader("ACTIVO")
                    dtp_ingreso.Text = reader("FECHA_CREACION").ToString()
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
        If (Id_usuario <> "") Then
            Dim connection As New OleDbConnection(connectionString)
            Try
                Dim query = "DELETE FROM USUARIO WHERE ID = @ID;"
                Dim cmd = New OleDbCommand(query, connection)

                cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Id_usuario)

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
End Class