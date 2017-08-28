﻿Public Class frmSerialNo_PartNo_History

    Public Property pp_sphENGINE_ID As Integer

    Private m_taSERIAL_NO_PART_NO_HISTORY As DataSet1TableAdapters.SERIAL_NO_PART_NO_HISTORYTableAdapter


    Private Sub frmSerialNo_PartNo_History_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            InitializeControls()

            Me.Text = "HISTORY DATA"

            Dim hCtrls As New Hashtable
            'hCtrls("ButtonHISTORY") = 0.1
            hCtrls("ButtonBACK") = 0.3
            hCtrls("ButtonEDIT") = 0.5
            hCtrls("ButtonPRINT") = 0.7
            hCtrls("ButtonMAINMENU") = 0.9

            ShowOnlyControls(hCtrls)


            '-------- Initialize table

            'm_dtWorkingString = Nothing
            'm_dtWorkingInteger = Nothing
            'm_dtWorkingDatetime = Nothing
            'm_dtSettingColumns = Nothing

            ''MsgBox(modGlobalVariables.searchBy)

            'm_dtEngineList = m_taSERIAL_NO_PART_NO_HISTORY.GetDataEngineId(pp_sphENGINE_ID)
            'm_dtTraceString = m_taTraceString.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
            'm_dtTraceInteger = m_taTraceInteger.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
            'm_dtTraceDatetime = m_taTraceDatetime.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
            'm_dtSettingColumns = m_taSettingColumns.GetTraceColumns()


            ''m_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(11)
            ''m_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(11)
            ''m_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(11)
            ''m_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(11)
            ''Dim strHiddenColNames() As String = {"ENGINE_ID"}
            'strHiddenColNames = {"REV_NO" _
            '                    , "REVISE_DATE" _
            '                    , "ENGINE_NO" _
            '                    , "MODEL_CODE" _
            '                    , "LOT_NO" _
            '                    , "UNIT_NO" _
            '                    , "ENGINE_ASM_NO"
            '                    }

            ''LoadData(m_dtEngineList _
            ''                               , m_dtWorkingString _
            ''                               , m_dtWorkingInteger _
            ''                               , m_dtWorkingDatetime _
            ''                               , m_dtSettingColumns _
            ''                               , {"ENGINE_ID", "REV_NO"} _
            ''                               , "WORKING_COLUMNS_ID" _
            ''                               , {"ENGINE_ID", "REV_NO"} _
            ''                               , "DATA" _
            ''                               , strHiddenColNames)


            'LoadData(m_dtEngineList _
            '                               , m_dtTraceString _
            '                               , m_dtTraceInteger _
            '                               , m_dtTraceDatetime _
            '                               , m_dtSettingColumns _
            '                               , {"ENGINE_ID", "REV_NO"} _
            '                               , "TRACE_COLUMNS_ID" _
            '                               , {"ENGINE_ID", "REV_NO"} _
            '                               , "DATA" _
            '                               , strHiddenColNames)
            LoadDataFromDB()



        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Protected Overrides Sub InitializeVariables()
        ' Add any initialization after the InitializeComponent() call.
        'If modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST Then
        '    m_dtEngineList = New DataSet1.ENGINE_LISTDataTable
        'End If
        m_dtEngineList = New DataSet1.SERIAL_NO_PART_NO_HISTORYDataTable
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
        m_taSERIAL_NO_PART_NO_HISTORY = New DataSet1TableAdapters.SERIAL_NO_PART_NO_HISTORYTableAdapter
        'm_taWorkingString = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
        'm_taWorkingInteger = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
        'm_taWorkingDatetime = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
        m_taTraceString = New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
        'm_taTraceInteger = New DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
        m_taTraceFloat = New DataSet1TableAdapters.TRACE_DATA_FLOATTableAdapter
        m_taTraceDatetime = New DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
        m_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter
    End Sub

    Protected Overrides Sub ButtonEDIT_Click(sender As Object, e As EventArgs)
        Dim frmEdit As frmSerialNo_PartNo_Edit
        Try
            If CtrlPivotGrid1.RowCount = 0 Then
                MsgBox("Cannot find the data.")
                Exit Sub
            ElseIf CtrlPivotGrid1.RowCount = CtrlPivotGrid1.SelectedRows(0).Cells("MAX_REV").Value + 1 Then
                MsgBox("Already Max allowed revision, cannot edit")
                Exit Sub
            End If

            frmEdit = New frmSerialNo_PartNo_Edit
            Dim intMAxREv As Integer = -1

            frmEdit.pp_speENGINE_ID = pp_sphENGINE_ID
            frmEdit.pp_speENGINE_No = CtrlPivotGrid1.SelectedRows(0).Cells("ENGINE_NO").Value
            frmEdit.pp_speModelCode = CtrlPivotGrid1.SelectedRows(0).Cells("MODEL_CODE").Value
            frmEdit.pp_speLotNo = CtrlPivotGrid1.SelectedRows(0).Cells("LOT_NO").Value
            frmEdit.pp_speENG_ASM_No = CtrlPivotGrid1.SelectedRows(0).Cells("ENGINE_ASM_NO").Value
            frmEdit.pp_speProductionDate = CtrlPivotGrid1.SelectedRows(0).Cells("LINE_ON_TIME").Value
            'frmEdit.TopMost = True
            If frmEdit.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.LoadDataFromDB()
            End If

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Protected Overrides Sub ButtonBACK_Click(sender As Object, e As EventArgs)
        Try
            Me.Close()
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

    Private Sub LoadDataFromDB()

        m_dtWorkingString = Nothing
        'm_dtWorkingInteger = Nothing
        m_dtWorkingFloat = Nothing
        m_dtWorkingDatetime = Nothing
        m_dtSettingColumns = Nothing

        'MsgBox(modGlobalVariables.searchBy)

        m_dtEngineList = m_taSERIAL_NO_PART_NO_HISTORY.GetDataEngineId(pp_sphENGINE_ID)
        m_dtTraceString = m_taTraceString.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
        'm_dtTraceInteger = m_taTraceInteger.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
        m_dtTraceFloat = m_taTraceFloat.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
        m_dtTraceDatetime = m_taTraceDatetime.GetDataByENGINE_ID_FOR_PART_AND_SERIAL_NO(pp_sphENGINE_ID)
        m_dtSettingColumns = m_taSettingColumns.GetTraceColumns()


        'm_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(11)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(11)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(11)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(11)
        'Dim strHiddenColNames() As String = {"ENGINE_ID"}
        strHiddenColNames = {"REV_NO" _
                            , "REVISE_DATE" _
                            , "ENGINE_NO" _
                            , "MODEL_CODE" _
                            , "LOT_NO" _
                            , "UNIT_NO" _
                            , "ENGINE_ASM_NO"
                            }

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
                                       , "TRACE_COLUMNS_ID" _
                                       , {"ENGINE_ID", "REV_NO"} _
                                       , "DATA" _
                                       , strHiddenColNames)
    End Sub

End Class