<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialNo_PartNo_Search
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
        Me.chbConnRod4 = New System.Windows.Forms.CheckBox()
        Me.chbConnRod3 = New System.Windows.Forms.CheckBox()
        Me.chbConnRod2 = New System.Windows.Forms.CheckBox()
        Me.chbConnRod1 = New System.Windows.Forms.CheckBox()
        Me.txtSerialNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbnCamShaftIn = New System.Windows.Forms.RadioButton()
        Me.rbnCamShaftEx = New System.Windows.Forms.RadioButton()
        Me.rbnCylenderHead = New System.Windows.Forms.RadioButton()
        Me.rbnCrankShaft = New System.Windows.Forms.RadioButton()
        Me.rbnConnRod = New System.Windows.Forms.RadioButton()
        Me.rbnCylenderBlock = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
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
        Me.Button1.Location = New System.Drawing.Point(161, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(680, 55)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Search by SERIAL No."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chbConnRod4)
        Me.GroupBox1.Controls.Add(Me.chbConnRod3)
        Me.GroupBox1.Controls.Add(Me.chbConnRod2)
        Me.GroupBox1.Controls.Add(Me.chbConnRod1)
        Me.GroupBox1.Controls.Add(Me.txtSerialNo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbnCamShaftIn)
        Me.GroupBox1.Controls.Add(Me.rbnCamShaftEx)
        Me.GroupBox1.Controls.Add(Me.rbnCylenderHead)
        Me.GroupBox1.Controls.Add(Me.rbnCrankShaft)
        Me.GroupBox1.Controls.Add(Me.rbnConnRod)
        Me.GroupBox1.Controls.Add(Me.rbnCylenderBlock)
        Me.GroupBox1.Location = New System.Drawing.Point(161, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 216)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'chbConnRod4
        '
        Me.chbConnRod4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbConnRod4.AutoSize = True
        Me.chbConnRod4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chbConnRod4.Location = New System.Drawing.Point(509, 46)
        Me.chbConnRod4.Name = "chbConnRod4"
        Me.chbConnRod4.Size = New System.Drawing.Size(33, 19)
        Me.chbConnRod4.TabIndex = 5
        Me.chbConnRod4.Text = "4"
        Me.chbConnRod4.UseVisualStyleBackColor = True
        '
        'chbConnRod3
        '
        Me.chbConnRod3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.chbConnRod2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.chbConnRod1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbConnRod1.AutoSize = True
        Me.chbConnRod1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chbConnRod1.Location = New System.Drawing.Point(368, 46)
        Me.chbConnRod1.Name = "chbConnRod1"
        Me.chbConnRod1.Size = New System.Drawing.Size(33, 19)
        Me.chbConnRod1.TabIndex = 2
        Me.chbConnRod1.Text = "1"
        Me.chbConnRod1.UseVisualStyleBackColor = True
        '
        'txtSerialNo
        '
        Me.txtSerialNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerialNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSerialNo.Location = New System.Drawing.Point(237, 170)
        Me.txtSerialNo.Name = "txtSerialNo"
        Me.txtSerialNo.Size = New System.Drawing.Size(178, 30)
        Me.txtSerialNo.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "SERIAL No."
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.rbnCamShaftIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbnCamShaftIn.AutoSize = True
        Me.rbnCamShaftIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCamShaftIn.Location = New System.Drawing.Point(237, 120)
        Me.rbnCamShaftIn.Name = "rbnCamShaftIn"
        Me.rbnCamShaftIn.Size = New System.Drawing.Size(115, 19)
        Me.rbnCamShaftIn.TabIndex = 8
        Me.rbnCamShaftIn.TabStop = True
        Me.rbnCamShaftIn.Text = "CAM SHAFT (IN)"
        Me.rbnCamShaftIn.UseVisualStyleBackColor = True
        '
        'rbnCamShaftEx
        '
        Me.rbnCamShaftEx.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbnCamShaftEx.AutoSize = True
        Me.rbnCamShaftEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCamShaftEx.Location = New System.Drawing.Point(237, 145)
        Me.rbnCamShaftEx.Name = "rbnCamShaftEx"
        Me.rbnCamShaftEx.Size = New System.Drawing.Size(119, 19)
        Me.rbnCamShaftEx.TabIndex = 9
        Me.rbnCamShaftEx.TabStop = True
        Me.rbnCamShaftEx.Text = "CAM SHAFT (EX)"
        Me.rbnCamShaftEx.UseVisualStyleBackColor = True
        '
        'rbnCylenderHead
        '
        Me.rbnCylenderHead.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbnCylenderHead.AutoSize = True
        Me.rbnCylenderHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCylenderHead.Location = New System.Drawing.Point(237, 70)
        Me.rbnCylenderHead.Name = "rbnCylenderHead"
        Me.rbnCylenderHead.Size = New System.Drawing.Size(126, 19)
        Me.rbnCylenderHead.TabIndex = 6
        Me.rbnCylenderHead.TabStop = True
        Me.rbnCylenderHead.Text = "CYLENDER HEAD"
        Me.rbnCylenderHead.UseVisualStyleBackColor = True
        '
        'rbnCrankShaft
        '
        Me.rbnCrankShaft.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbnCrankShaft.AutoSize = True
        Me.rbnCrankShaft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rbnCrankShaft.Location = New System.Drawing.Point(237, 95)
        Me.rbnCrankShaft.Name = "rbnCrankShaft"
        Me.rbnCrankShaft.Size = New System.Drawing.Size(107, 19)
        Me.rbnCrankShaft.TabIndex = 7
        Me.rbnCrankShaft.TabStop = True
        Me.rbnCrankShaft.Text = "CRANK SHAFT"
        Me.rbnCrankShaft.UseVisualStyleBackColor = True
        '
        'rbnConnRod
        '
        Me.rbnConnRod.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.rbnCylenderBlock.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Purple
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(403, 22)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(144, 50)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnMainMenu)
        Me.Panel1.Controls.Add(Me.btnOK)
        Me.Panel1.Location = New System.Drawing.Point(-5, 338)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 102)
        Me.Panel1.TabIndex = 14
        '
        'frmSerialNo_PartNo_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(896, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmSerialNo_PartNo_Search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERIAL No. + PART Search"
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
    Friend WithEvents txtSerialNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbnCamShaftIn As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCamShaftEx As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCylenderHead As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCrankShaft As System.Windows.Forms.RadioButton
    Friend WithEvents rbnConnRod As System.Windows.Forms.RadioButton
    Friend WithEvents rbnCylenderBlock As System.Windows.Forms.RadioButton
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
