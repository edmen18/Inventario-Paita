Imports System.Data.SqlClient
Public Class FrmRegistroCPU
    Dim cl_usu As New Cl_usuarios
    Dim cl_cpu As New Cl_CPU
    Dim flg As Integer = 0
    Private Sub FrmRegistroCPU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usuario()
        usuariobuscar()
        mostrarcpus()
        Me.cmbusuario.Visible = False
        Me.txtdato.Visible = False
    End Sub
    Sub mostrarcpus()
        Try
            Dim dr As SqlDataReader
            dr = cl_cpu.mostrar_CPUs
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
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(9).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(10).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(11).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub
    Sub usuario()
        Dim dr As SqlDataReader
        dr = cl_usu.listarusuarios1
        Me.cmbusuario.Items.Clear()
        While dr.Read
            Me.cmbusuario.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub usuariobuscar()
        Dim dr As SqlDataReader
        dr = cl_usu.listarusuarios1
        Me.cmbusuariobusqueda.Items.Clear()
        While dr.Read
            Me.cmbusuariobusqueda.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_usuario()
        Dim dr As SqlDataReader
        dr = cl_usu.COD_Usuarios(Me.cmbusuario.Text)
        While dr.Read
            Me.lblusuario.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_usuariobuscar()
        Dim dr As SqlDataReader
        dr = cl_usu.COD_Usuarios(Me.cmbusuariobusqueda.Text)
        While dr.Read
            Me.lblusuariobusqueda.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Private Sub cmbcomponentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        If Me.lblcodCPU.Text = "" Then
            MsgBox("Seleccione un Item de la lista", MsgBoxStyle.Critical)
        Else
            FrmDetalleCPU.Show()
        End If

    End Sub

    Private Sub cmbusuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuario.SelectedIndexChanged
        cod_usuario()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As SqlDataReader
        dr = cl_cpu.generar_CPU
        While dr.Read
            Me.lblcodCPU.Text = dr(0).ToString
        End While
        cn.Close()
        flg = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.lblcodCPU.Text = "" Or Me.txtcolor.Text = "" Or Me.txtmarca.Text = "" Then
            MsgBox("Complete los datos o elija un item del listado", MsgBoxStyle.Information)
        Else
            If flg = 0 Then
                If Me.chkinternet.Checked = True And Me.chkred.Checked = True Then
                    cl_cpu.guardarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "1", "1", Me.cmbestado.Text)
                ElseIf Me.chkinternet.Checked = False And Me.chkred.Checked = False Then
                    cl_cpu.guardarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "0", "0", Me.cmbestado.Text)
                ElseIf Me.chkinternet.Checked = True And Me.chkred.Checked = False Then
                    cl_cpu.guardarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "1", "0", Me.cmbestado.Text)
                ElseIf Me.chkinternet.Checked = False And Me.chkred.Checked = True Then
                    cl_cpu.guardarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "0", "1", Me.cmbestado.Text)
                End If
                MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
            Else
                If Me.chkinternet.Checked = True And Me.chkred.Checked = True Then
                    cl_cpu.editarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "1", "1", Me.cmbestado.Text)
                ElseIf Me.chkinternet.Checked = False And Me.chkred.Checked = False Then
                    cl_cpu.editarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "0", "0", Me.cmbestado.Text)
                ElseIf Me.chkinternet.Checked = True And Me.chkred.Checked = False Then
                    cl_cpu.editarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "1", "0", Me.cmbestado.Text)
                ElseIf Me.chkinternet.Checked = False And Me.chkred.Checked = True Then
                    cl_cpu.editarCPU(Me.lblcodCPU.Text, Me.txtcolor.Text, Me.txtmarca.Text, Me.txttipo.Text, Me.txtmodelo.Text, Me.lblusuario.Text, Me.txtsbn.Text, Me.txtip.Text, "0", "1", Me.cmbestado.Text)
                End If
                MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information)
            End If
        End If
        Me.Button3.PerformClick()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        flg = 0
        Me.lblcodCPU.ResetText()
        Me.txtcolor.ResetText()
        Me.txtmarca.ResetText()
        Me.txtsbn.ResetText()
        Me.txtmodelo.ResetText()
        Me.lblusuario.ResetText()
        Me.txttipo.ResetText()
        Me.txtip.ResetText()
        Me.chkred.Checked = False
        Me.chkinternet.Checked = False
        Me.cmbusuario.Text = ""
        mostrarcpus()
        Me.cmbusuariobusqueda.Text = ""
        Me.lblusuariobusqueda.ResetText()
    End Sub

    Private Sub cmbusuariobusqueda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbusuariobusqueda.SelectedIndexChanged
        cod_usuariobuscar()
    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcodCPU.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.txtcolor.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.txtmarca.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            Me.txttipo.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            Me.txtmodelo.Text = Me.ListView1.SelectedItems(0).SubItems(4).Text
            Me.lblusuario.Text = Me.ListView1.SelectedItems(0).SubItems(5).Text
            Me.cmbusuario.Text = Me.ListView1.SelectedItems(0).SubItems(6).Text
            Me.txtsbn.Text = Me.ListView1.SelectedItems(0).SubItems(7).Text
            Me.txtip.Text = Me.ListView1.SelectedItems(0).SubItems(8).Text
            Me.cmbestado.Text = Me.ListView1.SelectedItems(0).SubItems(11).Text
            If Me.ListView1.SelectedItems(0).SubItems(9).Text = "1" And Me.ListView1.SelectedItems(0).SubItems(10).Text = "1" Then
                Me.chkinternet.Checked = True
                Me.chkred.Checked = True
            ElseIf Me.ListView1.SelectedItems(0).SubItems(9).Text = "0" And Me.ListView1.SelectedItems(0).SubItems(10).Text = "0" Then
                Me.chkinternet.Checked = False
                Me.chkred.Checked = False
            ElseIf Me.ListView1.SelectedItems(0).SubItems(9).Text = "1" And Me.ListView1.SelectedItems(0).SubItems(10).Text = "0" Then
                Me.chkinternet.Checked = True
                Me.chkred.Checked = False
            ElseIf Me.ListView1.SelectedItems(0).SubItems(9).Text = "0" And Me.ListView1.SelectedItems(0).SubItems(10).Text = "1" Then
                Me.chkinternet.Checked = False
                Me.chkred.Checked = True
            End If
            flg = 1
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       
        Try

            Me.ListView1.Items.Clear()
            Dim dr As SqlDataReader
            Dim i As Integer = 0
            If Me.rbip.Checked = True Then
                dr = cl_cpu.BUSCAR_CPUIP(Me.txtdato.Text)
            End If
            If Me.rbip.Checked = True Then
                dr = cl_cpu.BUSCAR_CPUSBN(Me.txtdato.Text)
            End If
            If Me.rbusuario.Checked = True Then
                dr = cl_cpu.BUSCAR_CPU(Me.lblusuariobusqueda.Text)
            End If
            While dr.Read
                Me.ListView1.Items.Add(CStr((dr(0))), 1)
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(9).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(10).ToString))
                Me.ListView1.Items(i).SubItems.Add(CStr(dr(11).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.lblcodCPU.Text = "" Then
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        Else
            rep = 1
            FrmReportes.ShowDialog()
        End If
        
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btningsoft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningsoft.Click
        If Me.lblcodCPU.Text = "" Then
            MsgBox("Seleccione un Item de la lista", MsgBoxStyle.Critical)
        Else
            Frmsoftcpu.Show()
        End If
    End Sub

    Private Sub btnversw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnversw.Click

        rep = 7
        FrmReportes.ShowDialog()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Me.lblcodCPU.Text = "" Then
            MsgBox("Seleccione un Item de la lista", MsgBoxStyle.Critical)
        Else
            FrmAccesorios.Show()
        End If
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub rbusuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbusuario.CheckedChanged
        If Me.rbusuario.Checked = True Then
            Me.cmbusuariobusqueda.Visible = True
            Me.txtdato.Visible = False
        End If
    End Sub

    Private Sub rbip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbip.CheckedChanged
        If Me.rbip.Checked = True Then
            Me.cmbusuariobusqueda.Visible = False
            Me.txtdato.Visible = True
        End If
        
    End Sub

    Private Sub rbsbn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbsbn.CheckedChanged
        If Me.rbsbn.Checked = True Then
            Me.cmbusuariobusqueda.Visible = False
            Me.txtdato.Visible = True
        End If
    End Sub
End Class