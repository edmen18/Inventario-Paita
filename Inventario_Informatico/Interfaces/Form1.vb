Imports System.Data.SqlClient
Public Class Form1
    Dim cl_m_a As New CL_MARCA_ACCESORIO
    Dim clcmp As New Cl_componentes
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardependencia()
        Me.GroupBox1.Enabled = False
    End Sub
    Sub llenardependencia()
        Dim dr As SqlDataReader
        dr = cl_m_a.accesorio
        Me.cmbaccesorio.Items.Clear()
        While dr.Read
            Me.cmbaccesorio.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_accesorio()
        Dim dr As SqlDataReader
        dr = cl_m_a.cod_accesorio(Me.cmbaccesorio.Text)
        While dr.Read
            Me.lblcodigoaccesorio.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.GroupBox1.Enabled = True
        Dim DR As SqlDataReader
        DR = clcmp.GENARAR_COD_MARCA
        While DR.Read
            Me.LBLCODIGOMARCA.Text = DR(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.RadioButton1.Checked = True Then
            clcmp.guardarmarca(Me.LBLCODIGOMARCA.Text, Me.txtmarca.Text)
            clcmp.guardarCOMPONENTE_marca(Me.lblcodigoaccesorio.Text, Me.LBLCODIGOMARCA.Text)
        End If
        If Me.RadioButton2.Checked = True Then
            clcmp.guardarCOMPONENTE_marca(Me.lblcodigoaccesorio.Text, Me.LBLCODIGOMARCA.Text)
        End If
        MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub cmbaccesorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaccesorio.SelectedIndexChanged
        cod_accesorio()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.RadioButton1.Checked = False
        Me.RadioButton2.Checked = False
        Me.LBLCODIGOMARCA.ResetText()
        Me.lblcodigoaccesorio.ResetText()
        Me.txtmarca.ResetText()
        Me.cmbaccesorio.Text = ""
    End Sub
    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Me.LBLCODIGOMARCA.ResetText()
        FrmBuscarMarcaAcc.Label2.Text = "0"
        FrmBuscarMarcaAcc.ShowDialog()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
