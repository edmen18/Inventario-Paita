Imports System.Data.SqlClient
Public Class Cl_Modelo_Accesorio
    ' guardamos solo en la tabla de modelos
    Public Function guardarmodelo(ByVal CODIGO As String, ByVal descripcion As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardarmodeloaccesorio", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@idmodelo", SqlDbType.VarChar)
            co.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar)
            co.Parameters("@DESCRIPCION").Value = CStr(descripcion)
            co.Parameters("@idmodelo").Value = CStr(CODIGO)
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

    ' guardamos en la tabla donde se relaciona el modelo con el accesorio
    Public Function guardarAccesorio_modelo(ByVal cod_accesorio As String, ByVal modelo As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guarda_modelo_acc", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_accesorio", SqlDbType.VarChar)
            co.Parameters.Add("@cod_modelo", SqlDbType.VarChar)
            co.Parameters("@cod_accesorio").Value = CStr(cod_accesorio)
            co.Parameters("@cod_modelo").Value = CStr(modelo)
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

    Public Function buscar_modelo(ByVal modelo As String, ByVal accesorio As String, ByVal indicador As Integer) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters.Add("@accesorio", SqlDbType.VarChar)
            co.Parameters.Add("@indicador", SqlDbType.Int)
            co.Parameters("@descripcion").Value = CStr(modelo)
            co.Parameters("@accesorio").Value = CStr(accesorio)
            co.Parameters("@indicador").Value = CInt(indicador)
            co.CommandText = "sp_buscar_modelo_acc"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
End Class
