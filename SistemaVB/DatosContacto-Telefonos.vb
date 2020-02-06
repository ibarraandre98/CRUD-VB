Imports MySql.Data.MySqlClient
Imports CapaConexion

Public Class DatosContacto_Telefonos

    Dim _CCConsultas As CCConsultas = New CCConsultas

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

    Private Sub MostrarTelefonos()
        Dim _CCConsultas As CCConsultas = New CCConsultas
        dtgTelefonos.DataSource = _CCConsultas.MostrarTelefonos()
    End Sub

    Private Sub DatosContacto_Telefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTelefonos()
        Dim _header As Header = New Header()
        AbrirFormEnPanel(_header)
        cbTel.SelectedIndex = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        Try
            _CCConsultas.InsertarTelefonos(Correo, txtdesc.Text, cbTel.Text, txtcodpa.Text, txtnum.Text)
            MessageBox.Show("Agregado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtcodpa.Clear()
            txtdesc.Clear()
            txtnum.Clear()
            MostrarTelefonos()
        Catch ex As MySqlException
            MessageBox.Show("Ya existe este teléfono", "Teléfono duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
End Class