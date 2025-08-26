Module LogCategory

    ' TODO

    Public Const ID_TEST As String = "0"
    Public Const ID_SONOTA As String = "1"

    Public Const NAME_TEST As String = "テスト"
    Public Const NAME_SONOTA As String = "その他"

    Public ReadOnly Names As String() = {
        NAME_TEST,
        NAME_SONOTA
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_TEST, NAME_TEST},
        {ID_SONOTA, NAME_SONOTA}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_TEST, ID_TEST},
        {NAME_SONOTA, ID_SONOTA}
    }

    Public Function GetNameById(id As String) As String
        If idToName.ContainsKey(id) Then
            Return idToName(id)
        Else
            Return "[エラー]"
        End If
    End Function

    Public Function GetIdByName(name As String) As String
        If nameToId.ContainsKey(name) Then
            Return nameToId(name)
        Else
            Return "[エラー]"
        End If
    End Function

End Module
