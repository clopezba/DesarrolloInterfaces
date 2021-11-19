<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicios))
        Me.grSoftware = New System.Windows.Forms.GroupBox()
        Me.lblSoft = New System.Windows.Forms.Label()
        Me.lblSO = New System.Windows.Forms.Label()
        Me.pnlChck = New System.Windows.Forms.Panel()
        Me.chckNet = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.chckDream = New System.Windows.Forms.CheckBox()
        Me.chckAndroid = New System.Windows.Forms.CheckBox()
        Me.chckVisual = New System.Windows.Forms.CheckBox()
        Me.chckEclipse = New System.Windows.Forms.CheckBox()
        Me.pnlRbtn = New System.Windows.Forms.Panel()
        Me.rbtnNinguno = New System.Windows.Forms.RadioButton()
        Me.rbtnChrome = New System.Windows.Forms.RadioButton()
        Me.rbtnMac = New System.Windows.Forms.RadioButton()
        Me.rbtnUbuntu = New System.Windows.Forms.RadioButton()
        Me.rbtnWindows = New System.Windows.Forms.RadioButton()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.rtbResumen = New System.Windows.Forms.RichTextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.Btn_AgregaSW = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtb_swExtra = New System.Windows.Forms.TextBox()
        Me.Ltbx_Apli = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grSoftware.SuspendLayout()
        Me.pnlChck.SuspendLayout()
        Me.pnlRbtn.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grSoftware
        '
        Me.grSoftware.Controls.Add(Me.lblSoft)
        Me.grSoftware.Controls.Add(Me.lblSO)
        Me.grSoftware.Controls.Add(Me.pnlChck)
        Me.grSoftware.Controls.Add(Me.pnlRbtn)
        Me.grSoftware.Location = New System.Drawing.Point(27, 102)
        Me.grSoftware.Name = "grSoftware"
        Me.grSoftware.Size = New System.Drawing.Size(223, 308)
        Me.grSoftware.TabIndex = 0
        Me.grSoftware.TabStop = False
        Me.grSoftware.Text = "Software básico"
        '
        'lblSoft
        '
        Me.lblSoft.AutoSize = True
        Me.lblSoft.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSoft.Location = New System.Drawing.Point(65, 168)
        Me.lblSoft.Name = "lblSoft"
        Me.lblSoft.Size = New System.Drawing.Size(85, 13)
        Me.lblSoft.TabIndex = 3
        Me.lblSoft.Text = "Sw de desarrollo"
        '
        'lblSO
        '
        Me.lblSO.AutoSize = True
        Me.lblSO.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSO.Location = New System.Drawing.Point(65, 27)
        Me.lblSO.Name = "lblSO"
        Me.lblSO.Size = New System.Drawing.Size(93, 13)
        Me.lblSO.TabIndex = 3
        Me.lblSO.Text = "Sistema Operativo"
        '
        'pnlChck
        '
        Me.pnlChck.Controls.Add(Me.chckNet)
        Me.pnlChck.Controls.Add(Me.CheckBox5)
        Me.pnlChck.Controls.Add(Me.chckDream)
        Me.pnlChck.Controls.Add(Me.chckAndroid)
        Me.pnlChck.Controls.Add(Me.chckVisual)
        Me.pnlChck.Controls.Add(Me.chckEclipse)
        Me.pnlChck.Location = New System.Drawing.Point(17, 184)
        Me.pnlChck.Name = "pnlChck"
        Me.pnlChck.Size = New System.Drawing.Size(200, 118)
        Me.pnlChck.TabIndex = 2
        '
        'chckNet
        '
        Me.chckNet.AutoSize = True
        Me.chckNet.Location = New System.Drawing.Point(16, 95)
        Me.chckNet.Name = "chckNet"
        Me.chckNet.Size = New System.Drawing.Size(100, 17)
        Me.chckNet.TabIndex = 0
        Me.chckNet.Tag = "10"
        Me.chckNet.Text = "NetBeans (10€)"
        Me.chckNet.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(16, 98)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.Text = "CheckBox1"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'chckDream
        '
        Me.chckDream.AutoSize = True
        Me.chckDream.Location = New System.Drawing.Point(16, 72)
        Me.chckDream.Name = "chckDream"
        Me.chckDream.Size = New System.Drawing.Size(125, 17)
        Me.chckDream.TabIndex = 0
        Me.chckDream.Tag = "200"
        Me.chckDream.Text = "Dreamweaver (200€)"
        Me.chckDream.UseVisualStyleBackColor = True
        '
        'chckAndroid
        '
        Me.chckAndroid.AutoSize = True
        Me.chckAndroid.Location = New System.Drawing.Point(16, 49)
        Me.chckAndroid.Name = "chckAndroid"
        Me.chckAndroid.Size = New System.Drawing.Size(122, 17)
        Me.chckAndroid.TabIndex = 0
        Me.chckAndroid.Tag = "20"
        Me.chckAndroid.Text = "Android Studio (20€)"
        Me.chckAndroid.UseVisualStyleBackColor = True
        '
        'chckVisual
        '
        Me.chckVisual.AutoSize = True
        Me.chckVisual.Location = New System.Drawing.Point(16, 27)
        Me.chckVisual.Name = "chckVisual"
        Me.chckVisual.Size = New System.Drawing.Size(120, 17)
        Me.chckVisual.TabIndex = 0
        Me.chckVisual.Tag = "400"
        Me.chckVisual.Text = "Visual Studio (400€)"
        Me.chckVisual.UseVisualStyleBackColor = True
        '
        'chckEclipse
        '
        Me.chckEclipse.AutoSize = True
        Me.chckEclipse.Location = New System.Drawing.Point(16, 4)
        Me.chckEclipse.Name = "chckEclipse"
        Me.chckEclipse.Size = New System.Drawing.Size(87, 17)
        Me.chckEclipse.TabIndex = 0
        Me.chckEclipse.Tag = "20"
        Me.chckEclipse.Text = "Eclipse (20€)"
        Me.chckEclipse.UseVisualStyleBackColor = True
        '
        'pnlRbtn
        '
        Me.pnlRbtn.Controls.Add(Me.rbtnNinguno)
        Me.pnlRbtn.Controls.Add(Me.rbtnChrome)
        Me.pnlRbtn.Controls.Add(Me.rbtnMac)
        Me.pnlRbtn.Controls.Add(Me.rbtnUbuntu)
        Me.pnlRbtn.Controls.Add(Me.rbtnWindows)
        Me.pnlRbtn.Location = New System.Drawing.Point(17, 43)
        Me.pnlRbtn.Name = "pnlRbtn"
        Me.pnlRbtn.Size = New System.Drawing.Size(200, 111)
        Me.pnlRbtn.TabIndex = 1
        '
        'rbtnNinguno
        '
        Me.rbtnNinguno.AutoSize = True
        Me.rbtnNinguno.Checked = True
        Me.rbtnNinguno.Location = New System.Drawing.Point(16, 91)
        Me.rbtnNinguno.Name = "rbtnNinguno"
        Me.rbtnNinguno.Size = New System.Drawing.Size(65, 17)
        Me.rbtnNinguno.TabIndex = 0
        Me.rbtnNinguno.TabStop = True
        Me.rbtnNinguno.Text = "Ninguno"
        Me.rbtnNinguno.UseVisualStyleBackColor = True
        '
        'rbtnChrome
        '
        Me.rbtnChrome.AutoSize = True
        Me.rbtnChrome.Location = New System.Drawing.Point(16, 72)
        Me.rbtnChrome.Name = "rbtnChrome"
        Me.rbtnChrome.Size = New System.Drawing.Size(149, 17)
        Me.rbtnChrome.TabIndex = 0
        Me.rbtnChrome.Tag = "0"
        Me.rbtnChrome.Text = "Android Chrome Book (0€)"
        Me.rbtnChrome.UseVisualStyleBackColor = True
        '
        'rbtnMac
        '
        Me.rbtnMac.AutoSize = True
        Me.rbtnMac.Location = New System.Drawing.Point(16, 49)
        Me.rbtnMac.Name = "rbtnMac"
        Me.rbtnMac.Size = New System.Drawing.Size(92, 17)
        Me.rbtnMac.TabIndex = 0
        Me.rbtnMac.Tag = "150"
        Me.rbtnMac.Text = "MC OS (150€)"
        Me.rbtnMac.UseVisualStyleBackColor = True
        '
        'rbtnUbuntu
        '
        Me.rbtnUbuntu.AutoSize = True
        Me.rbtnUbuntu.Location = New System.Drawing.Point(16, 27)
        Me.rbtnUbuntu.Name = "rbtnUbuntu"
        Me.rbtnUbuntu.Size = New System.Drawing.Size(87, 17)
        Me.rbtnUbuntu.TabIndex = 0
        Me.rbtnUbuntu.Tag = "20"
        Me.rbtnUbuntu.Text = "Ubuntu (20€)"
        Me.rbtnUbuntu.UseVisualStyleBackColor = True
        '
        'rbtnWindows
        '
        Me.rbtnWindows.AutoSize = True
        Me.rbtnWindows.Location = New System.Drawing.Point(16, 4)
        Me.rbtnWindows.Name = "rbtnWindows"
        Me.rbtnWindows.Size = New System.Drawing.Size(102, 17)
        Me.rbtnWindows.TabIndex = 0
        Me.rbtnWindows.Tag = "100"
        Me.rbtnWindows.Text = "Windows (100€)"
        Me.rbtnWindows.UseVisualStyleBackColor = True
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.txtTotal)
        Me.pnlDatos.Controls.Add(Me.lblResumen)
        Me.pnlDatos.Controls.Add(Me.lblApp)
        Me.pnlDatos.Controls.Add(Me.lblTotal)
        Me.pnlDatos.Controls.Add(Me.rtbResumen)
        Me.pnlDatos.Controls.Add(Me.btnSumar)
        Me.pnlDatos.Controls.Add(Me.Btn_AgregaSW)
        Me.pnlDatos.Controls.Add(Me.txtPrecio)
        Me.pnlDatos.Controls.Add(Me.txtb_swExtra)
        Me.pnlDatos.Controls.Add(Me.Ltbx_Apli)
        Me.pnlDatos.Location = New System.Drawing.Point(268, 66)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(505, 359)
        Me.pnlDatos.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(294, 282)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(159, 29)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.ForeColor = System.Drawing.Color.Blue
        Me.lblResumen.Location = New System.Drawing.Point(250, 10)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(179, 13)
        Me.lblResumen.TabIndex = 6
        Me.lblResumen.Text = "Resumen de servicios de instalación"
        '
        'lblApp
        '
        Me.lblApp.AutoSize = True
        Me.lblApp.ForeColor = System.Drawing.Color.Blue
        Me.lblApp.Location = New System.Drawing.Point(17, 10)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(121, 13)
        Me.lblApp.TabIndex = 6
        Me.lblApp.Text = "Aplicaciones de Usuario"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(229, 289)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 20)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total €"
        '
        'rtbResumen
        '
        Me.rtbResumen.Location = New System.Drawing.Point(253, 36)
        Me.rtbResumen.Name = "rtbResumen"
        Me.rtbResumen.Size = New System.Drawing.Size(201, 238)
        Me.rtbResumen.TabIndex = 4
        Me.rtbResumen.Text = ""
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(215, 36)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(22, 238)
        Me.btnSumar.TabIndex = 3
        Me.btnSumar.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "r" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "v" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "c" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'Btn_AgregaSW
        '
        Me.Btn_AgregaSW.Location = New System.Drawing.Point(20, 318)
        Me.Btn_AgregaSW.Name = "Btn_AgregaSW"
        Me.Btn_AgregaSW.Size = New System.Drawing.Size(164, 20)
        Me.Btn_AgregaSW.TabIndex = 2
        Me.Btn_AgregaSW.Text = "Añadir SW Extra"
        Me.Btn_AgregaSW.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(158, 282)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(42, 29)
        Me.txtPrecio.TabIndex = 1
        Me.txtPrecio.Text = "0"
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtb_swExtra
        '
        Me.txtb_swExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_swExtra.Location = New System.Drawing.Point(20, 282)
        Me.txtb_swExtra.Name = "txtb_swExtra"
        Me.txtb_swExtra.Size = New System.Drawing.Size(132, 29)
        Me.txtb_swExtra.TabIndex = 1
        '
        'Ltbx_Apli
        '
        Me.Ltbx_Apli.FormattingEnabled = True
        Me.Ltbx_Apli.Items.AddRange(New Object() {"Office 365 (200€)", "Adobe Reader (50€)", "Compresor RAR (20€)", "Avast Antivirus (80€)"})
        Me.Ltbx_Apli.Location = New System.Drawing.Point(20, 36)
        Me.Ltbx_Apli.Name = "Ltbx_Apli"
        Me.Ltbx_Apli.Size = New System.Drawing.Size(180, 238)
        Me.Ltbx_Apli.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label1.Location = New System.Drawing.Point(108, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Configuración del Software del Dispositivo"
        '
        'Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlDatos)
        Me.Controls.Add(Me.grSoftware)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Servicios"
        Me.Text = "Simulación de costes por servicios de instalación"
        Me.grSoftware.ResumeLayout(False)
        Me.grSoftware.PerformLayout()
        Me.pnlChck.ResumeLayout(False)
        Me.pnlChck.PerformLayout()
        Me.pnlRbtn.ResumeLayout(False)
        Me.pnlRbtn.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grSoftware As GroupBox
    Friend WithEvents lblSoft As Label
    Friend WithEvents lblSO As Label
    Friend WithEvents pnlChck As Panel
    Friend WithEvents chckNet As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents chckDream As CheckBox
    Friend WithEvents chckAndroid As CheckBox
    Friend WithEvents chckVisual As CheckBox
    Friend WithEvents chckEclipse As CheckBox
    Friend WithEvents pnlRbtn As Panel
    Friend WithEvents rbtnNinguno As RadioButton
    Friend WithEvents rbtnChrome As RadioButton
    Friend WithEvents rbtnMac As RadioButton
    Friend WithEvents rbtnUbuntu As RadioButton
    Friend WithEvents rbtnWindows As RadioButton
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents rtbResumen As RichTextBox
    Friend WithEvents btnSumar As Button
    Friend WithEvents Btn_AgregaSW As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtb_swExtra As TextBox
    Friend WithEvents Ltbx_Apli As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApp As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblResumen As Label
End Class
