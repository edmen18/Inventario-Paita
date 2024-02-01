Imports System.Data.SqlClient
Public Class CL_MARCA_ACCESORIO
    Public Function accesorio() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_mostraraccesorio"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function cod_accesorio(ByVal descripcion As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@accesorio", SqlDbType.VarChar)
            co.Parameters("@accesorio").Value = CStr(descripcion)
            co.CommandText = "sp_mostrar_cod_accesorio"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function GENARAR_COD_MARCA() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarcodigomarcadeaccesorio"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    Public Function buscar_marca(ByVal marca As String, ByVal indicador As Integer, ByVal accesorio As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters.Add("@indicador", SqlDbType.Int)
            co.Parameters.Add("@cod_componente", SqlDbType.VarChar)
            co.Parameters("@descripcion").Value = CStr(marca)
            co.Parameters("@indicador").Value = CInt(indicador)
            co.Parameters("@cod_COMPONENTE").Value = CStr(accesorio)
            co.CommandText = "sp_buscar_marca_acc"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
End Class
