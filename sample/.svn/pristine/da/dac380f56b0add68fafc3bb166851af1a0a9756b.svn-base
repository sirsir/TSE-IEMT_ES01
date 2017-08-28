Public Class ctrlPlcMessage
    Protected dr As Common.dsPAINT.dtPLC_MSTRow
    Private m_converter As New System.Text.UTF8Encoding

    Public Sub New(ByVal drPlc As Common.dsPAINT.dtPLC_MSTRow)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dr = drPlc
        smcPlc.NetworkAddress = CShort(dr.PLC_NET)
        smcPlc.NodeAddress = CShort(dr.PLC_NODE)
        smcPlc.UnitAddress = CShort(dr.PLC_UNIT)
        smcPlc.Active = True
        smcPlc.Update()
        lblError.Text = ""
        lblProcess.Text = dr.ProcessName & " : Stage Code " & dr.STAGE_CODE

    End Sub

    Public Sub WriteMessageToPlc()

        Dim intStatus As Integer
        Dim intLane As Integer
        Dim intSkit As Integer
        lblError.Text = ""
        Try
            Try
                intStatus = CInt(Me.txtStatus.Text)
                If intStatus < 0 Then
                    Throw New Exception()
                End If
            Catch iex As Exception
                lblError.Text = "Status must be not negative integer"
                Return
            End Try

            Try
                intSkit = CInt(Me.txtSkitNo.Text)
                If intSkit < 0 Then
                    Throw New Exception()
                End If
            Catch iex As Exception
                lblError.Text = "Skit must be not negative integer"
                Return
            End Try

            If Me.txtLane.Text.Length = 0 Then
                intLane = 0
            Else
                Try
                    intLane = CInt(Me.txtLane.Text)
                    If intLane < 0 Then
                        Throw New Exception()
                    End If
                Catch iex As Exception
                    lblError.Text = "Lane must be not negative integer"
                    Return
                End Try
            End If

            smcPlc.WriteMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, CLng(dr.READ_DM), dr.STAGE_CODE, OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BCD)
            smcPlc.WriteMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, CLng(dr.READ_DM + 1), intStatus, OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BCD)
            smcPlc.WriteMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, CLng(dr.READ_DM + 2), intSkit, OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BCD)
            smcPlc.WriteMemoryWordInteger(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, CLng(dr.READ_DM + 3), intLane, OMRON.Compolet.SYSMAC.SysmacPlc.DataTypes.BCD)
            smcPlc.WriteMemoryString(OMRON.Compolet.SYSMAC.SysmacCSBase.MemoryTypes.DM, CLng(dr.READ_DM + 4), Me.txtMessage.Text)

        Catch ex As Exception
            lblError.Text = ex.Message
            Return
        End Try
    End Sub

    Protected Sub ConcatByte(ByRef arrByte1() As Byte, ByVal arrByte2() As Byte)
        'Concat arrByte2 into arrByte1
        Dim tempByte1(arrByte1.Count + arrByte2.Count - 1) As Byte

        For index As Integer = 0 To arrByte1.Count - 1
            tempByte1(index) = arrByte1(index)
        Next

        For index As Integer = 0 To arrByte2.Count - 1
            tempByte1(index + arrByte1.Count) = arrByte2(index)
        Next

        arrByte1 = tempByte1
    End Sub

    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click
        Me.WriteMessageToPlc()
    End Sub

    Public Sub SetStatus(ByVal status As String)
        Me.txtStatus.Text = status
    End Sub

    Private Sub ctrlPlcMessage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
