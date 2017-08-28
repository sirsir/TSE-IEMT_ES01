Public Class frmSearchByModelCodeLotNo

    Private Sub frmSearchByModelCodeLotNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Text = "Model code + Lot No. Search"

            Me.LabelHeading.Text = "Search by Model code + Lot No."

            'modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.MODEL_CODE_LOT_NO
            'Me.TextBoxIn1.Text = "160JYCIE"
            'Me.TextBoxIn2.Text = "0002"

            Me.TextBoxIn1.Text = ""
            Me.TextBoxIn2.Text = ""

            InitializeControls()

            'show bottom buttons
            Dim hCtrls As New Hashtable
            hCtrls("ButtonOK") = 0.5
            hCtrls("ButtonMAINMENU") = 0.9


            ShowOnlyControls(hCtrls)
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
        
    End Sub


    Protected Overrides Sub ButtonOK_Click(sender As Object, e As EventArgs)
        Dim taEngineList As New DataSet1TableAdapters.ENGINE_LISTTableAdapter
        Try
            'GlobalVariables.reset()
            modGlobalVariables.reset()

            If Not modValidate.ValidationParamSet.MODEL_CODE.CheckFormat(TextBoxIn1.Text) Then
                Exit Sub
            End If


            If Not modValidate.ValidationParamSet.LOT_NO2.CheckFormat(TextBoxIn2.Text) Then
                Exit Sub
            End If

            If Not modValidate.ValidationParamSet.LOT_NO.CheckFormat(TextBoxIn2.Text) Then
                Exit Sub
            End If

            'GlobalVariables.in_engineNo = TextBoxIn1.Text
            'modGlobalVariables.in_engineNo = TextBoxIn1.Text
            modGlobalVariables.arrIn.Add(TextBoxIn1.Text)
            modGlobalVariables.arrIn.Add(TextBoxIn2.Text)

            modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.MODEL_CODE_LOT_NO


            If taEngineList.ScalarQueryFindModelCode(TextBoxIn1.Text) > 0 AndAlso taEngineList.ScalarQueryFindLotNo(TextBoxIn2.Text) > 0 Then

                Dim frm As New frmSelectDataType
                If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                    Me.DialogResult = Windows.Forms.DialogResult.Abort
                    Me.Close()
                End If
            ElseIf taEngineList.ScalarQueryFindModelCode(TextBoxIn1.Text) <= 0 Then
                MsgBox("Model Code " & TextBoxIn1.Text & " not exit.")
                TextBoxIn1.Focus()
            Else
                MsgBox("Lot No. " & TextBoxIn2.Text & " not exit.")
                TextBoxIn2.Focus()
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