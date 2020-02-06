<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perfil))
        Me.labelnomcom = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbnom = New System.Windows.Forms.Label()
        Me.lbapp = New System.Windows.Forms.Label()
        Me.lbapm = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbpais = New System.Windows.Forms.Label()
        Me.lbcurp = New System.Windows.Forms.Label()
        Me.lbrfc = New System.Windows.Forms.Label()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.menustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelnomcom
        '
        Me.labelnomcom.AutoSize = True
        Me.labelnomcom.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnomcom.ForeColor = System.Drawing.Color.Maroon
        Me.labelnomcom.Location = New System.Drawing.Point(112, 77)
        Me.labelnomcom.Name = "labelnomcom"
        Me.labelnomcom.Size = New System.Drawing.Size(92, 24)
        Me.labelnomcom.TabIndex = 56
        Me.labelnomcom.Text = "nombre"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(70, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(169, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(277, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 380)
        Me.Panel2.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(457, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 24)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "DATOS PERSONALES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(340, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Nombre(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(488, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Apellido paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(651, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Apellido materno"
        '
        'lbnom
        '
        Me.lbnom.AutoSize = True
        Me.lbnom.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnom.ForeColor = System.Drawing.Color.Black
        Me.lbnom.Location = New System.Drawing.Point(326, 132)
        Me.lbnom.Name = "lbnom"
        Me.lbnom.Size = New System.Drawing.Size(92, 24)
        Me.lbnom.TabIndex = 63
        Me.lbnom.Text = "nombre"
        Me.lbnom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbapp
        '
        Me.lbapp.AutoSize = True
        Me.lbapp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbapp.ForeColor = System.Drawing.Color.Black
        Me.lbapp.Location = New System.Drawing.Point(487, 132)
        Me.lbapp.Name = "lbapp"
        Me.lbapp.Size = New System.Drawing.Size(92, 24)
        Me.lbapp.TabIndex = 64
        Me.lbapp.Text = "paterno"
        Me.lbapp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbapm
        '
        Me.lbapm.AutoSize = True
        Me.lbapm.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbapm.ForeColor = System.Drawing.Color.Black
        Me.lbapm.Location = New System.Drawing.Point(650, 132)
        Me.lbapm.Name = "lbapm"
        Me.lbapm.Size = New System.Drawing.Size(99, 24)
        Me.lbapm.TabIndex = 65
        Me.lbapm.Text = "materno"
        Me.lbapm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(488, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "INFORMACIÓN BÁSICA"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(305, 195)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(480, 1)
        Me.Panel3.TabIndex = 67
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(496, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "País de nacimiento"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(305, 312)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(480, 1)
        Me.Panel4.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(504, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 16)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "CLAVES DE REGISTRO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(651, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 16)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "RFC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(340, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "CURP"
        '
        'lbpais
        '
        Me.lbpais.AutoSize = True
        Me.lbpais.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpais.ForeColor = System.Drawing.Color.Black
        Me.lbpais.Location = New System.Drawing.Point(528, 246)
        Me.lbpais.Name = "lbpais"
        Me.lbpais.Size = New System.Drawing.Size(51, 24)
        Me.lbpais.TabIndex = 74
        Me.lbpais.Text = "país"
        Me.lbpais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbcurp
        '
        Me.lbcurp.AutoSize = True
        Me.lbcurp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcurp.ForeColor = System.Drawing.Color.Black
        Me.lbcurp.Location = New System.Drawing.Point(301, 364)
        Me.lbcurp.Name = "lbcurp"
        Me.lbcurp.Size = New System.Drawing.Size(57, 24)
        Me.lbcurp.TabIndex = 75
        Me.lbcurp.Text = "curp"
        Me.lbcurp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbrfc
        '
        Me.lbrfc.AutoSize = True
        Me.lbrfc.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrfc.ForeColor = System.Drawing.Color.Black
        Me.lbrfc.Location = New System.Drawing.Point(620, 364)
        Me.lbrfc.Name = "lbrfc"
        Me.lbrfc.Size = New System.Drawing.Size(37, 24)
        Me.lbrfc.TabIndex = 76
        Me.lbrfc.Text = "rfc"
        Me.lbrfc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbrfc)
        Me.Controls.Add(Me.lbcurp)
        Me.Controls.Add(Me.lbpais)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbapm)
        Me.Controls.Add(Me.lbapp)
        Me.Controls.Add(Me.lbnom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.labelnomcom)
        Me.Name = "Perfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.menustrip.ResumeLayout(False)
        Me.menustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelnomcom As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbnom As Label
    Friend WithEvents lbapp As Label
    Friend WithEvents lbapm As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbpais As Label
    Friend WithEvents lbcurp As Label
    Friend WithEvents lbrfc As Label
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
