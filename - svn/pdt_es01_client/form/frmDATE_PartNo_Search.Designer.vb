<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDATE_PartNo_Search
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.chbConnRod4 = New System.Windows.Forms.CheckBox()
        Me.chbConnRod3 = New System.Windows.Forms.CheckBox()
        Me.chbConnRod2 = New System.Windows.Forms.CheckBox()
        Me.chbConnRod1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbnCamShaftIn = New System.Windows.Forms.RadioButton()
        Me.rbnCamShaftEx = New System.Windows.Forms.RadioButton()
        Me.rbnCylenderHead = New System.Windows.Forms.RadioButton()
        Me.rbnCrankShaft = New System.Windows.Forms.RadioButton()
        Me.rbnConnRod = New System.Windows.Forms.RadioButton()
        Me.rbnCylenderBlock = New System.Windows.Forms.RadioButton()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(161, -114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(699, 55)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Search by ASM DATE + PART"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtDateTo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtDateFrom)
        Me.GroupBox1.Controls.Add(Me.chbConnRod4)
        Me.GroupBox1.Controls.Add(Me.chbConnRod3)
        Me.GroupBox1.Controls.Add(Me.chbConnRod2)
        Me.GroupBox1.Controls.Add(Me.chbConnRod1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbnCamShaftIn)
        Me.GroupBox1.Controls.Add(Me.rbnCamShaftEx)
        Me.GroupBox1.Controls.Add(Me.rbnCylenderHead)
        Me.GroupBox1.Controls.Add(Me.rbnCrankShaft)
        Me.GroupBox1.Controls.Add(Me.rbnConnRod)
        Me.GroupBox1.Controls.Add(Me.rbnCylenderBlock)
        Me.GroupBox1.Location = New System.Drawing.Point(161, -53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 266)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "(YYYYMMDD)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "(YYYYMMDD)"
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "yyyyMMdd"
        Me.dtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(237, 204)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(142, 30)
        Me.dtDateTo.TabIndex = 10
        Me.dtDateTo.Value = New Date(2015, 10, 7, 11, 10, 40, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 25)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "TO"
        '
        'dtDateFrom
        '
        Me.dtDateFrom.CustomFormat = "yyyyMMdd"
        Me.dtDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrom.Location = New System.Drawing.Point(237, 168)
        Me.dtDateFrom.Name = "dtDateFrom"
        Me.dtDateFrom.Size = New System.Drawing.Size(142, 30)
        Me.dtDateFrom.TabIndex = 9
        Me.dtDateFrom.Value = New Date(2015, 10, 7, 11, 10, 46, 0)
        '
        'chbConnRod4
        '
        Me.chbConnRod4.AutoSize = True
        Me.chbConnRod4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chbConnRod4.Location = New System.Drawing.Point(509, 46)
        Me.chbConnRod4.Name = "chbConnRod4"
        Me.chbConnRod4.Size = New System.Drawing.Size(33, 19)
        Me.chbConnRod4.TabIndex = 4
        Me.chbConnRod4.Text = "4"
        Me.chbConnRod4.UseVisualStyleBackColor = True
        '
        'chbConnRod3
        '
        Me.chbConnRod3.AutoSize = True
        Me.chbConnRod3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chbConnRod3.Location = New System.Drawing.Point(464, 46)
        Me.chbConnRod3.Name = "chbConnRod3"
        Me.chbConnRod3.Size = New System.Drawing.Size(33, 19)
        Me.chbConnRod3.TabIndex = 4
        Me.chbConnRod3.Text = "3"
        Me.chbConnRod3.UseVisualStyleBackColor = True
        '
        'chbConnRod2
        '
        Me.chbConnRod2.AutoSize = True
        Me.chbConnRod2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chbConnRod2.Location = New System.Drawing.Point(419, 46)
        Me.chbConnRod2.Name = "chbConnRod2"
        Me.chbConnRod2.Size = New System.Drawing.Size(33, 19)
        Me.chbConnRod2.TabIndex = 3
        Me.chbConnRod2.Text = "2"
        Me.chbConnRod2.UseVisualStyleBackColor = True
        '
        'chbConnRod1
        '
        Me.chbConnRod1.AutoSize = True
        Me.chbConnRod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chbConnRod1.Location = New System.Drawing.Point(368, 46)
        Me.chbConnRod1.Name = "chbConnRod1"
        Me.chbConnRod1.Size = New System.Drawing.Size(33, 19)
        Me.chbConnRod1.TabIndex = 2
        Me.chbConnRod1.Text = "1"
        Me.chbConnRod1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(145, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FROM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SELECT PART"
        '
        'rbnCamShaftIn
        '
        Me.rbnCamShaftIn.AutoSize = True
        Me.rbnCamShaftIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCamShaftIn.Location = New System.Drawing.Point(237, 120)
        Me.rbnCamShaftIn.Name = "rbnCamShaftIn"
        Me.rbnCamShaftIn.Size = New System.Drawing.Size(115, 19)
        Me.rbnCamShaftIn.TabIndex = 7
        Me.rbnCamShaftIn.TabStop = True
        Me.rbnCamShaftIn.Text = "CAM SHAFT (IN)"
        Me.rbnCamShaftIn.UseVisualStyleBackColor = True
        '
        'rbnCamShaftEx
        '
        Me.rbnCamShaftEx.AutoSize = True
        Me.rbnCamShaftEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCamShaftEx.Location = New System.Drawing.Point(237, 145)
        Me.rbnCamShaftEx.Name = "rbnCamShaftEx"
        Me.rbnCamShaftEx.Size = New System.Drawing.Size(119, 19)
        Me.rbnCamShaftEx.TabIndex = 8
        Me.rbnCamShaftEx.TabStop = True
        Me.rbnCamShaftEx.Text = "CAM SHAFT (EX)"
        Me.rbnCamShaftEx.UseVisualStyleBackColor = True
        '
        'rbnCylenderHead
        '
        Me.rbnCylenderHead.AutoSize = True
        Me.rbnCylenderHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCylenderHead.Location = New System.Drawing.Point(237, 70)
        Me.rbnCylenderHead.Name = "rbnCylenderHead"
        Me.rbnCylenderHead.Size = New System.Drawing.Size(126, 19)
        Me.rbnCylenderHead.TabIndex = 5
        Me.rbnCylenderHead.TabStop = True
        Me.rbnCylenderHead.Text = "CYLENDER HEAD"
        Me.rbnCylenderHead.UseVisualStyleBackColor = True
        '
        'rbnCrankShaft
        '
        Me.rbnCrankShaft.AutoSize = True
        Me.rbnCrankShaft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCrankShaft.Location = New System.Drawing.Point(237, 95)
        Me.rbnCrankShaft.Name = "rbnCrankShaft"
        Me.rbnCrankShaft.Size = New System.Drawing.Size(107, 19)
        Me.rbnCrankShaft.TabIndex = 6
        Me.rbnCrankShaft.TabStop = True
        Me.rbnCrankShaft.Text = "CRANK SHAFT"
        Me.rbnCrankShaft.UseVisualStyleBackColor = True
        '
        'rbnConnRod
        '
        Me.rbnConnRod.AutoSize = True
        Me.rbnConnRod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnConnRod.Location = New System.Drawing.Point(237, 45)
        Me.rbnConnRod.Name = "rbnConnRod"
        Me.rbnConnRod.Size = New System.Drawing.Size(93, 19)
        Me.rbnConnRod.TabIndex = 1
        Me.rbnConnRod.TabStop = True
        Me.rbnConnRod.Text = "CONN. ROD"
        Me.rbnConnRod.UseVisualStyleBackColor = True
        '
        'rbnCylenderBlock
        '
        Me.rbnCylenderBlock.AutoSize = True
        Me.rbnCylenderBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCylenderBlock.Location = New System.Drawing.Point(237, 20)
        Me.rbnCylenderBlock.Name = "rbnCylenderBlock"
        Me.rbnCylenderBlock.Size = New System.Drawing.Size(133, 19)
        Me.rbnCylenderBlock.TabIndex = 0
        Me.rbnCylenderBlock.TabStop = True
        Me.rbnCylenderBlock.Text = "CYLENDER BLOCK"
        Me.rbnCylenderBlock.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Purple
        Me.btnMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMainMenu.ForeColor = System.Drawing.Color.White
        Me.btnMainMenu.Location = New System.Drawing.Point(758, 22)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(144, 50)
        Me.btnMainMenu.TabIndex = 12
        Me.btnMainMenu.Text = "MAIN MENU"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Purple
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(398, 22)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(144, 50)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnMainMenu)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Location = New System.Drawing.Point(0, 264)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 102)
        Me.Panel1.TabIndex = 16
        '
        'frmDATE_PartNo_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1016, 365)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmDATE_PartNo_Search"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCTION DATE + PART Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chbConnRod4 As System.Windows.Forms.CheckBox
    Friend WithEvents chbConnRod3 As System.Windows.Forms.CheckBox
    Friend WithEvents chbConnRod2 As System.Windows.Forms.CheckBox
    Friend WithEvents chbConnRod1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbnCamShaftIn As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCamShaftEx As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCylenderHead As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCrankShaft As System.Windows.Forms.RadioButton
    Friend WithEvents rbnConnRod As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCylenderBlock As System.Windows.Forms.RadioButton
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
