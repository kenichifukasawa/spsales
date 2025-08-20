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

    'Function get_day_by_yyyyMMdd(yyyyMMdd As String) As String ' TODO : 削除？
    '    Dim dt As DateTime

    '    ' yyyyMMdd形式で正しく解析できない場合は空文字返却
    '    If DateTime.TryParseExact(yyyyMMdd, "yyyyMMdd", CultureInfo.InvariantCulture, Globalization.DateTimeStyles.None, dt) Then
    '        ' 日にち部分を2桁の文字列で返す
    '        Return dt.ToString("dd")
    '    Else
    '        Return String.Empty
    '    End If
    'End Function

End Module
