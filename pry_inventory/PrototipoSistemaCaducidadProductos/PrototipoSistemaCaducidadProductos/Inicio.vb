Public Class Inicio

    Private Sub bUsuario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub bProducto_Click(sender As Object, e As EventArgs)
        VentanaInicio.Show
        Close
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)
        Application.Exit
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub AbrirFormulario(ByVal Formhijo As Object)
        If VentanaInicio.PanelContenedor.Controls.Count > 0 Then
            VentanaInicio.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        VentanaInicio.PanelContenedor.Controls.Add(fh)
        VentanaInicio.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub bProducto_Click_1(sender As Object, e As EventArgs) Handles bProducto.Click
        AbrirFormulario(New Productos)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormulario(New Proveedores)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AbrirFormulario(New Categoria)
    End Sub

    Private Sub bUsuario_Click_1(sender As Object, e As EventArgs) Handles bUsuario.Click
        AbrirFormulario(New Usuario)
    End Sub
End Class