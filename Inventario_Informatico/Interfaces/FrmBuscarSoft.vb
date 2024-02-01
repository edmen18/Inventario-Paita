Imports System.Data.SqlClient
Public Class FrmBuscarSoft
    Dim soft As New Cl_Software
    Private Sub FrmBuscarSoft_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub buscar()
        Try
            Dim dr As SqlDataReader
            dr = soft.buscar_SOFWARE(Me.txtbuscar.Text)
            Me.lvwsoft.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwsoft.Items.Add(CStr((dr(0))), 1)
                Me.lvwsoft.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.lvwsoft.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.lvwsoft.Items(i).SubItems.Add(CStr(dr(3).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub lvwsoft_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwsoft.DoubleClick
        If Me.lvwsoft.SelectedItems.Count > 0 Then
            Frmsoftcpu.lblcodigosoft.Text = Me.lvwsoft.SelectedItems(0).SubItems(0).Text
            Frmsoftcpu.lblsoft.Text = Me.lvwsoft.SelectedItems(0).SubItems(1).Text
            Frmsoftcpu.lblversion.Text = Me.lvwsoft.SelectedItems(0).SubItems(2).Text
            Me.Close()
        End If
    End Sub

    Private Sub lvwsoft_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwsoft.SelectedIndexChanged

    End Sub
End Class