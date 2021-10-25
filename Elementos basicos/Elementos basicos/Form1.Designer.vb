<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaP
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
        Me.Btn_1 = New System.Windows.Forms.Button()
        Me.Btn_2 = New System.Windows.Forms.Button()
        Me.Lbl_1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_1
        '
        Me.Btn_1.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_1.Location = New System.Drawing.Point(283, 117)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Size = New System.Drawing.Size(125, 23)
        Me.Btn_1.TabIndex = 0
        Me.Btn_1.Text = "Hola buenos días"
        Me.Btn_1.UseVisualStyleBackColor = False
        '
        'Btn_2
        '
        Me.Btn_2.BackColor = System.Drawing.SystemColors.Control
        Me.Btn_2.Location = New System.Drawing.Point(283, 146)
        Me.Btn_2.Name = "Btn_2"
        Me.Btn_2.Size = New System.Drawing.Size(125, 23)
        Me.Btn_2.TabIndex = 1
        Me.Btn_2.Text = "Hola buenas tardes"
        Me.Btn_2.UseVisualStyleBackColor = False
        '
        'Lbl_1
        '
        Me.Lbl_1.AutoSize = True
        Me.Lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_1.Location = New System.Drawing.Point(292, 86)
        Me.Lbl_1.Name = "Lbl_1"
        Me.Lbl_1.Size = New System.Drawing.Size(120, 15)
        Me.Lbl_1.TabIndex = 2
        Me.Lbl_1.Text = "Hola buenas noches"
        '
        'VentanaP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 322)
        Me.Controls.Add(Me.Lbl_1)
        Me.Controls.Add(Me.Btn_2)
        Me.Controls.Add(Me.Btn_1)
        Me.Name = "VentanaP"
        Me.Text = "Ventana Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_1 As Button
    Friend WithEvents Btn_2 As Button
    Friend WithEvents Lbl_1 As Label
End Class
