Imports System.Text.RegularExpressions

Module modValidate



    Public Class ValidationParam
        Private regexp As String
        Private title As String
        Private message As String
        Private button As MessageBoxButtons
        Private icon As MessageBoxIcon

        Public Sub New(ByVal _regexp As String, ByVal _title As String, ByVal _message As String, Optional ByVal _button As MessageBoxButtons = Nothing, Optional _icon As MessageBoxIcon = Nothing)
            regexp = _regexp
            title = _title
            message = _message
            If _button = Nothing Then
                button = MessageBoxButtons.OK
            Else
                button = _button
            End If

            If _icon = Nothing Then
                icon = MessageBoxIcon.None
            Else
                icon = _icon
            End If


        End Sub


        Public Function MyMessageBox()
            Return MessageBox.Show(message, title, button, icon)
        End Function

        Public Function CheckFormat(ByVal strIn As String) As Boolean


            If regexp = "" Then
                Return True
            End If

            Dim regexpTemp As Regex = New Regex(regexp)
            'MsgBox(regexp)
            'MsgBox(strIn)

            If Not regexpTemp.IsMatch(strIn) Then
                'MessageBox.Show(message, title, button, icon)
                MyMessageBox()
                Return False
            Else
                Return True
            End If


        End Function


    End Class


    Public Class ValidationParamSet

        Public Shared SHORT_BLOCK_SERIAL_NO As ValidationParam = _
            New ValidationParam(
                                 "^(([0-9]{10})|([0-9]{6})|([ ]{1}[0-9]{1}))$", _
                                 "", _
                                 Regex.Unescape("Please check Short Block Serial No.\n " & _
                                                "Only 10 numbers (0-9)\n" & _
                                                "Or 6 numbers (0-9)\n" & _
                                                "Or 1 space 9 numbers (0-9) are accepted\n" _
                                                ) _
                                    )


        Public Shared SERIAL_NO As ValidationParam = _
            New ValidationParam(
                                 "^(([0-9]{1}[ ]{1}[0-9]{10})|([0-9]{12})|([ ]{12}))$", _
                                 "", _
                                 Regex.Unescape("Please check Serial No.\n " & _
                                                "Only 1 number (0-9) and 1 space and 10 numbers (0-9)\n" & _
                                                "Or 12 numbers (0-9)\n" & _
                                                "Or 12 spaces are accepted\n" _
                                                ) _
                                    )


        Public Shared ENGINE_NO As ValidationParam = _
            New ValidationParam(
                                 "^[A-Za-z]{2}[0-9]{4}$", _
                                 "", _
                                 Regex.Unescape("Please check Engine No.\nOnly 2 characters (A-Z) and 4 numbers (0-9) are accepted") _
                                    )


        Public Shared MODEL_CODE As ValidationParam = _
            New ValidationParam(
                                 "^[0-9]{3}[A-Za-z0]{5}$", _
                                 "", _
                                 Regex.Unescape("Please check Model Code.\nOnly 3 numbers(0-9) and 5 characters (A-Z) +0 are accepted") _
                                    )

        Public Shared LOT_NO As ValidationParam = _
            New ValidationParam(
                                 "^[0-9]{4}$", _
                                 "", _
                                 Regex.Unescape("Please check Lot No.\nOnly 4 numbers(0-9) are accepted") _
                                    )

        Public Shared LOT_NO2 As ValidationParam = _
            New ValidationParam(
                                 "^.+$", _
                                 "Warning", _
                                 "Please input Lot No.", _
                                 Nothing, _
                                 MessageBoxIcon.Error _
                                    )


        Public Shared PRODUCTION_DATE As ValidationParam = _
            New ValidationParam(
                                 "^[0-9]{8}$", _
                                 "", _
                                 Regex.Unescape("Please check Production Date.\n Only 8 numbers(0-9) YYYYMMDD are accepted."), _
                                    )

        Public Shared PRODUCTION_DATE_FROM As ValidationParam = _
            New ValidationParam(
                                 "^.+$", _
                                 "Warning", _
                                 "Please input FROM", _
                                 Nothing, _
                                 MessageBoxIcon.Error _
                                    )


        Public Shared PRODUCTION_DATE_TO As ValidationParam = _
            New ValidationParam(
                                 "^.+$", _
                                 "Warning", _
                                 "Please input TO", _
                                 Nothing, _
                                 MessageBoxIcon.Error _
                                    )

        Public Shared CONFIRM_DELETE As ValidationParam = _
            New ValidationParam(
                                 "", _
                                 "Confirmation", _
                                 "Do you want to DELETE?", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Exclamation _
                                    )

        Public Shared CONFIRM_SAVE As ValidationParam = _
            New ValidationParam(
                                 "", _
                                 "Confirmation", _
                                 "Do you want to save?", _
                                 MessageBoxButtons.YesNo, _
                                 MessageBoxIcon.Exclamation _
                                    )



    End Class


    Public Function CheckRegExp(ByVal strIn As String, ByVal regexp As String) As Boolean


        If regexp = "" Then
            Return True
        End If

        Dim regexpTemp As Regex = New Regex(regexp)
        'MsgBox(regexp)
        'MsgBox(strIn)

        If Not regexpTemp.IsMatch(strIn) Then
            'MessageBox.Show(message, title, button, icon)
            'MyMessageBox()
            Return False
        Else
            Return True
        End If


    End Function

End Module
