Public Class clsDbLogger

#Region "Attribute"
    Private m_objLogData As iemt_pdt_es01_developmentDataSetTableAdapters.LOG_DATATableAdapter
    Private m_objLogger As clsLogger
#End Region

#Region "Enum"
    Public Enum nLogType
        nImportLog = 1
    End Enum

    Public Enum nLogLevel
        nInfo = 0
        nWarning = 1
        nError = 2
    End Enum
#End Region

#Region "Constructor"
    Public Sub New()
        m_objLogData = New iemt_pdt_es01_developmentDataSetTableAdapters.LOG_DATATableAdapter
        m_objLogger = New clsLogger
    End Sub
#End Region

#Region "Method"
    Public Sub InsertLog(ByVal logType As nLogType, ByVal logLevel As nLogLevel, ByVal message As String, Optional ByVal lineName As String = Nothing)
        Try
            m_objLogData.Insert(logType, Now, My.Computer.Name & ":" & Process.GetCurrentProcess().Id, Nothing, logLevel, message)
            m_objLogger.AppendLog(message, logType.ToString.Substring(1))
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub

    Public Sub InsertLog(ByVal logType As nLogType, ByVal ex As Exception, Optional ByVal lineName As String = Nothing)
        Try
            m_objLogData.Insert(logType, Now, My.Computer.Name & ":" & Process.GetCurrentProcess().Id, Nothing, nLogLevel.nError, ex.Message)
            m_objLogger.AppendLog(ex)
        Catch ex2 As Exception
            m_objLogger.AppendLog(ex2)
        End Try
    End Sub
#End Region

End Class
