Public Module Rounding

    Private Const ID_KIRISUTE As String = "0"
    Private Const ID_SHISYAGONYUU As String = "1"
    Private Const ID_KIRIAGE As String = "2"

    Private Const NAME_KIRISUTE As String = "切り捨て"
    Private Const NAME_SHISYAGONYUU As String = "四捨五入"
    Private Const NAME_KIRIAGE As String = "切り上げ"

    Public ReadOnly Names As String() = {
        NAME_KIRISUTE,
        NAME_SHISYAGONYUU,
        NAME_KIRIAGE
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_KIRISUTE, NAME_KIRISUTE},
        {ID_SHISYAGONYUU, NAME_SHISYAGONYUU},
        {ID_KIRIAGE, NAME_KIRIAGE}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_KIRISUTE, ID_KIRISUTE},
        {NAME_SHISYAGONYUU, ID_SHISYAGONYUU},
        {NAME_KIRIAGE, ID_KIRIAGE}
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
