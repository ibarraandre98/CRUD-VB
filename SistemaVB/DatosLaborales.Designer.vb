<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosLaborales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosLaborales))
        Me.btndatlab = New System.Windows.Forms.Button()
        Me.btnperfilcuenta = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndatlab
        '
        Me.btndatlab.BackColor = System.Drawing.Color.White
        Me.btndatlab.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndatlab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btndatlab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndatlab.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndatlab.Image = CType(resources.GetObject("btndatlab.Image"), System.Drawing.Image)
        Me.btndatlab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndatlab.Location = New System.Drawing.Point(533, 250)
        Me.btndatlab.Name = "btndatlab"
        Me.btndatlab.Size = New System.Drawing.Size(238, 33)
        Me.btndatlab.TabIndex = 78
        Me.btndatlab.Text = "Adscripción externa"
        Me.btndatlab.UseVisualStyleBackColor = False
        '
        'btnperfilcuenta
        '
        Me.btnperfilcuenta.BackColor = System.Drawing.Color.White
        Me.btnperfilcuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnperfilcuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnperfilcuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnperfilcuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperfilcuenta.Image = CType(resources.GetObject("btnperfilcuenta.Image"), System.Drawing.Image)
        Me.btnperfilcuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnperfilcuenta.Location = New System.Drawing.Point(18, 250)
        Me.btnperfilcuenta.Name = "btnperfilcuenta"
        Me.btnperfilcuenta.Size = New System.Drawing.Size(238, 33)
        Me.btnperfilcuenta.TabIndex = 76
        Me.btnperfilcuenta.Text = "Adscripción a TECNM"
        Me.btnperfilcuenta.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(44, 222)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(710, 1)
        Me.Panel3.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(41, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "DATOS LABORALES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(282, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 24)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "DATOS LABORALES"
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
        Me.Panel1.TabIndex = 79
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
        'DatosLaborales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btndatlab)
        Me.Controls.Add(Me.btnperfilcuenta)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DatosLaborales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatosLaborales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menustrip.ResumeLayout(False)
        Me.menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btndatlab As Button
    Private WithEvents btnperfilcuenta As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
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
