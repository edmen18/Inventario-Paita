Imports System.Data.SqlClient
Public Class Cl_Accesorios
    Public Function guardarAccesorio(ByVal item As String, ByVal COD_accesorio As String, ByVal cod_marca As String, ByVal serie As String, ByVal cod_patrimonial As String, ByVal cod_modelo As String, ByVal cod_usuario As String, ByVal estado_actual As String, ByVal observaciones As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardaraccesorio ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@item", SqlDbType.VarChar)
            co.Parameters.Add("@cod_accesorio", SqlDbType.VarChar)
            co.Parameters.Add("@cod_marca", SqlDbType.VarChar)
            co.Parameters.Add("@serie", SqlDbType.VarChar)
            co.Parameters.Add("@cod_patrimonial", SqlDbType.VarChar)
            co.Parameters.Add("@cod_modelo", SqlDbType.VarChar)
            co.Parameters.Add("@cod_usuario", SqlDbType.VarChar)
            co.Parameters.Add("@estado_actual", SqlDbType.VarChar)
            co.Parameters.Add("@observaciones", SqlDbType.VarChar)
            co.Parameters("@item").Value = (item)
            co.Parameters("@cod_accesorio").Value = (COD_accesorio)
            co.Parameters("@cod_marca").Value = (cod_marca)
            co.Parameters("@serie").Value = (serie)
            co.Parameters("@cod_patrimonial").Value = (cod_patrimonial)
            co.Parameters("@cod_modelo").Value = (cod_modelo)
            co.Parameters("@cod_usuario").Value = (cod_usuario)
            co.Parameters("@estado_actual").Value = (estado_actual)
            co.Parameters("@observaciones").Value = (observaciones)
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
    ' editar accesorio
    Public Function EditarAccesorio(ByVal COD_CPU As String, ByVal cod_COMPONENTE As String, ByVal COD_MARCA As String, ByVal SERIE As String, ByVal cod_SBN As String, ByVal cod_MODELO As String, ByVal estado_actual As String, ByVal observaciones As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_editaraccesorio ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_CPU", SqlDbType.VarChar)
            co.Parameters.Add("@cod_COMPONENTE", SqlDbType.VarChar)
            co.Parameters.Add("@COD_MARCA", SqlDbType.VarChar)
            co.Parameters.Add("@SERIE", SqlDbType.VarChar)
            co.Parameters.Add("@cod_SBN", SqlDbType.VarChar)
            co.Parameters.Add("@cod_MODELO", SqlDbType.VarChar)
            co.Parameters.Add("@estado_actual", SqlDbType.VarChar)
            co.Parameters.Add("@observaciones", SqlDbType.VarChar)

            co.Parameters("@cod_CPU").Value = (COD_CPU)
            co.Parameters("@cod_COMPONENTE").Value = (cod_COMPONENTE)
            co.Parameters("@COD_MARCA").Value = (COD_MARCA)
            co.Parameters("@SERIE").Value = (SERIE)
            co.Parameters("@cod_SBN").Value = (cod_SBN)
            co.Parameters("@cod_MODELO").Value = (cod_MODELO)
            co.Parameters("@estado_actual").Value = (estado_actual)
            co.Parameters("@observaciones").Value = (observaciones)
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
    'buscar accesorios
    Public Function buscar_accesorios(ByVal codigo As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_cpu", SqlDbType.VarChar)
            co.Parameters("@cod_cpu").Value = CStr(codigo)
            co.CommandText = "sp_buscaraccesorio"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function generar_item() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generar_item"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
End Class
