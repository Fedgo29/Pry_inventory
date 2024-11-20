<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        PanelMenu = New Panel()
        bProducto = New Button()
        Button3 = New Button()
        bUsuario = New Button()
        Button4 = New Button()
        PanelMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.AutoSize = True
        PanelMenu.BackColor = Color.White
        PanelMenu.Controls.Add(bProducto)
        PanelMenu.Controls.Add(Button3)
        PanelMenu.Controls.Add(bUsuario)
        PanelMenu.Controls.Add(Button4)
        PanelMenu.Dock = DockStyle.Fill
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(1018, 668)
        PanelMenu.TabIndex = 2
        ' 
        ' bProducto
        ' 
        bProducto.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        bProducto.FlatAppearance.BorderSize = 0
        bProducto.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        bProducto.FlatStyle = FlatStyle.Flat
        bProducto.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bProducto.ForeColor = Color.White
        bProducto.Image = CType(resources.GetObject("bProducto.Image"), Image)
        bProducto.Location = New Point(30, 370)
        bProducto.Name = "bProducto"
        bProducto.Size = New Size(232, 285)
        bProducto.TabIndex = 12
        bProducto.Text = "PRODUCTO"
        bProducto.TextAlign = ContentAlignment.BottomCenter
        bProducto.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(268, 79)
        Button3.Name = "Button3"
        Button3.Size = New Size(232, 285)
        Button3.TabIndex = 11
        Button3.Text = "CATEGORIA"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = False
        ' 
        ' bUsuario
        ' 
        bUsuario.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        bUsuario.FlatAppearance.BorderSize = 0
        bUsuario.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        bUsuario.FlatStyle = FlatStyle.Flat
        bUsuario.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bUsuario.ForeColor = Color.White
        bUsuario.Image = CType(resources.GetObject("bUsuario.Image"), Image)
        bUsuario.Location = New Point(268, 370)
        bUsuario.Name = "bUsuario"
        bUsuario.Size = New Size(232, 285)
        bUsuario.TabIndex = 10
        bUsuario.Text = "USUARIO"
        bUsuario.TextAlign = ContentAlignment.BottomCenter
        bUsuario.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseOverBackColor = Color.DarkCyan
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.Location = New Point(30, 79)
        Button4.Name = "Button4"
        Button4.Size = New Size(232, 285)
        Button4.TabIndex = 9
        Button4.Text = "PROVEEDORES"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 668)
        Controls.Add(PanelMenu)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inicio"
        Text = "Inicio"
        PanelMenu.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents bProducto As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents bUsuario As Button
    Friend WithEvents Button4 As Button
End Class
