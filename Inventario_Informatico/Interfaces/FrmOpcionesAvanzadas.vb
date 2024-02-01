Public Class FrmOpcionesAvanzadas

    Private Sub btnbuscarmarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmarca.Click
        If rbmarca.Checked = True Then
            FrmBuscarMarcaAcc.Label2.Text = "2"
            FrmBuscarMarcaAcc.ShowDialog()
        End If
        If rbmodelo.Checked = True Then
            FrmBuscarModeloAcc.Label2.Text = "2"
            FrmBuscarModeloAcc.ShowDialog()
        End If
        
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        If rbmarca.Checked Then
            rep = 14
            FrmReportes.ShowDialog()
        End If
        If rbmodelo.Checked Then
            rep = 15
            FrmReportes.ShowDialog()
        End If
    End Sub
End Class