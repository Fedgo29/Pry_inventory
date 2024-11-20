<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        PProveedor = New Panel()
        dgvVisor = New DataGridView()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label16 = New Label()
        Panel5 = New Panel()
        Button1 = New Button()
        Panel6 = New Panel()
        Button2 = New Button()
        bBuscador = New Button()
        tbBuscador = New TextBox()
        GroupBoxProveedor = New GroupBox()
        Label5 = New Label()
        dtp_ingreso = New DateTimePicker()
        cbadmin = New CheckBox()
        cbactivo = New CheckBox()
        tb_contraseniados = New TextBox()
        Label4 = New Label()
        tb_contraseniauna = New TextBox()
        Label2 = New Label()
        tb_correoelectronico = New TextBox()
        Label1 = New Label()
        bEliminar = New Button()
        tb_nombre = New TextBox()
        Label15 = New Label()
        bguardar = New Button()
        blimpiar = New Button()
        tb_nombreusuario = New TextBox()
        Label3 = New Label()
        tb_apellido = New TextBox()
        LabelCodigodeBarra = New Label()
        PProveedor.SuspendLayout()
        CType(dgvVisor, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        GroupBoxProveedor.SuspendLayout()
        SuspendLayout()
        ' 
        ' PProveedor
        ' 
        PProveedor.Controls.Add(dgvVisor)
        PProveedor.Controls.Add(Panel3)
        PProveedor.Controls.Add(GroupBoxProveedor)
        PProveedor.Dock = DockStyle.Fill
        PProveedor.Location = New Point(0, 0)
        PProveedor.Name = "PProveedor"
        PProveedor.Size = New Size(1349, 798)
        PProveedor.TabIndex = 32
        ' 
        ' dgvVisor
        ' 
        dgvVisor.ColumnHeadersHeight = 29
        dgvVisor.Location = New Point(479, 107)
        dgvVisor.Name = "dgvVisor"
        dgvVisor.ReadOnly = True
        dgvVisor.RowHeadersWidth = 51
        dgvVisor.Size = New Size(858, 615)
        dgvVisor.TabIndex = 31
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(bBuscador)
        Panel3.Controls.Add(tbBuscador)
        Panel3.Location = New Point(479, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(858, 89)
        Panel3.TabIndex = 30
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Button2)
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(278, 53)
        Panel4.TabIndex = 30
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Right
        Label16.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(31, 0)
        Label16.Name = "Label16"
        Label16.RightToLeft = RightToLeft.Yes
        Label16.Size = New Size(247, 41)
        Label16.TabIndex = 3
        Label16.Text = "Visor de usuarios"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DarkCyan
        Panel5.Location = New Point(0, 385)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(11, 54)
        Panel5.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 385)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 54)
        Button1.TabIndex = 2
        Button1.Text = "SALIR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.DarkCyan
        Panel6.Location = New Point(0, 114)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(11, 54)
        Panel6.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 114)
        Button2.Name = "Button2"
        Button2.Size = New Size(232, 54)
        Button2.TabIndex = 0
        Button2.Text = "INICIO"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' bBuscador
        ' 
        bBuscador.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bBuscador.Location = New Point(463, 55)
        bBuscador.Name = "bBuscador"
        bBuscador.Size = New Size(87, 31)
        bBuscador.TabIndex = 27
        bBuscador.Text = "Buscar"
        bBuscador.UseVisualStyleBackColor = True
        ' 
        ' tbBuscador
        ' 
        tbBuscador.Location = New Point(3, 59)
        tbBuscador.Name = "tbBuscador"
        tbBuscador.Size = New Size(448, 27)
        tbBuscador.TabIndex = 26
        ' 
        ' GroupBoxProveedor
        ' 
        GroupBoxProveedor.Controls.Add(Label5)
        GroupBoxProveedor.Controls.Add(dtp_ingreso)
        GroupBoxProveedor.Controls.Add(cbadmin)
        GroupBoxProveedor.Controls.Add(cbactivo)
        GroupBoxProveedor.Controls.Add(tb_contraseniados)
        GroupBoxProveedor.Controls.Add(Label4)
        GroupBoxProveedor.Controls.Add(tb_contraseniauna)
        GroupBoxProveedor.Controls.Add(Label2)
        GroupBoxProveedor.Controls.Add(tb_correoelectronico)
        GroupBoxProveedor.Controls.Add(Label1)
        GroupBoxProveedor.Controls.Add(bEliminar)
        GroupBoxProveedor.Controls.Add(tb_nombre)
        GroupBoxProveedor.Controls.Add(Label15)
        GroupBoxProveedor.Controls.Add(bguardar)
        GroupBoxProveedor.Controls.Add(blimpiar)
        GroupBoxProveedor.Controls.Add(tb_nombreusuario)
        GroupBoxProveedor.Controls.Add(Label3)
        GroupBoxProveedor.Controls.Add(tb_apellido)
        GroupBoxProveedor.Controls.Add(LabelCodigodeBarra)
        GroupBoxProveedor.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBoxProveedor.ForeColor = Color.Black
        GroupBoxProveedor.Location = New Point(43, 77)
        GroupBoxProveedor.Name = "GroupBoxProveedor"
        GroupBoxProveedor.Size = New Size(408, 429)
        GroupBoxProveedor.TabIndex = 28
        GroupBoxProveedor.TabStop = False
        GroupBoxProveedor.Text = "Usuario"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(24, 308)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 20)
        Label5.TabIndex = 42
        Label5.Text = "Fecha de ingreso: "
        ' 
        ' dtp_ingreso
        ' 
        dtp_ingreso.Format = DateTimePickerFormat.Short
        dtp_ingreso.Location = New Point(186, 303)
        dtp_ingreso.Name = "dtp_ingreso"
        dtp_ingreso.Size = New Size(205, 30)
        dtp_ingreso.TabIndex = 32
        ' 
        ' cbadmin
        ' 
        cbadmin.AutoSize = True
        cbadmin.Location = New Point(235, 347)
        cbadmin.Name = "cbadmin"
        cbadmin.Size = New Size(138, 29)
        cbadmin.TabIndex = 41
        cbadmin.Text = "¿Es admin?"
        cbadmin.UseVisualStyleBackColor = True
        ' 
        ' cbactivo
        ' 
        cbactivo.AutoSize = True
        cbactivo.Location = New Point(46, 347)
        cbactivo.Name = "cbactivo"
        cbactivo.Size = New Size(88, 29)
        cbactivo.TabIndex = 40
        cbactivo.Text = "Activo"
        cbactivo.UseVisualStyleBackColor = True
        ' 
        ' tb_contraseniados
        ' 
        tb_contraseniados.Location = New Point(186, 265)
        tb_contraseniados.Name = "tb_contraseniados"
        tb_contraseniados.Size = New Size(205, 30)
        tb_contraseniados.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(24, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 20)
        Label4.TabIndex = 38
        Label4.Text = "Repetir contraseña:"
        ' 
        ' tb_contraseniauna
        ' 
        tb_contraseniauna.Location = New Point(186, 229)
        tb_contraseniauna.Name = "tb_contraseniauna"
        tb_contraseniauna.Size = New Size(205, 30)
        tb_contraseniauna.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(80, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 36
        Label2.Text = "Contraseña:"
        ' 
        ' tb_correoelectronico
        ' 
        tb_correoelectronico.Location = New Point(186, 193)
        tb_correoelectronico.Name = "tb_correoelectronico"
        tb_correoelectronico.Size = New Size(205, 30)
        tb_correoelectronico.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(19, 200)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 20)
        Label1.TabIndex = 34
        Label1.Text = "Correo electrónico: "
        ' 
        ' bEliminar
        ' 
        bEliminar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bEliminar.Location = New Point(6, 382)
        bEliminar.Name = "bEliminar"
        bEliminar.Size = New Size(128, 29)
        bEliminar.TabIndex = 33
        bEliminar.Text = "Eliminar"
        bEliminar.UseVisualStyleBackColor = True
        ' 
        ' tb_nombre
        ' 
        tb_nombre.Location = New Point(186, 85)
        tb_nombre.Name = "tb_nombre"
        tb_nombre.Size = New Size(205, 30)
        tb_nombre.TabIndex = 32
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(107, 92)
        Label15.Name = "Label15"
        Label15.Size = New Size(73, 20)
        Label15.TabIndex = 31
        Label15.Text = "Nombre:"
        ' 
        ' bguardar
        ' 
        bguardar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bguardar.Location = New Point(274, 382)
        bguardar.Name = "bguardar"
        bguardar.Size = New Size(128, 29)
        bguardar.TabIndex = 30
        bguardar.Text = "Guardar"
        bguardar.UseVisualStyleBackColor = True
        ' 
        ' blimpiar
        ' 
        blimpiar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        blimpiar.Location = New Point(140, 382)
        blimpiar.Name = "blimpiar"
        blimpiar.Size = New Size(128, 29)
        blimpiar.TabIndex = 26
        blimpiar.Text = "Limpiar"
        blimpiar.UseVisualStyleBackColor = True
        ' 
        ' tb_nombreusuario
        ' 
        tb_nombreusuario.Location = New Point(186, 157)
        tb_nombreusuario.Name = "tb_nombreusuario"
        tb_nombreusuario.Size = New Size(205, 30)
        tb_nombreusuario.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(19, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 20)
        Label3.TabIndex = 6
        Label3.Text = "Nombre de usuario: "
        ' 
        ' tb_apellido
        ' 
        tb_apellido.Location = New Point(186, 121)
        tb_apellido.Name = "tb_apellido"
        tb_apellido.Size = New Size(205, 30)
        tb_apellido.TabIndex = 1
        ' 
        ' LabelCodigodeBarra
        ' 
        LabelCodigodeBarra.AutoSize = True
        LabelCodigodeBarra.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelCodigodeBarra.ForeColor = Color.Black
        LabelCodigodeBarra.Location = New Point(107, 128)
        LabelCodigodeBarra.Name = "LabelCodigodeBarra"
        LabelCodigodeBarra.Size = New Size(73, 20)
        LabelCodigodeBarra.TabIndex = 0
        LabelCodigodeBarra.Text = "Apellido:"
        ' 
        ' Usuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1349, 798)
        Controls.Add(PProveedor)
        FormBorderStyle = FormBorderStyle.None
        Name = "Usuario"
        Text = "Usuario"
        PProveedor.ResumeLayout(False)
        CType(dgvVisor, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        GroupBoxProveedor.ResumeLayout(False)
        GroupBoxProveedor.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PProveedor As Panel
    Friend WithEvents dgvVisor As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents bBuscador As Button
    Friend WithEvents tbBuscador As TextBox
    Friend WithEvents GroupBoxProveedor As GroupBox
    Friend WithEvents tb_correoelectronico As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bEliminar As Button
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents bguardar As Button
    Friend WithEvents blimpiar As Button
    Friend WithEvents tb_nombreusuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_apellido As TextBox
    Friend WithEvents LabelCodigodeBarra As Label
    Friend WithEvents cbadmin As CheckBox
    Friend WithEvents cbactivo As CheckBox
    Friend WithEvents tb_contraseniados As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_contraseniauna As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_ingreso As DateTimePicker
End Class
