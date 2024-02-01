Imports System.Data.SqlClient
Module Conexion

    Public cn As New SqlConnection("Persist Security Info=False;User ID=sa;Initial Catalog=inventario;Data Source=EDGAR-PC")
    'Public cn As New SqlConnection("Persist Security Info=False;password =1234567890;User ID=paita;Initial Catalog=INVENTARIO;Data Source=catas")

    Public co As New SqlCommand
    Public dr As SqlDataReader
    'declaracion de variables globales
    '''''''''''declaracion de variable para mostrar reportes
    Public rep As Integer = 0
    ''' '''''''declaracion para capturar el codigo de usuario
    Public cod_usu As String
    Public nombrepersonal As String
    Public clave As String

End Module
