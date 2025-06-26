Public Module PaymentMethods

    Public Const ID_GENKIN As String = "0"
    Public Const ID_FURIKOMI As String = "1"
    Public Const ID_KOGITTE As String = "2"
    Public Const ID_TEGATA As String = "3"
    Public Const ID_SOUSAI As String = "4"

    Public Const NAME_GENKIN As String = "現金"
    Public Const NAME_FURIKOMI As String = "振込"
    Public Const NAME_KOGITTE As String = "小切手"
    Public Const NAME_TEGATA As String = "手形"
    Public Const NAME_SOUSAI As String = "相殺"

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_GENKIN, NAME_GENKIN},
        {ID_FURIKOMI, NAME_FURIKOMI},
        {ID_KOGITTE, NAME_KOGITTE},
        {ID_TEGATA, NAME_TEGATA},
        {ID_SOUSAI, NAME_SOUSAI}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_GENKIN, ID_GENKIN},
        {NAME_FURIKOMI, ID_FURIKOMI},
        {NAME_KOGITTE, ID_KOGITTE},
        {NAME_TEGATA, ID_TEGATA},
        {NAME_SOUSAI, ID_SOUSAI}
    }

    Public Function GetNameById(id As String) As String
        If idToName.ContainsKey(id) Then
            Return idToName(id)
        Else
            Return "不明"
        End If
    End Function

    Public Function GetIdByName(name As String) As String
        If nameToId.ContainsKey(name) Then
            Return nameToId(name)
        Else
            Return "不明"
        End If
    End Function

End Module
