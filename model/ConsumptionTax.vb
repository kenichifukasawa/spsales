Public Module ConsumptionTax

    Private Const ID_SHIME As String = "0"
    Private Const ID_DENPYOU As String = "1"

    Private Const NAME_SHIME As String = "〆日ごと"
    Private Const NAME_DENPYOU As String = "伝票ごと"

    Public ReadOnly Names As String() = {
        NAME_SHIME,
        NAME_DENPYOU
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_SHIME, NAME_SHIME},
        {ID_DENPYOU, NAME_DENPYOU}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_SHIME, ID_SHIME},
        {NAME_DENPYOU, ID_DENPYOU}
    }

    Public Function GetNameById(id As String) As String
        If idToName.ContainsKey(id) Then
            Return idToName(id)
        Else
            Return "エラー"
        End If
    End Function

    Public Function GetIdByName(name As String) As String
        If nameToId.ContainsKey(name) Then
            Return nameToId(name)
        Else
            Return "エラー"
        End If
    End Function

End Module
