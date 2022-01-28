<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hijo
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
        Me.HelpProvider = New System.Windows.Forms.HelpProvider()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider2 = New System.Windows.Forms.HelpProvider()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HelpProvider
        '
        Me.HelpProvider.HelpNamespace = "C:\Users\DAM2Alu10\Desktop\Procedimiento para proporcionar ayuda en una aplicació" &
    "n Windows.htm"
        '
        'Button1
        '
        Me.HelpProvider.SetHelpKeyword(Me.Button1, "cases")
        Me.HelpProvider.SetHelpNavigator(Me.Button1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider.SetHelpString(Me.Button1, "")
        Me.Button1.Location = New System.Drawing.Point(181, 197)
        Me.Button1.Name = "Button1"
        Me.HelpProvider.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HelpProvider2
        '
        Me.HelpProvider2.HelpNamespace = "https://docs.google.com/document/d/1s_Ht8_xkwW8lMZQcn4Qc-tGJhQ_cQR2lBHf2B6kUrHk/e" &
    "dit#"
        '
        'Button2
        '
        Me.HelpProvider2.SetHelpKeyword(Me.Button2, "delimitador")
        Me.HelpProvider2.SetHelpNavigator(Me.Button2, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.Button2.Location = New System.Drawing.Point(426, 197)
        Me.Button2.Name = "Button2"
        Me.HelpProvider2.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Hijo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.HelpProvider.SetHelpString(Me, "")
        Me.Name = "Hijo"
        Me.HelpProvider.SetShowHelp(Me, True)
        Me.Text = "Hijo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HelpProvider As HelpProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents HelpProvider2 As HelpProvider
    Friend WithEvents Button2 As Button
End Class
