Public Class DatosContacto
    Private Sub DatosContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPerfil.Text = Nombre.ToUpper
    End Sub

    Private Sub MENÚPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Private Sub btnperfilcuenta_Click(sender As Object, e As EventArgs) Handles btnperfilcuenta.Click
        Dim _telefonos As DatosContacto_Telefonos = New DatosContacto_Telefonos()
        _telefonos.Show()
        Me.Close()
    End Sub

    Private Sub btndatlab_Click(sender As Object, e As EventArgs) Handles btndatlab.Click
        Dim _otroscontactos As DatosContacto__Otros = New DatosContacto__Otros()
        _otroscontactos.Show()
        Me.Close()
    End Sub
End Class