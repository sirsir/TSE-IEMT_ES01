Public Class frmSearchByAsmDate

    Private Sub frmSearchByAsmDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Me.Text = "PRODUCTION DATE Search"

            LabelHeading.Text = "Search by ASM DATE"

            'TextBoxIn1.Text = "17530101"
            'TextBoxIn2.Text = "20151002"

            TextBoxIn1.Text = ""
            TextBoxIn2.Text = ""

            InitializeControls()

            'show bottom buttons
            Dim hCtrls As New Hashtable
            hCtrls("ButtonOK") = 0.5
            hCtrls("ButtonMAINMENU") = 0.9
            'hCtrls("GroupBoxSELECTBY") = 0.1


            ShowOnlyControls(hCtrls)
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try
    End Sub


    Protected Overrides Sub ButtonOK_Click(sender As Object, e As EventArgs)

        Try

            'GlobalVariables.reset()
            modGlobalVariables.reset()




            If Not modValidate.ValidationParamSet.PRODUCTION_DATE_FROM.CheckFormat(TextBoxIn1.Text) Then
                Exit Sub
            End If

            If Not modValidate.ValidationParamSet.PRODUCTION_DATE_TO.CheckFormat(TextBoxIn2.Text) Then
                Exit Sub
            End If


            'GlobalVariables.in_engineNo = TextBoxIn1.Text
            'modGlobalVariables.in_engineNo = TextBoxIn1.Text

            Dim strTemp1 As String = clsStringUtilities.string2date(TextBoxIn1.Text)
            Dim strTemp2 As String = clsStringUtilities.string2date(TextBoxIn2.Text)

            If strTemp1 = "" Or strTemp2 = "" Then
                modValidate.ValidationParamSet.PRODUCTION_DATE.MyMessageBox()
                Exit Sub
            End If
            clsStringUtilities.string2date(TextBoxIn2.Text)



            'modGlobalVariables.arrIn.Add(TextBoxIn1.Text)
            'modGlobalVariables.arrIn.Add(TextBoxIn2.Text)

            modGlobalVariables.arrIn.Add(strTemp1)
            modGlobalVariables.arrIn.Add(strTemp2)
            modGlobalVariables.searchBy = modGlobalVariables.SEARCH_BY.LINE_ON_TIME__ASM_DATE


            modGlobalVariables.tabletype = modGlobalVariables.TABLE2SHOW.ENGINE_LIST__ProductionDateSearch
            'frmProductionDateSearch.Show()

            Dim frm As New frmProductionDateSearch
            If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
                Me.DialogResult = Windows.Forms.DialogResult.Abort
                Me.Close()
            End If

            'Me.Close()
            'Me.Dispose()
        Catch ex As Exception
            modLogger.HandleException(ex, True)
        End Try

    End Sub


    Protected Overrides Sub moreShown()
        'Me.SuspendLayout()
        MyBase.moreShown()

        'With Me.TableLayoutPanel1
        '.Top = Me.Panel2.Top + (Me.Panel2.Height - .Height) / 2
        '.Left = Me.Panel2.Left + (Me.Panel2.Width - .Width) / 2
        'End With




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