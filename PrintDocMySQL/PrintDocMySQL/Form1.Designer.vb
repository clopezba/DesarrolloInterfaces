<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RejillaJugadores = New System.Windows.Forms.DataGridView()
        Me.txtJugador = New System.Windows.Forms.TextBox()
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.cmbEquipo = New System.Windows.Forms.ComboBox()
        Me.chckTodos = New System.Windows.Forms.CheckBox()
        Me.btnPDF = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.imgNBA = New System.Windows.Forms.PictureBox()
        CType(Me.RejillaJugadores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNBA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RejillaJugadores
        '
        Me.RejillaJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RejillaJugadores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RejillaJugadores.Location = New System.Drawing.Point(0, 224)
        Me.RejillaJugadores.Name = "RejillaJugadores"
        Me.RejillaJugadores.RowHeadersWidth = 51
        Me.RejillaJugadores.RowTemplate.Height = 24
        Me.RejillaJugadores.Size = New System.Drawing.Size(833, 335)
        Me.RejillaJugadores.TabIndex = 0
        '
        'txtJugador
        '
        Me.txtJugador.Location = New System.Drawing.Point(116, 66)
        Me.txtJugador.Name = "txtJugador"
        Me.txtJugador.Size = New System.Drawing.Size(356, 22)
        Me.txtJugador.TabIndex = 1
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Location = New System.Drawing.Point(116, 46)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(60, 17)
        Me.lblJugador.TabIndex = 2
        Me.lblJugador.Text = "Jugador"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Stencil", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(268, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(367, 32)
        Me.lblTitulo.TabIndex = 3
        Me.lblTitulo.Text = "NBA Jugadores y Equipos"
        '
        'lblEquipo
        '
        Me.lblEquipo.AutoSize = True
        Me.lblEquipo.Location = New System.Drawing.Point(116, 99)
        Me.lblEquipo.Name = "lblEquipo"
        Me.lblEquipo.Size = New System.Drawing.Size(52, 17)
        Me.lblEquipo.TabIndex = 4
        Me.lblEquipo.Text = "Equipo"
        '
        'cmbEquipo
        '
        Me.cmbEquipo.FormattingEnabled = True
        Me.cmbEquipo.Location = New System.Drawing.Point(116, 128)
        Me.cmbEquipo.Name = "cmbEquipo"
        Me.cmbEquipo.Size = New System.Drawing.Size(353, 24)
        Me.cmbEquipo.TabIndex = 5
        '
        'chckTodos
        '
        Me.chckTodos.AutoSize = True
        Me.chckTodos.Checked = True
        Me.chckTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckTodos.Location = New System.Drawing.Point(476, 130)
        Me.chckTodos.Name = "chckTodos"
        Me.chckTodos.Size = New System.Drawing.Size(70, 21)
        Me.chckTodos.TabIndex = 6
        Me.chckTodos.Text = "Todos"
        Me.chckTodos.UseVisualStyleBackColor = True
        '
        'btnPDF
        '
        Me.btnPDF.Location = New System.Drawing.Point(660, 86)
        Me.btnPDF.Name = "btnPDF"
        Me.btnPDF.Size = New System.Drawing.Size(78, 46)
        Me.btnPDF.TabIndex = 7
        Me.btnPDF.Text = "PDF"
        Me.btnPDF.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(34, 183)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(75, 23)
        Me.btnPrimero.TabIndex = 8
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(138, 183)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(75, 23)
        Me.btnAnterior.TabIndex = 8
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(363, 183)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(617, 183)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(721, 183)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(75, 23)
        Me.btnUltimo.TabIndex = 8
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'imgNBA
        '
        Me.imgNBA.Image = Global.PrintDocMySQL.My.Resources.Resources.NBA_Logo
        Me.imgNBA.Location = New System.Drawing.Point(22, 30)
        Me.imgNBA.Name = "imgNBA"
        Me.imgNBA.Size = New System.Drawing.Size(70, 122)
        Me.imgNBA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgNBA.TabIndex = 9
        Me.imgNBA.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 559)
        Me.Controls.Add(Me.imgNBA)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnPrimero)
        Me.Controls.Add(Me.btnPDF)
        Me.Controls.Add(Me.chckTodos)
        Me.Controls.Add(Me.cmbEquipo)
        Me.Controls.Add(Me.lblEquipo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblJugador)
        Me.Controls.Add(Me.txtJugador)
        Me.Controls.Add(Me.RejillaJugadores)
        Me.Name = "Form1"
        Me.Text = "MySQL DB & impresión tabla"
        CType(Me.RejillaJugadores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNBA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RejillaJugadores As DataGridView
    Friend WithEvents txtJugador As TextBox
    Friend WithEvents lblJugador As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblEquipo As Label
    Friend WithEvents cmbEquipo As ComboBox
    Friend WithEvents chckTodos As CheckBox
    Friend WithEvents btnPDF As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents imgNBA As PictureBox
End Class
