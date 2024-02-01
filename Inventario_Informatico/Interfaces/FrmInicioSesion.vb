Imports System.Data.SqlClient
Public Class FrmInicioSesion
    Dim CONT As Integer = 0
    Dim usuario As New Cl_usuario_sistema
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If CONT = 4 Then
            MsgBox("Usted, no pertenece al Sistema," & vbCrLf & _
            " Sus Intentos han terminado", MsgBoxStyle.Critical, "Nótificación")
            Close()
        Else
            Me.txtclaveencriptada.Text = usuario.EncriptarCadena(Me.txtcontraseña.Text)
            Try
                Dim dr As SqlDataReader
                dr = usuario.iniciarsesion(Me.txtusuario.Text, Me.txtclaveencriptada.Text)
                If dr.HasRows Then
                    While dr.Read
                        nombrepersonal = dr(0).ToString
                        cod_usu = dr(1).ToString
                        clave = dr(2).ToString
                    End While
                    MsgBox("Bienvenido(a) '" + nombrepersonal + "'")
                    cn.Close()
                    Me.Hide()
                    Dim asc As New MDIParentMenu
                    asc.ShowDialog(Me)
                Else
                    CONT = CONT + 1
                    MsgBox("Usuario o Contraseña No Validos " & vbCrLf & _
                    "Le queda • " + (5 - CONT).ToString + " • Intentos", MsgBoxStyle.Information, "Verificación")
                    Me.txtusuario.Focus()
                End If
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try

        End If
        cn.Close()
    End Sub

    Private Sub FrmInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txtclaveencriptada.ResetText()
        Me.txtcontraseña.ResetText()
        Me.txtusuario.ResetText()
    End Sub
End Class