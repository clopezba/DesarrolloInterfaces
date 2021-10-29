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
        Me.pbxImagen = New System.Windows.Forms.PictureBox()
        Me.rtbxTexto = New System.Windows.Forms.RichTextBox()
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxImagen
        '
        Me.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxImagen.Location = New System.Drawing.Point(119, 75)
        Me.pbxImagen.Name = "pbxImagen"
        Me.pbxImagen.Size = New System.Drawing.Size(252, 231)
        Me.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImagen.TabIndex = 0
        Me.pbxImagen.TabStop = False
        '
        'rtbxTexto
        '
        Me.rtbxTexto.Location = New System.Drawing.Point(491, 75)
        Me.rtbxTexto.Name = "rtbxTexto"
        Me.rtbxTexto.Size = New System.Drawing.Size(205, 158)
        Me.rtbxTexto.TabIndex = 1
        Me.rtbxTexto.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtbxTexto)
        Me.Controls.Add(Me.pbxImagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbxImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxImagen As PictureBox
    Friend WithEvents rtbxTexto As RichTextBox
End Class
