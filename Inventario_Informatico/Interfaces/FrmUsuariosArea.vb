Imports System.Data.SqlClient
Public Class FrmUsuariosArea
    Dim cl_ar As New Cl_areas
    Private Sub FrmUsuariosArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        areas()
    End Sub
    Sub areas()
        Dim dr As SqlDataReader
        dr = cl_ar.mostrar_areas
        Me.CMBACCESORIO.Items.Clear()
        While dr.Read
            Me.CMBACCESORIO.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_area()
        Dim dr As SqlDataReader
        dr = cl_ar.codarea(Me.CMBACCESORIO.Text)
        While dr.Read
            Me.Label1.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        If Me.chktodas.Checked = True And Me.Label1.Text = "" Then
            rep = 12
            FrmReportes.ShowDialog()
        ElseIf Me.chktodas.Checked = False And Me.Label1.Text <> "" Then
            rep = 13
            FrmReportes.ShowDialog()
        End If
    End Sub

    Private Sub CMBACCESORIO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBACCESORIO.SelectedIndexChanged
        cod_area()
        Me.chktodas.Checked = False
    End Sub

    Private Sub chktodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodas.CheckedChanged

    End Sub

    Private Sub chktodas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chktodas.Click
        Me.Label1.ResetText()
    End Sub
End Class