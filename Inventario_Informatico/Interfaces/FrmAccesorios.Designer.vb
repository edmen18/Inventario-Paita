<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccesorios
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnbuscarmodelo = New System.Windows.Forms.Button
        Me.lblmodelo = New System.Windows.Forms.Label
        Me.lblcodmodelo = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblmarca = New System.Windows.Forms.Label
        Me.btnbuscarmarca = New System.Windows.Forms.Button
        Me.lblcodmarca = New System.Windows.Forms.Label
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbestado = New System.Windows.Forms.ComboBox
        Me.txtpatrimonio = New System.Windows.Forms.TextBox
        Me.txtserie = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lvwaccesorios = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.lblaccesorio = New System.Windows.Forms.Label
        Me.cmbaccesorio = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btnsalir = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btngrabar = New System.Windows.Forms.Button
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblregistro = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 69)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(663, 295)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(655, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbestado)
        Me.GroupBox1.Controls.Add(Me.txtpatrimonio)
        Me.GroupBox1.Controls.Add(Me.txtserie)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(627, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnbuscarmodelo)
        Me.GroupBox3.Controls.Add(Me.lblmodelo)
        Me.GroupBox3.Controls.Add(Me.lblcodmodelo)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 46)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Modelo"
        '
        'btnbuscarmodelo
        '
        Me.btnbuscarmodelo.Image = Global.Inventario_Informatico.My.Resources.Resources._33
        Me.btnbuscarmodelo.Location = New System.Drawing.Point(295, 9)
        Me.btnbuscarmodelo.Name = "btnbuscarmodelo"
        Me.btnbuscarmodelo.Size = New System.Drawing.Size(35, 34)
        Me.btnbuscarmodelo.TabIndex = 15
        Me.btnbuscarmodelo.Text = "..."
        Me.btnbuscarmodelo.UseVisualStyleBackColor = True
        '
        'lblmodelo
        '
        Me.lblmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmodelo.Location = New System.Drawing.Point(20, 16)
        Me.lblmodelo.Name = "lblmodelo"
        Me.lblmodelo.Size = New System.Drawing.Size(269, 23)
        Me.lblmodelo.TabIndex = 14
        '
        'lblcodmodelo
        '
        Me.lblcodmodelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodmodelo.Location = New System.Drawing.Point(20, 16)
        Me.lblcodmodelo.Name = "lblcodmodelo"
        Me.lblcodmodelo.Size = New System.Drawing.Size(10, 23)
        Me.lblcodmodelo.TabIndex = 13
        Me.lblcodmodelo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblmarca)
        Me.GroupBox2.Controls.Add(Me.btnbuscarmarca)
        Me.GroupBox2.Controls.Add(Me.lblcodmarca)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 43)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Marca"
        '
        'lblmarca
        '
        Me.lblmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmarca.Location = New System.Drawing.Point(20, 16)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.Size = New System.Drawing.Size(269, 23)
        Me.lblmarca.TabIndex = 11
        '
        'btnbuscarmarca
        '
        Me.btnbuscarmarca.Image = Global.Inventario_Informatico.My.Resources.Resources._33
        Me.btnbuscarmarca.Location = New System.Drawing.Point(295, 6)
        Me.btnbuscarmarca.Name = "btnbuscarmarca"
        Me.btnbuscarmarca.Size = New System.Drawing.Size(35, 34)
        Me.btnbuscarmarca.TabIndex = 12
        Me.btnbuscarmarca.Text = "..."
        Me.btnbuscarmarca.UseVisualStyleBackColor = True
        '
        'lblcodmarca
        '
        Me.lblcodmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodmarca.Location = New System.Drawing.Point(20, 16)
        Me.lblcodmarca.Name = "lblcodmarca"
        Me.lblcodmarca.Size = New System.Drawing.Size(10, 23)
        Me.lblcodmarca.TabIndex = 10
        Me.lblcodmarca.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(355, 30)
        Me.RichTextBox1.MaxLength = 200
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(266, 178)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(401, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Observaciones"
        '
        'cmbestado
        '
        Me.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbestado.FormattingEnabled = True
        Me.cmbestado.Items.AddRange(New Object() {"Operativo", "No Operativo"})
        Me.cmbestado.Location = New System.Drawing.Point(94, 85)
        Me.cmbestado.Name = "cmbestado"
        Me.cmbestado.Size = New System.Drawing.Size(248, 21)
        Me.cmbestado.TabIndex = 7
        '
        'txtpatrimonio
        '
        Me.txtpatrimonio.Location = New System.Drawing.Point(94, 55)
        Me.txtpatrimonio.MaxLength = 12
        Me.txtpatrimonio.Name = "txtpatrimonio"
        Me.txtpatrimonio.Size = New System.Drawing.Size(248, 20)
        Me.txtpatrimonio.TabIndex = 6
        '
        'txtserie
        '
        Me.txtserie.Location = New System.Drawing.Point(94, 27)
        Me.txtserie.MaxLength = 50
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(248, 20)
        Me.txtserie.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Estado Actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cod Partimonial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serie"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TabPage2.Controls.Add(Me.lvwaccesorios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(655, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado"
        '
        'lvwaccesorios
        '
        Me.lvwaccesorios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwaccesorios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader11, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvwaccesorios.FullRowSelect = True
        Me.lvwaccesorios.GridLines = True
        Me.lvwaccesorios.HideSelection = False
        Me.lvwaccesorios.Location = New System.Drawing.Point(8, 19)
        Me.lvwaccesorios.Name = "lvwaccesorios"
        Me.lvwaccesorios.Size = New System.Drawing.Size(641, 206)
        Me.lvwaccesorios.TabIndex = 1
        Me.lvwaccesorios.UseCompatibleStateImageBehavior = False
        Me.lvwaccesorios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cód Accesorio"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Accesorio"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Cód Marca"
        Me.ColumnHeader3.Width = 0
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Serie"
        Me.ColumnHeader4.Width = 71
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Marca"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Cod Patrimonial"
        Me.ColumnHeader6.Width = 107
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cód Modelo"
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Modelo"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Estado"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Observaciones"
        Me.ColumnHeader9.Width = 111
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "item"
        Me.ColumnHeader10.Width = 0
        '
        'lblaccesorio
        '
        Me.lblaccesorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblaccesorio.Location = New System.Drawing.Point(418, 9)
        Me.lblaccesorio.Name = "lblaccesorio"
        Me.lblaccesorio.Size = New System.Drawing.Size(32, 21)
        Me.lblaccesorio.TabIndex = 13
        '
        'cmbaccesorio
        '
        Me.cmbaccesorio.FormattingEnabled = True
        Me.cmbaccesorio.Location = New System.Drawing.Point(94, 9)
        Me.cmbaccesorio.Name = "cmbaccesorio"
        Me.cmbaccesorio.Size = New System.Drawing.Size(374, 21)
        Me.cmbaccesorio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Accesorio"
        '
        'btnnuevo
        '
        Me.btnnuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnnuevo.Image = Global.Inventario_Informatico.My.Resources.Resources._51
        Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnnuevo.Location = New System.Drawing.Point(193, 370)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(64, 56)
        Me.btnnuevo.TabIndex = 31
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnnuevo.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnsalir.Image = Global.Inventario_Informatico.My.Resources.Resources._75
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalir.Location = New System.Drawing.Point(436, 371)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(64, 55)
        Me.btnsalir.TabIndex = 30
        Me.btnsalir.Text = "&Salir"
        Me.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btncancelar.Image = Global.Inventario_Informatico.My.Resources.Resources._08
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btncancelar.Location = New System.Drawing.Point(355, 370)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(64, 56)
        Me.btncancelar.TabIndex = 29
        Me.btncancelar.Text = "&Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btngrabar
        '
        Me.btngrabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btngrabar.Image = Global.Inventario_Informatico.My.Resources.Resources._21
        Me.btngrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btngrabar.Location = New System.Drawing.Point(274, 370)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(64, 56)
        Me.btngrabar.TabIndex = 28
        Me.btngrabar.Text = "&Grabar"
        Me.btngrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btngrabar.UseVisualStyleBackColor = False
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.Location = New System.Drawing.Point(94, 34)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(43, 21)
        Me.lblcodigo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Cpu."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Registro N°"
        '
        'lblregistro
        '
        Me.lblregistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblregistro.Location = New System.Drawing.Point(251, 33)
        Me.lblregistro.Name = "lblregistro"
        Me.lblregistro.Size = New System.Drawing.Size(87, 21)
        Me.lblregistro.TabIndex = 35
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Image = Global.Inventario_Informatico.My.Resources.Resources.remove
        Me.Button5.Location = New System.Drawing.Point(519, 374)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(62, 51)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "&Eliminar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'FrmAccesorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(697, 437)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblregistro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblcodigo)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.cmbaccesorio)
        Me.Controls.Add(Me.lblaccesorio)
        Me.Name = "FrmAccesorios"
        Me.Text = "Accesorios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpatrimonio As System.Windows.Forms.TextBox
    Friend WithEvents txtserie As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbaccesorio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbestado As System.Windows.Forms.ComboBox
    Friend WithEvents lblcodmarca As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblcodmodelo As System.Windows.Forms.Label
    Friend WithEvents btnbuscarmodelo As System.Windows.Forms.Button
    Friend WithEvents lblmodelo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblmarca As System.Windows.Forms.Label
    Friend WithEvents btnbuscarmarca As System.Windows.Forms.Button
    Friend WithEvents lblaccesorio As System.Windows.Forms.Label
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btngrabar As System.Windows.Forms.Button
    Friend WithEvents lvwaccesorios As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblregistro As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
