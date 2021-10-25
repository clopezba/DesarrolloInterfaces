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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lbl_colorSel = New System.Windows.Forms.Label()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(327, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listas de datos u opciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(59, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuadros de lista ListBox"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Items.AddRange(New Object() {"Azul", "Verde", "Negro", "Rojo", "Amarillo"})
        Me.ListBox1.Location = New System.Drawing.Point(107, 174)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(83, 84)
        Me.ListBox1.TabIndex = 2
        '
        'lbl_colorSel
        '
        Me.lbl_colorSel.AutoSize = True
        Me.lbl_colorSel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_colorSel.Location = New System.Drawing.Point(327, 174)
        Me.lbl_colorSel.Name = "lbl_colorSel"
        Me.lbl_colorSel.Size = New System.Drawing.Size(86, 25)
        Me.lbl_colorSel.TabIndex = 3
        Me.lbl_colorSel.Text = "Sin color"
        '
        'txtItems
        '
        Me.txtItems.Location = New System.Drawing.Point(536, 174)
        Me.txtItems.Multiline = True
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(108, 117)
        Me.txtItems.TabIndex = 4
        '
        'lblItems
        '
        Me.lblItems.AutoSize = True
        Me.lblItems.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblItems.Location = New System.Drawing.Point(498, 135)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(180, 25)
        Me.lblItems.TabIndex = 5
        Me.lblItems.Text = "Items seleccionados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.lbl_colorSel)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lbl_colorSel As Label
    Friend WithEvents txtItems As TextBox
    Friend WithEvents lblItems As Label
End Class
