<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarAreas
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
        Me.txtarea = New System.Windows.Forms.TextBox
        Me.lvwareas = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtarea
        '
        Me.txtarea.Location = New System.Drawing.Point(55, 3)
        Me.txtarea.Name = "txtarea"
        Me.txtarea.Size = New System.Drawing.Size(254, 20)
        Me.txtarea.TabIndex = 5
        '
        'lvwareas
        '
        Me.lvwareas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwareas.FullRowSelect = True
        Me.lvwareas.GridLines = True
        Me.lvwareas.HideSelection = False
        Me.lvwareas.Location = New System.Drawing.Point(55, 29)
        Me.lvwareas.Name = "lvwareas"
        Me.lvwareas.Size = New System.Drawing.Size(254, 97)
        Me.lvwareas.TabIndex = 4
        Me.lvwareas.UseCompatibleStateImageBehavior = False
        Me.lvwareas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        Me.ColumnHeader1.Width = 54
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Area"
        Me.ColumnHeader2.Width = 196
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Area"
        '
        'FrmBuscarAreas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(333, 137)
        Me.Controls.Add(Me.txtarea)
        Me.Controls.Add(Me.lvwareas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBuscarAreas"
        Me.Text = "Buscar Area"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtarea As System.Windows.Forms.TextBox
    Friend WithEvents lvwareas As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
