<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleCPU
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblregistro = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmbelegir1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbestado = New System.Windows.Forms.ComboBox
        Me.cmbelegir = New System.Windows.Forms.ComboBox
        Me.btnbuscarmodelo = New System.Windows.Forms.Button
        Me.btnbuscarmarca = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblmodelo = New System.Windows.Forms.Label
        Me.lblmarca = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txttipo = New System.Windows.Forms.TextBox
        Me.txtvelosidad = New System.Windows.Forms.TextBox
        Me.txtserie = New System.Windows.Forms.TextBox
        Me.txtcapacidad = New System.Windows.Forms.TextBox
        Me.lblcodmodelo = New System.Windows.Forms.Label
        Me.lblcodmarca = New System.Windows.Forms.Label
        Me.cmbcomponentes = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.LBLCODCOMPONENTE = New System.Windows.Forms.Label
        Me.lblcpu = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblregistro)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.cmbcomponentes)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.LBLCODCOMPONENTE)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(608, 213)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle CPU."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Registro N°"
        '
        'lblregistro
        '
        Me.lblregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblregistro.Location = New System.Drawing.Point(111, 40)
        Me.lblregistro.Name = "lblregistro"
        Me.lblregistro.Size = New System.Drawing.Size(58, 23)
        Me.lblregistro.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbelegir1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbestado)
        Me.Panel1.Controls.Add(Me.cmbelegir)
        Me.Panel1.Controls.Add(Me.btnbuscarmodelo)
        Me.Panel1.Controls.Add(Me.btnbuscarmarca)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblmodelo)
        Me.Panel1.Controls.Add(Me.lblmarca)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txttipo)
        Me.Panel1.Controls.Add(Me.txtvelosidad)
        Me.Panel1.Controls.Add(Me.txtserie)
        Me.Panel1.Controls.Add(Me.txtcapacidad)
        Me.Panel1.Controls.Add(Me.lblcodmodelo)
        Me.Panel1.Controls.Add(Me.lblcodmarca)
        Me.Panel1.Location = New System.Drawing.Point(10, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 139)
        Me.Panel1.TabIndex = 19
        '
        'cmbelegir1
        '
        Me.cmbelegir1.FormattingEnabled = True
        Me.cmbelegir1.Items.AddRange(New Object() {"Mb", "MB", "Gb", "GB", "Mhz", "Ghz"})
        Me.cmbelegir1.Location = New System.Drawing.Point(514, 66)
        Me.cmbelegir1.Name = "cmbelegir1"
        Me.cmbelegir1.Size = New System.Drawing.Size(54, 21)
        Me.cmbelegir1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Estado"
        '
        'cmbestado
        '
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"OPERATIVO.", "NO OPERATIVO."})
        Me.cmbestado.Location = New System.Drawing.Point(55, 87)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(231, 21)
        Me.cmbestado.TabIndex = 24
        '
        'cmbelegir
        '
        Me.cmbelegir.FormattingEnabled = True
        Me.cmbelegir.Items.AddRange(New Object() {"GB", "Gb", "MB", "Mb", "WATTS"})
        Me.cmbelegir.Location = New System.Drawing.Point(497, 14)
        Me.cmbelegir.Name = "cmbelegir"
        Me.cmbelegir.Size = New System.Drawing.Size(71, 21)
        Me.cmbelegir.TabIndex = 23
        '
        'btnbuscarmodelo
        '
        Me.btnbuscarmodelo.Image = Global.Inventario_Informatico.My.Resources.Resources._33
        Me.btnbuscarmodelo.Location = New System.Drawing.Point(251, 47)
        Me.btnbuscarmodelo.Name = "btnbuscarmodelo"
        Me.btnbuscarmodelo.Size = New System.Drawing.Size(35, 34)
        Me.btnbuscarmodelo.TabIndex = 22
        Me.btnbuscarmodelo.Text = "..."
        Me.btnbuscarmodelo.UseVisualStyleBackColor = True
        '
        'btnbuscarmarca
        '
        Me.btnbuscarmarca.Image = Global.Inventario_Informatico.My.Resources.Resources._33
        Me.btnbuscarmarca.Location = New System.Drawing.Point(251, 12)
        Me.btnbuscarmarca.Name = "btnbuscarmarca"
        Me.btnbuscarmarca.Size = New System.Drawing.Size(35, 34)
        Me.btnbuscarmarca.TabIndex = 21
        Me.btnbuscarmarca.Text = "..."
        Me.btnbuscarmarca.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Modelo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Marca"
        '
        'lblmodelo
        '
        Me.lblmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodelo.Location = New System.Drawing.Point(55, 55)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.Size = New System.Drawing.Size(190, 20)
        Me.lblmodelo.TabIndex = 16
        '
        'lblmarca
        '
        Me.lblmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmarca.Location = New System.Drawing.Point(55, 21)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(190, 20)
        Me.lblmarca.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(332, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Tipo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(332, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Velosidad"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(332, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Serie"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 26)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Capacidad" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/potencia"
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(395, 92)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(173, 20)
        Me.txttipo.TabIndex = 3
        '
        'txtvelosidad
        '
        Me.txtvelosidad.Location = New System.Drawing.Point(395, 66)
        Me.txtvelosidad.Name = "txtvelosidad"
        Me.txtvelosidad.Size = New System.Drawing.Size(112, 20)
        Me.txtvelosidad.TabIndex = 2
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(395, 40)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(173, 20)
        Me.txtserie.TabIndex = 1
        '
        'txtcapacidad
        '
        Me.txtcapacidad.Location = New System.Drawing.Point(395, 14)
        Me.txtcapacidad.Name = "txtcapacidad"
        Me.txtcapacidad.Size = New System.Drawing.Size(80, 20)
        Me.txtcapacidad.TabIndex = 0
        '
        'lblcodmodelo
        '
        Me.lblcodmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodmodelo.Location = New System.Drawing.Point(55, 55)
        Me.lblcodmodelo.Name = "lblcodmodelo"
        Me.lblcodmodelo.Size = New System.Drawing.Size(32, 20)
        Me.lblcodmodelo.TabIndex = 18
        '
        'lblcodmarca
        '
        Me.lblcodmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodmarca.Location = New System.Drawing.Point(55, 21)
        Me.lblcodmarca.Name = "lblcodmarca"
        Me.lblcodmarca.Size = New System.Drawing.Size(32, 20)
        Me.lblcodmarca.TabIndex = 17
        '
        'cmbcomponentes
        '
        Me.cmbcomponentes.FormattingEnabled = True
        Me.cmbcomponentes.Location = New System.Drawing.Point(111, 16)
        Me.cmbcomponentes.Name = "cmbcomponentes"
        Me.cmbcomponentes.Size = New System.Drawing.Size(284, 21)
        Me.cmbcomponentes.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Elegir Componete"
        '
        'LBLCODCOMPONENTE
        '
        Me.LBLCODCOMPONENTE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLCODCOMPONENTE.Location = New System.Drawing.Point(330, 17)
        Me.LBLCODCOMPONENTE.Name = "LBLCODCOMPONENTE"
        Me.LBLCODCOMPONENTE.Size = New System.Drawing.Size(39, 20)
        Me.LBLCODCOMPONENTE.TabIndex = 15
        '
        'lblcpu
        '
        Me.lblcpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcpu.Location = New System.Drawing.Point(449, 26)
        Me.lblcpu.Name = "lblcpu"
        Me.lblcpu.Size = New System.Drawing.Size(31, 20)
        Me.lblcpu.TabIndex = 20
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(635, 251)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(627, 225)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(627, 225)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado de Componentes"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(11, 11)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(610, 204)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CPU."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cod_Componente"
        Me.ColumnHeader2.Width = 54
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Descripción"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Cod. Marca"
        Me.ColumnHeader4.Width = 82
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cod. Modelo"
        Me.ColumnHeader5.Width = 76
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Capacidad"
        Me.ColumnHeader6.Width = 66
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Serie"
        Me.ColumnHeader7.Width = 47
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Velosidad"
        Me.ColumnHeader8.Width = 62
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Tipo"
        Me.ColumnHeader9.Width = 49
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Estado"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "item"
        Me.ColumnHeader11.Width = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Image = Global.Inventario_Informatico.My.Resources.Resources._75
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(374, 271)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 51)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "&Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Image = Global.Inventario_Informatico.My.Resources.Resources._08
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(295, 271)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 51)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "&Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Image = Global.Inventario_Informatico.My.Resources.Resources._21
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(215, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 51)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "&Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Image = Global.Inventario_Informatico.My.Resources.Resources._16g
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(133, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 51)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Nuevo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Image = Global.Inventario_Informatico.My.Resources.Resources.remove
        Me.Button5.Location = New System.Drawing.Point(449, 271)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 51)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "&Eliminar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FrmDetalleCPU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(659, 334)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblcpu)
        Me.Name = "FrmDetalleCPU"
        Me.Text = "Componentes de CPU"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbelegir As System.Windows.Forms.ComboBox
    Friend WithEvents btnbuscarmodelo As System.Windows.Forms.Button
    Friend WithEvents btnbuscarmarca As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblcodmodelo As System.Windows.Forms.Label
    Friend WithEvents lblcodmarca As System.Windows.Forms.Label
    Friend WithEvents lblmodelo As System.Windows.Forms.Label
    Friend WithEvents lblmarca As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtvelosidad As System.Windows.Forms.TextBox
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents txtcapacidad As System.Windows.Forms.TextBox
    Friend WithEvents LBLCODCOMPONENTE As System.Windows.Forms.Label
    Friend WithEvents cmbcomponentes As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblcpu As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbelegir1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblregistro As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
