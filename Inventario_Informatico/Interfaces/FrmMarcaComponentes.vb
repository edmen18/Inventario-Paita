Imports System.Data.SqlClient
Public Class FrmMarcaComponentes
    Dim cl_marca As New Cl_componentes
    Private Sub FrmMarcaComponentes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardependencia()
    End Sub
    Sub llenardependencia()
        Dim dr As SqlDataReader
        dr = cl_marca.componente
        Me.cmbaccesorio.Items.Clear()
        While dr.Read
            Me.cmbaccesorio.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_componente()
        Dim dr As SqlDataReader
        dr = cl_marca.cod_componente(Me.cmbaccesorio.Text)
        While dr.Read
            Me.lblcodigoaccesorio.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub cmbaccesorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaccesorio.SelectedIndexChanged
        cod_componente()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Dim dr As SqlDataReader
        dr = cl_marca.GENARAR_COD_MARCA
        While dr.Read
            Me.LBLCODIGOMARCA.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.RadioButton1.Checked = True Then
            cl_marca.guardarmarca(Me.LBLCODIGOMARCA.Text, Me.txtmarca.Text)
            cl_marca.guardarCOMPONENTE_marca(Me.lblcodigoaccesorio.Text, Me.LBLCODIGOMARCA.Text)
        End If
        If Me.RadioButton2.Checked = True Then
            cl_marca.guardarCOMPONENTE_marca(Me.lblcodigoaccesorio.Text, Me.LBLCODIGOMARCA.Text)
        End If
        MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.LBLCODIGOMARCA.ResetText()
        Me.lblcodigoaccesorio.ResetText()
        Me.txtmarca.ResetText()
        Me.cmbaccesorio.ResetText()
        '= ""
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        FrmBuscarMarcaCMP.Label2.Text = 0
        FrmBuscarMarcaCMP.ShowDialog()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class