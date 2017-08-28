<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmData
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
        Me.CtrlPivotGrid1 = New pdt_es01_client.ctrlPivotGrid()
        CType(Me.CtrlPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtrlPivotGrid1
        '
        Me.CtrlPivotGrid1.AllowUserToAddRows = False
        Me.CtrlPivotGrid1.AllowUserToDeleteRows = False
        Me.CtrlPivotGrid1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CtrlPivotGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CtrlPivotGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CtrlPivotGrid1.GroupedDuplicateCells = False
        Me.CtrlPivotGrid1.HideDuplicateColumns = 0
        Me.CtrlPivotGrid1.Location = New System.Drawing.Point(9, 9)
        Me.CtrlPivotGrid1.Margin = New System.Windows.Forms.Padding(0)
        Me.CtrlPivotGrid1.Name = "CtrlPivotGrid1"
        'Me.CtrlPivotGrid1.ReadOnly = True
        Me.CtrlPivotGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.CtrlPivotGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CtrlPivotGrid1.Size = New System.Drawing.Size(2751, 1485)
        Me.CtrlPivotGrid1.TabIndex = 3
        '
        'frmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 665)
        Me.Controls.Add(Me.CtrlPivotGrid1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.Margin = New System.Windows.Forms.Padding(23, 20, 23, 20)
        Me.MinimumSize = New System.Drawing.Size(1364, 704)
        Me.Name = "frmData"
        Me.Text = "frmData"
        Me.Controls.SetChildIndex(Me.CtrlPivotGrid1, 0)
        CType(Me.CtrlPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents CtrlPivotGrid1 As pdt_es01_client.ctrlPivotGrid
End Class
