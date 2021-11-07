<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Imagen
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
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.MenuContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarDesdePortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBox
        '
        Me.PicBox.ContextMenuStrip = Me.MenuContext
        Me.PicBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicBox.Location = New System.Drawing.Point(0, 0)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(1067, 554)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 0
        Me.PicBox.TabStop = False
        '
        'MenuContext
        '
        Me.MenuContext.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem, Me.InsertarDesdePortapapelesToolStripMenuItem})
        Me.MenuContext.Name = "MenuContext"
        Me.MenuContext.Size = New System.Drawing.Size(264, 52)
        '
        'BorrarTodoToolStripMenuItem
        '
        Me.BorrarTodoToolStripMenuItem.Name = "BorrarTodoToolStripMenuItem"
        Me.BorrarTodoToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.BorrarTodoToolStripMenuItem.Text = "Borrar todo"
        '
        'InsertarDesdePortapapelesToolStripMenuItem
        '
        Me.InsertarDesdePortapapelesToolStripMenuItem.Name = "InsertarDesdePortapapelesToolStripMenuItem"
        Me.InsertarDesdePortapapelesToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.InsertarDesdePortapapelesToolStripMenuItem.Text = "Insertar desde portapapeles"
        '
        'Form_Imagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.PicBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_Imagen"
        Me.Text = "Form_Imagen"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuContext.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicBox As PictureBox
    Friend WithEvents MenuContext As ContextMenuStrip
    Friend WithEvents BorrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarDesdePortapapelesToolStripMenuItem As ToolStripMenuItem
End Class
