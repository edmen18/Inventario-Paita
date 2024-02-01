Imports System.Data.SqlClient
Public Class FrmBuscarModeloAcc
    Dim cl_mo_a As New Cl_Modelo_Accesorio
    Dim CL_CMP As New Cl_componentes
    Private Sub txtmodelo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmodelo.TextChanged
        If Me.Label2.Text = "0" Then
            Try
                Dim dr As SqlDataReader
                dr = CL_CMP.buscar_MODELO(Me.txtmodelo.Text, 0, "")
                Me.lvwmodelo.Items.Clear()
                Dim i As Integer = 0
                While dr.Read
                    Me.lvwmodelo.Items.Add(CStr((dr(0))), 1)
                    Me.lvwmodelo.Items(i).SubItems.Add(CStr(dr(1).ToString))
                    i = i + 1
                End While
                dr = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            cn.Close()
        ElseIf Me.Label2.Text = "1" Then
            Try
                Dim dr As SqlDataReader
                dr = CL_CMP.buscar_MODELO(Me.txtmodelo.Text, 1, FrmAccesorios.lblaccesorio.Text)
                Me.lvwmodelo.Items.Clear()
                Dim i As Integer = 0
                While dr.Read
                    Me.lvwmodelo.Items.Add(CStr((dr(0))), 1)
                    Me.lvwmodelo.Items(i).SubItems.Add(CStr(dr(1).ToString))
                    i = i + 1
                End While
                dr = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            cn.Close()
        ElseIf Me.Label2.Text = "2" Then
            Try
                Dim dr As SqlDataReader
                dr = CL_CMP.buscar_MODELO(Me.txtmodelo.Text, 1, FrmConsultasACC.Label1.Text)
                Me.lvwmodelo.Items.Clear()
                Dim i As Integer = 0
                While dr.Read
                    Me.lvwmodelo.Items.Add(CStr((dr(0))), 1)
                    Me.lvwmodelo.Items(i).SubItems.Add(CStr(dr(1).ToString))
                    i = i + 1
                End While
                dr = Nothing
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            cn.Close()
        End If

       
    End Sub

    Private Sub lvwmodelo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwmodelo.DoubleClick
        If Me.lvwmodelo.SelectedItems.Count > 0 Then
            If Me.Label2.Text = "0" Then
                FrmModeloAcc.lblcodigomodelo.Text = Me.lvwmodelo.SelectedItems(0).SubItems(0).Text()
                FrmModeloAcc.txtmodelo.Text = Me.lvwmodelo.SelectedItems(0).SubItems(1).Text
            ElseIf Me.Label2.Text = "1" Then
                FrmAccesorios.lblcodmodelo.Text = Me.lvwmodelo.SelectedItems(0).SubItems(0).Text()
                FrmAccesorios.lblmodelo.Text = Me.lvwmodelo.SelectedItems(0).SubItems(1).Text()
            ElseIf Me.Label2.Text = "2" Then
                FrmOpcionesAvanzadas.lblcodigo.Text = Me.lvwmodelo.SelectedItems(0).SubItems(0).Text()
                FrmOpcionesAvanzadas.lblopcion.Text = Me.lvwmodelo.SelectedItems(0).SubItems(1).Text()
            End If
            Me.lvwmodelo.Items.Clear()
            Me.txtmodelo.ResetText()
            Me.Label2.ResetText()
            Me.Close()
        End If
    End Sub
    Private Sub FrmBuscarModeloAcc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.lvwmodelo.Items.Clear()
        Me.txtmodelo.ResetText()
        Me.Label2.ResetText()
    End Sub

    Private Sub FrmBuscarModeloAcc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lvwmodelo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwmodelo.SelectedIndexChanged

    End Sub
End Class