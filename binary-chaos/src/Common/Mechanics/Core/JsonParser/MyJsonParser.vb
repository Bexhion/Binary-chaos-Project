﻿Imports System.Web.Script.Serialization
Imports System.IO
Imports Newtonsoft.Json
Public Class MyJsonParser

    Public Shared applicationPath As String = My.Application.Info.DirectoryPath

    Public Shared Function SetProperties(jsonfile As String, pat As String) As User
        Dim deserializer As JavaScriptSerializer = New JavaScriptSerializer
        If File.Exists(Path.Combine(pat, jsonfile & "file.json")) Then
            Dim user As New MyJsonParser.User
            Dim allStrings As String = File.ReadAllText(Path.Combine(pat, jsonfile & "file.json"))
            Return deserializer.Deserialize(Of User)(allStrings)
        End If
        Return Nothing
    End Function

    Public Shared Function WriteToJson(user As User) As String
        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer
        If user IsNot Nothing Then
            Return JsonConvert.SerializeObject(user, ReferenceLoopHandling.Ignore)
        End If
        Return Nothing
    End Function

    Public Shared Sub WriteJsonToFile(json As String, jsonfile As String)
        If json Is Nothing Then Exit Sub
        If File.Exists(Path.Combine(applicationPath, "users", jsonfile & "file.json")) Then
            Dim theFile As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(Path.Combine(applicationPath, "users", jsonfile & "file.json"), False)
            theFile.WriteLine(json)
            theFile.Close()
        End If
    End Sub

    Public Class User

#Region "properties"
        Public Property id As String = ""
        Public Property username As String = ""
        Public Property password As String = ""
        Public Property securityAnswer1 As String = ""
        Public Property securityAnswer2 As String = ""
        Public Property securityAnswer3 As String = ""
        Public Property blacklistedPrograms As List(Of String) = Nothing
        Public Property allTimeMarkers As List(Of Marker) = Nothing
        Public Property fitness As Double = 0
#End Region

        Public Shared Function LoadUser(username As String, password As String) As User
            If Directory.Exists(Path.Combine(applicationPath, "users")) Then
                If File.Exists(Path.Combine(applicationPath, "users", username & "file.json")) Then
                    Dim user As User = MyJsonParser.SetProperties(username, Path.Combine(applicationPath, "users"))
                    If Not user.password = password Then
                        Return Nothing
                    Else
                        Return user
                    End If
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Function

        Public Shared Sub SaveUser(user As User)
            If Not Directory.Exists(Path.Combine(applicationPath, "users")) Then
                Dim dir As DirectoryInfo = Directory.CreateDirectory(Path.Combine(applicationPath, "users"))
            End If
            Dim jsonUser As String = MyJsonParser.WriteToJson(user)
            If File.Exists(Path.Combine(applicationPath, "users", user.username & "file.json")) Then
                MyJsonParser.WriteJsonToFile(jsonUser, user.username)
            Else
                File.WriteAllText(Path.Combine(applicationPath, "users", user.username & "file.json"), jsonUser)
            End If
        End Sub

        Public Class Marker
            Public Property Name As String
            Public Property Title As String
            Public Property Description As String
            Public Property DateStart As DateTime
            Public Property DateEnd As DateTime
            Public Property Priority As CustomListBox.Priority
            Public Property Points As List(Of String)
            Public Property AccomplishedPoints As List(Of String)
        End Class
    End Class
End Class