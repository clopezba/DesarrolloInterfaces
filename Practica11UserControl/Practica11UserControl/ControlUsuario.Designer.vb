<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.MiLista = New System.Windows.Forms.ListBox()
        Me.MiTexto = New System.Windows.Forms.TextBox()
        Me.MiBoton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MiLista
        '
        Me.MiLista.FormattingEnabled = True
        Me.MiLista.Location = New System.Drawing.Point(17, 16)
        Me.MiLista.Name = "MiLista"
        Me.MiLista.Size = New System.Drawing.Size(120, 95)
        Me.MiLista.TabIndex = 0
        '
        'MiTexto
        '
        Me.MiTexto.Location = New System.Drawing.Point(17, 118)
        Me.MiTexto.Name = "MiTexto"
        Me.MiTexto.Size = New System.Drawing.Size(120, 20)
        Me.MiTexto.TabIndex = 1
        '
        'MiBoton
        '
        Me.MiBoton.Location = New System.Drawing.Point(17, 145)
        Me.MiBoton.Name = "MiBoton"
        Me.MiBoton.Size = New System.Drawing.Size(120, 23)
        Me.MiBoton.TabIndex = 2
        Me.MiBoton.Text = "Agregar"
        Me.MiBoton.UseVisualStyleBackColor = True
        '
        'ControlUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MiBoton)
        Me.Controls.Add(Me.MiTexto)
        Me.Controls.Add(Me.MiLista)
        Me.Name = "ControlUsuario"
        Me.Size = New System.Drawing.Size(152, 179)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MiLista As ListBox
    Friend WithEvents MiTexto As TextBox
    Friend WithEvents MiBoton As Button
End Class
