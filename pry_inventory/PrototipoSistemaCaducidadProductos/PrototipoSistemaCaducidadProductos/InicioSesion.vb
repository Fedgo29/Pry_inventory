Imports System.Data.OleDb

Public Class InicioSesion

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edgar\Downloads\Temporaly\Daniel_proyecto\PrototipoSistemaCaducidadProductos\PrototipoSistemaCaducidadProductos.accdb"

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub BotonRestaurar_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BotonInicio_Click(sender As Object, e As EventArgs) Handles BotonInicio.Click
        Dim connection As New OleDbConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM USUARIO WHERE NOMBRE_DE_USUARIO='" + nombre_de_usuario.Text.ToString() + "'"
            Dim command As New OleDbCommand(query, connection)
            Dim reader As OleDbDataReader = command.ExecuteReader()
            Dim nombre_de_usuario_bd As String
            Dim contrasenia_bd As String

            While reader.Read()
                nombre_de_usuario_bd = reader("Nombre_de_usuario").ToString()
                contrasenia_bd = reader("Contrasenia").ToString()

            End While
            If nombre_de_usuario.Text = nombre_de_usuario_bd And contrasenia.Text = contrasenia_bd Then
                nombre_de_usuario.Clear()
                contrasenia.Clear()
                CheckBox1.Checked = False
                VentanaInicio.lUser.Text = "Usuario activo: " + nombre_de_usuario_bd
                Me.Hide()
                VentanaInicio.Show()
            Else
                MessageBox.Show("Acceso denegado")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            contrasenia.UseSystemPasswordChar = True
        Else
            contrasenia.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub contrasenia_MouseHover(sender As Object, e As EventArgs) Handles contrasenia.MouseHover
        contrasenia.UseSystemPasswordChar = True
    End Sub

    Private Sub BotonCerrar_Click_1(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Application.Exit()
    End Sub
End Class