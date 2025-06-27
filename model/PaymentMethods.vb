Public Module PaymentMethods

    Private Const ID_GENKIN As String = "0"
    Private Const ID_FURIKOMI As String = "1"
    Private Const ID_KOGITTE As String = "2"
    Private Const ID_TEGATA As String = "3"
    Private Const ID_SOUSAI As String = "4"

    Private Const NAME_GENKIN As String = "現金"
    Private Const NAME_FURIKOMI As String = "振込"
    Private Const NAME_KOGITTE As String = "小切手"
    Private Const NAME_TEGATA As String = "手形"
    Private Const NAME_SOUSAI As String = "相殺"

    Public ReadOnly Names As String() = {
        NAME_GENKIN,
        NAME_FURIKOMI,
        NAME_KOGITTE,
        NAME_TEGATA,
        NAME_SOUSAI
    }

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
