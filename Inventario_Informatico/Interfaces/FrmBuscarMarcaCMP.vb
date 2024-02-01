Imports System.Data.SqlClient
Public Class FrmBuscarMarcaCMP
    Dim cl_m_a As New Cl_componentes

    Private Sub FrmBuscarMarcaCMP_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Label2.ResetText()
        Me.lvwmarca.Items.Clear()
        Me.txtmarcaM.ResetText()
    End Sub
    Private Sub FrmBuscarMarcaCMP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
    Private Sub txtmarcaM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmarcaM.TextChanged
        If Me.Label2.Text = "0" Then
            Try
                Dim dr As SqlDataReader
                dr = cl_m_a.buscar_marca(Me.txtmarcaM.Text, "0", "")
                Me.lvwmarca.Items.Clear()
                Dim i As Integer = 0
                While dr.Read
                    Me.lvwmarca.Items.Add(CStr((dr(0))), 1)
                    Me.lvwmarca.Items(i).SubItems.Add(CStr(dr(1).ToString))
                    i = i + 1
                End While
                dr = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            cn.Close()
        ElseIf Me.Label2.Text = "1" Then
            FUNCION(FrmDetalleCPU.LBLCODCOMPONENTE.Text)
        End If

    End Sub
    Sub FUNCION(ByVal ACCESORIO As String)
        Try
            Dim dr As SqlDataReader
            dr = cl_m_a.buscar_marca(Me.txtmarcaM.Text, "1", ACCESORIO)
            Me.lvwmarca.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwmarca.Items.Add(CStr((dr(0))), 1)
                Me.lvwmarca.Items(i).SubItems.Add(CStr(dr(1).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub lvwmarca_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwmarca.DoubleClick
        If Me.lvwmarca.SelectedItems.Count > 0 Then
            If Me.Label2.Text = "0" Then
                FrmMarcaComponentes.LBLCODIGOMARCA.Text = Me.lvwmarca.SelectedItems(0).SubItems(0).Text
                FrmMarcaComponentes.txtmarca.Text = Me.lvwmarca.SelectedItems(0).SubItems(1).Text
            Else
                FrmDetalleCPU.lblcodmarca.Text = Me.lvwmarca.SelectedItems(0).SubItems(0).Text
                FrmDetalleCPU.lblmarca.Text = Me.lvwmarca.SelectedItems(0).SubItems(1).Text
            End If
        End If
        Me.Label2.ResetText()
        Me.lvwmarca.Items.Clear()
        Me.txtmarcaM.ResetText()
        Me.Close()
    End Sub

    Private Sub lvwmarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwmarca.SelectedIndexChanged

    End Sub
End Class