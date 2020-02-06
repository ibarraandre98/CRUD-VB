Imports MySql.Data.MySqlClient
Public Class CCConexion
    Dim Conexion As New MySqlConnection

    Private Function metodoconexion() As MySqlConnection
        Conexion.ConnectionString = "Server = localhost; Port = 3320; Database = sistemavb; Uid = root; Pwd = muski;"
        Return Conexion
    End Function


    Function AbrirConexion() As MySqlConnection

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.ConnectionString = "Server = localhost; Port = 3320; Database = sistemavb; Uid = root; Pwd = muski;"
                Conexion.Open()
            End If
        Catch ex As Exception

        End Try
        Return Conexion
    End Function

    Function CerrarConexion() As MySqlConnection
        Try
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        Catch ex As Exception
        End Try
        Return Conexion
    End Function
End Class
