Public Class frmSelectWorkingDataType
    Private m_dctMapping As Dictionary(Of String, Integer)
    'Private m_intSelectedId As Integer
    'Private frmShow As frmWorkingDataShow
    Private frmShow As frmWorkingData




    Public Property pp_wdENGINE_NO As String

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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
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

        End Try

    End Sub

    Private Sub frmSelectWorkingDataType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.FOR_CHECK_LIST_BOX' table. You can move, or remove it, as needed.
        Try
            modGlobalVariables.workingtypeID = -1
            modGlobalVariables.workingtypeName = ""
            m_dctMapping = New Dictionary(Of String, Integer)
            Me.FOR_CHECK_LIST_BOXTableAdapter.Fill(Me.DataSet1.FOR_CHECK_LIST_BOX)
            SetClBoxDataSource(Me.CheckedListBox1, Me.DataSet1.FOR_CHECK_LIST_BOX)
            'sender = sender
        Catch ex As Exception

        End Try

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
    End Sub

    Private Sub frmSelectWorkingDataType_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'frmMainMenu.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'If IsNothing(modGlobalVariables.lastHiddenForm) <> True Then
        '    modGlobalVariables.lastHiddenForm.Visible = True
        'Else
        '    frmMainMenu.Visible = True
        'End If

        Me.Close()
    End Sub
End Class