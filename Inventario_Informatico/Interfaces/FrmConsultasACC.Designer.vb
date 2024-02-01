<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasACC
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.CMBACCESORIO = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.rbarea = New System.Windows.Forms.RadioButton
        Me.rbaccesorio = New System.Windows.Forms.RadioButton
        Me.rbausuario = New System.Windows.Forms.RadioButton
        Me.btnopciones = New System.Windows.Forms.Button
        Me.btnver = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'CMBACCESORIO
        '
        Me.CMBACCESORIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBACCESORIO.FormattingEnabled = True
        Me.CMBACCESORIO.Location = New System.Drawing.Point(12, 55)
        Me.CMBACCESORIO.Name = "CMBACCESORIO"
        Me.CMBACCESORIO.Size = New System.Drawing.Size(283, 21)
        Me.CMBACCESORIO.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbarea)
        Me.Panel1.Controls.Add(Me.rbaccesorio)
        Me.Panel1.Controls.Add(Me.rbausuario)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 33)
        Me.Panel1.TabIndex = 4
        '
        'rbarea
        '
        Me.rbarea.AutoSize = True
        Me.rbarea.Location = New System.Drawing.Point(196, 10)
        Me.rbarea.Name = "rbarea"
        Me.rbarea.Size = New System.Drawing.Size(47, 17)
        Me.rbarea.TabIndex = 2
        Me.rbarea.TabStop = True
        Me.rbarea.Text = "Área"
        Me.rbarea.UseVisualStyleBackColor = True
        '
        'rbaccesorio
        '
        Me.rbaccesorio.AutoSize = True
        Me.rbaccesorio.Location = New System.Drawing.Point(94, 10)
        Me.rbaccesorio.Name = "rbaccesorio"
        Me.rbaccesorio.Size = New System.Drawing.Size(72, 17)
        Me.rbaccesorio.TabIndex = 1
        Me.rbaccesorio.TabStop = True
        Me.rbaccesorio.Text = "Accesorio"
        Me.rbaccesorio.UseVisualStyleBackColor = True
        '
        'rbausuario
        '
        Me.rbausuario.AutoSize = True
        Me.rbausuario.Location = New System.Drawing.Point(19, 10)
        Me.rbausuario.Name = "rbausuario"
        Me.rbausuario.Size = New System.Drawing.Size(61, 17)
        Me.rbausuario.TabIndex = 0
        Me.rbausuario.TabStop = True
        Me.rbausuario.Text = "Usuario"
        Me.rbausuario.UseVisualStyleBackColor = True
        '
        'btnopciones
        '
        Me.btnopciones.Image = Global.Inventario_Informatico.My.Resources.Resources.find
        Me.btnopciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnopciones.Location = New System.Drawing.Point(75, 82)
        Me.btnopciones.Name = "btnopciones"
        Me.btnopciones.Size = New System.Drawing.Size(82, 54)
        Me.btnopciones.TabIndex = 8
        Me.btnopciones.Text = "&Opciones Avanzadas"
        Me.btnopciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnopciones.UseVisualStyleBackColor = True
        '
        'btnver
        '
        Me.btnver.Image = Global.Inventario_Informatico.My.Resources.Resources.Copia_de_11
        Me.btnver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnver.Location = New System.Drawing.Point(163, 82)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(72, 54)
        Me.btnver.TabIndex = 5
        Me.btnver.Text = "&Ver Reporte"
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnver.UseVisualStyleBackColor = True
        '
        'FrmConsultasACC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(307, 140)
        Me.Controls.Add(Me.btnopciones)
        Me.Controls.Add(Me.CMBACCESORIO)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConsultasACC"
        Me.Text = "Consulta de Accesorios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMBACCESORIO As System.Windows.Forms.ComboBox
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbausuario As System.Windows.Forms.RadioButton
    Friend WithEvents rbarea As System.Windows.Forms.RadioButton
    Friend WithEvents rbaccesorio As System.Windows.Forms.RadioButton
    Friend WithEvents btnopciones As System.Windows.Forms.Button
End Class
