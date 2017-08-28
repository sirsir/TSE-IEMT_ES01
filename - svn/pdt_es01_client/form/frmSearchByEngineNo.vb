﻿Public Class frmSearchByEngineNo
    Private frmDataType As frmSelectDataType

    Private Sub frmSearchByEngineNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "ENGINE No. Search"

        'drawseparator()
        LabelHeading.Text = "Search by ENGINE No."

        'TextBoxIn1.Text = "NN0023"

        TextBoxIn1.Text = ""


        'MyBase.Load()
        InitializeControls()


        'show bottom buttons
        Dim hCtrls As New Hashtable
        hCtrls("ButtonOK") = 0.5
        hCtrls("ButtonMAINMENU") = 0.9


        ShowOnlyControls(hCtrls)

    End Sub


    Protected Overrides Sub ButtonOK_Click(sender As Object, e As EventArgs)
        Dim taEngineList As New DataSet1TableAdapters.ENGINE_LISTTableAdapter
        Try
            frmDataType = New frmSelectDataType

            'GlobalVariables.reset()
            modGlobalVariables.reset()

            'GlobalVariables.in_engineNo = TextBoxIn1.Text
            'modGlobalVariables.in_engineNo = TextBoxIn1.Text
            modGlobalVariables.arrIn.Add(TextBoxIn1.Text)
            modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.ENGINE_NO

            If Not modValidate.ValidationParamSet.ENGINE_NO.CheckFormat(TextBoxIn1.Text) Then
                Exit Sub
            End If

            If taEngineList.ScalarQueryFindEngineNo(TextBoxIn1.Text) > 0 Then
                frmDataType.pp_sdtENGINE_NO = TextBoxIn1.Text
                'frmDataType.Show()

                If frmDataType.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                    Me.DialogResult = Windows.Forms.DialogResult.Abort
                    Me.Close()
                End If
            Else
                MsgBox("Engine No. " & TextBoxIn1.Text & " not exit.")
                TextBoxIn1.Focus()
            End If
            
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try

    End Sub

    Protected Overrides Sub moreShown()
        'Me.SuspendLayout()
        MyBase.moreShown()

        With Me.Panel2

            '.Width = 0
            '.Height = 0

            '.Visible = False


            .Width = Me.LabelHeading.Width
            .Top = Me.LabelHeading.Top + Me.LabelHeading.Height + Me.Height * 0.1
            .Left = Me.LabelHeading.Left


            .Height = Me.Height - .Top - Me.Panel1.Height - Me.Height * 0.1

            .Visible = True

            .ForeColor = Color.FromArgb(25, Color.Navy)
            '.BackColor = Color.Transparent
        End With



        With Me.TableLayoutPanel1
            .Top = (.Parent.Height - .Height) / 2
            .Left = (.Parent.Width - .Width) / 2
            '.BackColor = Color.FromArgb(25, Color.Navy)
            .BackColor = Color.Transparent
            '.Top = 0
            '.Left = 0
            .Visible = True
        End With



    End Sub
End Class