Imports System.Data.SQLite

Public Class SelectChar

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If MyName = "" Then
            Form1.btnSkillOne.Enabled = False
            Form1.btnSkillTwo.Enabled = False
            Form1.btnSkillThree.Enabled = False
            Form1.btnSkillFour.Enabled = False
            Form1.cmdWalkNorth.Enabled = False
            Form1.cmdWalkEast.Enabled = False
            Form1.cmdWalkSouth.Enabled = False
            Form1.cmdWalkWest.Enabled = False
        ElseIf MyName <> "" Then
            Me.Hide()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            btnSelect.Enabled = False
        Else
            btnSelect.Enabled = True
        End If
    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        LiteConn = New SQLiteConnection(LiteConnString)
        Dim LiteCommand As New SQLiteCommand
        Dim LiteReader As SQLiteDataReader
        Dim SQL As String, i As Integer

        i = ListBox1.SelectedIndex

        SQL = "SELECT * FROM [" & CharNames(i) & "]"

        Try
            LiteConn.Open()
            Try
                LiteCommand.Connection = LiteConn
                LiteCommand.CommandText = SQL
                LiteReader = LiteCommand.ExecuteReader

                TheEdjimons.Clear()

                While LiteReader.Read
                    Dim x As New Edjimons
                    Dim Name As String, Stats(7) As Integer, Att(3, 2)
                    '"EdjimonName VARCHAR(50) NOT NULL, " & _
                    '"Attack INTEGER NOT NULL, " & _
                    '"Defense INTEGER NOT NULL, " & _
                    '"Speed INTEGER NOT NULL, " & _
                    '"Level INTEGER NOT NULL DEFAULT 1, " & _
                    '"TotalXP INTEGER NOT NULL DEFAULT 0, " & _
                    '"TotalHealth INTEGER NOT NULL DEFAULT 12, " & _
                    '"CurrentHealth INTEGER NOT NULL DEFAULT 12, " & _
                    '"Attack1Name VARCHAR(50), " & _
                    '"Attack1Damage INTEGER, " & _
                    '"Attack1Type INTEGER, " & _
                    '"Attack2Name VARCHAR(50), " & _
                    '"Attack2Damage INTEGER, " & _
                    '"Attack2Type INTEGER, " & _
                    '"Attack3Name VARCHAR(50), " & _
                    '"Attack3Damage INTEGER, " & _
                    '"Attack3Type INTEGER, " & _
                    '"Attack4Name VARCHAR(50), " & _
                    '"Attack4Damage INTEGER, " & _
                    '"Attack4Type INTEGER, " & _

                    Name = LiteReader.GetValue(LiteReader.GetOrdinal("EdjimonName"))
                    Stats(0) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack"))
                    Stats(1) = LiteReader.GetValue(LiteReader.GetOrdinal("Defense"))
                    Stats(2) = LiteReader.GetValue(LiteReader.GetOrdinal("Speed"))
                    Stats(3) = LiteReader.GetValue(LiteReader.GetOrdinal("Level"))
                    Stats(4) = LiteReader.GetValue(LiteReader.GetOrdinal("TotalXP"))
                    Stats(5) = LiteReader.GetValue(LiteReader.GetOrdinal("TotalHealth"))
                    Stats(6) = LiteReader.GetValue(LiteReader.GetOrdinal("CurrentHealth"))
                    Stats(7) = LiteReader.GetValue(LiteReader.GetOrdinal("ImageNum"))

                    Att(0, 0) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack1Name")).ToString
                    Att(0, 1) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack1Damage")).ToString
                    Att(0, 2) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack1Type")).ToString

                    Att(1, 0) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack2Name")).ToString
                    Att(1, 1) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack2Damage")).ToString
                    Att(1, 2) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack2Type")).ToString

                    Att(2, 0) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack3Name")).ToString
                    Att(2, 1) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack3Damage")).ToString
                    Att(2, 2) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack3Type")).ToString

                    Att(3, 0) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack4Name")).ToString
                    Att(3, 1) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack4Damage")).ToString
                    Att(3, 2) = LiteReader.GetValue(LiteReader.GetOrdinal("Attack4Type")).ToString

                    x.CreateFirstEdjimon(Name, Stats(0), Stats(1), Stats(2), Stats(5), Stats(3), Stats(7), Stats(4))
                    x.SetAttacks(Att(0, 0), Att(1, 0), Att(2, 0), Att(3, 0), Att(0, 1), Att(1, 1), Att(2, 1), Att(3, 1), Att(0, 2), Att(1, 2), Att(2, 2), Att(3, 2))

                    If TheEdjimons.Count = 0 Then
                        Form1.tolPlayer1.Image = x.EdjPic
                    ElseIf TheEdjimons.Count = 1 Then
                        Form1.tolPlayer2.Image = x.EdjPic
                    ElseIf TheEdjimons.Count = 2 Then
                        Form1.tolPlayer3.Image = x.EdjPic
                    ElseIf TheEdjimons.Count = 3 Then
                        Form1.tolPlayer4.Image = x.EdjPic
                    ElseIf TheEdjimons.Count = 4 Then
                        Form1.tolPLayer5.Image = x.EdjPic
                    ElseIf TheEdjimons.Count = 5 Then
                        Form1.tolPlayer6.Image = x.EdjPic
                    End If
                    TheEdjimons.Add(x)
                End While
                LiteReader.Close()
                If TheEdjimons.Count > 0 Then
                    Form1.Text = "Battle! - " & CharNames(i)
                    Form1.cmdWalkNorth.Enabled = True
                    Form1.cmdWalkEast.Enabled = True
                    Form1.cmdWalkSouth.Enabled = True
                    Form1.cmdWalkWest.Enabled = True
                End If

                SQL = "SELECT NorthClicks, EastClicks, CurrentEdjimon FROM CharNames WHERE CharName='" & CharNames(i) & "'"

                LiteCommand.CommandText = SQL
                LiteReader = LiteCommand.ExecuteReader
                While LiteReader.Read
                    NorthClicks = LiteReader.GetValue(LiteReader.GetOrdinal("NorthClicks"))
                    EastClicks = LiteReader.GetValue(LiteReader.GetOrdinal("EastClicks"))
                    CurrentEdjimon = LiteReader.GetValue(LiteReader.GetOrdinal("CurrentEdjimon"))
                End While
                LiteReader.Close()

                frmMap.lblCoords.Text = "(" & NorthClicks & ", " & EastClicks & ")"
                MapSpot()

                Form1.Show()
                Me.Hide()
            Catch ex As SQLiteException
                MessageBox.Show("Error reading from database: " & ex.Message & " (Error No.: " & ex.ErrorCode & ")", "Error", MessageBoxButtons.OK)
            End Try
        Catch ex As SQLiteException
            MessageBox.Show("Error connecting to database: " & ex.Message & " (Error No.: " & ex.ErrorCode & ")", "Error", MessageBoxButtons.OK)
        Finally
            LiteConn.Close()
        End Try

    End Sub
End Class