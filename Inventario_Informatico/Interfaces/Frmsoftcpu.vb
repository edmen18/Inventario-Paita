Imports System.Data.SqlClient
Public Class Frmsoftcpu
    Dim soft As New Cl_Software
    Dim flg As Integer = 0
    Private Sub Frmsoftcpu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargarcmp()
        Me.lblregcpu.Text = FrmRegistroCPU.lblcodCPU.Text
        'cargarcomponentes()
        TabPage1.Enabled = False
        mostrarlista()
    End Sub
    Sub mostrarlista()
        Try
            Dim dr As SqlDataReader
            dr = soft.mostrarswlista(Me.lblregcpu.Text)
            Me.ListView1.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.ListView1.Items.Add(CStr((dr(0))), 1)
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(4).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Button3.PerformClick()
        TabPage1.Enabled = True
        Dim dr As SqlDataReader
        dr = soft.generarsoftwarecpu
        While dr.Read
            Me.lblregistro.Text = dr(0).ToString
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabPage1.Enabled = False
        flg = 0
        Me.lblregistro.ResetText()
        Me.lblsoft.ResetText()
        Me.lblversion.ResetText()
        Me.lblcodigosoft.ResetText()
        mostrarlista()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        TabPage1.Enabled = True
        flg = 1
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblregcpu.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.lblcodigosoft.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.lblsoft.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            Me.lblversion.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            Me.lblregistro.Text = Me.ListView1.SelectedItems(0).SubItems(4).Text
        End If
        mostrarlista()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If flg = 0 Then
            soft.guardarsoftwarecpu(Me.lblregcpu.Text, Me.lblcodigosoft.Text, Me.lblregistro.Text)
            MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
        End If
        Me.Button3.PerformClick()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        FrmBuscarSoft.Show()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        If flg = 1 And Me.lblregistro.Text <> "" Then
            Dim salir As Integer
            salir = MsgBox("¿ Desea eliminar este item?", MsgBoxStyle.OkCancel Or MsgBoxStyle.Question, "Sist. Informático")
            If (salir = 1) Then
                soft.eliminar_soft_cpu(Me.lblregistro.Text)
            End If
        End If
    End Sub
End Class