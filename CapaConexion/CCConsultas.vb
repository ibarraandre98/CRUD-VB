Imports MySql.Data.MySqlClient

Public Class CCConsultas

    Private conexion As CCConexion = New CCConexion
    Dim comando As New MySqlCommand
    Dim leer As MySqlDataReader
    Dim tablatelefonos As DataTable = New DataTable()
    Dim tablaotroscontactos As DataTable = New DataTable()

    Function IniciarSesion(ByVal correo, contraseña) As MySqlDataReader
        conexion.CerrarConexion()
        comando.Parameters.Clear()
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "IniciarSesion"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("_correo", correo)
        comando.Parameters.AddWithValue("_contraseña", contraseña)
        leer = comando.ExecuteReader()
        comando.Parameters.Clear()

        Return leer
    End Function

    Public Sub RegistrarUsuario(ByVal correo, contraseña, nombre, apellidop, apellidom, RFC, curp, pais)
        conexion.CerrarConexion()
        comando.Parameters.Clear()
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "RegistrarUsuario"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("_correo", correo)
        comando.Parameters.AddWithValue("_contraseña", contraseña)
        comando.Parameters.AddWithValue("_nombre", nombre)
        comando.Parameters.AddWithValue("_apellidop", apellidop)
        comando.Parameters.AddWithValue("_apellidom", apellidom)
        comando.Parameters.AddWithValue("_RFC", RFC)
        comando.Parameters.AddWithValue("_curp", curp)
        comando.Parameters.AddWithValue("_pais", pais)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Sub InsertarTelefonos(ByVal correo, descripcion, tipo, codpais, numero)
        comando.Parameters.Clear()
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "InsertarTelefonos"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("_numero", numero)
        comando.Parameters.AddWithValue("_correo", correo)
        comando.Parameters.AddWithValue("_descripcion", descripcion)
        comando.Parameters.AddWithValue("_tipo", tipo)
        comando.Parameters.AddWithValue("_codpais", codpais)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Function MostrarTelefonos() As DataTable
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "MostrarTelefonos"
        comando.CommandType = CommandType.StoredProcedure
        leer = comando.ExecuteReader()
        tablatelefonos.Load(leer)
        conexion.CerrarConexion()
        Return tablatelefonos
    End Function

    Public Sub InsertarOtrosContactos(ByVal correo, servicio, usuario)
        comando.Parameters.Clear()
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "InsertarOtrosContactos"
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.AddWithValue("_correo", correo)
        comando.Parameters.AddWithValue("_servicio", servicio)
        comando.Parameters.AddWithValue("_usuario", usuario)
        comando.ExecuteNonQuery()
        comando.Parameters.Clear()
        conexion.CerrarConexion()
    End Sub

    Public Function MostrarOtrosContactos() As DataTable
        comando.Connection = conexion.AbrirConexion()
        comando.CommandText = "MostrarOtrosContactos"
        comando.CommandType = CommandType.StoredProcedure
        leer = comando.ExecuteReader()
        tablaotroscontactos.Load(leer)
        conexion.CerrarConexion()
        Return tablaotroscontactos
    End Function

End Class
