<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BD_Neptuno
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerClientesYPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerCategoríasYProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerProveedoresYProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarVentanaActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasLasVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VentanaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerClientesYPedidosToolStripMenuItem, Me.VerCategoríasYProductosToolStripMenuItem, Me.VerProveedoresYProductosToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarVentanaActivaToolStripMenuItem, Me.CerrarTodasLasVentanasToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'VerClientesYPedidosToolStripMenuItem
        '
        Me.VerClientesYPedidosToolStripMenuItem.Name = "VerClientesYPedidosToolStripMenuItem"
        Me.VerClientesYPedidosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.VerClientesYPedidosToolStripMenuItem.Text = "Ver Clientes y Pedidos"
        '
        'VerCategoríasYProductosToolStripMenuItem
        '
        Me.VerCategoríasYProductosToolStripMenuItem.Name = "VerCategoríasYProductosToolStripMenuItem"
        Me.VerCategoríasYProductosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.VerCategoríasYProductosToolStripMenuItem.Text = "Ver Categorías y Productos"
        '
        'VerProveedoresYProductosToolStripMenuItem
        '
        Me.VerProveedoresYProductosToolStripMenuItem.Name = "VerProveedoresYProductosToolStripMenuItem"
        Me.VerProveedoresYProductosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.VerProveedoresYProductosToolStripMenuItem.Text = "Ver Proveedores y Productos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(277, 6)
        '
        'CerrarVentanaActivaToolStripMenuItem
        '
        Me.CerrarVentanaActivaToolStripMenuItem.Name = "CerrarVentanaActivaToolStripMenuItem"
        Me.CerrarVentanaActivaToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.CerrarVentanaActivaToolStripMenuItem.Text = "Cerrar ventana activa"
        '
        'CerrarTodasLasVentanasToolStripMenuItem
        '
        Me.CerrarTodasLasVentanasToolStripMenuItem.Name = "CerrarTodasLasVentanasToolStripMenuItem"
        Me.CerrarTodasLasVentanasToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.CerrarTodasLasVentanasToolStripMenuItem.Text = "Cerrar todas las ventanas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(277, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.VentanaToolStripMenuItem.Text = "&Ventana"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "BD_Neptuno"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerClientesYPedidosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerCategoríasYProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerProveedoresYProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarVentanaActivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasLasVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
