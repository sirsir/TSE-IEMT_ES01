﻿Public Class frmSelectDataType

    Private frmWD As frmSelectWorkingDataType
    Public Property pp_sdtENGINE_NO As String

    Private Sub frmSelectDataType_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        Try

            'MsgBox(e.KeyData)
            Select Case e.KeyData
                Case Keys.F1
                    'MsgBox("ddd")
                    Button1_Click(sender, e)
                Case Keys.F2
                    'MsgBox("ddd")
                    Button2_Click(sender, e)
                Case Keys.F3
                    Button3_Click(sender, e)
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

        Button1.BackColor = Color.Blue
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.Orange

        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.White

        'With Me.Panel4LabelHeading.LabelHeading
        With Me.LabelHeading
            .AutoSize = False

            .TextAlign = ContentAlignment.MiddleCenter



            '.BackColor = Color.FromArgb(0, 180, 180)
            '.ForeColor = Color.FromArgb(255, 255, 255)

            .Width = Me.Width * 0.8

            '.Height = .Height * 1.8
            '.Margin = New System.Windows.Forms.Padding(.Height * 0)
            '.Size = New System.Drawing.Size(.Width, .Height * 3)






            .Top = Me.Height * 0.1
            .Height = Me.Height * 0.12
            .Left = (Me.Width - .Width) / 2

            '.Margin = New Padding(0, .Height * 0.5, 0, 0)
        End With


        With Me.TableLayoutPanel1
            .Width = Me.LabelHeading.Width
            .Top = Me.LabelHeading.Top + Me.LabelHeading.Height + Me.Height * 0.1
            '.Left = Me.TextBoxHeading.Left
            .Left = (Me.Width - .Width) / 2
        End With


        'Me.TextBoxHeading
    End Sub

    Private Sub frmSelectDataType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Me.Text = "DATA TYPE"

            'ButtonOK.Visible = False
            InitializeControls()

            'show bottom buttons
            Dim hCtrls As New Hashtable
            'hCtrls("ButtonOK") = 0.5
            hCtrls("ButtonMAINMENU") = 0.9
            hCtrls("ButtonCANCEL") = 0.7
            'hCtrls("ButtonPRINT") = 0.7
            'hCtrls("GroupBoxSELECTBY") = 0.1

            ShowOnlyControls(hCtrls)

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'GlobalVariables.in_datatype = "production data"
        Try
            modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST
            'frmProductionData.Show()

            Dim frm As New frmProductionData
            If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Me.Close()
            End If

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            'frmWD = New frmSelectWorkingDataType

            'frmWD.pp_wdENGINE_NO = pp_sdtENGINE_NO

            'If frmWD.ShowDialog() = Windows.Forms.DialogResult.Abort Then
            '    Me.DialogResult = Windows.Forms.DialogResult.Abort
            '    Me.Close()
            'End If


            'Me.Visible = False
            Dim frmWD = New frmSelectWorkingDataType
            If frmWD.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Me.Close()
            End If

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Try

            'frmTraceAbilityData_Show.Show()
            Dim frm As New frmTraceAbilityData_Show
            If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Me.Close()
            End If

            'Me.Close()

        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try

    End Sub

End Class