﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSerialNo_PartNo_Edit
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
        Me.components = New System.ComponentModel.Container()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DataSet1 = New pdt_es01_client.DataSet1()
        Me.TableAdapterManager = New pdt_es01_client.DataSet1TableAdapters.TableAdapterManager()
        Me.TRACE_DATA_MIXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_DATA_MIXTableAdapter = New pdt_es01_client.DataSet1TableAdapters.TRACE_DATA_MIXTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductionDate = New System.Windows.Forms.Label()
        Me.txtENG_ASM_No = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.Label()
        Me.txtModelCode = New System.Windows.Forms.Label()
        Me.txtEngineNo = New System.Windows.Forms.Label()
        Me.CtrlPivotGrid1 = New pdt_es01_client.ctrlPivotGrid()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_DATA_MIXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrlPivotGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(55, 167)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 35)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(55, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 35)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ENGINE_LISTTableAdapter = Nothing
        Me.TableAdapterManager.TRACE_DATA_DATETIMETableAdapter = Nothing
        'Me.TableAdapterManager.TRACE_DATA_INTTableAdapter = Nothing
        Me.TableAdapterManager.TRACE_DATA_FLOATTableAdapter = Nothing
        Me.TableAdapterManager.TRACE_DATA_STRTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pdt_es01_client.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WORKING_DATA_DATETIMETableAdapter = Nothing
        'Me.TableAdapterManager.WORKING_DATA_INTTableAdapter = Nothing
        Me.TableAdapterManager.WORKING_DATA_FLOATTableAdapter = Nothing
        Me.TableAdapterManager.WORKING_DATA_STRTableAdapter = Nothing
        '
        'TRACE_DATA_MIXBindingSource
        '
        Me.TRACE_DATA_MIXBindingSource.DataMember = "TRACE_DATA_MIX"
        Me.TRACE_DATA_MIXBindingSource.DataSource = Me.DataSet1
        '
        'TRACE_DATA_MIXTableAdapter
        '
        Me.TRACE_DATA_MIXTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ENGINE No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "MODEL CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ENG ASM No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LOT NO."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "PRODUCTION DATE"
        '
        'txtProductionDate
        '
        Me.txtProductionDate.AutoSize = True
        Me.txtProductionDate.Location = New System.Drawing.Point(136, 99)
        Me.txtProductionDate.Name = "txtProductionDate"
        Me.txtProductionDate.Size = New System.Drawing.Size(13, 13)
        Me.txtProductionDate.TabIndex = 15
        Me.txtProductionDate.Text = "[]"
        '
        'txtENG_ASM_No
        '
        Me.txtENG_ASM_No.AutoSize = True
        Me.txtENG_ASM_No.Location = New System.Drawing.Point(136, 79)
        Me.txtENG_ASM_No.Name = "txtENG_ASM_No"
        Me.txtENG_ASM_No.Size = New System.Drawing.Size(13, 13)
        Me.txtENG_ASM_No.TabIndex = 14
        Me.txtENG_ASM_No.Text = "[]"
        '
        'txtLotNo
        '
        Me.txtLotNo.AutoSize = True
        Me.txtLotNo.Location = New System.Drawing.Point(136, 59)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.Size = New System.Drawing.Size(13, 13)
        Me.txtLotNo.TabIndex = 13
        Me.txtLotNo.Text = "[]"
        '
        'txtModelCode
        '
        Me.txtModelCode.AutoSize = True
        Me.txtModelCode.Location = New System.Drawing.Point(136, 39)
        Me.txtModelCode.Name = "txtModelCode"
        Me.txtModelCode.Size = New System.Drawing.Size(13, 13)
        Me.txtModelCode.TabIndex = 12
        Me.txtModelCode.Text = "[]"
        '
        'txtEngineNo
        '
        Me.txtEngineNo.AutoSize = True
        Me.txtEngineNo.Location = New System.Drawing.Point(136, 19)
        Me.txtEngineNo.Name = "txtEngineNo"
        Me.txtEngineNo.Size = New System.Drawing.Size(13, 13)
        Me.txtEngineNo.TabIndex = 11
        Me.txtEngineNo.Text = "[]"
        '
        'CtrlPivotGrid1
        '
        Me.CtrlPivotGrid1.AllowUserToAddRows = False
        Me.CtrlPivotGrid1.AllowUserToDeleteRows = False
        Me.CtrlPivotGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CtrlPivotGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CtrlPivotGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CtrlPivotGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CtrlPivotGrid1.GroupedDuplicateCells = False
        Me.CtrlPivotGrid1.HideDuplicateColumns = 0
        Me.CtrlPivotGrid1.Location = New System.Drawing.Point(223, 0)
        Me.CtrlPivotGrid1.MultiSelect = False
        Me.CtrlPivotGrid1.Name = "CtrlPivotGrid1"
        Me.CtrlPivotGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.CtrlPivotGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.CtrlPivotGrid1.Size = New System.Drawing.Size(544, 661)
        Me.CtrlPivotGrid1.TabIndex = 1
        '
        'frmSerialNo_PartNo_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 661)
        Me.Controls.Add(Me.txtProductionDate)
        Me.Controls.Add(Me.txtENG_ASM_No)
        Me.Controls.Add(Me.txtLotNo)
        Me.Controls.Add(Me.txtModelCode)
        Me.Controls.Add(Me.txtEngineNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CtrlPivotGrid1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "frmSerialNo_PartNo_Edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETAILS DATA EDIT 5C"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_DATA_MIXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrlPivotGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataSet1 As pdt_es01_client.DataSet1
    Friend WithEvents TableAdapterManager As pdt_es01_client.DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TRACE_DATA_MIXBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TRACE_DATA_MIXTableAdapter As pdt_es01_client.DataSet1TableAdapters.TRACE_DATA_MIXTableAdapter
    Friend WithEvents CtrlPivotGrid1 As pdt_es01_client.ctrlPivotGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProductionDate As System.Windows.Forms.Label
    Friend WithEvents txtENG_ASM_No As System.Windows.Forms.Label
    Friend WithEvents txtLotNo As System.Windows.Forms.Label
    Friend WithEvents txtModelCode As System.Windows.Forms.Label
    Friend WithEvents txtEngineNo As System.Windows.Forms.Label

End Class
