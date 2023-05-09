Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim url As String = "http://localhost:8080/buku"
        j()
        Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"

        Dim response As HttpWebResponse = request.GetResponse()
        Dim reader As New StreamReader(response.GetResponseStream())
        Dim responseText As String = reader.ReadToEnd()

        ' Konversi respons JSON ke dalam DataTable
        Dim table As DataTable = JsonConvert.DeserializeObject(Of DataTable)(responseText)

        ' Tampilkan data pada DataGridView
        DataGridView1.DataSource = table

    End Sub
    Private Sub simpanapi()
        
    End Sub
End Class
