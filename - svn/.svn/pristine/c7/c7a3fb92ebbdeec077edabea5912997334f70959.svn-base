Public Class frmData
    'Protected m_dtEngineList As DataSet1.ENGINE_LISTDataTable
    Protected m_dtEngineList As DataTable
    Protected m_dtWorkingString As DataSet1.WORKING_DATA_STRDataTable
    'Protected m_dtWorkingInteger As DataSet1.WORKING_DATA_INTDataTable
    Protected m_dtWorkingFloat As DataSet1.WORKING_DATA_FLOATDataTable
    Protected m_dtWorkingDatetime As DataSet1.WORKING_DATA_DATETIMEDataTable
    Protected m_dtTraceString As DataSet1.TRACE_DATA_STRDataTable
    'Protected m_dtTraceInteger As DataSet1.TRACE_DATA_INTDataTable
    Protected m_dtTraceFloat As DataSet1.TRACE_DATA_FLOATDataTable
    Protected m_dtTraceDatetime As DataSet1.TRACE_DATA_DATETIMEDataTable
    Protected m_dtSettingColumns As DataSet1.V_SETTING_COLUMNSDataTable

    'Protected m_taEngineList As DataSet1TableAdapters.ENGINE_LISTTableAdapter
    Protected m_taEngineList

    Protected m_taWorkingString As DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
    'Protected m_taWorkingInteger As DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
    Protected m_taWorkingFloat As DataSet1TableAdapters.WORKING_DATA_FLOATTableAdapter
    Protected m_taWorkingDatetime As DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
    Protected m_taTraceString As DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
    'Protected m_taTraceInteger As DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
    Protected m_taTraceFloat As DataSet1TableAdapters.TRACE_DATA_FLOATTableAdapter
    Protected m_taTraceDatetime As DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
    Protected m_taSettingColumns As DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter

    Protected strHiddenColNames() As String

    Protected m_strSelectedLot As String
    Protected m_StrSelectedModelCode As String
    Protected m_blnSelecting As String

    Public Overridable Sub LoadData(ByVal dtStatic As DataTable _
                                        , ByVal dtDynamicDataString As DataTable _
                                        , ByVal dtDynamicDataInteger As DataTable _
                                        , ByVal dtDynamicDataDateTime As DataTable _
                                        , ByVal dtColumnHeader As DataSet1.V_SETTING_COLUMNSDataTable _
                                        , ByVal astrRowHeaderMappingDataMember As String() _
                                        , ByVal strRawDataColumnMappingDataMember As String _
                                        , ByVal astrRawDataRowMappingDataMember As String() _
                                        , ByVal strRawDataValueDataMember As String _
                                        , ByVal astrHiddenColumnNames As String() _
                                        , Optional ByVal blnReadOnly As Boolean = True)
        'm_taEngineView.FillAllRevEngIdAndWorkingTypeId(m_dtEngineView, 6, 2)


        Me.CtrlPivotGrid1.SetDataSource(dtStatic _
                                        , dtDynamicDataString _
                                        , dtDynamicDataInteger _
                                        , dtDynamicDataDateTime _
                                        , dtColumnHeader _
                                        , astrRowHeaderMappingDataMember _
                                        , strRawDataColumnMappingDataMember _
                                        , astrRawDataRowMappingDataMember _
                                        , strRawDataValueDataMember _
                                        , astrHiddenColumnNames _
                                         , blnReadOnly)

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.CtrlPivotGrid1.Font = New Font(Me.Font.FontFamily, 8, Me.Font.Style)

        Me.CtrlPivotGrid1.BackColor = Color.FromArgb(255, 255, 255)

        'initializeVariable
        InitializeVariables()
    End Sub

    Protected Overridable Sub InitializeVariables()

        ' Add any initialization after the InitializeComponent() call.
        'm_dtEngineList = New DataSet1.ENGINE_LISTDataTable
        'm_dtWorkingString = New DataSet1.WORKING_DATA_STRDataTable
        'm_dtWorkingInteger = New DataSet1.WORKING_DATA_INTDataTable
        'm_dtWorkingDatetime = New DataSet1.WORKING_DATA_DATETIMEDataTable
        'm_dtTraceString = New DataSet1.TRACE_DATA_STRDataTable
        'm_dtTraceInteger = New DataSet1.TRACE_DATA_INTDataTable
        'm_dtTraceDatetime = New DataSet1.TRACE_DATA_DATETIMEDataTable
        'm_dtSettingColumns = New DataSet1.V_SETTING_COLUMNSDataTable
        ''m_objPivotGrid = New ctrlPivotGrid
        'm_taEngineList = New DataSet1TableAdapters.ENGINE_LISTTableAdapter
        'm_taWorkingString = New DataSet1TableAdapters.WORKING_DATA_STRTableAdapter
        'm_taWorkingInteger = New DataSet1TableAdapters.WORKING_DATA_INTTableAdapter
        'm_taWorkingDatetime = New DataSet1TableAdapters.WORKING_DATA_DATETIMETableAdapter
        'm_taTraceString = New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
        'm_taTraceInteger = New DataSet1TableAdapters.TRACE_DATA_INTTableAdapter
        'm_taTraceDatetime = New DataSet1TableAdapters.TRACE_DATA_DATETIMETableAdapter
        'm_taSettingColumns = New DataSet1TableAdapters.V_SETTING_COLUMNSTableAdapter
    End Sub


    Protected Sub frmData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'm_dtWorkingString = Nothing
        'm_dtWorkingInteger = Nothing
        'm_dtWorkingDatetime = Nothing
        'm_taSettingColumns = Nothing
        'm_dtEngineView = m_taEngineView.GetAllRevByEngIdAndWorkingTypeId(38, 11)
        'm_dtEngineList = m_taEngineList.GetAllRevByEngIdAndWorkingTypeId(38, 11)
        'm_dtWorkingString = m_taWorkingString.GetDataByWorkingTypeId(11)
        'm_dtWorkingInteger = m_taWorkingInteger.GetDataByWorkingTypeId(11)
        'm_dtWorkingDatetime = m_taWorkingDatetime.GetDataByWorkingTypeId(11)
        'm_dtSettingColumns = m_taSettingColumns.GetWorkingColumns(11)
        'Dim strHiddenColNames() As String = {"ENGINE_ID"}


    End Sub

    Protected Overrides Sub moreShown()


        With Me.CtrlPivotGrid1
            Dim spaceLeft As Integer = CInt(Me.Height - Me.Panel1.Height - Me.Height * 0.05)

            '.Size = New System.Drawing.Size(Me.Width * 0.9, Me.Height * 0.8)
            .Size = New System.Drawing.Size(Me.Width * 0.9, spaceLeft * 0.9)
            '.Top = Me.Height * 0.05
            '.Top = Me.Height - Me.Panel1.Height - .Height + Me.Height * 0.1
            .Top = spaceLeft * 0.05
            .Left = (Me.Width - .Width) / 2
        End With

        'Me.TextBoxHeading
    End Sub

    Protected Sub CtrlPivotGrid1_KeyDown(sender As Object, e As KeyEventArgs) Handles CtrlPivotGrid1.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            e.Handled = True
        End If
    End Sub


    Protected Sub CtrlPivotGrid1_SelectionChanged(sender As Object, e As EventArgs) Handles CtrlPivotGrid1.SelectionChanged
        'If Me.LabelSELECTBY.Visible = True And Me.RadioButton1.Checked = True Then


        '    Dim selectedRowCount As Integer = CtrlPivotGrid1.Rows.GetRowCount(DataGridViewElementStates.Selected)

        '    If selectedRowCount = 1 Then
        '        'modGlobalVariables.reset()

        '        Dim selectedLot As String = CtrlPivotGrid1.SelectedRows(0).Cells("LOT_NO").Value.ToString()
        '        Dim selectedModelCode As String = CtrlPivotGrid1.SelectedRows(0).Cells("MODEL_CODE").Value.ToString()

        '        'For i As Integer = 0 To CtrlPivotGrid1.Rows.GetRowCount(DataGridViewElementStates.None)
        '        For Each row As DataGridViewRow In CtrlPivotGrid1.Rows
        '            If row.Cells("LOT_NO").Value.ToString() = selectedLot And row.Cells("MODEL_CODE").Value.ToString() = selectedModelCode Then
        '                row.Selected = True
        '            End If
        '        Next



        '        'MsgBox(selectedLot)
        '    End If
        'End If
        'If Not m_blnSelecting AndAlso Me.CtrlPivotGrid1.Rows.Count > 0 Then
        '    If Me.LabelSELECTBY.Visible = True AndAlso Me.rdoUnit.Checked Then
        '        Me.CtrlPivotGrid1.MultiSelect = False
        '    ElseIf Me.LabelSELECTBY.Visible = True AndAlso Me.rdoLot.Checked Then
        '        Me.CtrlPivotGrid1.MultiSelect = True
        '        Me.CtrlPivotGrid1.ClearSelection()
        '        For Each row As DataGridViewRow In CtrlPivotGrid1.Rows
        '            If row.Cells("LOT_NO").Value.ToString() = m_strSelectedLot _
        '                AndAlso row.Cells("MODEL_CODE").Value.ToString() = m_StrSelectedModelCode Then
        '                row.Selected = True
        '            End If
        '        Next
        '    End If
        'End If


    End Sub


    Private Sub CtrlPivotGrid1_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CtrlPivotGrid1.CellMouseDown
        If e.RowIndex = -1 AndAlso e.ColumnIndex = -1 Then
            Me.CtrlPivotGrid1.MultiSelect = False
        End If

        If Me.LabelSELECTBY.Visible = True AndAlso Me.rdoUnit.Checked Then
            Me.CtrlPivotGrid1.MultiSelect = False
        ElseIf Me.LabelSELECTBY.Visible = True AndAlso Me.rdoLot.Checked Then
            If Me.CtrlPivotGrid1.Rows.Count > 0 AndAlso e.RowIndex >= 0 AndAlso e.RowIndex < Me.CtrlPivotGrid1.Rows.Count Then
                m_strSelectedLot = ""
                m_StrSelectedModelCode = ""
                m_strSelectedLot = CtrlPivotGrid1.Rows(e.RowIndex).Cells("LOT_NO").Value.ToString()
                m_StrSelectedModelCode = CtrlPivotGrid1.Rows(e.RowIndex).Cells("MODEL_CODE").Value.ToString()
                Me.CtrlPivotGrid1.MultiSelect = False
            End If
        End If
    End Sub

    Private Sub CtrlPivotGrid1_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CtrlPivotGrid1.CellMouseUp
        m_blnSelecting = True
        Try
            If e.RowIndex = -1 AndAlso e.ColumnIndex = -1 Then
                Me.CtrlPivotGrid1.ClearSelection()
            End If
            If Me.LabelSELECTBY.Visible = True AndAlso Me.rdoUnit.Checked Then
                'Do Nothing
            ElseIf Me.LabelSELECTBY.Visible = True AndAlso Me.rdoLot.Checked Then
                Me.CtrlPivotGrid1.MultiSelect = True
                If Me.CtrlPivotGrid1.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In CtrlPivotGrid1.Rows
                        If row.Cells("LOT_NO").Value.ToString() = m_strSelectedLot AndAlso _
                            row.Cells("MODEL_CODE").Value.ToString() = m_StrSelectedModelCode Then
                            row.Selected = True
                        End If
                    Next
                End If
            End If
        Catch ex As Exception

        Finally
            m_blnSelecting = False
        End Try
    End Sub

    Public Overridable Sub FillGrid()

    End Sub

    Protected Overrides Sub rdoLot_CheckedChanged(sender As Object, e As EventArgs)
        If CtrlPivotGrid1 IsNot Nothing Then
            Me.CtrlPivotGrid1.ClearSelection()
        End If
    End Sub

    Protected Overrides Sub rdoUnit_CheckedChanged(sender As Object, e As EventArgs)
        If CtrlPivotGrid1 IsNot Nothing Then
            Me.CtrlPivotGrid1.ClearSelection()
        End If
    End Sub
End Class