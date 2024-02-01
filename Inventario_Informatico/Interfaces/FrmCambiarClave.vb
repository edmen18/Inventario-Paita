Imports System.Data.SqlClient
Public Class FrmCambiarClave
    Dim usuario As New Cl_usuario_sistema
    Private Sub FrmCambiarClave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblcodusuario.Text = cod_usu
        Me.lblusuario.Text = nombrepersonal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If clave = usuario.EncriptarCadena(Me.txtanterior.Text) Then
            If Me.txtnueva.Text <> "" Or Me.txtrepetir.Text <> "" Then
                If Me.txtnueva.Text = Me.txtrepetir.Text Then
                    usuario.editarclave(Me.lblcodusuario.Text, usuario.EncriptarCadena(Me.txtnueva.Text))
                    MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Ingrese y/o confirme la nueva clave", MsgBoxStyle.Critical)
            End If
        End If
        Me.txtnueva.ResetText()
        Me.txtrepetir.ResetText()
        Me.txtanterior.ResetText()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.txtnueva.ResetText()
        Me.txtrepetir.ResetText()
        Me.txtanterior.ResetText()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class