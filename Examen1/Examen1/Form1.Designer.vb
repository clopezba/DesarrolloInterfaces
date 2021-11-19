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
        Me.group = New System.Windows.Forms.GroupBox()
        Me.rdbtnNinguno = New System.Windows.Forms.RadioButton()
        Me.rdbtnMac = New System.Windows.Forms.RadioButton()
        Me.rdbtnLinux = New System.Windows.Forms.RadioButton()
        Me.rdbtnWindows = New System.Windows.Forms.RadioButton()
        Me.pnlChck = New System.Windows.Forms.Panel()
        Me.chckInstalar = New System.Windows.Forms.CheckBox()
        Me.chckRAM = New System.Windows.Forms.CheckBox()
        Me.chckGPU = New System.Windows.Forms.CheckBox()
        Me.chckProcesador = New System.Windows.Forms.CheckBox()
        Me.ltbxItems = New System.Windows.Forms.ListBox()
        Me.ltbxCompra = New System.Windows.Forms.ListBox()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.pnlRbtn = New System.Windows.Forms.Panel()
        Me.group.SuspendLayout()
        Me.pnlChck.SuspendLayout()
        Me.pnlRbtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'group
        '
        Me.group.Controls.Add(Me.pnlRbtn)
        Me.group.Controls.Add(Me.pnlChck)
        Me.group.Location = New System.Drawing.Point(28, 27)
        Me.group.Name = "group"
        Me.group.Size = New System.Drawing.Size(216, 406)
        Me.group.TabIndex = 0
        Me.group.TabStop = False
        Me.group.Text = "Grupo"
        '
        'rdbtnNinguno
        '
        Me.rdbtnNinguno.AutoSize = True
        Me.rdbtnNinguno.Location = New System.Drawing.Point(25, 129)
        Me.rdbtnNinguno.Name = "rdbtnNinguno"
        Me.rdbtnNinguno.Size = New System.Drawing.Size(87, 24)
        Me.rdbtnNinguno.TabIndex = 1
        Me.rdbtnNinguno.Text = "Ninguno"
        Me.rdbtnNinguno.UseVisualStyleBackColor = True
        '
        'rdbtnMac
        '
        Me.rdbtnMac.AutoSize = True
        Me.rdbtnMac.Location = New System.Drawing.Point(25, 85)
        Me.rdbtnMac.Name = "rdbtnMac"
        Me.rdbtnMac.Size = New System.Drawing.Size(58, 24)
        Me.rdbtnMac.TabIndex = 1
        Me.rdbtnMac.Text = "Mac"
        Me.rdbtnMac.UseVisualStyleBackColor = True
        '
        'rdbtnLinux
        '
        Me.rdbtnLinux.AutoSize = True
        Me.rdbtnLinux.Location = New System.Drawing.Point(25, 45)
        Me.rdbtnLinux.Name = "rdbtnLinux"
        Me.rdbtnLinux.Size = New System.Drawing.Size(64, 24)
        Me.rdbtnLinux.TabIndex = 1
        Me.rdbtnLinux.Text = "Linux"
        Me.rdbtnLinux.UseVisualStyleBackColor = True
        '
        'rdbtnWindows
        '
        Me.rdbtnWindows.AutoSize = True
        Me.rdbtnWindows.Location = New System.Drawing.Point(25, 3)
        Me.rdbtnWindows.Name = "rdbtnWindows"
        Me.rdbtnWindows.Size = New System.Drawing.Size(91, 24)
        Me.rdbtnWindows.TabIndex = 1
        Me.rdbtnWindows.Text = "Windows"
        Me.rdbtnWindows.UseVisualStyleBackColor = True
        '
        'pnlChck
        '
        Me.pnlChck.Controls.Add(Me.chckInstalar)
        Me.pnlChck.Controls.Add(Me.chckRAM)
        Me.pnlChck.Controls.Add(Me.chckGPU)
        Me.pnlChck.Controls.Add(Me.chckProcesador)
        Me.pnlChck.Location = New System.Drawing.Point(5, 213)
        Me.pnlChck.Name = "pnlChck"
        Me.pnlChck.Size = New System.Drawing.Size(205, 177)
        Me.pnlChck.TabIndex = 2
        '
        'chckInstalar
        '
        Me.chckInstalar.AutoSize = True
        Me.chckInstalar.Location = New System.Drawing.Point(21, 139)
        Me.chckInstalar.Name = "chckInstalar"
        Me.chckInstalar.Size = New System.Drawing.Size(117, 24)
        Me.chckInstalar.TabIndex = 0
        Me.chckInstalar.Tag = "60"
        Me.chckInstalar.Text = "Instalar (60€)"
        Me.chckInstalar.UseVisualStyleBackColor = True
        '
        'chckRAM
        '
        Me.chckRAM.AutoSize = True
        Me.chckRAM.Location = New System.Drawing.Point(21, 99)
        Me.chckRAM.Name = "chckRAM"
        Me.chckRAM.Size = New System.Drawing.Size(101, 24)
        Me.chckRAM.TabIndex = 0
        Me.chckRAM.Tag = "45"
        Me.chckRAM.Text = "RAM (45€)"
        Me.chckRAM.UseVisualStyleBackColor = True
        '
        'chckGPU
        '
        Me.chckGPU.AutoSize = True
        Me.chckGPU.Location = New System.Drawing.Point(21, 54)
        Me.chckGPU.Name = "chckGPU"
        Me.chckGPU.Size = New System.Drawing.Size(97, 24)
        Me.chckGPU.TabIndex = 0
        Me.chckGPU.Tag = "50"
        Me.chckGPU.Text = "GPU (50€)"
        Me.chckGPU.UseVisualStyleBackColor = True
        '
        'chckProcesador
        '
        Me.chckProcesador.AutoSize = True
        Me.chckProcesador.Location = New System.Drawing.Point(21, 14)
        Me.chckProcesador.Name = "chckProcesador"
        Me.chckProcesador.Size = New System.Drawing.Size(143, 24)
        Me.chckProcesador.TabIndex = 0
        Me.chckProcesador.Tag = "20"
        Me.chckProcesador.Text = "Procesador (20€)"
        Me.chckProcesador.UseVisualStyleBackColor = True
        '
        'ltbxItems
        '
        Me.ltbxItems.FormattingEnabled = True
        Me.ltbxItems.ItemHeight = 20
        Me.ltbxItems.Location = New System.Drawing.Point(297, 60)
        Me.ltbxItems.Name = "ltbxItems"
        Me.ltbxItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ltbxItems.Size = New System.Drawing.Size(206, 284)
        Me.ltbxItems.TabIndex = 3
        '
        'ltbxCompra
        '
        Me.ltbxCompra.FormattingEnabled = True
        Me.ltbxCompra.ItemHeight = 20
        Me.ltbxCompra.Location = New System.Drawing.Point(623, 60)
        Me.ltbxCompra.Name = "ltbxCompra"
        Me.ltbxCompra.Size = New System.Drawing.Size(206, 284)
        Me.ltbxCompra.TabIndex = 3
        '
        'txtOtro
        '
        Me.txtOtro.Location = New System.Drawing.Point(297, 374)
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(145, 27)
        Me.txtOtro.TabIndex = 4
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(462, 374)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(41, 27)
        Me.txtPrecio.TabIndex = 5
        '
        'btnSumar
        '
        Me.btnSumar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSumar.Location = New System.Drawing.Point(554, 60)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(37, 284)
        Me.btnSumar.TabIndex = 6
        Me.btnSumar.Text = "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ñ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(623, 366)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(206, 27)
        Me.txtTotal.TabIndex = 7
        '
        'pnlRbtn
        '
        Me.pnlRbtn.Controls.Add(Me.rdbtnNinguno)
        Me.pnlRbtn.Controls.Add(Me.rdbtnWindows)
        Me.pnlRbtn.Controls.Add(Me.rdbtnMac)
        Me.pnlRbtn.Controls.Add(Me.rdbtnLinux)
        Me.pnlRbtn.Location = New System.Drawing.Point(5, 33)
        Me.pnlRbtn.Name = "pnlRbtn"
        Me.pnlRbtn.Size = New System.Drawing.Size(205, 174)
        Me.pnlRbtn.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 529)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtOtro)
        Me.Controls.Add(Me.ltbxCompra)
        Me.Controls.Add(Me.ltbxItems)
        Me.Controls.Add(Me.group)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.group.ResumeLayout(False)
        Me.pnlChck.ResumeLayout(False)
        Me.pnlChck.PerformLayout()
        Me.pnlRbtn.ResumeLayout(False)
        Me.pnlRbtn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents group As GroupBox
    Friend WithEvents rdbtnNinguno As RadioButton
    Friend WithEvents rdbtnMac As RadioButton
    Friend WithEvents rdbtnLinux As RadioButton
    Friend WithEvents rdbtnWindows As RadioButton
    Friend WithEvents pnlChck As Panel
    Friend WithEvents chckInstalar As CheckBox
    Friend WithEvents chckRAM As CheckBox
    Friend WithEvents chckGPU As CheckBox
    Friend WithEvents chckProcesador As CheckBox
    Friend WithEvents ltbxItems As ListBox
    Friend WithEvents ltbxCompra As ListBox
    Friend WithEvents txtOtro As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnSumar As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents pnlRbtn As Panel
End Class
