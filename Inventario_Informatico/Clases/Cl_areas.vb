Imports System.Data.SqlClient
Public Class Cl_areas
    ' generar el código corelativo del area
    Public Function GENARARarea() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_generarAREA"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function mostrar_areas() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_mostrarareas"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function codarea(ByVal area As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters("@descripcion").Value = area
            co.CommandText = "sp_codarea"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    Public Function guardarArea(ByVal CODIGO As String, ByVal descripcion As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_guardararea ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@codigo", SqlDbType.VarChar)
            co.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar)
            co.Parameters("@DESCRIPCION").Value = CStr(descripcion)
            co.Parameters("@codigo").Value = CStr(CODIGO)
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
    'EDITAR EL NOMBRE DEL AREA
    Public Function EditarArea(ByVal CODIGO As String, ByVal descripcion As String) As Integer
        co = Nothing
        Try
            co = New SqlCommand("sp_editar_area ", cn)
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@codigo", SqlDbType.VarChar)
            co.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar)
            co.Parameters("@DESCRIPCION").Value = CStr(descripcion)
            co.Parameters("@codigo").Value = CStr(CODIGO)
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
    ' listar areas en la grilla por descripcion
    Public Function listarareas() As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.CommandText = "sp_mostrar_areas"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
    ' listar areas en la ventana de busqueda de areas
    Public Function listarareasbuscar(ByVal NOMBRE As String) As SqlDataReader
        Try
            co = New SqlCommand
            co.Connection = cn
            co.CommandType = CommandType.StoredProcedure
            co.Parameters.Add("@descripcion", SqlDbType.VarChar)
            co.Parameters("@descripcion").Value = CStr(NOMBRE)
            co.CommandText = "sp_buscar_areas"
            cn.Open()
            Return co.ExecuteReader()
            cn.Close()
        Catch ex As Exception
            MsgBox("No ha sido posible el acceso a los datos" & ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Function
End Class
