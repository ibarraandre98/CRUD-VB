<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosContacto__Correos
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
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcodpa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelheader = New System.Windows.Forms.Panel()
        Me.dtgTelefonos = New System.Windows.Forms.DataGridView()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(610, 310)
        Me.txtnum.MaxLength = 10
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(158, 20)
        Me.txtnum.TabIndex = 100
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(607, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Número teléfonico:"
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(34, 386)
        Me.txtdesc.MaxLength = 10
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(734, 20)
        Me.txtdesc.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 367)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Descripción:"
        '
        'cbTel
        '
        Me.cbTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTel.FormattingEnabled = True
        Me.cbTel.Items.AddRange(New Object() {"Fijo", "Móvil"})
        Me.cbTel.Location = New System.Drawing.Point(317, 310)
        Me.cbTel.Name = "cbTel"
        Me.cbTel.Size = New System.Drawing.Size(166, 21)
        Me.cbTel.TabIndex = 96
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(314, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 16)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Tipo de teléfono:"
        '
        'txtcodpa
        '
        Me.txtcodpa.Location = New System.Drawing.Point(34, 311)
        Me.txtcodpa.MaxLength = 10
        Me.txtcodpa.Name = "txtcodpa"
        Me.txtcodpa.Size = New System.Drawing.Size(158, 20)
        Me.txtcodpa.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Código de país:"
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.Gray
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(800, 46)
        Me.panelheader.TabIndex = 92
        '
        'dtgTelefonos
        '
        Me.dtgTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgTelefonos.BackgroundColor = System.Drawing.Color.White
        Me.dtgTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgTelefonos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dtgTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION, Me.Direccion})
        Me.dtgTelefonos.Location = New System.Drawing.Point(34, 117)
        Me.dtgTelefonos.Name = "dtgTelefonos"
        Me.dtgTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTelefonos.Size = New System.Drawing.Size(734, 157)
        Me.dtgTelefonos.TabIndex = 91
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(631, 421)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(137, 23)
        Me.btnAcceder.TabIndex = 90
        Me.btnAcceder.Text = "AGREGAR TELÉFONO"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(276, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 24)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "CORREOS ELECTRÓNICOS"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "descripcion"
        Me.DESCRIPCION.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "direccion"
        Me.Direccion.HeaderText = "DIRECCIÓN DE CORREO"
        Me.Direccion.Name = "Direccion"
        '
        'DatosContacto__Correos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcodpa)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.panelheader)
        Me.Controls.Add(Me.dtgTelefonos)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DatosContacto__Correos"
        Me.Text = "DatosContacto__Correos"
        CType(Me.dtgTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTel As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtcodpa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents panelheader As Panel
    Friend WithEvents dtgTelefonos As DataGridView
    Friend WithEvents btnAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
End Class
