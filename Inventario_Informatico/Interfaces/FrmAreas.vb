Imports System.Data.SqlClient
Public Class FrmAreas
    Dim cl_a As New Cl_areas
    Dim flg As Integer = 0
    Private Sub FrmAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenar()
    End Sub
    Sub llenar()
        Try
            Dim dr As SqlDataReader
            dr = cl_a.listarareas
            Me.ListView1.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.ListView1.Items.Add(CStr((dr(0))), 1)
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(1).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        flg = 0
        Dim dr As SqlDataReader
        dr = cl_a.GENARARarea
        While dr.Read
            Me.lblcodigo.Text = dr(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblcodigo.Text = "" Or Me.txtarea.Text = "" Then
            MsgBox("Complete los Datos antes de continuar", MsgBoxStyle.Critical)
        Else
            If flg = 0 Then
                'guardar los datos en la bd 
                cl_a.guardarArea(Me.lblcodigo.Text, Me.txtarea.Text)
                MsgBox("Datos Añadidos correctamente", MsgBoxStyle.Information)
            ElseIf flg = 1 Then
                'EDITAR AREA
                cl_a.EditarArea(Me.lblcodigo.Text, Me.txtarea.Text)
                MsgBox("Datos corregidos correctamente", MsgBoxStyle.Information)
            End If
        End If
        llenar()
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        flg = 1
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodigo.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.txtarea.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        flg = 0
        Me.lblcodigo.ResetText()
        Me.txtarea.ResetText()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class