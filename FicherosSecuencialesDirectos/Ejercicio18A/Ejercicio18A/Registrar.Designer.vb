<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EtiquetaReg = New System.Windows.Forms.Label()
        Me.LREG = New System.Windows.Forms.Label()
        Me.CFecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CApellidos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PBotones = New System.Windows.Forms.Panel()
        Me.BRegistrar = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.PBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'EtiquetaReg
        '
        Me.EtiquetaReg.AutoSize = True
        Me.EtiquetaReg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaReg.Location = New System.Drawing.Point(336, 95)
        Me.EtiquetaReg.Name = "EtiquetaReg"
        Me.EtiquetaReg.Size = New System.Drawing.Size(34, 15)
        Me.EtiquetaReg.TabIndex = 12
        Me.EtiquetaReg.Text = "Nreg"
        '
        'LREG
        '
        Me.LREG.AutoSize = True
        Me.LREG.Location = New System.Drawing.Point(372, 95)
        Me.LREG.Name = "LREG"
        Me.LREG.Size = New System.Drawing.Size(30, 13)
        Me.LREG.TabIndex = 13
        Me.LREG.Text = "Nreg"
        '
        'CFecha
        '
        Me.CFecha.Location = New System.Drawing.Point(169, 176)
        Me.CFecha.Name = "CFecha"
        Me.CFecha.Size = New System.Drawing.Size(99, 20)
        Me.CFecha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha Nacimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CApellidos
        '
        Me.CApellidos.Location = New System.Drawing.Point(169, 137)
        Me.CApellidos.Name = "CApellidos"
        Me.CApellidos.Size = New System.Drawing.Size(233, 20)
        Me.CApellidos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Apellidos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CNombre
        '
        Me.CNombre.Location = New System.Drawing.Point(169, 95)
        Me.CNombre.Name = "CNombre"
        Me.CNombre.Size = New System.Drawing.Size(121, 20)
        Me.CNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 27)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Registro de datos en un fichero Secuencial"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(501, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirToolStripMenuItem, Me.NuevoToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'AñadirToolStripMenuItem
        '
        Me.AñadirToolStripMenuItem.Name = "AñadirToolStripMenuItem"
        Me.AñadirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AñadirToolStripMenuItem.Tag = "8"
        Me.AñadirToolStripMenuItem.Text = "Añadir"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NuevoToolStripMenuItem.Tag = "2"
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'PBotones
        '
        Me.PBotones.Controls.Add(Me.BRegistrar)
        Me.PBotones.Controls.Add(Me.BLimpiar)
        Me.PBotones.Location = New System.Drawing.Point(169, 232)
        Me.PBotones.Name = "PBotones"
        Me.PBotones.Size = New System.Drawing.Size(138, 30)
        Me.PBotones.TabIndex = 15
        Me.PBotones.Visible = False
        '
        'BRegistrar
        '
        Me.BRegistrar.Location = New System.Drawing.Point(72, 3)
        Me.BRegistrar.Name = "BRegistrar"
        Me.BRegistrar.Size = New System.Drawing.Size(63, 25)
        Me.BRegistrar.TabIndex = 0
        Me.BRegistrar.Text = "Registrar"
        Me.BRegistrar.UseVisualStyleBackColor = True
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(3, 3)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(63, 25)
        Me.BLimpiar.TabIndex = 0
        Me.BLimpiar.Text = "Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'Registrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 276)
        Me.Controls.Add(Me.PBotones)
        Me.Controls.Add(Me.EtiquetaReg)
        Me.Controls.Add(Me.LREG)
        Me.Controls.Add(Me.CFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Registrar"
        Me.Text = "Registrar"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EtiquetaReg As System.Windows.Forms.Label
    Friend WithEvents LREG As System.Windows.Forms.Label
    Friend WithEvents CFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AñadirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PBotones As System.Windows.Forms.Panel
    Friend WithEvents BLimpiar As System.Windows.Forms.Button
    Friend WithEvents BRegistrar As System.Windows.Forms.Button
End Class
