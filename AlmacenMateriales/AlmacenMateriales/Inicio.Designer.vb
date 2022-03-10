<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.menu_inicioMateriales = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_crear = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_modif = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_listar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.barra_iconos = New System.Windows.Forms.ToolStrip()
        Me.icon_crear = New System.Windows.Forms.ToolStripButton()
        Me.icon_modificar = New System.Windows.Forms.ToolStripButton()
        Me.icon_listar = New System.Windows.Forms.ToolStripButton()
        Me.icon_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.ayuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_listar = New System.Windows.Forms.Button()
        Me.img_icono = New System.Windows.Forms.PictureBox()
        Me.lblPantalla = New System.Windows.Forms.Label()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.btn_modif = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.menu_inicioMateriales.SuspendLayout()
        Me.barra_iconos.SuspendLayout()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu_inicioMateriales
        '
        Me.menu_inicioMateriales.BackColor = System.Drawing.Color.White
        Me.menu_inicioMateriales.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.menu_inicioMateriales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.menu_inicioMateriales.Location = New System.Drawing.Point(0, 0)
        Me.menu_inicioMateriales.Name = "menu_inicioMateriales"
        Me.menu_inicioMateriales.Size = New System.Drawing.Size(1382, 28)
        Me.menu_inicioMateriales.TabIndex = 0
        Me.menu_inicioMateriales.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_crear, Me.menu_modif, Me.menu_listar, Me.menu_eliminar})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        Me.OpcionesToolStripMenuItem.ToolTipText = "Menú de opciones"
        '
        'menu_crear
        '
        Me.menu_crear.Image = CType(resources.GetObject("menu_crear.Image"), System.Drawing.Image)
        Me.menu_crear.Name = "menu_crear"
        Me.menu_crear.Size = New System.Drawing.Size(215, 26)
        Me.menu_crear.Text = "&Crear Material"
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
        Me.menu_eliminar.Image = CType(resources.GetObject("menu_eliminar.Image"), System.Drawing.Image)
        Me.menu_eliminar.Name = "menu_eliminar"
        Me.menu_eliminar.Size = New System.Drawing.Size(215, 26)
        Me.menu_eliminar.Text = "&Eliminar Material"
        '
        'barra_iconos
        '
        Me.barra_iconos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.barra_iconos.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.barra_iconos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.icon_crear, Me.icon_modificar, Me.icon_listar, Me.icon_eliminar})
        Me.barra_iconos.Location = New System.Drawing.Point(0, 28)
        Me.barra_iconos.Name = "barra_iconos"
        Me.barra_iconos.Size = New System.Drawing.Size(1382, 32)
        Me.barra_iconos.TabIndex = 1
        Me.barra_iconos.Text = "ToolStrip1"
        '
        'icon_crear
        '
        Me.icon_crear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon_crear.Image = CType(resources.GetObject("icon_crear.Image"), System.Drawing.Image)
        Me.icon_crear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon_crear.Margin = New System.Windows.Forms.Padding(0, 1, 8, 2)
        Me.icon_crear.Name = "icon_crear"
        Me.icon_crear.Size = New System.Drawing.Size(29, 29)
        Me.icon_crear.Text = "Crear material"
        Me.icon_crear.ToolTipText = "Pulsar para crear material nuevo"
        '
        'icon_modificar
        '
        Me.icon_modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon_modificar.Image = CType(resources.GetObject("icon_modificar.Image"), System.Drawing.Image)
        Me.icon_modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon_modificar.Margin = New System.Windows.Forms.Padding(0, 1, 8, 2)
        Me.icon_modificar.Name = "icon_modificar"
        Me.icon_modificar.Size = New System.Drawing.Size(29, 29)
        Me.icon_modificar.Text = "Modificar material"
        Me.icon_modificar.ToolTipText = "Pulsar para modificar un material existente"
        '
        'icon_listar
        '
        Me.icon_listar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon_listar.Image = CType(resources.GetObject("icon_listar.Image"), System.Drawing.Image)
        Me.icon_listar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon_listar.Margin = New System.Windows.Forms.Padding(0, 1, 8, 2)
        Me.icon_listar.Name = "icon_listar"
        Me.icon_listar.Size = New System.Drawing.Size(29, 29)
        Me.icon_listar.Text = "Listar material"
        Me.icon_listar.ToolTipText = "Pulsar para listar los materiales"
        '
        'icon_eliminar
        '
        Me.icon_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon_eliminar.Image = CType(resources.GetObject("icon_eliminar.Image"), System.Drawing.Image)
        Me.icon_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon_eliminar.Margin = New System.Windows.Forms.Padding(0, 1, 8, 2)
        Me.icon_eliminar.Name = "icon_eliminar"
        Me.icon_eliminar.Size = New System.Drawing.Size(29, 29)
        Me.icon_eliminar.Text = "Eliminar material"
        Me.icon_eliminar.ToolTipText = "Pulsar para eliminar un material"
        '
        'ayuda
        '
        Me.ayuda.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'btn_listar
        '
        Me.btn_listar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_listar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_listar.Location = New System.Drawing.Point(556, 505)
        Me.btn_listar.Name = "btn_listar"
        Me.btn_listar.Size = New System.Drawing.Size(236, 64)
        Me.btn_listar.TabIndex = 3
        Me.btn_listar.Text = "Listar Materiales"
        Me.ayuda.SetToolTip(Me.btn_listar, "Pulsar para ")
        Me.btn_listar.UseVisualStyleBackColor = True
        '
        'img_icono
        '
        Me.img_icono.Image = CType(resources.GetObject("img_icono.Image"), System.Drawing.Image)
        Me.img_icono.Location = New System.Drawing.Point(52, 95)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(89, 89)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_icono.TabIndex = 2
        Me.img_icono.TabStop = False
        Me.ayuda.SetToolTip(Me.img_icono, "Logo de TecnoHuesca")
        '
        'lblPantalla
        '
        Me.lblPantalla.AutoSize = True
        Me.lblPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPantalla.Location = New System.Drawing.Point(187, 117)
        Me.lblPantalla.Name = "lblPantalla"
        Me.lblPantalla.Size = New System.Drawing.Size(86, 36)
        Me.lblPantalla.TabIndex = 0
        Me.lblPantalla.Text = "Inicio"
        '
        'btn_crear
        '
        Me.btn_crear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear.Location = New System.Drawing.Point(556, 226)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(236, 64)
        Me.btn_crear.TabIndex = 1
        Me.btn_crear.Text = "Crear Material"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'btn_modif
        '
        Me.btn_modif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modif.Location = New System.Drawing.Point(556, 364)
        Me.btn_modif.Name = "btn_modif"
        Me.btn_modif.Size = New System.Drawing.Size(236, 64)
        Me.btn_modif.TabIndex = 2
        Me.btn_modif.Text = "Modificar Material"
        Me.btn_modif.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Location = New System.Drawing.Point(556, 644)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(236, 64)
        Me.btn_eliminar.TabIndex = 4
        Me.btn_eliminar.Text = "Eliminar Material"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1382, 1033)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_listar)
        Me.Controls.Add(Me.btn_modif)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.lblPantalla)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.barra_iconos)
        Me.Controls.Add(Me.menu_inicioMateriales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_inicioMateriales
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén de Materiales"
        Me.menu_inicioMateriales.ResumeLayout(False)
        Me.menu_inicioMateriales.PerformLayout()
        Me.barra_iconos.ResumeLayout(False)
        Me.barra_iconos.PerformLayout()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_inicioMateriales As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_crear As ToolStripMenuItem
    Friend WithEvents menu_modif As ToolStripMenuItem
    Friend WithEvents menu_listar As ToolStripMenuItem
    Friend WithEvents menu_eliminar As ToolStripMenuItem
    Friend WithEvents barra_iconos As ToolStrip
    Friend WithEvents icon_crear As ToolStripButton
    Friend WithEvents ayuda As ToolTip
    Friend WithEvents icon_modificar As ToolStripButton
    Friend WithEvents icon_listar As ToolStripButton
    Friend WithEvents icon_eliminar As ToolStripButton
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents lblPantalla As Label
    Friend WithEvents btn_crear As Button
    Friend WithEvents btn_modif As Button
    Friend WithEvents btn_listar As Button
    Friend WithEvents btn_eliminar As Button
End Class
