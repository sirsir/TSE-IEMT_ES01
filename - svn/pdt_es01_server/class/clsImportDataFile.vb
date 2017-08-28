﻿Imports System.IO
Imports System.Text.RegularExpressions

Public Class clsImportDataFile
    Inherits System.ComponentModel.BackgroundWorker

#Region "Attribute"
    Private m_dsES As iemt_pdt_es01_developmentDataSet

    Private m_taManager As iemt_pdt_es01_developmentDataSetTableAdapters.TableAdapterManager

    Private m_taImportEngineMapping As iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_ENGINE_MAPPINGTableAdapter
    Private m_taImportWorkDataMapping As iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_WORKING_DATA_MAPPINGTableAdapter
    Private m_taImportTraceDataMapping As iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_TRACE_DATA_MAPPINGTableAdapter
    Private m_taWorkingColumn As iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_COLUMNSTableAdapter
    Private m_taWorkingType As iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_TYPETableAdapter
    Private m_taTraceColumn As iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_COLUMNSTableAdapter
    Private m_taEngineList As iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter
    Private m_taWorkingDataString As iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
    'Private m_taWorkingDataInt As iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_FLOATTableAdapter
    Private m_taWorkingDataFloat As iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_FLOATTableAdapter
    Private m_taWorkingDataDatetime As iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_DATETIMETableAdapter
    Private m_taTraceDataString As iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_STRTableAdapter
    'Private m_taTraceDataInt As iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_FLOATTableAdapter
    Private m_taTraceDataFloat As iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_FLOATTableAdapter
    Private m_taTraceDataDatetime As iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_DATETIMETableAdapter

    Private m_drEngineRow As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow

    Private m_astrFileNameList As ArrayList
    Private m_objDbLogger As clsDbLogger
    Private m_objLogger As clsLogger

    Private m_intCountAdd As Integer
    Private m_intCountUpdate As Integer
    Private m_intCountSkip As Integer
    Private m_intCountTotal As Integer
    Private m_blnNewMode As Boolean

    Private m_regNumeric As Regex
#End Region

#Region "Constant"
    Private mstrDateTimeFormat As String = "yyyyMMddHHmmss"
    Private ms_intImportStartColumn As Integer = 4
    Private datNull As DateTime = New DateTime(1753, 1, 1)
#End Region

#Region "Enum"
    Public Enum nDataCategory
        Working = 1
        Traceability = 2
    End Enum

    Public Enum nDataType
        nString = 1
        nFloat = 2
        nDateTime = 3
    End Enum
#End Region

#Region "Constructor/Destructor"
    Public Sub New()
        Me.WorkerSupportsCancellation = True
        Me.WorkerReportsProgress = True

        m_dsES = New iemt_pdt_es01_developmentDataSet

        m_taManager = New iemt_pdt_es01_developmentDataSetTableAdapters.TableAdapterManager

        m_taImportEngineMapping = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_ENGINE_MAPPINGTableAdapter
        m_taImportWorkDataMapping = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_WORKING_DATA_MAPPINGTableAdapter
        m_taImportTraceDataMapping = New iemt_pdt_es01_developmentDataSetTableAdapters.IMPORT_TRACE_DATA_MAPPINGTableAdapter
        m_taWorkingColumn = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_COLUMNSTableAdapter
        m_taWorkingType = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_TYPETableAdapter
        m_taTraceColumn = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_COLUMNSTableAdapter
        m_taEngineList = New iemt_pdt_es01_developmentDataSetTableAdapters.ENGINE_LISTTableAdapter
        m_taWorkingDataString = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_STRTableAdapter
        'm_taWorkingDataInt = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_FLOATTableAdapter
        m_taWorkingDataFloat = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_FLOATTableAdapter
        m_taWorkingDataDatetime = New iemt_pdt_es01_developmentDataSetTableAdapters.WORKING_DATA_DATETIMETableAdapter
        m_taTraceDataString = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_STRTableAdapter
        'm_taTraceDataInt = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_FLOATTableAdapter
        m_taTraceDataFloat = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_FLOATTableAdapter
        m_taTraceDataDatetime = New iemt_pdt_es01_developmentDataSetTableAdapters.TRACE_DATA_DATETIMETableAdapter

        m_taManager.ENGINE_LISTTableAdapter = m_taEngineList
        m_taManager.WORKING_DATA_STRTableAdapter = m_taWorkingDataString
        'm_taManager.WORKING_DATA_FLOATTableAdapter = m_taWorkingDataInt
        m_taManager.WORKING_DATA_FLOATTableAdapter = m_taWorkingDataFloat
        m_taManager.WORKING_DATA_DATETIMETableAdapter = m_taWorkingDataDatetime
        m_taManager.TRACE_DATA_STRTableAdapter = m_taTraceDataString
        'm_taManager.TRACE_DATA_FLOATTableAdapter = m_taTraceDataInt
        m_taManager.TRACE_DATA_FLOATTableAdapter = m_taTraceDataFloat
        m_taManager.TRACE_DATA_DATETIMETableAdapter = m_taTraceDataDatetime

        m_astrFileNameList = New ArrayList
        m_objDbLogger = New clsDbLogger
        m_objLogger = New clsLogger
        'm_regNumeric = New Regex(
        LoadMaster()
    End Sub
#End Region

#Region "Event"
    Private Sub clsImportDataFile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Me.DoWork
        Dim di As IO.DirectoryInfo
        Dim fileInf() As IO.FileInfo

        If Not My.Computer.FileSystem.DirectoryExists(My.Settings.WatchPath) Then
            MessageBox.Show(String.Format("Path ""{0}"" not exist, please recheck configuration and restart program", My.Settings.WatchPath))
            Return
        End If
        di = New IO.DirectoryInfo(My.Settings.WatchPath)

        While True
            Try
                fileInf = di.GetFiles("*.csv", SearchOption.AllDirectories)
                If fileInf.Length > 0 And Me.m_astrFileNameList.Count = 0 Then
                    For Each inf As FileInfo In fileInf
                        Me.m_astrFileNameList.Add(inf.FullName)
                    Next
                    m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                            , clsDbLogger.nLogLevel.nInfo _
                                            , "New Manual Import File Found")

                    While Me.m_astrFileNameList.Count > 0
                        Me.ImportDataFile()
                    End While
                End If
            Catch ex As Exception
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, ex)
            Finally
                Threading.Thread.Sleep(1000)
            End Try

        End While

    End Sub
#End Region

#Region "Method"
    Public Sub Init()
        'm_dsES.ENGINE_LIST.Clear()
        'm_dsES.WORKING_DATA_STR.Clear()
        'm_dtWorkingDataInt.Clear()
        'm_dtWorkingDataDatetime.Clear()
        'm_dtTraceDataString.Clear()
        'm_dtTraceDataInt.Clear()
        'm_dtTraceDataDatetime.Clear()

        m_dsES.Clear()
    End Sub

    Public Sub LoadMaster()
        'm_taImportEngineMapping.Fill(m_dsES.IMPORT_ENGINE_MAPPING)
        'm_taImportCellMapping.Fill(m_dtImportCellMapping)
        'm_taWorkingColumn.Fill(m_dtWorkingColumn)
        'm_taWorkingType.Fill(m_dtWorkingType)
        'm_taTraceColumn.Fill(m_dtTraceColumn)
        With m_dsES
            m_taImportEngineMapping.Fill(.IMPORT_ENGINE_MAPPING)
            m_taImportWorkDataMapping.Fill(.IMPORT_WORKING_DATA_MAPPING)
            m_taImportTraceDataMapping.Fill(.IMPORT_TRACE_DATA_MAPPING)
            m_taWorkingColumn.Fill(.WORKING_COLUMNS)
            m_taWorkingType.Fill(.WORKING_TYPE)
            m_taTraceColumn.Fill(.TRACE_COLUMNS)
        End With
    End Sub

    Public Sub ExtractFile(ByVal filePath As String)
        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nInfo, "Start Import: " & filePath)
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited
            MyReader.TrimWhiteSpace = False
            MyReader.Delimiters = New String() {","}
            Dim strCurrentRow As String()
            'Loop through all of the fields in the file. 
            'If any lines are corrupt, report an error and continue parsing. 

            'skip 1st line
            strCurrentRow = MyReader.ReadFields()
            'With m_dsES
            '    '.Clear()
            '    'LoadMaster()
            '    m_taWorkingDataString.Fill(.WORKING_DATA_STR)
            '    m_taWorkingDataInt.Fill(.WORKING_DATA_FLOAT)
            '    m_taWorkingDataDatetime.Fill(.WORKING_DATA_DATETIME)

            '    m_taTraceDataString.Fill(.TRACE_DATA_STR)
            '    m_taTraceDataInt.Fill(.TRACE_DATA_FLOAT)
            '    m_taTraceDataDatetime.Fill(.TRACE_DATA_DATETIME)

            '    m_taEngineList.Fill(.ENGINE_LIST)
            'End With

            While Not MyReader.EndOfData
                Try
                    strCurrentRow = MyReader.ReadFields()
                    m_intCountTotal += 1

                    'Step 01 Extract from ImportEngineMapping
                    If Not ExtractFromImportEngineMapping(strCurrentRow) Then
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nError, "Skip record [" & m_intCountTotal & "]")
                        Continue While
                    End If
                    'Step 02 Extract working data
                    If Not ExtractFromImportWorkingDataMapping(strCurrentRow) Then
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nError, "Skip record [" & m_intCountTotal & "]")
                        Continue While
                    End If
                    'Step 03 Extract trace data
                    If Not ExtractFromImportTraceDataMapping(strCurrentRow) Then
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nError, "Skip record [" & m_intCountTotal & "]")
                        Continue While
                    End If

                    m_taManager.UpdateAll(m_dsES)

                    If m_blnNewMode Then
                        m_intCountAdd += 1
                    Else
                        m_intCountUpdate += 1
                    End If
                Catch ex As Exception
                    m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, ex)
                End Try
            End While
            Dim strMessage As String = String.Format("Import Completed: Total {0} records, {1} records added, {2} records updated", m_intCountTotal, m_intCountAdd, m_intCountUpdate)
            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nInfo, strMessage)

        End Using
    End Sub

    Private Function ExtractFromImportEngineMapping(ByVal astrRowData() As String) As Boolean
        Dim strDataTemp As String
        Dim intEngineNoPosition As Integer
        Dim intEngineNoLength As Integer
        Dim strEngineNo As String = ""
        'Dim adrEngineList() As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow
        Dim drEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow
        Dim blnIsNew As Boolean

        'ENGINE_NO
        Dim drEngineNo() As iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGRow = m_dsES.IMPORT_ENGINE_MAPPING.Select("COLUMN_NAME=" & ValueForSQL("ENGINE_NO"))

        Debug.Assert(drEngineNo IsNot Nothing AndAlso drEngineNo.Length = 1)
        intEngineNoPosition = drEngineNo(0).POSITION + ms_intImportStartColumn
        intEngineNoLength = drEngineNo(0).LENGTH
        Debug.Assert(intEngineNoLength > 0)
        For i As Integer = 0 To intEngineNoLength - 1
            strEngineNo &= astrRowData(intEngineNoPosition + i)
        Next

        With m_dsES
            '.Clear()
            'LoadMaster()
            .WORKING_DATA_STR.Clear()
            '.WORKING_DATA_FLOAT.Clear()
            .WORKING_DATA_FLOAT.Clear()
            .WORKING_DATA_DATETIME.Clear()
            .TRACE_DATA_STR.Clear()
            '.TRACE_DATA_FLOAT.Clear()
            .TRACE_DATA_FLOAT.Clear()
            .TRACE_DATA_DATETIME.Clear()
            .ENGINE_LIST.Clear()

            m_taEngineList.FillByEngineNo(.ENGINE_LIST, strEngineNo)
            If .ENGINE_LIST IsNot Nothing AndAlso .ENGINE_LIST.Count > 0 Then
                blnIsNew = False
                m_blnNewMode = False
                drEngineList = .ENGINE_LIST(0)
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nInfo, "Update EngineNo [" & strEngineNo & "]")
            Else
                blnIsNew = True
                m_blnNewMode = True
                drEngineList = .ENGINE_LIST.NewENGINE_LISTRow
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nInfo, "Add EngineNo [" & strEngineNo & "]")

            End If

            m_taWorkingDataString.FillByEngineNo(.WORKING_DATA_STR, strEngineNo)
            'm_taWorkingDataInt.FillByEngineNo(.WORKING_DATA_FLOAT, strEngineNo)
            m_taWorkingDataFloat.FillByEngineNo(.WORKING_DATA_FLOAT, strEngineNo)
            m_taWorkingDataDatetime.FillByEngineNo(.WORKING_DATA_DATETIME, strEngineNo)

            m_taTraceDataString.FillByEngineNo(.TRACE_DATA_STR, strEngineNo)
            'm_taTraceDataInt.FillByEngineNo(.TRACE_DATA_FLOAT, strEngineNo)
            m_taTraceDataFloat.FillByEngineNo(.TRACE_DATA_FLOAT, strEngineNo)
            m_taTraceDataDatetime.FillByEngineNo(.TRACE_DATA_DATETIME, strEngineNo)
        End With

        Dim strTempPad As String
        For Each dr As iemt_pdt_es01_developmentDataSet.IMPORT_ENGINE_MAPPINGRow In m_dsES.IMPORT_ENGINE_MAPPING.Rows
            strDataTemp = ""
            strTempPad = ""


            If dr.POSITION + dr.LENGTH - 1 + ms_intImportStartColumn > astrRowData.Length - 1 Then
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Cannot read file at Position [" _
                                                    & dr.POSITION & "], LENGTH [ " _
                                                    & dr.LENGTH & "], COLUMN [ " _
                                                    & dr.COLUMN_NAME _
                                                    & "]. Record field count [" & astrRowData.Length & "].")
                Return False
            End If

            Select Case dr.DATA_TYPE
                Case nDataType.nString
                    For i As Integer = 0 To dr.LENGTH - 1
                        strDataTemp &= astrRowData(dr.POSITION + i + ms_intImportStartColumn)
                    Next
                    If dr.COLUMN_REGEX <> "" Then
                        Dim rgxCheck As New Regex(dr.COLUMN_REGEX)
                        If rgxCheck.IsMatch(strDataTemp) Then
                            drEngineList.Item(dr.COLUMN_NAME) = strDataTemp
                        Else
                            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid string value [" & strDataTemp & "] in " _
                                                   & dr.COLUMN_NAME _
                                                   & " at position " & dr.POSITION)
                            If Not My.Settings.ImportIgnoreError Then
                                Return False
                            End If
                        End If
                    Else
                        drEngineList.Item(dr.COLUMN_NAME) = strDataTemp
                    End If

                Case nDataType.nFloat

                    For i As Integer = 0 To dr.LENGTH - 1
                        strDataTemp &= astrRowData(dr.POSITION + i + ms_intImportStartColumn)
                        strTempPad &= astrRowData(dr.POSITION + i + ms_intImportStartColumn).Trim.PadLeft(4, "0")
                    Next

                    Dim blnRegexPass As Boolean = False
                    If dr.COLUMN_REGEX <> "" Then
                        Dim rgxCheck As New Regex(dr.COLUMN_REGEX)
                        If rgxCheck.IsMatch(strDataTemp) Then
                            blnRegexPass = True
                        Else
                            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid numeric format [" & strDataTemp & "] in " _
                                                   & dr.COLUMN_NAME _
                                                   & " at position " & dr.POSITION)
                            If Not My.Settings.ImportIgnoreError Then
                                Return False
                            End If
                        End If
                    Else
                        blnRegexPass = True
                    End If

                    If blnRegexPass AndAlso Not IsNumeric(strDataTemp) Then
                        strDataTemp = strDataTemp
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                                , clsDbLogger.nLogLevel.nError _
                                                , "Invalid numeric value [" & strDataTemp & "] in " _
                                                    & dr.COLUMN_NAME _
                                                    & " at position " & dr.POSITION)
                        If Not My.Settings.ImportIgnoreError Then
                            Return False
                        End If
                    Else
                        If dr.LENGTH = 2 Then
                            If strDataTemp.Substring(0, 1) = "1" Then
                                strDataTemp = "-" & strDataTemp.Substring(1)
                            End If
                        End If
                        drEngineList.Item(dr.COLUMN_NAME) = CDbl(strDataTemp) * CDbl(dr.FORMAT_STRING)
                    End If

                Case nDataType.nDateTime
                    For i As Integer = 0 To dr.LENGTH - 1
                        strDataTemp &= astrRowData(dr.POSITION + i + ms_intImportStartColumn)
                        strTempPad &= astrRowData(dr.POSITION + i + ms_intImportStartColumn).Trim.PadLeft(4, "0")
                    Next
                    Dim datTemp As DateTime = datNull
                    Try
                        datTemp = DateTime.ParseExact(strTempPad.Substring(0, mstrDateTimeFormat.Length), mstrDateTimeFormat, Nothing)
                    Catch ex As Exception
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid date/time value [" & strDataTemp & "] in " _
                                                   & dr.COLUMN_NAME _
                                                   & " at position " & dr.POSITION)
                        If Not My.Settings.ImportIgnoreError Then
                            Return False
                        End If
                    End Try
                    'If Date.Compare(datTemp, datNull) <> 0 Then
                    drEngineList.Item(dr.COLUMN_NAME) = datTemp
                    'End If
            End Select
        Next

        If blnIsNew Then
            drEngineList.CREATED_WHEN = Now
            m_dsES.ENGINE_LIST.AddENGINE_LISTRow(drEngineList)
        Else
            drEngineList.UPDATED_WHEN = Now
        End If

        'Set to use in other functions
        m_drEngineRow = drEngineList

        'Dim intResult As Integer
        'intResult = m_taEngineList.Update(m_dsES.ENGINE_LIST)

        'If intResult > 0 Then
        '    Return strEngineNo
        'Else
        '    Return True
        'End If
        Return True
    End Function

    Private Function ExtractFromImportWorkingDataMapping(ByVal astrRowData() As String) As Boolean
        Dim strDataTemp As String
        Dim strWhere As String = ""

        Dim drEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow

        Dim drWorkingDataStr As iemt_pdt_es01_developmentDataSet.WORKING_DATA_STRRow
        'Dim drWorkingDataInt As iemt_pdt_es01_developmentDataSet.WORKING_DATA_FLOATRow
        Dim drWorkingDataFloat As iemt_pdt_es01_developmentDataSet.WORKING_DATA_FLOATRow
        Dim drWorkingDataDatetime As iemt_pdt_es01_developmentDataSet.WORKING_DATA_DATETIMERow

        Dim blnIsNew As Boolean

        'Select by ENGINE_NO to find ENGINE_ID
        drEngineList = m_drEngineRow

        For Each drWorkingMapping As iemt_pdt_es01_developmentDataSet.IMPORT_WORKING_DATA_MAPPINGRow In m_dsES.IMPORT_WORKING_DATA_MAPPING.Rows
            strDataTemp = ""

            If drWorkingMapping.POSITION + drWorkingMapping.LENGTH - 1 + ms_intImportStartColumn > astrRowData.Length - 1 Then
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Cannot read file at Position [" _
                                                    & drWorkingMapping.POSITION & "], LENGTH [ " _
                                                    & drWorkingMapping.LENGTH & "], COLUMN [ " _
                                                    & drWorkingMapping.WORKING_COLUMNSRow.COLUMN_NAME _
                                                    & "]. Record field count [" & astrRowData.Length & "].")
                Return False
            End If

            Select Case drWorkingMapping.WORKING_COLUMNSRow.DATA_TYPE
                Case nDataType.nString
                    For i As Integer = 0 To drWorkingMapping.LENGTH - 1
                        strDataTemp &= astrRowData(drWorkingMapping.POSITION + i + ms_intImportStartColumn)
                    Next

                    Dim blnRegexPass As Boolean = False
                    If drWorkingMapping.WORKING_COLUMNSRow.COLUMN_REGEX <> "" Then
                        Dim rgxCheck As New Regex(drWorkingMapping.WORKING_COLUMNSRow.COLUMN_REGEX)
                        If rgxCheck.IsMatch(strDataTemp) Then
                            blnRegexPass = True
                        Else
                            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid string value [" & strDataTemp & "] in " _
                                                   & drWorkingMapping.WORKING_COLUMNSRow.COLUMN_NAME _
                                                   & " at position " & drWorkingMapping.POSITION)
                            If Not My.Settings.ImportIgnoreError Then
                                Return False
                            End If
                        End If
                    Else
                        blnRegexPass = True
                    End If

                    drWorkingDataStr = m_dsES.WORKING_DATA_STR.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(drEngineList.ID _
                                                                                                        , drWorkingMapping.COLUMN_ID _
                                                                                                        , drWorkingMapping.REV)
                    If drWorkingDataStr IsNot Nothing Then
                        blnIsNew = False
                        drWorkingDataStr.DATA = strDataTemp
                        drWorkingDataStr.REVISE_DATE = Today
                    Else
                        blnIsNew = True
                        drWorkingDataStr = m_dsES.WORKING_DATA_STR.NewWORKING_DATA_STRRow
                        With drWorkingDataStr
                            .ENGINE_LISTRow = drEngineList
                            .WORKING_COLUMNS_ID = drWorkingMapping.COLUMN_ID
                            .REV_NO = drWorkingMapping.REV
                            .DATA = strDataTemp
                            .REVISE_DATE = Today
                        End With
                        m_dsES.WORKING_DATA_STR.AddWORKING_DATA_STRRow(drWorkingDataStr)
                    End If


                Case nDataType.nFloat

                    For i As Integer = 0 To drWorkingMapping.LENGTH - 1
                        strDataTemp &= astrRowData(drWorkingMapping.POSITION + i + ms_intImportStartColumn).Trim.PadLeft(4, "0")
                    Next

                    Dim blnRegexPass As Boolean = False
                    If drWorkingMapping.WORKING_COLUMNSRow.COLUMN_REGEX <> "" Then
                        Dim rgxCheck As New Regex(drWorkingMapping.WORKING_COLUMNSRow.COLUMN_REGEX)
                        If rgxCheck.IsMatch(strDataTemp) Then
                            blnRegexPass = True
                        Else
                            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid numeric value [" & strDataTemp & "] in " _
                                                   & drWorkingMapping.WORKING_COLUMNSRow.COLUMN_NAME _
                                                   & " at position " & drWorkingMapping.POSITION)
                            If Not My.Settings.ImportIgnoreError Then
                                Return False
                            End If
                        End If
                    Else
                        blnRegexPass = True
                    End If

                    If drWorkingMapping.LENGTH = 2 Then
                        If strDataTemp.Substring(0, 1) = "1" Then
                            strDataTemp = "-" & strDataTemp.Substring(1)
                        End If
                    End If

                    'drWorkingDataInt = m_dsES.WORKING_DATA_FLOAT.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(drEngineList.ID _
                    drWorkingDataFloat = m_dsES.WORKING_DATA_FLOAT.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(drEngineList.ID _
                                                                                                       , drWorkingMapping.COLUMN_ID _
                                                                                                       , drWorkingMapping.REV)
                    If Not IsNumeric(strDataTemp) Then
                        strDataTemp = strDataTemp
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                                , clsDbLogger.nLogLevel.nError _
                                                , "Invalid numeric value [" & strDataTemp & "] in " _
                                                    & drWorkingMapping.WORKING_COLUMNSRow.COLUMN_NAME _
                                                    & " at position " & drWorkingMapping.POSITION)
                        If Not My.Settings.ImportIgnoreError Then
                            Return False
                        End If
                    Else
                        If drWorkingDataFloat IsNot Nothing Then
                            blnIsNew = False
                            drWorkingDataFloat.DATA = CDbl(strDataTemp) * CDbl(drWorkingMapping.WORKING_COLUMNSRow.FORMAT_STRING)
                            drWorkingDataFloat.REVISE_DATE = Today
                        Else
                            blnIsNew = True
                            drWorkingDataFloat = m_dsES.WORKING_DATA_FLOAT.NewWORKING_DATA_FLOATRow
                            With drWorkingDataFloat
                                .ENGINE_LISTRow = drEngineList
                                .WORKING_COLUMNS_ID = drWorkingMapping.COLUMN_ID
                                .REV_NO = drWorkingMapping.REV
                                .DATA = CDbl(strDataTemp) * CDbl(drWorkingMapping.WORKING_COLUMNSRow.FORMAT_STRING)
                                .REVISE_DATE = Today
                            End With
                            m_dsES.WORKING_DATA_FLOAT.AddWORKING_DATA_FLOATRow(drWorkingDataFloat)
                        End If
                    End If

                Case nDataType.nDateTime

                    For i As Integer = 0 To drWorkingMapping.LENGTH - 1
                        strDataTemp &= astrRowData(drWorkingMapping.POSITION + i + ms_intImportStartColumn).Trim.PadLeft(4, "0")
                    Next

                    Dim datTemp As DateTime = datNull
                    Try
                        datTemp = DateTime.ParseExact(strDataTemp.Substring(0, mstrDateTimeFormat.Length), mstrDateTimeFormat, Nothing)
                    Catch ex As Exception
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                                , clsDbLogger.nLogLevel.nError _
                                                , "Invalid date/time value [" & strDataTemp & "] in " _
                                                    & drWorkingMapping.WORKING_COLUMNSRow.COLUMN_NAME _
                                                    & " at position " & drWorkingMapping.POSITION)
                        If Not My.Settings.ImportIgnoreError Then
                            Return False
                        End If
                    End Try

                    'If Date.Compare(datTemp, datNull) <> 0 Then
                    drWorkingDataDatetime = m_dsES.WORKING_DATA_DATETIME.FindByENGINE_IDWORKING_COLUMNS_IDREV_NO(drEngineList.ID _
                                                                                                                           , drWorkingMapping.COLUMN_ID _
                                                                                                                           , drWorkingMapping.REV)
                    If drWorkingDataDatetime IsNot Nothing Then
                        blnIsNew = False
                        drWorkingDataDatetime.DATA = datTemp
                        drWorkingDataDatetime.REVISE_DATE = Today
                    Else
                        blnIsNew = True
                        drWorkingDataDatetime = m_dsES.WORKING_DATA_DATETIME.NewWORKING_DATA_DATETIMERow
                        With drWorkingDataDatetime
                            .ENGINE_LISTRow = drEngineList
                            .WORKING_COLUMNS_ID = drWorkingMapping.COLUMN_ID
                            .REV_NO = drWorkingMapping.REV
                            .DATA = datTemp
                            .REVISE_DATE = Today
                        End With
                        m_dsES.WORKING_DATA_DATETIME.AddWORKING_DATA_DATETIMERow(drWorkingDataDatetime)
                    End If
                    'End If

            End Select
        Next

        Return True
    End Function

    Private Function ExtractFromImportTraceDataMapping(ByVal astrRowData() As String) As Boolean
        Dim strDataTemp As String
        Dim strWhere As String = ""

        Dim drEngineList As iemt_pdt_es01_developmentDataSet.ENGINE_LISTRow

        Dim drTraceDataStr As iemt_pdt_es01_developmentDataSet.TRACE_DATA_STRRow
        Dim drTraceDataFloat As iemt_pdt_es01_developmentDataSet.TRACE_DATA_FLOATRow
        Dim drTraceDataDatetime As iemt_pdt_es01_developmentDataSet.TRACE_DATA_DATETIMERow

        Dim blnIsNew As Boolean

        'Select by ENGINE_NO to find ENGINE_ID
        drEngineList = m_drEngineRow

        For Each drTraceMapping As iemt_pdt_es01_developmentDataSet.IMPORT_TRACE_DATA_MAPPINGRow In m_dsES.IMPORT_TRACE_DATA_MAPPING.Rows
            strDataTemp = ""

            If drTraceMapping.POSITION + drTraceMapping.LENGTH - 1 + ms_intImportStartColumn > astrRowData.Length - 1 Then
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Cannot read file at Position [" _
                                                    & drTraceMapping.POSITION & "], LENGTH [ " _
                                                    & drTraceMapping.LENGTH & "], COLUMN [ " _
                                                    & drTraceMapping.TRACE_COLUMNSRow.COLUMN_NAME _
                                                    & "]. Record field count [" & astrRowData.Length & "].")
                Return False
            End If

            Select Case drTraceMapping.TRACE_COLUMNSRow.DATA_TYPE
                Case nDataType.nString
                    For i As Integer = 0 To drTraceMapping.LENGTH - 1
                        strDataTemp &= astrRowData(drTraceMapping.POSITION + i + ms_intImportStartColumn)
                    Next

                    Dim blnRegexPass As Boolean = False
                    If drTraceMapping.TRACE_COLUMNSRow.COLUMN_REGEX <> "" Then
                        Dim rgxCheck As New Regex(drTraceMapping.TRACE_COLUMNSRow.COLUMN_REGEX)
                        If rgxCheck.IsMatch(strDataTemp) Then
                            blnRegexPass = True
                        Else
                            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid string value [" & strDataTemp & "] in " _
                                                   & drTraceMapping.TRACE_COLUMNSRow.COLUMN_NAME _
                                                   & " at position " & drTraceMapping.POSITION)
                            If Not My.Settings.ImportIgnoreError Then
                                Return False
                            End If
                        End If
                    Else
                        blnRegexPass = True
                    End If

                    drTraceDataStr = m_dsES.TRACE_DATA_STR.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(drEngineList.ID _
                                                                                                        , drTraceMapping.COLUMN_ID _
                                                                                                        , drTraceMapping.REV)
                    If drTraceDataStr IsNot Nothing Then
                        blnIsNew = False
                        drTraceDataStr.DATA = strDataTemp
                        drTraceDataStr.REVISE_DATE = Today
                    Else
                        blnIsNew = True
                        drTraceDataStr = m_dsES.TRACE_DATA_STR.NewTRACE_DATA_STRRow
                        With drTraceDataStr
                            .ENGINE_LISTRow = drEngineList
                            .TRACE_COLUMNS_ID = drTraceMapping.COLUMN_ID
                            .REV_NO = drTraceMapping.REV
                            .DATA = strDataTemp
                            .REVISE_DATE = Today
                        End With
                        m_dsES.TRACE_DATA_STR.AddTRACE_DATA_STRRow(drTraceDataStr)
                    End If


                Case nDataType.nFloat

                    For i As Integer = 0 To drTraceMapping.LENGTH - 1
                        strDataTemp &= astrRowData(drTraceMapping.POSITION + i + ms_intImportStartColumn).Trim.PadLeft(4, "0")
                    Next

                    Dim blnRegexPass As Boolean = False
                    If drTraceMapping.TRACE_COLUMNSRow.COLUMN_REGEX <> "" Then
                        Dim rgxCheck As New Regex(drTraceMapping.TRACE_COLUMNSRow.COLUMN_REGEX)
                        If rgxCheck.IsMatch(strDataTemp) Then
                            blnRegexPass = True
                        Else
                            m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                               , clsDbLogger.nLogLevel.nError _
                                               , "Invalid numeric value [" & strDataTemp & "] in " _
                                                   & drTraceMapping.TRACE_COLUMNSRow.COLUMN_NAME _
                                                   & " at position " & drTraceMapping.POSITION)
                            If Not My.Settings.ImportIgnoreError Then
                                Return False
                            End If
                        End If
                    Else
                        blnRegexPass = True
                    End If

                    If drTraceMapping.LENGTH = 2 Then
                        If strDataTemp.Substring(0, 1) = "1" Then
                            strDataTemp = "-" & strDataTemp.Substring(1)
                        End If
                    End If

                    If Not IsNumeric(strDataTemp) Then
                        strDataTemp = strDataTemp
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                                , clsDbLogger.nLogLevel.nError _
                                                , "Invalid numeric value [" & strDataTemp & "] in " _
                                                    & drTraceMapping.TRACE_COLUMNSRow.COLUMN_NAME _
                                                    & " at position " & drTraceMapping.POSITION)
                        If Not My.Settings.ImportIgnoreError Then
                            Return False
                        End If
                    Else
                        drTraceDataFloat = m_dsES.TRACE_DATA_FLOAT.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(drEngineList.ID _
                                                                                                        , drTraceMapping.COLUMN_ID _
                                                                                                        , drTraceMapping.REV)
                        If drTraceDataFloat IsNot Nothing Then
                            blnIsNew = False
                            drTraceDataFloat.DATA = CDbl(strDataTemp) * CDbl(drTraceMapping.TRACE_COLUMNSRow.FORMAT_STRING)
                            drTraceDataFloat.REVISE_DATE = Today
                        Else
                            blnIsNew = True
                            drTraceDataFloat = m_dsES.TRACE_DATA_FLOAT.NewTRACE_DATA_FLOATRow
                            With drTraceDataFloat
                                .ENGINE_LISTRow = drEngineList
                                .TRACE_COLUMNS_ID = drTraceMapping.COLUMN_ID
                                .REV_NO = drTraceMapping.REV
                                .DATA = CDbl(strDataTemp) * CDbl(drTraceMapping.TRACE_COLUMNSRow.FORMAT_STRING)
                                .REVISE_DATE = Today
                            End With
                            m_dsES.TRACE_DATA_FLOAT.AddTRACE_DATA_FLOATRow(drTraceDataFloat)
                        End If
                    End If



                Case nDataType.nDateTime

                    For i As Integer = 0 To drTraceMapping.LENGTH - 1
                        strDataTemp &= astrRowData(drTraceMapping.POSITION + i + ms_intImportStartColumn).Trim.PadLeft(4, "0")
                    Next

                    Dim datTemp As DateTime = datNull
                    Try
                        datTemp = DateTime.ParseExact(strDataTemp.Substring(0, mstrDateTimeFormat.Length), mstrDateTimeFormat, Nothing)
                    Catch ex As Exception
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog _
                                                , clsDbLogger.nLogLevel.nError _
                                                , "Invalid date/time value [" & strDataTemp & "] in " _
                                                    & drTraceMapping.TRACE_COLUMNSRow.COLUMN_NAME _
                                                    & " at position " & drTraceMapping.POSITION)
                        If Not My.Settings.ImportIgnoreError Then
                            Return False
                        End If
                    End Try

                    'If Date.Compare(datTemp, datNull) <> 0 Then
                    drTraceDataDatetime = m_dsES.TRACE_DATA_DATETIME.FindByENGINE_IDTRACE_COLUMNS_IDREV_NO(drEngineList.ID _
                                                                                                                           , drTraceMapping.COLUMN_ID _
                                                                                                                           , drTraceMapping.REV)
                    If drTraceDataDatetime IsNot Nothing Then
                        blnIsNew = False
                        drTraceDataDatetime.DATA = datTemp
                        drTraceDataDatetime.REVISE_DATE = Today
                    Else
                        blnIsNew = True
                        drTraceDataDatetime = m_dsES.TRACE_DATA_DATETIME.NewTRACE_DATA_DATETIMERow
                        With drTraceDataDatetime
                            .ENGINE_LISTRow = drEngineList
                            .TRACE_COLUMNS_ID = drTraceMapping.COLUMN_ID
                            .REV_NO = drTraceMapping.REV
                            .DATA = datTemp
                            .REVISE_DATE = Today
                        End With
                        m_dsES.TRACE_DATA_DATETIME.AddTRACE_DATA_DATETIMERow(drTraceDataDatetime)
                    End If
                    'End If

            End Select
        Next

        Return True
    End Function

    Private Sub ImportDataFile()
        Dim objLog As New iemt_pdt_es01_developmentDataSetTableAdapters.LOG_DATATableAdapter
        Dim intResult As Integer = 0
        m_intCountAdd = 0
        m_intCountUpdate = 0
        m_intCountSkip = 0
        m_intCountTotal = 0

        If Me.m_astrFileNameList.Count > 0 Then

            Dim strFileNameWithPath As String = Me.m_astrFileNameList(0).ToString
            Dim strFileName As String = strFileNameWithPath.Substring(My.Settings.WatchPath.Length + 1)
            Dim strFileRename As String = Format(Now, "yyyyMMddHHmmss") & strFileName
            Dim strFileRenameWithPath As String = My.Settings.WatchPath & "\" & strFileRename
            Dim strBackupName As String = My.Settings.BackupPath & "\" & Format(Now, "yyyyMMdd") & "\"
            If Not My.Computer.FileSystem.DirectoryExists(strBackupName) Then
                My.Computer.FileSystem.CreateDirectory(strBackupName)
            End If
            strBackupName += strFileRename

            'Dim theFile2 As FileStream = Nothing
            Dim bCheckPass As Boolean = False
            Dim bImportPass As Boolean = False
            Dim blnCanRead As Boolean = False

            Try
                Using theFile As New IO.FileStream(strFileNameWithPath, FileMode.Open, FileAccess.Read)
                    If Not theFile.CanRead Then
                        m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, clsDbLogger.nLogLevel.nError, "Cannot read the file")
                    Else
                        blnCanRead = True
                    End If
                End Using

                MoveFile(strFileNameWithPath, strFileRenameWithPath)

                If blnCanRead Then
                    Me.ExtractFile(strFileRenameWithPath)
                End If

                'Import complete, move file to backup
                Me.m_astrFileNameList.RemoveAt(0)
                MoveFile(strFileRenameWithPath, strBackupName)

            Catch ex As Exception
                'Import failed, move file to backup
                Me.m_astrFileNameList.RemoveAt(0)
                MoveFile(strFileRenameWithPath, strBackupName)
                m_objDbLogger.InsertLog(clsDbLogger.nLogType.nImportLog, ex)
            End Try

        End If
    End Sub

    Private Sub MoveFile(ByVal fromFile As String, ByVal toFile As String)
        If My.Computer.FileSystem.FileExists(fromFile) = True Then
            My.Computer.FileSystem.MoveFile(fromFile, toFile, True)
        End If
    End Sub

    Public Function ValueForSQL(ByVal varValue As Object, _
                            Optional ByVal varDelimiter As Object = Nothing, _
                            Optional ByVal blnSupportThLang As Boolean = False) As String
        On Error Resume Next
        Dim strResult As String
        Dim strText As String
        Dim vtType As VariantType

        strResult = "NULL"

        If Not IsNothing(varValue) AndAlso Not IsDBNull(varValue) Then
            vtType = VarType(varValue)

            If Trim(varValue) <> "" Then
                Select Case vtType
                    Case VariantType.String     'Kong change from vbString --> VariantType.String
                        strText = RTrim(varValue)
                        If Asc(Strings.Right(strText, 1)) = 0 Then
                            strText = Strings.Left(strText, Len(strText) - 1)
                        End If
                        If Not IsNothing(varDelimiter) Then
                            strText = strText.Split(varDelimiter)(0)
                        End If

                        strResult = "'" & Replace(strText, "'", "''") & "'"

                        If blnSupportThLang Then
                            strResult = "N" & strResult
                        End If
                    Case VariantType.Date       'Kong change from vbDate --> VariantType.Date
                        strResult = GetDateValueForSQL(varValue)
                        'Debug.Assert(False)  'please use GetDateValueForSQL(dt,cnn) instead.
                    Case VariantType.Boolean    'Kong change from vbBoolean --> VariantType.Boolean
                        strResult = IIf(varValue, "1", "0")
                    Case VariantType.Double     'Kong add for handle Double.NaN
                        If Not Double.IsNaN(varValue) Then
                            strResult = CType(varValue, String)
                        End If
                    Case Else
                        strResult = CType(varValue, String)
                End Select
            End If
        End If

        Return strResult
    End Function

    Public Function GetDateValueForSQL(ByVal varDateTime As Object) As String

        Const cstrDateFormatForSQL As String = "/MM/dd"

        Dim strText As String
        Dim strResult As String

        strResult = ""

        'If IsDBNull(varDateTime) Then
        If IsDBNull(varDateTime) OrElse IsNothing(varDateTime) Then 'Kong 20091109 : add "OrElse IsNothing(varDateTime)"
            strResult = "NULL"
        Else
            strText = CDate(varDateTime).Year & Format(varDateTime, cstrDateFormatForSQL)
            'strText = Replace(strText, " 12:00:00", "")

            strResult = "CONVERT(datetime, '" & strText & "',111)"
        End If

        Return strResult
    End Function

#End Region

End Class
