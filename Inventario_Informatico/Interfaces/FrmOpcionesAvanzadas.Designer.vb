<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpcionesAvanzadas
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
        Me.rbmarca = New System.Windows.Forms.RadioButton
        Me.rbmodelo = New System.Windows.Forms.RadioButton
        Me.rbserie = New System.Windows.Forms.RadioButton
        Me.lblcodigo = New System.Windows.Forms.Label
        Me.btnver = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblopcion = New System.Windows.Forms.Label
        Me.btnbuscarmarca = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbmarca
        '
        Me.rbmarca.AutoSize = True
        Me.rbmarca.Location = New System.Drawing.Point(28, 19)
        Me.rbmarca.Name = "rbmarca"
        Me.rbmarca.Size = New System.Drawing.Size(55, 17)
        Me.rbmarca.TabIndex = 0
        Me.rbmarca.TabStop = True
        Me.rbmarca.Text = "Marca"
        Me.rbmarca.UseVisualStyleBackColor = True
        '
        'rbmodelo
        '
        Me.rbmodelo.AutoSize = True
        Me.rbmodelo.Location = New System.Drawing.Point(143, 19)
        Me.rbmodelo.Name = "rbmodelo"
        Me.rbmodelo.Size = New System.Drawing.Size(60, 17)
        Me.rbmodelo.TabIndex = 1
        Me.rbmodelo.TabStop = True
        Me.rbmodelo.Text = "Modelo"
        Me.rbmodelo.UseVisualStyleBackColor = True
        '
        'rbserie
        '
        Me.rbserie.AutoSize = True
        Me.rbserie.Location = New System.Drawing.Point(260, 19)
        Me.rbserie.Name = "rbserie"
        Me.rbserie.Size = New System.Drawing.Size(49, 17)
        Me.rbserie.TabIndex = 2
        Me.rbserie.TabStop = True
        Me.rbserie.Text = "Serie"
        Me.rbserie.UseVisualStyleBackColor = True
        '
        'lblcodigo
        '
        Me.lblcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcodigo.Location = New System.Drawing.Point(22, 75)
        Me.lblcodigo.Name = "lblcodigo"
        Me.lblcodigo.Size = New System.Drawing.Size(37, 21)
        Me.lblcodigo.TabIndex = 4
        '
        'btnver
        '
        Me.btnver.Image = Global.Inventario_Informatico.My.Resources.Resources.Copia_de_11
        Me.btnver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnver.Location = New System.Drawing.Point(138, 101)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(72, 54)
        Me.btnver.TabIndex = 6
        Me.btnver.Text = "&Ver Reporte"
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbmarca)
        Me.GroupBox1.Controls.Add(Me.rbmodelo)
        Me.GroupBox1.Controls.Add(Me.rbserie)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 46)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione una Opción"
        '
        'lblopcion
        '
        Me.lblopcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblopcion.Location = New System.Drawing.Point(22, 75)
        Me.lblopcion.Name = "lblopcion"
        Me.lblopcion.Size = New System.Drawing.Size(286, 21)
        Me.lblopcion.TabIndex = 8
        '
        'btnbuscarmarca
        '
        Me.btnbuscarmarca.Image = Global.Inventario_Informatico.My.Resources.Resources._33
        Me.btnbuscarmarca.Location = New System.Drawing.Point(314, 58)
        Me.btnbuscarmarca.Name = "btnbuscarmarca"
        Me.btnbuscarmarca.Size = New System.Drawing.Size(55, 48)
        Me.btnbuscarmarca.TabIndex = 13
        Me.btnbuscarmarca.Text = "..."
        Me.btnbuscarmarca.UseVisualStyleBackColor = True
        '
        'FrmOpcionesAvanzadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 167)
        Me.Controls.Add(Me.btnbuscarmarca)
        Me.Controls.Add(Me.lblopcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.lblcodigo)
        Me.Name = "FrmOpcionesAvanzadas"
        Me.Text = "Opciones Avanzadas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbmarca As System.Windows.Forms.RadioButton
    Friend WithEvents rbmodelo As System.Windows.Forms.RadioButton
    Friend WithEvents rbserie As System.Windows.Forms.RadioButton
    Friend WithEvents lblcodigo As System.Windows.Forms.Label
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblopcion As System.Windows.Forms.Label
    Friend WithEvents btnbuscarmarca As System.Windows.Forms.Button
End Class
