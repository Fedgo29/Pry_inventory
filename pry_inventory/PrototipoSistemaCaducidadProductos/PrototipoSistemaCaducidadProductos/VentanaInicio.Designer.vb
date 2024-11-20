<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VentanaInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentanaInicio))
        PanelTitulo = New Panel()
        BotonRestaurar = New PictureBox()
        BotonMaximizar = New PictureBox()
        BotonMinimizar = New PictureBox()
        BotonCerrar = New PictureBox()
        PanelMenu = New Panel()
        Panel2 = New Panel()
        lUser = New Label()
        BotonSalir = New Button()
        Panel1 = New Panel()
        BotonInicio = New Button()
        PanelContenedor = New Panel()
        PanelTitulo.SuspendLayout()
        CType(BotonRestaurar, ComponentModel.ISupportInitialize).BeginInit()
        CType(BotonMaximizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(BotonMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(BotonCerrar, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.DarkCyan
        PanelTitulo.Controls.Add(BotonRestaurar)
        PanelTitulo.Controls.Add(BotonMaximizar)
        PanelTitulo.Controls.Add(BotonMinimizar)
        PanelTitulo.Controls.Add(BotonCerrar)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(1300, 40)
        PanelTitulo.TabIndex = 0
        ' 
        ' BotonRestaurar
        ' 
        BotonRestaurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonRestaurar.Image = CType(resources.GetObject("BotonRestaurar.Image"), Image)
        BotonRestaurar.Location = New Point(1216, 6)
        BotonRestaurar.Name = "BotonRestaurar"
        BotonRestaurar.Size = New Size(28, 28)
        BotonRestaurar.SizeMode = PictureBoxSizeMode.Zoom
        BotonRestaurar.TabIndex = 3
        BotonRestaurar.TabStop = False
        BotonRestaurar.Visible = False
        ' 
        ' BotonMaximizar
        ' 
        BotonMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonMaximizar.Image = CType(resources.GetObject("BotonMaximizar.Image"), Image)
        BotonMaximizar.Location = New Point(1216, 6)
        BotonMaximizar.Name = "BotonMaximizar"
        BotonMaximizar.Size = New Size(28, 28)
        BotonMaximizar.SizeMode = PictureBoxSizeMode.Zoom
        BotonMaximizar.TabIndex = 2
        BotonMaximizar.TabStop = False
        ' 
        ' BotonMinimizar
        ' 
        BotonMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonMinimizar.Image = CType(resources.GetObject("BotonMinimizar.Image"), Image)
        BotonMinimizar.Location = New Point(1172, 6)
        BotonMinimizar.Name = "BotonMinimizar"
        BotonMinimizar.Size = New Size(28, 28)
        BotonMinimizar.SizeMode = PictureBoxSizeMode.Zoom
        BotonMinimizar.TabIndex = 1
        BotonMinimizar.TabStop = False
        ' 
        ' BotonCerrar
        ' 
        BotonCerrar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BotonCerrar.Image = CType(resources.GetObject("BotonCerrar.Image"), Image)
        BotonCerrar.Location = New Point(1260, 6)
        BotonCerrar.Name = "BotonCerrar"
        BotonCerrar.Size = New Size(28, 28)
        BotonCerrar.SizeMode = PictureBoxSizeMode.Zoom
        BotonCerrar.TabIndex = 0
        BotonCerrar.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        PanelMenu.Controls.Add(Panel2)
        PanelMenu.Controls.Add(lUser)
        PanelMenu.Controls.Add(BotonSalir)
        PanelMenu.Controls.Add(Panel1)
        PanelMenu.Controls.Add(BotonInicio)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 40)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(232, 771)
        PanelMenu.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkCyan
        Panel2.Location = New Point(0, 237)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(11, 54)
        Panel2.TabIndex = 2
        ' 
        ' lUser
        ' 
        lUser.AutoSize = True
        lUser.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold)
        lUser.ForeColor = Color.White
        lUser.Location = New Point(12, 26)
        lUser.Name = "lUser"
        lUser.Size = New Size(60, 21)
        lUser.TabIndex = 26
        lUser.Text = "Usuario"
        ' 
        ' BotonSalir
        ' 
        BotonSalir.FlatAppearance.BorderSize = 0
        BotonSalir.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        BotonSalir.FlatStyle = FlatStyle.Flat
        BotonSalir.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BotonSalir.ForeColor = Color.White
        BotonSalir.Location = New Point(0, 237)
        BotonSalir.Name = "BotonSalir"
        BotonSalir.Size = New Size(232, 54)
        BotonSalir.TabIndex = 2
        BotonSalir.Text = "SALIR"
        BotonSalir.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkCyan
        Panel1.Location = New Point(0, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(11, 54)
        Panel1.TabIndex = 1
        ' 
        ' BotonInicio
        ' 
        BotonInicio.FlatAppearance.BorderSize = 0
        BotonInicio.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        BotonInicio.FlatStyle = FlatStyle.Flat
        BotonInicio.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BotonInicio.ForeColor = Color.White
        BotonInicio.Location = New Point(0, 114)
        BotonInicio.Name = "BotonInicio"
        BotonInicio.Size = New Size(232, 54)
        BotonInicio.TabIndex = 0
        BotonInicio.Text = "INICIO"
        BotonInicio.UseVisualStyleBackColor = True
        ' 
        ' PanelContenedor
        ' 
        PanelContenedor.BackColor = Color.White
        PanelContenedor.Dock = DockStyle.Fill
        PanelContenedor.Location = New Point(232, 40)
        PanelContenedor.Name = "PanelContenedor"
        PanelContenedor.Size = New Size(1068, 771)
        PanelContenedor.TabIndex = 2
        ' 
        ' VentanaInicio
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1300, 811)
        Controls.Add(PanelContenedor)
        Controls.Add(PanelMenu)
        Controls.Add(PanelTitulo)
        FormBorderStyle = FormBorderStyle.None
        Name = "VentanaInicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelTitulo.ResumeLayout(False)
        CType(BotonRestaurar, ComponentModel.ISupportInitialize).EndInit()
        CType(BotonMaximizar, ComponentModel.ISupportInitialize).EndInit()
        CType(BotonMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(BotonCerrar, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BotonCerrar As PictureBox
    Friend WithEvents BotonMaximizar As PictureBox
    Friend WithEvents BotonMinimizar As PictureBox
    Friend WithEvents BotonRestaurar As PictureBox
    Friend WithEvents BotonInicio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BotonSalir As Button
    Friend WithEvents lUser As Label
    Friend WithEvents PanelContenedor As Panel

End Class
