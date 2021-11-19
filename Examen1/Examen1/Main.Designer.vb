<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnForm1 = New System.Windows.Forms.Button()
        Me.btnTexto = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnForm1
        '
        Me.btnForm1.Location = New System.Drawing.Point(185, 74)
        Me.btnForm1.Name = "btnForm1"
        Me.btnForm1.Size = New System.Drawing.Size(239, 59)
        Me.btnForm1.TabIndex = 0
        Me.btnForm1.Text = "Configurar equipo"
        Me.btnForm1.UseVisualStyleBackColor = True
        '
        'btnTexto
        '
        Me.btnTexto.Location = New System.Drawing.Point(185, 188)
        Me.btnTexto.Name = "btnTexto"
        Me.btnTexto.Size = New System.Drawing.Size(239, 59)
        Me.btnTexto.TabIndex = 0
        Me.btnTexto.Text = "Estilos texto"
        Me.btnTexto.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(185, 305)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(239, 59)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.Text = "Menú"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 451)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnTexto)
        Me.Controls.Add(Me.btnForm1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnForm1 As Button
    Friend WithEvents btnTexto As Button
    Friend WithEvents btnMenu As Button
End Class
