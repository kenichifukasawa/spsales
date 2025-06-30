Public Module BankAccountType

    Public Const ID_FUTSUU As String = "0"
    Public Const ID_TOUZA As String = "1"

    Private Const NAME_FUTSUU As String = "普通"
    Private Const NAME_TOUZA As String = "当座"

    Public ReadOnly Names As String() = {
        NAME_FUTSUU,
        NAME_TOUZA
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_FUTSUU, NAME_FUTSUU},
        {ID_TOUZA, NAME_TOUZA}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_FUTSUU, ID_FUTSUU},
        {NAME_TOUZA, ID_TOUZA}
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

