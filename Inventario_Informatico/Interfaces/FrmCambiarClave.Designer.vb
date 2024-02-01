<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarClave
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
        Me.label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblcodusuario = New System.Windows.Forms.Label
        Me.lblusuario = New System.Windows.Forms.Label
        Me.txtanterior = New System.Windows.Forms.TextBox
        Me.txtnueva = New System.Windows.Forms.TextBox
        Me.txtrepetir = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(24, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(40, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Clave Anterior"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nueva Clave"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Repetir Nueva Clave"
        '
        'lblcodusuario
        '
        Me.lblcodusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodusuario.Location = New System.Drawing.Point(136, 9)
        Me.lblcodusuario.Name = "lblcodusuario"
        Me.lblcodusuario.Size = New System.Drawing.Size(81, 20)
        Me.lblcodusuario.TabIndex = 5
        '
        'lblusuario
        '
        Me.lblusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblusuario.Location = New System.Drawing.Point(136, 38)
        Me.lblusuario.Name = "lblusuario"
        Me.lblusuario.Size = New System.Drawing.Size(180, 20)
        Me.lblusuario.TabIndex = 6
        '
        'txtanterior
        '
        Me.txtanterior.Location = New System.Drawing.Point(136, 67)
        Me.txtanterior.MaxLength = 10
        Me.txtanterior.Name = "txtanterior"
        Me.txtanterior.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtanterior.Size = New System.Drawing.Size(180, 20)
        Me.txtanterior.TabIndex = 7
        '
        'txtnueva
        '
        Me.txtnueva.Location = New System.Drawing.Point(136, 96)
        Me.txtnueva.MaxLength = 10
        Me.txtnueva.Name = "txtnueva"
        Me.txtnueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnueva.Size = New System.Drawing.Size(180, 20)
        Me.txtnueva.TabIndex = 8
        '
        'txtrepetir
        '
        Me.txtrepetir.Location = New System.Drawing.Point(136, 127)
        Me.txtrepetir.MaxLength = 10
        Me.txtrepetir.Name = "txtrepetir"
        Me.txtrepetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepetir.Size = New System.Drawing.Size(180, 20)
        Me.txtrepetir.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Image = Global.Inventario_Informatico.My.Resources.Resources._75
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(211, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 51)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "&Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Image = Global.Inventario_Informatico.My.Resources.Resources._08
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(132, 167)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(62, 51)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "&Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Image = Global.Inventario_Informatico.My.Resources.Resources._21
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(52, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 51)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "&Guardar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmCambiarClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(339, 232)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtrepetir)
        Me.Controls.Add(Me.txtnueva)
        Me.Controls.Add(Me.txtanterior)
        Me.Controls.Add(Me.lblusuario)
        Me.Controls.Add(Me.lblcodusuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "FrmCambiarClave"
        Me.Text = "Cambiar Clave"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblcodusuario As System.Windows.Forms.Label
    Friend WithEvents lblusuario As System.Windows.Forms.Label
    Friend WithEvents txtanterior As System.Windows.Forms.TextBox
    Friend WithEvents txtnueva As System.Windows.Forms.TextBox
    Friend WithEvents txtrepetir As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
