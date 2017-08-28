Public Class frmShortBlockSerialNo_Search

    Private Sub frmShortBlockSerialNo_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.FOR_CHECK_LIST_BOX' table. You can move, or remove it, as needed.
        'Try
        '    rbnCylenderBlock.Checked = True
        '    checkRadio(False)

        'Catch ex As Exception

        'End Try

        btnMainMenu.Location = New Point(Panel1.Width / 1.3, 22)

    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim taTraceDataSTR As New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
        Dim frmSBS As frmShortBlockSerialNo_Show
        Try
            If Not modValidate.ValidationParamSet.SHORT_BLOCK_SERIAL_NO.CheckFormat(txtSerialNo.Text) Then
                Exit Sub
            End If

            If taTraceDataSTR.ScalarQueryFindShortBlockSerialNo(txtSerialNo.Text) > 0 Then

                frmSBS = New frmShortBlockSerialNo_Show
                frmSBS.pp_sbsSeritalNo = txtSerialNo.Text
                'frmSBS.ShowDialog()
                If frmSBS.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                    Me.DialogResult = Windows.Forms.DialogResult.Abort
                    Me.Close()
                End If
            Else
                MsgBox("Short Block Serial No. " & txtSerialNo.Text & " not exit.")
                txtSerialNo.Focus()
            End If
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try
    End Sub

    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Me.Close()
    End Sub

End Class