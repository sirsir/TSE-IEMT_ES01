﻿Public Class frmProductionData
    'Dim m_taEngineList As DataSet1TableAdapters.ENGINE_LISTTableAdapter



    Private Sub frmProductionData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "PRODUCTION DATA"

            InitializeControls()



            Dim hCtrls As New Hashtable
            hCtrls("ButtonDELETE") = 0.1
            hCtrls("ButtonMAINMENU") = 0.9
            hCtrls("ButtonPRINT") = 0.5
            hCtrls("ButtonCANCEL") = 0.7

            ShowOnlyControls(hCtrls)


            FillGrid()

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Protected Overrides Sub InitializeVariables()
        ' Add any initialization after the InitializeComponent() call.
        If modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST Then
            m_dtEngineList = New DataSet1.ENGINE_LISTDataTable
        End If

        m_dtWorkingString = New DataSet1.WORKING_DATA_STRDataTable
        'm_dtWorkingInteger = New DataSet1.WORKING_DATA_INTDataTable
        m_dtWorkingFloat = New DataSet1.WORKING_DATA_FLOATDataTable
        m_dtWorkingDatetime = New DataSet1.WORKING_DATA_DATETIMEDataTable
        m_dtSettingColumns = New DataSet1.V_SETTING_COLUMNSDataTable
        'm_objPivotGrid = New ctrlPivotGrid
        If modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST Then
            m_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter

            'm_taEngineList = DirectCast(New DataSet1TableAdapters.ENGINE_LISTTableAdapter, DataSet1TableAdapters.ENGINE_LISTTableAdapter)
            'Dim m_taEngineList = DirectCast(New DataSet1TableAdapters.ENGINE_LISTTableAdapter, DataSet1TableAdapters.ENGINE_LISTTableAdapter)
            'm_taEngineList.getdata
        End If

        m_taWorkingString = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
        'm_taWorkingInteger = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
        m_taWorkingFloat = New DataSet1TableAdapters.WORKING_DATA_FLOATTableAdapter
        m_taWorkingDatetime = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
        m_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter
    End Sub



    Protected Overrides Sub ButtonDELETE_Click(sender As Object, e As EventArgs)
        Try


            Dim selectedRowCount As Integer = CtrlPivotGrid1.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If selectedRowCount < 1 Then
                Exit Sub
            End If

            If modValidate.ValidationParamSet.CONFIRM_DELETE.MyMessageBox() <> DialogResult.Yes Then
                Exit Sub
            End If


            'modGlobalVariables.reset()

            'MsgBox(CtrlPivotGrid1.SelectedRows(0).Cells("ID").Value.ToString())

            'Dim selectedEngineId = CtrlPivotGrid1.SelectedRows(0).Cells("ID").Value.ToString()
            Dim selectedEngineId = CtrlPivotGrid1.SelectedRows(0).Cells("ID").Value
            Dim selectedEngineNo = CtrlPivotGrid1.SelectedRows(0).Cells("ENGINE_NO").Value

            'MsgBox(selectedEngineNo)

            Dim m_ds As DataSet1
            m_ds = New DataSet1()




            Dim m_tam As DataSet1TableAdapters.TableAdapterManager
            m_tam = New DataSet1TableAdapters.TableAdapterManager

            'm_tam.TRACE_DATA_STRTableAdapter = New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
            'm_tam.TRACE_DATA_INTTableAdapter = New DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
            'm_tam.TRACE_DATA_DATETIMETableAdapter = New DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
            'm_tam.WORKING_DATA_STRTableAdapter = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
            'm_tam.WORKING_DATA_INTTableAdapter = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
            'm_tam.WORKING_DATA_DATETIMETableAdapter = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
            m_tam.ENGINE_LISTTableAdapter = New DataSet1TableAdapters.ENGINE_LISTTableAdapter


            'm_ds.Tables.Clear()
            'm_ds.EnforceConstraints = False

            'm_tam.ENGINE_LISTTableAdapter.Fill(m_ds.Tables("ENGINE_LIST"))
            'm_tam.TRACE_DATA_STRTableAdapter.Fill(m_ds.Tables("TRACE_DATA_STR"))
            'm_tam.TRACE_DATA_INTTableAdapter.Fill(m_ds.Tables("TRACE_DATA_INT"))
            'm_tam.TRACE_DATA_DATETIMETableAdapter.Fill(m_ds.Tables("TRACE_DATA_DATETIME"))
            'm_tam.WORKING_DATA_STRTableAdapter.Fill(m_ds.Tables("WORKING_DATA_STR"))
            'm_tam.WORKING_DATA_INTTableAdapter.Fill(m_ds.Tables("WORKING_DATA_INT"))
            'm_tam.WORKING_DATA_DATETIMETableAdapter.Fill(m_ds.Tables("WORKING_DATA_DATETIME"))

            m_tam.ENGINE_LISTTableAdapter.FillByEngineNo(m_ds.ENGINE_LIST, selectedEngineNo)
            'm_tam.TRACE_DATA_STRTableAdapter.FillByENGINE_ID(m_ds.Tables("TRACE_DATA_STR"), selectedEngineId)
            'm_tam.TRACE_DATA_INTTableAdapter.FillByENGINE_ID(m_ds.Tables("TRACE_DATA_INT"), selectedEngineId)
            'm_tam.TRACE_DATA_DATETIMETableAdapter.FillByENGINE_ID(m_ds.Tables("TRACE_DATA_DATETIME"), selectedEngineId)
            'm_tam.WORKING_DATA_STRTableAdapter.FillByENGINE_ID(m_ds.Tables("WORKING_DATA_STR"), selectedEngineId)
            'm_tam.WORKING_DATA_INTTableAdapter.FillByENGINE_ID(m_ds.Tables("WORKING_DATA_INT"), selectedEngineId)
            'm_tam.WORKING_DATA_DATETIMETableAdapter.FillByENGINE_ID(m_ds.Tables("WORKING_DATA_DATETIME"),selectedEngineId)
            'm_tam.WORKING_DATA_STRTableAdapter.FillByENGINE_NO(m_ds.Tables("WORKING_DATA_STR"), selectedEngineNo)
            'm_tam.WORKING_DATA_INTTableAdapter.FillByENGINE_NO(m_ds.Tables("WORKING_DATA_INT"), selectedEngineNo)
            'm_tam.WORKING_DATA_DATETIMETableAdapter.FillByENGINE_NO(m_ds.Tables("WORKING_DATA_DATETIME"), selectedEngineNo)

            'm_tam.TRACE_DATA_STRTableAdapter.FillByENGINE_ID(m_ds.TRACE_DATA_STR, selectedEngineId)
            'm_tam.TRACE_DATA_INTTableAdapter.FillByENGINE_ID(m_ds.TRACE_DATA_INT, selectedEngineId)
            'm_tam.TRACE_DATA_DATETIMETableAdapter.FillByENGINE_ID(m_ds.TRACE_DATA_DATETIME, selectedEngineId)

            'm_tam.WORKING_DATA_STRTableAdapter.FillByENGINE_NO(m_ds.WORKING_DATA_STR, selectedEngineNo)
            'm_tam.WORKING_DATA_INTTableAdapter.FillByENGINE_NO(m_ds.WORKING_DATA_INT, selectedEngineNo)
            'm_tam.WORKING_DATA_DATETIMETableAdapter.FillByENGINE_NO(m_ds.WORKING_DATA_DATETIME, selectedEngineNo)

            'Dim strTables() As String = {"TRACE_DATA_STR", "TRACE_DATA_INT", "TRACE_DATA_DATETIME", "WORKING_DATA_STR", "WORKING_DATA_INT", "WORKING_DATA_DATETIME", "ENGINE_LIST"}

            Dim strTables() As String = {"TRACE_DATA_STR", "TRACE_DATA_FLOAT", "TRACE_DATA_DATETIME", "WORKING_DATA_STR", "WORKING_DATA_FLOAT", "WORKING_DATA_DATETIME", "ENGINE_LIST"}

            'Debug.Print(strTables.Count)

            'For i = 0 To strTables.count
            'For Each strTable In strTables
            'Dim table As DataTable
            'Dim rows As DataRowCollection
            'Dim irow As DataRow

            'Dim engineId2del As String = -1

            'For Each strTable In strTables
            '    'MsgBox(strTable)
            'table = m_ds.Tables(strTable)


            'rows = table.Rows


            'For Each irow In rows
            '    'Debug.Print(irow("ENGINE_ID"))
            '    Dim rowVal As String = ""

            '    If strTable = "ENGINE_LIST" Then
            '        rowVal = irow("ID")

            '    Else

            '        rowVal = irow("ENGINE_ID")
            '    End If

            '    If rowVal = selectedEngineId Then
            '        engineId2del = rowVal
            '        'Debug.Print(irow("ENGINE_ID"))
            '        'Debug.Print(irow("TRACE_COLUMNS_ID"))
            '        irow.Delete()
            '        'm_ds.Tables("TRACE_DATA_STR").Rows(irow).Delete()
            '    End If
            'Next
            ''Next
            m_ds.ENGINE_LIST.FindByID(selectedEngineId).Delete()




            'Next
            'MsgBox(m_ds.HasChanges)










            'Debug.Print("------------------------------")




            'm_tam.BackupDataSetBeforeUpdate = True
            'm_tam.UpdateOrder = DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
            m_tam.UpdateAll(m_ds)
            'Debug.Print("DELETED ENGINE_ID: " & engineId2del)

            'Application.Restart()

            'Me.Refresh()


            'CtrlPivotGrid1.Refresh()
            'MessageBox.Show(String.Format("ENGINE_ID={0} has been deleted successfully.", engineId2del))


            'CtrlPivotGrid1.Rows.GetRowCount(DataGridViewElementStates.Selected)

            'For Each dr In CtrlPivotGrid1.SelectedRows

            '    CtrlPivotGrid1.Rows.Remove(dr)

            'Next

            FillGrid()


            'MessageBox.Show(String.Format("ENGINE_ID={0} has been deleted successfully.", engineId2del))
            MessageBox.Show(String.Format("Data(ENGINE_No.={0}) has been deleted successfully.", selectedEngineNo))



        Catch ex As Exception
            modLogger.HandleException(ex, True)
            MessageBox.Show("Delete Fail!")
        End Try

        

    End Sub

    Public Overrides Sub FillGrid()
        '-------- Initialize table

        m_dtWorkingString = Nothing
        m_dtWorkingFloat = Nothing
        m_dtWorkingDatetime = Nothing
        m_taSettingColumns = Nothing

        'MsgBox(modGlobalVariables.searchBy)


        If modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.ENGINE_NO Then
            'm_dtEngineList = m_taEngineList.GetDataByEngineNo(modGlobalVariables.in_engineNo)
            m_dtEngineList = m_taEngineList.GetDataByEngineNo(modGlobalVariables.arrIn(0))


            'm_dtEngineList.Clear()

            'm_dtEngineList.


        ElseIf modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.MODEL_CODE_LOT_NO Then
            'Dim m_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter
            'MsgBox(modGlobalVariables.arrIn(1))



            m_dtEngineList = m_taEngineList.GetDataByModelCodeLotNo(modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            'm_dtEngineList = m_taEngineList.GetDataByEngineNo("NL9506")
        End If


        'm_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(11)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(11)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(11)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(11)
        'Dim strHiddenColNames() As String = {"ENGINE_ID"}
        strHiddenColNames = {"ENGINE_NO", "MODEL_CODE", "LOT_NO", "UNIT_NO", "ENGINE_TYPE", "ENGINE_ASM_NO", "LINE_ON_TIME", "LINE_OFF_TIME", "BOOK", "YEAR", "AT_MT", "EMISSION", "INJ_MODEL_CODE" _
                                              , "SPARE_001" _
                                              , "SB_DATA_SB_PARTS_NO" _
                                              , "SB_DATA_SB_SERIAL_NO" _
                                              , "SB_DATA_GASKET_GRADE" _
                                              , "RPCOCF_SBLO_BCT" _
                                              , "RPCOCF_SBLO_CRT" _
                                              , "RPCOCF_SBLO_CTM" _
                                              , "RPCOCF_SBLO_SPARE01" _
                                              , "RPCOCF_SBLO_SPARE02" _
                                              , "RPCOCF_SBLO_SPARE03" _
                                              , "RPCOCF_MALO_CCT" _
                                              , "RPCOCF_MALO_DPT" _
                                              , "RPCOCF_MALO_FWT" _
                                              , "RPCOCF_MALO_SPARE01" _
                                              , "RPCOCF_MALO_SPARE02" _
                                              , "RPCOCF_MALO_SPARE03" _
                                              , "RPCOCF_MBLO_HDT" _
                                              , "RPCOCF_MBLO_CCT" _
                                              , "RPCOCF_MBLO_HCT" _
                                              , "RPCOCF_MBLO_PPT" _
                                              , "RPCOCF_MBLO_SPARE01" _
                                              , "RPCOCF_MBLO_SPARE02" _
                                              , "RPCOCF_MBLO_SPARE03" _
                                              , "RPCOCF_MBLO_SPARE04" _
                                              , "INSPSJ_INSPECTION01" _
                                              , "INSPSJ_INSPECTION02" _
                                              , "INSPSJ_INSPECTION03" _
                                              , "INSPSJ_INSPECTION04" _
                                              , "INSPSJ_INSPECTION05" _
                                              , "INSPSJ_INSPECTION06" _
                                              , "INSPSJ_INSPECTION_TIME01" _
                                              , "INSPSJ_INSPECTION11" _
                                              , "INSPSJ_INSPECTION12" _
                                              , "INSPSJ_INSPECTION13" _
                                              , "INSPSJ_INSPECTION14" _
                                              , "INSPSJ_INSPECTION15" _
                                              , "INSPSJ_INSPECTION16" _
                                              , "INSPSJ_INSPECTION_TIME02" _
                                              , "UPDATED_BY" _
                                              , "CREATED_WHEN" _
                                              , "UPDATED_WHEN"}


        LoadData(m_dtEngineList _
                                       , m_dtWorkingString _
                                       , m_dtWorkingFloat _
                                       , m_dtWorkingDatetime _
                                       , m_dtSettingColumns _
                                       , {"ID"} _
                                       , "WORKING_COLUMNS_ID" _
                                       , {"ENGINE_ID"} _
                                       , "DATA" _
                                       , strHiddenColNames)



    End Sub
End Class