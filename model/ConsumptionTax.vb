Public Module ConsumptionTax
    Public Const ID_SHIME As String = "0"
    Public Const ID_DENPYOU As String = "1"

    Public Const NAME_SHIME As String = "〆日ごと"
    Public Const NAME_DENPYOU As String = "伝票ごと"

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
