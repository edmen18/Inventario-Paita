Imports System.Data.SqlClient
Public Class FrmBuscarMarcaAcc
    Dim cl_m_a As New CL_MARCA_ACCESORIO

    Private Sub FrmBuscarMarcaAcc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Label2.ResetText()
        Me.lvwmarca.Items.Clear()
        Me.txtmarca.ResetText()
    End Sub
    Private Sub FrmBuscarMarcaAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txtmarca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmarca.TextChanged
        If Me.Label2.Text = "0" Then
            Try
                Dim dr As SqlDataReader
                dr = cl_m_a.buscar_marca(Me.txtmarca.Text, "0", "")
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
            FUNCION(FrmAccesorios.lblaccesorio.Text)
        ElseIf Me.Label2.Text = "2" Then
            FUNCION(FrmConsultasACC.Label1.Text)
        End If
        
    End Sub
    Sub FUNCION(ByVal ACCESORIO As String)
        Try
            Dim dr As SqlDataReader
            dr = cl_m_a.buscar_marca(Me.txtmarca.Text, "1", ACCESORIO)
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
                Form1.LBLCODIGOMARCA.Text = Me.lvwmarca.SelectedItems(0).SubItems(0).Text
                Form1.txtmarca.Text = Me.lvwmarca.SelectedItems(0).SubItems(1).Text
            ElseIf Me.Label2.Text = "1" Then
                FrmAccesorios.lblcodmarca.Text = Me.lvwmarca.SelectedItems(0).SubItems(0).Text
                FrmAccesorios.lblmarca.Text = Me.lvwmarca.SelectedItems(0).SubItems(1).Text
            ElseIf Me.Label2.Text = "2" Then
                FrmOpcionesAvanzadas.lblcodigo.Text = Me.lvwmarca.SelectedItems(0).SubItems(0).Text
                FrmOpcionesAvanzadas.lblopcion.Text = Me.lvwmarca.SelectedItems(0).SubItems(1).Text
            End If
        End If
        Me.Label2.ResetText()
        Me.lvwmarca.Items.Clear()
        Me.txtmarca.ResetText()
        Me.Close()
    End Sub

    Private Sub lvwmarca_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwmarca.SelectedIndexChanged

    End Sub
End Class