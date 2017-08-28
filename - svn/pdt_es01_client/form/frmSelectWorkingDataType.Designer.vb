<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectWorkingDataType
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.LabelHeading = New System.Windows.Forms.Label()
        Me.Panel4LabelHeading = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 994.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CheckedListBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(55, 48)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(994, 385)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(275, 0)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(444, 364)
        Me.CheckedListBox1.TabIndex = 0
        '
        'LabelHeading
        '
        Me.LabelHeading.AutoSize = True
        Me.LabelHeading.BackColor = System.Drawing.Color.Yellow
        Me.LabelHeading.Location = New System.Drawing.Point(84, 9)
        Me.LabelHeading.Name = "LabelHeading"
        Me.LabelHeading.Size = New System.Drawing.Size(373, 36)
        Me.LabelHeading.TabIndex = 6
        Me.LabelHeading.Text = "SELECT THE DATA TYPE"
        '
        'Panel4LabelHeading
        '
        Me.Panel4LabelHeading.AutoSize = True
        Me.Panel4LabelHeading.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4LabelHeading.BackColor = System.Drawing.Color.Yellow
        Me.Panel4LabelHeading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4LabelHeading.ForeColor = System.Drawing.Color.Blue
        Me.Panel4LabelHeading.Location = New System.Drawing.Point(55, 13)
        Me.Panel4LabelHeading.Name = "Panel4LabelHeading"
        Me.Panel4LabelHeading.Size = New System.Drawing.Size(2, 2)
        Me.Panel4LabelHeading.TabIndex = 7
        '
        'frmSelectWorkingDataType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 666)
        Me.Controls.Add(Me.LabelHeading)
        Me.Controls.Add(Me.Panel4LabelHeading)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(23, 20, 23, 20)
        Me.MinimumSize = New System.Drawing.Size(1364, 704)
        Me.Name = "frmSelectWorkingDataType"
        Me.ShowInTaskbar = False
        Me.Text = "DATA TYPE"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.Panel4LabelHeading, 0)
        Me.Controls.SetChildIndex(Me.LabelHeading, 0)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelHeading As System.Windows.Forms.Label
    Friend WithEvents Panel4LabelHeading As System.Windows.Forms.Panel
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
End Class
