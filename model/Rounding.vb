Public Module Rounding
    Public Const ID_KIRISUTE As String = "0"
    Public Const ID_SHISYAGONYUU As String = "1"
    Public Const ID_KIRIAGE As String = "2"

    Public Const NAME_KIRISUTE As String = "切り捨て"
    Public Const NAME_SHISYAGONYUU As String = "四捨五入"
    Public Const NAME_KIRIAGE As String = "切り上げ"

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
