Imports System.Data.SqlClient
Public Class FrmReportes
    Private Sub FrmReportes_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        rep = 0
    End Sub
    Private Sub FrmReportes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        rep = 0
    End Sub
    Private Sub FrmReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If rep = 1 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+' '+APELLIDOS as usuario,ta.DESCRIPCION as area,MODELO,DIR_IP,t_c.COD_SBN,CON_INTERNET,CON_RED,CAPACIDAD,SERIE,VELOSIDAD,tdc.TIPO,TDC.ESTADO,ccp.descripcion as componente,tmc.descricpcion as modelocmp ,tmac.descripcion as marcacmp,tt.descripción as tipocmp,tdc.cod_sbn as sbn from dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area  inner join dbo.T_CPU t_c on t_c.cod_usuario=tu.cod_usuario inner join t_detalle_cpu tdc on tdc.cod_cpu=t_c.cod_cpu  inner join componentes_cpu ccp on ccp.cod_componente=tdc.cod_componente inner join  dbo.T_TIPO tt on tt.cod_tipo=ccp.cod_tipo inner join t_modelo_c tmc on tmc.cod_modeloc=tdc.cod_modeloc inner join t_marca_c tmac on tmac.cod_marcac=tdc.cod_marcac where t_c.cod_cpu='" + FrmRegistroCPU.lblcodCPU.Text + "'and est='A'", cn)
            Dim ds As New Ds_ReporteCpu
            adaptador.Fill(ds.Tables("Dt_cpu"))
            Dim cr As New Cr_reportecpu
            cr.SetDataSource(ds.Tables("Dt_cpu"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 2 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+' '+APELLIDOS as usuario,ta.DESCRIPCION as area,MODELO,DIR_IP,COD_SBN,CON_INTERNET,CON_RED,TIPO,MARCA,COLOR from dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area inner join dbo.T_CPU t_c on t_c.cod_usuario=tu.cod_usuario ", cn)
            Dim ds As New Ds_reportepcs
            adaptador.Fill(ds.Tables("dt_pcs"))
            Dim cr As New Cr_pcs
            cr.SetDataSource(ds.Tables("Dt_pcs"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 3 Then
            Dim adaptador As New SqlDataAdapter("select distinct SERIE,da.COD_sbn as cod_patrimonial,da.ESTADO as estado_actual,OBSERVACIONES,tma.descripcion as marca,mocc.descricpcion as modelo,nombre+' '+apellidos as usuario ,ta.descripcion as area , tac.DESCRIPCION as Accesorio from dbo.t_DETALLE_cpu da inner join dbo.t_Mc_c  ma on da.cod_marcac=ma.cod_marcac inner join t_marca_c tma on tma.cod_marcac=ma.cod_marcac inner join dbo.t_moc_c moa on moa.cod_modeloc=da.cod_modeloc inner join t_modelo_c mocc on mocc.cod_modeloc=moa.cod_modeloc inner join t_cpu cpu on cpu.cod_cpu=da.cod_cpu inner join dbo.T_USUARIOS tu on tu.cod_usuario=cpu.cod_usuario inner join dbo.T_AREAS ta on ta.cod_area=tu.cod_area inner join componentes_cpu tac  on tac.cod_componente=da.cod_componente where cod_tipo=2 order by ta.descripcion", cn)
            Dim ds As New Ds_Accesorios
            adaptador.Fill(ds.Tables("dt_accesorios"))
            Dim cr As New Cr_Accesorios
            cr.SetDataSource(ds.Tables("Dt_accesorios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 4 Then
            Dim adaptador As New SqlDataAdapter("select distinct SERIE,da.COD_sbn as cod_patrimonial,da.ESTADO as estado_actual,OBSERVACIONES,tma.descripcion as marca,mocc.descricpcion as modelo,nombre+' '+apellidos as usuario ,ta.descripcion as area , tac.DESCRIPCION as Accesorio from dbo.t_DETALLE_cpu da inner join dbo.t_Mc_c  ma on da.cod_marcac=ma.cod_marcac inner join t_marca_c tma on tma.cod_marcac=ma.cod_marcac inner join dbo.t_moc_c moa on moa.cod_modeloc=da.cod_modeloc inner join t_modelo_c mocc on mocc.cod_modeloc=moa.cod_modeloc inner join t_cpu cpu on cpu.cod_cpu=da.cod_cpu inner join dbo.T_USUARIOS tu on tu.cod_usuario=cpu.cod_usuario inner join dbo.T_AREAS ta on ta.cod_area=tu.cod_area inner join componentes_cpu tac  on tac.cod_componente=da.cod_componente where tu.cod_usuario='" + FrmConsultasACC.Label1.Text + "' and cod_tipo=2 and est='A'", cn)
            Dim ds As New Ds_Accesorios
            adaptador.Fill(ds.Tables("dt_accesorios"))
            Dim cr As New Cr_accesorios_usuario
            cr.SetDataSource(ds.Tables("Dt_accesorios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 5 Then
            Dim adaptador As New SqlDataAdapter("select distinct SERIE,da.COD_sbn as cod_patrimonial,da.ESTADO as estado_actual,OBSERVACIONES,tma.descripcion as marca,mocc.descricpcion as modelo,nombre+' '+apellidos as usuario ,ta.descripcion as area , tac.DESCRIPCION as Accesorio from dbo.t_DETALLE_cpu da inner join dbo.t_Mc_c  ma on da.cod_marcac=ma.cod_marcac inner join t_marca_c tma on tma.cod_marcac=ma.cod_marcac inner join dbo.t_moc_c moa on moa.cod_modeloc=da.cod_modeloc inner join t_modelo_c mocc on mocc.cod_modeloc=moa.cod_modeloc inner join t_cpu cpu on cpu.cod_cpu=da.cod_cpu inner join dbo.T_USUARIOS tu on tu.cod_usuario=cpu.cod_usuario inner join dbo.T_AREAS ta on ta.cod_area=tu.cod_area inner join componentes_cpu tac  on tac.cod_componente=da.cod_componente where tac.cod_componente= '" + FrmConsultasACC.Label1.Text + "'and est='A'", cn)
            Dim ds As New Ds_Accesorios
            adaptador.Fill(ds.Tables("dt_accesorios"))
            Dim cr As New Cr_accesorio_acc
            cr.SetDataSource(ds.Tables("Dt_accesorios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 6 Then
            Dim adaptador As New SqlDataAdapter("select distinct SERIE,da.COD_sbn as cod_patrimonial,da.ESTADO as estado_actual,OBSERVACIONES,tma.descripcion as marca,mocc.descricpcion as modelo,nombre+' '+apellidos as usuario ,ta.descripcion as area , tac.DESCRIPCION as Accesorio from dbo.t_DETALLE_cpu da inner join dbo.t_Mc_c  ma on da.cod_marcac=ma.cod_marcac inner join t_marca_c tma on tma.cod_marcac=ma.cod_marcac inner join dbo.t_moc_c moa on moa.cod_modeloc=da.cod_modeloc inner join t_modelo_c mocc on mocc.cod_modeloc=moa.cod_modeloc inner join t_cpu cpu on cpu.cod_cpu=da.cod_cpu inner join dbo.T_USUARIOS tu on tu.cod_usuario=cpu.cod_usuario inner join dbo.T_AREAS ta on ta.cod_area=tu.cod_area inner join componentes_cpu tac  on tac.cod_componente=da.cod_componente where ta.cod_area= '" + FrmConsultasACC.Label1.Text + "'and cod_tipo=2 and est='A'", cn)
            Dim ds As New Ds_Accesorios
            adaptador.Fill(ds.Tables("dt_accesorios"))
            Dim cr As New Cr_accesorio_area
            cr.SetDataSource(ds.Tables("Dt_accesorios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 7 Then
            Dim adaptador As New SqlDataAdapter("SELECT item,S.COD_SOFT,DESCRIPCION,VERSION, CPU.COD_CPU,cod_sbn,dir_ip,con_internet,con_red,cpu.estado fROM T_CPU CPU INNER JOIN SOFT_CPU SC ON SC.COD_CPU=CPU.COD_CPU  COLLATE SQL_Latin1_General_CP1_CI_AS INNER JOIN SOFTWARE S ON S.COD_SOFT=SC.COD_SOFT  WHERE CPU.COD_CPU='" + FrmRegistroCPU.lblcodCPU.Text + "' and sc.estado='a'", cn)
            Dim ds As New DS_swcpu
            adaptador.Fill(ds.Tables("dt_sw_cpu"))
            Dim cr As New Cr_swcpu
            cr.DataDefinition.FormulaFields.Item("USUARIO").Text = "'" + FrmRegistroCPU.cmbusuario.Text + "'"
            cr.SetDataSource(ds.Tables("Dt_sw_cpu"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 8 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+'  '+APELLIDOS as usuario,ta.DESCRIPCION as area,MODELO,DIR_IP,t_c.COD_SBN,CON_INTERNET,CON_RED,CAPACIDAD,SERIE,VELOSIDAD,tdc.TIPO,TDC.ESTADO,ccp.descripcion as componente,tmc.descricpcion as modelocmp ,tmac.descripcion as marcacmp,tt.descripción as tipocmp,tdc.cod_sbn as sbn from dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area  inner join dbo.T_CPU t_c on t_c.cod_usuario=tu.cod_usuario inner join t_detalle_cpu tdc on tdc.cod_cpu=t_c.cod_cpu  inner join componentes_cpu ccp on ccp.cod_componente=tdc.cod_componente inner join  dbo.T_TIPO tt on tt.cod_tipo=ccp.cod_tipo inner join t_modelo_c tmc on tmc.cod_modeloc=tdc.cod_modeloc inner join t_marca_c tmac on tmac.cod_marcac=tdc.cod_marcac where tu.cod_usuario='" + FrmConsultaPcs.Label1.Text + "'and est='A'", cn)
            Dim ds As New Ds_ReporteCpu
            adaptador.Fill(ds.Tables("Dt_cpu"))
            Dim cr As New Cr_reportecpu
            cr.SetDataSource(ds.Tables("Dt_cpu"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 9 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+' '+APELLIDOS as usuario,ta.DESCRIPCION as area,MODELO,DIR_IP,t_c.COD_SBN,CON_INTERNET,CON_RED,CAPACIDAD,SERIE,VELOSIDAD,tdc.TIPO,TDC.ESTADO,ccp.descripcion as componente,tmc.descricpcion as modelocmp ,tmac.descripcion as marcacmp,tt.descripción as tipocmp,tdc.cod_sbn as sbn from dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area  inner join dbo.T_CPU t_c on t_c.cod_usuario=tu.cod_usuario inner join t_detalle_cpu tdc on tdc.cod_cpu=t_c.cod_cpu  inner join componentes_cpu ccp on ccp.cod_componente=tdc.cod_componente inner join  dbo.T_TIPO tt on tt.cod_tipo=ccp.cod_tipo inner join t_modelo_c tmc on tmc.cod_modeloc=tdc.cod_modeloc inner join t_marca_c tmac on tmac.cod_marcac=tdc.cod_marcac where ta.cod_area='" + FrmConsultaPcs.Label1.Text + "'and est='A'", cn)
            Dim ds As New Ds_ReporteCpu
            adaptador.Fill(ds.Tables("Dt_cpu"))
            Dim cr As New Cr_reportepcs
            cr.SetDataSource(ds.Tables("Dt_cpu"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 10 Then
            Dim adaptador As New SqlDataAdapter("select dni,nombre+' '+apellidos as usuario,descripcion from t_usuarios tu inner join t_areas ta on ta.cod_area=tu.cod_area order by descripcion", cn)
            Dim ds As New Ds_Usuarios
            adaptador.Fill(ds.Tables("dt_usuarios"))
            Dim cr As New CrystalReport1
            cr.SetDataSource(ds.Tables("dt_usuarios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 11 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+' '+APELLIDOS as usuario,ta.DESCRIPCION as area,MODELO,DIR_IP,t_c.COD_SBN,CON_INTERNET,CON_RED,CAPACIDAD,SERIE,VELOSIDAD,tdc.TIPO,TDC.ESTADO,ccp.descripcion as componente,tmc.descricpcion as modelocmp ,tmac.descripcion as marcacmp,tt.descripción as tipocmp,tdc.cod_sbn as sbn from dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area  inner join dbo.T_CPU t_c on t_c.cod_usuario=tu.cod_usuario inner join t_detalle_cpu tdc on tdc.cod_cpu=t_c.cod_cpu  inner join componentes_cpu ccp on ccp.cod_componente=tdc.cod_componente inner join  dbo.T_TIPO tt on tt.cod_tipo=ccp.cod_tipo inner join t_modelo_c tmc on tmc.cod_modeloc=tdc.cod_modeloc inner join t_marca_c tmac on tmac.cod_marcac=tdc.cod_marcac where est='a' ", cn)
            Dim ds As New Ds_ReporteCpu
            adaptador.Fill(ds.Tables("Dt_cpu"))
            Dim cr As New Cr_reportepcs
            cr.SetDataSource(ds.Tables("Dt_cpu"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 12 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+' '+APELLIDOS as usuario,ta.DESCRIPCION as area FROM dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area ", cn)
            Dim ds As New Ds_usuariosarea
            adaptador.Fill(ds.Tables("DtUSUARIO"))
            Dim cr As New Cr_usuarios_area
            cr.SetDataSource(ds.Tables("DtUSUARIO"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 13 Then
            Dim adaptador As New SqlDataAdapter("select DNI,NOMBRE+' '+APELLIDOS as usuario,ta.DESCRIPCION as area FROM dbo.T_AREAS ta inner join dbo.T_USUARIOS  tu on tu.cod_area=ta.cod_area WHERE TA.COD_AREA='" + FrmUsuariosArea.Label1.Text + "'", cn)
            Dim ds As New Ds_usuariosarea
            adaptador.Fill(ds.Tables("DtUSUARIO"))
            Dim cr As New Cr_usuarios_area
            cr.SetDataSource(ds.Tables("DtUSUARIO"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 14 Then
            Dim adaptador As New SqlDataAdapter("select distinct SERIE,da.COD_sbn as cod_patrimonial,da.ESTADO as estado_actual,OBSERVACIONES,tma.descripcion as marca,mocc.descricpcion as modelo,nombre+' '+apellidos as usuario ,ta.descripcion as area , tac.DESCRIPCION as Accesorio from dbo.t_DETALLE_cpu da inner join dbo.t_Mc_c  ma on da.cod_marcac=ma.cod_marcac inner join t_marca_c tma on tma.cod_marcac=ma.cod_marcac inner join dbo.t_moc_c moa on moa.cod_modeloc=da.cod_modeloc inner join t_modelo_c mocc on mocc.cod_modeloc=moa.cod_modeloc inner join t_cpu cpu on cpu.cod_cpu=da.cod_cpu inner join dbo.T_USUARIOS tu on tu.cod_usuario=cpu.cod_usuario inner join dbo.T_AREAS ta on ta.cod_area=tu.cod_area inner join componentes_cpu tac  on tac.cod_componente=da.cod_componente where tac.cod_componente= '" + FrmConsultasACC.Label1.Text + "' and tma.cod_marcac='" + FrmOpcionesAvanzadas.lblcodigo.Text + "'", cn)
            Dim ds As New Ds_Accesorios
            adaptador.Fill(ds.Tables("dt_accesorios"))
            Dim cr As New Cr_acc_marca
            cr.SetDataSource(ds.Tables("Dt_accesorios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 15 Then
            Dim adaptador As New SqlDataAdapter("select distinct SERIE,da.COD_sbn as cod_patrimonial,da.ESTADO as estado_actual,OBSERVACIONES,tma.descripcion as marca,mocc.descricpcion as modelo,nombre+' '+apellidos as usuario ,ta.descripcion as area , tac.DESCRIPCION as Accesorio from dbo.t_DETALLE_cpu da inner join dbo.t_Mc_c  ma on da.cod_marcac=ma.cod_marcac inner join t_marca_c tma on tma.cod_marcac=ma.cod_marcac inner join dbo.t_moc_c moa on moa.cod_modeloc=da.cod_modeloc inner join t_modelo_c mocc on mocc.cod_modeloc=moa.cod_modeloc inner join t_cpu cpu on cpu.cod_cpu=da.cod_cpu inner join dbo.T_USUARIOS tu on tu.cod_usuario=cpu.cod_usuario inner join dbo.T_AREAS ta on ta.cod_area=tu.cod_area inner join componentes_cpu tac  on tac.cod_componente=da.cod_componente where tac.cod_componente= '" + FrmConsultasACC.Label1.Text + "' and mocc.cod_modeloc='" + FrmOpcionesAvanzadas.lblcodigo.Text + "'", cn)
            Dim ds As New Ds_Accesorios
            adaptador.Fill(ds.Tables("dt_accesorios"))
            Dim cr As New Cr_acc_modelo
            cr.SetDataSource(ds.Tables("Dt_accesorios"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 16 Then
            Dim adaptador As New SqlDataAdapter("select DOCUMENTO,USUARIO_DE,USUARIO_A,DESCRIPCIOM,MARCA,MODELO,SERIE,COD_SBN,VELOSIDAD,CAPACIDAD,AREA_DE,AREA_A,convert(char(10),FECHA,103)as FECHA from dbo.TRASLADOS WHERE FECHA>='" + FrmConsultaTraslado.dtdel.Value.Date + "' AND FECHA<='" + FrmConsultaTraslado.dtal.Value.Date + "' ", cn)
            Dim ds As New Ds_Traslados
            adaptador.Fill(ds.Tables("dt_traslados"))
            Dim cr As New Cr_traslados
            cr.DataDefinition.FormulaFields("Fechainicio").Text = "'" + FrmConsultaTraslado.dtdel.Text + "'"
            cr.DataDefinition.FormulaFields("Fechafin").Text = "'" + FrmConsultaTraslado.dtal.Text + "'"
            cr.SetDataSource(ds.Tables("Dt_traslados"))
            Me.CrystalReportViewer1.ReportSource = cr
        ElseIf rep = 17 Then
            Dim adaptador As New SqlDataAdapter("select DOCUMENTO,USUARIO_DE,USUARIO_A,DESCRIPCIOM,MARCA,MODELO,SERIE,COD_SBN,VELOSIDAD,CAPACIDAD,AREA_DE,AREA_A,convert(char(10),FECHA,103)as FECHA from dbo.TRASLADOS WHERE fecha='" + FrmConsultaTraslado.Lvwtraslados.SelectedItems(0).SubItems(12).Text + "' AND documento='" + FrmConsultaTraslado.Lvwtraslados.SelectedItems(0).SubItems(0).Text + "' ", cn)
            Dim ds As New Ds_Traslados
            adaptador.Fill(ds.Tables("dt_traslados"))
            Dim cr As New Cr_trasladodetalle
            cr.SetDataSource(ds.Tables("Dt_traslados"))
            Me.CrystalReportViewer1.ReportSource = cr
        End If

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class