<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitulosAcademicos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GRADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TITULO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTITUCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEDULA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.menustrip = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENÚPRINCIPALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PERFILYCUENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSDECONTACTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOSLABORALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TÍTULOSACADÉMICOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODEPCONACYTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTIVIDADACADÉMICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DISTINCIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASOCIACIONESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(283, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 24)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "TÍTULOS ACADÉMICOS"
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(646, 145)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(112, 23)
        Me.btnAcceder.TabIndex = 75
        Me.btnAcceder.Text = "AGREGAR TÍTULO"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GRADO, Me.TITULO, Me.INSTITUCION, Me.FECHA, Me.CEDULA})
        Me.DataGridView1.Location = New System.Drawing.Point(32, 190)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(734, 228)
        Me.DataGridView1.TabIndex = 76
        '
        'GRADO
        '
        Me.GRADO.HeaderText = "GRADO"
        Me.GRADO.Name = "GRADO"
        '
        'TITULO
        '
        Me.TITULO.HeaderText = "TÍTULO"
        Me.TITULO.Name = "TITULO"
        '
        'INSTITUCION
        '
        Me.INSTITUCION.HeaderText = "INSTITUCIÓN"
        Me.INSTITUCION.Name = "INSTITUCION"
        '
        'FECHA
        '
        Me.FECHA.HeaderText = "FECHA OBT. GRADO (MEX)"
        Me.FECHA.Name = "FECHA"
        '
        'CEDULA
        '
        Me.CEDULA.HeaderText = "NO. CÉDULA"
        Me.CEDULA.Name = "CEDULA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnPerfil)
        Me.Panel1.Controls.Add(Me.btnCerrarSesion)
        Me.Panel1.Controls.Add(Me.menustrip)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 46)
        Me.Panel1.TabIndex = 77
        '
        'btnPerfil
        '
        Me.btnPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Location = New System.Drawing.Point(588, 12)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(97, 23)
        Me.btnPerfil.TabIndex = 52
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Location = New System.Drawing.Point(691, 12)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(97, 23)
        Me.btnCerrarSesion.TabIndex = 53
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'menustrip
        '
        Me.menustrip.BackColor = System.Drawing.Color.DarkGreen
        Me.menustrip.Dock = System.Windows.Forms.DockStyle.None
        Me.menustrip.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menustrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.menustrip.Location = New System.Drawing.Point(17, 12)
        Me.menustrip.Name = "menustrip"
        Me.menustrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menustrip.Size = New System.Drawing.Size(66, 24)
        Me.menustrip.TabIndex = 55
        Me.menustrip.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENÚPRINCIPALToolStripMenuItem, Me.PERFILYCUENTAToolStripMenuItem, Me.DATOSDECONTACTOToolStripMenuItem, Me.DATOSLABORALESToolStripMenuItem, Me.TÍTULOSACADÉMICOSToolStripMenuItem, Me.PRODEPCONACYTToolStripMenuItem, Me.PRODUCTIVIDADACADÉMICAToolStripMenuItem, Me.DISTINCIONESToolStripMenuItem, Me.ASOCIACIONESToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.DarkGreen
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "MENÚ"
        '
        'MENÚPRINCIPALToolStripMenuItem
        '
        Me.MENÚPRINCIPALToolStripMenuItem.BackColor = System.Drawing.Color.DarkGreen
        Me.MENÚPRINCIPALToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MENÚPRINCIPALToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.DarkGreen
        Me.MENÚPRINCIPALToolStripMenuItem.Name = "MENÚPRINCIPALToolStripMenuItem"
        Me.MENÚPRINCIPALToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.MENÚPRINCIPALToolStripMenuItem.Text = "MENÚ PRINCIPAL"
        '
        'PERFILYCUENTAToolStripMenuItem
        '
        Me.PERFILYCUENTAToolStripMenuItem.Name = "PERFILYCUENTAToolStripMenuItem"
        Me.PERFILYCUENTAToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.PERFILYCUENTAToolStripMenuItem.Text = "PERFIL Y CUENTA"
        '
        'DATOSDECONTACTOToolStripMenuItem
        '
        Me.DATOSDECONTACTOToolStripMenuItem.Name = "DATOSDECONTACTOToolStripMenuItem"
        Me.DATOSDECONTACTOToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.DATOSDECONTACTOToolStripMenuItem.Text = "DATOS DE CONTACTO"
        '
        'DATOSLABORALESToolStripMenuItem
        '
        Me.DATOSLABORALESToolStripMenuItem.Name = "DATOSLABORALESToolStripMenuItem"
        Me.DATOSLABORALESToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.DATOSLABORALESToolStripMenuItem.Text = "DATOS LABORALES"
        '
        'TÍTULOSACADÉMICOSToolStripMenuItem
        '
        Me.TÍTULOSACADÉMICOSToolStripMenuItem.Name = "TÍTULOSACADÉMICOSToolStripMenuItem"
        Me.TÍTULOSACADÉMICOSToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.TÍTULOSACADÉMICOSToolStripMenuItem.Text = "TÍTULOS ACADÉMICOS"
        '
        'PRODEPCONACYTToolStripMenuItem
        '
        Me.PRODEPCONACYTToolStripMenuItem.Name = "PRODEPCONACYTToolStripMenuItem"
        Me.PRODEPCONACYTToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.PRODEPCONACYTToolStripMenuItem.Text = "PRODEP / CONACYT"
        '
        'PRODUCTIVIDADACADÉMICAToolStripMenuItem
        '
        Me.PRODUCTIVIDADACADÉMICAToolStripMenuItem.Name = "PRODUCTIVIDADACADÉMICAToolStripMenuItem"
        Me.PRODUCTIVIDADACADÉMICAToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.PRODUCTIVIDADACADÉMICAToolStripMenuItem.Text = "PRODUCTIVIDAD ACADÉMICA"
        '
        'DISTINCIONESToolStripMenuItem
        '
        Me.DISTINCIONESToolStripMenuItem.Name = "DISTINCIONESToolStripMenuItem"
        Me.DISTINCIONESToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.DISTINCIONESToolStripMenuItem.Text = "DISTINCIONES"
        '
        'ASOCIACIONESToolStripMenuItem
        '
        Me.ASOCIACIONESToolStripMenuItem.Name = "ASOCIACIONESToolStripMenuItem"
        Me.ASOCIACIONESToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ASOCIACIONESToolStripMenuItem.Text = "ASOCIACIONES"
        '
        'TitulosAcademicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TitulosAcademicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TitulosAcademicos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menustrip.ResumeLayout(False)
        Me.menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcceder As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GRADO As DataGridViewTextBoxColumn
    Friend WithEvents TITULO As DataGridViewTextBoxColumn
    Friend WithEvents INSTITUCION As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents CEDULA As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents menustrip As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MENÚPRINCIPALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PERFILYCUENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATOSDECONTACTOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATOSLABORALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TÍTULOSACADÉMICOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODEPCONACYTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTIVIDADACADÉMICAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DISTINCIONESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASOCIACIONESToolStripMenuItem As ToolStripMenuItem
End Class
