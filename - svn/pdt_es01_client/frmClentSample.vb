Public Class frmClentSample
    'Private m_dtEngineView As DataSet1.V_WORKING_DATA_STATICDataTable
    'Private m_dtWorkingString As DataSet1.WORKING_DATA_STRDataTable
    'Private m_dtWorkingInteger As DataSet1.WORKING_DATA_INTDataTable
    'Private m_dtWorkingDatetime As DataSet1.WORKING_DATA_DATETIMEDataTable
    'Private m_dtSettingColumns As DataSet1.V_SETTING_COLUMNSDataTable
    Private m_ds As DataSet1
    Private m_tam As DataSet1TableAdapters.TableAdapterManager

    Private m_taEngineView As DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter
    Private m_taWorkingString As DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
    Private m_taWorkingInteger As DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
    Private m_taWorkingDatetime As DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
    Private m_taSettingColumns As DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadData()
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Public Sub LoadData()
        'm_taEngineView.FillAllRevEngIdAndWorkingTypeId(m_dtEngineView, 6, 2)
        'm_dtWorkingString = Nothing
        'm_dtWorkingInteger = Nothing
        'm_dtWorkingDatetime = Nothing
        'm_taSettingColumns = Nothing

        'm_dtEngineView = m_taEngineView.GetAllRevByEngIdAndWorkingTypeId(38, 4)
        'm_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(4)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(4)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(4)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(4)

        m_taEngineView.FillAllRevEngIdAndWorkingTypeId(m_ds.V_WORKING_DATA_STATIC, 38, 4)
        m_taWorkingString.FillByWorkingTypeId(m_ds.WORKING_DATA_STR, 4)
        m_taWorkingInteger.FillByWorkingTypeId(m_ds.WORKING_DATA_INT, 4)
        m_taWorkingDatetime.FillByWorkingTypeId(m_ds.WORKING_DATA_DATETIME, 4)
        m_taSettingColumns.FillWorkingColumns(m_ds.V_SETTING_COLUMNS, 4)
        'Dim astrDisplayColNames() As String = {"LINE_ON_TIME" _
        '                                      , "ENGINE_NO" _
        '                                      , "MODEL_CODE" _
        '                                      , "LOT_NO"}
        Dim astrDisplayColNames() As String = {}

        CtrlPivotGrid1.SetDataSource(m_ds.V_WORKING_DATA_STATIC _
                                           , m_ds.WORKING_DATA_STR _
                                           , m_ds.WORKING_DATA_INT _
                                           , m_ds.WORKING_DATA_DATETIME _
                                           , m_ds.V_SETTING_COLUMNS _
                                           , {"ENGINE_ID", "REV_NO"} _
                                           , "WORKING_COLUMNS_ID" _
                                           , {"ENGINE_ID", "REV_NO"} _
                                           , "DATA" _
                                           , astrDisplayColNames _
                                           , False)

        'CtrlPivotGrid1.SetDataSource(m_dtEngineView _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , Nothing _
        '                                   , False)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'm_dtEngineView = m_ds.V_WORKING_DATA_STATIC
        'm_dtWorkingString = m_ds.WORKING_DATA_STR
        'm_dtWorkingInteger = m_ds.WORKING_DATA_INT
        'm_dtWorkingDatetime = m_ds.WORKING_DATA_DATETIME
        'm_dtSettingColumns = m_ds.V_SETTING_COLUMNS
        m_ds = New DataSet1
        m_tam = New DataSet1TableAdapters.TableAdapterManager

        ' ''m_tam.WORKING_DATA_STRTableAdapter = m_taWorkingString
        ' ''m_tam.WORKING_DATA_INTTableAdapter = m_taWorkingInteger
        ' ''m_tam.WORKING_DATA_DATETIMETableAdapter = m_taWorkingDatetime

        ' ''m_tam.UpdateAll(m_ds)
        ' ''m_taWorkingString.Fill(m_ds.WORKING_DATA_STR)
        ' ''With m_ds
        ' ''    .WORKING_DATA_STR(0).Delete()
        ' ''    .WORKING_DATA_STR(1).Delete()
        ' ''    .WORKING_DATA_STR(2).Delete()
        ' ''    .WORKING_DATA_STR(0).Delete()
        ' ''    .WORKING_DATA_STR(0).Delete()
        ' ''    .WORKING_DATA_STR(0).Delete()
        ' ''    .ENGINE_LIST.FindByID(38).Delete()
        ' ''End With
        'm_objPivotGrid = New ctrlPivotGrid
        m_taEngineView = New DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter
        m_taWorkingString = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
        m_taWorkingInteger = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
        m_taWorkingDatetime = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
        m_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Try/Catch exception in every event, not in every function
        Try
            LoadData()
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim i As Integer = 0
        SaveFileDialog1.FileName = Now.ToString("yyyyMMddHHmmss") & ".xlsx"
        Dim objExcel As New clsGridToExcel
        Try
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                objExcel.WriteDataToExcel(Me.CtrlPivotGrid1 _
                                          , Me.Name & ".xlsx" _
                                          , SaveFileDialog1.FileName)
            End If
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim intColumnId As Integer
            Dim intEngineId As Integer
            Dim intRevNo As Integer
            Dim drSettingColumns As DataSet1.V_SETTING_COLUMNSRow

            If CtrlPivotGrid1.RowCount <= 0 Then
                MsgBox("No data to update", MsgBoxStyle.Exclamation)
                Return
            End If

            If CtrlPivotGrid1.SelectedRows.Count = 1 Then
                intEngineId = CtrlPivotGrid1.Item("ENGINE_ID", 0).Value
                intRevNo = CtrlPivotGrid1.Item("REV_NO", 0).Value
            End If

            For i As Integer = 0 To CtrlPivotGrid1.ColumnCount - 1
                If CtrlPivotGrid1.Columns(i).Visible Then
                    If CtrlPivotGrid1.Columns(i).Name Like "ID*" _
                        AndAlso CtrlPivotGrid1.Columns(i).Name <> "ID" Then
                        intColumnId = CInt(CtrlPivotGrid1.Columns(i).Name.Substring(2))
                        drSettingColumns = m_ds.V_SETTING_COLUMNS.FindByID(intColumnId)

                        Select Case drSettingColumns.DATA_TYPE
                            Case DataType.nString
                                Dim dr As DataSet1.WORKING_DATA_STRRow
                                dr = m_ds.WORKING_DATA_STR.NewWORKING_DATA_STRRow()
                                dr.ENGINE_ID = intEngineId
                                dr.WORKING_COLUMNS_ID = intColumnId
                                dr.REV_NO = intRevNo + 1
                                dr.DATA = CtrlPivotGrid1.Item(i, 0).Value
                                m_ds.WORKING_DATA_STR.AddWORKING_DATA_STRRow(dr)
                            Case DataType.nInteger
                                Dim dr As DataSet1.WORKING_DATA_INTRow
                                dr = m_ds.WORKING_DATA_INT.NewWORKING_DATA_INTRow
                                dr.ENGINE_ID = intEngineId
                                dr.WORKING_COLUMNS_ID = intColumnId
                                dr.REV_NO = intRevNo + 1
                                dr.DATA = CtrlPivotGrid1.Item(i, 0).Value
                                m_ds.WORKING_DATA_INT.AddWORKING_DATA_INTRow(dr)
                            Case DataType.nDateTime
                                Dim dr As DataSet1.WORKING_DATA_DATETIMERow
                                dr = m_ds.WORKING_DATA_DATETIME.NewWORKING_DATA_DATETIMERow
                                dr.ENGINE_ID = intEngineId
                                dr.WORKING_COLUMNS_ID = intColumnId
                                dr.REV_NO = intRevNo + 1
                                dr.DATA = CtrlPivotGrid1.Item(i, 0).Value
                                m_ds.WORKING_DATA_DATETIME.AddWORKING_DATA_DATETIMERow(dr)

                        End Select
                    End If
                End If
            Next

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub
End Class