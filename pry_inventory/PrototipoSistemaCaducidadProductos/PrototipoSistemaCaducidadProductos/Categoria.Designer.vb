<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria
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
        dtpFecha_Creacion = New DateTimePicker()
        bEliminar = New Button()
        tb_nombre = New TextBox()
        Label15 = New Label()
        bguardar = New Button()
        blimpiar = New Button()
        Label3 = New Label()
        tbDescripcion = New TextBox()
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
        PProveedor.Size = New Size(1346, 738)
        PProveedor.TabIndex = 31
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
        Panel4.Size = New Size(303, 53)
        Panel4.TabIndex = 30
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Right
        Label16.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(29, 0)
        Label16.Name = "Label16"
        Label16.RightToLeft = RightToLeft.Yes
        Label16.Size = New Size(274, 41)
        Label16.TabIndex = 3
        Label16.Text = "Visor de categorias"
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
        GroupBoxProveedor.Controls.Add(dtpFecha_Creacion)
        GroupBoxProveedor.Controls.Add(bEliminar)
        GroupBoxProveedor.Controls.Add(tb_nombre)
        GroupBoxProveedor.Controls.Add(Label15)
        GroupBoxProveedor.Controls.Add(bguardar)
        GroupBoxProveedor.Controls.Add(blimpiar)
        GroupBoxProveedor.Controls.Add(Label3)
        GroupBoxProveedor.Controls.Add(tbDescripcion)
        GroupBoxProveedor.Controls.Add(LabelCodigodeBarra)
        GroupBoxProveedor.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBoxProveedor.ForeColor = Color.Black
        GroupBoxProveedor.Location = New Point(43, 77)
        GroupBoxProveedor.Name = "GroupBoxProveedor"
        GroupBoxProveedor.Size = New Size(408, 262)
        GroupBoxProveedor.TabIndex = 28
        GroupBoxProveedor.TabStop = False
        GroupBoxProveedor.Text = "Categoria"
        ' 
        ' dtpFecha_Creacion
        ' 
        dtpFecha_Creacion.Font = New Font("Microsoft Sans Serif", 12F)
        dtpFecha_Creacion.Format = DateTimePickerFormat.Short
        dtpFecha_Creacion.Location = New Point(186, 157)
        dtpFecha_Creacion.Name = "dtpFecha_Creacion"
        dtpFecha_Creacion.Size = New Size(205, 30)
        dtpFecha_Creacion.TabIndex = 32
        ' 
        ' bEliminar
        ' 
        bEliminar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bEliminar.Location = New Point(6, 220)
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
        Label15.Size = New Size(84, 20)
        Label15.TabIndex = 31
        Label15.Text = "* Nombre:"
        ' 
        ' bguardar
        ' 
        bguardar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bguardar.Location = New Point(274, 220)
        bguardar.Name = "bguardar"
        bguardar.Size = New Size(128, 29)
        bguardar.TabIndex = 30
        bguardar.Text = "Guardar"
        bguardar.UseVisualStyleBackColor = True
        ' 
        ' blimpiar
        ' 
        blimpiar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        blimpiar.Location = New Point(140, 220)
        blimpiar.Name = "blimpiar"
        blimpiar.Size = New Size(128, 29)
        blimpiar.TabIndex = 26
        blimpiar.Text = "Limpiar"
        blimpiar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(28, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 20)
        Label3.TabIndex = 6
        Label3.Text = "Fecha de creación:"
        ' 
        ' tbDescripcion
        ' 
        tbDescripcion.Location = New Point(186, 121)
        tbDescripcion.Name = "tbDescripcion"
        tbDescripcion.Size = New Size(205, 30)
        tbDescripcion.TabIndex = 1
        ' 
        ' LabelCodigodeBarra
        ' 
        LabelCodigodeBarra.AutoSize = True
        LabelCodigodeBarra.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelCodigodeBarra.ForeColor = Color.Black
        LabelCodigodeBarra.Location = New Point(76, 128)
        LabelCodigodeBarra.Name = "LabelCodigodeBarra"
        LabelCodigodeBarra.Size = New Size(115, 20)
        LabelCodigodeBarra.TabIndex = 0
        LabelCodigodeBarra.Text = "* Descripción:"
        ' 
        ' Categoria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1346, 738)
        Controls.Add(PProveedor)
        FormBorderStyle = FormBorderStyle.None
        Name = "Categoria"
        Text = "Categoria"
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
    Friend WithEvents bBuscador As Button
    Friend WithEvents tbBuscador As TextBox
    Friend WithEvents GroupBoxProveedor As GroupBox
    Friend WithEvents bEliminar As Button
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents bguardar As Button
    Friend WithEvents blimpiar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents LabelCodigodeBarra As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents dtpFecha_Creacion As DateTimePicker
End Class
