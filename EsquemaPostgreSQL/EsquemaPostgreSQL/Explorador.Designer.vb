<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Explorador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Explorador))
        Me.VisorRejilla = New System.Windows.Forms.DataGridView()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.lblTablas = New System.Windows.Forms.Label()
        Me.lblCampos = New System.Windows.Forms.Label()
        Me.lblEditorSQL = New System.Windows.Forms.Label()
        Me.Catalogo = New System.Windows.Forms.ComboBox()
        Me.Tablas = New System.Windows.Forms.ComboBox()
        Me.LISTA_CAMPOS = New System.Windows.Forms.CheckedListBox()
        Me.SQLText = New System.Windows.Forms.TextBox()
        Me.btnEjecutarSQL = New System.Windows.Forms.Button()
        Me.btnFormulario = New System.Windows.Forms.Button()
        Me.InformacionTabla = New System.Windows.Forms.Label()
        CType(Me.VisorRejilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisorRejilla
        '
        Me.VisorRejilla.AllowUserToAddRows = False
        Me.VisorRejilla.AllowUserToDeleteRows = False
        Me.VisorRejilla.AllowUserToResizeColumns = False
        Me.VisorRejilla.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VisorRejilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VisorRejilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VisorRejilla.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VisorRejilla.Location = New System.Drawing.Point(0, 365)
        Me.VisorRejilla.Margin = New System.Windows.Forms.Padding(4)
        Me.VisorRejilla.Name = "VisorRejilla"
        Me.VisorRejilla.ReadOnly = True
        Me.VisorRejilla.RowHeadersWidth = 51
        Me.VisorRejilla.RowTemplate.Height = 24
        Me.VisorRejilla.Size = New System.Drawing.Size(1269, 285)
        Me.VisorRejilla.TabIndex = 0
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.lblCatalogo.Location = New System.Drawing.Point(28, 19)
        Me.lblCatalogo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(149, 29)
        Me.lblCatalogo.TabIndex = 1
        Me.lblCatalogo.Text = "Catálogo BD"
        '
        'lblTablas
        '
        Me.lblTablas.AutoSize = True
        Me.lblTablas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.lblTablas.Location = New System.Drawing.Point(28, 87)
        Me.lblTablas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTablas.Name = "lblTablas"
        Me.lblTablas.Size = New System.Drawing.Size(87, 29)
        Me.lblTablas.TabIndex = 1
        Me.lblTablas.Text = "Tablas"
        '
        'lblCampos
        '
        Me.lblCampos.AutoSize = True
        Me.lblCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.lblCampos.Location = New System.Drawing.Point(483, 19)
        Me.lblCampos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCampos.Name = "lblCampos"
        Me.lblCampos.Size = New System.Drawing.Size(103, 29)
        Me.lblCampos.TabIndex = 1
        Me.lblCampos.Text = "Campos"
        '
        'lblEditorSQL
        '
        Me.lblEditorSQL.AutoSize = True
        Me.lblEditorSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.lblEditorSQL.Location = New System.Drawing.Point(863, 9)
        Me.lblEditorSQL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEditorSQL.Name = "lblEditorSQL"
        Me.lblEditorSQL.Size = New System.Drawing.Size(131, 29)
        Me.lblEditorSQL.TabIndex = 1
        Me.lblEditorSQL.Text = "Editor SQL"
        '
        'Catalogo
        '
        Me.Catalogo.FormattingEnabled = True
        Me.Catalogo.Location = New System.Drawing.Point(21, 51)
        Me.Catalogo.Name = "Catalogo"
        Me.Catalogo.Size = New System.Drawing.Size(313, 24)
        Me.Catalogo.TabIndex = 2
        Me.Catalogo.Text = "<Selecciona base>"
        '
        'Tablas
        '
        Me.Tablas.FormattingEnabled = True
        Me.Tablas.ItemHeight = 16
        Me.Tablas.Location = New System.Drawing.Point(21, 119)
        Me.Tablas.Name = "Tablas"
        Me.Tablas.Size = New System.Drawing.Size(313, 24)
        Me.Tablas.TabIndex = 2
        Me.Tablas.Text = "<Selecciona tabla>"
        '
        'LISTA_CAMPOS
        '
        Me.LISTA_CAMPOS.FormattingEnabled = True
        Me.LISTA_CAMPOS.Location = New System.Drawing.Point(488, 51)
        Me.LISTA_CAMPOS.Name = "LISTA_CAMPOS"
        Me.LISTA_CAMPOS.Size = New System.Drawing.Size(348, 106)
        Me.LISTA_CAMPOS.TabIndex = 3
        '
        'SQLText
        '
        Me.SQLText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.SQLText.ForeColor = System.Drawing.Color.Maroon
        Me.SQLText.Location = New System.Drawing.Point(868, 51)
        Me.SQLText.Multiline = True
        Me.SQLText.Name = "SQLText"
        Me.SQLText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SQLText.Size = New System.Drawing.Size(371, 106)
        Me.SQLText.TabIndex = 4
        '
        'btnEjecutarSQL
        '
        Me.btnEjecutarSQL.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEjecutarSQL.Location = New System.Drawing.Point(1090, 163)
        Me.btnEjecutarSQL.Name = "btnEjecutarSQL"
        Me.btnEjecutarSQL.Size = New System.Drawing.Size(149, 35)
        Me.btnEjecutarSQL.TabIndex = 5
        Me.btnEjecutarSQL.Text = "Ejecutar SQL -->"
        Me.btnEjecutarSQL.UseVisualStyleBackColor = False
        '
        'btnFormulario
        '
        Me.btnFormulario.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFormulario.Location = New System.Drawing.Point(1090, 310)
        Me.btnFormulario.Name = "btnFormulario"
        Me.btnFormulario.Size = New System.Drawing.Size(149, 35)
        Me.btnFormulario.TabIndex = 5
        Me.btnFormulario.Text = "Formulario Datos"
        Me.btnFormulario.UseVisualStyleBackColor = False
        Me.btnFormulario.Visible = False
        '
        'InformacionTabla
        '
        Me.InformacionTabla.AutoSize = True
        Me.InformacionTabla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.2!)
        Me.InformacionTabla.Location = New System.Drawing.Point(28, 316)
        Me.InformacionTabla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InformacionTabla.Name = "InformacionTabla"
        Me.InformacionTabla.Size = New System.Drawing.Size(284, 29)
        Me.InformacionTabla.TabIndex = 1
        Me.InformacionTabla.Text = "Información del esquema"
        '
        'Explorador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EsquemaPostgreSQL.My.Resources.Resources.postgres
        Me.ClientSize = New System.Drawing.Size(1269, 650)
        Me.Controls.Add(Me.btnFormulario)
        Me.Controls.Add(Me.btnEjecutarSQL)
        Me.Controls.Add(Me.SQLText)
        Me.Controls.Add(Me.LISTA_CAMPOS)
        Me.Controls.Add(Me.Tablas)
        Me.Controls.Add(Me.Catalogo)
        Me.Controls.Add(Me.lblEditorSQL)
        Me.Controls.Add(Me.lblCampos)
        Me.Controls.Add(Me.InformacionTabla)
        Me.Controls.Add(Me.lblTablas)
        Me.Controls.Add(Me.lblCatalogo)
        Me.Controls.Add(Me.VisorRejilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Explorador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Explorador PostgreSQL"
        CType(Me.VisorRejilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VisorRejilla As DataGridView
    Friend WithEvents lblCatalogo As Label
    Friend WithEvents lblTablas As Label
    Friend WithEvents lblCampos As Label
    Friend WithEvents lblEditorSQL As Label
    Friend WithEvents Catalogo As ComboBox
    Friend WithEvents Tablas As ComboBox
    Friend WithEvents LISTA_CAMPOS As CheckedListBox
    Friend WithEvents SQLText As TextBox
    Friend WithEvents btnEjecutarSQL As Button
    Friend WithEvents btnFormulario As Button
    Friend WithEvents InformacionTabla As Label
End Class
