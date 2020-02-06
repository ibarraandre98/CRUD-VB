Imports MySql.Data.MySqlClient
Imports CapaConexion

Public Class FormAcceso
    Dim _CCConsultas As CCConsultas = New CCConsultas
    Private Sub FormAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbPais.DropDownStyle = ComboBoxStyle.DropDownList
        cbPais.SelectedItem = "México"
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If txtCorreoIniciar.Text = "" Or txtContraseñaIniciar.Text = "" Then
            MessageBox.Show("No debe haber campos en blanco", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim Loguear As MySqlDataReader
            Loguear = _CCConsultas.IniciarSesion(txtCorreoIniciar.Text, txtContraseñaIniciar.Text)

            If Loguear.Read() = True Then
                Dim _principal As Principal = New Principal()
                Contraseña = Loguear("contrasena").ToString
                Correo = Loguear("correo").ToString
                Nombre = Loguear("nombre").ToString
                Paterno = Loguear("apellidop").ToString
                Materno = Loguear("apellidom").ToString
                RFC = Loguear("RFC").ToString
                Curp = Loguear("curp").ToString
                Pais = Loguear("Pais").ToString
                _principal.Show()
                Me.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtCorreoRegistro.Text = "" Or txtContraseñaRegistro.Text = "" Or txtNombre.Text = "" Or txtAP.Text = "" Or txtAM.Text = "" Or txtRFC.Text = "" Or txtCurp.Text = "" Then
            MessageBox.Show("No debe haber campos en blanco", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Try
                _CCConsultas.RegistrarUsuario(txtCorreoRegistro.Text, txtContraseñaRegistro.Text, txtNombre.Text, txtAP.Text, txtAM.Text, txtRFC.Text, txtCurp.Text, cbPais.Text)
                MessageBox.Show("Usuario registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtCorreoRegistro.Clear()
                txtContraseñaRegistro.Clear()
                txtNombre.Clear()
                txtAP.Clear()
                txtAM.Clear()
                txtRFC.Clear()
                txtCurp.Clear()
            Catch ex As MySqlException
                MessageBox.Show("Ya existe un usuario con este correo electronico", "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        End If



    End Sub

    Private Sub txtContraseñaIniciar_Enter(sender As Object, e As EventArgs) Handles txtContraseñaIniciar.Enter
        txtContraseñaIniciar.UseSystemPasswordChar = True
    End Sub

    Private Sub txtContraseñaRegistro_Enter(sender As Object, e As EventArgs) Handles txtContraseñaRegistro.Enter
        txtContraseñaRegistro.UseSystemPasswordChar = True
    End Sub
End Class
