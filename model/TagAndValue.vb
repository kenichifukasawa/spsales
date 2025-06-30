Imports System.IO
Imports System.Net
Imports System.Web.Script.Serialization
Imports System.Xml

Module TagAndValue

    Private Structure TagAndValue
        Dim tag As String
        Dim value As String
    End Structure

    Public Function GetAddressFromZipCode(zipCode As String) As String

        Dim url As String = "https://zipcloud.ibsnet.co.jp/api/search?zipcode=" & zipCode
        Dim request As WebRequest = WebRequest.Create(url)

        Try
            Using response As WebResponse = request.GetResponse()
                Using stream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(stream)
                        Dim json As String = reader.ReadToEnd()
                        Dim serializer As New JavaScriptSerializer()
                        Dim result = serializer.Deserialize(Of Dictionary(Of String, Object))(json)

                        If result("results") IsNot Nothing Then
                            Dim results = CType(result("results"), ArrayList)
                            If results.Count > 0 Then
                                Dim firstResult = CType(results(0), Dictionary(Of String, Object))
                                Dim address = firstResult("address1") & firstResult("address2") & firstResult("address3")
                                Return address
                            End If
                        End If
                        msg_go("該当する住所が見つかりませんでした。")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            msg_go(ex.Message)
        End Try

        Return ""

    End Function

    Public Function GetOnlyAddress3FromZipCode(zipCode As String) As String

        Dim url As String = "https://zipcloud.ibsnet.co.jp/api/search?zipcode=" & zipCode
        Dim request As WebRequest = WebRequest.Create(url)

        Try
            Using response As WebResponse = request.GetResponse()
                Using stream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(stream)
                        Dim json As String = reader.ReadToEnd()
                        Dim serializer As New JavaScriptSerializer()
                        Dim result = serializer.Deserialize(Of Dictionary(Of String, Object))(json)

                        If result("results") IsNot Nothing Then
                            Dim results = CType(result("results"), ArrayList)
                            If results.Count > 0 Then
                                Dim firstResult = CType(results(0), Dictionary(Of String, Object))
                                Dim address = firstResult("address3")
                                Return address
                            End If
                        End If
                        msg_go("該当する住所が見つかりませんでした。")
                    End Using
                End Using
            End Using
        Catch ex As Exception
            msg_go(ex.Message)
        End Try

        Return ""

    End Function

End Module
