﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkingDataShowBall
    Inherits System.Windows.Forms.Form

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CtrlPivotGrid1 = New pdt_es01_client.ctrlPivotGrid()
        CType(Me.CtrlPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 625)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CtrlPivotGrid1
        '
        Me.CtrlPivotGrid1.AllowUserToAddRows = False
        Me.CtrlPivotGrid1.AllowUserToDeleteRows = False
        Me.CtrlPivotGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlPivotGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CtrlPivotGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CtrlPivotGrid1.GroupedDuplicateCells = False
        Me.CtrlPivotGrid1.HideDuplicateColumns = 0
        Me.CtrlPivotGrid1.Location = New System.Drawing.Point(0, 1)
        Me.CtrlPivotGrid1.Name = "CtrlPivotGrid1"
        Me.CtrlPivotGrid1.ReadOnly = True
        Me.CtrlPivotGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.CtrlPivotGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CtrlPivotGrid1.Size = New System.Drawing.Size(1015, 618)
        Me.CtrlPivotGrid1.TabIndex = 2
        '
        'frmClentSample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 661)
        Me.Controls.Add(Me.CtrlPivotGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmClentSample"
        Me.Text = "Form1"
        CType(Me.CtrlPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CtrlPivotGrid1 As pdt_es01_client.ctrlPivotGrid

End Class
