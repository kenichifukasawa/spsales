Module LogStatus

    ' TODO

    Public Const ID_TAIOUCHUU As String = "0"
    Public Const ID_SHUURYOU As String = "1"

    Public Const NAME_TAIOUCHUU As String = "対応中"
    Public Const NAME_SHUURYOU As String = "終了"

    Public ReadOnly Names As String() = {
        NAME_TAIOUCHUU,
        NAME_SHUURYOU
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_TAIOUCHUU, NAME_TAIOUCHUU},
        {ID_SHUURYOU, NAME_SHUURYOU}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_TAIOUCHUU, ID_TAIOUCHUU},
        {NAME_SHUURYOU, ID_SHUURYOU}
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
