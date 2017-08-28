Public Class clsStringUtilities
    Public Shared Function string2date(ByVal strIn)
        Dim strOut As String = ""

        Dim format As String
        'Dim result As Date
        Dim provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture

        format = "yyyyMMdd"

        Try
            strOut = Date.ParseExact(strIn, format, provider)
            'Console.WriteLine("{0} converts to {1}.", DateString, result.ToString())
            'Console.ReadLine()
        Catch e As FormatException
            Console.WriteLine("{0} is not in the correct format.", strIn)
            strOut = ""
        End Try

        Return strOut
    End Function

    Public Shared Function arraylist2string(ByVal arrIn As ArrayList, Optional ByVal separator As String = "")
        If separator = "" Then

            separator = Environment.NewLine
        End If

        Return String.Join(separator, CType(arrIn.ToArray(Type.GetType("System.String")), String()))
    End Function

End Class
