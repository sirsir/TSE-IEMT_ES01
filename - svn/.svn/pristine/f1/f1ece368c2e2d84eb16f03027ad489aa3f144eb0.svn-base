Public Class frmSerialNo_PartNo_Show


    Private m_spsTRACE_COLUMNS_ID As Integer
    Private m_spsSERIAL_NO As String

    Public Property pp_spsTRACE_COLUMNS_ID As Integer
        Get
            Return m_spsTRACE_COLUMNS_ID
        End Get
        Set(value As Integer)
            m_spsTRACE_COLUMNS_ID = value
        End Set
    End Property

    Public Property pp_spsSERIAL_NO As String
        Get
            Return m_spsSERIAL_NO
        End Get
        Set(value As String)
            m_spsSERIAL_NO = value
        End Set
    End Property

    Private m_taSerialNoView As DataSet1TableAdapters.SERIAL_NO_PART_NO_SHOWTableAdapter


    Private Sub frmSerialNo_PartNo_Show_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeControls()

        'Me.Text = "RESULT FROM PRODUCTION DATE + PART Search"

        Dim hCtrls As New Hashtable
        'hCtrls("ButtonHISTORY") = 0.1
        hCtrls("ButtonMAINMENU") = 0.9
        hCtrls("ButtonHISTORY") = 0.5
        hCtrls("ButtonPRINT") = 0.7

        ShowOnlyControls(hCtrls)


        '-------- Initialize table

        'm_dtWorkingString = Nothing
        'm_dtWorkingInteger = Nothing
        'm_dtWorkingDatetime = Nothing
        m_dtTraceString = Nothing
        m_dtTraceFloat = Nothing
        m_dtTraceDatetime = Nothing
        m_dtSettingColumns = Nothing

        'MsgBox(modGlobalVariables.searchBy)

        m_dtEngineList = m_taSerialNoView.GetDataMaxRevBySerialNoAndTraceId(pp_spsSERIAL_NO, pp_spsTRACE_COLUMNS_ID)



        'm_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(11)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(11)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(11)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(11)
        'Dim strHiddenColNames() As String = {"ENGINE_ID"}
        strHiddenColNames = {"REV_NO" _
                            , "PART_NAME" _
                            , "SERIAL_NO" _
                            , "LINE_ON_TIME" _
                            , "LINE_OFF_TIME" _
                            , "ENGINE_NO" _
                            , "MODEL_LOT" _
                            , "UNIT_NO" _
                            , "ENGINE_ASM_NO"
                            }

        Try
            'LoadData(m_dtEngineList _
            '                               , m_dtWorkingString _
            '                               , m_dtWorkingInteger _
            '                               , m_dtWorkingDatetime _
            '                               , m_dtSettingColumns _
            '                               , {"ENGINE_ID", "REV_NO"} _
            '                               , "WORKING_COLUMNS_ID" _
            '                               , {"ENGINE_ID", "REV_NO"} _
            '                               , "DATA" _
            '                               , strHiddenColNames)


            LoadData(m_dtEngineList _
                                           , m_dtTraceString _
                                           , m_dtTraceFloat _
                                           , m_dtTraceDatetime _
                                           , m_dtSettingColumns _
                                           , {"ENGINE_ID", "REV_NO"} _
                                           , "WORKING_COLUMNS_ID" _
                                           , {"ENGINE_ID", "REV_NO"} _
                                           , "DATA" _
                                           , strHiddenColNames)



        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Protected Overrides Sub InitializeVariables()
        ' Add any initialization after the InitializeComponent() call.
        'If modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST Then
        '    m_dtEngineList = New DataSet1.ENGINE_LISTDataTable
        'End If
        m_dtEngineList = New DataSet1.SERIAL_NO_PART_NO_SHOWDataTable
        'm_dtWorkingString = New DataSet1.WORKING_DATA_STRDataTable
        'm_dtWorkingInteger = New DataSet1.WORKING_DATA_INTDataTable
        'm_dtWorkingDatetime = New DataSet1.WORKING_DATA_DATETIMEDataTable
        m_dtTraceString = New DataSet1.TRACE_DATA_STRDataTable
        'm_dtTraceInteger = New DataSet1.TRACE_DATA_INTDataTable
        m_dtTraceFloat = New DataSet1.TRACE_DATA_FLOATDataTable
        m_dtTraceDatetime = New DataSet1.TRACE_DATA_DATETIMEDataTable
        m_dtSettingColumns = New DataSet1.V_SETTING_COLUMNSDataTable
        'm_objPivotGrid = New ctrlPivotGrid
        'If modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST Then
        '    m_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter

        '    'm_taEngineList = DirectCast(New DataSet1TableAdapters.ENGINE_LISTTableAdapter, DataSet1TableAdapters.ENGINE_LISTTableAdapter)
        '    'Dim m_taEngineList = DirectCast(New DataSet1TableAdapters.ENGINE_LISTTableAdapter, DataSet1TableAdapters.ENGINE_LISTTableAdapter)
        '    'm_taEngineList.getdata
        'End If
        m_taSerialNoView = New DataSet1TableAdapters.SERIAL_NO_PART_NO_SHOWTableAdapter
        'm_taWorkingString = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
        'm_taWorkingInteger = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
        'm_taWorkingDatetime = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
        m_taTraceString = New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
        m_taTraceFloat = New DataSet1TableAdapters.TRACE_DATA_FLOATTableAdapter
        m_taTraceDatetime = New DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
        m_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter
    End Sub

    Protected Overrides Sub ButtonHISTORY_Click(sender As Object, e As EventArgs)
        Dim inEngineId As Integer
        Dim frmShow As frmSerialNo_PartNo_History
        'Try/Catch exception in every event, not in every function
        Try
            frmShow = New frmSerialNo_PartNo_History
            If CtrlPivotGrid1.SelectedRows.Count = 1 Then
                inEngineId = CtrlPivotGrid1.SelectedRows(0).Cells("ENGINE_ID").Value
                frmShow.pp_sphENGINE_ID = inEngineId
            End If
            If frmShow.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Me.Close()
            End If

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    'Protected Overrides Sub ButtonMAINMENU_Click(sender As Object, e As EventArgs)

    '    Try
    '        Me.DialogResult = Windows.Forms.DialogResult.Abort
    '        Me.Close()
    '    Catch ex As Exception
    '        modLogger.HandleException(ex, True)
    '    End Try
    'End Sub

End Class