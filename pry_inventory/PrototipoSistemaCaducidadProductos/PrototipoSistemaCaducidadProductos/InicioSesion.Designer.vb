<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        PanelTitulo = New Panel()
        BotonCerrar = New PictureBox()
        PictureBox1 = New PictureBox()
        BotonMaximizar = New PictureBox()
        PictureBox4 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        nombre_de_usuario = New TextBox()
        contrasenia = New TextBox()
        CheckBox1 = New CheckBox()
        BotonInicio = New Button()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        BotonMinimizar = New PictureBox()
        PictureBox7 = New PictureBox()
        Label3 = New Label()
        PanelTitulo.SuspendLayout()
        CType(BotonCerrar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(BotonMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(BotonMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.DarkCyan
        PanelTitulo.Controls.Add(BotonCerrar)
        PanelTitulo.Controls.Add(PictureBox1)
        PanelTitulo.Controls.Add(BotonMaximizar)
        PanelTitulo.Controls.Add(PictureBox4)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(327, 40)
        PanelTitulo.TabIndex = 8
        ' 
        ' BotonCerrar
        ' 
        BotonCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonCerrar.Image = CType(resources.GetObject("BotonCerrar.Image"), Image)
        BotonCerrar.Location = New Point(287, 6)
        BotonCerrar.Name = "BotonCerrar"
        BotonCerrar.Size = New Size(28, 28)
        BotonCerrar.SizeMode = PictureBoxSizeMode.Zoom
        BotonCerrar.TabIndex = 18
        BotonCerrar.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(242, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 28)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' BotonMaximizar
        ' 
        BotonMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonMaximizar.Image = CType(resources.GetObject("BotonMaximizar.Image"), Image)
        BotonMaximizar.Location = New Point(242, 6)
        BotonMaximizar.Name = "BotonMaximizar"
        BotonMaximizar.Size = New Size(27, 28)
        BotonMaximizar.SizeMode = PictureBoxSizeMode.Zoom
        BotonMaximizar.TabIndex = 9
        BotonMaximizar.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(869, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(27, 28)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(32, 120)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 75)
        Label1.TabIndex = 9
        Label1.Text = "SISTEMA DE CADUCIDAD " & vbCrLf & "DE PRODUCTOS" & vbCrLf & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(56, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 22)
        Label2.TabIndex = 10
        Label2.Text = "Usuario:"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' nombre_de_usuario
        ' 
        nombre_de_usuario.Font = New Font("Microsoft Sans Serif", 9F)
        nombre_de_usuario.Location = New Point(56, 234)
        nombre_de_usuario.Name = "nombre_de_usuario"
        nombre_de_usuario.RightToLeft = RightToLeft.No
        nombre_de_usuario.Size = New Size(214, 24)
        nombre_de_usuario.TabIndex = 12
        ' 
        ' contrasenia
        ' 
        contrasenia.Font = New Font("Microsoft Sans Serif", 9F)
        contrasenia.Location = New Point(56, 310)
        contrasenia.Name = "contrasenia"
        contrasenia.RightToLeft = RightToLeft.No
        contrasenia.Size = New Size(214, 24)
        contrasenia.TabIndex = 13
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.ForeColor = Color.Black
        CheckBox1.Location = New Point(56, 344)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(82, 22)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Mostrar"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' BotonInicio
        ' 
        BotonInicio.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        BotonInicio.FlatAppearance.BorderSize = 0
        BotonInicio.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        BotonInicio.FlatStyle = FlatStyle.Flat
        BotonInicio.Font = New Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BotonInicio.ForeColor = Color.White
        BotonInicio.Location = New Point(86, 386)
        BotonInicio.Name = "BotonInicio"
        BotonInicio.Size = New Size(152, 48)
        BotonInicio.TabIndex = 15
        BotonInicio.Text = "INGRESAR"
        BotonInicio.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkCyan
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(BotonMinimizar)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 454)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(327, 40)
        Panel1.TabIndex = 16
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(825, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(27, 28)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        PictureBox5.Visible = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(825, 5)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(27, 28)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 2
        PictureBox6.TabStop = False
        ' 
        ' BotonMinimizar
        ' 
        BotonMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonMinimizar.Image = CType(resources.GetObject("BotonMinimizar.Image"), Image)
        BotonMinimizar.Location = New Point(781, 5)
        BotonMinimizar.Name = "BotonMinimizar"
        BotonMinimizar.Size = New Size(27, 28)
        BotonMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        BotonMinimizar.TabIndex = 1
        BotonMinimizar.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(869, 5)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(27, 28)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(56, 285)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 22)
        Label3.TabIndex = 17
        Label3.Text = "Contraseña:"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' InicioSesion
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(327, 494)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Controls.Add(BotonInicio)
        Controls.Add(CheckBox1)
        Controls.Add(contrasenia)
        Controls.Add(nombre_de_usuario)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PanelTitulo)
        ForeColor = Color.White
        FormBorderStyle = FormBorderStyle.None
        Name = "InicioSesion"
        StartPosition = FormStartPosition.CenterScreen
        Text = "InicioSesion"
        PanelTitulo.ResumeLayout(False)
        CType(BotonCerrar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(BotonMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(BotonMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre_de_usuario As TextBox
    Friend WithEvents contrasenia As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BotonInicio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BotonMinimizar As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotonMaximizar As PictureBox
    Friend WithEvents BotonCerrar As PictureBox
    'Friend WithEvents close As PictureBox
End Class
