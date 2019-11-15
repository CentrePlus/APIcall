Imports System.Xml
Public Class Form1
    Dim _API As APIcalls

    Private Sub ButCallAPI_Click(sender As Object, e As EventArgs) Handles ButCallID.Click
        Me._API = New APIcalls(Me.TxtAPIpublicKey.Text, Me.TxtAPIPrivateKey.Text, Me.TxtWebSite.Text, Me.TxtPassWord.Text, Me.TxtUserId.Text)

        Me.LBResult.Items.Clear()

        Dim URL As String = Me._API.getByID(Me.TxtID.Text)

        Me.LBResult.Items.Add("URL Call - " & URL)
        Me.LBResult.Items.Add("")

        Dim reader As XmlTextReader = New XmlTextReader(URL)

        Try
            Do While reader.Read()

                Me.LBResult.Items.Add(reader.Read.ToString())

            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub ButCallASBV_Click(sender As Object, e As EventArgs) Handles ButCallASBV.Click
        Me._API = New APIcalls(Me.TxtAPIpublicKey.Text, Me.TxtAPIPrivateKey.Text, Me.TxtWebSite.Text, Me.TxtPassWord.Text, Me.TxtUserId.Text)

        Me.LBResult.Items.Clear()

        Dim URL As String = Me._API.CallASBVs

        Me.LBResult.Items.Add("URL Call - " & URL)
        Me.LBResult.Items.Add("")

        Dim reader As XmlTextReader = New XmlTextReader(URL)

        Try
            Do While reader.Read()

                Me.LBResult.Items.Add(reader.Read.ToString())

            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
            Exit Sub
        End Try
    End Sub
End Class