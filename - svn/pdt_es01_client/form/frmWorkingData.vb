﻿Public Class frmWorkingData
    'Dim m_taEngineList As DataSet1TableAdapters.ENGINE_LISTTableAdapter

    Public Overrides Sub FillGrid()
        If modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.ENGINE_NO Then
            'm_dtEngineList = m_taEngineList.GetDataByEngineNo(modGlobalVariables.in_engineNo)
            m_dtEngineList = DirectCast(m_taEngineList, DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter).GetDataByWorkingID_EngineNo(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0))

            m_dtWorkingString = m_taWorkingString.GetDataByWORKING_ENGINE_NO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0))
            'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWORKING_ENGINE_NO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0))
            m_dtWorkingFloat = m_taWorkingFloat.GetDataByWORKING_ENGINE_NO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0))
            m_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWORKING_ENGINE_NO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0))
            m_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(modGlobalVariables.workingtypeID)

            'm_dtEngineList.Clear()

            'm_dtEngineList.


        ElseIf modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.MODEL_CODE_LOT_NO Then
            'Dim m_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter
            'MsgBox(modGlobalVariables.arrIn(1))

            m_dtEngineList = DirectCast(m_taEngineList, DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter).GetDataByWorkingID_ModelCode_LotNo(workingtypeID, modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))

            'm_dtEngineList = m_taEngineList.GetDataByModelCodeLotNo(modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            'MsgBox("-----Waiting for BELL")
            m_dtWorkingString = m_taWorkingString.GetDataByWORKING_MODELCODE_LOTNO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWORKING_MODELCODE_LOTNO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            m_dtWorkingFloat = m_taWorkingFloat.GetDataByWORKING_MODELCODE_LOTNO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            m_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWORKING_MODELCODE_LOTNO(modGlobalVariables.workingtypeID, modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            m_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(modGlobalVariables.workingtypeID)

            'm_dtEngineList = m_taEngineList.GetDataByModelCodeLotNo(modGlobalVariables.arrIn(0), modGlobalVariables.arrIn(1))
            'm_dtEngineList = m_taEngineList.GetDataByEngineNo("NL9506")
        End If


        'm_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(11)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(11)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(11)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(11)
        'Dim strHiddenColNames() As String = {"ENGINE_ID"}
        strHiddenColNames = {"REV_NO" _
                                                          , "ENGINE_NO" _
                                , "MODEL_CODE" _
                                , "LOT_NO" _
                                , "UNIT_NO" _
                                , "ENGINE_ASM_NO"
                                }
        'strHiddenColNames = {"ENGINE_ID" _
        '                                      , "ID" _
        '                                      , "ENGINE_TYPE" _
        '                                      , "BOOK" _
        '                                      , "YEAR" _
        '                                      , "AT_MT" _
        '                                      , "EMISSION" _
        '                                      , "INJ_MODEL_CODE" _
        '                                      , "SPARE_001" _
        '                                      , "SB_DATA_SB_PARTS_NO" _
        '                                      , "SB_DATA_SB_SERIAL_NO" _
        '                                      , "SB_DATA_GASKET_GRADE" _
        '                                      , "LINE_ON_TIME" _
        '                                      , "LINE_OFF_TIME" _
        '                                      , "RPCOCF_SBLO_BCT" _
        '                                      , "RPCOCF_SBLO_CRT" _
        '                                      , "RPCOCF_SBLO_CTM" _
        '                                      , "RPCOCF_SBLO_SPARE01" _
        '                                      , "RPCOCF_SBLO_SPARE02" _
        '                                      , "RPCOCF_SBLO_SPARE03" _
        '                                      , "RPCOCF_MALO_CCT" _
        '                                      , "RPCOCF_MALO_DPT" _
        '                                      , "RPCOCF_MALO_FWT" _
        '                                      , "RPCOCF_MALO_SPARE01" _
        '                                      , "RPCOCF_MALO_SPARE02" _
        '                                      , "RPCOCF_MALO_SPARE03" _
        '                                      , "RPCOCF_MBLO_HDT" _
        '                                      , "RPCOCF_MBLO_CCT" _
        '                                      , "RPCOCF_MBLO_HCT" _
        '                                      , "RPCOCF_MBLO_PPT" _
        '                                      , "RPCOCF_MBLO_SPARE01" _
        '                                      , "RPCOCF_MBLO_SPARE02" _
        '                                      , "RPCOCF_MBLO_SPARE03" _
        '                                      , "RPCOCF_MBLO_SPARE04" _
        '                                      , "INSPSJ_INSPECTION01" _
        '                                      , "INSPSJ_INSPECTION02" _
        '                                      , "INSPSJ_INSPECTION03" _
        '                                      , "INSPSJ_INSPECTION04" _
        '                                      , "INSPSJ_INSPECTION05" _
        '                                      , "INSPSJ_INSPECTION06" _
        '                                      , "INSPSJ_INSPECTION_TIME01" _
        '                                      , "INSPSJ_INSPECTION11" _
        '                                      , "INSPSJ_INSPECTION12" _
        '                                      , "INSPSJ_INSPECTION13" _
        '                                      , "INSPSJ_INSPECTION14" _
        '                                      , "INSPSJ_INSPECTION15" _
        '                                      , "INSPSJ_INSPECTION16" _
        '                                      , "INSPSJ_INSPECTION_TIME02" _
        '                                      , "UPDATED_BY" _
        '                                      , "CREATED_WHEN" _
        '                                      , "UPDATED_WHEN"}
        ' , {"ENGINE_ID", "REV_NO"} _


        LoadData(m_dtEngineList _
                                           , m_dtWorkingString _
                                           , m_dtWorkingFloat _
                                           , m_dtWorkingDatetime _
                                           , m_dtSettingColumns _
                                           , {"ENGINE_ID", "REV_NO"} _
                                           , "WORKING_COLUMNS_ID" _
                                           , {"ENGINE_ID", "REV_NO"} _
                                           , "DATA" _
                                           , strHiddenColNames)

        'CtrlPivotGrid1.SetDataSource(m_dtEngineView _
        '                               , m_dtWorkingString _
        '                               , m_dtWorkingInteger _
        '                               , m_dtWorkingDatetime _
        '                               , m_dtSettingColumns _
        '                               , {"ID"} _
        '                               , "WORKING_COLUMNS_ID" _
        '                               , {"ENGINE_ID"} _
        '                               , "DATA" _
        '                               , strHiddenColNames)


    End Sub


    Private Sub frmWorkingData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "WORKING DATA"

            InitializeControls()



            Dim hCtrls As New Hashtable
            hCtrls("ButtonManualInput") = 0.3
            hCtrls("ButtonMAINMENU") = 0.9
            hCtrls("ButtonPRINT") = 0.5
            hCtrls("ButtonCANCEL") = 0.7

            ShowOnlyControls(hCtrls)


            '-------- Initialize table

            'm_dtWorkingString = Nothing
            'm_dtWorkingInteger = Nothing
            'm_dtWorkingDatetime = Nothing
            'm_taSettingColumns = Nothing

            'MsgBox(modGlobalVariables.searchBy)
            FillGrid()


            

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Protected Overrides Sub InitializeVariables()
        ' Add any initialization after the InitializeComponent() call.
        m_taEngineList = New DataSet1TableAdapters.V_WORKING_DATA_STATICTableAdapter
        m_dtEngineList = New DataSet1.V_WORKING_DATA_STATICDataTable

        m_dtWorkingString = New DataSet1.WORKING_DATA_STRDataTable
        'm_dtWorkingInteger = New DataSet1.WORKING_DATA_INTDataTable
        m_dtWorkingFloat = New DataSet1.WORKING_DATA_FLOATDataTable
        m_dtWorkingDatetime = New DataSet1.WORKING_DATA_DATETIMEDataTable
        m_dtSettingColumns = New DataSet1.V_SETTING_COLUMNSDataTable
        'm_objPivotGrid = New ctrlPivotGrid
       

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

            For Each dr In CtrlPivotGrid1.SelectedRows

                CtrlPivotGrid1.Rows.Remove(dr)

            Next

            'MessageBox.Show(String.Format("ENGINE_ID={0} has been deleted successfully.", engineId2del))
            MessageBox.Show(String.Format("Data(ENGINE_No.={0}) has been deleted successfully.", selectedEngineNo))



        Catch ex As Exception
            modLogger.HandleException(ex, True)
            MessageBox.Show("Delete Fail!")
        End Try



    End Sub


    Protected Shadows Sub ButtonManualInput_Click(sender As Object, e As EventArgs) Handles ButtonManualInput.Click

        Try
            Dim CtrlPivotGrid1 As pdt_es01_client.ctrlPivotGrid = Me.Controls("CtrlPivotGrid1")

            If CtrlPivotGrid1.RowCount <= 0 Then
                MsgBox("No data to update", MsgBoxStyle.Exclamation)
                Return
            End If

            If CtrlPivotGrid1.SelectedRows.Count = 1 Then

                'modGlobalVariables.reset()
                Dim intLastRev As Integer = 0
                Dim int2EditRev As Integer = 0
                Dim int2MaxRev As Integer = CtrlPivotGrid1.SelectedRows(0).Cells("MAX_REV").Value
                Dim engine_no As String = CtrlPivotGrid1.SelectedRows(0).Cells("ENGINE_NO").Value

                'MsgBox(CtrlPivotGrid1.SelectedRows(0).Cells("MAX_REV").Value)
                For Each row As DataGridViewRow In CtrlPivotGrid1.Rows
                    If row.Cells("ENGINE_NO").Value = engine_no And row.Cells("REV_NO").Value > intLastRev Then
                        intLastRev = row.Cells("REV_NO").Value
                    End If
                Next

                If int2MaxRev = CtrlPivotGrid1.SelectedRows(0).Cells("REV_NO").Value Then
                    int2EditRev = int2MaxRev
                Else
                    int2EditRev = intLastRev + 1
                    'intLastRev = intLastRev + 1
                End If

                'MsgBox(intLastRev)
                'Exit Sub


                Dim result1 As DialogResult = MessageBox.Show(String.Format("YES: to edit{0}NO: to add new revision{0}CANCEL: to do nothing.", Environment.NewLine), _
                              "EDIT selected revision?", _
                              MessageBoxButtons.YesNoCancel)


                If result1 = Windows.Forms.DialogResult.Yes Then
                    int2EditRev = CtrlPivotGrid1.SelectedRows(0).Cells("REV_NO").Value
                ElseIf result1 = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub

                Else
                    If int2EditRev > CtrlPivotGrid1.SelectedRows(0).Cells("MAX_REV").Value Then

                        MessageBox.Show("Revision no. is already reach the maximum revision.", "Can not create new revision!")
                        Exit Sub
                    End If



                End If

                modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.ENGINE_NO

                modGlobalVariables.arrIn.Clear()
                modGlobalVariables.arrIn.Add(engine_no)
                modGlobalVariables.arrIn.Add(CtrlPivotGrid1.SelectedRows(0).Cells("REV_NO").Value)
                modGlobalVariables.arrIn.Add(int2EditRev)
                modGlobalVariables.arrIn.Add(int2MaxRev)


                Dim frm As New frmProductionManualInputWorkingData

                Select Case frm.ShowDialog
                    Case Windows.Forms.DialogResult.Abort
                        Me.DialogResult = Windows.Forms.DialogResult.Abort
                        Me.Close()
                    Case Windows.Forms.DialogResult.OK
                        Me.FillGrid()
                End Select
                'If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                '    Me.DialogResult = Windows.Forms.DialogResult.Abort
                '    Me.Close()
                'End If

                'Me.Close()

            Else
                MsgBox("Please select data first.", "No row selected!")
            End If

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try



    End Sub

End Class