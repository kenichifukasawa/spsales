Public Module PaymentMethodsDeposit

    Private Const ID_GENKIN As String = "0"
    Private Const ID_FURIKOMI As String = "1"
    Private Const ID_KOGITTE As String = "2"
    Private Const ID_SOUSAI As String = "3" ' 業者の支払方法とは手形と相殺のIDが逆のため注意
    Private Const ID_TESUURYOU As String = "4" ' 業者の支払方法とは手形と相殺のIDが逆のため注意
    Private Const ID_NEBIKI As String = "5"
    Private Const ID_SONOTA As String = "6"
    Private Const ID_CREDIT As String = "7"

    Private Const NAME_GENKIN As String = "現金"
    Private Const NAME_FURIKOMI As String = "振込"
    Private Const NAME_KOGITTE As String = "小切手"
    Private Const NAME_SOUSAI As String = "相殺"
    Private Const NAME_TESUURYOU As String = "手数料"
    Private Const NAME_NEBIKI As String = "値引"
    Private Const NAME_SONOTA As String = "その他"
    Private Const NAME_CREDIT As String = "クレジット"

    Public ReadOnly Names As String() = {
        NAME_GENKIN,
        NAME_FURIKOMI,
        NAME_KOGITTE,
        NAME_SOUSAI,
        NAME_TESUURYOU,
        NAME_NEBIKI,
        NAME_SONOTA,
        NAME_CREDIT
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_GENKIN, NAME_GENKIN},
        {ID_FURIKOMI, NAME_FURIKOMI},
        {ID_KOGITTE, NAME_KOGITTE},
        {ID_SOUSAI, NAME_SOUSAI},
        {ID_TESUURYOU, NAME_TESUURYOU},
        {ID_NEBIKI, NAME_NEBIKI},
        {ID_SONOTA, NAME_SONOTA},
        {ID_CREDIT, NAME_CREDIT}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_GENKIN, ID_GENKIN},
        {NAME_FURIKOMI, ID_FURIKOMI},
        {NAME_KOGITTE, ID_KOGITTE},
        {NAME_SOUSAI, ID_SOUSAI},
        {NAME_TESUURYOU, ID_TESUURYOU},
        {NAME_NEBIKI, ID_NEBIKI},
        {NAME_SONOTA, ID_SONOTA},
        {NAME_CREDIT, ID_CREDIT}
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
