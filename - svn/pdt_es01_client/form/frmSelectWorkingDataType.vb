Public Class frmSelectWorkingDataType

    

    Private m_dctMapping As Dictionary(Of String, Integer)
    'Private m_intSelectedId As Integer
    'Private frmShow As frmWorkingDataShow
    Private frmShow As frmWorkingData

    Private Sub frmSelectWorkingDataType_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        Try

            'MsgBox(e.KeyData)
            Select Case e.KeyData
                Case Keys.F1
                    'MsgBox("ddd")
                    'Button1_Click(sender, e)
                Case Keys.F2
                    'MsgBox("ddd")
                    'Button2_Click(sender, e)
                Case Keys.F3
                    'Button3_Click(sender, e)
                    'Case Keys.F4
                    '    btnSerialNo_Click(sender, e)
                    'Case Keys.F5
                    '    btnProductionDatePart_Click(sender, e)
                    'Case Keys.F6
                    '    btnShortBlock_Click(sender, e)
                    'Case Keys.F7
                    '    btnClose_Click(sender, e)
            End Select
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub


    Protected Overrides Sub moreShown()
        Me.LabelHeading.BackColor = Color.Yellow

        ButtonSELECT.BackColor = Color.Purple
        'Button2.BackColor = Color.Red
        'Button3.BackColor = Color.Orange

        ButtonSELECT.ForeColor = Color.White
        'Button2.ForeColor = Color.White
        'Button3.ForeColor = Color.White

        'With Me.Panel4LabelHeading.LabelHeading
        With Me.LabelHeading
            .Text = "WORKING DATA"
            .AutoSize = False

            .TextAlign = ContentAlignment.MiddleCenter



            .BackColor = Color.FromArgb(255, 128, 0)
            '.ForeColor = Color.FromArgb(255, 255, 255)

            .Width = Me.Width * 0.8

            '.Height = .Height * 1.8
            '.Margin = New System.Windows.Forms.Padding(.Height * 0)
            '.Size = New System.Drawing.Size(.Width, .Height * 3)






            .Top = Me.Height * 0.07
            .Height = Me.Height * 0.09
            .Left = (Me.Width - .Width) / 2

            '.Margin = New Padding(0, .Height * 0.5, 0, 0)
        End With


        With Me.TableLayoutPanel1
            .Width = Me.LabelHeading.Width
            .Top = Me.LabelHeading.Top + Me.LabelHeading.Height * 1.5
            '.Left = Me.TextBoxHeading.Left
            .Left = (.Parent.Width - .Width) / 2
        End With

        With Me.CheckedListBox1
            '.Width = Me.LabelHeading.Width
            '.Top = Me.LabelHeading.Top + Me.LabelHeading.Height + Me.Height * 0.1
            .Top = 0
            '.Left = Me.TextBoxHeading.Left
            .Left = (Me.Width - .Width) / 2
        End With


        'Me.TextBoxHeading
    End Sub

    Private Sub frmSelectWorkingDataType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Me.Text = "WORKING DATA"

            'ButtonOK.Visible = False
            InitializeControls()



            'SET CHECK LISTs
            modGlobalVariables.workingtypeID = -1
            modGlobalVariables.workingtypeName = ""
            m_dctMapping = New Dictionary(Of String, Integer)

            Dim m_taTemp As DataSet1TableAdapters.FOR_CHECK_LIST_BOXTableAdapter = New DataSet1TableAdapters.FOR_CHECK_LIST_BOXTableAdapter()
            Dim m_dtTemp As DataSet1.FOR_CHECK_LIST_BOXDataTable = New DataSet1.FOR_CHECK_LIST_BOXDataTable
            m_taTemp.Fill(m_dtTemp)
            SetClBoxDataSource(CheckedListBox1, m_dtTemp)
            'sender = sender


            'show bottom buttons
            Dim hCtrls As New Hashtable
            'hCtrls("ButtonOK") = 0.5
            hCtrls("ButtonSELECT") = 0.5
            hCtrls("ButtonMAINMENU") = 0.9
            hCtrls("ButtonCANCEL") = 0.7
            'hCtrls("ButtonPRINT") = 0.7
            'hCtrls("GroupBoxSELECTBY") = 0.1

            ShowOnlyControls(hCtrls)

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Protected Overrides Sub ButtonSELECT_Click(sender As Object, e As EventArgs)
        Try
            'If frmShow.pp_wdsWORKING_TYPE_ID <> Nothing Then
            '    frmShow.pp_wdsENGINE_NO = pp_wdENGINE_NO
            '    frmShow.Show()
            '    Me.Close()
            'End If

            If modGlobalVariables.workingtypeID <> Nothing Then
                'frmShow.pp_wdsENGINE_NO = pp_wdENGINE_NO
                'frmShow.Show()

                'Me.DialogResult = Windows.Forms.DialogResult.Abort

                Dim frm As New frmWorkingData
                If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                    Me.DialogResult = Windows.Forms.DialogResult.Abort
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Private Sub CheckedListBox1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        'frmShow = New frmWorkingData
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To Me.CheckedListBox1.Items.Count - 1 Step 1
                If i <> e.Index Then
                    Me.CheckedListBox1.SetItemChecked(i, False)
                End If
            Next i
            'm_intSelectedId = m_dctMapping(CheckedListBox1.SelectedItem)
            'frmShow.pp_wdsWORKING_TYPE_ID = m_intSelectedId
            modGlobalVariables.workingtypeID = m_dctMapping(CheckedListBox1.SelectedItem)
            modGlobalVariables.workingtypeName = CheckedListBox1.SelectedItem
        End If
    End Sub

    Private Sub SetClBoxDataSource(ByVal clb As CheckedListBox,
                 ByVal dt As DataTable)

        'Clear it
        clb.Items.Clear()

        'Fill it
        Dim x As Integer
        For x = 0 To dt.DefaultView.Count - 1
            clb.Items.Add(dt.Rows(x)("WORKING_TYPE_NAME"))
            If Not m_dctMapping.ContainsKey(dt.Rows(x)("WORKING_TYPE_NAME")) Then
                m_dctMapping.Add(dt.Rows(x)("WORKING_TYPE_NAME"), dt.Rows(x)("ID"))
            End If
        Next
        clb.BackColor = Me.BackColor
        clb.Size = clb.ClientSize

        'Dim maxWidth = 0
        'Dim height = 0
        'For Each c In clb.CheckedItems
        '    c.
        'Next()


    End Sub

   


End Class