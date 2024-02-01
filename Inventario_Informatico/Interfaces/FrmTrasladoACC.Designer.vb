<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTrasladoACC
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblusuario1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lwvCMP1 = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader37 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader38 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader41 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader43 = New System.Windows.Forms.ColumnHeader
        Me.lvwcmp2 = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader39 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader40 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader42 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader44 = New System.Windows.Forms.ColumnHeader
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblusuario2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbusuario1 = New System.Windows.Forms.ComboBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lvwcpua = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader23 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader24 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader25 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader26 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader27 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader28 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader29 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmbusuario2 = New System.Windows.Forms.ComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lvwcpub = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader30 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader31 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader32 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader33 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader34 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader35 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader36 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbdoc = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblusuario1
        '
        Me.lblusuario1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblusuario1.Location = New System.Drawing.Point(8, 33)
        Me.lblusuario1.Name = "lblusuario1"
        Me.lblusuario1.Size = New System.Drawing.Size(20, 23)
        Me.lblusuario1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario"
        '
        'lwvCMP1
        '
        Me.lwvCMP1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader41, Me.ColumnHeader43})
        Me.lwvCMP1.FullRowSelect = True
        Me.lwvCMP1.GridLines = True
        Me.lwvCMP1.HideSelection = False
        Me.lwvCMP1.Location = New System.Drawing.Point(9, 152)
        Me.lwvCMP1.Name = "lwvCMP1"
        Me.lwvCMP1.Size = New System.Drawing.Size(500, 225)
        Me.lwvCMP1.TabIndex = 5
        Me.lwvCMP1.UseCompatibleStateImageBehavior = False
        Me.lwvCMP1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "item"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Descripción"
        Me.ColumnHeader8.Width = 117
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Marca"
        Me.ColumnHeader9.Width = 92
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Modelo"
        Me.ColumnHeader10.Width = 105
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Serie"
        Me.ColumnHeader11.Width = 76
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "SBN"
        Me.ColumnHeader12.Width = 96
        '
        'ColumnHeader37
        '
        Me.ColumnHeader37.Text = "Capacidad"
        '
        'ColumnHeader38
        '
        Me.ColumnHeader38.Text = "Velosidad"
        '
        'ColumnHeader41
        '
        Me.ColumnHeader41.Text = "Cod_cpu"
        '
        'ColumnHeader43
        '
        Me.ColumnHeader43.Text = "Tipo"
        '
        'lvwcmp2
        '
        Me.lvwcmp2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader42, Me.ColumnHeader44})
        Me.lvwcmp2.FullRowSelect = True
        Me.lvwcmp2.GridLines = True
        Me.lvwcmp2.HideSelection = False
        Me.lvwcmp2.Location = New System.Drawing.Point(17, 153)
        Me.lvwcmp2.Name = "lvwcmp2"
        Me.lvwcmp2.Size = New System.Drawing.Size(465, 224)
        Me.lvwcmp2.TabIndex = 11
        Me.lvwcmp2.UseCompatibleStateImageBehavior = False
        Me.lvwcmp2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "item"
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Descripción"
        Me.ColumnHeader14.Width = 117
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Marca"
        Me.ColumnHeader15.Width = 78
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Modelo"
        Me.ColumnHeader16.Width = 79
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Serie"
        Me.ColumnHeader17.Width = 80
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "SBN"
        Me.ColumnHeader18.Width = 97
        '
        'ColumnHeader39
        '
        Me.ColumnHeader39.Text = "Capacidad"
        '
        'ColumnHeader40
        '
        Me.ColumnHeader40.Text = "Velosidad"
        '
        'ColumnHeader42
        '
        Me.ColumnHeader42.Text = "Cod_cpu"
        '
        'ColumnHeader44
        '
        Me.ColumnHeader44.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Usuario"
        '
        'lblusuario2
        '
        Me.lblusuario2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblusuario2.Location = New System.Drawing.Point(17, 30)
        Me.lblusuario2.Name = "lblusuario2"
        Me.lblusuario2.Size = New System.Drawing.Size(20, 23)
        Me.lblusuario2.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbusuario1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblusuario1)
        Me.GroupBox1.Controls.Add(Me.lwvCMP1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 391)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Donante"
        '
        'cmbusuario1
        '
        Me.cmbusuario1.FormattingEnabled = True
        Me.cmbusuario1.Location = New System.Drawing.Point(38, 35)
        Me.cmbusuario1.Name = "cmbusuario1"
        Me.cmbusuario1.Size = New System.Drawing.Size(471, 21)
        Me.cmbusuario1.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lvwcpua)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 84)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos CPU."
        '
        'lvwcpua
        '
        Me.lvwcpua.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29})
        Me.lvwcpua.FullRowSelect = True
        Me.lvwcpua.GridLines = True
        Me.lvwcpua.HideSelection = False
        Me.lvwcpua.Location = New System.Drawing.Point(6, 19)
        Me.lvwcpua.Name = "lvwcpua"
        Me.lvwcpua.Size = New System.Drawing.Size(497, 65)
        Me.lvwcpua.TabIndex = 1
        Me.lvwcpua.UseCompatibleStateImageBehavior = False
        Me.lvwcpua.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod_Cpu"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Color"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marca"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tipo"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Modelo"
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "Cod_usuario"
        Me.ColumnHeader23.Width = 0
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "Usuario"
        Me.ColumnHeader24.Width = 0
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "SBN"
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "Dir IP"
        Me.ColumnHeader26.Width = 43
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "Internet"
        Me.ColumnHeader27.Width = 52
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "Red"
        Me.ColumnHeader28.Width = 38
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "Estado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cmbusuario2)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.lblusuario2)
        Me.GroupBox2.Controls.Add(Me.lvwcmp2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(524, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(488, 391)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recibidor"
        '
        'Cmbusuario2
        '
        Me.Cmbusuario2.FormattingEnabled = True
        Me.Cmbusuario2.Location = New System.Drawing.Point(40, 31)
        Me.Cmbusuario2.Name = "Cmbusuario2"
        Me.Cmbusuario2.Size = New System.Drawing.Size(442, 21)
        Me.Cmbusuario2.TabIndex = 12
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lvwcpub)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 65)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(475, 84)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos CPU."
        '
        'lvwcpub
        '
        Me.lvwcpub.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36})
        Me.lvwcpub.FullRowSelect = True
        Me.lvwcpub.GridLines = True
        Me.lvwcpub.HideSelection = False
        Me.lvwcpub.Location = New System.Drawing.Point(5, 11)
        Me.lvwcpub.Name = "lvwcpub"
        Me.lvwcpub.Size = New System.Drawing.Size(470, 65)
        Me.lvwcpub.TabIndex = 2
        Me.lvwcpub.UseCompatibleStateImageBehavior = False
        Me.lvwcpub.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cod_Cpu"
        Me.ColumnHeader2.Width = 0
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Color"
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Marca"
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Tipo"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Modelo"
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "Cod_usuario"
        Me.ColumnHeader30.Width = 0
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "Usuario"
        Me.ColumnHeader31.Width = 0
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "SBN"
        Me.ColumnHeader32.Width = 31
        '
        'ColumnHeader33
        '
        Me.ColumnHeader33.Text = "Dir IP"
        Me.ColumnHeader33.Width = 43
        '
        'ColumnHeader34
        '
        Me.ColumnHeader34.Text = "Internet"
        Me.ColumnHeader34.Width = 52
        '
        'ColumnHeader35
        '
        Me.ColumnHeader35.Text = "Red"
        Me.ColumnHeader35.Width = 48
        '
        'ColumnHeader36
        '
        Me.ColumnHeader36.Text = "Estado"
        Me.ColumnHeader36.Width = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 418)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Documento de traslado"
        '
        'cmbdoc
        '
        Me.cmbdoc.FormattingEnabled = True
        Me.cmbdoc.Items.AddRange(New Object() {"MEMORANDUM", "OFICIO", "INFORME"})
        Me.cmbdoc.Location = New System.Drawing.Point(123, 410)
        Me.cmbdoc.Name = "cmbdoc"
        Me.cmbdoc.Size = New System.Drawing.Size(184, 21)
        Me.cmbdoc.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(339, 410)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(308, 413)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "N°"
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsalir.Image = Global.Inventario_Informatico.My.Resources.Resources._75
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(686, 410)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(64, 55)
        Me.btnsalir.TabIndex = 37
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancelar.Image = Global.Inventario_Informatico.My.Resources.Resources._08
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(605, 409)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(64, 55)
        Me.btncancelar.TabIndex = 36
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btngrabar
        '
        Me.btngrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btngrabar.Image = Global.Inventario_Informatico.My.Resources.Resources._21
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(524, 409)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(64, 55)
        Me.btngrabar.TabIndex = 35
        Me.btngrabar.Text = "&Grabar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = False
        '
        'FrmTrasladoACC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 472)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmbdoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmTrasladoACC"
        Me.Text = "FrmTrasladoACC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusuario1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lwvCMP1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwcmp2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblusuario2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbusuario1 As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbusuario2 As System.Windows.Forms.ComboBox
    Friend WithEvents lvwcpua As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwcpub As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbdoc As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
End Class
