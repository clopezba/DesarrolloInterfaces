<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuOpciones = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarHijosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarVentanaActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodasLasVentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirDeLaAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasacadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBar = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.MenuOpciones.SuspendLayout()
        Me.ToolBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOpciones
        '
        Me.MenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.MenuOpciones.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuOpciones.Size = New System.Drawing.Size(800, 24)
        Me.MenuOpciones.TabIndex = 1
        Me.MenuOpciones.Text = "MenuStrip1"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarHijosToolStripMenuItem, Me.CerrarVentanaActualToolStripMenuItem, Me.CerrarTodasLasVentanasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirDeLaAplicaciónToolStripMenuItem})
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.PrincipalToolStripMenuItem.Text = "&Principal"
        '
        'CargarHijosToolStripMenuItem
        '
        Me.CargarHijosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextoToolStripMenuItem, Me.ImagenToolStripMenuItem})
        Me.CargarHijosToolStripMenuItem.Name = "CargarHijosToolStripMenuItem"
        Me.CargarHijosToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CargarHijosToolStripMenuItem.Text = "Cargar hijos"
        '
        'TextoToolStripMenuItem
        '
        Me.TextoToolStripMenuItem.Image = CType(resources.GetObject("TextoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextoToolStripMenuItem.Name = "TextoToolStripMenuItem"
        Me.TextoToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.TextoToolStripMenuItem.Text = "Texto"
        '
        'ImagenToolStripMenuItem
        '
        Me.ImagenToolStripMenuItem.Image = CType(resources.GetObject("ImagenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImagenToolStripMenuItem.Name = "ImagenToolStripMenuItem"
        Me.ImagenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ImagenToolStripMenuItem.Text = "Imagen"
        '
        'CerrarVentanaActualToolStripMenuItem
        '
        Me.CerrarVentanaActualToolStripMenuItem.Name = "CerrarVentanaActualToolStripMenuItem"
        Me.CerrarVentanaActualToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CerrarVentanaActualToolStripMenuItem.Text = "Cerrar ventana actual"
        '
        'CerrarTodasLasVentanasToolStripMenuItem
        '
        Me.CerrarTodasLasVentanasToolStripMenuItem.Name = "CerrarTodasLasVentanasToolStripMenuItem"
        Me.CerrarTodasLasVentanasToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.CerrarTodasLasVentanasToolStripMenuItem.Text = "Cerrar todas las ventanas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(202, 6)
        '
        'SalirDeLaAplicaciónToolStripMenuItem
        '
        Me.SalirDeLaAplicaciónToolStripMenuItem.Name = "SalirDeLaAplicaciónToolStripMenuItem"
        Me.SalirDeLaAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SalirDeLaAplicaciónToolStripMenuItem.Text = "&Salir de la aplicación"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CasacadeToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.VentanaToolStripMenuItem.Text = "&Ventanas hijos (Childs)"
        '
        'CasacadeToolStripMenuItem
        '
        Me.CasacadeToolStripMenuItem.Name = "CasacadeToolStripMenuItem"
        Me.CasacadeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CasacadeToolStripMenuItem.Text = "Casacade"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'ToolBar
        '
        Me.ToolBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolBar.Location = New System.Drawing.Point(0, 24)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.Size = New System.Drawing.Size(800, 27)
        Me.ToolBar.TabIndex = 4
        Me.ToolBar.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.Text = "Abrir Texto"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton2.Text = "Abrir Imagen"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton3.Text = "Cerrar Ventanas"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton4.Text = "Acerca de..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolBar)
        Me.Controls.Add(Me.MenuOpciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuOpciones
        Me.Name = "Form1"
        Me.Text = "Formulario MDI"
        Me.MenuOpciones.ResumeLayout(False)
        Me.MenuOpciones.PerformLayout()
        Me.ToolBar.ResumeLayout(False)
        Me.ToolBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuOpciones As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarHijosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarVentanaActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodasLasVentanasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirDeLaAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CasacadeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolBar As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
End Class
