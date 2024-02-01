Imports System.Data.SqlClient
Public Class FrmSoftware
    Dim soft As New Cl_Software
    Dim flg As Integer = 0
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        flg = 0
        Dim dr As SqlDataReader
        dr = soft.generarsoftware()
        While dr.Read
            Me.lblregistro.Text = dr(0)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If flg = 0 Then
            soft.guardarsoftware(Me.lblregistro.Text, Me.txtdescripcion.Text, Me.txtversion.Text, Me.cmbtipo.Text)
            MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
        Else
            soft.editarsoftware(Me.lblregistro.Text, Me.txtdescripcion.Text, Me.txtversion.Text, Me.cmbtipo.Text)
            MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information)
        End If
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub lvwsoft_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwsoft.DoubleClick
        flg = 1
        If Me.lvwsoft.SelectedItems.Count > 0 Then
            Me.lblregistro.Text = Me.lvwsoft.SelectedItems(0).SubItems(0).Text
            Me.txtdescripcion.Text = Me.lvwsoft.SelectedItems(0).SubItems(1).Text
            Me.txtversion.Text = Me.lvwsoft.SelectedItems(0).SubItems(2).Text
            Me.cmbtipo.Text = Me.lvwsoft.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub lvwsoft_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwsoft.SelectedIndexChanged

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        flg = 0
        Me.lblregistro.ResetText()
        Me.txtversion.ResetText()
        Me.txtdescripcion.ResetText()
        Me.cmbtipo.Text = ""
        filtar()
    End Sub

    Private Sub FrmSoftware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filtar()
    End Sub
    Sub filtar()
        Try
            Dim dr As SqlDataReader
            dr = soft.mostrar_SOFWARE
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

    Private Sub btnbuscarmarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmarca.Click
        buscar()
    End Sub
End Class