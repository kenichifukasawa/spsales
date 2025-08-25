Imports System.Globalization

Module m_date_time

    Function get_tsuki_saishuubi(nen As String, tsuki As String)

        Dim int_nen As Integer = CInt(nen)
        Dim int_tsuki As Integer = CInt(tsuki)
        Dim tsuki_saishuubi As Integer = DateTime.DaysInMonth(int_nen, int_tsuki)
        Return tsuki_saishuubi.ToString("D2")

    End Function

    Function TryParseDateString(yyyyMMdd As String, ByRef result As DateTime) As Boolean
        Return DateTime.TryParseExact(yyyyMMdd, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, result)
    End Function

    Function ConvertYmdStringToYmdSlash(dateYmd As String) As String
        Return DateTime.ParseExact(dateYmd, "yyyyMMdd", Nothing).ToString("yyyy/MM/dd")
    End Function

    Function ConvertYmdSlashStringToYmd(dateYmdSlash As String) As String
        Return DateTime.ParseExact(dateYmdSlash, "yyyy/MM/dd", Nothing).ToString("yyyyMMdd")
    End Function

End Module
