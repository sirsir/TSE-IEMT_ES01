﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectDataType
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelHeading = New System.Windows.Forms.Label()
        Me.Panel4LabelHeading = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 8)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(857, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PRODUCTION DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 74)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(857, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "WORKING DATA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(158, 140)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(857, 52)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "TRACEABILITY DATA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 873.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(55, 51)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(994, 200)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 36)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "F1:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "F2:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 36)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "F3:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'frmSelectDataType
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
        Me.Name = "frmSelectDataType"
        Me.ShowInTaskbar = False
        Me.Text = "DATA TYPE"
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.Panel4LabelHeading, 0)
        Me.Controls.SetChildIndex(Me.LabelHeading, 0)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabelHeading As System.Windows.Forms.Label
    Friend WithEvents Panel4LabelHeading As System.Windows.Forms.Panel
End Class
