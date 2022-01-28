<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.fecha = New System.Windows.Forms.DateTimePicker()
        Me.rbPanel = New System.Windows.Forms.Panel()
        Me.rdbtFinanzas = New System.Windows.Forms.RadioButton()
        Me.rdbtLogistica = New System.Windows.Forms.RadioButton()
        Me.rdbtRRHH = New System.Windows.Forms.RadioButton()
        Me.cmbAcceso = New System.Windows.Forms.ComboBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.lblApellidos = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNacimiento = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.grPersona = New System.Windows.Forms.GroupBox()
        Me.errDNI = New System.Windows.Forms.Label()
        Me.errApe = New System.Windows.Forms.Label()
        Me.errNom = New System.Windows.Forms.Label()
        Me.grTrabajo = New System.Windows.Forms.GroupBox()
        Me.errAcc = New System.Windows.Forms.Label()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbPanel.SuspendLayout()
        Me.grPersona.SuspendLayout()
        Me.grTrabajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(246, 25)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(229, 28)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro de personal"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(16, 34)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 18)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        Me.ToolTip.SetToolTip(Me.lblNombre, "Nombre del empleado")
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(20, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(183, 24)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.Tag = "errNom"
        Me.ToolTip.SetToolTip(Me.txtNombre, "Nombre del empleado")
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(20, 125)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(183, 24)
        Me.txtApellidos.TabIndex = 2
        Me.txtApellidos.Tag = "errApe"
        Me.ToolTip.SetToolTip(Me.txtApellidos, "Apellidos del empleado")
        '
        'txtDNI
        '
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(20, 194)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(183, 24)
        Me.txtDNI.TabIndex = 3
        Me.txtDNI.Tag = "errDNI"
        Me.ToolTip.SetToolTip(Me.txtDNI, "DNI del empleado")
        '
        'fecha
        '
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.Location = New System.Drawing.Point(20, 266)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(266, 24)
        Me.fecha.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.fecha, "Fecha de nacimiento del empelado")
        '
        'rbPanel
        '
        Me.rbPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.rbPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rbPanel.Controls.Add(Me.rdbtFinanzas)
        Me.rbPanel.Controls.Add(Me.rdbtLogistica)
        Me.rbPanel.Controls.Add(Me.rdbtRRHH)
        Me.rbPanel.Location = New System.Drawing.Point(25, 58)
        Me.rbPanel.Name = "rbPanel"
        Me.rbPanel.Size = New System.Drawing.Size(193, 102)
        Me.rbPanel.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.rbPanel, "Departamento autorizador")
        '
        'rdbtFinanzas
        '
        Me.rdbtFinanzas.AutoSize = True
        Me.rdbtFinanzas.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtFinanzas.Location = New System.Drawing.Point(10, 2)
        Me.rdbtFinanzas.Name = "rdbtFinanzas"
        Me.rdbtFinanzas.Size = New System.Drawing.Size(87, 24)
        Me.rdbtFinanzas.TabIndex = 5
        Me.rdbtFinanzas.TabStop = True
        Me.rdbtFinanzas.Text = "Finanzas"
        Me.rdbtFinanzas.UseVisualStyleBackColor = True
        '
        'rdbtLogistica
        '
        Me.rdbtLogistica.AutoSize = True
        Me.rdbtLogistica.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtLogistica.Location = New System.Drawing.Point(10, 64)
        Me.rdbtLogistica.Name = "rdbtLogistica"
        Me.rdbtLogistica.Size = New System.Drawing.Size(85, 24)
        Me.rdbtLogistica.TabIndex = 5
        Me.rdbtLogistica.TabStop = True
        Me.rdbtLogistica.Text = "Logística"
        Me.rdbtLogistica.UseVisualStyleBackColor = True
        '
        'rdbtRRHH
        '
        Me.rdbtRRHH.AutoSize = True
        Me.rdbtRRHH.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtRRHH.Location = New System.Drawing.Point(10, 33)
        Me.rdbtRRHH.Name = "rdbtRRHH"
        Me.rdbtRRHH.Size = New System.Drawing.Size(159, 24)
        Me.rdbtRRHH.TabIndex = 5
        Me.rdbtRRHH.TabStop = True
        Me.rdbtRRHH.Text = "Recursos Humanos"
        Me.rdbtRRHH.UseVisualStyleBackColor = True
        '
        'cmbAcceso
        '
        Me.cmbAcceso.FormattingEnabled = True
        Me.cmbAcceso.Items.AddRange(New Object() {"Matutino (08:00-14:00)", "Verpertino (14:00-22:00)", "Nocturno (22:00-08:00)"})
        Me.cmbAcceso.Location = New System.Drawing.Point(28, 210)
        Me.cmbAcceso.Name = "cmbAcceso"
        Me.cmbAcceso.Size = New System.Drawing.Size(190, 26)
        Me.cmbAcceso.TabIndex = 6
        Me.cmbAcceso.Tag = "errAcc"
        Me.ToolTip.SetToolTip(Me.cmbAcceso, "Periodo de acceso al centro")
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(301, 438)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(106, 34)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.ToolTip.SetToolTip(Me.btnEnviar, "Enviar formulario para registro")
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'lblApellidos
        '
        Me.lblApellidos.AutoSize = True
        Me.lblApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos.Location = New System.Drawing.Point(16, 101)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(71, 18)
        Me.lblApellidos.TabIndex = 0
        Me.lblApellidos.Text = "Apellidos:"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.Location = New System.Drawing.Point(16, 170)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(37, 18)
        Me.lblDNI.TabIndex = 0
        Me.lblDNI.Text = "DNI:"
        '
        'lblNacimiento
        '
        Me.lblNacimiento.AutoSize = True
        Me.lblNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNacimiento.Location = New System.Drawing.Point(16, 241)
        Me.lblNacimiento.Name = "lblNacimiento"
        Me.lblNacimiento.Size = New System.Drawing.Size(149, 18)
        Me.lblNacimiento.TabIndex = 0
        Me.lblNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.Location = New System.Drawing.Point(21, 31)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(198, 21)
        Me.lblDepartamento.TabIndex = 0
        Me.lblDepartamento.Text = "Departamento autorizador:"
        '
        'grPersona
        '
        Me.grPersona.Controls.Add(Me.errDNI)
        Me.grPersona.Controls.Add(Me.errApe)
        Me.grPersona.Controls.Add(Me.errNom)
        Me.grPersona.Controls.Add(Me.lblNombre)
        Me.grPersona.Controls.Add(Me.lblApellidos)
        Me.grPersona.Controls.Add(Me.lblDNI)
        Me.grPersona.Controls.Add(Me.lblNacimiento)
        Me.grPersona.Controls.Add(Me.fecha)
        Me.grPersona.Controls.Add(Me.txtNombre)
        Me.grPersona.Controls.Add(Me.txtDNI)
        Me.grPersona.Controls.Add(Me.txtApellidos)
        Me.grPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grPersona.Location = New System.Drawing.Point(40, 78)
        Me.grPersona.Name = "grPersona"
        Me.grPersona.Size = New System.Drawing.Size(302, 311)
        Me.grPersona.TabIndex = 0
        Me.grPersona.TabStop = False
        Me.grPersona.Text = "Datos personales"
        '
        'errDNI
        '
        Me.errDNI.AutoSize = True
        Me.errDNI.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errDNI.ForeColor = System.Drawing.Color.Red
        Me.errDNI.Location = New System.Drawing.Point(49, 172)
        Me.errDNI.Name = "errDNI"
        Me.errDNI.Size = New System.Drawing.Size(16, 21)
        Me.errDNI.TabIndex = 0
        Me.errDNI.Text = "*"
        '
        'errApe
        '
        Me.errApe.AutoSize = True
        Me.errApe.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errApe.ForeColor = System.Drawing.Color.Red
        Me.errApe.Location = New System.Drawing.Point(84, 101)
        Me.errApe.Name = "errApe"
        Me.errApe.Size = New System.Drawing.Size(16, 21)
        Me.errApe.TabIndex = 0
        Me.errApe.Text = "*"
        '
        'errNom
        '
        Me.errNom.AutoSize = True
        Me.errNom.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errNom.ForeColor = System.Drawing.Color.Red
        Me.errNom.Location = New System.Drawing.Point(75, 35)
        Me.errNom.Name = "errNom"
        Me.errNom.Size = New System.Drawing.Size(16, 21)
        Me.errNom.TabIndex = 0
        Me.errNom.Text = "*"
        '
        'grTrabajo
        '
        Me.grTrabajo.Controls.Add(Me.errAcc)
        Me.grTrabajo.Controls.Add(Me.cmbAcceso)
        Me.grTrabajo.Controls.Add(Me.lblAcceso)
        Me.grTrabajo.Controls.Add(Me.rbPanel)
        Me.grTrabajo.Controls.Add(Me.lblDepartamento)
        Me.grTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grTrabajo.Location = New System.Drawing.Point(377, 78)
        Me.grTrabajo.Name = "grTrabajo"
        Me.grTrabajo.Size = New System.Drawing.Size(290, 311)
        Me.grTrabajo.TabIndex = 0
        Me.grTrabajo.TabStop = False
        Me.grTrabajo.Text = "Datos laborales"
        '
        'errAcc
        '
        Me.errAcc.AutoSize = True
        Me.errAcc.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errAcc.ForeColor = System.Drawing.Color.Red
        Me.errAcc.Location = New System.Drawing.Point(159, 174)
        Me.errAcc.Name = "errAcc"
        Me.errAcc.Size = New System.Drawing.Size(16, 21)
        Me.errAcc.TabIndex = 0
        Me.errAcc.Text = "*"
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Location = New System.Drawing.Point(25, 174)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(137, 18)
        Me.lblAcceso.TabIndex = 0
        Me.lblAcceso.Text = "Periodo de acceso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Unicode MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(52, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "* Campos obligatorios"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(722, 509)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.grTrabajo)
        Me.Controls.Add(Me.grPersona)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de personal"
        Me.rbPanel.ResumeLayout(False)
        Me.rbPanel.PerformLayout()
        Me.grPersona.ResumeLayout(False)
        Me.grPersona.PerformLayout()
        Me.grTrabajo.ResumeLayout(False)
        Me.grTrabajo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblApellidos As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents lblNacimiento As Label
    Friend WithEvents fecha As DateTimePicker
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents rdbtFinanzas As RadioButton
    Friend WithEvents rdbtRRHH As RadioButton
    Friend WithEvents rdbtLogistica As RadioButton
    Friend WithEvents grPersona As GroupBox
    Friend WithEvents grTrabajo As GroupBox
    Friend WithEvents rbPanel As Panel
    Friend WithEvents cmbAcceso As ComboBox
    Friend WithEvents lblAcceso As Label
    Friend WithEvents errDNI As Label
    Friend WithEvents errApe As Label
    Friend WithEvents errNom As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents errAcc As Label
    Friend WithEvents btnEnviar As Button
End Class
