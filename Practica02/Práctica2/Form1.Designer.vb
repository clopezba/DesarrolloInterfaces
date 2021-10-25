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
        Me.Chck_Op1 = New System.Windows.Forms.CheckBox()
        Me.Chck_Op2 = New System.Windows.Forms.CheckBox()
        Me.Chck_Op3 = New System.Windows.Forms.CheckBox()
        Me.Chck_Op4 = New System.Windows.Forms.CheckBox()
        Me.btnResumen = New System.Windows.Forms.Button()
        Me.lblResumen = New System.Windows.Forms.Label()
        Me.pnlOpciones = New System.Windows.Forms.Panel()
        Me.pnlOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chck_Op1
        '
        Me.Chck_Op1.AutoSize = True
        Me.Chck_Op1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Chck_Op1.Location = New System.Drawing.Point(24, 19)
        Me.Chck_Op1.Name = "Chck_Op1"
        Me.Chck_Op1.Size = New System.Drawing.Size(84, 23)
        Me.Chck_Op1.TabIndex = 0
        Me.Chck_Op1.Text = "Opción 1"
        Me.Chck_Op1.UseVisualStyleBackColor = True
        '
        'Chck_Op2
        '
        Me.Chck_Op2.AutoSize = True
        Me.Chck_Op2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Chck_Op2.Location = New System.Drawing.Point(24, 51)
        Me.Chck_Op2.Name = "Chck_Op2"
        Me.Chck_Op2.Size = New System.Drawing.Size(84, 23)
        Me.Chck_Op2.TabIndex = 0
        Me.Chck_Op2.Text = "Opción 2"
        Me.Chck_Op2.UseVisualStyleBackColor = True
        '
        'Chck_Op3
        '
        Me.Chck_Op3.AutoSize = True
        Me.Chck_Op3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Chck_Op3.Location = New System.Drawing.Point(24, 82)
        Me.Chck_Op3.Name = "Chck_Op3"
        Me.Chck_Op3.Size = New System.Drawing.Size(84, 23)
        Me.Chck_Op3.TabIndex = 0
        Me.Chck_Op3.Text = "Opción 3"
        Me.Chck_Op3.UseVisualStyleBackColor = True
        '
        'Chck_Op4
        '
        Me.Chck_Op4.AutoSize = True
        Me.Chck_Op4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Chck_Op4.Location = New System.Drawing.Point(24, 114)
        Me.Chck_Op4.Name = "Chck_Op4"
        Me.Chck_Op4.Size = New System.Drawing.Size(84, 23)
        Me.Chck_Op4.TabIndex = 0
        Me.Chck_Op4.Text = "Opción 4"
        Me.Chck_Op4.UseVisualStyleBackColor = True
        '
        'btnResumen
        '
        Me.btnResumen.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnResumen.Location = New System.Drawing.Point(302, 200)
        Me.btnResumen.Name = "btnResumen"
        Me.btnResumen.Size = New System.Drawing.Size(75, 33)
        Me.btnResumen.TabIndex = 1
        Me.btnResumen.Text = "Resumen"
        Me.btnResumen.UseVisualStyleBackColor = True
        '
        'lblResumen
        '
        Me.lblResumen.AutoSize = True
        Me.lblResumen.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblResumen.Location = New System.Drawing.Point(435, 137)
        Me.lblResumen.Name = "lblResumen"
        Me.lblResumen.Size = New System.Drawing.Size(122, 20)
        Me.lblResumen.TabIndex = 2
        Me.lblResumen.Text = "Estado CheckBox"
        '
        'pnlOpciones
        '
        Me.pnlOpciones.Controls.Add(Me.Chck_Op1)
        Me.pnlOpciones.Controls.Add(Me.Chck_Op2)
        Me.pnlOpciones.Controls.Add(Me.Chck_Op3)
        Me.pnlOpciones.Controls.Add(Me.Chck_Op4)
        Me.pnlOpciones.Location = New System.Drawing.Point(126, 137)
        Me.pnlOpciones.Name = "pnlOpciones"
        Me.pnlOpciones.Size = New System.Drawing.Size(133, 155)
        Me.pnlOpciones.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlOpciones)
        Me.Controls.Add(Me.lblResumen)
        Me.Controls.Add(Me.btnResumen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnlOpciones.ResumeLayout(False)
        Me.pnlOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chck_Op1 As CheckBox
    Friend WithEvents Chck_Op2 As CheckBox
    Friend WithEvents Chck_Op3 As CheckBox
    Friend WithEvents Chck_Op4 As CheckBox
    Friend WithEvents btnResumen As Button
    Friend WithEvents lblResumen As Label
    Friend WithEvents pnlOpciones As Panel
End Class
