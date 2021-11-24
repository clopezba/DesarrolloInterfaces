<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CNombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CApellidos = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CFecha = New System.Windows.Forms.TextBox
        Me.BPrimero = New System.Windows.Forms.Button
        Me.BSiguiente = New System.Windows.Forms.Button
        Me.BAnterior = New System.Windows.Forms.Button
        Me.BUltimo = New System.Windows.Forms.Button
        Me.LREG = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lectura de fichero Secuencial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'CNombre
        '
        Me.CNombre.Location = New System.Drawing.Point(166, 88)
        Me.CNombre.Name = "CNombre"
        Me.CNombre.Size = New System.Drawing.Size(121, 20)
        Me.CNombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellidos"
        '
        'CApellidos
        '
        Me.CApellidos.Location = New System.Drawing.Point(166, 130)
        Me.CApellidos.Name = "CApellidos"
        Me.CApellidos.Size = New System.Drawing.Size(233, 20)
        Me.CApellidos.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha Nacimiento"
        '
        'CFecha
        '
        Me.CFecha.Location = New System.Drawing.Point(166, 169)
        Me.CFecha.Name = "CFecha"
        Me.CFecha.Size = New System.Drawing.Size(99, 20)
        Me.CFecha.TabIndex = 2
        '
        'BPrimero
        '
        Me.BPrimero.Location = New System.Drawing.Point(62, 215)
        Me.BPrimero.Name = "BPrimero"
        Me.BPrimero.Size = New System.Drawing.Size(88, 35)
        Me.BPrimero.TabIndex = 3
        Me.BPrimero.Text = "&Primero"
        Me.BPrimero.UseVisualStyleBackColor = True
        '
        'BSiguiente
        '
        Me.BSiguiente.Location = New System.Drawing.Point(166, 215)
        Me.BSiguiente.Name = "BSiguiente"
        Me.BSiguiente.Size = New System.Drawing.Size(88, 35)
        Me.BSiguiente.TabIndex = 3
        Me.BSiguiente.Text = "&Siguiente"
        Me.BSiguiente.UseVisualStyleBackColor = True
        '
        'BAnterior
        '
        Me.BAnterior.Location = New System.Drawing.Point(269, 215)
        Me.BAnterior.Name = "BAnterior"
        Me.BAnterior.Size = New System.Drawing.Size(88, 35)
        Me.BAnterior.TabIndex = 3
        Me.BAnterior.Text = "&Anterior"
        Me.BAnterior.UseVisualStyleBackColor = True
        '
        'BUltimo
        '
        Me.BUltimo.Location = New System.Drawing.Point(385, 215)
        Me.BUltimo.Name = "BUltimo"
        Me.BUltimo.Size = New System.Drawing.Size(88, 35)
        Me.BUltimo.TabIndex = 3
        Me.BUltimo.Text = "&Último"
        Me.BUltimo.UseVisualStyleBackColor = True
        '
        'LREG
        '
        Me.LREG.AutoSize = True
        Me.LREG.Location = New System.Drawing.Point(446, 33)
        Me.LREG.Name = "LREG"
        Me.LREG.Size = New System.Drawing.Size(0, 13)
        Me.LREG.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 278)
        Me.Controls.Add(Me.LREG)
        Me.Controls.Add(Me.BUltimo)
        Me.Controls.Add(Me.BAnterior)
        Me.Controls.Add(Me.BSiguiente)
        Me.Controls.Add(Me.BPrimero)
        Me.Controls.Add(Me.CFecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CApellidos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Secuenciales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CApellidos As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CFecha As System.Windows.Forms.TextBox
    Friend WithEvents BPrimero As System.Windows.Forms.Button
    Friend WithEvents BSiguiente As System.Windows.Forms.Button
    Friend WithEvents BAnterior As System.Windows.Forms.Button
    Friend WithEvents BUltimo As System.Windows.Forms.Button
    Friend WithEvents LREG As System.Windows.Forms.Label

End Class
