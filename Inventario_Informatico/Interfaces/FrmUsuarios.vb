Imports System.Data.SqlClient
Public Class FrmUsuarios
    Dim cl_u As New Cl_usuarios
    Dim flg As Integer = 0
    Private Sub FrmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listar()
    End Sub
    Sub listar()
        Try
            Dim dr As SqlDataReader
            dr = cl_u.ListarUsuarios
            Me.ListView1.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.ListView1.Items.Add(CStr((dr(0))), 1)
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(7).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        flg = 0
        Dim dr As SqlDataReader
        dr = cl_u.GENARARUSUARIO
        While dr.Read
            Me.lblcodigousuario.Text = dr(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmBuscarAreas.ShowDialog()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblcodigousuario.Text = "" Or Me.txtnombre.Text = "" Or Me.txtapellido.Text = "" Or Me.LBLAREA.Text = "" Then
            MsgBox("Complete los datos antes de continuar", MsgBoxStyle.Critical)
        Else
            If flg = 0 Then
                cl_u.guardarUsuario(Me.txtdni.Text, Me.txtnombre.Text, Me.txtapellido.Text, Me.txtdireccion.Text, Me.txttelefono.Text, Me.LBLAREA.Text, Me.lblcodigousuario.Text)
                MsgBox("Datos Añadidos correctamente", MsgBoxStyle.Information)
            Else
                cl_u.editarUsuario(Me.txtdni.Text, Me.txtnombre.Text, Me.txtapellido.Text, Me.txtdireccion.Text, Me.txttelefono.Text, Me.LBLAREA.Text, Me.lblcodigousuario.Text)
                MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information)
            End If
        End If
        listar()
        Me.btncancelar.PerformClick()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.txttelefono.ResetText()
        Me.txtdni.ResetText()
        Me.txtnombre.ResetText()
        Me.txtapellido.ResetText()
        Me.txtdireccion.ResetText()
        Me.LBLAREA.ResetText()
        Me.lblarea1.ResetText()
        Me.lblcodigousuario.ResetText()
        flg = 0
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.txtdni.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.txtnombre.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.txtapellido.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            Me.txtdireccion.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            Me.txttelefono.Text = Me.ListView1.SelectedItems(0).SubItems(4).Text
            Me.lblcodigousuario.Text = Me.ListView1.SelectedItems(0).SubItems(6).Text
            Me.LBLAREA.Text = Me.ListView1.SelectedItems(0).SubItems(5).Text
            Me.lblarea1.Text = Me.ListView1.SelectedItems(0).SubItems(7).Text
            flg = 1
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class