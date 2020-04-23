Public Class Nebula
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("www.google.ca")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()


    End Sub
End Class
