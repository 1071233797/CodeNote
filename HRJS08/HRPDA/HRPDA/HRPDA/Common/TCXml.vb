Public Class TCXml


    ''' <summary>
    ''' 创建XML文件
    ''' </summary>
    ''' <param name="xmlFileName">要创建的XML文件名</param>
    ''' <remarks></remarks>
    Public Shared Sub createXML(ByVal xmlFileName As String)
        Try
            Dim writer As New Xml.XmlTextWriter(xmlFileName, System.Text.Encoding.GetEncoding("utf-8"))
            '使用自动缩进便于阅读
            writer.Formatting = Xml.Formatting.Indented
            writer.WriteRaw("<?xml version=""1.0"" encoding=""utf-8"" ?>")
            '书写根元素()
            writer.WriteStartElement("Config")

            '添加子元素()
            writer.WriteElementString("HostIP", "")
            writer.WriteElementString("HostPort", "")
            writer.WriteElementString("IsLogin", "1")

            '关闭根元素
            writer.WriteFullEndElement()
            '将XML写入文件并关闭writer
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Sub



    Public Shared Function updateXML(ByVal xmlFileName As String, ByVal elementName As String, ByVal innerText As String) As Boolean
        Try
            If System.IO.File.Exists(xmlFileName) Then

                Dim doc As New Xml.XmlDocument
                doc.Load(xmlFileName)
                Dim list As Xml.XmlNodeList = doc.SelectSingleNode("Config").ChildNodes
                For Each xn As Xml.XmlNode In list
                    If xn.Name = elementName Then
                        xn.InnerText = innerText
                    End If
                Next
                doc.Save(xmlFileName)

            End If
            Return True
        Catch ex As Exception
            Return False
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Function
    
    ''' <summary>
    ''' 读取xml
    ''' </summary>
    ''' <param name="xmlNodeName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function readXMl(ByVal xmlNodeName As String) As String
        Try
            Dim tmpStr As String = ""
            If System.IO.File.Exists(GetAppPath() + "Config.xml") Then
                Dim doc As New Xml.XmlDocument
                doc.Load(GetAppPath() + "Config.xml")
                Dim re As Xml.XmlNodeReader = New Xml.XmlNodeReader(doc)

                Dim name As String = ""

                While re.Read
                    Select Case re.NodeType

                        Case Xml.XmlNodeType.Element
                            name = re.Name
                        Case Xml.XmlNodeType.Text
                            If name.Equals(xmlNodeName) Then
                                tmpStr = re.Value
                                Exit While
                            End If
                    End Select
                End While
            Else
                createXML(GetAppPath() + "Config.xml")
            End If

            Return tmpStr
        Catch ex As Exception
            Return ""
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
        End Try
    End Function


    Private Shared Function GetAppPath() As String
        Dim m As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Replace("/", "\"), "(?<=file:\\\\\\|^)(?:[^\\]+)?(\\[^\\]+)+(?=\\[^\\]+)")
        If Not m.Success Then
            Throw New Exception("Get execute path error.Can not run on this system.")
        Else
            Return m.Value + "\"
        End If
    End Function
End Class

