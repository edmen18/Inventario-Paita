Imports System.Data.SqlClient
Public Class FrmUsuarios_Sistema
    Dim usuarios As New Cl_usuario_sistema
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Dim dr As SqlDataReader
        dr = usuarios.generar_usuario
        While dr.Read
            Me.lblcodigo.Text = dr(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        cancelar()
        Me.Close()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblcodigo.Text = "" Or Me.txtapellido.Text = "" Or Me.txtnombre.Text = "" Or Me.txtusuario.Text = "" Or Me.txtclave.Text = "" Or Me.txtrepclave.Text = "" Then
            MsgBox("Complete los datos antes de continuar", MsgBoxStyle.Critical)
        Else
            If CStr(Me.txtclave.Text) = CStr(Me.txtrepclave.Text) Then
                encriptar()
                usuarios.guardar_usuario(Me.lblcodigo.Text, Me.txtnombre.Text, Me.txtapellido.Text, Me.txtusuario.Text, Me.TXTCLAVEENCRIPTADA.Text)
                MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
                cancelar()
            Else
                MsgBox("La confirmación de la clave no es correcta", MsgBoxStyle.Critical)
                Me.txtclave.ResetText()
                Me.txtrepclave.ResetText()
            End If
        End If
    End Sub
    Sub cancelar()
        Me.txtclave.ResetText()
        Me.txtrepclave.ResetText()
        Me.lblcodigo.ResetText()
        Me.txtnombre.ResetText()
        Me.txtapellido.ResetText()
        Me.txtusuario.ResetText()
    End Sub

    Private Sub FrmUsuarios_Sistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub encriptar()
        Me.TXTCLAVEENCRIPTADA.Text = usuarios.EncriptarCadena(Me.txtclave.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class