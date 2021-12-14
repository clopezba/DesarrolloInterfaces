<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.TServidor = New System.Windows.Forms.TextBox()
        Me.TUsuario = New System.Windows.Forms.TextBox()
        Me.TPassword = New System.Windows.Forms.TextBox()
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(12, 20)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(142, 17)
        Me.lblServidor.TabIndex = 0
        Me.lblServidor.Text = "Servidor PostgreSQL"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 51)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(57, 17)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 81)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Password"
        '
        'TServidor
        '
        Me.TServidor.Location = New System.Drawing.Point(160, 17)
        Me.TServidor.Name = "TServidor"
        Me.TServidor.Size = New System.Drawing.Size(298, 22)
        Me.TServidor.TabIndex = 1
        '
        'TUsuario
        '
        Me.TUsuario.Location = New System.Drawing.Point(160, 51)
        Me.TUsuario.Name = "TUsuario"
        Me.TUsuario.Size = New System.Drawing.Size(298, 22)
        Me.TUsuario.TabIndex = 1
        '
        'TPassword
        '
        Me.TPassword.Location = New System.Drawing.Point(160, 81)
        Me.TPassword.Name = "TPassword"
        Me.TPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TPassword.Size = New System.Drawing.Size(298, 22)
        Me.TPassword.TabIndex = 1
        '
        'BAceptar
        '
        Me.BAceptar.Location = New System.Drawing.Point(33, 127)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(170, 27)
        Me.BAceptar.TabIndex = 2
        Me.BAceptar.Text = "&Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancelar.Location = New System.Drawing.Point(253, 127)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(170, 27)
        Me.BCancelar.TabIndex = 2
        Me.BCancelar.Text = "&Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BCancelar
        Me.ClientSize = New System.Drawing.Size(470, 176)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Controls.Add(Me.TPassword)
        Me.Controls.Add(Me.TUsuario)
        Me.Controls.Add(Me.TServidor)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblServidor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credenciales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblServidor As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents TServidor As TextBox
    Friend WithEvents TUsuario As TextBox
    Friend WithEvents TPassword As TextBox
    Friend WithEvents BAceptar As Button
    Friend WithEvents BCancelar As Button
End Class
