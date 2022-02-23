<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class modificarMaterial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(modificarMaterial))
        Me.menu_modificar = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_crear = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_modif = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_listar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.barra_iconos = New System.Windows.Forms.ToolStrip()
        Me.icon_inicio = New System.Windows.Forms.ToolStripButton()
        Me.icon_guardar = New System.Windows.Forms.ToolStripButton()
        Me.ayuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.img_icono = New System.Windows.Forms.PictureBox()
        Me.txtmat_buscar = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.lblstock = New System.Windows.Forms.Label()
        Me.lblimp_ven = New System.Windows.Forms.Label()
        Me.lblsub_cat = New System.Windows.Forms.Label()
        Me.lblpas = New System.Windows.Forms.Label()
        Me.lbldesc = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.lblmat = New System.Windows.Forms.Label()
        Me.lblimp_com = New System.Windows.Forms.Label()
        Me.lblcat = New System.Windows.Forms.Label()
        Me.lblfe_reg = New System.Windows.Forms.Label()
        Me.lblnum_mat = New System.Windows.Forms.Label()
        Me.lblPantalla = New System.Windows.Forms.Label()
        Me.pnlbuscar = New System.Windows.Forms.Panel()
        Me.lblmat_buscar = New System.Windows.Forms.Label()
        Me.pnlCampos = New System.Windows.Forms.Panel()
        Me.lbleur2 = New System.Windows.Forms.Label()
        Me.lbleur = New System.Windows.Forms.Label()
        Me.pnlsec = New System.Windows.Forms.Panel()
        Me.rdbtF = New System.Windows.Forms.RadioButton()
        Me.rdbtD = New System.Windows.Forms.RadioButton()
        Me.rdbtB = New System.Windows.Forms.RadioButton()
        Me.rdbtE = New System.Windows.Forms.RadioButton()
        Me.rdbtC = New System.Windows.Forms.RadioButton()
        Me.rdbtA = New System.Windows.Forms.RadioButton()
        Me.cmbPasillo = New System.Windows.Forms.ComboBox()
        Me.fechafe_reg = New System.Windows.Forms.DateTimePicker()
        Me.cmbsub_cat = New System.Windows.Forms.ComboBox()
        Me.cmbcat = New System.Windows.Forms.ComboBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtimp_com = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtimp_ven = New System.Windows.Forms.TextBox()
        Me.txtnum_mat = New System.Windows.Forms.TextBox()
        Me.txtmat = New System.Windows.Forms.TextBox()
        Me.menu_modificar.SuspendLayout()
        Me.barra_iconos.SuspendLayout()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlbuscar.SuspendLayout()
        Me.pnlCampos.SuspendLayout()
        Me.pnlsec.SuspendLayout()
        Me.SuspendLayout()
        '
        'menu_modificar
        '
        Me.menu_modificar.BackColor = System.Drawing.Color.White
        Me.menu_modificar.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.menu_modificar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.menu_modificar.Location = New System.Drawing.Point(0, 0)
        Me.menu_modificar.Name = "menu_modificar"
        Me.menu_modificar.Size = New System.Drawing.Size(1067, 28)
        Me.menu_modificar.TabIndex = 1
        Me.menu_modificar.Text = "MenuStrip1"
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
        Me.menu_modif.Enabled = False
        Me.menu_modif.Image = CType(resources.GetObject("menu_modif.Image"), System.Drawing.Image)
        Me.menu_modif.Name = "menu_modif"
        Me.menu_modif.Size = New System.Drawing.Size(215, 26)
        Me.menu_modif.Text = "&Modificar Material"
        Me.menu_modif.ToolTipText = "Ventana actual"
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
        Me.barra_iconos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.icon_inicio, Me.icon_guardar})
        Me.barra_iconos.Location = New System.Drawing.Point(0, 28)
        Me.barra_iconos.Name = "barra_iconos"
        Me.barra_iconos.Size = New System.Drawing.Size(1067, 32)
        Me.barra_iconos.TabIndex = 2
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
        'icon_guardar
        '
        Me.icon_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.icon_guardar.Image = CType(resources.GetObject("icon_guardar.Image"), System.Drawing.Image)
        Me.icon_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.icon_guardar.Margin = New System.Windows.Forms.Padding(0, 1, 8, 2)
        Me.icon_guardar.Name = "icon_guardar"
        Me.icon_guardar.Size = New System.Drawing.Size(29, 29)
        Me.icon_guardar.Text = "Guardar cambios"
        Me.icon_guardar.ToolTipText = "Guardar cambios realizados"
        '
        'img_icono
        '
        Me.img_icono.Image = CType(resources.GetObject("img_icono.Image"), System.Drawing.Image)
        Me.img_icono.Location = New System.Drawing.Point(45, 88)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(89, 89)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_icono.TabIndex = 30
        Me.img_icono.TabStop = False
        Me.ayuda.SetToolTip(Me.img_icono, "Logo de TecnoHuesca")
        '
        'txtmat_buscar
        '
        Me.txtmat_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmat_buscar.Location = New System.Drawing.Point(201, 18)
        Me.txtmat_buscar.MaxLength = 8
        Me.txtmat_buscar.Name = "txtmat_buscar"
        Me.txtmat_buscar.Size = New System.Drawing.Size(109, 28)
        Me.txtmat_buscar.TabIndex = 1
        Me.ayuda.SetToolTip(Me.txtmat_buscar, "Número de material")
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(399, 18)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(109, 29)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.ayuda.SetToolTip(Me.btn_buscar, "Buscar material indicado")
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'lblstock
        '
        Me.lblstock.AutoSize = True
        Me.lblstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstock.Location = New System.Drawing.Point(201, 687)
        Me.lblstock.Name = "lblstock"
        Me.lblstock.Size = New System.Drawing.Size(61, 24)
        Me.lblstock.TabIndex = 24
        Me.lblstock.Text = "Stock:"
        '
        'lblimp_ven
        '
        Me.lblimp_ven.AutoSize = True
        Me.lblimp_ven.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimp_ven.Location = New System.Drawing.Point(201, 564)
        Me.lblimp_ven.Name = "lblimp_ven"
        Me.lblimp_ven.Size = New System.Drawing.Size(159, 24)
        Me.lblimp_ven.TabIndex = 25
        Me.lblimp_ven.Text = "Importe de Venta:"
        '
        'lblsub_cat
        '
        Me.lblsub_cat.AutoSize = True
        Me.lblsub_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsub_cat.Location = New System.Drawing.Point(201, 352)
        Me.lblsub_cat.Name = "lblsub_cat"
        Me.lblsub_cat.Size = New System.Drawing.Size(126, 24)
        Me.lblsub_cat.TabIndex = 22
        Me.lblsub_cat.Text = "Subcategoría:"
        '
        'lblpas
        '
        Me.lblpas.AutoSize = True
        Me.lblpas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpas.Location = New System.Drawing.Point(201, 603)
        Me.lblpas.Name = "lblpas"
        Me.lblpas.Size = New System.Drawing.Size(69, 24)
        Me.lblpas.TabIndex = 21
        Me.lblpas.Text = "Pasillo:"
        '
        'lbldesc
        '
        Me.lbldesc.AutoSize = True
        Me.lbldesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesc.Location = New System.Drawing.Point(201, 427)
        Me.lbldesc.Name = "lbldesc"
        Me.lbldesc.Size = New System.Drawing.Size(115, 24)
        Me.lbldesc.TabIndex = 20
        Me.lbldesc.Text = "Descripción:"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(201, 646)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(84, 24)
        Me.lblsec.TabIndex = 19
        Me.lblsec.Text = "Sección:"
        '
        'lblmat
        '
        Me.lblmat.AutoSize = True
        Me.lblmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmat.Location = New System.Drawing.Point(201, 276)
        Me.lblmat.Name = "lblmat"
        Me.lblmat.Size = New System.Drawing.Size(80, 24)
        Me.lblmat.TabIndex = 18
        Me.lblmat.Text = "Material:"
        '
        'lblimp_com
        '
        Me.lblimp_com.AutoSize = True
        Me.lblimp_com.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblimp_com.Location = New System.Drawing.Point(201, 528)
        Me.lblimp_com.Name = "lblimp_com"
        Me.lblimp_com.Size = New System.Drawing.Size(177, 24)
        Me.lblimp_com.TabIndex = 17
        Me.lblimp_com.Text = "Importe de Compra:"
        '
        'lblcat
        '
        Me.lblcat.AutoSize = True
        Me.lblcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.Location = New System.Drawing.Point(201, 314)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(95, 24)
        Me.lblcat.TabIndex = 16
        Me.lblcat.Text = "Categoría:"
        '
        'lblfe_reg
        '
        Me.lblfe_reg.AutoSize = True
        Me.lblfe_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfe_reg.Location = New System.Drawing.Point(201, 390)
        Me.lblfe_reg.Name = "lblfe_reg"
        Me.lblfe_reg.Size = New System.Drawing.Size(170, 24)
        Me.lblfe_reg.TabIndex = 15
        Me.lblfe_reg.Text = "Fecha de Registro:"
        '
        'lblnum_mat
        '
        Me.lblnum_mat.AutoSize = True
        Me.lblnum_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum_mat.Location = New System.Drawing.Point(201, 240)
        Me.lblnum_mat.Name = "lblnum_mat"
        Me.lblnum_mat.Size = New System.Drawing.Size(181, 24)
        Me.lblnum_mat.TabIndex = 14
        Me.lblnum_mat.Text = "Número de Material:"
        '
        'lblPantalla
        '
        Me.lblPantalla.AutoSize = True
        Me.lblPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPantalla.Location = New System.Drawing.Point(179, 88)
        Me.lblPantalla.Name = "lblPantalla"
        Me.lblPantalla.Size = New System.Drawing.Size(250, 36)
        Me.lblPantalla.TabIndex = 23
        Me.lblPantalla.Text = "Modificar Material"
        '
        'pnlbuscar
        '
        Me.pnlbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlbuscar.Controls.Add(Me.btn_buscar)
        Me.pnlbuscar.Controls.Add(Me.txtmat_buscar)
        Me.pnlbuscar.Controls.Add(Me.lblmat_buscar)
        Me.pnlbuscar.Location = New System.Drawing.Point(205, 146)
        Me.pnlbuscar.Name = "pnlbuscar"
        Me.pnlbuscar.Size = New System.Drawing.Size(552, 62)
        Me.pnlbuscar.TabIndex = 38
        '
        'lblmat_buscar
        '
        Me.lblmat_buscar.AutoSize = True
        Me.lblmat_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmat_buscar.Location = New System.Drawing.Point(14, 19)
        Me.lblmat_buscar.Name = "lblmat_buscar"
        Me.lblmat_buscar.Size = New System.Drawing.Size(181, 24)
        Me.lblmat_buscar.TabIndex = 15
        Me.lblmat_buscar.Text = "Número de Material:"
        '
        'pnlCampos
        '
        Me.pnlCampos.Controls.Add(Me.lbleur2)
        Me.pnlCampos.Controls.Add(Me.lbleur)
        Me.pnlCampos.Controls.Add(Me.pnlsec)
        Me.pnlCampos.Controls.Add(Me.cmbPasillo)
        Me.pnlCampos.Controls.Add(Me.fechafe_reg)
        Me.pnlCampos.Controls.Add(Me.cmbsub_cat)
        Me.pnlCampos.Controls.Add(Me.cmbcat)
        Me.pnlCampos.Controls.Add(Me.txtdesc)
        Me.pnlCampos.Controls.Add(Me.txtimp_com)
        Me.pnlCampos.Controls.Add(Me.txtstock)
        Me.pnlCampos.Controls.Add(Me.txtimp_ven)
        Me.pnlCampos.Controls.Add(Me.txtnum_mat)
        Me.pnlCampos.Controls.Add(Me.txtmat)
        Me.pnlCampos.Location = New System.Drawing.Point(414, 222)
        Me.pnlCampos.Name = "pnlCampos"
        Me.pnlCampos.Size = New System.Drawing.Size(412, 496)
        Me.pnlCampos.TabIndex = 39
        '
        'lbleur2
        '
        Me.lbleur2.AutoSize = True
        Me.lbleur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleur2.Location = New System.Drawing.Point(190, 338)
        Me.lbleur2.Name = "lbleur2"
        Me.lbleur2.Size = New System.Drawing.Size(20, 24)
        Me.lbleur2.TabIndex = 23
        Me.lbleur2.Text = "€"
        '
        'lbleur
        '
        Me.lbleur.AutoSize = True
        Me.lbleur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbleur.Location = New System.Drawing.Point(189, 301)
        Me.lbleur.Name = "lbleur"
        Me.lbleur.Size = New System.Drawing.Size(20, 24)
        Me.lbleur.TabIndex = 25
        Me.lbleur.Text = "€"
        '
        'pnlsec
        '
        Me.pnlsec.Controls.Add(Me.rdbtF)
        Me.pnlsec.Controls.Add(Me.rdbtD)
        Me.pnlsec.Controls.Add(Me.rdbtB)
        Me.pnlsec.Controls.Add(Me.rdbtE)
        Me.pnlsec.Controls.Add(Me.rdbtC)
        Me.pnlsec.Controls.Add(Me.rdbtA)
        Me.pnlsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlsec.Location = New System.Drawing.Point(66, 417)
        Me.pnlsec.Name = "pnlsec"
        Me.pnlsec.Size = New System.Drawing.Size(307, 32)
        Me.pnlsec.TabIndex = 24
        Me.ayuda.SetToolTip(Me.pnlsec, "Indicar sección donde se encuentra")
        '
        'rdbtF
        '
        Me.rdbtF.AutoSize = True
        Me.rdbtF.Location = New System.Drawing.Point(254, 2)
        Me.rdbtF.Name = "rdbtF"
        Me.rdbtF.Size = New System.Drawing.Size(43, 28)
        Me.rdbtF.TabIndex = 0
        Me.rdbtF.TabStop = True
        Me.rdbtF.Text = "F"
        Me.rdbtF.UseVisualStyleBackColor = True
        '
        'rdbtD
        '
        Me.rdbtD.AutoSize = True
        Me.rdbtD.Location = New System.Drawing.Point(154, 2)
        Me.rdbtD.Name = "rdbtD"
        Me.rdbtD.Size = New System.Drawing.Size(44, 28)
        Me.rdbtD.TabIndex = 0
        Me.rdbtD.TabStop = True
        Me.rdbtD.Text = "D"
        Me.rdbtD.UseVisualStyleBackColor = True
        '
        'rdbtB
        '
        Me.rdbtB.AutoSize = True
        Me.rdbtB.Location = New System.Drawing.Point(54, 1)
        Me.rdbtB.Name = "rdbtB"
        Me.rdbtB.Size = New System.Drawing.Size(43, 28)
        Me.rdbtB.TabIndex = 0
        Me.rdbtB.TabStop = True
        Me.rdbtB.Text = "B"
        Me.rdbtB.UseVisualStyleBackColor = True
        '
        'rdbtE
        '
        Me.rdbtE.AutoSize = True
        Me.rdbtE.Location = New System.Drawing.Point(204, 2)
        Me.rdbtE.Name = "rdbtE"
        Me.rdbtE.Size = New System.Drawing.Size(44, 28)
        Me.rdbtE.TabIndex = 0
        Me.rdbtE.TabStop = True
        Me.rdbtE.Text = "E"
        Me.rdbtE.UseVisualStyleBackColor = True
        '
        'rdbtC
        '
        Me.rdbtC.AutoSize = True
        Me.rdbtC.Location = New System.Drawing.Point(104, 1)
        Me.rdbtC.Name = "rdbtC"
        Me.rdbtC.Size = New System.Drawing.Size(44, 28)
        Me.rdbtC.TabIndex = 0
        Me.rdbtC.TabStop = True
        Me.rdbtC.Text = "C"
        Me.rdbtC.UseVisualStyleBackColor = True
        '
        'rdbtA
        '
        Me.rdbtA.AutoSize = True
        Me.rdbtA.Location = New System.Drawing.Point(4, 2)
        Me.rdbtA.Name = "rdbtA"
        Me.rdbtA.Size = New System.Drawing.Size(44, 28)
        Me.rdbtA.TabIndex = 0
        Me.rdbtA.TabStop = True
        Me.rdbtA.Text = "A"
        Me.rdbtA.UseVisualStyleBackColor = True
        '
        'cmbPasillo
        '
        Me.cmbPasillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasillo.FormattingEnabled = True
        Me.cmbPasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbPasillo.Location = New System.Drawing.Point(66, 378)
        Me.cmbPasillo.Name = "cmbPasillo"
        Me.cmbPasillo.Size = New System.Drawing.Size(83, 30)
        Me.cmbPasillo.TabIndex = 22
        Me.ayuda.SetToolTip(Me.cmbPasillo, "Indicar pasillo en que se encuentra")
        '
        'fechafe_reg
        '
        Me.fechafe_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechafe_reg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechafe_reg.Location = New System.Drawing.Point(66, 163)
        Me.fechafe_reg.Name = "fechafe_reg"
        Me.fechafe_reg.Size = New System.Drawing.Size(159, 28)
        Me.fechafe_reg.TabIndex = 18
        Me.ayuda.SetToolTip(Me.fechafe_reg, "Indica la fecha de registro")
        Me.fechafe_reg.Value = New Date(2022, 2, 16, 20, 1, 5, 0)
        '
        'cmbsub_cat
        '
        Me.cmbsub_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsub_cat.FormattingEnabled = True
        Me.cmbsub_cat.Location = New System.Drawing.Point(66, 127)
        Me.cmbsub_cat.MaxLength = 50
        Me.cmbsub_cat.Name = "cmbsub_cat"
        Me.cmbsub_cat.Size = New System.Drawing.Size(159, 30)
        Me.cmbsub_cat.TabIndex = 17
        Me.ayuda.SetToolTip(Me.cmbsub_cat, "Selecciona una subcategoría")
        '
        'cmbcat
        '
        Me.cmbcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.cmbcat.Location = New System.Drawing.Point(66, 89)
        Me.cmbcat.MaxLength = 50
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(159, 30)
        Me.cmbcat.TabIndex = 16
        Me.ayuda.SetToolTip(Me.cmbcat, "Selecciona una categoría")
        '
        'txtdesc
        '
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(66, 202)
        Me.txtdesc.MaxLength = 250
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdesc.Size = New System.Drawing.Size(253, 85)
        Me.txtdesc.TabIndex = 19
        Me.ayuda.SetToolTip(Me.txtdesc, "Introduce la descripción del producto")
        '
        'txtimp_com
        '
        Me.txtimp_com.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimp_com.Location = New System.Drawing.Point(66, 298)
        Me.txtimp_com.MaxLength = 11
        Me.txtimp_com.Name = "txtimp_com"
        Me.txtimp_com.Size = New System.Drawing.Size(126, 28)
        Me.txtimp_com.TabIndex = 20
        Me.txtimp_com.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ayuda.SetToolTip(Me.txtimp_com, "Introduce el importe de compra")
        '
        'txtstock
        '
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(66, 457)
        Me.txtstock.MaxLength = 8
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(110, 28)
        Me.txtstock.TabIndex = 26
        Me.ayuda.SetToolTip(Me.txtstock, "Introduce la cantidad de stock del material")
        '
        'txtimp_ven
        '
        Me.txtimp_ven.Enabled = False
        Me.txtimp_ven.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimp_ven.Location = New System.Drawing.Point(66, 334)
        Me.txtimp_ven.MaxLength = 11
        Me.txtimp_ven.Name = "txtimp_ven"
        Me.txtimp_ven.Size = New System.Drawing.Size(126, 28)
        Me.txtimp_ven.TabIndex = 21
        Me.txtimp_ven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ayuda.SetToolTip(Me.txtimp_ven, "Importe de venta del material")
        '
        'txtnum_mat
        '
        Me.txtnum_mat.Enabled = False
        Me.txtnum_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_mat.Location = New System.Drawing.Point(66, 9)
        Me.txtnum_mat.MaxLength = 8
        Me.txtnum_mat.Name = "txtnum_mat"
        Me.txtnum_mat.Size = New System.Drawing.Size(110, 28)
        Me.txtnum_mat.TabIndex = 14
        Me.ayuda.SetToolTip(Me.txtnum_mat, "Número de material")
        '
        'txtmat
        '
        Me.txtmat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmat.Location = New System.Drawing.Point(66, 52)
        Me.txtmat.MaxLength = 50
        Me.txtmat.Name = "txtmat"
        Me.txtmat.Size = New System.Drawing.Size(253, 28)
        Me.txtmat.TabIndex = 15
        Me.ayuda.SetToolTip(Me.txtmat, "Introduce el nombre del material")
        '
        'modificarMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1067, 743)
        Me.Controls.Add(Me.pnlCampos)
        Me.Controls.Add(Me.pnlbuscar)
        Me.Controls.Add(Me.lblstock)
        Me.Controls.Add(Me.lblimp_ven)
        Me.Controls.Add(Me.lblsub_cat)
        Me.Controls.Add(Me.lblpas)
        Me.Controls.Add(Me.lbldesc)
        Me.Controls.Add(Me.lblsec)
        Me.Controls.Add(Me.lblmat)
        Me.Controls.Add(Me.lblimp_com)
        Me.Controls.Add(Me.lblcat)
        Me.Controls.Add(Me.lblfe_reg)
        Me.Controls.Add(Me.lblnum_mat)
        Me.Controls.Add(Me.lblPantalla)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.barra_iconos)
        Me.Controls.Add(Me.menu_modificar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "modificarMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén de Materiales"
        Me.menu_modificar.ResumeLayout(False)
        Me.menu_modificar.PerformLayout()
        Me.barra_iconos.ResumeLayout(False)
        Me.barra_iconos.PerformLayout()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlbuscar.ResumeLayout(False)
        Me.pnlbuscar.PerformLayout()
        Me.pnlCampos.ResumeLayout(False)
        Me.pnlCampos.PerformLayout()
        Me.pnlsec.ResumeLayout(False)
        Me.pnlsec.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu_modificar As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_crear As ToolStripMenuItem
    Friend WithEvents menu_modif As ToolStripMenuItem
    Friend WithEvents menu_listar As ToolStripMenuItem
    Friend WithEvents menu_eliminar As ToolStripMenuItem
    Friend WithEvents barra_iconos As ToolStrip
    Friend WithEvents icon_inicio As ToolStripButton
    Friend WithEvents icon_guardar As ToolStripButton
    Friend WithEvents ayuda As ToolTip
    Friend WithEvents lblstock As Label
    Friend WithEvents lblimp_ven As Label
    Friend WithEvents lblsub_cat As Label
    Friend WithEvents lblpas As Label
    Friend WithEvents lbldesc As Label
    Friend WithEvents lblsec As Label
    Friend WithEvents lblmat As Label
    Friend WithEvents lblimp_com As Label
    Friend WithEvents lblcat As Label
    Friend WithEvents lblfe_reg As Label
    Friend WithEvents lblnum_mat As Label
    Friend WithEvents lblPantalla As Label
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents pnlbuscar As Panel
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txtmat_buscar As TextBox
    Friend WithEvents lblmat_buscar As Label
    Friend WithEvents menu_inicio As ToolStripMenuItem
    Friend WithEvents pnlCampos As Panel
    Friend WithEvents lbleur2 As Label
    Friend WithEvents lbleur As Label
    Friend WithEvents pnlsec As Panel
    Friend WithEvents rdbtF As RadioButton
    Friend WithEvents rdbtD As RadioButton
    Friend WithEvents rdbtB As RadioButton
    Friend WithEvents rdbtE As RadioButton
    Friend WithEvents rdbtC As RadioButton
    Friend WithEvents rdbtA As RadioButton
    Friend WithEvents cmbPasillo As ComboBox
    Friend WithEvents fechafe_reg As DateTimePicker
    Friend WithEvents cmbsub_cat As ComboBox
    Friend WithEvents cmbcat As ComboBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents txtimp_com As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtimp_ven As TextBox
    Friend WithEvents txtnum_mat As TextBox
    Friend WithEvents txtmat As TextBox
End Class
