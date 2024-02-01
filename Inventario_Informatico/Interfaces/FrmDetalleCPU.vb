Imports System.Data.SqlClient
Public Class FrmDetalleCPU
    Dim cl_cmp As New Cl_componentes
    Dim CL_CP As New Cl_CPU
    Dim flg As Integer = 0
    Dim pregunta As DialogResult
    Private Sub FrmDetalleCPU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarcmp()
        Me.lblcpu.Text = FrmRegistroCPU.lblcodCPU.Text
        cargarcomponentes()
        Me.TabPage1.Enabled = False
    End Sub
    Sub modelo()
        Dim dr As SqlDataReader
        dr = CL_CP.mostrarmodelocmp(Me.lblcodmodelo.Text)
        While dr.Read
            Me.lblmodelo.Text = dr(0).ToString
        End While
        cn.Close()
    End Sub
    Sub marca()
        Dim dr As SqlDataReader
        dr = CL_CP.mostrarmarcacmp(Me.lblcodmarca.Text)
        While dr.Read
            Me.lblmarca.Text = dr(0).ToString
        End While
        cn.Close()
    End Sub
    Sub cargarcomponentes()
        Try
            Dim dr As SqlDataReader
            dr = CL_CP.mostrarcomponentes(Me.lblcpu.Text)
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
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub
    Sub cargarcmp()
        Dim dr As SqlDataReader
        dr = cl_cmp.componente
        While dr.Read
            Me.cmbcomponentes.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub CODIGOCMP()
        Dim DR As SqlDataReader
        DR = cl_cmp.cod_componente(Me.cmbcomponentes.Text)
        While DR.Read
            Me.LBLCODCOMPONENTE.Text = DR(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub cmbcomponentes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcomponentes.SelectedIndexChanged
        CODIGOCMP()
    End Sub
    Private Sub btnbuscarmarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmarca.Click
        Me.lblcodmarca.ResetText()
        Me.lblmarca.ResetText()
        FrmBuscarMarcaCMP.Label2.Text = 1
        FrmBuscarMarcaCMP.ShowDialog()
    End Sub

    Private Sub btnbuscarmodelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmodelo.Click
        Me.lblcodmodelo.ResetText()
        Me.lblmodelo.ResetText()
        FrmBuscarModeloCMP.Label2.Text = 1
        FrmBuscarModeloCMP.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.lblregistro.ResetText()
        Me.TabPage1.Enabled = False
        Me.txtcapacidad.ResetText()
        Me.txtserie.ResetText()
        Me.txttipo.ResetText()
        Me.txtvelosidad.ResetText()
        Me.cmbelegir.Text = ""
        Me.lblmarca.ResetText()
        Me.lblcodmarca.ResetText()
        Me.lblmodelo.ResetText()
        Me.lblcodmodelo.ResetText()
        Me.cmbestado.ResetText()
        Me.LBLCODCOMPONENTE.ResetText()
        Me.cmbcomponentes.Text = ""
        cargarcomponentes()
        flg = 0
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.lblcodmodelo.Text = "" Or Me.lblcodmarca.Text = "" Or Me.lblmarca.Text = "" Or Me.lblmodelo.Text = "" Or Me.LBLCODCOMPONENTE.Text = "" Then
            MsgBox("Complete los datos nates de continuar", MsgBoxStyle.Critical)
        Else
            If flg = 0 Then
                CL_CP.guardardetalleCPU(Me.lblcpu.Text, Me.LBLCODCOMPONENTE.Text, Me.lblcodmarca.Text, Me.lblcodmodelo.Text, Me.txtcapacidad.Text & " " & Me.cmbelegir.Text, Me.txtserie.Text, Me.txtvelosidad.Text & " " & Me.cmbelegir1.Text, Me.txttipo.Text, Me.cmbestado.Text, "--", "--", Me.lblregistro.Text)
                MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
            Else
                CL_CP.EditardetalleCPU(Me.lblregistro.Text, Me.LBLCODCOMPONENTE.Text, Me.lblcodmarca.Text, Me.lblcodmodelo.Text, Me.txtcapacidad.Text & " " & Me.cmbelegir.Text, Me.txtserie.Text, Me.txtvelosidad.Text & " " & Me.cmbelegir1.Text, Me.txttipo.Text, Me.cmbestado.Text)
                MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information)
            End If
            cargarcomponentes()
            Me.Button3.PerformClick()
        End If
        
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If Me.ListView1.SelectedItems.Count > 0 Then
            Me.lblcpu.Text = Me.ListView1.SelectedItems(0).SubItems(0).Text
            Me.LBLCODCOMPONENTE.Text = Me.ListView1.SelectedItems(0).SubItems(1).Text
            Me.cmbcomponentes.Text = Me.ListView1.SelectedItems(0).SubItems(2).Text
            Me.lblcodmarca.Text = Me.ListView1.SelectedItems(0).SubItems(3).Text
            Me.lblcodmodelo.Text = Me.ListView1.SelectedItems(0).SubItems(4).Text
            Me.txtcapacidad.Text = Me.ListView1.SelectedItems(0).SubItems(5).Text
            Me.txtserie.Text = Me.ListView1.SelectedItems(0).SubItems(6).Text
            Me.txtvelosidad.Text = Me.ListView1.SelectedItems(0).SubItems(7).Text
            Me.txttipo.Text = Me.ListView1.SelectedItems(0).SubItems(8).Text
            Me.cmbestado.Text = Me.ListView1.SelectedItems(0).SubItems(9).Text
            Me.lblregistro.Text = Me.ListView1.SelectedItems(0).SubItems(10).Text
        End If
        modelo()
        marca()
        flg = 1
        Me.TabPage1.Enabled = True
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TabPage1.Enabled = True
        'funcion generar
        Dim dr As SqlDataReader
        dr = CL_CP.generar_detalleCPU
        While dr.Read
            Me.lblregistro.Text = dr(0).ToString
        End While
        cn.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If flg <> 0 Then
            pregunta = MessageBox.Show("Desea eliminar este componente ", "Inventario Informático", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                CL_CP.EliminardetalleCPU(Me.lblregistro.Text)
                MsgBox("Datos Eliminados", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
        cargarcomponentes()
        Me.Button3.PerformClick()
    End Sub
End Class