Imports System.Data.SqlClient
Public Class Cl_usuarios
    ' guardar usuario
    Public Function guardarUsuario(ByVal dni As String, ByVal nombre As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal cod_area As String, ByVal cod_usuario As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardar_usuario ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@dni", SqlDbType.VarChar)
            co.Parameters.Add("@nombre", SqlDbType.VarChar)
            co.Parameters.Add("@apellidos", SqlDbType.VarChar)
            co.Parameters.Add("@direccion", SqlDbType.VarChar)
            co.Parameters.Add("@telefono", SqlDbType.VarChar)
            co.Parameters.Add("@cod_area", SqlDbType.VarChar)
            co.Parameters.Add("@cod_usuario", SqlDbType.VarChar)
            co.Parameters("@dni").Value = CStr(dni)
            co.Parameters("@nombre").Value = CStr(nombre)
            co.Parameters("@apellidos").Value = CStr(apellidos)
            co.Parameters("@direccion").Value = CStr(direccion)
            co.Parameters("@telefono").Value = CStr(telefono)
            co.Parameters("@cod_area").Value = CStr(cod_area)
            co.Parameters("@cod_usuario").Value = CStr(cod_usuario)
            cn.Open()
            co.ExecuteNonQuery()
            'MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn IsNot Nothing AndAlso cn.State <> ConnectionState.Closed Then
                cn.Close()
                co = Nothing
            End If
        End Try
    End Function
    'editar los datos del usuario
    Public Function editarUsuario(ByVal dni As String, ByVal nombre As String, ByVal apellidos As String, ByVal direccion As String, ByVal telefono As String, ByVal cod_area As String, ByVal cod_usuario As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_editar_usuario ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@dni", SqlDbType.VarChar)
            co.Parameters.Add("@nombre", SqlDbType.VarChar)
            co.Parameters.Add("@apellidos", SqlDbType.VarChar)
            co.Parameters.Add("@direccion", SqlDbType.VarChar)
            co.Parameters.Add("@telefono", SqlDbType.VarChar)
            co.Parameters.Add("@cod_area", SqlDbType.VarChar)
            co.Parameters.Add("@cod_usuario", SqlDbType.VarChar)
            co.Parameters("@dni").Value = CStr(dni)
            co.Parameters("@nombre").Value = CStr(nombre)
            co.Parameters("@apellidos").Value = CStr(apellidos)
            co.Parameters("@direccion").Value = CStr(direccion)
            co.Parameters("@telefono").Value = CStr(telefono)
            co.Parameters("@cod_area").Value = CStr(cod_area)
            co.Parameters("@cod_usuario").Value = CStr(cod_usuario)
            cn.Open()
            co.ExecuteNonQuery()
            'MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn IsNot Nothing AndAlso cn.State <> ConnectionState.Closed Then
                cn.Close()
                co = Nothing
            End If
        End Try
    End Function
    ' listar usuarios en la grilla por descripcion
    Public Function ListarUsuarios() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_listarusuarios"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function COD_Usuarios(ByVal var As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@variable", SqlDbType.VarChar)
            co.Parameters("@variable").Value = CStr(var)
            co.CommandText = "sp_cod_usuario"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    ' generar el código corelativo del usuario
    Public Function GENARARUSUARIO() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarusuario"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function listarusuarios1() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_listar_usuarios"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
End Class
