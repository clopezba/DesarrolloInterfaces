<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI_y_Menues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI_y_Menues))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PizarrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImágenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CerrarPizarraActivaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PizarrasToolStripMenuItem, Me.VentanasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PizarrasToolStripMenuItem
        '
        Me.PizarrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImágenesToolStripMenuItem, Me.TextosToolStripMenuItem, Me.ToolStripMenuItem1, Me.CerrarPizarraActivaToolStripMenuItem, Me.CerrarTodasToolStripMenuItem, Me.ToolStripMenuItem2, Me.SalirToolStripMenuItem})
        Me.PizarrasToolStripMenuItem.Name = "PizarrasToolStripMenuItem"
        Me.PizarrasToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.PizarrasToolStripMenuItem.Text = "&Pizarras"
        '
        'ImágenesToolStripMenuItem
        '
        Me.ImágenesToolStripMenuItem.Name = "ImágenesToolStripMenuItem"
        Me.ImágenesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ImágenesToolStripMenuItem.Text = "Imágenes"
        '
        'TextosToolStripMenuItem
        '
        Me.TextosToolStripMenuItem.Name = "TextosToolStripMenuItem"
        Me.TextosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TextosToolStripMenuItem.Text = "Textos"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
        '
        'CerrarPizarraActivaToolStripMenuItem
        '
        Me.CerrarPizarraActivaToolStripMenuItem.Name = "CerrarPizarraActivaToolStripMenuItem"
        Me.CerrarPizarraActivaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarPizarraActivaToolStripMenuItem.Text = "Cerrar Pizarra Activa"
        '
        'CerrarTodasToolStripMenuItem
        '
        Me.CerrarTodasToolStripMenuItem.Name = "CerrarTodasToolStripMenuItem"
        Me.CerrarTodasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CerrarTodasToolStripMenuItem.Text = "Cerrar Todas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(177, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.VentanasToolStripMenuItem.Text = "&Ventanas"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblFecha})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblFecha
        '
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(64, 17)
        Me.lblFecha.Text = "Fecha reloj"
        '
        'MDI_y_Menues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI_y_Menues"
        Me.Text = "MDI_y_Menues"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PizarrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImágenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CerrarPizarraActivaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblFecha As ToolStripStatusLabel
End Class
