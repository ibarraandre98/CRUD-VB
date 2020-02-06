<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosContacto_Telefonos
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
        Me.dtgTelefonos = New System.Windows.Forms.DataGridView()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelheader = New System.Windows.Forms.Panel()
        Me.txtcodpa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbTel = New System.Windows.Forms.ComboBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMERO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgTelefonos
        '
        Me.dtgTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgTelefonos.BackgroundColor = System.Drawing.Color.White
        Me.dtgTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgTelefonos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dtgTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DESCRIPCION, Me.TIPO, Me.CODIGO, Me.NUMERO})
        Me.dtgTelefonos.Location = New System.Drawing.Point(34, 111)
        Me.dtgTelefonos.Name = "dtgTelefonos"
        Me.dtgTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTelefonos.Size = New System.Drawing.Size(734, 157)
        Me.dtgTelefonos.TabIndex = 79
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(631, 415)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(137, 23)
        Me.btnAcceder.TabIndex = 78
        Me.btnAcceder.Text = "AGREGAR TELÉFONO"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(323, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 24)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "TELÉFONOS"
        '
        'panelheader
        '
        Me.panelheader.BackColor = System.Drawing.Color.Gray
        Me.panelheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelheader.Location = New System.Drawing.Point(0, 0)
        Me.panelheader.Name = "panelheader"
        Me.panelheader.Size = New System.Drawing.Size(800, 46)
        Me.panelheader.TabIndex = 80
        '
        'txtcodpa
        '
        Me.txtcodpa.Location = New System.Drawing.Point(34, 305)
        Me.txtcodpa.MaxLength = 10
        Me.txtcodpa.Name = "txtcodpa"
        Me.txtcodpa.Size = New System.Drawing.Size(158, 20)
        Me.txtcodpa.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 286)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 16)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Código de país:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(314, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 16)
        Me.Label12.TabIndex = 83
        Me.Label12.Text = "Tipo de teléfono:"
        '
        'cbTel
        '
        Me.cbTel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTel.FormattingEnabled = True
        Me.cbTel.Items.AddRange(New Object() {"Fijo", "Móvil"})
        Me.cbTel.Location = New System.Drawing.Point(317, 304)
        Me.cbTel.Name = "cbTel"
        Me.cbTel.Size = New System.Drawing.Size(166, 21)
        Me.cbTel.TabIndex = 84
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(34, 380)
        Me.txtdesc.MaxLength = 10
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(734, 20)
        Me.txtdesc.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Descripción:"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(610, 304)
        Me.txtnum.MaxLength = 10
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(158, 20)
        Me.txtnum.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(607, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Número teléfonico:"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "descripcion"
        Me.DESCRIPCION.HeaderText = "DESCRIPCIÓN"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "tipo"
        Me.TIPO.HeaderText = "TIPO"
        Me.TIPO.Name = "TIPO"
        '
        'CODIGO
        '
        Me.CODIGO.DataPropertyName = "codigopais"
        Me.CODIGO.HeaderText = "CÓDIGO DE PAÍS"
        Me.CODIGO.Name = "CODIGO"
        '
        'NUMERO
        '
        Me.NUMERO.DataPropertyName = "numero"
        Me.NUMERO.HeaderText = "NÚMERO"
        Me.NUMERO.Name = "NUMERO"
        '
        'DatosContacto_Telefonos
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
        Me.Name = "DatosContacto_Telefonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatosContacto_Telefonos"
        CType(Me.dtgTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgTelefonos As DataGridView
    Friend WithEvents btnAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents panelheader As Panel
    Friend WithEvents txtcodpa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbTel As ComboBox
    Friend WithEvents txtdesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents TIPO As DataGridViewTextBoxColumn
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NUMERO As DataGridViewTextBoxColumn
End Class
