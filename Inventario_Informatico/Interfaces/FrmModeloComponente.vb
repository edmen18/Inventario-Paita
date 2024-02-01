Imports System.Data.SqlClient
Public Class FrmModeloComponente
    Dim cl_cmp As New Cl_componentes
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
    Sub llenardependencia()
        Dim dr As SqlDataReader
        dr = cl_cmp.componente
        Me.cmbaccesorio.Items.Clear()
        While dr.Read
            Me.cmbaccesorio.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_accesorio()
        Dim dr As SqlDataReader
        dr = cl_cmp.cod_componente(Me.cmbaccesorio.Text)
        While dr.Read
            Me.lblcodigoaccesorio.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Private Sub FrmModeloComponente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardependencia()
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Dim dr As SqlDataReader
        dr = cl_cmp.GENARAR_COD_Modelo
        While dr.Read
            Me.lblcodigomodelo.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblcodigomodelo.Text = "" Or Me.txtmodelo.Text = "" Then
            MsgBox("Complete los datos antes de continuar", MsgBoxStyle.Critical)
        Else
            If Me.RadioButton1.Checked = True Then
                cl_cmp.guardarmodelo(Me.lblcodigomodelo.Text, Me.txtmodelo.Text)
                cl_cmp.guardarCOMPONENTE_modelo(Me.lblcodigoaccesorio.Text, Me.lblcodigomodelo.Text)
            End If
            If Me.RadioButton2.Checked = True Then
                cl_cmp.guardarCOMPONENTE_modelo(Me.lblcodigoaccesorio.Text, Me.lblcodigomodelo.Text)
            End If
            MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)

        End If
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.lblcodigomodelo.ResetText()
        Me.lblcodigoaccesorio.ResetText()
        Me.txtmodelo.ResetText()
        Me.cmbaccesorio.Text = ""
    End Sub

    Private Sub cmbaccesorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaccesorio.SelectedIndexChanged
        cod_accesorio()
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Me.lblcodigomodelo.ResetText()
        FrmBuscarModeloCMP.Label2.Text = 0
        FrmBuscarModeloCMP.ShowDialog()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class