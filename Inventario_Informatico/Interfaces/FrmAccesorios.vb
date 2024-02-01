Imports System.Data.SqlClient
Public Class FrmAccesorios
    Dim cl_m_a As New CL_MARCA_ACCESORIO
    Dim cl_usu As New Cl_usuarios
    Dim cl_ac As New Cl_Accesorios
    Dim flg As Integer = 0
    Dim cl_cp As New Cl_CPU
    Dim pregunta As DialogResult
    Private Sub btnbuscarmarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmarca.Click
        FrmBuscarMarcaAcc.Label2.Text = "1"
        FrmBuscarMarcaAcc.ShowDialog()
    End Sub
    Sub llenardependencia()
        Dim dr As SqlDataReader
        dr = cl_m_a.accesorio
        Me.cmbaccesorio.Items.Clear()
        While dr.Read
            Me.cmbaccesorio.Items.Add(dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Sub cod_accesorio()
        Dim dr As SqlDataReader
        dr = cl_m_a.cod_accesorio(Me.cmbaccesorio.Text)
        While dr.Read
            Me.lblaccesorio.Text = (dr(0).ToString)
        End While
        cn.Close()
    End Sub
    Private Sub FrmAccesorios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenardependencia()
        TabPage1.Enabled = False
        Me.lblcodigo.Text = FrmRegistroCPU.lblcodCPU.Text
        filtar()
    End Sub
    Sub filtar()
        Try
            Dim dr As SqlDataReader
            dr = cl_ac.buscar_accesorios(Me.lblcodigo.Text)
            Me.lvwaccesorios.Items.Clear()
            Dim i As Integer = 0
            While dr.Read
                Me.lvwaccesorios.Items.Add(CStr((dr(0))), 1)
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(1).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(2).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(3).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(4).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(5).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(6).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(7).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(8).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(9).ToString))
                Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(10).ToString))
                'Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(11).ToString))
                'Me.lvwaccesorios.Items(i).SubItems.Add(CStr(dr(12).ToString))
                i = i + 1
            End While
            dr = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        cn.Close()
    End Sub

    Private Sub cmbaccesorio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbaccesorio.SelectedIndexChanged
        cod_accesorio()

    End Sub

    Private Sub cmbusuario_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub btnbuscarmodelo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarmodelo.Click
        FrmBuscarModeloAcc.Label2.Text = "1"
        FrmBuscarModeloAcc.ShowDialog()
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        If Me.lblcodmodelo.Text = "" Or Me.lblcodmarca.Text = "" Or Me.lblmarca.Text = "" Or Me.lblmodelo.Text = "" Or Me.lblaccesorio.Text = "" Then
            MsgBox("Complete los datos nates de continuar", MsgBoxStyle.Critical)
        Else
            If flg = 0 Then
                cl_cp.guardardetalleCPU(Me.lblcodigo.Text, Me.lblaccesorio.Text, Me.lblcodmarca.Text, Me.lblcodmodelo.Text, "--", Me.txtserie.Text, "--", "--", Me.cmbestado.Text, Me.txtpatrimonio.Text, Me.RichTextBox1.Text, Me.lblregistro.Text)
                MsgBox("Datos añadidos correctamente", MsgBoxStyle.Information)
            Else
                cl_ac.EditarAccesorio(Me.lblcodigo.Text, Me.lblaccesorio.Text, Me.lblcodmarca.Text, Me.txtserie.Text, Me.txtpatrimonio.Text, Me.lblcodmodelo.Text, Me.cmbestado.Text, Me.RichTextBox1.Text)
                MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information)
            End If

            Me.btncancelar.PerformClick()
            filtar()
        End If
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        Me.btncancelar.PerformClick()
        flg = 0
        Dim dr As SqlDataReader
        dr = cl_cp.generar_detalleCPU
        While dr.Read
            Me.lblregistro.Text = dr(0).ToString
        End While
        cn.Close()
        TabPage1.Enabled = True
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        flg = 0
        Me.lblregistro.ResetText()
        Me.txtpatrimonio.ResetText()
        Me.txtserie.ResetText()
        Me.RichTextBox1.ResetText()
        Me.lblaccesorio.ResetText()
        Me.lblcodmarca.ResetText()
        Me.lblcodmodelo.ResetText()
        Me.lblmarca.ResetText()
        Me.lblmodelo.ResetText()
        Me.cmbaccesorio.Text = ""
        Me.cmbestado.Text = ""
        Me.lvwaccesorios.Items.Clear()
        TabPage1.Enabled = False
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub lvwaccesorios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwaccesorios.DoubleClick
        If Me.lvwaccesorios.SelectedItems.Count > 0 Then
            Me.lblaccesorio.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(0).Text
            Me.cmbaccesorio.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(1).Text
            Me.lblcodmarca.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(2).Text
            Me.txtserie.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(3).Text
            Me.lblmarca.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(4).Text
            Me.txtpatrimonio.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(5).Text
            Me.lblcodmodelo.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(6).Text
            Me.lblmodelo.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(7).Text
            Me.cmbestado.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(8).Text
            Me.RichTextBox1.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(9).Text
            Me.lblregistro.Text = Me.lvwaccesorios.SelectedItems(0).SubItems(10).Text

            flg = 1
            TabPage1.Enabled = True
        End If
          End Sub

    Private Sub lvwaccesorios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwaccesorios.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If flg <> 0 Then
            pregunta = MessageBox.Show("Desea eliminar este componente ", "Inventario Informático", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If pregunta = DialogResult.Yes Then
                cl_cp.EliminardetalleCPU(Me.lblregistro.Text)
                MsgBox("Datos Eliminados", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un elemento de la lista", MsgBoxStyle.Critical)
        End If
        Me.btncancelar.PerformClick()
        filtar()
    End Sub
End Class