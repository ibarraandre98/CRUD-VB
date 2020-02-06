Public Class Perfil
    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPerfil.Text = Nombre.ToUpper
        labelnomcom.Text = Nombre.ToUpper & " " & Paterno.ToUpper & " " & Materno.ToUpper
        lbnom.Text = Nombre.ToUpperInvariant
        lbapp.Text = Paterno.ToUpperInvariant
        lbapm.Text = Materno.ToUpperInvariant
        lbpais.Text = Pais.ToUpperInvariant
        lbcurp.Text = Curp.ToUpperInvariant
        lbrfc.Text = RFC.ToUpperInvariant
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub MENÚPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENÚPRINCIPALToolStripMenuItem.Click
        Dim _principal As Principal = New Principal()
        _principal.Show()
        Me.Close()
    End Sub

    Private Sub PERFILYCUENTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERFILYCUENTAToolStripMenuItem.Click
        Dim _perfil As Perfil = New Perfil()
        _perfil.Show()
        Me.Close()
    End Sub

    Private Sub DATOSDECONTACTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSDECONTACTOToolStripMenuItem.Click
        Dim _datosdecontacto As DatosContacto = New DatosContacto()
        _datosdecontacto.Show()
        Me.Close()
    End Sub

    Private Sub DATOSLABORALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSLABORALESToolStripMenuItem.Click
        Dim _datoslaborales As DatosLaborales = New DatosLaborales()
        _datoslaborales.Show()
        Me.Close()
    End Sub

    Private Sub TÍTULOSACADÉMICOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TÍTULOSACADÉMICOSToolStripMenuItem.Click
        Dim _titulosacademicos As TitulosAcademicos = New TitulosAcademicos()
        _titulosacademicos.Show()
        Me.Close()
    End Sub

    Private Sub PRODEPCONACYTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODEPCONACYTToolStripMenuItem.Click
        Dim _prodepconacyt As PRODEPCONACYT = New PRODEPCONACYT()
        _prodepconacyt.Show()
        Me.Close()
    End Sub

    Private Sub PRODUCTIVIDADACADÉMICAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTIVIDADACADÉMICAToolStripMenuItem.Click
        Dim _productividadacademica As PRODUCTIVIDAD_ACADÉMICA = New PRODUCTIVIDAD_ACADÉMICA()
        _productividadacademica.Show()
        Me.Close()
    End Sub

    Private Sub DISTINCIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DISTINCIONESToolStripMenuItem.Click
        Dim _distinciones As Distinciones = New Distinciones()
        _distinciones.Show()
        Me.Close()
    End Sub

    Private Sub ASOCIACIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASOCIACIONESToolStripMenuItem.Click
        Dim _asociaciones As Asociaciones = New Asociaciones()
        _asociaciones.Show()
        Me.Close()
    End Sub

End Class