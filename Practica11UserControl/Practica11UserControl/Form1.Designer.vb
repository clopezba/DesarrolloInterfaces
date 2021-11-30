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
        Me.ControlUsuario1 = New Practica11UserControl.ControlUsuario()
        Me.ControlUsuario2 = New Practica11UserControl.ControlUsuario()
        Me.SuspendLayout()
        '
        'ControlUsuario1
        '
        Me.ControlUsuario1.Location = New System.Drawing.Point(56, 37)
        Me.ControlUsuario1.Margin = New System.Windows.Forms.Padding(4)
        Me.ControlUsuario1.Name = "ControlUsuario1"
        Me.ControlUsuario1.Size = New System.Drawing.Size(214, 283)
        Me.ControlUsuario1.TabIndex = 0
        Me.ControlUsuario1.TextoInicial = "Ejemplo"
        '
        'ControlUsuario2
        '
        Me.ControlUsuario2.Location = New System.Drawing.Point(345, 37)
        Me.ControlUsuario2.Margin = New System.Windows.Forms.Padding(4)
        Me.ControlUsuario2.Name = "ControlUsuario2"
        Me.ControlUsuario2.Size = New System.Drawing.Size(214, 283)
        Me.ControlUsuario2.TabIndex = 0
        Me.ControlUsuario2.TextoInicial = "Ejemplo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.ControlUsuario2)
        Me.Controls.Add(Me.ControlUsuario1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlUsuario1 As ControlUsuario
    Friend WithEvents ControlUsuario2 As ControlUsuario
End Class
