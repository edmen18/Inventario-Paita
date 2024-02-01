Imports System.Data.SqlClient
Public Class FrmConsultaPcs
    Dim cl_usu As New Cl_usuarios
    Dim cl_ar As New Cl_areas
    Private Sub FrmConsultaPcs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Sub areas()
        Dim dr As SqlDataReader
        dr = cl_ar.mostrar_areas
        Me.CMBACCESORIO.Items.Clear()
        While dr.Read
            Me.CMBACCESORIO.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub usuario()
        Dim dr As SqlDataReader
        dr = cl_usu.listarusuarios1
        Me.CMBACCESORIO.Items.Clear()
        While dr.Read
            Me.CMBACCESORIO.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_usuario()
        Dim dr As SqlDataReader
        dr = cl_usu.COD_Usuarios(Me.CMBACCESORIO.Text)
        While dr.Read
            Me.Label1.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
  
    Sub cod_area()
        Dim dr As SqlDataReader
        dr = cl_ar.codarea(Me.CMBACCESORIO.Text)
        While dr.Read
            Me.Label1.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub rbausuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbausuario.Click
        Me.Label1.ResetText()
        usuario()
    End Sub

    Private Sub btnver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnver.Click
        If Me.rbausuario.Checked = True Then
            rep = 8
            FrmReportes.ShowDialog()
        End If
        If Me.rbarea.Checked = True Then
            rep = 9
            FrmReportes.ShowDialog()
        End If
    End Sub
    Private Sub rbarea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbarea.Click
        Me.CMBACCESORIO.Items.Clear()
        areas()
    End Sub

    Private Sub rbarea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbarea.CheckedChanged

    End Sub

    Private Sub CMBACCESORIO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBACCESORIO.SelectedIndexChanged
        If Me.rbausuario.Checked = True Then
            cod_usuario()
        End If
        If rbarea.Checked = True Then
            cod_area()
        End If
    End Sub
End Class