<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSaludo = New System.Windows.Forms.Label()
        Me.cmbxFuentes = New System.Windows.Forms.ComboBox()
        Me.trckSize = New System.Windows.Forms.TrackBar()
        CType(Me.trckSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSaludo
        '
        Me.lblSaludo.AutoSize = True
        Me.lblSaludo.Location = New System.Drawing.Point(149, 64)
        Me.lblSaludo.Name = "lblSaludo"
        Me.lblSaludo.Size = New System.Drawing.Size(32, 15)
        Me.lblSaludo.TabIndex = 0
        Me.lblSaludo.Text = "Hola"
        '
        'cmbxFuentes
        '
        Me.cmbxFuentes.FormattingEnabled = True
        Me.cmbxFuentes.Location = New System.Drawing.Point(149, 222)
        Me.cmbxFuentes.Name = "cmbxFuentes"
        Me.cmbxFuentes.Size = New System.Drawing.Size(198, 23)
        Me.cmbxFuentes.TabIndex = 1
        '
        'trckSize
        '
        Me.trckSize.Location = New System.Drawing.Point(126, 152)
        Me.trckSize.Maximum = 50
        Me.trckSize.Minimum = 8
        Me.trckSize.Name = "trckSize"
        Me.trckSize.Size = New System.Drawing.Size(248, 45)
        Me.trckSize.TabIndex = 2
        Me.trckSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trckSize.Value = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.trckSize)
        Me.Controls.Add(Me.cmbxFuentes)
        Me.Controls.Add(Me.lblSaludo)
        Me.HelpButton = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.trckSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSaludo As Label
    Friend WithEvents cmbxFuentes As ComboBox
    Friend WithEvents trckSize As TrackBar
End Class
