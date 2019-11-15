<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LBResult = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAPIpublicKey = New System.Windows.Forms.TextBox()
        Me.TxtAPIPrivateKey = New System.Windows.Forms.TextBox()
        Me.TxtWebSite = New System.Windows.Forms.TextBox()
        Me.TxtUserId = New System.Windows.Forms.TextBox()
        Me.TxtPassWord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButCallID = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.ButCallASBV = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBResult
        '
        Me.LBResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBResult.FormattingEnabled = True
        Me.LBResult.Location = New System.Drawing.Point(33, 213)
        Me.LBResult.Name = "LBResult"
        Me.LBResult.Size = New System.Drawing.Size(755, 212)
        Me.LBResult.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "API Public Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "API Private Key"
        '
        'TxtAPIpublicKey
        '
        Me.TxtAPIpublicKey.Location = New System.Drawing.Point(135, 22)
        Me.TxtAPIpublicKey.Name = "TxtAPIpublicKey"
        Me.TxtAPIpublicKey.Size = New System.Drawing.Size(203, 20)
        Me.TxtAPIpublicKey.TabIndex = 3
        Me.TxtAPIpublicKey.Text = "db2c26ab0f0d875e2292770305a80ebb"
        '
        'TxtAPIPrivateKey
        '
        Me.TxtAPIPrivateKey.Location = New System.Drawing.Point(135, 50)
        Me.TxtAPIPrivateKey.Name = "TxtAPIPrivateKey"
        Me.TxtAPIPrivateKey.Size = New System.Drawing.Size(203, 20)
        Me.TxtAPIPrivateKey.TabIndex = 4
        Me.TxtAPIPrivateKey.Text = "3e8f9b1afa733da337e14f38fd0df7cc"
        '
        'TxtWebSite
        '
        Me.TxtWebSite.Location = New System.Drawing.Point(135, 76)
        Me.TxtWebSite.Name = "TxtWebSite"
        Me.TxtWebSite.Size = New System.Drawing.Size(203, 20)
        Me.TxtWebSite.TabIndex = 5
        Me.TxtWebSite.Text = "http://api.sheepgenetics.org.au/api/1"
        '
        'TxtUserId
        '
        Me.TxtUserId.Location = New System.Drawing.Point(135, 102)
        Me.TxtUserId.Name = "TxtUserId"
        Me.TxtUserId.Size = New System.Drawing.Size(133, 20)
        Me.TxtUserId.TabIndex = 6
        Me.TxtUserId.Text = "centreplus"
        '
        'TxtPassWord
        '
        Me.TxtPassWord.Location = New System.Drawing.Point(135, 128)
        Me.TxtPassWord.Name = "TxtPassWord"
        Me.TxtPassWord.Size = New System.Drawing.Size(133, 20)
        Me.TxtPassWord.TabIndex = 7
        Me.TxtPassWord.Text = "centre+sheep01"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Web Site"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "User ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pass Word"
        '
        'ButCallID
        '
        Me.ButCallID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButCallID.Location = New System.Drawing.Point(694, 16)
        Me.ButCallID.Name = "ButCallID"
        Me.ButCallID.Size = New System.Drawing.Size(94, 30)
        Me.ButCallID.TabIndex = 11
        Me.ButCallID.Text = "Call ID"
        Me.ButCallID.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtID.Location = New System.Drawing.Point(537, 22)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(134, 20)
        Me.TxtID.TabIndex = 12
        Me.TxtID.Text = "6012502017707071"
        '
        'ButCallASBV
        '
        Me.ButCallASBV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButCallASBV.Location = New System.Drawing.Point(694, 66)
        Me.ButCallASBV.Name = "ButCallASBV"
        Me.ButCallASBV.Size = New System.Drawing.Size(94, 30)
        Me.ButCallASBV.TabIndex = 13
        Me.ButCallASBV.Text = "Call ASBV's"
        Me.ButCallASBV.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButCallASBV)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.ButCallID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPassWord)
        Me.Controls.Add(Me.TxtUserId)
        Me.Controls.Add(Me.TxtWebSite)
        Me.Controls.Add(Me.TxtAPIPrivateKey)
        Me.Controls.Add(Me.TxtAPIpublicKey)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBResult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBResult As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAPIpublicKey As TextBox
    Friend WithEvents TxtAPIPrivateKey As TextBox
    Friend WithEvents TxtWebSite As TextBox
    Friend WithEvents TxtUserId As TextBox
    Friend WithEvents TxtPassWord As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ButCallID As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents ButCallASBV As Button
End Class
