<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficheros_Random
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExistenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PBotones = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.BUltimo = New System.Windows.Forms.Button
        Me.BAnterior = New System.Windows.Forms.Button
        Me.BSiguiente = New System.Windows.Forms.Button
        Me.BPrimero = New System.Windows.Forms.Button
        Me.BRegistrar = New System.Windows.Forms.Button
        Me.BNuevoR = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LNREG = New System.Windows.Forms.Label
        Me.EtiquetaReg = New System.Windows.Forms.Label
        Me.CFecha = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CApellidos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CNombre = New System.Windows.Forms.TextBox
        Me.LNombre = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.PBotones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(533, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ExistenteToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "&Nuevo"
        '
        'ExistenteToolStripMenuItem
        '
        Me.ExistenteToolStripMenuItem.Name = "ExistenteToolStripMenuItem"
        Me.ExistenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExistenteToolStripMenuItem.Text = "&Existente"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'PBotones
        '
        Me.PBotones.Controls.Add(Me.Button1)
        Me.PBotones.Controls.Add(Me.BUltimo)
        Me.PBotones.Controls.Add(Me.BAnterior)
        Me.PBotones.Controls.Add(Me.BSiguiente)
        Me.PBotones.Controls.Add(Me.BPrimero)
        Me.PBotones.Controls.Add(Me.BRegistrar)
        Me.PBotones.Controls.Add(Me.BNuevoR)
        Me.PBotones.Enabled = False
        Me.PBotones.Location = New System.Drawing.Point(22, 238)
        Me.PBotones.Name = "PBotones"
        Me.PBotones.Size = New System.Drawing.Size(499, 45)
        Me.PBotones.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(420, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 36)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "&Ir a Posición"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BUltimo
        '
        Me.BUltimo.Location = New System.Drawing.Point(351, 3)
        Me.BUltimo.Name = "BUltimo"
        Me.BUltimo.Size = New System.Drawing.Size(63, 36)
        Me.BUltimo.TabIndex = 6
        Me.BUltimo.Text = "&Último"
        Me.BUltimo.UseVisualStyleBackColor = True
        '
        'BAnterior
        '
        Me.BAnterior.Enabled = False
        Me.BAnterior.Location = New System.Drawing.Point(287, 3)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(58, 36)
        Me.BAnterior.TabIndex = 7
        Me.BAnterior.Text = "&Anterior"
        Me.BAnterior.UseVisualStyleBackColor = True
        '
        'BSiguiente
        '
        Me.BSiguiente.Enabled = False
        Me.BSiguiente.Location = New System.Drawing.Point(213, 3)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(68, 36)
        Me.BSiguiente.TabIndex = 4
        Me.BSiguiente.Text = "&Siguiente"
        Me.BSiguiente.UseVisualStyleBackColor = True
        '
        'BPrimero
        '
        Me.BPrimero.Location = New System.Drawing.Point(143, 3)
        Me.BPrimero.Name = "BPrimero"
        Me.BPrimero.Size = New System.Drawing.Size(64, 36)
        Me.BPrimero.TabIndex = 5
        Me.BPrimero.Text = "&Primero"
        Me.BPrimero.UseVisualStyleBackColor = True
        '
        'BRegistrar
        '
        Me.BRegistrar.Location = New System.Drawing.Point(74, 3)
        Me.BRegistrar.Name = "BRegistrar"
        Me.BRegistrar.Size = New System.Drawing.Size(63, 36)
        Me.BRegistrar.TabIndex = 0
        Me.BRegistrar.Text = "Registrar"
        Me.BRegistrar.UseVisualStyleBackColor = True
        '
        'BNuevoR
        '
        Me.BNuevoR.Location = New System.Drawing.Point(5, 3)
        Me.BNuevoR.Name = "BNuevoR"
        Me.BNuevoR.Size = New System.Drawing.Size(63, 36)
        Me.BNuevoR.TabIndex = 0
        Me.BNuevoR.Text = "Nuevo registro"
        Me.BNuevoR.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LNREG)
        Me.Panel1.Controls.Add(Me.EtiquetaReg)
        Me.Panel1.Controls.Add(Me.CFecha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CApellidos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CNombre)
        Me.Panel1.Controls.Add(Me.LNombre)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(42, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 142)
        Me.Panel1.TabIndex = 23
        '
        'LNREG
        '
        Me.LNREG.AutoSize = True
        Me.LNREG.BackColor = System.Drawing.SystemColors.Window
        Me.LNREG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LNREG.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNREG.Location = New System.Drawing.Point(375, 20)
        Me.LNREG.Name = "LNREG"
        Me.LNREG.Size = New System.Drawing.Size(36, 17)
        Me.LNREG.TabIndex = 28
        Me.LNREG.Text = "Nreg"
        '
        'EtiquetaReg
        '
        Me.EtiquetaReg.AutoSize = True
        Me.EtiquetaReg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EtiquetaReg.Location = New System.Drawing.Point(335, 20)
        Me.EtiquetaReg.Name = "EtiquetaReg"
        Me.EtiquetaReg.Size = New System.Drawing.Size(34, 15)
        Me.EtiquetaReg.TabIndex = 29
        Me.EtiquetaReg.Text = "Nreg"
        '
        'CFecha
        '
        Me.CFecha.Location = New System.Drawing.Point(168, 101)
        Me.CFecha.Name = "CFecha"
        Me.CFecha.Size = New System.Drawing.Size(99, 20)
        Me.CFecha.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Fecha Nacimiento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CApellidos
        '
        Me.CApellidos.Location = New System.Drawing.Point(168, 62)
        Me.CApellidos.MaxLength = 40
        Me.CApellidos.Name = "CApellidos"
        Me.CApellidos.Size = New System.Drawing.Size(233, 20)
        Me.CApellidos.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Apellidos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CNombre
        '
        Me.CNombre.Location = New System.Drawing.Point(168, 20)
        Me.CNombre.MaxLength = 20
        Me.CNombre.Name = "CNombre"
        Me.CNombre.Size = New System.Drawing.Size(121, 20)
        Me.CNombre.TabIndex = 22
        '
        'LNombre
        '
        Me.LNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(110, 25)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(52, 15)
        Me.LNombre.TabIndex = 27
        Me.LNombre.Text = "Nombre"
        Me.LNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ficheros Aleatorios"
        '
        'Ficheros_Random
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PBotones)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ficheros_Random"
        Me.Text = "Ficheros Random"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PBotones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PBotones As System.Windows.Forms.Panel
    Friend WithEvents BRegistrar As System.Windows.Forms.Button
    Friend WithEvents BNuevoR As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LNREG As System.Windows.Forms.Label
    Friend WithEvents EtiquetaReg As System.Windows.Forms.Label
    Friend WithEvents CFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BUltimo As System.Windows.Forms.Button
    Friend WithEvents BAnterior As System.Windows.Forms.Button
    Friend WithEvents BSiguiente As System.Windows.Forms.Button
    Friend WithEvents BPrimero As System.Windows.Forms.Button

End Class
