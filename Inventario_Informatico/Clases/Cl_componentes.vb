Imports System.Data.SqlClient
Public Class Cl_componentes
    '**************** interfaz marca de componente *******************
    Public Function componente() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_mostrarcomponente"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    Public Function cod_componente(ByVal descripcion As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@componente", SqlDbType.VarChar)
            co.Parameters("@componente").Value = CStr(descripcion)
            co.CommandText = "sp_mostrar_cod_componente"
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
            co.CommandText = "sp_generarcodigomarcadecomponente"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function guardarmarca(ByVal CODIGO As String, ByVal descripcion As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardarmarcacomponente", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@idMARCA", SqlDbType.VarChar)
            co.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar)
            co.Parameters("@DESCRIPCION").Value = CStr(descripcion)
            co.Parameters("@idMARCA").Value = CStr(CODIGO)
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
    Public Function guardarCOMPONENTE_marca(ByVal cod_componente As String, ByVal descripcion As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guarda_marca_componente", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_componente", SqlDbType.VarChar)
            co.Parameters.Add("@cod_marcac", SqlDbType.VarChar)
            co.Parameters("@cod_componente").Value = CStr(cod_componente)
            co.Parameters("@cod_marcac").Value = CStr(descripcion)
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
    '******************** fin interfaz marca componente *******************
    ' ***********interfaz buscar marca componente *******
    Public Function buscar_marca(ByVal marca As String, ByVal indicador As Integer, ByVal accesorio As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters.Add("@indicador", SqlDbType.Int)
            co.Parameters.Add("@cod_accesorio", SqlDbType.VarChar)
            co.Parameters("@descripcion").Value = CStr(marca)
            co.Parameters("@indicador").Value = CInt(indicador)
            co.Parameters("@cod_accesorio").Value = CStr(accesorio)
            co.CommandText = "sp_buscar_marca_componente"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    '************ fin interfaz buscar marca componente **********
    '************ INTERFAZ MODELO COMPONENTES ********************
    Public Function GENARAR_COD_Modelo() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarcodigomodelodecomponente"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function guardarmodelo(ByVal CODIGO As String, ByVal descripcion As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardarmodelocomponente", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@idModelo", SqlDbType.VarChar)
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
    Public Function guardarCOMPONENTE_modelo(ByVal cod_componente As String, ByVal cod_modelo As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guarda_modelo_cmp", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_accesorio", SqlDbType.VarChar)
            co.Parameters.Add("@cod_modelo", SqlDbType.VarChar)
            co.Parameters("@cod_accesorio").Value = CStr(cod_componente)
            co.Parameters("@cod_modelo").Value = CStr(cod_modelo)
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
    '******************* FIN INTERFAZ  ***************************

    '******************* INTERFAZ BUSCAR MODELO ***************
    Public Function buscar_MODELO(ByVal MODELO As String, ByVal indicador As Integer, ByVal accesorio As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters.Add("@indicador", SqlDbType.Int)
            co.Parameters.Add("@accesorio", SqlDbType.VarChar)
            co.Parameters("@descripcion").Value = CStr(MODELO)
            co.Parameters("@indicador").Value = CInt(indicador)
            co.Parameters("@accesorio").Value = CStr(accesorio)
            co.CommandText = "sp_buscar_modelo_CMP"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    ' *****************************FIN INTERFAZ ****************************

End Class
