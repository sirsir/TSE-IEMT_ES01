<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
    'Inherits System.Windows.Forms.Form
    Inherits frmBase

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelHeading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Location = New System.Drawing.Point(41, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 0)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Visible = False
        '
        'LabelHeading
        '
        Me.LabelHeading.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelHeading.Location = New System.Drawing.Point(-214, 0)
        Me.LabelHeading.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelHeading.Name = "LabelHeading"
        Me.LabelHeading.Size = New System.Drawing.Size(107, 38)
        Me.LabelHeading.TabIndex = 3
        Me.LabelHeading.Text = "Label1"
        Me.LabelHeading.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 33.0!)
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.LabelHeading)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.Name = "frmSearch"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.LabelHeading, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LabelHeading As System.Windows.Forms.Label

End Class
