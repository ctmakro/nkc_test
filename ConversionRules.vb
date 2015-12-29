Imports Newtonsoft.Json
Imports System.Net

Module ConversionRules
    'a list of keys.
    'on the left are the keys to be read from mysql,
    'on the right are the keys to be written into nosql.

    Public PostsToPosts As String() =
        {"pid", "_id",
        "fid", "fid",
        "tid", "tid",
        "subject", "title",
        "content", "content",
        "created_time", "toc",
        "created_userid", "uid"
        }

    Public Function rowtojson(r As System.Data.DataRow, ck As String()) As String

        'ck means Conversion Keys
        Dim d = New Dictionary(Of String, Object)

        If ck.Length > 1 Then 'if key exist
            For i = 0 To ck.Length - 1 Step 2
                Dim originalkey = ck(i)
                Dim newkey = ck(i + 1)
                Dim item = r.Item(originalkey)

                If ((TypeOf (item) Is String) AndAlso CStr(item) = "") Then
                    'dont do a thing
                Else
                    If (newkey = "_id") Then
                        d.Add(newkey, item.ToString.Trim)
                    Else
                        d.Add(newkey, item)
                    End If
                End If
            Next
            Return JsonConvert.SerializeObject(d)
        Else
            Return "error"
        End If
    End Function

End Module

Module CouchDriver
    Function couchpostdocument(dbname As String, jsondoc As String) As String
        Dim s = couchrequest("POST", "/" + dbname, jsondoc)
        Return s
    End Function

    Function couchdropdb(dbname As String) As String
        Return couchrequest("DELETE", "/" + dbname, "")
    End Function

    Function couchnewdb(dbname As String) As String
        Return couchrequest("PUT", "/" + dbname, "")
    End Function

    Function couchrequest(method As String, url As String, Optional jsondoc As String = "") As String
        Dim wc = New WebClient
        wc.Encoding = System.Text.Encoding.UTF8
        'post
        wc.Headers.Add("accept:application/json")
        wc.Headers.Add("content-type:application/json")
        Dim s As String
        Try
            s = wc.UploadString("http://127.0.0.1:5984" + url, method, jsondoc)
        Catch ex As Exception
            'ignore
            s = ex.ToString
        End Try

        Return s
    End Function
End Module