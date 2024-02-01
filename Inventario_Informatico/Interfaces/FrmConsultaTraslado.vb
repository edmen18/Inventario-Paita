Imports System.Data.SqlClient
Public Class FrmConsultaTraslado
    Dim CL_TR As New Cl_Traslado
    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        Try
            Dim dr As SqlDataReader
            dr = CL_TR.mostrar_TRASLADOS(Me.dtdel.Text, Me.dtal.Text)
            Me.Lvwtraslados.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.Lvwtraslados.Items.Add(CStr((dr(0))), 1)
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(9).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(10).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(11).ToString))
                Me.Lvwtraslados.Items(i).SubItems.Add(CStr(dr(12).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()

    End Sub

    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        rep = 16
        FrmReportes.ShowDialog()
    End Sub

    Private Sub btnverdetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnverdetalle.Click
        If Me.Lvwtraslados.SelectedItems.Count > 0 Then
            rep = 17
            FrmReportes.ShowDialog()
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
       
    End Sub
End Class