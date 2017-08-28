Public Class frmSearch
    'Inherits frmBase
    Protected Overrides Sub moreShown()
        'Me.LabelHeading.Height = 0
        'Me.LabelHeading.Text = "TEST"
        Me.LabelHeading.AutoSize = True

        'Me.LabelHeading.TextAlign = HorizontalAlignment.Center

        Me.LabelHeading.TextAlign = ContentAlignment.MiddleCenter
        'MsgBox("xxx")

        Me.LabelHeading.BackColor = Color.FromArgb(0, 180, 180)
        Me.LabelHeading.ForeColor = Color.FromArgb(255, 255, 255)

        Me.LabelHeading.AutoSize = False

        'Me.LabelHeading.

        Me.LabelHeading.Width = Me.Width * 0.8

        'Me.LabelHeading.Height = Me.LabelHeading.Height * 1.8
        Me.LabelHeading.Height = Me.Height * 0.1

        Me.LabelHeading.Margin = New System.Windows.Forms.Padding(Me.LabelHeading.Height * 2)
        'Me.TextBoxHeading.Size = New System.Drawing.Size(Me.TextBoxHeading.Width, Me.TextBoxHeading.Height * 3)


        Me.LabelHeading.Top = Me.Height * 0.1
        Me.LabelHeading.Left = (Me.Width - Me.LabelHeading.Width) / 2



        'Me.TextBoxHeading
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.BorderStyle = BorderStyle.None

        Dim intLineTickness As Double = 10
        Dim myPen As New Pen(color:=Color.Blue, Width:=intLineTickness)
        With e.ClipRectangle
            'e.Graphics.DrawLine(myPen, 0, .Top - CInt(intLineTickness / 2), .Width, .Top - CInt(intLineTickness / 2))
            ' e.Graphics.DrawLine(myPen, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Right, e.ClipRectangle.Top)
            DrawRoundedRectangle(e.Graphics,
                                .Left + intLineTickness / 2,
                                .Top + intLineTickness / 2,
                                .Width - intLineTickness,
                                .Height - intLineTickness, .Height * 0.3, myPen)
        End With

        'e.Graphics.DrawLine(myPen, 0, e.ClipRectangle.Top - CInt(intLineTickness / 2), e.ClipRectangle.Width, e.ClipRectangle.Top - CInt(intLineTickness / 2))
        'myGraphics.Dispose()
        myPen.Dispose()


        'drawseparator(e.Graphics)
    End Sub
End Class