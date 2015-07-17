Imports System.Data.SQLite

Public Class Form2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Form1.tolPlayer1.Image = PictureBox1.Image

        AddChar(13)
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.tolPlayer1.Image = PictureBox2.Image

        AddChar(12)
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form1.tolPlayer1.Image = PictureBox3.Image

        AddChar(9)
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub AddChar(ByVal PicNum As Integer)
        LiteConn = New SQLiteConnection(LiteConnString)
        Dim LiteCommand As New SQLiteCommand
        Dim SQL, TempName As String

        MyName = InputBox("What is your name?", "Your Name", "Patrick Swayze")
        TempName = InputBox("Name your Edjimon.", "What do you want your Edjimon's name to be?", "Edjimon")

        If MyName = "" Or TempName = "" Then
            Exit Sub
        End If

        Dim TempStats(3) As Integer
        TempStats(0) = Int(Rnd() * 11) + 5
        TempStats(1) = Int(Rnd() * 11) + 5
        TempStats(2) = Int(Rnd() * 11) + 5

        Dim x As New Edjimons
        TheEdjimons.Add(x)
        x = TheEdjimons(1)

        x.CreateFirstEdjimon(TempName, TempStats(1), TempStats(2), TempStats(0), 12, 1, PicNum, 0)
        Form1.Button1.Enabled = True
        Form1.tolPlayer1.Text = TempName
        Form1.tolPlayer1.ToolTipText = TempName & vbNewLine & "LVL: 1"
        CurrentEdjimon = 1

        SQL = "INSERT INTO CharNames (CharName,NorthClicks,EastClicks) VALUES " & _
                "('" & MyName & "'," & 37 & "," & 43 & ")"

        Try
            LiteConn.Open()
            Try
                LiteCommand.Connection = LiteConn
                LiteCommand.CommandText = SQL
                LiteCommand.ExecuteNonQuery()

                SQL = "CREATE TABLE [" & MyName & "] " & _
"(" & _
                    "EdjimonName VARCHAR(50) NOT NULL, " & _
                    "Attack INTEGER NOT NULL, " & _
                    "Defense INTEGER NOT NULL, " & _
                    "Speed INTEGER NOT NULL, " & _
                    "Level INTEGER NOT NULL DEFAULT 1, " & _
                    "TotalXP INTEGER NOT NULL DEFAULT 0, " & _
                    "TotalHealth INTEGER NOT NULL DEFAULT 12, " & _
                    "CurrentHealth INTEGER NOT NULL DEFAULT 12, " & _
                    "Attack1Name VARCHAR(50), " & _
                    "Attack1Damage INTEGER DEFAULT 0, " & _
                    "Attack1Type INTEGER DEFAULT 0, " & _
                    "Attack2Name VARCHAR(50), " & _
                    "Attack2Damage INTEGER DEFAULT 0, " & _
                    "Attack2Type INTEGER DEFAULT 0, " & _
                    "Attack3Name VARCHAR(50), " & _
                    "Attack3Damage INTEGER DEFAULT 0, " & _
                    "Attack3Type INTEGER DEFAULT 0, " & _
                    "Attack4Name VARCHAR(50), " & _
                    "Attack4Damage INTEGER DEFAULT 0, " & _
                    "Attack4Type INTEGER DEFAULT 0, " & _
                    "ImageNum INTEGER, " & _
                    "Counter INTEGER NOT NULL PRIMARY KEY" & _
");"

                'Attacks need to be filled in
                SQL = SQL & "INSERT INTO [" & MyName & "] (EdjimonName,Attack,Defense,Speed,ImageNum) VALUES " & _
                        "('" & x.EdjName & "'," & x.PlayerAttack & "," & x.PlayerDefense & "," & x.PlayerSpeed & "," & PicNum & ")"

                LiteCommand.CommandText = SQL
                LiteCommand.ExecuteNonQuery()
            Catch ex As SQLiteException
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As SQLiteException
            MessageBox.Show("CONN : " & ex.Message)
        Finally
            LiteConn.Close()
        End Try
    End Sub
End Class