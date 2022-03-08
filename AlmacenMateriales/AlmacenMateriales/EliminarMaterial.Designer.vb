<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminarMaterial
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eliminarMaterial))
        Me.ayuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.img_icono = New System.Windows.Forms.PictureBox()
        Me.txtnum_mat = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.barra_iconos = New System.Windows.Forms.ToolStrip()
        Me.icon_inicio = New System.Windows.Forms.ToolStripButton()
        Me.menu_eliminarMaterial = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_crear = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_modif = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_listar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPantalla = New System.Windows.Forms.Label()
        Me.lblnum_mat = New System.Windows.Forms.Label()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barra_iconos.SuspendLayout()
        Me.menu_eliminarMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'img_icono
        '
        Me.img_icono.Image = CType(resources.GetObject("img_icono.Image"), System.Drawing.Image)
        Me.img_icono.Location = New System.Drawing.Point(49, 89)
        Me.img_icono.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(89, 89)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_icono.TabIndex = 32
        Me.img_icono.TabStop = False
        Me.ayuda.SetToolTip(Me.img_icono, "Logo de TecnoHuesca")
        '
        'txtnum_mat
        '
        Me.txtnum_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_mat.Location = New System.Drawing.Point(545, 175)
        Me.txtnum_mat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnum_mat.MaxLength = 8
        Me.txtnum_mat.Name = "txtnum_mat"
        Me.txtnum_mat.Size = New System.Drawing.Size(111, 28)
        Me.txtnum_mat.TabIndex = 34
        Me.ayuda.SetToolTip(Me.txtnum_mat, "Número de material")
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(459, 246)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(109, 30)
        Me.btn_eliminar.TabIndex = 35
        Me.btn_eliminar.Text = "Eliminar"
        Me.ayuda.SetToolTip(Me.btn_eliminar, "Eliminar el material indicado")
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'barra_iconos
        '
        Me.barra_iconos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.barra_iconos.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.barra_iconos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.icon_inicio})
        Me.barra_iconos.Location = New System.Drawing.Point(0, 28)
        Me.barra_iconos.Name = "barra_iconos"
        Me.barra_iconos.Size = New System.Drawing.Size(1067, 32)
        Me.barra_iconos.TabIndex = 4
        Me.barra_iconos.Text = "ToolStrip1"
        '
        'icon_inicio
        '
        Me.icon_inicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon_inicio.Image = CType(resources.GetObject("icon_inicio.Image"), System.Drawing.Image)
        Me.icon_inicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon_inicio.Margin = New System.Windows.Forms.Padding(0, 1, 8, 2)
        Me.icon_inicio.Name = "icon_inicio"
        Me.icon_inicio.Size = New System.Drawing.Size(29, 29)
        Me.icon_inicio.Text = "Inicio"
        Me.icon_inicio.ToolTipText = "Pulsar para volver a inicio"
        '
        'menu_eliminarMaterial
        '
        Me.menu_eliminarMaterial.BackColor = System.Drawing.Color.White
        Me.menu_eliminarMaterial.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.menu_eliminarMaterial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.menu_eliminarMaterial.Location = New System.Drawing.Point(0, 0)
        Me.menu_eliminarMaterial.Name = "menu_eliminarMaterial"
        Me.menu_eliminarMaterial.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menu_eliminarMaterial.Size = New System.Drawing.Size(1067, 28)
        Me.menu_eliminarMaterial.TabIndex = 3
        Me.menu_eliminarMaterial.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_inicio, Me.menu_crear, Me.menu_modif, Me.menu_listar, Me.menu_eliminar})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        Me.OpcionesToolStripMenuItem.ToolTipText = "Menú de opciones"
        '
        'menu_inicio
        '
        Me.menu_inicio.Image = CType(resources.GetObject("menu_inicio.Image"), System.Drawing.Image)
        Me.menu_inicio.Name = "menu_inicio"
        Me.menu_inicio.Size = New System.Drawing.Size(215, 26)
        Me.menu_inicio.Text = "&Inicio"
        '
        'menu_crear
        '
        Me.menu_crear.Image = CType(resources.GetObject("menu_crear.Image"), System.Drawing.Image)
        Me.menu_crear.Name = "menu_crear"
        Me.menu_crear.Size = New System.Drawing.Size(215, 26)
        Me.menu_crear.Text = "&Crear material"
        '
        'menu_modif
        '
        Me.menu_modif.Image = CType(resources.GetObject("menu_modif.Image"), System.Drawing.Image)
        Me.menu_modif.Name = "menu_modif"
        Me.menu_modif.Size = New System.Drawing.Size(215, 26)
        Me.menu_modif.Text = "&Modificar Material"
        '
        'menu_listar
        '
        Me.menu_listar.Image = CType(resources.GetObject("menu_listar.Image"), System.Drawing.Image)
        Me.menu_listar.Name = "menu_listar"
        Me.menu_listar.Size = New System.Drawing.Size(215, 26)
        Me.menu_listar.Text = "&Listar Materiales"
        '
        'menu_eliminar
        '
        Me.menu_eliminar.Enabled = False
        Me.menu_eliminar.Image = CType(resources.GetObject("menu_eliminar.Image"), System.Drawing.Image)
        Me.menu_eliminar.Name = "menu_eliminar"
        Me.menu_eliminar.Size = New System.Drawing.Size(215, 26)
        Me.menu_eliminar.Text = "&Eliminar Material"
        Me.menu_eliminar.ToolTipText = "Ventana actual"
        '
        'lblPantalla
        '
        Me.lblPantalla.AutoSize = True
        Me.lblPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPantalla.Location = New System.Drawing.Point(183, 89)
        Me.lblPantalla.Name = "lblPantalla"
        Me.lblPantalla.Size = New System.Drawing.Size(235, 36)
        Me.lblPantalla.TabIndex = 31
        Me.lblPantalla.Text = "Eliminar Material"
        '
        'lblnum_mat
        '
        Me.lblnum_mat.AutoSize = True
        Me.lblnum_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum_mat.Location = New System.Drawing.Point(305, 178)
        Me.lblnum_mat.Name = "lblnum_mat"
        Me.lblnum_mat.Size = New System.Drawing.Size(181, 24)
        Me.lblnum_mat.TabIndex = 33
        Me.lblnum_mat.Text = "Número de Material:"
        '
        'eliminarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1067, 743)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.txtnum_mat)
        Me.Controls.Add(Me.lblnum_mat)
        Me.Controls.Add(Me.lblPantalla)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.barra_iconos)
        Me.Controls.Add(Me.menu_eliminarMaterial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "eliminarMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén de Materiales"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barra_iconos.ResumeLayout(False)
        Me.barra_iconos.PerformLayout()
        Me.menu_eliminarMaterial.ResumeLayout(False)
        Me.menu_eliminarMaterial.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ayuda As ToolTip
    Friend WithEvents barra_iconos As ToolStrip
    Friend WithEvents icon_inicio As ToolStripButton
    Friend WithEvents menu_eliminarMaterial As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_crear As ToolStripMenuItem
    Friend WithEvents menu_modif As ToolStripMenuItem
    Friend WithEvents menu_listar As ToolStripMenuItem
    Friend WithEvents menu_eliminar As ToolStripMenuItem
    Friend WithEvents lblPantalla As Label
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents txtnum_mat As TextBox
    Friend WithEvents lblnum_mat As Label
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents menu_inicio As ToolStripMenuItem
End Class
