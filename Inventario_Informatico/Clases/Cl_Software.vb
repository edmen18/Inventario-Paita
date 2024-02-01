Imports System.Data.SqlClient
Public Class Cl_Software
    'generar codigo de software
    Public Function generarsoftware() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarsoftware"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    'generar software cpu
    Public Function generarsoftwarecpu() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarcpusoft"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    'guardar software
    Public Function guardarsoftware(ByVal cod_soft As String, ByVal descripcion As String, ByVal version As String, ByVal tipo As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardar_software ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_soft", SqlDbType.VarChar)
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters.Add("@version", SqlDbType.Char)
            co.Parameters.Add("@tipo", SqlDbType.VarChar)
            co.Parameters("@cod_soft").Value = (cod_soft)
            co.Parameters("@descripcion").Value = (descripcion)
            co.Parameters("@version").Value = (version)
            co.Parameters("@tipo").Value = (tipo)
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
    Public Function guardarsoftwarecpu(ByVal cod_cpu As String, ByVal cod_soft As String, ByVal item As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardarcpusoft ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_cpu", SqlDbType.VarChar)
            co.Parameters.Add("@cod_soft", SqlDbType.VarChar)
            co.Parameters.Add("@item", SqlDbType.VarChar)
            co.Parameters("@cod_cpu").Value = (cod_cpu)
            co.Parameters("@cod_soft").Value = (cod_soft)
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
    Public Function editarsoftware(ByVal cod_soft As String, ByVal descripcion As String, ByVal version As String, ByVal tipo As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_editar_software ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cod_soft", SqlDbType.VarChar)
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters.Add("@version", SqlDbType.Char)
            co.Parameters.Add("@tipo", SqlDbType.VarChar)
            co.Parameters("@cod_soft").Value = (cod_soft)
            co.Parameters("@descripcion").Value = (descripcion)
            co.Parameters("@version").Value = (version)
            co.Parameters("@tipo").Value = (tipo)
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
    Public Function mostrar_SOFWARE() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "LISTAR_SOFTWARE"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function buscar_SOFWARE(ByVal descripcion As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters("@descripcion").Value = CStr(descripcion)
            co.CommandText = "sp_buscarsoftware"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function

    ' MOSTRAR SOFWARE POR CPU

    Public Function mostrar_SOFWARECPU(ByVal CPU As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@COD_CPU", SqlDbType.VarChar)
            co.Parameters("@COD_CPU").Value = CStr(CPU)
            co.CommandText = "SP_MOSTRARSW"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrarswlista(ByVal cpu As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@cpu", SqlDbType.VarChar)
            co.Parameters("@cpu").Value = CStr(cpu)
            co.CommandText = "sp_swmostrarlista"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    'eliminar la asignacion del sw al cpu
    Public Function eliminar_soft_cpu(ByVal item As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_eliminarsoftcpu ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@item", SqlDbType.VarChar)
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
End Class
