Imports System.Data.SqlClient
Public Class FrmTrasladoACC
    Dim cl_usu As New Cl_usuarios
    Dim cl_cpu As New Cl_CPU
    Dim trasl As New Cl_Traslado
    Dim c As Integer
    Dim i As Integer
    Private Sub FrmTrasladoACC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usuario()
    End Sub
    Sub usuario()
        Dim dr As SqlDataReader
        dr = cl_usu.listarusuarios1
        Me.cmbusuario1.Items.Clear()
        While dr.Read
            Me.cmbusuario1.Items.Add(dr(0).ToString)
            Me.Cmbusuario2.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_usuario1()
        Dim dr As SqlDataReader
        dr = cl_usu.COD_Usuarios(Me.cmbusuario1.Text)
        While dr.Read
            Me.lblusuario1.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_usuario2()
        Dim dr As SqlDataReader
        dr = cl_usu.COD_Usuarios(Me.Cmbusuario2.Text)
        While dr.Read
            Me.lblusuario2.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub

    Private Sub cmbusuario1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario1.SelectedIndexChanged
        cod_usuario1()
        Try
            Dim dr As SqlDataReader
            dr = Cl_CPU.BUSCAR_CPU(Me.lblusuario1.Text)
            Me.lvwcpua.Items.Clear()
            Me.lwvCMP1.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwcpua.Items.Add(CStr((dr(0))), 1)
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(9).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(10).ToString))
                Me.lvwcpua.Items(i).SubItems.Add(CStr(dr(11).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub Cmbusuario2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbusuario2.SelectedIndexChanged
        cod_usuario2()
        Try
            Dim dr As SqlDataReader
            dr = cl_cpu.BUSCAR_CPU(Me.lblusuario2.Text)
            Me.lvwcpub.Items.Clear()
            Me.lvwcmp2.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwcpub.Items.Add(CStr((dr(0))), 1)
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(9).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(10).ToString))
                Me.lvwcpub.Items(i).SubItems.Add(CStr(dr(11).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub lvwcpua_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwcpua.DoubleClick
        FUNCION1()
    End Sub
    Sub FUNCION1()
        Try
            Dim dr As SqlDataReader
            dr = cl_cpu.mostrarcomponentesacc(Me.lvwcpua.SelectedItems(0).SubItems(0).Text)
            Me.lwvCMP1.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lwvCMP1.Items.Add(CStr((dr(0))), 1)
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.lwvCMP1.Items(i).SubItems.Add(CStr(dr(9).ToString))

                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub lvwcpua_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwcpua.SelectedIndexChanged

    End Sub

    Private Sub lvwcpub_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwcpub.DoubleClick
        FUNCION2()
    End Sub
    Sub FUNCION2()
        Try
            Dim dr As SqlDataReader
            dr = cl_cpu.mostrarcomponentesacc(Me.lvwcpub.SelectedItems(0).SubItems(0).Text)
            Me.lvwcmp2.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwcmp2.Items.Add(CStr((dr(0))), 1)
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.lvwcmp2.Items(i).SubItems.Add(CStr(dr(9).ToString))

                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub
    Private Sub lvwcpub_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwcpub.SelectedIndexChanged

    End Sub

    Private Sub lwvCMP1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lwvCMP1.DoubleClick
        If Me.lwvCMP1.SelectedItems.Count > 0 Then
            If Me.lwvCMP1.SelectedItems(0).SubItems(2).Text = "INTEGRADO" Or Me.lwvCMP1.SelectedItems(0).SubItems(3).Text = "INTEGRADO" Or Me.lwvCMP1.SelectedItems(0).SubItems(9).Text = "INTEGRADO" Then
                MsgBox("El componente es Integrado al cpu y no es posible el traslado", MsgBoxStyle.Critical)
            Else
                If Me.lvwcmp2.Items.Count <> 0 Then
                    c = Me.lvwcmp2.Items.Count
                    Me.lvwcmp2.Items.Add(Me.lwvCMP1.SelectedItems(0).SubItems(0).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(1).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(2).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(3).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(4).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(5).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(6).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(7).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(8).Text)
                    Me.lvwcmp2.Items(c).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(9).Text)
                ElseIf Me.lvwcmp2.Items.Count = 0 And Me.lvwcpub.SelectedItems.Count > 0 Then
                    Me.lvwcmp2.Items.Add(Me.lwvCMP1.SelectedItems(0).SubItems(0).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(1).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(2).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(3).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(4).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(5).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(6).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(7).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(8).Text)
                    Me.lvwcmp2.Items(0).SubItems.Add(Me.lwvCMP1.SelectedItems(0).SubItems(9).Text)
                ElseIf Me.lvwcmp2.Items.Count = 0 And Me.lvwcpub.SelectedItems.Count = 0 Then
                    MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
                End If
                Me.lwvCMP1.Items.RemoveAt(Me.lwvCMP1.SelectedItems(0).Index)
            End If
        End If
    End Sub

    Private Sub lwvCMP1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lwvCMP1.SelectedIndexChanged

    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        FUNCION1()
        FUNCION2()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.cmbdoc.Text = "" Or Me.TextBox1.Text = "" Then
            MsgBox("Debe ingresar el documento que autorizó el traslado", MsgBoxStyle.Critical)
        Else
            For i = 0 To Me.lvwcmp2.Items.Count - 1
                If Me.lvwcmp2.Items(i).SubItems(8).Text = Me.lvwcpua.SelectedItems(0).SubItems(0).Text Then
                    trasl.guardartraslado(Me.cmbdoc.Text + " " + Me.TextBox1.Text, Me.cmbusuario1.Text, Me.Cmbusuario2.Text, Me.lvwcmp2.Items(i).SubItems(1).Text, Me.lvwcmp2.Items(i).SubItems(2).Text, Me.lvwcmp2.Items(i).SubItems(3).Text, Me.lvwcmp2.Items(i).SubItems(4).Text, Me.lvwcmp2.Items(i).SubItems(5).Text, Me.lvwcmp2.Items(i).SubItems(7).Text, Me.lvwcmp2.Items(i).SubItems(6).Text, "", "", Now.Date)
                    trasl.editar_traslado(Me.lvwcmp2.Items(i).SubItems(0).Text, Me.lvwcpub.SelectedItems(0).SubItems(0).Text)
                    MsgBox("Datos guardados correctamente", MsgBoxStyle.Information)
                    limpiar()
                End If
            Next
        End If
    End Sub
    Sub limpiar()
        Me.Cmbusuario2.Text = ""
        Me.cmbusuario1.Text = ""
        Me.lvwcmp2.Items.Clear()
        Me.lwvCMP1.Items.Clear()
        Me.lvwcpub.Items.Clear()
        Me.lvwcpua.Items.Clear()
        Me.lblusuario1.ResetText()
        Me.lblusuario2.ResetText()
        Me.TextBox1.ResetText()
        Me.cmbdoc.Text = ""
    End Sub
End Class