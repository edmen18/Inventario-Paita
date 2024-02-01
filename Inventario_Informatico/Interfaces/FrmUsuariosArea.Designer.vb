<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuariosArea
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
        Me.CMBACCESORIO = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnver = New System.Windows.Forms.Button
        Me.chktodas = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CMBACCESORIO
        '
        Me.CMBACCESORIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBACCESORIO.FormattingEnabled = True
        Me.CMBACCESORIO.Location = New System.Drawing.Point(12, 24)
        Me.CMBACCESORIO.Name = "CMBACCESORIO"
        Me.CMBACCESORIO.Size = New System.Drawing.Size(290, 21)
        Me.CMBACCESORIO.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 12
        '
        'btnver
        '
        Me.btnver.Image = Global.Inventario_Informatico.My.Resources.Resources.Copia_de_11
        Me.btnver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnver.Location = New System.Drawing.Point(308, 14)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(72, 54)
        Me.btnver.TabIndex = 13
        Me.btnver.Text = "&Ver Reporte"
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnver.UseVisualStyleBackColor = True
        '
        'chktodas
        '
        Me.chktodas.AutoSize = True
        Me.chktodas.Location = New System.Drawing.Point(200, 51)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(102, 17)
        Me.chktodas.TabIndex = 14
        Me.chktodas.Text = "Todas las Areas"
        Me.chktodas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Seleccione un Area"
        '
        'FrmUsuariosArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(387, 89)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chktodas)
        Me.Controls.Add(Me.CMBACCESORIO)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUsuariosArea"
        Me.Text = "Usuarios por Área"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBACCESORIO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents chktodas As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
