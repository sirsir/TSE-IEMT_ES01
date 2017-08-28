Module modGlobalVariables
    'Public in_engineNo As String = ""
    'Public in_datatype As String = ""
    'Public strIn1 As String = ""
    'Public strIn2 As String = ""
    'Public strIn3 As String = ""
    Public DATE_NULL As Date = #1/1/1753 12:00:01 PM#

    'Public DATE_NULL As Date = New DateTime(1753, 1, 1)
    Public Enum SEARCH_BY
        ENGINE_NO
        MODEL_CODE_LOT_NO
        LINE_ON_TIME__ASM_DATE
    End Enum

    Public Enum TABLE2SHOW
        ENGINE_LIST
        V_WORKING_DATA_STATIC
        ENGINE_LIST__ProductionDateSearch
    End Enum

    Public Enum DataType
        nString = 1
        nInteger = 2
        nDateTime = 3
    End Enum

    Public arrIn As New ArrayList()
    Public tabletype As New TABLE2SHOW

    Public workingtypeID As Integer
    Public workingtypeName As String

    Public searchBy As SEARCH_BY


    Public Sub reset()
        'in_engineNo = ""
        'in_modelNo = ""
        'In_lotNo = ""
        'in_datatype = ""
        'strIn1 = 0
        'strIn2 = 0
        'strIn1 = 0

        workingtypeID = Nothing
        arrIn.Clear()
    End Sub

#Region "temp"""
    

#End Region


End Module
