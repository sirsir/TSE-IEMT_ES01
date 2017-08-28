Public Class frmServer

    Private m_datStartProgramWhen As DateTime
    Private m_objLogger As clsLogger
    Friend WithEvents m_objBkgImport As clsImportDataFile

    Private Const DATE_FORMAT As String = "yyyy/MM/dd HH:mm:ss"



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_objLogger = New clsLogger
        m_datStartProgramWhen = Now
        tmrRefreshLog.Enabled = False
        m_objBkgImport = New clsImportDataFile
        AddScrollListener()
    End Sub

    Private Sub frmServer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            Me.LOG_DATATableAdapter.Insert(clsDbLogger.nLogType.nImportLog, m_datStartProgramWhen, My.Computer.Name, Nothing, clsDbLogger.nLogLevel.nInfo _
                                               , "Program Ended")
        Catch ex As Exception

        End Try

        bkgClock.CancelAsync()
        bkgClock.Dispose()

        m_objBkgImport.CancelAsync()
        m_objBkgImport.Dispose()

        System.GC.Collect()
        Me.Dispose()
    End Sub

    Private Sub frmServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure to exit program?", MsgBoxStyle.YesNo + vbQuestion) <> MsgBoxResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub frmServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            bkgClock.RunWorkerAsync()
            Threading.Thread.Sleep(1000)
            Me.OCCDATEDataGridViewTextBoxColumn.DefaultCellStyle.Format = DATE_FORMAT

            tmrRefreshLog.Enabled = True
            m_objBkgImport.RunWorkerAsync()
            Me.LOG_DATATableAdapter.Insert(clsDbLogger.nLogType.nImportLog, m_datStartProgramWhen, My.Computer.Name, Nothing, clsDbLogger.nLogLevel.nInfo _
                                           , "Program Started")
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try

    End Sub

    Private Sub tmrRefreshLog_Tick(sender As Object, e As EventArgs) Handles tmrRefreshLog.Tick
        tmrRefreshLog.Stop()
        Try
            'TODO: This line of code loads data into the 'Iemt_pdt_es01_developmentDataSet.LOG_DATA' table. You can move, or remove it, as needed.
            Me.LOG_DATATableAdapter.FillByOccDateLogTypeLogLevel(Me.Iemt_pdt_es01_developmentDataSet.LOG_DATA _
                                                           , m_datStartProgramWhen _
                                                           , clsDbLogger.nLogType.nImportLog _
                                                           , clsDbLogger.nLogLevel.nInfo)

        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        Finally
            tmrRefreshLog.Start()
        End Try
    End Sub

    Private Sub bkgClock_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkgClock.DoWork
        While Not bkgClock.CancellationPending
            Try
                bkgClock.ReportProgress(0)
            Catch ex As Exception
                m_objLogger.AppendLog(ex)
            Finally
                Threading.Thread.Sleep(1000)
            End Try
        End While
    End Sub

    Private Sub bkgClock_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bkgClock.ProgressChanged
        Try
            Me.lblDateTime.Text = Now.ToString(DATE_FORMAT)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
         Me.Close()
    End Sub

    Private Sub DataGridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDown
        Try

        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub

    Private Sub DataGridView1_MouseUp(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseUp
        Try
            tmrRefreshLog.Start()
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub

    'Private Sub DataGridView1_Scroll(sender As Object, e As ScrollEventArgs) Handles DataGridView1.Scroll
    '    Try
    '        tmrRefreshLog.Stop()
    '        Debug.WriteLine(e.Type.ToString)
    '        If e.Type = ScrollEventType.EndScroll Then
    '            tmrRefreshLog.Start()
    '        End If
    '    Catch ex As Exception
    '        m_objLogger.AppendLog(ex)
    '    End Try
    'End Sub

    Private Sub AddScrollListener()
        'HScrollBar scrollBar = dgv.Controls.OfType<HScrollBar>().First();
        Dim scrollBar As VScrollBar = Me.DataGridView1.Controls.OfType(Of VScrollBar).First()
        AddHandler scrollBar.Scroll, AddressOf ScrollBarEventHandler
    End Sub

    Private Sub ScrollBarEventHandler(sender As Object, e As ScrollEventArgs)
        Try
            tmrRefreshLog.Stop()
            'Debug.WriteLine(e.Type.ToString)
            If e.Type = ScrollEventType.EndScroll Then
                tmrRefreshLog.Start()
            End If
        Catch ex As Exception
            m_objLogger.AppendLog(ex)
        End Try
    End Sub

    '{
    '   HScrollBar scrollBar = dgv.Controls.OfType<HScrollBar>().First();
    '   scrollBar.Scroll += scrollEventHandler;
    '}
End Class