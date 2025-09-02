Module PrintCategory

    Public Const ID_KAKEURI As String = "0"
    Public Const ID_GENKINURI As String = "1"
    Public Const ID_HENPIN As String = "2"
    Public Const ID_HENKIN As String = "3"
    Public Const ID_ITAKU As String = "4"

    Public Const NAME_KAKEURI As String = "掛売"
    Public Const NAME_GENKINURI As String = "現金売"
    Public Const NAME_HENPIN As String = "返品"
    Public Const NAME_HENKIN As String = "返金"
    Public Const NAME_ITAKU As String = "委託"

    Public ReadOnly Names As String() = {
        NAME_KAKEURI,
        NAME_GENKINURI,
        NAME_HENPIN,
        NAME_HENKIN,
        NAME_ITAKU
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_KAKEURI, NAME_KAKEURI},
        {ID_GENKINURI, NAME_GENKINURI},
        {ID_HENPIN, NAME_HENPIN},
        {ID_HENKIN, NAME_HENKIN},
        {ID_ITAKU, NAME_ITAKU}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_KAKEURI, ID_KAKEURI},
        {NAME_GENKINURI, ID_GENKINURI},
        {NAME_HENPIN, ID_HENPIN},
        {NAME_HENKIN, ID_HENKIN},
        {NAME_ITAKU, ID_ITAKU}
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
