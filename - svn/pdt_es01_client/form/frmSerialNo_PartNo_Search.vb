﻿Public Class frmSerialNo_PartNo_Search

    Private Sub frmSerialNo_PartNo_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.FOR_CHECK_LIST_BOX' table. You can move, or remove it, as needed.
        'Dim lenthX As Integer = Panel1.Width / 2
        'label1.Location = new Point(x,y);
        Try
            rbnCylenderBlock.Checked = True
            checkRadio(False)

            'MsgBox(Panel1.Height)
            'btnOK.Location = New Point(Panel1.Width / 2.6, 22)
            btnMainMenu.Location = New Point(Panel1.Width / 1.2, 22)

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try

    End Sub

    Private Sub checkRadio(pCheck As Boolean)
        If pCheck Then
            chbConnRod1.Enabled = True
            chbConnRod2.Enabled = True
            chbConnRod4.Enabled = True
            chbConnRod3.Enabled = True

            chbConnRod1.Checked = True
        Else
            chbConnRod1.Enabled = False
            chbConnRod2.Enabled = False
            chbConnRod4.Enabled = False
            chbConnRod3.Enabled = False

            chbConnRod1.Checked = False
            chbConnRod2.Checked = False
            chbConnRod4.Checked = False
            chbConnRod3.Checked = False

        End If
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles rbnConnRod.Click
        checkRadio(True)
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles chbConnRod1.Click
        chbConnRod2.Checked = False
        chbConnRod4.Checked = False
        chbConnRod3.Checked = False
    End Sub

    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles chbConnRod2.Click
        chbConnRod1.Checked = False
        chbConnRod4.Checked = False
        chbConnRod3.Checked = False
    End Sub

    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles chbConnRod4.Click
        chbConnRod1.Checked = False
        chbConnRod2.Checked = False
        chbConnRod3.Checked = False
    End Sub

    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles chbConnRod3.Click
        chbConnRod2.Checked = False
        chbConnRod4.Checked = False
        chbConnRod1.Checked = False
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles rbnCylenderBlock.Click
        checkRadio(False)
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles rbnCylenderHead.Click
        checkRadio(False)
    End Sub

    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles rbnCrankShaft.Click
        checkRadio(False)
    End Sub

    Private Sub RadioButton5_Click(sender As Object, e As EventArgs) Handles rbnCamShaftIn.Click
        checkRadio(False)
    End Sub

    Private Sub RadioButton6_Click(sender As Object, e As EventArgs) Handles rbnCamShaftEx.Click
        checkRadio(False)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim taTraceDataSTR As New DataSet1TableAdapters.TRACE_DATA_STRTableAdapter
        Dim frmSPS As frmSerialNo_PartNo_Show
        Try

            If Not modValidate.ValidationParamSet.SERIAL_NO.CheckFormat(txtSerialNo.Text) Then
                Exit Sub
            End If

            If taTraceDataSTR.ScalarQueryFindSerialNo(txtSerialNo.Text) > 0 Then
                frmSPS = New frmSerialNo_PartNo_Show
                If rbnCylenderBlock.Checked Then
                    ' TRACE_COLUMNS_ID = 1
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 1
                ElseIf rbnCylenderHead.Checked Then
                    ' TRACE_COLUMNS_ID = 2
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 2
                ElseIf rbnCrankShaft.Checked Then
                    ' TRACE_COLUMNS_ID = 3
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 3
                ElseIf rbnCamShaftIn.Checked Then
                    ' TRACE_COLUMNS_ID = 8
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 8
                ElseIf rbnCamShaftEx.Checked Then
                    ' TRACE_COLUMNS_ID = 9
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 9
                ElseIf chbConnRod1.Checked Then
                    ' TRACE_COLUMNS_ID = 4
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 4
                ElseIf chbConnRod2.Checked Then
                    ' TRACE_COLUMNS_ID = 5
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 5
                ElseIf chbConnRod3.Checked Then
                    ' TRACE_COLUMNS_ID = 6
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 6
                ElseIf chbConnRod4.Checked Then
                    ' TRACE_COLUMNS_ID = 7
                    frmSPS.pp_spsTRACE_COLUMNS_ID = 7
                Else
                    frmSPS.pp_spsTRACE_COLUMNS_ID = Nothing
                End If

                If frmSPS.pp_spsTRACE_COLUMNS_ID <> Nothing Then

                    frmSPS.pp_spsSERIAL_NO = txtSerialNo.Text
                    If frmSPS.pp_spsSERIAL_NO <> Nothing Then

                        'frmSPS.ShowDialog()
                        If frmSPS.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                            Me.DialogResult = Windows.Forms.DialogResult.Abort
                            Me.Close()
                        End If
                        'Me.Close()
                    Else
                        MsgBox("Please input Serial No.")
                    End If

                Else
                    MsgBox("Please Select Past.")
                End If
            Else
                MsgBox("Serial No. " & txtSerialNo.Text & " not exit.")
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