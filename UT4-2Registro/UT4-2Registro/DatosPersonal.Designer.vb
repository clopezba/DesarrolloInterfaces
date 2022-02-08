<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosPersonal
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
        Me.RejillaDatos = New System.Windows.Forms.DataGridView()
        Me.cmbFiltrarAcceso = New System.Windows.Forms.ComboBox()
        Me.lblFiltrarAcceso = New System.Windows.Forms.Label()
        CType(Me.RejillaDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RejillaDatos
        '
        Me.RejillaDatos.BackgroundColor = System.Drawing.Color.MintCream
        Me.RejillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RejillaDatos.Location = New System.Drawing.Point(22, 123)
        Me.RejillaDatos.Name = "RejillaDatos"
        Me.RejillaDatos.Size = New System.Drawing.Size(772, 205)
        Me.RejillaDatos.TabIndex = 2
        '
        'cmbFiltrarAcceso
        '
        Me.cmbFiltrarAcceso.FormattingEnabled = True
        Me.cmbFiltrarAcceso.Items.AddRange(New Object() {"Matutino (08:00-14:00)", "Verpertino (14:00-22:00)", "Nocturno (22:00-08:00)"})
        Me.cmbFiltrarAcceso.Location = New System.Drawing.Point(58, 81)
        Me.cmbFiltrarAcceso.Name = "cmbFiltrarAcceso"
        Me.cmbFiltrarAcceso.Size = New System.Drawing.Size(169, 21)
        Me.cmbFiltrarAcceso.TabIndex = 1
        '
        'lblFiltrarAcceso
        '
        Me.lblFiltrarAcceso.AutoSize = True
        Me.lblFiltrarAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrarAcceso.Location = New System.Drawing.Point(55, 52)
        Me.lblFiltrarAcceso.Name = "lblFiltrarAcceso"
        Me.lblFiltrarAcceso.Size = New System.Drawing.Size(198, 18)
        Me.lblFiltrarAcceso.TabIndex = 0
        Me.lblFiltrarAcceso.Text = "Filtrar por periodo de acceso"
        '
        'DatosPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(835, 364)
        Me.Controls.Add(Me.lblFiltrarAcceso)
        Me.Controls.Add(Me.cmbFiltrarAcceso)
        Me.Controls.Add(Me.RejillaDatos)
        Me.Name = "DatosPersonal"
        Me.Text = "DatosPersonal"
        CType(Me.RejillaDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RejillaDatos As DataGridView
    Friend WithEvents cmbFiltrarAcceso As ComboBox
    Friend WithEvents lblFiltrarAcceso As Label
End Class
