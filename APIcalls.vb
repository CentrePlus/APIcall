Public Class APIcalls
    Dim _apiPublicKey As String
    Dim _apiPrivateKey As String
    Dim _timeStamp As Integer
    Dim _APIwebsite As String
    Dim _PassWord As String
    Dim _UserID As String

    Public Sub New(ByVal PublicKey As String, ByVal PrivateKey As String, ByVal webSite As String, ByVal password As String, ByVal UserID As String)
        Me._timeStamp = (Date.Now.ToUniversalTime - New DateTime(1970, 1, 1)).TotalSeconds
        Me._apiPublicKey = PublicKey
        Me._apiPrivateKey = PrivateKey
        Me._APIwebsite = webSite
        Me._PassWord = password
        Me._UserID = UserID
    End Sub

#Region "API Stuff"
    Private Function asbvs() As String
        Dim urlBuilder As New System.Text.StringBuilder
        urlBuilder.Append(Me._APIwebsite & "/1/5/asbvs.xml?")
        urlBuilder.Append(userIdApiKey)
        Return urlBuilder.ToString
    End Function

    Private Function byID(ByVal ID As String) As String
        Dim urlBuilder As New System.Text.StringBuilder
        urlBuilder.Append(Me._APIwebsite & "/1/5/animal/sgid/" & ID & ".xml?")
        urlBuilder.Append(userIdApiKey)
        My.Computer.Clipboard.SetText(urlBuilder.ToString)
        Return urlBuilder.ToString
    End Function

    Private Function buildPercentiles() As String
        Dim urlBuilder As New System.Text.StringBuilder
        urlBuilder.Append(Me._APIwebsite & "/1/5/percentiles.xml?")
        urlBuilder.Append(userIdApiKey)
        Return urlBuilder.ToString
    End Function

    Private Function analysis() As String
        Dim urlBuilder As New System.Text.StringBuilder
        urlBuilder.Append(Me._APIwebsite & "/1/analyses.xml?")
        urlBuilder.Append(userIdApiKey)
        Return urlBuilder.ToString
    End Function

    Private Function userIdApiKey()
        'Dim hashedUserPassPhrase As String = getSHA1Hash("publicSGPasswordSaltpublic")
        Dim hashedUserPassPhrase As String = getSHA1Hash(Me._PassWord)
        Dim HMAC As String = HashString(Me._apiPublicKey & "public" & Me._timeStamp.ToString, Me._apiPrivateKey & hashedUserPassPhrase)
        Dim urlBuilder As New System.Text.StringBuilder
        urlBuilder.Append("timestamp=" & Me._timeStamp)
        urlBuilder.Append("&appid=" & Me._apiPublicKey)
        'urlBuilder.Append("&userid=public")
        urlBuilder.Append("&userid=" & Me._UserID)
        urlBuilder.Append("&apikey=" & HMAC)
        Return urlBuilder.ToString
    End Function

    Private Function HashString(ByVal stringToHash As String, ByVal HachKey As String) As String
        Dim myEncoder As New System.Text.UTF8Encoding
        Dim Key() As Byte = myEncoder.GetBytes(HachKey)
        Dim Text() As Byte = myEncoder.GetBytes(stringToHash)
        Dim myHMACSHA1 As New System.Security.Cryptography.HMACSHA1(Key)
        Dim HashCode As Byte() = myHMACSHA1.ComputeHash(Text)
        Dim hash As String = Replace(BitConverter.ToString(HashCode), "-", "").ToLower
        Return hash
    End Function

    Private Function getSHA1Hash(ByVal strToHash As String) As String
        Dim sha1Obj As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = sha1Obj.ComputeHash(bytesToHash)
        Dim Hash As String = Replace(BitConverter.ToString(bytesToHash), "-", "").ToLower
        Return Hash
    End Function
#End Region

#Region "Properties"
    Public ReadOnly Property getByID(ByVal ID As String) As String
        Get
            Return Me.byID(ID)
        End Get
    End Property

    Public ReadOnly Property percentilesURL As String
        Get
            Return Me.buildPercentiles
        End Get
    End Property

    Public ReadOnly Property timeStamp As Double
        Get
            Return Me._timeStamp
        End Get
    End Property

    Public ReadOnly Property CallASBVs As String
        Get
            Return Me.asbvs
        End Get
    End Property
#End Region
End Class
