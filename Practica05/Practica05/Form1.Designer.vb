<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ltbxIzq = New System.Windows.Forms.ListBox()
        Me.txtIzq = New System.Windows.Forms.TextBox()
        Me.btnBorr_lisIzq = New System.Windows.Forms.Button()
        Me.ltbxCentro = New System.Windows.Forms.ListBox()
        Me.txtCentro = New System.Windows.Forms.TextBox()
        Me.btnBorr_lisCentro = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnRecibir = New System.Windows.Forms.Button()
        Me.ltbxDcha = New System.Windows.Forms.ListBox()
        Me.txtDcha = New System.Windows.Forms.TextBox()
        Me.btnBorr_lisDcha = New System.Windows.Forms.Button()
        Me.btnEnviar2 = New System.Windows.Forms.Button()
        Me.btnRecibir2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltbxIzq
        '
        Me.ltbxIzq.AllowDrop = True
        Me.ltbxIzq.FormattingEnabled = True
        Me.ltbxIzq.ItemHeight = 15
        Me.ltbxIzq.Items.AddRange(New Object() {"Ford", "Mazda", "Seat", "Audi", "Mercedes"})
        Me.ltbxIzq.Location = New System.Drawing.Point(70, 84)
        Me.ltbxIzq.Name = "ltbxIzq"
        Me.ltbxIzq.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbxIzq.Size = New System.Drawing.Size(117, 169)
        Me.ltbxIzq.TabIndex = 0
        '
        'txtIzq
        '
        Me.txtIzq.Location = New System.Drawing.Point(70, 274)
        Me.txtIzq.Name = "txtIzq"
        Me.txtIzq.Size = New System.Drawing.Size(117, 23)
        Me.txtIzq.TabIndex = 1
        '
        'btnBorr_lisIzq
        '
        Me.btnBorr_lisIzq.Location = New System.Drawing.Point(70, 48)
        Me.btnBorr_lisIzq.Name = "btnBorr_lisIzq"
        Me.btnBorr_lisIzq.Size = New System.Drawing.Size(117, 23)
        Me.btnBorr_lisIzq.TabIndex = 2
        Me.btnBorr_lisIzq.Text = "Borrar lista"
        Me.btnBorr_lisIzq.UseVisualStyleBackColor = True
        '
        'ltbxCentro
        '
        Me.ltbxCentro.AllowDrop = True
        Me.ltbxCentro.FormattingEnabled = True
        Me.ltbxCentro.ItemHeight = 15
        Me.ltbxCentro.Location = New System.Drawing.Point(302, 84)
        Me.ltbxCentro.Name = "ltbxCentro"
        Me.ltbxCentro.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbxCentro.Size = New System.Drawing.Size(117, 169)
        Me.ltbxCentro.TabIndex = 0
        '
        'txtCentro
        '
        Me.txtCentro.Location = New System.Drawing.Point(302, 274)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.Size = New System.Drawing.Size(117, 23)
        Me.txtCentro.TabIndex = 1
        '
        'btnBorr_lisCentro
        '
        Me.btnBorr_lisCentro.Location = New System.Drawing.Point(302, 48)
        Me.btnBorr_lisCentro.Name = "btnBorr_lisCentro"
        Me.btnBorr_lisCentro.Size = New System.Drawing.Size(117, 23)
        Me.btnBorr_lisCentro.TabIndex = 2
        Me.btnBorr_lisCentro.Text = "Borrar lista"
        Me.btnBorr_lisCentro.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(228, 114)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(38, 23)
        Me.btnEnviar.TabIndex = 3
        Me.btnEnviar.Text = ">>"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnRecibir
        '
        Me.btnRecibir.Location = New System.Drawing.Point(228, 171)
        Me.btnRecibir.Name = "btnRecibir"
        Me.btnRecibir.Size = New System.Drawing.Size(38, 23)
        Me.btnRecibir.TabIndex = 3
        Me.btnRecibir.Text = "<<"
        Me.btnRecibir.UseVisualStyleBackColor = True
        '
        'ltbxDcha
        '
        Me.ltbxDcha.AllowDrop = True
        Me.ltbxDcha.FormattingEnabled = True
        Me.ltbxDcha.ItemHeight = 15
        Me.ltbxDcha.Location = New System.Drawing.Point(537, 84)
        Me.ltbxDcha.Name = "ltbxDcha"
        Me.ltbxDcha.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ltbxDcha.Size = New System.Drawing.Size(117, 169)
        Me.ltbxDcha.TabIndex = 0
        '
        'txtDcha
        '
        Me.txtDcha.Location = New System.Drawing.Point(537, 274)
        Me.txtDcha.Name = "txtDcha"
        Me.txtDcha.Size = New System.Drawing.Size(117, 23)
        Me.txtDcha.TabIndex = 1
        '
        'btnBorr_lisDcha
        '
        Me.btnBorr_lisDcha.Location = New System.Drawing.Point(537, 48)
        Me.btnBorr_lisDcha.Name = "btnBorr_lisDcha"
        Me.btnBorr_lisDcha.Size = New System.Drawing.Size(117, 23)
        Me.btnBorr_lisDcha.TabIndex = 2
        Me.btnBorr_lisDcha.Text = "Borrar lista"
        Me.btnBorr_lisDcha.UseVisualStyleBackColor = True
        '
        'btnEnviar2
        '
        Me.btnEnviar2.Location = New System.Drawing.Point(463, 114)
        Me.btnEnviar2.Name = "btnEnviar2"
        Me.btnEnviar2.Size = New System.Drawing.Size(38, 23)
        Me.btnEnviar2.TabIndex = 3
        Me.btnEnviar2.Text = ">>"
        Me.btnEnviar2.UseVisualStyleBackColor = True
        '
        'btnRecibir2
        '
        Me.btnRecibir2.Location = New System.Drawing.Point(463, 171)
        Me.btnRecibir2.Name = "btnRecibir2"
        Me.btnRecibir2.Size = New System.Drawing.Size(38, 23)
        Me.btnRecibir2.TabIndex = 3
        Me.btnRecibir2.Text = "<<"
        Me.btnRecibir2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRecibir2)
        Me.Controls.Add(Me.btnRecibir)
        Me.Controls.Add(Me.btnEnviar2)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.btnBorr_lisDcha)
        Me.Controls.Add(Me.btnBorr_lisCentro)
        Me.Controls.Add(Me.txtDcha)
        Me.Controls.Add(Me.txtCentro)
        Me.Controls.Add(Me.btnBorr_lisIzq)
        Me.Controls.Add(Me.ltbxDcha)
        Me.Controls.Add(Me.ltbxCentro)
        Me.Controls.Add(Me.txtIzq)
        Me.Controls.Add(Me.ltbxIzq)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbxIzq As ListBox
    Friend WithEvents txtIzq As TextBox
    Friend WithEvents btnBorr_lisIzq As Button
    Friend WithEvents ltbxCentro As ListBox
    Friend WithEvents txtCentro As TextBox
    Friend WithEvents btnBorr_lisCentro As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents btnRecibir As Button
    Friend WithEvents ltbxDcha As ListBox
    Friend WithEvents txtDcha As TextBox
    Friend WithEvents btnBorr_lisDcha As Button
    Friend WithEvents btnEnviar2 As Button
    Friend WithEvents btnRecibir2 As Button
End Class
