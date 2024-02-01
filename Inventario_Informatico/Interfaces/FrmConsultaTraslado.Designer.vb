<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaTraslado
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
        Me.dtdel = New System.Windows.Forms.DateTimePicker
        Me.dtal = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Lvwtraslados = New System.Windows.Forms.ListView
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
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.btnverdetalle = New System.Windows.Forms.Button
        Me.btnimprimir = New System.Windows.Forms.Button
        Me.btnver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dtdel
        '
        Me.dtdel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdel.Location = New System.Drawing.Point(40, 32)
        Me.dtdel.Name = "dtdel"
        Me.dtdel.Size = New System.Drawing.Size(118, 20)
        Me.dtdel.TabIndex = 0
        '
        'dtal
        '
        Me.dtal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtal.Location = New System.Drawing.Point(241, 32)
        Me.dtal.Name = "dtal"
        Me.dtal.Size = New System.Drawing.Size(118, 20)
        Me.dtal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Del"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Al"
        '
        'Lvwtraslados
        '
        Me.Lvwtraslados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13})
        Me.Lvwtraslados.FullRowSelect = True
        Me.Lvwtraslados.GridLines = True
        Me.Lvwtraslados.HideSelection = False
        Me.Lvwtraslados.Location = New System.Drawing.Point(12, 66)
        Me.Lvwtraslados.Name = "Lvwtraslados"
        Me.Lvwtraslados.Size = New System.Drawing.Size(827, 226)
        Me.Lvwtraslados.TabIndex = 4
        Me.Lvwtraslados.UseCompatibleStateImageBehavior = False
        Me.Lvwtraslados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Documento"
        Me.ColumnHeader1.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "De"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "A"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Descripción"
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Marca"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Modelo"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Serie"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "SBN"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Velosidad"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Capacidad"
        Me.ColumnHeader10.Width = 73
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Area de"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Area a"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Fecha"
        '
        'btnverdetalle
        '
        Me.btnverdetalle.Image = Global.Inventario_Informatico.My.Resources.Resources.find
        Me.btnverdetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnverdetalle.Location = New System.Drawing.Point(747, 21)
        Me.btnverdetalle.Name = "btnverdetalle"
        Me.btnverdetalle.Size = New System.Drawing.Size(92, 35)
        Me.btnverdetalle.TabIndex = 7
        Me.btnverdetalle.Text = "&Ver Detalle"
        Me.btnverdetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnverdetalle.UseVisualStyleBackColor = True
        '
        'btnimprimir
        '
        Me.btnimprimir.Image = Global.Inventario_Informatico.My.Resources.Resources._20
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimprimir.Location = New System.Drawing.Point(632, 21)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(91, 35)
        Me.btnimprimir.TabIndex = 6
        Me.btnimprimir.Text = "&Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnimprimir.UseVisualStyleBackColor = True
        '
        'btnver
        '
        Me.btnver.Image = Global.Inventario_Informatico.My.Resources.Resources._33
        Me.btnver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnver.Location = New System.Drawing.Point(394, 21)
        Me.btnver.Name = "btnver"
        Me.btnver.Size = New System.Drawing.Size(75, 34)
        Me.btnver.TabIndex = 5
        Me.btnver.Text = "&Ver"
        Me.btnver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnver.UseVisualStyleBackColor = True
        '
        'FrmConsultaTraslado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 307)
        Me.Controls.Add(Me.btnverdetalle)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.btnver)
        Me.Controls.Add(Me.Lvwtraslados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtal)
        Me.Controls.Add(Me.dtdel)
        Me.MaximizeBox = False
        Me.Name = "FrmConsultaTraslado"
        Me.Text = "FrmConsultaTraslado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtdel As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lvwtraslados As System.Windows.Forms.ListView
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
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnver As System.Windows.Forms.Button
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnverdetalle As System.Windows.Forms.Button
End Class
