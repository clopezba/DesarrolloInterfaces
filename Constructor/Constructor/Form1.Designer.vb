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
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.pnl = New System.Windows.Forms.Panel()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAnadir
        '
        Me.btnAnadir.Location = New System.Drawing.Point(66, 84)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(124, 50)
        Me.btnAnadir.TabIndex = 0
        Me.btnAnadir.Text = "Más TextBox"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(66, 177)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(124, 50)
        Me.btnQuitar.TabIndex = 0
        Me.btnQuitar.Text = "Menos TextBox"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'pnl
        '
        Me.pnl.Location = New System.Drawing.Point(336, 31)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(345, 376)
        Me.pnl.TabIndex = 1
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(336, 13)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(90, 15)
        Me.lblContador.TabIndex = 2
        Me.lblContador.Text = "Nº de TextBox 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAnadir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAnadir As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents pnl As Panel
    Friend WithEvents lblContador As Label
End Class
