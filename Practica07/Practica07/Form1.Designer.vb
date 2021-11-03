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
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.trckSize = New System.Windows.Forms.TrackBar()
        Me.cmbxFuentes = New System.Windows.Forms.ComboBox()
        Me.grbxEstilos = New System.Windows.Forms.GroupBox()
        Me.chbxNormal = New System.Windows.Forms.CheckBox()
        Me.pnlEstilos = New System.Windows.Forms.Panel()
        Me.chbxTachada = New System.Windows.Forms.CheckBox()
        Me.chbxSubrayada = New System.Windows.Forms.CheckBox()
        Me.chbxInclinada = New System.Windows.Forms.CheckBox()
        Me.chbxNegrita = New System.Windows.Forms.CheckBox()
        CType(Me.trckSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxEstilos.SuspendLayout()
        Me.pnlEstilos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Location = New System.Drawing.Point(619, 181)
        Me.lblSaludo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(37, 17)
        Me.lblSaludo.TabIndex = 0
        Me.lblSaludo.Text = "Hola"
        '
        'trckSize
        '
        Me.trckSize.Location = New System.Drawing.Point(525, 300)
        Me.trckSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.trckSize.Maximum = 50
        Me.trckSize.Minimum = 8
        Me.trckSize.Name = "trckSize"
        Me.trckSize.Size = New System.Drawing.Size(380, 56)
        Me.trckSize.TabIndex = 1
        Me.trckSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trckSize.Value = 8
        '
        'cmbxFuentes
        '
        Me.cmbxFuentes.FormattingEnabled = True
        Me.cmbxFuentes.Location = New System.Drawing.Point(525, 395)
        Me.cmbxFuentes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbxFuentes.Name = "cmbxFuentes"
        Me.cmbxFuentes.Size = New System.Drawing.Size(379, 24)
        Me.cmbxFuentes.TabIndex = 2
        '
        'grbxEstilos
        '
        Me.grbxEstilos.Controls.Add(Me.chbxNormal)
        Me.grbxEstilos.Controls.Add(Me.pnlEstilos)
        Me.grbxEstilos.Location = New System.Drawing.Point(183, 194)
        Me.grbxEstilos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbxEstilos.Name = "grbxEstilos"
        Me.grbxEstilos.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbxEstilos.Size = New System.Drawing.Size(164, 204)
        Me.grbxEstilos.TabIndex = 3
        Me.grbxEstilos.TabStop = False
        Me.grbxEstilos.Text = "Estilos"
        '
        'chbxNormal
        '
        Me.chbxNormal.AutoSize = True
        Me.chbxNormal.Checked = True
        Me.chbxNormal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbxNormal.Location = New System.Drawing.Point(13, 28)
        Me.chbxNormal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbxNormal.Name = "chbxNormal"
        Me.chbxNormal.Size = New System.Drawing.Size(75, 21)
        Me.chbxNormal.TabIndex = 1
        Me.chbxNormal.Text = "Normal"
        Me.chbxNormal.UseVisualStyleBackColor = True
        '
        'pnlEstilos
        '
        Me.pnlEstilos.Controls.Add(Me.chbxTachada)
        Me.pnlEstilos.Controls.Add(Me.chbxSubrayada)
        Me.pnlEstilos.Controls.Add(Me.chbxInclinada)
        Me.pnlEstilos.Controls.Add(Me.chbxNegrita)
        Me.pnlEstilos.Location = New System.Drawing.Point(8, 58)
        Me.pnlEstilos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlEstilos.Name = "pnlEstilos"
        Me.pnlEstilos.Size = New System.Drawing.Size(139, 124)
        Me.pnlEstilos.TabIndex = 0
        '
        'chbxTachada
        '
        Me.chbxTachada.AutoSize = True
        Me.chbxTachada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxTachada.Location = New System.Drawing.Point(5, 90)
        Me.chbxTachada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbxTachada.Name = "chbxTachada"
        Me.chbxTachada.Size = New System.Drawing.Size(86, 21)
        Me.chbxTachada.TabIndex = 0
        Me.chbxTachada.Text = "Tachada"
        Me.chbxTachada.UseVisualStyleBackColor = True
        '
        'chbxSubrayada
        '
        Me.chbxSubrayada.AutoSize = True
        Me.chbxSubrayada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxSubrayada.Location = New System.Drawing.Point(5, 62)
        Me.chbxSubrayada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbxSubrayada.Name = "chbxSubrayada"
        Me.chbxSubrayada.Size = New System.Drawing.Size(99, 21)
        Me.chbxSubrayada.TabIndex = 0
        Me.chbxSubrayada.Text = "Subrayada"
        Me.chbxSubrayada.UseVisualStyleBackColor = True
        '
        'chbxInclinada
        '
        Me.chbxInclinada.AutoSize = True
        Me.chbxInclinada.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxInclinada.Location = New System.Drawing.Point(5, 33)
        Me.chbxInclinada.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbxInclinada.Name = "chbxInclinada"
        Me.chbxInclinada.Size = New System.Drawing.Size(86, 21)
        Me.chbxInclinada.TabIndex = 0
        Me.chbxInclinada.Text = "Inclinada"
        Me.chbxInclinada.UseVisualStyleBackColor = True
        '
        'chbxNegrita
        '
        Me.chbxNegrita.AutoSize = True
        Me.chbxNegrita.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxNegrita.Location = New System.Drawing.Point(5, 5)
        Me.chbxNegrita.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbxNegrita.Name = "chbxNegrita"
        Me.chbxNegrita.Size = New System.Drawing.Size(83, 21)
        Me.chbxNegrita.TabIndex = 0
        Me.chbxNegrita.Text = "Negrita"
        Me.chbxNegrita.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.grbxEstilos)
        Me.Controls.Add(Me.cmbxFuentes)
        Me.Controls.Add(Me.trckSize)
        Me.Controls.Add(Me.lblSaludo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.trckSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxEstilos.ResumeLayout(False)
        Me.grbxEstilos.PerformLayout()
        Me.pnlEstilos.ResumeLayout(False)
        Me.pnlEstilos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaludo As Label
    Friend WithEvents trckSize As TrackBar
    Friend WithEvents cmbxFuentes As ComboBox
    Friend WithEvents grbxEstilos As GroupBox
    Friend WithEvents chbxNormal As CheckBox
    Friend WithEvents pnlEstilos As Panel
    Friend WithEvents chbxTachada As CheckBox
    Friend WithEvents chbxSubrayada As CheckBox
    Friend WithEvents chbxInclinada As CheckBox
    Friend WithEvents chbxNegrita As CheckBox
End Class
