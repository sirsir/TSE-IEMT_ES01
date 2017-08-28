Module modLogger

    Public g_objLogger As New clsLogger()

    Public Enum enumLogType
        eError
        eInfo
    End Enum

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : LogEntry
    '   Purpose         : General inteface for logging messages
    '   Created         : Danzler.S 2008/01/16
    '   Modified        :
    '
    '   Syntax          : 
    '
    '   Return Value    : 
    '   Example         :
    '
    '   Linked          : 
    '
    '--------------------------------------------------------------------------------------------------------
    Public Sub LogEntry(ByRef objSource As Object, ByVal sMethod As String, ByVal sEntry As String, Optional ByVal LogType As enumLogType = enumLogType.eInfo)
        ' If LogType = eLogType.eLT_Info Then Exit Sub

        Dim sMessage As String
        sMessage = "[" + Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]"
        sMessage &= vbTab & objSource.ToString
        sMessage &= vbTab & sEntry
        g_objLogger.AppendLog(sMessage, LogType.ToString)
    End Sub

    '--------------------------------------------------------------------------------------------------------
    '   Function Name   : LogException
    '   Purpose         : General inteface for logging messages
    '   Created         : Danzler.S 2008/01/16
    '   Modified        :
    '
    '   Syntax          : 
    ' 
    '   Return Value    : 
    '   Example         :
    '
    '   Linked          : 
    '
    '--------------------------------------------------------------------------------------------------------
    Public Sub LogException(ByRef ex As System.Exception)
        g_objLogger.AppendLog(ex)
    End Sub

    Public Sub HandleException(ByRef ex As System.Exception, Optional ByVal showMessage As Boolean = False)
        g_objLogger.AppendLog(ex)
        If showMessage Then
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End If

    End Sub
End Module
