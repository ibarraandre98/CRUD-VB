<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosLaborales__AdscripcionExterna
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
        Me.txtInstitucion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelheader = New System.Windows.Forms.Panel()
        Me.dtgOtros = New System.Windows.Forms.DataGridView()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Institucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombramiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vigente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVigente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombramiento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dtgOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInstitucion
        '
        Me.txtInstitucion.Location = New System.Drawing.Point(34, 278)
        Me.txtInstitucion.MaxLength = 100
        Me.txtInstitucion.Name = "txtInstitucion"
        Me.txtInstitucion.Size = New System.Drawing.Size(270, 20)
        Me.txtInstitucion.TabIndex = 120
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Nombre de la institución"
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.Gray
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(800, 46)
        Me.panelheader.TabIndex = 117
        '
        'dtgOtros
        '
        Me.dtgOtros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgOtros.BackgroundColor = System.Drawing.Color.White
        Me.dtgOtros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgOtros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dtgOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Institucion, Me.Puesto, Me.Nombramiento, Me.Vigente})
        Me.dtgOtros.Location = New System.Drawing.Point(34, 87)
        Me.dtgOtros.Name = "dtgOtros"
        Me.dtgOtros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOtros.Size = New System.Drawing.Size(734, 157)
        Me.dtgOtros.TabIndex = 116
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(631, 426)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(137, 23)
        Me.btnAcceder.TabIndex = 115
        Me.btnAcceder.Text = "AGREGAR"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(298, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 24)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "ADSCRIPCIÓN EXTERNA"
        '
        'Institucion
        '
        Me.Institucion.DataPropertyName = "Institucion"
        Me.Institucion.HeaderText = "Institución"
        Me.Institucion.Name = "Institucion"
        '
        'Puesto
        '
        Me.Puesto.DataPropertyName = "Puesto"
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        '
        'Nombramiento
        '
        Me.Nombramiento.DataPropertyName = "Nombramiento"
        Me.Nombramiento.HeaderText = "Nombramiento"
        Me.Nombramiento.Name = "Nombramiento"
        '
        'Vigente
        '
        Me.Vigente.DataPropertyName = "Vigente"
        Me.Vigente.HeaderText = "Vigente"
        Me.Vigente.Name = "Vigente"
        '
        'txtPuesto
        '
        Me.txtPuesto.Location = New System.Drawing.Point(498, 278)
        Me.txtPuesto.MaxLength = 100
        Me.txtPuesto.Name = "txtPuesto"
        Me.txtPuesto.Size = New System.Drawing.Size(270, 20)
        Me.txtPuesto.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Puesto o cargo:"
        '
        'txtVigente
        '
        Me.txtVigente.Location = New System.Drawing.Point(498, 340)
        Me.txtVigente.MaxLength = 100
        Me.txtVigente.Name = "txtVigente"
        Me.txtVigente.Size = New System.Drawing.Size(270, 20)
        Me.txtVigente.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(495, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Año de vigencia:"
        '
        'txtNombramiento
        '
        Me.txtNombramiento.Location = New System.Drawing.Point(34, 340)
        Me.txtNombramiento.MaxLength = 100
        Me.txtNombramiento.Name = "txtNombramiento"
        Me.txtNombramiento.Size = New System.Drawing.Size(270, 20)
        Me.txtNombramiento.TabIndex = 124
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 321)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 16)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Fecha de nombramiento:"
        '
        'DatosLaborales__AdscripcionExterna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtVigente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombramiento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPuesto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInstitucion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.panelheader)
        Me.Controls.Add(Me.dtgOtros)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DatosLaborales__AdscripcionExterna"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatosLaborales__AdscripcionExterna"
        CType(Me.dtgOtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInstitucion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents panelheader As Panel
    Friend WithEvents dtgOtros As DataGridView
    Friend WithEvents btnAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Institucion As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Nombramiento As DataGridViewTextBoxColumn
    Friend WithEvents Vigente As DataGridViewTextBoxColumn
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVigente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombramiento As TextBox
    Friend WithEvents Label5 As Label
End Class
