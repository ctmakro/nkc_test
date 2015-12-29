Imports System.Net

Public Class Form1

    Sub log(tolog As String)
        TextBox1.AppendText(tolog + vbCrLf)
    End Sub

    Function makerequest(method As String, url As String, Optional content As String = "") As String
        log(method + " " + url + " " + "len=" + content.Length.ToString)
        Dim wc = New WebClient
        wc.Encoding = System.Text.Encoding.UTF8
        'post
        wc.Headers.Add("accept:application/json")
        wc.Headers.Add("content-type:application/json")
        Dim s As String
        Try
            If method <> "GET" Then
                s = wc.UploadString("http://127.0.0.1:1080" + url, method, content)
            Else
                s = wc.DownloadString("http://127.0.0.1:1080" + url)
            End If
        Catch ex As Exception
            'ignore
            s = ex.ToString
        End Try
        log(s)
        Return s
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        log("test start")

        'initialize db

        log(couchdropdb("posts"))
        log(couchnewdb("posts"))

        log(couchdropdb("counters"))
        log(couchnewdb("counters"))

        log(couchpostdocument("posts", My.Resources.thread))

        log(couchpostdocument("counters", "{""_id"":""postcount"",""count"":0}"))
        log("counters update")
        log(couchpostdocument("counters", My.Resources.counter))

        'PUT /{db}/_design/{ddoc}/_update/{func}/{docid}
        log(couchrequest("PUT", "/counters/_design/counters/_update/counters/postcount"))
        log(couchrequest("PUT", "/counters/_design/counters/_update/counters/postcount"))
        log(couchrequest("PUT", "/counters/_design/counters/_update/counters/postcount"))

        makerequest("POST", "/posts?tid=10", "{""content"":""hello world""}")
        makerequest("POST", "/posts?tid=10", "{""content"":""goodmorning""}")
        makerequest("POST", "/posts?tid=10", "hello")
        makerequest("POST", "/posts?tid=10", "{""typo"":""hello world""}")

        makerequest("GET", "/posts/4")
        makerequest("GET", "/posts/5")
        makerequest("GET", "/posts/6")
        makerequest("GET", "/posts/7")
    End Sub
End Class
