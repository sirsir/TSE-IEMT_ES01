﻿Public Class frmSerialNo_PartNo_Edit
    Private m_dtEngineView As DataSet1.TRACE_DATA_MIXDataTable
    'Private m_dtEngineView As DataSet1.ENGINE_LISTDataTable
    Private m_dtTraceString As DataSet1.TRACE_DATA_STRDataTable
    'Private m_dtTraceInteger As DataSet1.TRACE_DATA_INTDataTable
    Private m_dtTraceFloat As DataSet1.TRACE_DATA_FLOATDataTable
    Private m_dtTraceDatetime As DataSet1.TRACE_DATA_DATETIMEDataTable
    Private m_dtSettingColumns As DataSet1.V_SETTING_COLUMNSDataTable

    Private m_taEngineView As DataSet1TableAdapters.TRACE_DATA_MIXTableAdapter
    Private m_taEngineList As DataSet1TableAdapters.ENGINE_LISTTableAdapter
    Private m_taTraceString As DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
    'Private m_taTraceInteger As DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
    Private m_taTraceFloat As DataSet1TableAdapters.TRACE_DATA_FLOATTableAdapter
    Private m_taTraceDatetime As DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
    Private m_taSettingColumns As DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter

    Private check_table As String
    Private intRev As Integer = -1

    Public Property pp_speENGINE_ID As Integer
    Public Property pp_speENGINE_No As String
    Public Property pp_speModelCode As String
    Public Property pp_speLotNo As String
    Public Property pp_speENG_ASM_No As String
    Public Property pp_speProductionDate As Date

    'Friend WithEvents m_objPivotGrid As ctrlPivotGrid

    Private Sub frmSerialNo_PartNo_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'DataSet1.TRACE_COLUMNS' table. You can move, or remove it, as needed.
        'Me.TRACE_COLUMNSTableAdapter.Fill(Me.DataSet1.TRACE_COLUMNS)
        Try
            txtEngineNo.Text = "[ " & pp_speENGINE_No & " ]"
            txtModelCode.Text = "[ " & pp_speModelCode & " ]"
            txtLotNo.Text = "[ " & pp_speLotNo & " ]"
            txtENG_ASM_No.Text = "[ " & pp_speENG_ASM_No & " ]"
            txtProductionDate.Text = "[ " & pp_speProductionDate.ToString("yyyyMMdd") & " ]"

            LoadData()
            'CtrlPivotGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            CtrlPivotGrid1.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            CtrlPivotGrid1.Columns(5).FillWeight = 20
            CtrlPivotGrid1.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable

            CtrlPivotGrid1.Columns(5).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
            'CtrlPivotGrid1.Columns(5).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
            CtrlPivotGrid1.Columns(5).DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 255, 192)
            CtrlPivotGrid1.Columns(5).DefaultCellStyle.SelectionForeColor = Color.Black

            CtrlPivotGrid1.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            CtrlPivotGrid1.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
            CtrlPivotGrid1.Columns(6).FillWeight = 50

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Public Sub LoadData()


        Dim taMIX As New DataSet1TableAdapters.TRACE_DATA_MIXTableAdapter
        taMIX.ClearBeforeFill = False

        Me.DataSet1.TRACE_DATA_MIX.Clear()

        m_taEngineList.FillByENGINE_ID(Me.DataSet1.ENGINE_LIST, pp_speENGINE_ID)
        taMIX.FillStrByENGINE_ID(Me.DataSet1.TRACE_DATA_MIX, pp_speENGINE_ID)
        taMIX.FillIntByENGINE_ID(Me.DataSet1.TRACE_DATA_MIX, pp_speENGINE_ID)
        taMIX.FillDateByENGINE_ID(Me.DataSet1.TRACE_DATA_MIX, pp_speENGINE_ID)

        'For Each dgvr As DataGridViewRow In Me.TRACE_DATA_MIXDataGridView.Rows
        '    Dim drv As DataRowView = dgvr.DataBoundItem
        '    If drv Is Nothing Then Continue For

        '    Dim dr As DataRow = drv.Row
        '    If dr Is Nothing Then Continue For

        '    Select Case dr.Item("SRC")
        '        Case "STR"
        '        Case "INT"
        '            dgvr.Cells(3).Style.Alignment = DataGridViewContentAlignment.MiddleRight
        '            dgvr.Cells(3).Style.Format = "N0"
        '        Case "DT"
        '            dgvr.Cells(3).Style.Format = "yyyy/MM/dd"
        '    End Select
        'Next dgvr



        'm_taEngineView.FillAllRevEngIdAndWorkingTypeId(m_dtEngineView, 6, 2)
        m_dtTraceString = Nothing
        m_dtTraceFloat = Nothing
        m_dtTraceDatetime = Nothing
        m_dtSettingColumns = Nothing
        'm_dtEngineView = m_taEngineView.GetAllRevByEngIdAndWorkingTypeId(38, 11)
        'm_taEngineView.FillByEngineNo(m_dtEngineView, 11)
        'MsgBox(pp_spsTRACE_COLUMNS_ID.ToString)
        m_taEngineView.ClearBeforeFill = False
        m_dtEngineView.Clear()
        'm_dtEngineView = m_taEngineView.GetDataDateByENGINE_ID(pp_speENGINE_ID)
        'm_dtEngineView = m_taEngineView.GetDataStrByENGINE_ID(pp_speENGINE_ID)
        'm_dtEngineView = m_taEngineView.GetDataIntByENGINE_ID(pp_speENGINE_ID)
        m_taEngineView.FillDateByENGINE_ID(m_dtEngineView, pp_speENGINE_ID)
        m_taEngineView.FillIntByENGINE_ID(m_dtEngineView, pp_speENGINE_ID)
        m_taEngineView.FillStrByENGINE_ID(m_dtEngineView, pp_speENGINE_ID)
        'm_dtTraceString = m_taTraceString.GetDataBySerialNoAndTraceId(pp_spsSERIAL_NO, pp_spsTRACE_COLUMNS_ID)
        'm_dtTraceInteger = m_taTraceInteger.GetDataBySerialNoAndTraceId(-1, pp_spsTRACE_COLUMNS_ID)
        'm_dtTraceDatetime = m_taTraceDatetime.GetDataBySerialNoAndTraceId(DATE_NULL, pp_spsTRACE_COLUMNS_ID)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(pp_spsTRACE_COLUMNS_ID)
        'MsgBox("", )

        '"ENGINE_ID" _
        'Dim strHiddenColNames() As String = {}
        'Dim strHiddenColNames() As String = {"ENGINE_ID"}

        Dim astrDisplayColNames() As String = {"PART_NAME" _
                                              , "DATA"
                                              }
        'Dim astrDisplayColNames() As String = {}

        ' , {"ENGINE_ID", "REV_NO"} _
        'DataGridView.

        Dim dt As DataTable = m_dtEngineView


        Dim intDtRow As Integer = dt.Rows.Count
        For j As Integer = 0 To intDtRow - 1
            Dim dr_ As DataRow = dt.NewRow
            For i As Integer = 0 To dt.Columns.Count - 1
                If dt.Columns(i).ColumnName = "REV_NO" Then
                    dr_("REV_NO") = dt(j)("REV_NO") + 1

                    If dr_("REV_NO") > intRev Then
                        intRev = dr_("REV_NO")
                    End If
                Else
                    dr_.Item(i) = dt(j).Item(i)
                    check_table = dt(j)("SRC")
                End If
            Next i
            'dr_.REV_NO = dt.Item(i).rev_no + 1
            dt.Rows.Add(dr_)
        Next j

        CtrlPivotGrid1.DataSource = TRACE_DATA_MIXBindingSource
        TRACE_DATA_MIXBindingSource.DataSource = m_dtEngineView
        TRACE_DATA_MIXBindingSource.Filter = "REV_NO = " & intRev
        TRACE_DATA_MIXBindingSource.Sort = "TRACE_COLUMNS_ID"
        CtrlPivotGrid1.SetDisplayColumn(astrDisplayColNames)
        'CtrlPivotGrid1.SetDataSource(m_dtEngineView _
        '                                   , m_dtTraceString _
        '                                   , m_dtTraceInteger _
        '                                   , m_dtTraceDatetime _
        '                                   , m_dtSettingColumns _
        '                                   , {"ENGINE_ID", "REV_NO"} _
        '                                   , "WORKING_COLUMNS_ID" _
        '                                   , {"ENGINE_ID", "REV_NO"} _
        '                                   , "DATA" _
        '                                   , astrDisplayColNames, False)


    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        InitializeControls()

        ' Add any initialization after the InitializeComponent() call.
        m_dtEngineView = New DataSet1.TRACE_DATA_MIXDataTable
        'm_dtEngineView = New DataSet1.ENGINE_LISTDataTable
        m_dtTraceString = New DataSet1.TRACE_DATA_STRDataTable
        'm_dtTraceInteger = New DataSet1.TRACE_DATA_INTDataTable
        m_dtTraceFloat = New DataSet1.TRACE_DATA_FLOATDataTable
        m_dtTraceDatetime = New DataSet1.TRACE_DATA_DATETIMEDataTable
        m_dtSettingColumns = New DataSet1.V_SETTING_COLUMNSDataTable
        'm_objPivotGrid = New ctrlPivotGrid
        m_taEngineView = New DataSet1TableAdapters.TRACE_DATA_MIXTableAdapter
        m_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter
        m_taTraceString = New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
        'm_taTraceInteger = New DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
        m_taTraceFloat = New DataSet1TableAdapters.TRACE_DATA_FLOATTableAdapter
        m_taTraceDatetime = New DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
        m_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter

    End Sub

    Protected Sub InitializeControls()
        'Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        ''SaveFileDialog1
        ''
        'Me.SaveFileDialog1.DefaultExt = "xlsx"
        'Me.SaveFileDialog1.Filter = "Excel Workbook|*.xlsx"

        'Me.Show()
        'Me.WindowState = FormWindowState.Maximized
        'Me.Height = 
        'Dim intH As Integer = Screen.PrimaryScreen.Bounds.Height
        'Dim intW As Integer = Screen.PrimaryScreen.Bounds.Width

        Me.Top = 0
        Me.Left = 0

        Dim intH = Screen.PrimaryScreen.WorkingArea.Height
        Dim intW = Screen.PrimaryScreen.WorkingArea.Width

        'If Me.Height > intH Then
        Me.Height = intH
        Me.Width = intW
        'End If

        'Me.Height = 300

        Me.Font = New Font(Me.Font.FontFamily, 12, Me.Font.Style)

        Me.BackColor = Color.FromArgb(0, 220, 220)


        'With Me.Panel1
        '    .AutoSize = False
        '    .BorderStyle = BorderStyle.FixedSingle

        '    '.Size = New System.Drawing.Size(0, 0)
        '    .Height = Me.Height * 0.15
        '    .Width = Me.Width
        '    'minux height
        '    .Top = Me.Height - .Height - Me.Height * 0.05
        '    .Left = 0
        'End With



        Dim cControl As Control
        For Each cControl In Me.Controls
            'MsgBox(cControl.Name)
            If (TypeOf cControl Is TextBox) Then
                'cControl.Text = "abc"
                'cControl.Font = New Font(cControl.Font.FontFamily, 22, cControl.Font.Style)

                'cControl.ForeColor = Color.FromArgb(255, 255, 255)

            ElseIf (TypeOf cControl Is Button) Then
                With cControl
                    'cControl.AutoSize = True
                    '.Size = New System.Drawing.Size(0, 0)

                    '.AutoSize = True
                    '.Refresh()

                    '.Size = New System.Drawing.Size(.Parent.Width / 8, .Parent.Height * 0.6)

                    '.Margin = New Padding(0, 0, 0, 0)
                    '.Top = (.Parent.Height) / 2 - .Height / 2
                    '.Top = (.Parent.Height / 2) - (.Height / 2)

                End With

                cControl.Font = New Font(Me.Font.FontFamily, 12, Me.Font.Style)

                cControl.BackColor = Color.FromArgb(0, 100, 255)
                cControl.ForeColor = Color.FromArgb(255, 255, 255)




            End If


        Next cControl
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Select MsgBox("Confirm to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes, MsgBoxResult.Ok
                    If (intRev >= 0) AndAlso (intRev <= 4) Then
                        For i = 0 To CtrlPivotGrid1.RowCount - 1
                            Select Case check_table
                                Case "STR"
                                    Dim drTraceData As DataSet1.TRACE_DATA_STRRow = DataSet1.TRACE_DATA_STR.NewTRACE_DATA_STRRow
                                    Dim taTraceData As New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
                                    drTraceData.ENGINE_ID = CtrlPivotGrid1.Item("ENGINE_ID", i).Value
                                    drTraceData.TRACE_COLUMNS_ID = CtrlPivotGrid1.Item("TRACE_COLUMNS_ID", i).Value
                                    drTraceData.REV_NO = CtrlPivotGrid1.Item("REV_NO", i).Value
                                    drTraceData.DATA = CtrlPivotGrid1.Item("DATA", i).Value
                                    drTraceData.REVISE_DATE = CtrlPivotGrid1.Item("REVISE_DATE", i).Value
                                    DataSet1.TRACE_DATA_STR.AddTRACE_DATA_STRRow(drTraceData)
                                    taTraceData.Update(DataSet1.TRACE_DATA_STR)
                                Case "INT"
                                    'Dim drTraceData As DataSet1.TRACE_DATA_INTRow = DataSet1.TRACE_DATA_INT.NewTRACE_DATA_INTRow
                                    'Dim taTraceData As New DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
                                    Dim drTraceData As DataSet1.TRACE_DATA_FLOATRow = DataSet1.TRACE_DATA_FLOAT.NewTRACE_DATA_FLOATRow
                                    Dim taTraceData As New DataSet1TableAdapters.TRACE_DATA_FLOATTableAdapter
                                    drTraceData.ENGINE_ID = CtrlPivotGrid1.Item("ENGINE_ID", i).Value
                                    drTraceData.TRACE_COLUMNS_ID = CtrlPivotGrid1.Item("TRACE_COLUMNS_ID", i).Value
                                    drTraceData.REV_NO = CtrlPivotGrid1.Item("REV_NO", i).Value
                                    drTraceData.DATA = CtrlPivotGrid1.Item("DATA", i).Value
                                    drTraceData.REVISE_DATE = CtrlPivotGrid1.Item("REVISE_DATE", i).Value
                                    'DataSet1.TRACE_DATA_INT.AddTRACE_DATA_INTRow(drTraceData)
                                    'taTraceData.Update(DataSet1.TRACE_DATA_INT)
                                    DataSet1.TRACE_DATA_FLOAT.AddTRACE_DATA_FLOATRow(drTraceData)
                                    taTraceData.Update(DataSet1.TRACE_DATA_FLOAT)
                                Case "DT"
                                    Dim drTraceData As DataSet1.TRACE_DATA_DATETIMERow = DataSet1.TRACE_DATA_DATETIME.NewTRACE_DATA_DATETIMERow
                                    Dim taTraceData As New DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
                                    drTraceData.ENGINE_ID = CtrlPivotGrid1.Item("ENGINE_ID", i).Value
                                    drTraceData.TRACE_COLUMNS_ID = CtrlPivotGrid1.Item("TRACE_COLUMNS_ID", i).Value
                                    drTraceData.REV_NO = CtrlPivotGrid1.Item("REV_NO", i).Value
                                    drTraceData.DATA = CtrlPivotGrid1.Item("DATA", i).Value
                                    drTraceData.REVISE_DATE = CtrlPivotGrid1.Item("REVISE_DATE", i).Value
                                    DataSet1.TRACE_DATA_DATETIME.AddTRACE_DATA_DATETIMERow(drTraceData)
                                    taTraceData.Update(DataSet1.TRACE_DATA_DATETIME)
                            End Select

                        Next i

                        MsgBox("Save Complete")
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MsgBox("Cannot Save The Data")
                    End If
                Case Else
                    ' Do nothing 
            End Select
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

End Class
