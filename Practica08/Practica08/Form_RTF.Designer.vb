<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_RTF
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
        Me.rtbTexto = New System.Windows.Forms.RichTextBox()
        Me.MenuContexto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BorrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarDesdePortapapelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuContexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtbTexto
        '
        Me.rtbTexto.ContextMenuStrip = Me.MenuContexto
        Me.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbTexto.Location = New System.Drawing.Point(0, 0)
        Me.rtbTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbTexto.Name = "rtbTexto"
        Me.rtbTexto.Size = New System.Drawing.Size(1067, 554)
        Me.rtbTexto.TabIndex = 0
        Me.rtbTexto.Text = ""
        '
        'MenuContexto
        '
        Me.MenuContexto.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuContexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrarTodoToolStripMenuItem, Me.InsertarDesdePortapapelesToolStripMenuItem})
        Me.MenuContexto.Name = "MenuContexto"
        Me.MenuContexto.Size = New System.Drawing.Size(264, 52)
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
        'Form_RTF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.rtbTexto)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_RTF"
        Me.Text = "Form_RTF"
        Me.MenuContexto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rtbTexto As RichTextBox
    Friend WithEvents MenuContexto As ContextMenuStrip
    Friend WithEvents BorrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertarDesdePortapapelesToolStripMenuItem As ToolStripMenuItem
End Class
