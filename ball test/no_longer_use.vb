Protected Sub drawseparator()
        Dim myGraphics As Graphics
        myGraphics = Me.CreateGraphics()
        'myGraphics = Graphics.FromHwnd(Me.Handle)

        Dim intLineTickness As Double = 5
        Dim myPen As New Pen(color:=Color.Blue, Width:=intLineTickness)
        With Me.Panel1
            myGraphics.DrawLine(myPen, 0, .Top - CInt(intLineTickness / 2), .Width, .Top - CInt(intLineTickness / 2))
        End With
        myGraphics.Dispose()
        myPen.Dispose()

    End Sub