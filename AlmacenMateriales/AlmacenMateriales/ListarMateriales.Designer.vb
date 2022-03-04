<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarMateriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarMateriales))
        Me.ayuda = New System.Windows.Forms.ToolTip(Me.components)
        Me.img_icono = New System.Windows.Forms.PictureBox()
        Me.pnlsec = New System.Windows.Forms.Panel()
        Me.rdbtF = New System.Windows.Forms.RadioButton()
        Me.rdbtD = New System.Windows.Forms.RadioButton()
        Me.rdbtB = New System.Windows.Forms.RadioButton()
        Me.rdbtE = New System.Windows.Forms.RadioButton()
        Me.rdbtC = New System.Windows.Forms.RadioButton()
        Me.rdbtA = New System.Windows.Forms.RadioButton()
        Me.btnlistar = New System.Windows.Forms.Button()
        Me.cmbPasillo = New System.Windows.Forms.ComboBox()
        Me.fechafe_reg = New System.Windows.Forms.DateTimePicker()
        Me.cmbsub_cat = New System.Windows.Forms.ComboBox()
        Me.cmbcat = New System.Windows.Forms.ComboBox()
        Me.txtnum_mat = New System.Windows.Forms.TextBox()
        Me.menu_listarMaterial = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_inicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_crear = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_modif = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_listar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_eliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.barra_iconos = New System.Windows.Forms.ToolStrip()
        Me.icon_inicio = New System.Windows.Forms.ToolStripButton()
        Me.lblsub_cat = New System.Windows.Forms.Label()
        Me.lblcat = New System.Windows.Forms.Label()
        Me.lblfe_reg = New System.Windows.Forms.Label()
        Me.lblnum_mat = New System.Windows.Forms.Label()
        Me.lblPantalla = New System.Windows.Forms.Label()
        Me.lblpas = New System.Windows.Forms.Label()
        Me.lblsec = New System.Windows.Forms.Label()
        Me.rejillaMateriales = New System.Windows.Forms.DataGridView()
        Me.num_mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subcat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fe_reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imp_com = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.imp_ven = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenMaterialesDBDataSet = New AlmacenMateriales.AlmacenMaterialesDBDataSet()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlsec.SuspendLayout()
        Me.menu_listarMaterial.SuspendLayout()
        Me.barra_iconos.SuspendLayout()
        CType(Me.rejillaMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenMaterialesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'img_icono
        '
        Me.img_icono.Image = CType(resources.GetObject("img_icono.Image"), System.Drawing.Image)
        Me.img_icono.Location = New System.Drawing.Point(34, 75)
        Me.img_icono.Margin = New System.Windows.Forms.Padding(2)
        Me.img_icono.Name = "img_icono"
        Me.img_icono.Size = New System.Drawing.Size(67, 72)
        Me.img_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_icono.TabIndex = 16
        Me.img_icono.TabStop = False
        Me.ayuda.SetToolTip(Me.img_icono, "Logo de TecnoHuesca")
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
        Me.pnlsec.Location = New System.Drawing.Point(383, 283)
        Me.pnlsec.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlsec.Name = "pnlsec"
        Me.pnlsec.Size = New System.Drawing.Size(230, 26)
        Me.pnlsec.TabIndex = 7
        Me.ayuda.SetToolTip(Me.pnlsec, "Indicar sección donde se encuentra")
        '
        'rdbtF
        '
        Me.rdbtF.AutoSize = True
        Me.rdbtF.Location = New System.Drawing.Point(190, 2)
        Me.rdbtF.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtF.Name = "rdbtF"
        Me.rdbtF.Size = New System.Drawing.Size(35, 22)
        Me.rdbtF.TabIndex = 0
        Me.rdbtF.TabStop = True
        Me.rdbtF.Text = "F"
        Me.rdbtF.UseVisualStyleBackColor = True
        '
        'rdbtD
        '
        Me.rdbtD.AutoSize = True
        Me.rdbtD.Location = New System.Drawing.Point(116, 2)
        Me.rdbtD.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtD.Name = "rdbtD"
        Me.rdbtD.Size = New System.Drawing.Size(37, 22)
        Me.rdbtD.TabIndex = 0
        Me.rdbtD.Text = "D"
        Me.rdbtD.UseVisualStyleBackColor = True
        '
        'rdbtB
        '
        Me.rdbtB.AutoSize = True
        Me.rdbtB.Location = New System.Drawing.Point(40, 1)
        Me.rdbtB.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtB.Name = "rdbtB"
        Me.rdbtB.Size = New System.Drawing.Size(36, 22)
        Me.rdbtB.TabIndex = 0
        Me.rdbtB.TabStop = True
        Me.rdbtB.Text = "B"
        Me.rdbtB.UseVisualStyleBackColor = True
        '
        'rdbtE
        '
        Me.rdbtE.AutoSize = True
        Me.rdbtE.Location = New System.Drawing.Point(153, 2)
        Me.rdbtE.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtE.Name = "rdbtE"
        Me.rdbtE.Size = New System.Drawing.Size(36, 22)
        Me.rdbtE.TabIndex = 0
        Me.rdbtE.TabStop = True
        Me.rdbtE.Text = "E"
        Me.rdbtE.UseVisualStyleBackColor = True
        '
        'rdbtC
        '
        Me.rdbtC.AutoSize = True
        Me.rdbtC.Location = New System.Drawing.Point(78, 2)
        Me.rdbtC.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtC.Name = "rdbtC"
        Me.rdbtC.Size = New System.Drawing.Size(37, 22)
        Me.rdbtC.TabIndex = 0
        Me.rdbtC.TabStop = True
        Me.rdbtC.Text = "C"
        Me.rdbtC.UseVisualStyleBackColor = True
        '
        'rdbtA
        '
        Me.rdbtA.AutoSize = True
        Me.rdbtA.Checked = True
        Me.rdbtA.Location = New System.Drawing.Point(3, 1)
        Me.rdbtA.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbtA.Name = "rdbtA"
        Me.rdbtA.Size = New System.Drawing.Size(35, 22)
        Me.rdbtA.TabIndex = 0
        Me.rdbtA.TabStop = True
        Me.rdbtA.Text = "A"
        Me.rdbtA.UseVisualStyleBackColor = True
        '
        'btnlistar
        '
        Me.btnlistar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlistar.Location = New System.Drawing.Point(664, 124)
        Me.btnlistar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlistar.Name = "btnlistar"
        Me.btnlistar.Size = New System.Drawing.Size(89, 30)
        Me.btnlistar.TabIndex = 8
        Me.btnlistar.Text = "Listar"
        Me.ayuda.SetToolTip(Me.btnlistar, "Listar según los filtros indicados")
        Me.btnlistar.UseVisualStyleBackColor = True
        '
        'cmbPasillo
        '
        Me.cmbPasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPasillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPasillo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPasillo.FormattingEnabled = True
        Me.cmbPasillo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbPasillo.Location = New System.Drawing.Point(16, 124)
        Me.cmbPasillo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPasillo.Name = "cmbPasillo"
        Me.cmbPasillo.Size = New System.Drawing.Size(63, 25)
        Me.cmbPasillo.TabIndex = 12
        Me.ayuda.SetToolTip(Me.cmbPasillo, "Indicar pasillo en que se encuentra")
        '
        'fechafe_reg
        '
        Me.fechafe_reg.Checked = False
        Me.fechafe_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechafe_reg.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fechafe_reg.Location = New System.Drawing.Point(16, 94)
        Me.fechafe_reg.Margin = New System.Windows.Forms.Padding(2)
        Me.fechafe_reg.Name = "fechafe_reg"
        Me.fechafe_reg.ShowCheckBox = True
        Me.fechafe_reg.Size = New System.Drawing.Size(120, 24)
        Me.fechafe_reg.TabIndex = 11
        Me.ayuda.SetToolTip(Me.fechafe_reg, "Indica la fecha de registro")
        Me.fechafe_reg.Value = New Date(2022, 2, 16, 0, 0, 0, 0)
        '
        'cmbsub_cat
        '
        Me.cmbsub_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsub_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbsub_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsub_cat.FormattingEnabled = True
        Me.cmbsub_cat.Items.AddRange(New Object() {"Equipo", "Periféricos", "Antivirus", "Servicio"})
        Me.cmbsub_cat.Location = New System.Drawing.Point(16, 65)
        Me.cmbsub_cat.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbsub_cat.MaxLength = 50
        Me.cmbsub_cat.Name = "cmbsub_cat"
        Me.cmbsub_cat.Size = New System.Drawing.Size(120, 25)
        Me.cmbsub_cat.TabIndex = 10
        Me.ayuda.SetToolTip(Me.cmbsub_cat, "Selecciona una subcategoría")
        '
        'cmbcat
        '
        Me.cmbcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcat.FormattingEnabled = True
        Me.cmbcat.Items.AddRange(New Object() {"Hardware", "Software"})
        Me.cmbcat.Location = New System.Drawing.Point(16, 34)
        Me.cmbcat.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbcat.MaxLength = 50
        Me.cmbcat.Name = "cmbcat"
        Me.cmbcat.Size = New System.Drawing.Size(120, 25)
        Me.cmbcat.TabIndex = 9
        Me.ayuda.SetToolTip(Me.cmbcat, "Selecciona una categoría")
        '
        'txtnum_mat
        '
        Me.txtnum_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum_mat.Location = New System.Drawing.Point(16, 2)
        Me.txtnum_mat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnum_mat.MaxLength = 8
        Me.txtnum_mat.Name = "txtnum_mat"
        Me.txtnum_mat.Size = New System.Drawing.Size(84, 24)
        Me.txtnum_mat.TabIndex = 7
        Me.ayuda.SetToolTip(Me.txtnum_mat, "Número de material")
        '
        'menu_listarMaterial
        '
        Me.menu_listarMaterial.BackColor = System.Drawing.Color.White
        Me.menu_listarMaterial.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.menu_listarMaterial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.menu_listarMaterial.Location = New System.Drawing.Point(0, 0)
        Me.menu_listarMaterial.Name = "menu_listarMaterial"
        Me.menu_listarMaterial.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.menu_listarMaterial.Size = New System.Drawing.Size(1153, 24)
        Me.menu_listarMaterial.TabIndex = 1
        Me.menu_listarMaterial.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_inicio, Me.menu_crear, Me.menu_modif, Me.menu_listar, Me.menu_eliminar})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "&Opciones"
        Me.OpcionesToolStripMenuItem.ToolTipText = "Menú de opciones"
        '
        'menu_inicio
        '
        Me.menu_inicio.Image = CType(resources.GetObject("menu_inicio.Image"), System.Drawing.Image)
        Me.menu_inicio.Name = "menu_inicio"
        Me.menu_inicio.Size = New System.Drawing.Size(171, 22)
        Me.menu_inicio.Text = "&Inicio"
        '
        'menu_crear
        '
        Me.menu_crear.Image = CType(resources.GetObject("menu_crear.Image"), System.Drawing.Image)
        Me.menu_crear.Name = "menu_crear"
        Me.menu_crear.Size = New System.Drawing.Size(171, 22)
        Me.menu_crear.Text = "&Crear material"
        '
        'menu_modif
        '
        Me.menu_modif.Image = CType(resources.GetObject("menu_modif.Image"), System.Drawing.Image)
        Me.menu_modif.Name = "menu_modif"
        Me.menu_modif.Size = New System.Drawing.Size(171, 22)
        Me.menu_modif.Text = "&Modificar Material"
        '
        'menu_listar
        '
        Me.menu_listar.Enabled = False
        Me.menu_listar.Image = CType(resources.GetObject("menu_listar.Image"), System.Drawing.Image)
        Me.menu_listar.Name = "menu_listar"
        Me.menu_listar.Size = New System.Drawing.Size(171, 22)
        Me.menu_listar.Text = "&Listar Materiales"
        Me.menu_listar.ToolTipText = "Ventana actual"
        '
        'menu_eliminar
        '
        Me.menu_eliminar.Image = CType(resources.GetObject("menu_eliminar.Image"), System.Drawing.Image)
        Me.menu_eliminar.Name = "menu_eliminar"
        Me.menu_eliminar.Size = New System.Drawing.Size(171, 22)
        Me.menu_eliminar.Text = "&Eliminar Material"
        '
        'barra_iconos
        '
        Me.barra_iconos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.barra_iconos.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.barra_iconos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.icon_inicio})
        Me.barra_iconos.Location = New System.Drawing.Point(0, 24)
        Me.barra_iconos.Name = "barra_iconos"
        Me.barra_iconos.Size = New System.Drawing.Size(1153, 32)
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
        'lblsub_cat
        '
        Me.lblsub_cat.AutoSize = True
        Me.lblsub_cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsub_cat.Location = New System.Drawing.Point(163, 191)
        Me.lblsub_cat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsub_cat.Name = "lblsub_cat"
        Me.lblsub_cat.Size = New System.Drawing.Size(99, 18)
        Me.lblsub_cat.TabIndex = 6
        Me.lblsub_cat.Text = "Subcategoría:"
        '
        'lblcat
        '
        Me.lblcat.AutoSize = True
        Me.lblcat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcat.Location = New System.Drawing.Point(163, 160)
        Me.lblcat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcat.Name = "lblcat"
        Me.lblcat.Size = New System.Drawing.Size(76, 18)
        Me.lblcat.TabIndex = 8
        Me.lblcat.Text = "Categoría:"
        '
        'lblfe_reg
        '
        Me.lblfe_reg.AutoSize = True
        Me.lblfe_reg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfe_reg.Location = New System.Drawing.Point(163, 221)
        Me.lblfe_reg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfe_reg.Name = "lblfe_reg"
        Me.lblfe_reg.Size = New System.Drawing.Size(133, 18)
        Me.lblfe_reg.TabIndex = 9
        Me.lblfe_reg.Text = "Fecha de Registro:"
        '
        'lblnum_mat
        '
        Me.lblnum_mat.AutoSize = True
        Me.lblnum_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum_mat.Location = New System.Drawing.Point(163, 128)
        Me.lblnum_mat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnum_mat.Name = "lblnum_mat"
        Me.lblnum_mat.Size = New System.Drawing.Size(142, 18)
        Me.lblnum_mat.TabIndex = 10
        Me.lblnum_mat.Text = "Número de Material:"
        '
        'lblPantalla
        '
        Me.lblPantalla.AutoSize = True
        Me.lblPantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPantalla.Location = New System.Drawing.Point(131, 75)
        Me.lblPantalla.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPantalla.Name = "lblPantalla"
        Me.lblPantalla.Size = New System.Drawing.Size(189, 29)
        Me.lblPantalla.TabIndex = 11
        Me.lblPantalla.Text = "Listar Materiales"
        '
        'lblpas
        '
        Me.lblpas.AutoSize = True
        Me.lblpas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpas.Location = New System.Drawing.Point(163, 249)
        Me.lblpas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpas.Name = "lblpas"
        Me.lblpas.Size = New System.Drawing.Size(56, 18)
        Me.lblpas.TabIndex = 18
        Me.lblpas.Text = "Pasillo:"
        '
        'lblsec
        '
        Me.lblsec.AutoSize = True
        Me.lblsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsec.Location = New System.Drawing.Point(163, 282)
        Me.lblsec.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsec.Name = "lblsec"
        Me.lblsec.Size = New System.Drawing.Size(66, 18)
        Me.lblsec.TabIndex = 19
        Me.lblsec.Text = "Sección:"
        '
        'rejillaMateriales
        '
        Me.rejillaMateriales.AutoGenerateColumns = False
        Me.rejillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rejillaMateriales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.num_mat, Me.mat, Me.cat, Me.subcat, Me.fe_reg, Me.desc, Me.imp_com, Me.imp_ven, Me.pas, Me.sec, Me.stock})
        Me.rejillaMateriales.DataSource = Me.AlmacenMaterialesDBDataSet
        Me.rejillaMateriales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rejillaMateriales.Location = New System.Drawing.Point(0, 376)
        Me.rejillaMateriales.Margin = New System.Windows.Forms.Padding(2)
        Me.rejillaMateriales.Name = "rejillaMateriales"
        Me.rejillaMateriales.RowHeadersWidth = 51
        Me.rejillaMateriales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rejillaMateriales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.rejillaMateriales.RowTemplate.Height = 24
        Me.rejillaMateriales.Size = New System.Drawing.Size(1153, 228)
        Me.rejillaMateriales.TabIndex = 20
        '
        'num_mat
        '
        Me.num_mat.DataPropertyName = "num_mat"
        Me.num_mat.HeaderText = "Nº Material"
        Me.num_mat.Name = "num_mat"
        '
        'mat
        '
        Me.mat.DataPropertyName = "mat"
        Me.mat.HeaderText = "Material"
        Me.mat.Name = "mat"
        '
        'cat
        '
        Me.cat.DataPropertyName = "cat"
        Me.cat.HeaderText = "Categoría"
        Me.cat.Name = "cat"
        '
        'subcat
        '
        Me.subcat.DataPropertyName = "sub_cat"
        Me.subcat.HeaderText = "Subcategoría"
        Me.subcat.Name = "subcat"
        '
        'fe_reg
        '
        Me.fe_reg.DataPropertyName = "fe_reg"
        Me.fe_reg.HeaderText = "Fecha Registro"
        Me.fe_reg.Name = "fe_reg"
        '
        'desc
        '
        Me.desc.DataPropertyName = "desc"
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        '
        'imp_com
        '
        Me.imp_com.DataPropertyName = "imp_com"
        Me.imp_com.HeaderText = "Importe Compra"
        Me.imp_com.Name = "imp_com"
        '
        'imp_ven
        '
        Me.imp_ven.DataPropertyName = "imp_ven"
        Me.imp_ven.HeaderText = "Importe Venta"
        Me.imp_ven.Name = "imp_ven"
        '
        'pas
        '
        Me.pas.DataPropertyName = "pas"
        Me.pas.HeaderText = "Pasillo"
        Me.pas.Name = "pas"
        '
        'sec
        '
        Me.sec.DataPropertyName = "sec"
        Me.sec.HeaderText = "Sección"
        Me.sec.Name = "sec"
        '
        'stock
        '
        Me.stock.DataPropertyName = "stock"
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        '
        'AlmacenMaterialesDBDataSet
        '
        Me.AlmacenMaterialesDBDataSet.DataSetName = "AlmacenMaterialesDBDataSet"
        Me.AlmacenMaterialesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pnlFiltros
        '
        Me.pnlFiltros.Controls.Add(Me.cmbPasillo)
        Me.pnlFiltros.Controls.Add(Me.fechafe_reg)
        Me.pnlFiltros.Controls.Add(Me.cmbsub_cat)
        Me.pnlFiltros.Controls.Add(Me.cmbcat)
        Me.pnlFiltros.Controls.Add(Me.txtnum_mat)
        Me.pnlFiltros.Location = New System.Drawing.Point(367, 126)
        Me.pnlFiltros.Name = "pnlFiltros"
        Me.pnlFiltros.Size = New System.Drawing.Size(277, 152)
        Me.pnlFiltros.TabIndex = 21
        '
        'listarMateriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1153, 604)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.rejillaMateriales)
        Me.Controls.Add(Me.btnlistar)
        Me.Controls.Add(Me.pnlsec)
        Me.Controls.Add(Me.lblpas)
        Me.Controls.Add(Me.lblsec)
        Me.Controls.Add(Me.lblsub_cat)
        Me.Controls.Add(Me.lblcat)
        Me.Controls.Add(Me.lblfe_reg)
        Me.Controls.Add(Me.lblnum_mat)
        Me.Controls.Add(Me.lblPantalla)
        Me.Controls.Add(Me.img_icono)
        Me.Controls.Add(Me.barra_iconos)
        Me.Controls.Add(Me.menu_listarMaterial)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "listarMateriales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén de Materiales"
        CType(Me.img_icono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlsec.ResumeLayout(False)
        Me.pnlsec.PerformLayout()
        Me.menu_listarMaterial.ResumeLayout(False)
        Me.menu_listarMaterial.PerformLayout()
        Me.barra_iconos.ResumeLayout(False)
        Me.barra_iconos.PerformLayout()
        CType(Me.rejillaMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenMaterialesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ayuda As ToolTip
    Friend WithEvents menu_listarMaterial As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents menu_crear As ToolStripMenuItem
    Friend WithEvents menu_modif As ToolStripMenuItem
    Friend WithEvents menu_listar As ToolStripMenuItem
    Friend WithEvents menu_eliminar As ToolStripMenuItem
    Friend WithEvents barra_iconos As ToolStrip
    Friend WithEvents icon_inicio As ToolStripButton
    Friend WithEvents lblsub_cat As Label
    Friend WithEvents lblcat As Label
    Friend WithEvents lblfe_reg As Label
    Friend WithEvents lblnum_mat As Label
    Friend WithEvents lblPantalla As Label
    Friend WithEvents img_icono As PictureBox
    Friend WithEvents pnlsec As Panel
    Friend WithEvents rdbtF As RadioButton
    Friend WithEvents rdbtD As RadioButton
    Friend WithEvents rdbtB As RadioButton
    Friend WithEvents rdbtE As RadioButton
    Friend WithEvents rdbtC As RadioButton
    Friend WithEvents rdbtA As RadioButton
    Friend WithEvents lblpas As Label
    Friend WithEvents lblsec As Label
    Friend WithEvents btnlistar As Button
    Friend WithEvents rejillaMateriales As DataGridView
    Friend WithEvents menu_inicio As ToolStripMenuItem
    Friend WithEvents pnlFiltros As Panel
    Friend WithEvents cmbPasillo As ComboBox
    Friend WithEvents fechafe_reg As DateTimePicker
    Friend WithEvents cmbsub_cat As ComboBox
    Friend WithEvents cmbcat As ComboBox
    Friend WithEvents txtnum_mat As TextBox
    Friend WithEvents AlmacenMaterialesDBDataSet As AlmacenMaterialesDBDataSet
    Friend WithEvents num_mat As DataGridViewTextBoxColumn
    Friend WithEvents mat As DataGridViewTextBoxColumn
    Friend WithEvents cat As DataGridViewTextBoxColumn
    Friend WithEvents subcat As DataGridViewTextBoxColumn
    Friend WithEvents fe_reg As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents imp_com As DataGridViewTextBoxColumn
    Friend WithEvents imp_ven As DataGridViewTextBoxColumn
    Friend WithEvents pas As DataGridViewTextBoxColumn
    Friend WithEvents sec As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
