﻿Public Class frmMainMenu

    Private Sub btnEngineNo_Click(sender As Object, e As EventArgs) Handles btnEngineNo.Click
        Try
            Dim frm As New frmSearchByEngineNo
            frm.ShowDialog()
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try

    End Sub

    Private Sub frmMainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyData
            Case Keys.F1
                btnEngineNo_Click(sender, e)
            Case Keys.F2
                btnModelCode_Click(sender, e)
            Case Keys.F3
                btnProductionDate_Click(sender, e)
            Case Keys.F4
                btnSerialNo_Click(sender, e)
            Case Keys.F5
                btnProductionDatePart_Click(sender, e)
            Case Keys.F6
                btnShortBlock_Click(sender, e)
            Case Keys.F7
                btnClose_Click(sender, e)

            Case Keys.F12
                frmClentSample.Show()
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            Close()
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        Try
            response = MsgBox("Do you want to close?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
            If response = MsgBoxResult.Yes Then
                'Me.Visible = False
            ElseIf response = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try

    End Sub

    Private Sub btnModelCode_Click(sender As Object, e As EventArgs) Handles btnModelCode.Click
        Try
            Dim frm As New frmSearchByModelCodeLotNo
            frm.ShowDialog()
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try

    End Sub

    Private Sub btnProductionDate_Click(sender As Object, e As EventArgs) Handles btnProductionDate.Click
        Try
            Dim frm As New frmSearchByAsmDate
            frm.ShowDialog()
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try

    End Sub

    Private Sub btnSerialNo_Click(sender As Object, e As EventArgs) Handles btnSerialNo.Click

        Try
            Dim frm As New frmSerialNo_PartNo_Search
            frm.ShowDialog()
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try
    End Sub

    Private Sub btnProductionDatePart_Click(sender As Object, e As EventArgs) Handles btnProductionDatePart.Click

        Try
            Dim frm As New frmDATE_PartNo_Search
            frm.ShowDialog()
        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try
    End Sub

    Private Sub btnShortBlock_Click(sender As Object, e As EventArgs) Handles btnShortBlock.Click

        Try
            Dim frm As New frmShortBlockSerialNo_Search
            frm.ShowDialog()

        Catch ex As Exception
            modLogger.HandleException(ex)
        End Try
    End Sub
End Class