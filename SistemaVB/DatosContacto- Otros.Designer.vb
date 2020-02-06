<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosContacto__Otros
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
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelheader = New System.Windows.Forms.Panel()
        Me.dtgOtros = New System.Windows.Forms.DataGridView()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SERVICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbservicio = New System.Windows.Forms.ComboBox()
        CType(Me.dtgOtros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(432, 313)
        Me.txtusuario.MaxLength = 100
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(336, 20)
        Me.txtusuario.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(429, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Usuario:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 295)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Servicio:"
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.Gray
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(800, 46)
        Me.panelheader.TabIndex = 104
        '
        'dtgOtros
        '
        Me.dtgOtros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgOtros.BackgroundColor = System.Drawing.Color.White
        Me.dtgOtros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgOtros.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dtgOtros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOtros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SERVICIO, Me.USUARIO})
        Me.dtgOtros.Location = New System.Drawing.Point(34, 120)
        Me.dtgOtros.Name = "dtgOtros"
        Me.dtgOtros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgOtros.Size = New System.Drawing.Size(734, 157)
        Me.dtgOtros.TabIndex = 103
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(631, 424)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(137, 23)
        Me.btnAcceder.TabIndex = 102
        Me.btnAcceder.Text = "AGREGAR"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(276, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 24)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "OTROS MEDIOS DE CONTACTO"
        '
        'SERVICIO
        '
        Me.SERVICIO.DataPropertyName = "servicio"
        Me.SERVICIO.HeaderText = "SERVICIO"
        Me.SERVICIO.Name = "SERVICIO"
        '
        'USUARIO
        '
        Me.USUARIO.DataPropertyName = "usuario"
        Me.USUARIO.HeaderText = "USUARIO"
        Me.USUARIO.Name = "USUARIO"
        '
        'cbservicio
        '
        Me.cbservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbservicio.FormattingEnabled = True
        Me.cbservicio.Items.AddRange(New Object() {"Facebook", "LinkedIn", "Skype"})
        Me.cbservicio.Location = New System.Drawing.Point(34, 312)
        Me.cbservicio.Name = "cbservicio"
        Me.cbservicio.Size = New System.Drawing.Size(336, 21)
        Me.cbservicio.TabIndex = 113
        '
        'DatosContacto__Otros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbservicio)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.panelheader)
        Me.Controls.Add(Me.dtgOtros)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DatosContacto__Otros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatosContacto__Otros"
        CType(Me.dtgOtros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents panelheader As Panel
    Friend WithEvents dtgOtros As DataGridView
    Friend WithEvents btnAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SERVICIO As DataGridViewTextBoxColumn
    Friend WithEvents USUARIO As DataGridViewTextBoxColumn
    Friend WithEvents cbservicio As ComboBox
End Class
