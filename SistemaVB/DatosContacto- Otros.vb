Imports CapaConexion
Imports MySql.Data.MySqlClient

Public Class DatosContacto__Otros
    Private Sub DatosContacto__Otros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarOtrosContactos()
        Dim _header As Header = New Header()
        AbrirFormEnPanel(_header)
        cbservicio.SelectedIndex = 0
    End Sub

    Private Sub MostrarOtrosContactos()
        Dim _CCConsultas As CCConsultas = New CCConsultas()
        dtgOtros.DataSource = _CCConsultas.MostrarOtrosContactos()
    End Sub

    Private Sub AbrirFormEnPanel(ByVal formpanel)
        If (Me.panelheader.Controls.Count > 0) Then
            Me.panelheader.Controls.RemoveAt(0)
        End If
        Dim fp As Form = New Form()
        fp = formpanel
        fp.TopLevel = False
        fp.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fp.Dock = DockStyle.Fill
        panelheader.Controls.Add(fp)
        Me.panelheader.Tag = fp
        fp.Show()
    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Dim _CCConsultas As CCConsultas = New CCConsultas()
        Try
            _CCConsultas.InsertarOtrosContactos(Correo, cbservicio.Text, txtusuario.Text)
            MessageBox.Show("Agregado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtusuario.Clear()
            MostrarOtrosContactos()
        Catch ex As MySqlException
            MessageBox.Show("Ya existe este usuario", "Teléfono duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class