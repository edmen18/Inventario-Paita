Imports System.Data.SqlClient
Public Class Cl_usuario_sistema
    Public Function generar_usuario() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generar_usuario_sistema"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function guardar_usuario(ByVal cod_usuario As String, ByVal nombre As String, ByVal apellido As String, ByVal usuario As String, ByVal clave As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardar_usuario_sistema ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_usuario", SqlDbType.VarChar)
            co.Parameters.Add("@nombre", SqlDbType.VarChar)
            co.Parameters.Add("@apellido", SqlDbType.VarChar)
            co.Parameters.Add("@usuario", SqlDbType.VarChar)
            co.Parameters.Add("@clave", SqlDbType.VarChar)
            co.Parameters("@COD_usuario").Value = (cod_usuario)
            co.Parameters("@nombre").Value = (nombre)
            co.Parameters("@apellido").Value = (apellido)
            co.Parameters("@usuario").Value = (usuario)
            co.Parameters("@clave").Value = (clave)
            cn.Open()
            co.ExecuteNonQuery()
            '
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn IsNot Nothing AndAlso cn.State <> ConnectionState.Closed Then
                cn.Close()
                co = Nothing
            End If
        End Try
    End Function
    '********************************* ENCRIPTAR LAS CLAVES *****************************************
    Private patron_busqueda As String = "0ABIZ2ÑebDNOEcwGl6oSñixq1…"
    Private Patron_encripta As String = "vQÑO8dk1VgIPZxAR3UsLD6XBz…"
    'Los patrones están aquí sin terminar por falta de espacio.

    Public Function EncriptarCadena(ByVal cadena As String) As String

        Dim idx As Integer
        Dim result As String = ""
        For idx = 0 To cadena.Length - 1
            result += EncriptarCaracter(cadena.Substring(idx, 1), cadena.Length, idx)
        Next
        Return result

    End Function

    Private Function EncriptarCaracter(ByVal caracter As String, ByVal variable As Integer, ByVal a_indice As Integer) As String

        Dim caracterEncriptado As String, indice As Integer

        If patron_busqueda.IndexOf(caracter) <> -1 Then
            indice = (patron_busqueda.IndexOf(caracter) + variable + a_indice) Mod patron_busqueda.Length
            Return Patron_encripta.Substring(indice, 1)
        End If

        Return caracter

    End Function
    '******************************** FIN ENCRIPTAR ***********************

    '****************************iniciar sesion  *********************
    Public Function iniciarsesion(ByVal usuario As String, ByVal clave As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@usuario", SqlDbType.VarChar)
            co.Parameters.Add("@clave", SqlDbType.VarChar)
            co.Parameters("@usuario").Value = CStr(usuario)
            co.Parameters("@clave").Value = CStr(clave)
            co.CommandText = "sp_inicio_sesion"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    '********************** fin iniciar sesion *******************
    Public Function editarclave(ByVal cod_usuario As String, ByVal clave As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_editar_clave ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_usuario", SqlDbType.VarChar)
            co.Parameters.Add("@Clave", SqlDbType.VarChar)
            co.Parameters("@COD_usuario").Value = CStr(cod_usuario)
            co.Parameters("@clave").Value = CStr(clave)
            cn.Open()
            co.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn IsNot Nothing AndAlso cn.State <> ConnectionState.Closed Then
                cn.Close()
                co = Nothing
            End If
        End Try
    End Function
End Class
