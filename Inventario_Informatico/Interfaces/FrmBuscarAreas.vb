Imports System.Data.SqlClient
Public Class FrmBuscarAreas
    Dim cl_area As New Cl_areas
    Private Sub FrmBuscarAreas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtarea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtarea.TextChanged
        Try
            Dim dr As SqlDataReader
            dr = cl_area.listarareasbuscar(Me.txtarea.Text)
            Me.lvwareas.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwareas.Items.Add(CStr((dr(0))), 1)
                Me.lvwareas.Items(i).SubItems.Add(CStr(dr(1).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub lvwareas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwareas.DoubleClick
        If Me.lvwareas.SelectedItems.Count > 0 Then
            FrmUsuarios.LBLAREA.Text = Me.lvwareas.SelectedItems(0).SubItems(0).Text
            FrmUsuarios.lblarea1.Text = Me.lvwareas.SelectedItems(0).SubItems(1).Text
            Me.lvwareas.Items.Clear()
            Me.txtarea.ResetText()
            Me.Close()
        End If
    End Sub

    Private Sub lvwareas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwareas.SelectedIndexChanged

    End Sub
End Class