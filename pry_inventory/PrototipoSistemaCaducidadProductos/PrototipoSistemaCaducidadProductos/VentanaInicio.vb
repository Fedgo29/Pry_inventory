Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms

Public Class VentanaInicio
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Edgar\Documents\GitHub\Pry_inventory\pry_inventory\PrototipoSistemaCaducidadProductos\PrototipoSistemaCaducidadProductos.accdb"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles BotonCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BotonMaximizar_Click(sender As Object, e As EventArgs) Handles BotonMaximizar.Click
        WindowState = FormWindowState.Maximized
        BotonMaximizar.Visible = False
        BotonRestaurar.Visible = True
    End Sub

    Private Sub BotonRestaurar_Click(sender As Object, e As EventArgs) Handles BotonRestaurar.Click
        WindowState = FormWindowState.Normal
        BotonRestaurar.Visible = False
        BotonMaximizar.Visible = True
    End Sub

    Private Sub BotonMinimizar_Click(sender As Object, e As EventArgs) Handles BotonMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Close()
        InicioSesion.Show()
    End Sub

    Private Sub AbrirFormulario(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub BotonInicio_Click(sender As Object, e As EventArgs) Handles BotonInicio.Click
        AbrirFormulario(New Inicio)
    End Sub
End Class
