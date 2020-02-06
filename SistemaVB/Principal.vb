Public Class Principal
    Private Sub botonventas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPerfil.Text = Nombre.ToUpper

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim _acceso As FormAcceso = New FormAcceso()
        _acceso.Show()
        Me.Close()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Dim pf As Perfil = New Perfil()
        pf.Show()
        Me.Close()
    End Sub

    Private Sub botonventas_Click_1(sender As Object, e As EventArgs) Handles btnperfilcuenta.Click
        Dim pf As Perfil = New Perfil()
        pf.Show()
        Me.Close()
    End Sub

    Private Sub btndatcon_Click(sender As Object, e As EventArgs) Handles btndatcon.Click
        Dim datcon As DatosContacto = New DatosContacto()
        datcon.Show()
        Me.Close()
    End Sub

    Private Sub btntit_Click(sender As Object, e As EventArgs) Handles btntit.Click

    End Sub

    Private Sub btndatlab_Click(sender As Object, e As EventArgs) Handles btndatlab.Click
        Dim datlab As DatosLaborales = New DatosLaborales()
        datlab.Show()
        Me.Close()
    End Sub

    Private Sub btnprodep_Click(sender As Object, e As EventArgs) Handles btnprodep.Click

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