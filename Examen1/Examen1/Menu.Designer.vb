<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirCuadroImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarVentanaActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VistaToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VistaToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirTextoToolStripMenuItem, Me.AbrirCuadroImagenToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarVentanaActivaToolStripMenuItem, Me.CerrarTodasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'AbrirTextoToolStripMenuItem
        '
        Me.AbrirTextoToolStripMenuItem.Name = "AbrirTextoToolStripMenuItem"
        Me.AbrirTextoToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.AbrirTextoToolStripMenuItem.Text = "Abrir cuadro texto"
        '
        'AbrirCuadroImagenToolStripMenuItem
        '
        Me.AbrirCuadroImagenToolStripMenuItem.Name = "AbrirCuadroImagenToolStripMenuItem"
        Me.AbrirCuadroImagenToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.AbrirCuadroImagenToolStripMenuItem.Text = "Abrir cuadro imagen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(228, 6)
        '
        'CerrarVentanaActivaToolStripMenuItem
        '
        Me.CerrarVentanaActivaToolStripMenuItem.Name = "CerrarVentanaActivaToolStripMenuItem"
        Me.CerrarVentanaActivaToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.CerrarVentanaActivaToolStripMenuItem.Text = "Cerrar ventana activa"
        '
        'CerrarTodasToolStripMenuItem
        '
        Me.CerrarTodasToolStripMenuItem.Name = "CerrarTodasToolStripMenuItem"
        Me.CerrarTodasToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.CerrarTodasToolStripMenuItem.Text = "Cerrar todas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.HorizontalToolStripMenuItem, Me.VerticalToolStripMenuItem})
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.VistaToolStripMenuItem.Text = "&Vista"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(30, 24)
        Me.AboutToolStripMenuItem.Text = "&?"
        '
        'reloj
        '
        Me.reloj.Enabled = True
        Me.reloj.Interval = 1000
        '
        'txtFecha
        '
        Me.txtFecha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(0, 423)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(800, 27)
        Me.txtFecha.TabIndex = 8
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents reloj As Timer
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents AbrirTextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirCuadroImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarVentanaActivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
