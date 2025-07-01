Public Module Deadline

    Private Const ID_5 As String = "0"
    Private Const ID_10 As String = "1"
    Private Const ID_15 As String = "2"
    Private Const ID_20 As String = "3"
    Private Const ID_25 As String = "4"
    Private Const ID_END As String = "5"
    Private Const ID_ZUIJI As String = "6"

    Private Const NAME_5 As String = "５日"
    Private Const NAME_10 As String = "１０日"
    Private Const NAME_15 As String = "１５日"
    Private Const NAME_20 As String = "２０日"
    Private Const NAME_25 As String = "２５日"
    Private Const NAME_END As String = "月末日"
    Private Const NAME_ZUIJI As String = "随時"

    Private Const CSV_NAME_5 As String = "5"
    Private Const CSV_NAME_10 As String = "10"
    Private Const CSV_NAME_15 As String = "15"
    Private Const CSV_NAME_20 As String = "20"
    Private Const CSV_NAME_25 As String = "25"
    Private Const CSV_NAME_END As String = "31"
    Private Const CSV_NAME_ZUIJI As String = "00"

    Public ReadOnly Names As String() = {
        NAME_5,
        NAME_10,
        NAME_15,
        NAME_20,
        NAME_25,
        NAME_END,
        NAME_ZUIJI
    }

    Public ReadOnly idToName As New Dictionary(Of String, String) From {
        {ID_5, NAME_5},
        {ID_10, NAME_10},
        {ID_15, NAME_15},
        {ID_20, NAME_20},
        {ID_25, NAME_25},
        {ID_END, NAME_END},
        {ID_ZUIJI, NAME_ZUIJI}
    }

    Public ReadOnly idToCsvName As New Dictionary(Of String, String) From {
        {ID_5, CSV_NAME_5},
        {ID_10, CSV_NAME_10},
        {ID_15, CSV_NAME_15},
        {ID_20, CSV_NAME_20},
        {ID_25, CSV_NAME_25},
        {ID_END, CSV_NAME_END},
        {ID_ZUIJI, CSV_NAME_ZUIJI}
    }

    Public ReadOnly nameToId As New Dictionary(Of String, String) From {
        {NAME_5, ID_5},
        {NAME_10, ID_10},
        {NAME_15, ID_15},
        {NAME_20, ID_20},
        {NAME_25, ID_25},
        {NAME_END, ID_END},
        {NAME_ZUIJI, ID_ZUIJI}
    }

    Public Function GetNameById(id As String) As String
        If idToName.ContainsKey(id) Then
            Return idToName(id)
        Else
            Return "エラー"
        End If
    End Function

    Public Function GetCsvNameById(id As String) As String
        If idToCsvName.ContainsKey(id) Then
            Return idToCsvName(id)
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
