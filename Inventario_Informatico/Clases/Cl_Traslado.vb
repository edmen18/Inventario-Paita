Imports System.Data.SqlClient
Public Class Cl_Traslado
    Public Function guardartraslado(ByVal documento As String, ByVal usuario_de As String, ByVal usuario_a As String, ByVal descripcion As String, ByVal marca As String, ByVal modelo As String, ByVal serie As String, ByVal cod_sbn As String, ByVal velosidad As String, ByVal capacidad As String, ByVal area_de As String, ByVal area_a As String, ByVal fecha As Date) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardar_traslado ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@documento", SqlDbType.VarChar)
            co.Parameters.Add("@usuario_de", SqlDbType.VarChar)
            co.Parameters.Add("@usuario_a", SqlDbType.VarChar)
            co.Parameters.Add("@descripciom", SqlDbType.VarChar)
            co.Parameters.Add("@marca", SqlDbType.VarChar)
            co.Parameters.Add("@modelo", SqlDbType.VarChar)
            co.Parameters.Add("@serie", SqlDbType.VarChar)
            co.Parameters.Add("@cod_sbn", SqlDbType.Char)
            co.Parameters.Add("@velosidad", SqlDbType.Char)
            co.Parameters.Add("@capacidad", SqlDbType.Char)
            co.Parameters.Add("@area_de", SqlDbType.VarChar)
            co.Parameters.Add("@area_a", SqlDbType.VarChar)
            co.Parameters.Add("@fecha", SqlDbType.DateTime)
            'asignacion de valores
            co.Parameters("@Documento").Value = CStr(documento)
            co.Parameters("@usuario_de").Value = CStr(usuario_de)
            co.Parameters("@usuario_a").Value = CStr(usuario_a)
            co.Parameters("@descripciom").Value = CStr(descripcion)
            co.Parameters("@marca").Value = CStr(marca)
            co.Parameters("@modelo").Value = CStr(modelo)
            co.Parameters("@serie").Value = CStr(serie)
            co.Parameters("@cod_sbn").Value = CStr(cod_sbn)
            co.Parameters("@velosidad").Value = CStr(velosidad)
            co.Parameters("@capacidad").Value = CStr(capacidad)
            co.Parameters("@area_de").Value = CStr(area_de)
            co.Parameters("@area_a").Value = CStr(area_a)
            co.Parameters("@fecha").Value = CDate(fecha)
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
    Public Function editar_traslado(ByVal item As String, ByVal cod_cpu As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("SP_EDITAR_TRASLADO ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_cpu", SqlDbType.VarChar)
            co.Parameters.Add("@item", SqlDbType.VarChar)

            co.Parameters("@COD_cpu").Value = (cod_cpu)
            co.Parameters("@item").Value = (item)
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
    Public Function mostrar_TRASLADOS(ByVal FECHAINI As Date, ByVal FECHAFIN As Date) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@FECHAINI", SqlDbType.DateTime)
            co.Parameters.Add("@FECHAFIN", SqlDbType.DateTime)
            co.Parameters("@FECHAINI").Value = CStr(FECHAINI)
            co.Parameters("@FECHAFIN").Value = CStr(FECHAFIN)
            co.CommandText = "sp_TRASLADOS"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

End Class
