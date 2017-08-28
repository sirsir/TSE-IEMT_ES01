Public Class Form1
    Friend WithEvents m_objBkgImport As clsImportDataFile

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim staff As sakilaDataSet.customerDataTable = New sakilaDataSetTableAdapters.customerTableAdapter().GetData
        'Dim rows() As sakilaDataSet.customerRow = staff.Select("email='" + email.Text + "'")
        Dim dtTemp2 As iemt_pdt_es01_developmentDataSet.IMPORT_CELL_MAPPINGDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_CELL_MAPPINGTableAdapter().GetData

        'Dim dsTemp2 As New DataSet
        'dsTemp2 = New iemt_pdt_es01_developmentDataSet

        Me.DataGridView1.DataSource = dtTemp2

        Dim rows() As iemt_pdt_es01_developmentDataSet.IMPORT_CELL_MAPPINGRow = dtTemp2.Select("POSITION=" & 122)

        'Dim rows() As DataRow
        'rows = dsTemp2.Tables("IMPORT_CELL_MAPPING").Select("POSITION=122")


        Dim strOut As String
        strOut = ""

        Dim i As String
        i = 0
        For Each row In rows
            'strOut = row.ToString & Environment.NewLine

            strOut &= row.LENGTH.ToString & " " & i.ToString & Environment.NewLine


        Next row

        TextBox1.Text = strOut

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dtTemp As New DataTable
        'Dim dsTemp As New DataSet
        'Dim daTemp As SqlDataAdapter = New iemt_pdt_es01_developmentDataSetTableAdapters
        'Dim daTemp As New OleDb.OleDbDataAdapter
        'Dim daTemp As New SqlDataAdapter

        'dsTemp = New iemt_pdt_es01_developmentDataSet



        'dtTemp = New iemt_pdt_es01_developmentDataSet.IMPORT_CELL_MAPPINGDataTable
        'dtTemp = New iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGDataTable

        'dtTemp = dsTemp.Tables("IMPORT_ENGINE_MAPPING").GetData

        Dim dtTemp As iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData

        ' daTemp = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_ENGINE_MAPPINGTableAdapter

        Me.DataGridView1.DataSource = dtTemp

        'Me.DataGridView1.DataSource = dsTemp.Tables(0)

        m_objBkgImport = New clsImportDataFile
        m_objBkgImport.RunWorkerAsync()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim taTemp As iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter
        taTemp = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter

        'Dim dtTemp As New DataTable("CSV")
        'dtTemp.Columns.Add("pos")
        'dtTemp.Columns.Add("value")
        'dtTemp.Rows.Add("sam", 1)




        Dim strMsg As String = ""

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\Users\Administrator\Desktop\IEMT_ES01\from mail\DataWriter_1_0000 - ORIGIN.csv")

            Dim dtEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
            Dim dtWorkCol As iemt_pdt_es01_developmentDataSet.WORKING_COLUMNSDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_COLUMNSTableAdapter().GetData
            Dim dtTraceCol As iemt_pdt_es01_developmentDataSet.TRACE_COLUMNSDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_COLUMNSTableAdapter().GetData

            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.TrimWhiteSpace = False
            'MyReader.Delimiters = New String() {vbTab}
            MyReader.Delimiters = New String() {","}
            Dim currentRow As String()
            'Loop through all of the fields in the file. 
            'If any lines are corrupt, report an error and continue parsing. 

            'Dim pos As Integer

            'skip 1st line
            currentRow = MyReader.ReadFields()

            Dim dtEngineMap As iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_ENGINE_MAPPINGTableAdapter().GetData
            Dim dtCellMap As iemt_pdt_es01_developmentDataSet.IMPORT_CELL_MAPPINGDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_CELL_MAPPINGTableAdapter().GetData


            Dim rEngineRow As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow

            'Based 0
            Dim startColumnPos As Integer = 5


            While Not MyReader.EndOfData
                Try
                    ' while loop for each line in csv


                    rEngineRow = dtEngineList.NewRow()
                    'pos = 1
                    currentRow = MyReader.ReadFields()
                    Dim ENGINE_ID As Integer = -1
                    Dim ENGINE_NO As String = ""

                    'For i As Integer = currentRow.GetLowerBound(0) To currentRow.GetUpperBound(0)

                    If currentRow.Length > 0 Then
                        'Debug.Print("----{0}---{1}----{2}----", LBound(currentRow), LBound(currentRow) + startColumnPos - 1, currentRow(LBound(currentRow)))
                        For csspos As Integer = LBound(currentRow) + startColumnPos - 1 To UBound(currentRow)
                            Dim pos As Integer = csspos - startColumnPos + 1
                            'each column in a line in csv


                            Dim currentField As String = currentRow(csspos)
                            'For Each currentField As String In currentRow
                            'dtTemp.Rows.Add(pos, currentField)
                            'add2tables(pos, currentField, dtTemp)
                            Dim rows() As iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGRow = dtEngineMap.Select("POSITION=" & pos)
                            'Dim row As iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGRow



                            If rows.Length > 0 Then
                                Dim columnName As String = rows.First.COLUMN_NAME
                                'rEngineRow.SetField(rows[0], currentField)

                                'Debug.Print(columnName & Environment.NewLine & "------------------------------------------------")
                                'Debug.Print(currentField & "|   " & pos & Environment.NewLine & "------------------------------------------------")


                                Dim length As Integer = CInt(rows.First.Item("LENGTH").ToString)

                                Dim strTemp4field = currentField


                                'Debug.Print("---pos-{0}({1})-val:{2}--length:{3}------------------------------------------", pos, csspos, currentRow(csspos), length)

                                If columnName = "ENGINE_NO" Then

                                    ENGINE_NO = currentRow(csspos)

                                End If

                                While length <> 1
                                    pos += 1
                                    'Dim columnName As String = rows.First.Item("COLUMN_NAME").ToString

                                    If (dtEngineList.Columns(columnName)).DataType = System.Type.GetType("System.DateTime") Then
                                        strTemp4field &= CInt(currentRow(csspos)).ToString("0000")
                                    Else

                                        strTemp4field &= currentRow(csspos)
                                    End If




                                    length -= 1

                                End While


                                If (dtEngineList.Columns(columnName)).DataType = System.Type.GetType("System.DateTime") Then
                                    strTemp4field = Strings.Format(CULng(strTemp4field) / 100, "####-##-## ##:##:##")
                                End If


                                'Debug.Print(pos)

                                'Debug.Print(strTemp4field & "|   " & pos & Environment.NewLine & "------------------------------------------------")
                                'Debug.Print(Environment.NewLine & "------------------------------------------------")

                                'rows.First.Item("COLUMN_NAME").AllowDBNull

                                'MsgBox(dtEngineList.Columns(columnName).AllowDBNull)

                                'If (dtEngineList.Columns("COLUMN_NAME").AllowDBNull = False) And strTemp4field = "" Then
                                If (dtEngineList.Columns(columnName).AllowDBNull = False) And strTemp4field = "" Then
                                    strTemp4field = "x"
                                    strMsg &= "Modified: Column(" & columnName & ") to be not null(add 'x')" & Environment.NewLine
                                End If

                                If dtEngineList.Columns(columnName).MaxLength <> -1 Then
                                    If strTemp4field.Length > dtEngineList.Columns(columnName).MaxLength Then
                                        strTemp4field = "x"
                                        strMsg &= "Modified: Column(" & columnName & ") to be within limited length(set as 'x')" & Environment.NewLine
                                    End If
                                End If

                                Try
                                    rEngineRow.Item(columnName) = strTemp4field

                                Catch ex As System.ArgumentException
                                    Debug.Print(ex.Message)
                                    'If strTemp4field = "" And (InStr(ex.Message, "String was not recognized as a valid DateTime") > 0) Then
                                    If (InStr(ex.Message, "String was not recognized as a valid DateTime") > 0) Then
                                        'If (InStr(ex.Message, "String was not recognized as a valid DateTime") > 0) Then
                                        rEngineRow.Item(columnName) = "1753-01-01"
                                        'rEngineRow.Item(columnName) = "1753-01-01  13:23:44"

                                        Debug.Print("Modified: Column(" & columnName & ") to be dated(set as '1753-01-01')" & Environment.NewLine)

                                        strMsg &= "Modified: Column(" & columnName & ") to be dated(set as '1753-01-01')" & Environment.NewLine
                                    End If

                                End Try




                            End If

                            'pos += 1
                        Next
                        'End loop for each field in csv

                        'NorthwindDataSet1.Customers.Rows.Add(newCustomersRow)


                        'rEngineRow.Item("CREATED_BY") = "x"
                        'rEngineRow.Item("CREATED_WHEN") = "1753-01-01"
                        rEngineRow.CREATED_WHEN = DateTime.Now

                        'strMsg &= "Modified: Column(CREATE_BY) to be not null(add 'x')" & Environment.NewLine
                        strMsg &= "Modified: Column(CREATED_WHEN) to be not null(add 'x')" & Environment.NewLine

                        'For Each col In New String() {"CREATED_BY", "SPARE_002", "SPARE_003", "SPARE_004", "SPARE_005", "SPARE_006", "SPARE_007", "SPARE_008", "SPARE_009", "SPARE_010", "SPARE_011", "SPARE_012", "SPARE_013", "SPARE_014", "SPARE_015", "SPARE_016", "SPARE_017"}
                        For Each col In New String() {}
                            rEngineRow.Item(col) = "x"


                            strMsg &= "Modified: Column(" & col & ") to be not null(add 'x')" & Environment.NewLine
                        Next col


                        Dim rowResults() As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow = dtEngineList.Select("ENGINE_NO='" & rEngineRow.ENGINE_NO & "'")


                        If rowResults.Length = 0 Then
                            dtEngineList.Rows.Add(rEngineRow)
                            ENGINE_ID = rEngineRow.ID
                            'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                        Else
                            rEngineRow.UPDATED_WHEN = rEngineRow.CREATED_WHEN
                            rEngineRow.CREATED_WHEN = rowResults(0).CREATED_WHEN

                            ENGINE_ID = rowResults(0).ID


                            For Each column In dtEngineList.Columns
                                'dtEngineList.Rows(rowResults(0).Item("ID")).Item(column) = rEngineRow.Item(column)

                                'set only settable column
                                Try
                                    dtEngineList.FindByID(ENGINE_ID).Item(column) = rEngineRow.Item(column)
                                Catch ex As System.Data.ReadOnlyException

                                End Try
                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray


                            Next column
                            'dtEngineList.Rows.
                            'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))

                            'Dim dtEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
                            'dtEngineList = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
                            'dtEngineList.Rows.
                            'dtEngineList.Rows.Add(rEngineRow)
                            'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))









                        End If
                        'of If rowResults.Length = 0 
                        ' modify existing row or add new one


                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Deleted))
                        taTemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        'datemp.Update(dsTemp2)
                        taTemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))

                        'dtEngineList = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
                        'dtEngineList.Reset()

                        'Threading.Thread.Sleep(2000)
                        'datemp = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter

                        'Dim datemp2 As iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter
                        'datemp2 = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter

                        'datemp.Update()
                        'Dim dtEngineListUpdate = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
                        'Dim dtEngineListUpdate = datemp2.GetData

                        If ENGINE_ID < 0 Then
                            'MsgBox(ENGINE_ID)
                            Dim rows() As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow = dtEngineList.Select("ENGINE_NO='" & ENGINE_NO & "'")

                            If rows.Length < 1 Then
                                MsgBox("CANT SELECT: ENGINE_NO='" & ENGINE_NO & "'")
                                ENGINE_ID = -9999
                            Else
                                ENGINE_ID = CInt(rows.First.Item("ID"))
                            End If
                            'ENGINE_ID = getEngineListID_from_EngineNo(ENGINE_NO)
                        End If
                        ' end set ENGINE_NO

                        '' SET WORKING & TRACE
                        'Dim hdaOut As Hashtable = New Hashtable()
                        '"category|datatype"
                        'hdaOut(strMode)
                        Dim daOut11 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                        Dim dtOut11 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                        Dim rowdata11 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                        rowdata11 = dtOut11.NewRow()
                        Dim rowCheckDuplicateResults11() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow


                        Dim daOut12 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_INTTableAdapter
                        Dim dtOut12 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_INTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_INTTableAdapter().GetData
                        Dim rowdata12 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_INTRow
                        rowdata12 = dtOut12.NewRow()
                        Dim rowCheckDuplicateResults12() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_INTRow

                        Dim daOut13 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_DATETIMETableAdapter
                        Dim dtOut13 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_DATETIMEDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_DATETIMETableAdapter().GetData
                        Dim rowdata13 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_DATETIMERow
                        rowdata13 = dtOut13.NewRow()
                        Dim rowCheckDuplicateResults13() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_DATETIMERow


                        Dim daOut21 = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_STRTableAdapter
                        Dim dtOut21 As iemt_pdt_es01_developmentDataSet.TRACE_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_STRTableAdapter().GetData
                        Dim rowdata21 As iemt_pdt_es01_developmentDataSet.TRACE_DATA_STRRow
                        rowdata21 = dtOut21.NewRow()
                        Dim rowCheckDuplicateResults21() As iemt_pdt_es01_developmentDataSet.TRACE_DATA_STRRow


                        Dim daOut22 = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_INTTableAdapter
                        Dim dtOut22 As iemt_pdt_es01_developmentDataSet.TRACE_DATA_INTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_INTTableAdapter().GetData
                        Dim rowdata22 As iemt_pdt_es01_developmentDataSet.TRACE_DATA_INTRow
                        rowdata22 = dtOut22.NewRow()
                        Dim rowCheckDuplicateResults22() As iemt_pdt_es01_developmentDataSet.TRACE_DATA_INTRow


                        Dim daOut23 = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_DATETIMETableAdapter
                        Dim dtOut23 As iemt_pdt_es01_developmentDataSet.TRACE_DATA_DATETIMEDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_DATETIMETableAdapter().GetData
                        Dim rowdata23 As iemt_pdt_es01_developmentDataSet.TRACE_DATA_DATETIMERow
                        rowdata23 = dtOut23.NewRow()
                        Dim rowCheckDuplicateResults23() As iemt_pdt_es01_developmentDataSet.TRACE_DATA_DATETIMERow


                        For csspos As Integer = LBound(currentRow) + startColumnPos - 1 To UBound(currentRow)
                            Dim pos As Integer = csspos - startColumnPos + 1

                            'Debug.Print("----------------------------------" & pos)
                            'Debug.Print(pos - startColumnPos + 2)
                            'For pos As Integer = LBound(currentRow) + startColumnPos To 129
                            Dim currentField As String = currentRow(csspos)
                            Dim rowsFromSQL() As iemt_pdt_es01_developmentDataSet.IMPORT_CELL_MAPPINGRow = dtCellMap.Select("POSITION=" & pos)
                            'Dim row As iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGRow



                            If rowsFromSQL.Length > 0 Then

                                Dim category As Integer = CInt(rowsFromSQL.First.Item("DATA_CATEGORY"))
                                Dim id As Integer = CInt(rowsFromSQL.First.Item("COLUMN_ID"))
                                Dim length As Integer = CInt(rowsFromSQL.First.Item("LENGTH"))
                                Dim revision As Integer = CInt(rowsFromSQL.First.Item("REV"))
                                Dim datatype As Integer
                                'datatype   1:string,2:int,3:date
                                If category = 1 Then
                                    datatype = dtWorkCol.FindByID(id).Item("DATA_TYPE")

                                ElseIf category = 2 Then
                                    datatype = dtTraceCol.FindByID(id).Item("DATA_TYPE")

                                End If

                                'Debug.Print(columnName & Environment.NewLine & "------------------------------------------------")
                                'Debug.Print(currentField & "|   " & pos & Environment.NewLine & "------------------------------------------------")


                                'Dim length As Integer = CInt(rows.First.Item("LENGTH").ToString)

                                Dim strTemp4field = currentField

                                Debug.Print("---pos-{0}(csspos{6})-cat:{1}--datatyp:{2}---id:{3}---value:{4}---length:{5}-----------------------------------------------------", pos, category, datatype, id, currentRow(csspos), length, csspos)

                                While length <> 1
                                    'Debug.Print("----------------------------------------------------------------------")
                                    'Debug.Print("----{0}--{1}--{2}---{3}---{4}--------------------------------------------------------", pos, category, datatype, id, currentRow(csspos))


                                    pos += 1
                                    'Dim columnName As String = rows.First.Item("COLUMN_NAME").ToString

                                    If datatype = 3 And currentRow(csspos).Trim <> "" Then

                                        strTemp4field &= CInt(currentRow(csspos)).ToString("0000")
                                    Else

                                        strTemp4field &= currentRow(csspos)
                                    End If




                                    length -= 1

                                End While
                                ' concate string for length >1

                                If datatype = 3 Then
                                    Try
                                        strTemp4field = Strings.Format(CULng(strTemp4field) / 100, "####-##-## ##:##:##")
                                    Catch ex As Exception
                                        'Debug.Print("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
                                        'Debug.Print(strTemp4field)
                                        strTemp4field = "1753-01-01"
                                        strMsg &= "Modified: Pos(" & pos & ") to be '1753-01-01'" & Environment.NewLine
                                    End Try

                                    If Not IsDate(strTemp4field) Then
                                        strTemp4field = "1753-01-01"
                                        strMsg &= "Modified: Pos(" & pos & ") to be '1753-01-01'" & Environment.NewLine
                                    End If


                                ElseIf datatype = 1 Then
                                    strTemp4field = Strings.Left(strTemp4field, 255)
                                    strMsg &= "Modified: Pos(" & pos & ") to be not stings.left(x,255)" & Environment.NewLine
                                End If

                                'Dim dtOut1 As Object


                                If category = 1 And datatype = 1 Then

                                    'Dim daOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                                    'Dim dtOut1 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData

                                    'dtOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                                    Dim columnIdName As String = "WORKING_COLUMNS_ID"
                                    'Dim rowdata As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                                    'rowdata = dtOut1.NewRow()

                                    Dim duplicateExist As Boolean = False

                                    Try
                                        rowdata11.ENGINE_ID = ENGINE_ID
                                        rowdata11.WORKING_COLUMNS_ID = id
                                        rowdata11.REV_NO = revision
                                        rowdata11.DATA = strTemp4field

                                        'Debug.Print(pos)
                                        'Debug.Print(strTemp4field)
                                        'Debug.Print("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                                    Catch ex As System.ArgumentException
                                        Debug.Print(ex.Message)
                                    Catch ex As System.Data.ConstraintException
                                        duplicateExist = True
                                    End Try
                                    Dim str4select As String

                                    'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                    str4select = String.Format("ENGINE_ID={0} AND {1}={2} AND REV_NO={3}", ENGINE_ID, columnIdName, id, revision)
                                    'str4select = String.Format("ENGINE_ID={0} x", ENGINE_ID)
                                    'Debug.Print(str4select)

                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut11.Select(str4select)
                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut11.Select(str4select)
                                    rowCheckDuplicateResults11 = dtOut11.Select(str4select)


                                    If (Not duplicateExist) And rowCheckDuplicateResults11.Length < 1 Then
                                        dtOut11.Rows.Add(rowdata11)
                                        'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                        'Debug.Print(rowdata11.DATA)

                                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                                    Else

                                        'Dim id2mod As Integer = rowCheckDuplicateResults(0).Item("ID")


                                        For Each column As DataColumn In dtOut11.Columns
                                            'Debug.Print(column.ColumnName)
                                            If column.ColumnName = "DATA" Then
                                                Try
                                                    '------------------MODIFY HERE for each strMode
                                                    'dtOut11.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = rowdata11.Item(column)
                                                    dtOut11.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = strTemp4field
                                                Catch ex As System.Data.ReadOnlyException

                                                End Try
                                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray

                                            End If
                                        Next column




                                    End If





                                ElseIf category = 1 And datatype = 2 Then
                                    'Dim daOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                                    'Dim dtOut1 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData

                                    'dtOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                                    Dim columnIdName As String = "WORKING_COLUMNS_ID"
                                    'Dim rowdata As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                                    'rowdata = dtOut1.NewRow()

                                    Dim duplicateExist As Boolean = False

                                    Try
                                        rowdata12.ENGINE_ID = ENGINE_ID
                                        rowdata12.WORKING_COLUMNS_ID = id
                                        rowdata12.REV_NO = revision
                                        rowdata12.DATA = strTemp4field

                                        'Debug.Print(pos)
                                        'Debug.Print(strTemp4field)
                                        'Debug.Print("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                                    Catch ex As System.ArgumentException
                                        Debug.Print(ex.Message)
                                    Catch ex As System.Data.ConstraintException
                                        duplicateExist = True
                                    End Try
                                    Dim str4select As String

                                    'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                    str4select = String.Format("ENGINE_ID={0} AND {1}={2} AND REV_NO={3}", ENGINE_ID, columnIdName, id, revision)
                                    'str4select = String.Format("ENGINE_ID={0} x", ENGINE_ID)
                                    'Debug.Print(str4select)

                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut12.Select(str4select)
                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut12.Select(str4select)
                                    rowCheckDuplicateResults12 = dtOut12.Select(str4select)


                                    If (Not duplicateExist) And rowCheckDuplicateResults12.Length < 1 Then
                                        dtOut12.Rows.Add(rowdata12)
                                        'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                        'Debug.Print(rowdata12.DATA)

                                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                                    Else

                                        'Dim id2mod As Integer = rowCheckDuplicateResults(0).Item("ID")


                                        For Each column As DataColumn In dtOut12.Columns
                                            'Debug.Print(column.ColumnName)
                                            If column.ColumnName = "DATA" Then
                                                Try
                                                    '------------------MODIFY HERE for each strMode
                                                    'dtOut12.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = rowdata12.Item(column)
                                                    dtOut12.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = strTemp4field
                                                Catch ex As System.Data.ReadOnlyException

                                                End Try
                                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray

                                            End If
                                        Next column




                                    End If
                                ElseIf category = 1 And datatype = 3 Then
                                    'Dim daOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                                    'Dim dtOut1 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData

                                    'dtOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                                    Dim columnIdName As String = "WORKING_COLUMNS_ID"
                                    'Dim rowdata As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                                    'rowdata = dtOut1.NewRow()

                                    Dim duplicateExist As Boolean = False

                                    Try
                                        rowdata13.ENGINE_ID = ENGINE_ID
                                        rowdata13.WORKING_COLUMNS_ID = id
                                        rowdata13.REV_NO = revision
                                        rowdata13.DATA = strTemp4field

                                        'Debug.Print(pos)
                                        'Debug.Print(strTemp4field)
                                        'Debug.Print("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                                    Catch ex As System.ArgumentException
                                        Debug.Print(ex.Message)
                                    Catch ex As System.Data.ConstraintException
                                        duplicateExist = True
                                    End Try
                                    Dim str4select As String

                                    'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                    str4select = String.Format("ENGINE_ID={0} AND {1}={2} AND REV_NO={3}", ENGINE_ID, columnIdName, id, revision)
                                    'str4select = String.Format("ENGINE_ID={0} x", ENGINE_ID)
                                    'Debug.Print(str4select)

                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut13.Select(str4select)
                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut13.Select(str4select)
                                    rowCheckDuplicateResults13 = dtOut13.Select(str4select)


                                    If (Not duplicateExist) And rowCheckDuplicateResults13.Length < 1 Then
                                        dtOut13.Rows.Add(rowdata13)
                                        'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                        'Debug.Print(rowdata13.DATA)

                                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                                    Else

                                        'Dim id2mod As Integer = rowCheckDuplicateResults(0).Item("ID")


                                        For Each column As DataColumn In dtOut13.Columns
                                            'Debug.Print(column.ColumnName)
                                            If column.ColumnName = "DATA" Then
                                                Try
                                                    '------------------MODIFY HERE for each strMode
                                                    'dtOut13.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = rowdata13.Item(column)
                                                    dtOut13.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = strTemp4field
                                                Catch ex As System.Data.ReadOnlyException

                                                End Try
                                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray

                                            End If
                                        Next column




                                    End If

                                ElseIf category = 2 And datatype = 1 Then
                                    'Dim daOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                                    'Dim dtOut1 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData

                                    'dtOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                                    Dim columnIdName As String = "TRACE_COLUMNS_ID"
                                    'Dim rowdata As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                                    'rowdata = dtOut1.NewRow()

                                    Dim duplicateExist As Boolean = False

                                    Try
                                        rowdata21.Item("ENGINE_ID") = ENGINE_ID
                                        rowdata21.Item(columnIdName) = id
                                        rowdata21.Item("REV_NO") = revision
                                        rowdata21.Item("DATA") = strTemp4field

                                        'Debug.Print(pos)
                                        'Debug.Print(strTemp4field)
                                        'Debug.Print("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                                    Catch ex As System.ArgumentException
                                        Debug.Print(ex.Message)
                                    Catch ex As System.Data.ConstraintException
                                        duplicateExist = True
                                    End Try
                                    Dim str4select As String

                                    'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                    str4select = String.Format("ENGINE_ID={0} AND {1}={2} AND REV_NO={3}", ENGINE_ID, columnIdName, id, revision)
                                    'str4select = String.Format("ENGINE_ID={0} x", ENGINE_ID)
                                    'Debug.Print(str4select)

                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut21.Select(str4select)
                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut21.Select(str4select)
                                    rowCheckDuplicateResults21 = dtOut21.Select(str4select)


                                    If (Not duplicateExist) And rowCheckDuplicateResults21.Length < 1 Then
                                        dtOut21.Rows.Add(rowdata21)
                                        'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                        'Debug.Print(rowdata21.DATA)

                                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                                    Else

                                        'Dim id2mod As Integer = rowCheckDuplicateResults(0).Item("ID")


                                        For Each column As DataColumn In dtOut21.Columns
                                            'Debug.Print(column.ColumnName)
                                            If column.ColumnName = "DATA" Then
                                                Try
                                                    '------------------MODIFY HERE for each strMode
                                                    'dtOut21.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = rowdata21.Item(column)
                                                    dtOut21.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = strTemp4field
                                                Catch ex As System.Data.ReadOnlyException

                                                End Try
                                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray

                                            End If
                                        Next column




                                    End If
                                ElseIf category = 2 And datatype = 2 Then
                                    'Dim daOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                                    'Dim dtOut1 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData

                                    'dtOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                                    Dim columnIdName As String = "TRACE_COLUMNS_ID"
                                    'Dim rowdata As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                                    'rowdata = dtOut1.NewRow()

                                    Dim duplicateExist As Boolean = False

                                    Try
                                        rowdata22.Item("ENGINE_ID") = ENGINE_ID
                                        rowdata22.Item(columnIdName) = id
                                        rowdata22.Item("REV_NO") = revision
                                        rowdata22.Item("DATA") = strTemp4field

                                        'Debug.Print(pos)
                                        'Debug.Print(strTemp4field)
                                        'Debug.Print("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                                    Catch ex As System.ArgumentException
                                        Debug.Print(ex.Message)
                                    Catch ex As System.Data.ConstraintException
                                        duplicateExist = True
                                    End Try
                                    Dim str4select As String

                                    'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                    str4select = String.Format("ENGINE_ID={0} AND {1}={2} AND REV_NO={3}", ENGINE_ID, columnIdName, id, revision)
                                    'str4select = String.Format("ENGINE_ID={0} x", ENGINE_ID)
                                    'Debug.Print(str4select)

                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut22.Select(str4select)
                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut22.Select(str4select)
                                    rowCheckDuplicateResults22 = dtOut22.Select(str4select)


                                    If (Not duplicateExist) And rowCheckDuplicateResults22.Length < 1 Then
                                        dtOut22.Rows.Add(rowdata22)
                                        'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                        'Debug.Print(rowdata22.DATA)

                                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                                    Else

                                        'Dim id2mod As Integer = rowCheckDuplicateResults(0).Item("ID")


                                        For Each column As DataColumn In dtOut22.Columns
                                            'Debug.Print(column.ColumnName)
                                            If column.ColumnName = "DATA" Then
                                                Try
                                                    '------------------MODIFY HERE for each strMode
                                                    'dtOut22.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = rowdata22.Item(column)
                                                    dtOut22.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = strTemp4field
                                                Catch ex As System.Data.ReadOnlyException

                                                End Try
                                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray

                                            End If
                                        Next column




                                    End If


                                ElseIf category = 2 And datatype = 3 Then
                                    'Dim daOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
                                    'Dim dtOut1 As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData

                                    'dtOut1 = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
                                    Dim columnIdName As String = "TRACE_COLUMNS_ID"
                                    'Dim rowdata As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
                                    'rowdata = dtOut1.NewRow()

                                    Dim duplicateExist As Boolean = False

                                    Try
                                        rowdata23.Item("ENGINE_ID") = ENGINE_ID
                                        rowdata23.Item(columnIdName) = id
                                        rowdata23.Item("REV_NO") = revision
                                        rowdata23.Item("DATA") = strTemp4field

                                        'Debug.Print(pos)
                                        'Debug.Print(strTemp4field)
                                        'Debug.Print("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$")
                                    Catch ex As System.ArgumentException
                                        Debug.Print(ex.Message)
                                    Catch ex As System.Data.ConstraintException
                                        duplicateExist = True
                                    End Try
                                    Dim str4select As String

                                    'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                    str4select = String.Format("ENGINE_ID={0} AND {1}={2} AND REV_NO={3}", ENGINE_ID, columnIdName, id, revision)
                                    'str4select = String.Format("ENGINE_ID={0} x", ENGINE_ID)
                                    'Debug.Print(str4select)

                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut23.Select(str4select)
                                    'Dim rowCheckDuplicateResults() As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow = dtOut23.Select(str4select)
                                    rowCheckDuplicateResults23 = dtOut23.Select(str4select)


                                    If (Not duplicateExist) And rowCheckDuplicateResults23.Length < 1 Then
                                        dtOut23.Rows.Add(rowdata23)
                                        'Debug.Print("sssssssssssssssssssssssssssssssssssssssssssssssssss")
                                        'Debug.Print(rowdata23.DATA)

                                        'datemp.Update(dtEngineList.Select(Nothing, Nothing, DataViewRowState.Added))
                                    Else

                                        'Dim id2mod As Integer = rowCheckDuplicateResults(0).Item("ID")


                                        For Each column As DataColumn In dtOut23.Columns
                                            'Debug.Print(column.ColumnName)
                                            If column.ColumnName = "DATA" Then
                                                Try
                                                    '------------------MODIFY HERE for each strMode
                                                    'dtOut23.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = rowdata23.Item(column)
                                                    dtOut23.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(ENGINE_ID, id, revision).Item(column) = strTemp4field
                                                Catch ex As System.Data.ReadOnlyException

                                                End Try
                                                'For Each item In dtEngineList.Rows(rowResults(0).Item("ID")).ItemArray

                                            End If
                                        Next column




                                    End If



                                End If



                            End If
                            'value are for trace/working


                        Next
                        daOut11.Update(dtOut11.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        daOut11.Update(dtOut11.Select(Nothing, Nothing, DataViewRowState.Added))

                        daOut12.Update(dtOut12.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        daOut12.Update(dtOut12.Select(Nothing, Nothing, DataViewRowState.Added))

                        daOut13.Update(dtOut13.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        daOut13.Update(dtOut13.Select(Nothing, Nothing, DataViewRowState.Added))

                        daOut21.Update(dtOut21.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        daOut21.Update(dtOut21.Select(Nothing, Nothing, DataViewRowState.Added))

                        daOut22.Update(dtOut22.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        daOut22.Update(dtOut22.Select(Nothing, Nothing, DataViewRowState.Added))

                        daOut23.Update(dtOut23.Select(Nothing, Nothing, DataViewRowState.ModifiedCurrent))
                        daOut23.Update(dtOut23.Select(Nothing, Nothing, DataViewRowState.Added))


                        'Debug.Print(Environment.NewLine & "----------------------------------------------------" & Environment.NewLine & strMsg)


                        'MsgBox(ENGINE_ID)
                    End If


                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    " is invalid.  Skipping")
                End Try


            End While

            'Debug.Print(Environment.NewLine & "----------------------------------------------------" & Environment.NewLine & strMsg)

            Me.DataGridView1.DataSource = dtEngineList
        End Using

        'Dim daTemp As iemt_pdt_es01_developmentDataSetTableAdapters
        'daTemp = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_ENGINE_MAPPINGTableAdapter

        'Dim dsTemp2 As New DataSet
        'dsTemp2 = New iemt_pdt_es01_developmentDataSet
        'dsTemp2.Tables.Add(dtEngineList)
        'iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable()








        'Me.DataGridView1.DataSource = dtEngineList
        'Me.DataGridView3.DataSource = dsTemp.Tables("IMPORT_ENGINE_MAPPING")
    End Sub


    Sub add2tables(ByVal pos As Integer, ByVal value As String, ByRef dtTemp As DataTable)
        Dim dtEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
        'Dim dtTemp2 As iemt_pdt_es01_developmentDataSet.IMPORT_CELL_MAPPINGDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_CELL_MAPPINGTableAdapter().GetData
        'Dim query = From ENGINE In Me.DataSet1.ENGINE_LIST Select ID

        dtTemp.Rows.Add(pos, value)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dtEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData

        Dim rowResults() As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow = dtEngineList.Select()


        Dim strOut As String = ""

        For Each row In rowResults
            strOut &= row.ID & Environment.NewLine
        Next row
        MsgBox(strOut)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim modes As String() = New String() {"regexp", "showdata ENGINE_LIST", "showdata x"}
        Dim mode As String
        mode = modes(2)

        If mode = modes(0) Then
            Dim stringsIn As String() = Split(TextBox1.Text, Environment.NewLine)
            'TextBox2.Text = String.Format(stringsIn(1), stringsIn(0))

            TextBox2.Text = Strings.Format(CULng(stringsIn(0)), stringsIn(1))
        ElseIf mode = modes(1) Then
            Dim dtTemp As iemt_pdt_es01_developmentDataSet.ENGINE_LISTDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData
            Me.DataGridView1.DataSource = dtTemp

        ElseIf mode = modes(2) Then
            Dim dtTemp As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRDataTable = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter().GetData
            Me.DataGridView1.DataSource = dtTemp
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Function getEngineListID_from_EngineNo(ByRef ENGINE_NO As String) As Integer
        Dim id As Integer

        Dim dtEngineList = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter().GetData

        Dim rows() As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow = dtEngineList.Select("ENGINE_NO='" & ENGINE_NO & "'")

        If rows.Length < 1 Then
            MsgBox("ENGINE_NO='" & ENGINE_NO & "'")
        End If

        id = -999
        Try
            id = CInt(rows.First.Item("ID"))
            'ENGINE_ID = rows.First.ID

        Catch ex As System.InvalidOperationException

        End Try

        getEngineListID_from_EngineNo = id

    End Function
End Class
