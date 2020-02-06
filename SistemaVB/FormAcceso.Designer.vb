<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAcceso
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
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorreoIniciar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContraseñaIniciar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCorreoRegistro = New System.Windows.Forms.TextBox()
        Me.txtContraseñaRegistro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCurp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAcceder
        '
        Me.btnAcceder.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Location = New System.Drawing.Point(239, 290)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(75, 23)
        Me.btnAcceder.TabIndex = 0
        Me.btnAcceder.Text = "ACCEDER"
        Me.btnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dirección de correo eletrónico: "
        '
        'txtCorreoIniciar
        '
        Me.txtCorreoIniciar.Location = New System.Drawing.Point(41, 187)
        Me.txtCorreoIniciar.MaxLength = 50
        Me.txtCorreoIniciar.Name = "txtCorreoIniciar"
        Me.txtCorreoIniciar.Size = New System.Drawing.Size(273, 20)
        Me.txtCorreoIniciar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'txtContraseñaIniciar
        '
        Me.txtContraseñaIniciar.Location = New System.Drawing.Point(41, 241)
        Me.txtContraseñaIniciar.MaxLength = 15
        Me.txtContraseñaIniciar.Name = "txtContraseñaIniciar"
        Me.txtContraseñaIniciar.Size = New System.Drawing.Size(273, 20)
        Me.txtContraseñaIniciar.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(79, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "INICIO DE SESIÓN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(462, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "REGISTRARSE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(382, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dirección de correo eletrónico: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(364, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 432)
        Me.Panel1.TabIndex = 8
        '
        'txtCorreoRegistro
        '
        Me.txtCorreoRegistro.Location = New System.Drawing.Point(385, 98)
        Me.txtCorreoRegistro.MaxLength = 50
        Me.txtCorreoRegistro.Name = "txtCorreoRegistro"
        Me.txtCorreoRegistro.Size = New System.Drawing.Size(273, 20)
        Me.txtCorreoRegistro.TabIndex = 9
        '
        'txtContraseñaRegistro
        '
        Me.txtContraseñaRegistro.Location = New System.Drawing.Point(385, 142)
        Me.txtContraseñaRegistro.MaxLength = 15
        Me.txtContraseñaRegistro.Name = "txtContraseñaRegistro"
        Me.txtContraseñaRegistro.Size = New System.Drawing.Size(273, 20)
        Me.txtContraseñaRegistro.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Contraseña:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(385, 187)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(273, 20)
        Me.txtNombre.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(382, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre(s):"
        '
        'txtAP
        '
        Me.txtAP.Location = New System.Drawing.Point(385, 231)
        Me.txtAP.MaxLength = 20
        Me.txtAP.Name = "txtAP"
        Me.txtAP.Size = New System.Drawing.Size(273, 20)
        Me.txtAP.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(382, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Apellido paterno:"
        '
        'txtAM
        '
        Me.txtAM.Location = New System.Drawing.Point(385, 274)
        Me.txtAM.MaxLength = 20
        Me.txtAM.Name = "txtAM"
        Me.txtAM.Size = New System.Drawing.Size(273, 20)
        Me.txtAM.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(382, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Apellido materno:"
        '
        'txtRFC
        '
        Me.txtRFC.Location = New System.Drawing.Point(385, 320)
        Me.txtRFC.MaxLength = 13
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(273, 20)
        Me.txtRFC.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(382, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "RFC:"
        '
        'txtCurp
        '
        Me.txtCurp.Location = New System.Drawing.Point(385, 367)
        Me.txtCurp.MaxLength = 18
        Me.txtCurp.Name = "txtCurp"
        Me.txtCurp.Size = New System.Drawing.Size(273, 20)
        Me.txtCurp.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(382, 348)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "CURP:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(382, 399)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 16)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "País de nacimiento:"
        '
        'cbPais
        '
        Me.cbPais.Items.AddRange(New Object() {"Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea ecuatorial", "Guinea-Bisáu", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República de Macedonia", "República del Congo", "República Democrática del Congo", "República Dominicana", "República Sudafricana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue"})
        Me.cbPais.Location = New System.Drawing.Point(385, 418)
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(273, 21)
        Me.cbPais.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(467, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "CREAR CUENTA"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FormAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 508)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbPais)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCurp)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAM)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtContraseñaRegistro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCorreoRegistro)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContraseñaIniciar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCorreoIniciar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAcceder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAcceder As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCorreoIniciar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContraseñaIniciar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCorreoRegistro As TextBox
    Friend WithEvents txtContraseñaRegistro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCurp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbPais As ComboBox
    Friend WithEvents Button1 As Button
End Class
