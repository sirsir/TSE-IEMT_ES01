Public Class clsGridToExcel

    Private m_objLogger As clsLogger
    Private m_strInsertValues As String
    Private m_dgv As DataGridView

    Public Sub New()
        m_objLogger = New clsLogger
    End Sub

    Public Sub WriteDataToExcel(ByVal dgv As DataGridView, ByVal strTemplateFileName As String, ByVal strOutputFileName As String)

        Dim strTemplatePath As String
        strTemplatePath = My.Computer.FileSystem.CombinePath(My.Application.Info.DirectoryPath, ".\Template") _
                                    & "\" & strTemplateFileName

        If Not My.Computer.FileSystem.FileExists(strTemplatePath) Then
            MsgBox("Template File """ & strTemplatePath & """Not Exist", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim fi As New IO.FileInfo(strOutputFileName)
        If Not fi.Directory.Exists Then
            My.Computer.FileSystem.CreateDirectory(fi.Directory.FullName)
        End If

        Dim strOutFullPath As String = strOutputFileName

        Dim blnWriteHeader As Boolean = False
        If Not My.Computer.FileSystem.FileExists(strOutFullPath) Then
            My.Computer.FileSystem.CopyFile(strTemplatePath, strOutFullPath)
        End If

        Dim sqlInsert As String = GetInsertHeader(dgv)
        Dim sqlValues As String = ""

        For i As Integer = 0 To dgv.RowCount - 1

            'Using MyConnection As New System.Data.OleDb.OleDbConnection _
            '                            ("provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & _
            '                            "'" & strOutFullPath & "';" & _
            '                            "Extended Properties=""Excel 8.0;HDR=YES""")
            sqlValues = GetInsertValues(dgv, i)
            Using MyConnection As New System.Data.OleDb.OleDbConnection _
                                        ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _
                                        "'" & strOutFullPath & "';" & _
                                        "Extended Properties=""Excel 12.0 Xml;HDR=YES""")
                MyConnection.Open()
                Using myCommand As New System.Data.OleDb.OleDbCommand()
                    myCommand.Connection = MyConnection
                    myCommand.CommandText = sqlInsert & sqlValues
                    m_objLogger.AppendLog(Me.GetType.Name, "WriteDataToExcel", "Insert Excel = " & sqlInsert & sqlValues, "Info")
                    myCommand.ExecuteNonQuery()
                End Using
            End Using
        Next
    End Sub

    Private Function GetInsertHeader(ByVal dgv As DataGridView) As String
        GetInsertHeader = "Insert into [DATA$] ("
        Dim j As Integer = 1
        Dim strNames As List(Of String) = (From column As DataGridViewColumn In dgv.Columns.Cast(Of DataGridViewColumn)() _
                                 Order By column.DisplayIndex Select column.Name).ToList
        For i As Integer = 0 To strNames.Count - 1
            If dgv.Columns(strNames(i)).Visible = True Then
                GetInsertHeader &= "F" & j & ","
                j += 1
            End If
        Next
        If Not j > 1 Then
            Throw New Exception("No data to export.")
        Else
            GetInsertHeader = GetInsertHeader.Remove(GetInsertHeader.Length - 1)
            GetInsertHeader &= ") values "
        End If
    End Function

    Private Function GetInsertValues(ByVal dgv As DataGridView, ByVal intRow As Integer) As String
        GetInsertValues = "("
        Dim j As Integer = 1
        Dim strNames As List(Of String) = (From column As DataGridViewColumn In dgv.Columns.Cast(Of DataGridViewColumn)() _
                                Order By column.DisplayIndex Select column.Name).ToList
        For i As Integer = 0 To strNames.Count - 1
            If dgv.Columns(strNames(i)).Visible = True Then
                GetInsertValues &= "'" & dgv.Item(dgv.Columns(strNames(i)).Index, intRow).FormattedValue & "',"
                j += 1
            End If
        Next
        GetInsertValues = GetInsertValues.Remove(GetInsertValues.Length - 1)
        GetInsertValues &= ") "
        
    End Function

    Private Function SetDefaultRemainingInsertValues(ByVal strLastValuesString As String) As String
        strLastValuesString = strLastValuesString.Replace("[E]", "0")
        strLastValuesString = strLastValuesString.Replace("[F]", "0")
        strLastValuesString = strLastValuesString.Replace("[G]", "0")
        strLastValuesString = strLastValuesString.Replace("[H]", "0")
        strLastValuesString = strLastValuesString.Replace("[I]", "0")
        strLastValuesString = strLastValuesString.Replace("[J]", "0")
        strLastValuesString = strLastValuesString.Replace("[K]", "0")
        strLastValuesString = strLastValuesString.Replace("[L]", "0")
        strLastValuesString = strLastValuesString.Replace("[M]", "0")
        strLastValuesString = strLastValuesString.Replace("[N]", "0")
        strLastValuesString = strLastValuesString.Replace("[O]", "0")
        strLastValuesString = strLastValuesString.Replace("[P]", "0")
        strLastValuesString = strLastValuesString.Replace("[Q]", "0")
        strLastValuesString = strLastValuesString.Replace("[R]", "0")
        strLastValuesString = strLastValuesString.Replace("[S]", "0")
        strLastValuesString = strLastValuesString.Replace("[T]", "0")
        strLastValuesString = strLastValuesString.Replace("[U]", "0")
        strLastValuesString = strLastValuesString.Replace("[V]", "0")
        Return strLastValuesString
    End Function
End Class
