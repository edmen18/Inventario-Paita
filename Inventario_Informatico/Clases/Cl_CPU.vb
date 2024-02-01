Imports System.Data.SqlClient
Public Class Cl_CPU
    Public Function generar_CPU() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarcpu"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function generar_detalleCPU() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generardetallecpu"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrar_CPUs() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_mostrarcpu"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrarcomponentes(ByVal cpu As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COd_cpu", SqlDbType.NChar)
            co.Parameters("@COD_cpu").Value = (cpu)
            co.CommandText = "sp_mostrarcomponentescpu"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrarcomponentesacc(ByVal cpu As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@Cpu", SqlDbType.NChar)
            co.Parameters("@cpu").Value = (cpu)
            co.CommandText = "sp_buscarcmpacc"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrarmodelocmp(ByVal modelo As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COd_modeloc", SqlDbType.NChar)
            co.Parameters("@COD_modeloc").Value = (modelo)
            co.CommandText = "sp_mostrarmodeloc"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrarmarcacmp(ByVal marca As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COd_marcac", SqlDbType.NChar)
            co.Parameters("@COD_marcac").Value = (marca)
            co.CommandText = "sp_mostrarmarcac"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    Public Function BUSCAR_CPU(ByVal usuario As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COd_usuario", SqlDbType.NChar)
            co.Parameters("@COD_usuario").Value = (usuario)
            co.CommandText = "sp_buscarcpu"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    Public Function BUSCAR_CPUIP(ByVal IP As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@IP", SqlDbType.VarChar)
            co.Parameters("@IP").Value = (IP)
            co.CommandText = "SP_BUSCARCPUIP"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    Public Function BUSCAR_CPUSBN(ByVal SBN As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@SBN", SqlDbType.VarChar)
            co.Parameters("@SBN").Value = (SBN)
            co.CommandText = "sp_buscarcpuSBN"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    Public Function guardarCPU(ByVal COD_CPU As String, ByVal COLOR As String, ByVal marca As String, ByVal TIPO As String, ByVal MODELO As String, ByVal cod_USUARIO As String, ByVal cod_SBN As String, ByVal DIR_IP As String, ByVal CON_INTERNET As String, ByVal CON_RED As String, ByVal ESTADO As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardarCPU ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_CPU", SqlDbType.VarChar)
            co.Parameters.Add("@COLOR", SqlDbType.VarChar)
            co.Parameters.Add("@marca", SqlDbType.VarChar)
            co.Parameters.Add("@TIPO", SqlDbType.VarChar)
            co.Parameters.Add("@MODELO", SqlDbType.VarChar)
            co.Parameters.Add("@cod_USUARIO", SqlDbType.VarChar)
            co.Parameters.Add("@cod_SBN", SqlDbType.VarChar)
            co.Parameters.Add("@DIR_IP", SqlDbType.VarChar)
            co.Parameters.Add("@CON_INTERNET", SqlDbType.NChar)
            co.Parameters.Add("@CON_RED", SqlDbType.NChar)
            co.Parameters.Add("@ESTADO", SqlDbType.VarChar)
            co.Parameters("@COD_CPU").Value = (COD_CPU)
            co.Parameters("@color").Value = (COLOR)
            co.Parameters("@marca").Value = (marca)
            co.Parameters("@TIPO").Value = (TIPO)
            co.Parameters("@MODELO").Value = (MODELO)
            co.Parameters("@cod_USUARIO").Value = (cod_USUARIO)
            co.Parameters("@cod_SBN").Value = (cod_SBN)
            co.Parameters("@DIR_IP").Value = (DIR_IP)
            co.Parameters("@CON_INTERNET").Value = (CON_INTERNET)
            co.Parameters("@CON_RED").Value = (CON_RED)
            co.Parameters("@ESTADO").Value = (ESTADO)
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
    Public Function editarCPU(ByVal COD_CPU As String, ByVal COLOR As String, ByVal marca As String, ByVal TIPO As String, ByVal MODELO As String, ByVal cod_USUARIO As String, ByVal cod_SBN As String, ByVal DIR_IP As String, ByVal CON_INTERNET As String, ByVal CON_RED As String, ByVal estado As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_editarCPU ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_CPU", SqlDbType.VarChar)
            co.Parameters.Add("@COLOR", SqlDbType.VarChar)
            co.Parameters.Add("@marca", SqlDbType.VarChar)
            co.Parameters.Add("@TIPO", SqlDbType.VarChar)
            co.Parameters.Add("@MODELO", SqlDbType.VarChar)
            co.Parameters.Add("@cod_USUARIO", SqlDbType.VarChar)
            co.Parameters.Add("@cod_SBN", SqlDbType.VarChar)
            co.Parameters.Add("@DIR_IP", SqlDbType.VarChar)
            co.Parameters.Add("@CON_INTERNET", SqlDbType.NChar)
            co.Parameters.Add("@CON_RED", SqlDbType.NChar)
            co.Parameters.Add("@estado", SqlDbType.VarChar)
            co.Parameters("@COD_CPU").Value = (COD_CPU)
            co.Parameters("@color").Value = (COLOR)
            co.Parameters("@marca").Value = (marca)
            co.Parameters("@TIPO").Value = (TIPO)
            co.Parameters("@MODELO").Value = (MODELO)
            co.Parameters("@cod_USUARIO").Value = (cod_USUARIO)
            co.Parameters("@cod_SBN").Value = (cod_SBN)
            co.Parameters("@DIR_IP").Value = (DIR_IP)
            co.Parameters("@CON_INTERNET").Value = (CON_INTERNET)
            co.Parameters("@CON_RED").Value = (CON_RED)
            co.Parameters("@estado").Value = (estado)
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

    Public Function guardardetalleCPU(ByVal COD_CPU As String, ByVal COd_componente As String, ByVal cod_marca As String, ByVal cod_modeloc As String, ByVal capacidad As String, ByVal serie As String, ByVal velosidad As String, ByVal tipo As String, ByVal estado As String, ByVal sbn As String, ByVal observaciones As String, ByVal item As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardardetalleCPU ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_CPU", SqlDbType.VarChar)
            co.Parameters.Add("@Cod_componente", SqlDbType.VarChar)
            co.Parameters.Add("@cod_marcac", SqlDbType.VarChar)
            co.Parameters.Add("@cod_modeloc", SqlDbType.VarChar)
            co.Parameters.Add("@capacidad", SqlDbType.VarChar)
            co.Parameters.Add("@serie", SqlDbType.VarChar)
            co.Parameters.Add("@velosidad", SqlDbType.VarChar)
            co.Parameters.Add("@tipo", SqlDbType.VarChar)
            co.Parameters.Add("@estado", SqlDbType.NChar)
            co.Parameters.Add("@sbn", SqlDbType.Char)
            co.Parameters.Add("@obs", SqlDbType.NChar)
            co.Parameters.Add("@item", SqlDbType.VarChar)

            co.Parameters("@COD_CPU").Value = (COD_CPU)
            co.Parameters("@cod_componente").Value = (COd_componente)
            co.Parameters("@cod_marcac").Value = (cod_marca)
            co.Parameters("@cod_modeloc").Value = (cod_modeloc)
            co.Parameters("@capacidad").Value = (capacidad)
            co.Parameters("@serie").Value = (serie)
            co.Parameters("@velosidad").Value = (velosidad)
            co.Parameters("@tipo").Value = (tipo)
            co.Parameters("@estado").Value = (estado)
            co.Parameters("@sbn").Value = sbn
            co.Parameters("@obs").Value = observaciones
            co.Parameters("@item").Value = item

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
    Public Function EditardetalleCPU(ByVal item As String, ByVal COd_componente As String, ByVal cod_marca As String, ByVal cod_modeloc As String, ByVal capacidad As String, ByVal serie As String, ByVal velosidad As String, ByVal tipo As String, ByVal estado As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_EditardetalleCPU ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@Cod_componente", SqlDbType.VarChar)
            co.Parameters.Add("@cod_marcac", SqlDbType.VarChar)
            co.Parameters.Add("@cod_modeloc", SqlDbType.VarChar)
            co.Parameters.Add("@capacidad", SqlDbType.VarChar)
            co.Parameters.Add("@serie", SqlDbType.VarChar)
            co.Parameters.Add("@velosidad", SqlDbType.VarChar)
            co.Parameters.Add("@tipo", SqlDbType.VarChar)
            co.Parameters.Add("@estado", SqlDbType.NChar)
            co.Parameters.Add("@item", SqlDbType.VarChar)

            co.Parameters("@item").Value = (item)
            co.Parameters("@cod_componente").Value = (COd_componente)
            co.Parameters("@cod_marcac").Value = (cod_marca)
            co.Parameters("@cod_modeloc").Value = (cod_modeloc)
            co.Parameters("@capacidad").Value = (capacidad)
            co.Parameters("@serie").Value = (serie)
            co.Parameters("@velosidad").Value = (velosidad)
            co.Parameters("@tipo").Value = (tipo)
            co.Parameters("@estado").Value = (estado)
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
    Public Function EliminardetalleCPU(ByVal item As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_Eliminardetalle ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@item", SqlDbType.VarChar)
            co.Parameters("@item").Value = (item)
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
End Class
