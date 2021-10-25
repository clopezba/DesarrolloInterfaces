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
        Me.ltbxColores = New System.Windows.Forms.ListBox()
        Me.txtColores = New System.Windows.Forms.TextBox()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.ltbxMarcas = New System.Windows.Forms.ListBox()
        Me.txtMarcas = New System.Windows.Forms.TextBox()
        Me.btnMarcas = New System.Windows.Forms.Button()
        Me.ltbxModelo = New System.Windows.Forms.ListBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.btnModelo = New System.Windows.Forms.Button()
        Me.ltbxPrecio = New System.Windows.Forms.ListBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.btnPrecio = New System.Windows.Forms.Button()
        Me.btnBorrCol = New System.Windows.Forms.Button()
        Me.btnBorrMarca = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ltbxColores
        '
        Me.ltbxColores.FormattingEnabled = True
        Me.ltbxColores.ItemHeight = 15
        Me.ltbxColores.Location = New System.Drawing.Point(51, 31)
        Me.ltbxColores.Name = "ltbxColores"
        Me.ltbxColores.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ltbxColores.Size = New System.Drawing.Size(125, 154)
        Me.ltbxColores.TabIndex = 0
        '
        'txtColores
        '
        Me.txtColores.Location = New System.Drawing.Point(51, 209)
        Me.txtColores.Name = "txtColores"
        Me.txtColores.Size = New System.Drawing.Size(125, 23)
        Me.txtColores.TabIndex = 1
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(51, 258)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(125, 23)
        Me.btnColor.TabIndex = 2
        Me.btnColor.Text = "Ingresar Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'ltbxMarcas
        '
        Me.ltbxMarcas.FormattingEnabled = True
        Me.ltbxMarcas.ItemHeight = 15
        Me.ltbxMarcas.Location = New System.Drawing.Point(245, 31)
        Me.ltbxMarcas.Name = "ltbxMarcas"
        Me.ltbxMarcas.Size = New System.Drawing.Size(125, 154)
        Me.ltbxMarcas.TabIndex = 0
        '
        'txtMarcas
        '
        Me.txtMarcas.Location = New System.Drawing.Point(245, 209)
        Me.txtMarcas.Name = "txtMarcas"
        Me.txtMarcas.Size = New System.Drawing.Size(125, 23)
        Me.txtMarcas.TabIndex = 1
        '
        'btnMarcas
        '
        Me.btnMarcas.Location = New System.Drawing.Point(245, 258)
        Me.btnMarcas.Name = "btnMarcas"
        Me.btnMarcas.Size = New System.Drawing.Size(125, 23)
        Me.btnMarcas.TabIndex = 2
        Me.btnMarcas.Text = "Ingresar Marca"
        Me.btnMarcas.UseVisualStyleBackColor = True
        '
        'ltbxModelo
        '
        Me.ltbxModelo.FormattingEnabled = True
        Me.ltbxModelo.ItemHeight = 15
        Me.ltbxModelo.Location = New System.Drawing.Point(425, 31)
        Me.ltbxModelo.Name = "ltbxModelo"
        Me.ltbxModelo.Size = New System.Drawing.Size(125, 154)
        Me.ltbxModelo.TabIndex = 0
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(425, 209)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(125, 23)
        Me.txtModelo.TabIndex = 1
        '
        'btnModelo
        '
        Me.btnModelo.Location = New System.Drawing.Point(425, 258)
        Me.btnModelo.Name = "btnModelo"
        Me.btnModelo.Size = New System.Drawing.Size(125, 23)
        Me.btnModelo.TabIndex = 2
        Me.btnModelo.Text = "Ingresar Modelo"
        Me.btnModelo.UseVisualStyleBackColor = True
        '
        'ltbxPrecio
        '
        Me.ltbxPrecio.FormattingEnabled = True
        Me.ltbxPrecio.ItemHeight = 15
        Me.ltbxPrecio.Location = New System.Drawing.Point(614, 31)
        Me.ltbxPrecio.Name = "ltbxPrecio"
        Me.ltbxPrecio.Size = New System.Drawing.Size(125, 154)
        Me.ltbxPrecio.TabIndex = 0
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(614, 209)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(125, 23)
        Me.txtPrecio.TabIndex = 1
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(614, 258)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(125, 23)
        Me.btnPrecio.TabIndex = 2
        Me.btnPrecio.Text = "Ingresar Precio"
        Me.btnPrecio.UseVisualStyleBackColor = True
        '
        'btnBorrCol
        '
        Me.btnBorrCol.Location = New System.Drawing.Point(51, 296)
        Me.btnBorrCol.Name = "btnBorrCol"
        Me.btnBorrCol.Size = New System.Drawing.Size(125, 23)
        Me.btnBorrCol.TabIndex = 2
        Me.btnBorrCol.Text = "Borrar Color"
        Me.btnBorrCol.UseVisualStyleBackColor = True
        '
        'btnBorrMarca
        '
        Me.btnBorrMarca.Location = New System.Drawing.Point(245, 296)
        Me.btnBorrMarca.Name = "btnBorrMarca"
        Me.btnBorrMarca.Size = New System.Drawing.Size(125, 23)
        Me.btnBorrMarca.TabIndex = 2
        Me.btnBorrMarca.Text = "Borrar Marca"
        Me.btnBorrMarca.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnPrecio)
        Me.Controls.Add(Me.btnModelo)
        Me.Controls.Add(Me.btnBorrMarca)
        Me.Controls.Add(Me.btnMarcas)
        Me.Controls.Add(Me.btnBorrCol)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtMarcas)
        Me.Controls.Add(Me.txtColores)
        Me.Controls.Add(Me.ltbxPrecio)
        Me.Controls.Add(Me.ltbxModelo)
        Me.Controls.Add(Me.ltbxMarcas)
        Me.Controls.Add(Me.ltbxColores)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltbxColores As ListBox
    Friend WithEvents txtColores As TextBox
    Friend WithEvents btnColor As Button
    Friend WithEvents ltbxMarcas As ListBox
    Friend WithEvents txtMarcas As TextBox
    Friend WithEvents btnMarcas As Button
    Friend WithEvents ltbxModelo As ListBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents btnModelo As Button
    Friend WithEvents ltbxPrecio As ListBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents btnPrecio As Button
    Friend WithEvents btnBorrCol As Button
    Friend WithEvents btnBorrMarca As Button
End Class
