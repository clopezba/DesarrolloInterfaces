<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalTecnoHuesca
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
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.btnNuevoReg = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.UT4_2Registro.My.Resources.Resources.logo
        Me.imgLogo.Location = New System.Drawing.Point(93, 28)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(90, 86)
        Me.imgLogo.TabIndex = 0
        Me.imgLogo.TabStop = False
        '
        'btnNuevoReg
        '
        Me.btnNuevoReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoReg.Location = New System.Drawing.Point(79, 166)
        Me.btnNuevoReg.Name = "btnNuevoReg"
        Me.btnNuevoReg.Size = New System.Drawing.Size(122, 28)
        Me.btnNuevoReg.TabIndex = 1
        Me.btnNuevoReg.Text = "Nuevo registro"
        Me.btnNuevoReg.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.Location = New System.Drawing.Point(79, 215)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(122, 28)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "Ver personal"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'PersonalTecnoHuesca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 292)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnNuevoReg)
        Me.Controls.Add(Me.imgLogo)
        Me.Name = "PersonalTecnoHuesca"
        Me.Text = "Personal de TecnoHuesca"
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnNuevoReg As Button
    Friend WithEvents btnVer As Button
End Class
