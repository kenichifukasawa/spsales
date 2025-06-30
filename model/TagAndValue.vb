Imports System.IO
Imports System.Net
Imports System.Xml

Module TagAndValue

    Private Structure TagAndValue
        Dim tag As String
        Dim value As String
    End Structure

    Public Function SearchAddress1ByZipCode(zip_code As String) As String

        Dim zip_code_without_hyphen As String
        If Len(zip_code) = 8 Then
            zip_code_without_hyphen = Mid(zip_code, 1, 3) & Mid(zip_code, 5, 4)
        Else
            Return ""
        End If

        Dim address_1 = ""

        Try

            Dim url As String = "http://groovelab.asia/zipcode/address.xml?zipcode=" & zip_code_without_hyphen
            Dim req As HttpWebRequest = WebRequest.Create(url)
            Dim res As WebResponse = req.GetResponse()
            Dim stream As Stream = res.GetResponseStream
            Dim streamRead As StreamReader = New StreamReader(stream)
            Dim xmlStr As String = streamRead.ReadToEnd()
            Dim stringReader As New StringReader(xmlStr)
            Dim strBuffer As String = stringReader.ReadToEnd()

            Dim number_of_attribute As Integer
            Dim tags_vals() As TagAndValue
            tags_vals = GetTagsVals("XML2", strBuffer, number_of_attribute)

            Dim val As String = GetValueFromTagAndValue(tags_vals, "status")

            Dim s_ken As String = GetValueFromTagAndValue(tags_vals, "ken")
            Dim s_ad1 As String = GetValueFromTagAndValue(tags_vals, "address1")
            Dim s_ad2 As String = GetValueFromTagAndValue(tags_vals, "address2")
            If val = "OK" And s_ken <> "" And s_ad1 <> "" And s_ad2 <> "" Then
                address_1 = s_ken & s_ad1 & s_ad2
            End If

            Return address_1

        Catch ex As Exception
            msg_go(ex.Message)
            Return ""
        End Try

    End Function

    Private Function GetTagsVals(ver As String,
                                ByRef xml_text As String,
                                ByRef number_of_attribute As Integer) As TagAndValue()

        Dim tags_vals() As TagAndValue

        If ver = "XML" Then
            tags_vals = GetTagsVals1(xml_text, number_of_attribute)
            Return tags_vals
        ElseIf ver = "XML2" Then
            tags_vals = GetTagsVals2(xml_text, number_of_attribute)
            Return tags_vals
        Else
            Return Nothing
        End If

    End Function

    Private Function GetTagsVals1(ByRef xml_text As String, ByRef number_of_attribute As Integer) As TagAndValue()

        Dim counter As Integer = 0
        Dim tag_val As String = ""
        Dim tags_vals() As TagAndValue

        number_of_attribute = NumberOfAttribute(xml_text)
        ReDim tags_vals(number_of_attribute)

        Try
            Dim reader As XmlTextReader = New XmlTextReader(New StringReader(xml_text))
            Try
                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element

                            If reader.MoveToFirstAttribute() Then
                                Do
                                    'writer.WriteLine("[{0}] 属性:{1} ({2})", counter, reader.Value, select_flag)
                                    tag_val = reader.Value
                                    tags_vals(counter).tag = tag_val
                                    tags_vals(counter).value = "none"
                                    counter = counter + 1
                                Loop Until (Not reader.MoveToNextAttribute())
                            End If

                        Case XmlNodeType.Text

                            counter = counter - 1
                            'writer.WriteLine("[{0}] 属性:{1} 値:{2} ({3})", counter, tag_val, reader.Value, select_flag)
                            tags_vals(counter).tag = tag_val
                            tags_vals(counter).value = reader.Value
                            counter = counter + 1

                    End Select
                End While
            Catch ex As XmlException

            Finally
                reader.Close()
            End Try
        Finally

        End Try

        Return tags_vals

    End Function

    Private Function GetTagsVals2(ByRef xml_text As String,
                                 ByRef number_of_attribute As Integer) As TagAndValue()
        'Dim writer As StringWriter = New StringWriter()
        Dim counter As Integer = 0
        Dim select_flag As Integer = 0
        Dim tag_val As String = ""
        Dim tag As String = ""
        Dim tags_vals() As TagAndValue

        number_of_attribute = NumberOfAttribute2(xml_text)
        ReDim tags_vals(number_of_attribute)

        'Try
        Dim reader As XmlTextReader = New XmlTextReader(New StringReader(xml_text))
        Try
            While reader.Read()
                Select Case reader.NodeType
                    Case XmlNodeType.Element
                        tag = reader.Name
                        'Console.WriteLine("[{0}] ---{1}---", counter, tag)
                        If reader.MoveToFirstAttribute() Then
                            Do
                                select_flag = 0
                                'Console.WriteLine("[{0}] 属性:{1} ({2}) ={3}=", counter, "element", select_flag, tag)
                            Loop Until (Not reader.MoveToNextAttribute())
                        End If
                    Case XmlNodeType.Text
                        '要素がテキストの値を持っていればこっちに振り分けられる．
                        select_flag = 1
                        'Console.WriteLine("[{0}] 属性:{1} 値:{2} ({3})", counter, tag, reader.Value, select_flag)
                        tags_vals(counter).tag = tag
                        tags_vals(counter).value = reader.Value
                        counter = counter + 1
                End Select
            End While
        Catch ex As XmlException
            'writer.WriteLine(ex.ToString())
        Finally
            reader.Close()
        End Try
        'Finally
        'writer.Close()
        'End Try
        Return tags_vals
    End Function

    Private Function NumberOfAttribute(ByRef xml_text As String) As Integer

        Dim writer As StringWriter = New StringWriter()
        Dim counter As Integer = 0
        Try
            Dim reader As XmlTextReader = New XmlTextReader(New StringReader(xml_text))
            Try
                While reader.Read()
                    Select Case reader.NodeType
                        Case XmlNodeType.Element
                            If reader.MoveToFirstAttribute() Then
                                Do
                                    counter = counter + 1
                                Loop Until (Not reader.MoveToNextAttribute())
                            End If
                    End Select
                End While
            Catch ex As XmlException
                msg_go(ex.ToString())
            Finally
                reader.Close()
            End Try
        Finally
            writer.Close()
        End Try

        Return counter

    End Function

    Private Function NumberOfAttribute2(ByRef xml_text As String) As Integer

        Dim counter As Integer = 0
        Dim reader As XmlTextReader = New XmlTextReader(New StringReader(xml_text))
        Try
            While reader.Read()
                Select Case reader.NodeType
                    Case XmlNodeType.Element
                        If reader.MoveToFirstAttribute() Then
                            Do
                            Loop Until (Not reader.MoveToNextAttribute())
                        End If
                    Case XmlNodeType.Text
                        '要素がテキストの値を持っていればこっちに振り分けられる．
                        counter = counter + 1
                End Select
            End While
        Catch ex As XmlException
            msg_go(ex.ToString())
        Finally
            reader.Close()
        End Try

        Return counter

    End Function

    Private Function GetValueFromTagAndValue(dat() As TagAndValue, tag As String) As String

        Dim len As Integer = dat.Length
        Dim val As String = "none"

        For i As Integer = 0 To len - 1
            If dat(i).tag = tag Then
                Return dat(i).value
            End If

        Next

        Return val

    End Function

End Module
