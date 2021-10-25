<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Saludo = New System.Windows.Forms.Label()
        Me.BtnSaludo = New System.Windows.Forms.Button()
        Me.RbtDia = New System.Windows.Forms.RadioButton()
        Me.RbtTardes = New System.Windows.Forms.RadioButton()
        Me.RbtNoches = New System.Windows.Forms.RadioButton()
        Me.PnlRbt = New System.Windows.Forms.Panel()
        Me.RbtMedios = New System.Windows.Forms.RadioButton()
        Me.PnlNombre = New System.Windows.Forms.Panel()
        Me.RbtJose = New System.Windows.Forms.RadioButton()
        Me.RbtInes = New System.Windows.Forms.RadioButton()
        Me.RbtMaria = New System.Windows.Forms.RadioButton()
        Me.RbtJuan = New System.Windows.Forms.RadioButton()
        Me.PnlRbt.SuspendLayout()
        Me.PnlNombre.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Saludo
        '
        Me.Lbl_Saludo.AutoSize = True
        Me.Lbl_Saludo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Saludo.Location = New System.Drawing.Point(254, 96)
        Me.Lbl_Saludo.Name = "Lbl_Saludo"
        Me.Lbl_Saludo.Size = New System.Drawing.Size(58, 21)
        Me.Lbl_Saludo.TabIndex = 1
        Me.Lbl_Saludo.Text = "Saludo"
        '
        'BtnSaludo
        '
        Me.BtnSaludo.Location = New System.Drawing.Point(61, 189)
        Me.BtnSaludo.Name = "BtnSaludo"
        Me.BtnSaludo.Size = New System.Drawing.Size(95, 23)
        Me.BtnSaludo.TabIndex = 2
        Me.BtnSaludo.Tag = ""
        Me.BtnSaludo.Text = "Saludo"
        Me.BtnSaludo.UseVisualStyleBackColor = True
        '
        'RbtDia
        '
        Me.RbtDia.AutoSize = True
        Me.RbtDia.Checked = True
        Me.RbtDia.Location = New System.Drawing.Point(15, 18)
        Me.RbtDia.Name = "RbtDia"
        Me.RbtDia.Size = New System.Drawing.Size(47, 19)
        Me.RbtDia.TabIndex = 3
        Me.RbtDia.TabStop = True
        Me.RbtDia.Tag = "Buenos"
        Me.RbtDia.Text = "Días"
        Me.RbtDia.UseVisualStyleBackColor = True
        '
        'RbtTardes
        '
        Me.RbtTardes.AutoSize = True
        Me.RbtTardes.Location = New System.Drawing.Point(15, 69)
        Me.RbtTardes.Name = "RbtTardes"
        Me.RbtTardes.Size = New System.Drawing.Size(58, 19)
        Me.RbtTardes.TabIndex = 4
        Me.RbtTardes.Tag = "Buenas"
        Me.RbtTardes.Text = "Tardes"
        Me.RbtTardes.UseVisualStyleBackColor = True
        '
        'RbtNoches
        '
        Me.RbtNoches.AutoSize = True
        Me.RbtNoches.Location = New System.Drawing.Point(15, 96)
        Me.RbtNoches.Name = "RbtNoches"
        Me.RbtNoches.Size = New System.Drawing.Size(65, 19)
        Me.RbtNoches.TabIndex = 5
        Me.RbtNoches.Tag = "Buenas"
        Me.RbtNoches.Text = "Noches"
        Me.RbtNoches.UseVisualStyleBackColor = True
        '
        'PnlRbt
        '
        Me.PnlRbt.Controls.Add(Me.RbtDia)
        Me.PnlRbt.Controls.Add(Me.RbtNoches)
        Me.PnlRbt.Controls.Add(Me.RbtMedios)
        Me.PnlRbt.Controls.Add(Me.RbtTardes)
        Me.PnlRbt.Location = New System.Drawing.Point(58, 30)
        Me.PnlRbt.Name = "PnlRbt"
        Me.PnlRbt.Size = New System.Drawing.Size(108, 134)
        Me.PnlRbt.TabIndex = 6
        '
        'RbtMedios
        '
        Me.RbtMedios.AutoSize = True
        Me.RbtMedios.Location = New System.Drawing.Point(15, 43)
        Me.RbtMedios.Name = "RbtMedios"
        Me.RbtMedios.Size = New System.Drawing.Size(89, 19)
        Me.RbtMedios.TabIndex = 4
        Me.RbtMedios.Tag = "Buenos"
        Me.RbtMedios.Text = "Medios Días"
        Me.RbtMedios.UseVisualStyleBackColor = True
        '
        'PnlNombre
        '
        Me.PnlNombre.Controls.Add(Me.RbtJose)
        Me.PnlNombre.Controls.Add(Me.RbtInes)
        Me.PnlNombre.Controls.Add(Me.RbtMaria)
        Me.PnlNombre.Controls.Add(Me.RbtJuan)
        Me.PnlNombre.Location = New System.Drawing.Point(444, 30)
        Me.PnlNombre.Name = "PnlNombre"
        Me.PnlNombre.Size = New System.Drawing.Size(108, 134)
        Me.PnlNombre.TabIndex = 6
        '
        'RbtJose
        '
        Me.RbtJose.AutoSize = True
        Me.RbtJose.Checked = True
        Me.RbtJose.Location = New System.Drawing.Point(15, 18)
        Me.RbtJose.Name = "RbtJose"
        Me.RbtJose.Size = New System.Drawing.Size(47, 19)
        Me.RbtJose.TabIndex = 3
        Me.RbtJose.TabStop = True
        Me.RbtJose.Tag = ""
        Me.RbtJose.Text = "José"
        Me.RbtJose.UseVisualStyleBackColor = True
        '
        'RbtInes
        '
        Me.RbtInes.AutoSize = True
        Me.RbtInes.Location = New System.Drawing.Point(15, 96)
        Me.RbtInes.Name = "RbtInes"
        Me.RbtInes.Size = New System.Drawing.Size(46, 19)
        Me.RbtInes.TabIndex = 5
        Me.RbtInes.Tag = ""
        Me.RbtInes.Text = "Inés"
        Me.RbtInes.UseVisualStyleBackColor = True
        '
        'RbtMaria
        '
        Me.RbtMaria.AutoSize = True
        Me.RbtMaria.Location = New System.Drawing.Point(15, 43)
        Me.RbtMaria.Name = "RbtMaria"
        Me.RbtMaria.Size = New System.Drawing.Size(55, 19)
        Me.RbtMaria.TabIndex = 4
        Me.RbtMaria.Tag = ""
        Me.RbtMaria.Text = "María"
        Me.RbtMaria.UseVisualStyleBackColor = True
        '
        'RbtJuan
        '
        Me.RbtJuan.AutoSize = True
        Me.RbtJuan.Location = New System.Drawing.Point(15, 69)
        Me.RbtJuan.Name = "RbtJuan"
        Me.RbtJuan.Size = New System.Drawing.Size(49, 19)
        Me.RbtJuan.TabIndex = 4
        Me.RbtJuan.Tag = ""
        Me.RbtJuan.Text = "Juan"
        Me.RbtJuan.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PnlNombre)
        Me.Controls.Add(Me.PnlRbt)
        Me.Controls.Add(Me.BtnSaludo)
        Me.Controls.Add(Me.Lbl_Saludo)
        Me.Name = "Principal"
        Me.Text = "Saludo"
        Me.PnlRbt.ResumeLayout(False)
        Me.PnlRbt.PerformLayout()
        Me.PnlNombre.ResumeLayout(False)
        Me.PnlNombre.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Saludo As Label
    Friend WithEvents BtnSaludo As Button
    Friend WithEvents RbtDia As RadioButton
    Friend WithEvents RbtTardes As RadioButton
    Friend WithEvents RbtNoches As RadioButton
    Friend WithEvents PnlRbt As Panel
    Friend WithEvents RbtMedios As RadioButton
    Friend WithEvents PnlNombre As Panel
    Friend WithEvents RbtJose As RadioButton
    Friend WithEvents RbtInes As RadioButton
    Friend WithEvents RbtMaria As RadioButton
    Friend WithEvents RbtJuan As RadioButton
End Class
