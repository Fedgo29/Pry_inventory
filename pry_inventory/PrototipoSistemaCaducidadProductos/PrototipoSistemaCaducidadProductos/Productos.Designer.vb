<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        PProducto = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Label16 = New Label()
        Panel5 = New Panel()
        Button1 = New Button()
        Panel6 = New Panel()
        Button2 = New Button()
        bBuscador = New Button()
        tbBuscador = New TextBox()
        dgvVisor = New DataGridView()
        GroupBoxProducto = New GroupBox()
        dtp_fechacaducidad = New DateTimePicker()
        bEliminar = New Button()
        tb_nombre = New TextBox()
        Label15 = New Label()
        bguardar = New Button()
        blimpiar = New Button()
        tb_stockmax = New TextBox()
        Label14 = New Label()
        tb_stockact = New TextBox()
        Label13 = New Label()
        tb_stockmin = New TextBox()
        Label12 = New Label()
        Label9 = New Label()
        tbPrecio_out = New TextBox()
        Label11 = New Label()
        tb_marca = New TextBox()
        Label4 = New Label()
        tb_precioin = New TextBox()
        Label5 = New Label()
        tb_proveedor = New TextBox()
        Label6 = New Label()
        tb_categoria = New TextBox()
        Label7 = New Label()
        tbCodigodebarras = New TextBox()
        Label3 = New Label()
        tb_um = New TextBox()
        Label2 = New Label()
        tbDescripcion = New TextBox()
        LabelCodigodeBarra = New Label()
        PProducto.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvVisor, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxProducto.SuspendLayout()
        SuspendLayout()
        ' 
        ' PProducto
        ' 
        PProducto.Controls.Add(Panel3)
        PProducto.Controls.Add(dgvVisor)
        PProducto.Controls.Add(GroupBoxProducto)
        PProducto.Dock = DockStyle.Fill
        PProducto.Location = New Point(0, 0)
        PProducto.Name = "PProducto"
        PProducto.Size = New Size(1366, 902)
        PProducto.TabIndex = 29
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(bBuscador)
        Panel3.Controls.Add(tbBuscador)
        Panel3.Location = New Point(476, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(878, 89)
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
        Panel4.Location = New Point(129, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(746, 53)
        Panel4.TabIndex = 28
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Dock = DockStyle.Right
        Label16.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(480, 0)
        Label16.Name = "Label16"
        Label16.RightToLeft = RightToLeft.Yes
        Label16.Size = New Size(266, 41)
        Label16.TabIndex = 3
        Label16.Text = "Visor de productos"
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
        ' dgvVisor
        ' 
        dgvVisor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVisor.ColumnHeadersHeight = 29
        dgvVisor.Location = New Point(476, 110)
        dgvVisor.Name = "dgvVisor"
        dgvVisor.ReadOnly = True
        dgvVisor.RowHeadersWidth = 51
        dgvVisor.Size = New Size(878, 780)
        dgvVisor.TabIndex = 29
        ' 
        ' GroupBoxProducto
        ' 
        GroupBoxProducto.Controls.Add(dtp_fechacaducidad)
        GroupBoxProducto.Controls.Add(bEliminar)
        GroupBoxProducto.Controls.Add(tb_nombre)
        GroupBoxProducto.Controls.Add(Label15)
        GroupBoxProducto.Controls.Add(bguardar)
        GroupBoxProducto.Controls.Add(blimpiar)
        GroupBoxProducto.Controls.Add(tb_stockmax)
        GroupBoxProducto.Controls.Add(Label14)
        GroupBoxProducto.Controls.Add(tb_stockact)
        GroupBoxProducto.Controls.Add(Label13)
        GroupBoxProducto.Controls.Add(tb_stockmin)
        GroupBoxProducto.Controls.Add(Label12)
        GroupBoxProducto.Controls.Add(Label9)
        GroupBoxProducto.Controls.Add(tbPrecio_out)
        GroupBoxProducto.Controls.Add(Label11)
        GroupBoxProducto.Controls.Add(tb_marca)
        GroupBoxProducto.Controls.Add(Label4)
        GroupBoxProducto.Controls.Add(tb_precioin)
        GroupBoxProducto.Controls.Add(Label5)
        GroupBoxProducto.Controls.Add(tb_proveedor)
        GroupBoxProducto.Controls.Add(Label6)
        GroupBoxProducto.Controls.Add(tb_categoria)
        GroupBoxProducto.Controls.Add(Label7)
        GroupBoxProducto.Controls.Add(tbCodigodebarras)
        GroupBoxProducto.Controls.Add(Label3)
        GroupBoxProducto.Controls.Add(tb_um)
        GroupBoxProducto.Controls.Add(Label2)
        GroupBoxProducto.Controls.Add(tbDescripcion)
        GroupBoxProducto.Controls.Add(LabelCodigodeBarra)
        GroupBoxProducto.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBoxProducto.ForeColor = Color.Black
        GroupBoxProducto.Location = New Point(43, 77)
        GroupBoxProducto.Name = "GroupBoxProducto"
        GroupBoxProducto.Size = New Size(408, 568)
        GroupBoxProducto.TabIndex = 28
        GroupBoxProducto.TabStop = False
        GroupBoxProducto.Text = "Producto"
        ' 
        ' dtp_fechacaducidad
        ' 
        dtp_fechacaducidad.Font = New Font("Microsoft Sans Serif", 12F)
        dtp_fechacaducidad.Format = DateTimePickerFormat.Short
        dtp_fechacaducidad.Location = New Point(187, 493)
        dtp_fechacaducidad.Name = "dtp_fechacaducidad"
        dtp_fechacaducidad.Size = New Size(205, 30)
        dtp_fechacaducidad.TabIndex = 31
        ' 
        ' bEliminar
        ' 
        bEliminar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bEliminar.Location = New Point(7, 529)
        bEliminar.Name = "bEliminar"
        bEliminar.Size = New Size(128, 29)
        bEliminar.TabIndex = 33
        bEliminar.Text = "Eliminar"
        bEliminar.UseVisualStyleBackColor = True
        ' 
        ' tb_nombre
        ' 
        tb_nombre.Location = New Point(187, 61)
        tb_nombre.Name = "tb_nombre"
        tb_nombre.Size = New Size(205, 30)
        tb_nombre.TabIndex = 32
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(108, 68)
        Label15.Name = "Label15"
        Label15.Size = New Size(84, 20)
        Label15.TabIndex = 31
        Label15.Text = "* Nombre:"
        ' 
        ' bguardar
        ' 
        bguardar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bguardar.Location = New Point(275, 529)
        bguardar.Name = "bguardar"
        bguardar.Size = New Size(128, 29)
        bguardar.TabIndex = 30
        bguardar.Text = "Guardar"
        bguardar.UseVisualStyleBackColor = True
        ' 
        ' blimpiar
        ' 
        blimpiar.Font = New Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        blimpiar.Location = New Point(141, 529)
        blimpiar.Name = "blimpiar"
        blimpiar.Size = New Size(128, 29)
        blimpiar.TabIndex = 26
        blimpiar.Text = "Limpiar"
        blimpiar.UseVisualStyleBackColor = True
        ' 
        ' tb_stockmax
        ' 
        tb_stockmax.Location = New Point(187, 385)
        tb_stockmax.Name = "tb_stockmax"
        tb_stockmax.Size = New Size(205, 30)
        tb_stockmax.TabIndex = 29
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(66, 392)
        Label14.Name = "Label14"
        Label14.Size = New Size(130, 20)
        Label14.TabIndex = 28
        Label14.Text = "* Stock máximo:"
        ' 
        ' tb_stockact
        ' 
        tb_stockact.Location = New Point(187, 349)
        tb_stockact.Name = "tb_stockact"
        tb_stockact.Size = New Size(205, 30)
        tb_stockact.TabIndex = 27
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(66, 356)
        Label13.Name = "Label13"
        Label13.Size = New Size(119, 20)
        Label13.TabIndex = 26
        Label13.Text = "* Stock Actual:"
        ' 
        ' tb_stockmin
        ' 
        tb_stockmin.Location = New Point(187, 313)
        tb_stockmin.Name = "tb_stockmin"
        tb_stockmin.Size = New Size(205, 30)
        tb_stockmin.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(66, 320)
        Label12.Name = "Label12"
        Label12.Size = New Size(126, 20)
        Label12.TabIndex = 24
        Label12.Text = "* Stock minimo:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(14, 500)
        Label9.Name = "Label9"
        Label9.Size = New Size(178, 20)
        Label9.TabIndex = 20
        Label9.Text = "* Fecha de Caducidad:"
        ' 
        ' tbPrecio_out
        ' 
        tbPrecio_out.Location = New Point(187, 457)
        tbPrecio_out.Name = "tbPrecio_out"
        tbPrecio_out.Size = New Size(205, 30)
        tbPrecio_out.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(48, 464)
        Label11.Name = "Label11"
        Label11.Size = New Size(133, 20)
        Label11.TabIndex = 16
        Label11.Text = "Precio de Venta:"
        ' 
        ' tb_marca
        ' 
        tb_marca.Location = New Point(187, 241)
        tb_marca.Name = "tb_marca"
        tb_marca.Size = New Size(205, 30)
        tb_marca.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(120, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 20)
        Label4.TabIndex = 14
        Label4.Text = "Marca:"
        ' 
        ' tb_precioin
        ' 
        tb_precioin.Location = New Point(187, 421)
        tb_precioin.Name = "tb_precioin"
        tb_precioin.Size = New Size(205, 30)
        tb_precioin.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(32, 428)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 20)
        Label5.TabIndex = 12
        Label5.Text = "Precio de Compra:"
        ' 
        ' tb_proveedor
        ' 
        tb_proveedor.Location = New Point(187, 277)
        tb_proveedor.Name = "tb_proveedor"
        tb_proveedor.Size = New Size(205, 30)
        tb_proveedor.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(91, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 20)
        Label6.TabIndex = 10
        Label6.Text = "* Proveedor:"
        ' 
        ' tb_categoria
        ' 
        tb_categoria.Location = New Point(187, 205)
        tb_categoria.Name = "tb_categoria"
        tb_categoria.Size = New Size(205, 30)
        tb_categoria.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(84, 212)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 8
        Label7.Text = "* Categoría:"
        ' 
        ' tbCodigodebarras
        ' 
        tbCodigodebarras.Location = New Point(187, 133)
        tbCodigodebarras.Name = "tbCodigodebarras"
        tbCodigodebarras.Size = New Size(205, 30)
        tbCodigodebarras.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(45, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 20)
        Label3.TabIndex = 6
        Label3.Text = "* Código de Barra:"
        ' 
        ' tb_um
        ' 
        tb_um.Location = New Point(187, 169)
        tb_um.Name = "tb_um"
        tb_um.Size = New Size(205, 30)
        tb_um.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(141, 176)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 4
        Label2.Text = "UM:"
        ' 
        ' tbDescripcion
        ' 
        tbDescripcion.Location = New Point(187, 97)
        tbDescripcion.Name = "tbDescripcion"
        tbDescripcion.Size = New Size(205, 30)
        tbDescripcion.TabIndex = 1
        ' 
        ' LabelCodigodeBarra
        ' 
        LabelCodigodeBarra.AutoSize = True
        LabelCodigodeBarra.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelCodigodeBarra.ForeColor = Color.Black
        LabelCodigodeBarra.Location = New Point(77, 104)
        LabelCodigodeBarra.Name = "LabelCodigodeBarra"
        LabelCodigodeBarra.Size = New Size(115, 20)
        LabelCodigodeBarra.TabIndex = 0
        LabelCodigodeBarra.Text = "* Descripción:"
        ' 
        ' Productos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1366, 902)
        Controls.Add(PProducto)
        FormBorderStyle = FormBorderStyle.None
        Name = "Productos"
        Text = "Productos"
        PProducto.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvVisor, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxProducto.ResumeLayout(False)
        GroupBoxProducto.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PProducto As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents bBuscador As Button
    Friend WithEvents tbBuscador As TextBox
    Friend WithEvents dgvVisor As DataGridView
    Friend WithEvents GroupBoxProducto As GroupBox
    Friend WithEvents bEliminar As Button
    Friend WithEvents tb_nombre As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents bguardar As Button
    Friend WithEvents blimpiar As Button
    Friend WithEvents tb_stockmax As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tb_stockact As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tb_stockmin As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tb_utilidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPrecio_out As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tb_marca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_precioin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tb_proveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_categoria As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCodigodebarras As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_um As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_material As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbDescripcion As TextBox
    Friend WithEvents LabelCodigodeBarra As Label
    Friend WithEvents dtp_fechacaducidad As DateTimePicker
End Class
