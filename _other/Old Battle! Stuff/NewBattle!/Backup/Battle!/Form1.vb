Imports System.IO
Imports System.Data.sqlite

Public Class Form1

    Private Sub cmdMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMap.Click
        frmMap.Show()
    End Sub

#Region "Walking..."
    Private Sub cmdWalknorth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkNorth.Click
        NorthClicks = NorthClicks + 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        frmMap.lblCoords.Text = "(" & NorthClicks & ", " & EastClicks & ")"
    End Sub

    Private Sub cmdwalkwest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkWest.Click
        EastClicks = EastClicks - 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        frmMap.lblCoords.Text = "(" & NorthClicks & ", " & EastClicks & ")"
    End Sub

    Private Sub cmdWalkEast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkEast.Click
        EastClicks = EastClicks + 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        frmMap.lblCoords.Text = "(" & NorthClicks & ", " & EastClicks & ")"
    End Sub

    Private Sub cmdWalkSouth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWalkSouth.Click
        NorthClicks = NorthClicks - 1
        TierDetermine()
        MonsterDetermine()
        MapSpot()
        frmMap.lblCoords.Text = "(" & NorthClicks & ", " & EastClicks & ")"
    End Sub
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LiteConn = New SQLiteConnection
        Dim LiteCommand As New SQLiteCommand
        Dim LiteReader As SQLiteDataReader
        Dim Path(2), SQL As String, x, z As Integer, y As Boolean

        Randomize()
        MaptoArray()
        Path(0) = Application.ExecutablePath
        x = Path(0).LastIndexOf("\")
        Path(1) = Mid(Path(0), 1, x + 1)
        Path(2) = Path(1) & "Edjimon.edj"
        y = File.Exists(Path(2))

        If y = False Then
            LiteConnString = "Data Source=" & Path(2) & ";Version=3;New=True;"

            SQL = "CREATE TABLE CharNames " & _
"(" & _
                "CharName VARCHAR(50) NOT NULL, " & _
                "NorthClicks INTEGER NOT NULL DEFAULT 37, " & _
                "EastClicks INTEGER NOT NULL DEFAULT 43, " & _
                "CurrentEdjimon INTEGER NOT NULL DEFAULT 1, " & _
                "Counter INTEGER NOT NULL PRIMARY KEY" & _
");"
            Try
                LiteConn.ConnectionString = LiteConnString
                LiteConn.Open()
                Try
                    LiteCommand.Connection = LiteConn
                    LiteCommand.CommandText = SQL
                    LiteCommand.ExecuteNonQuery()
                    NorthClicks = 37
                    EastClicks = 43
                    FirstEdj = 1
                    Form2.ShowDialog()
                Catch ex As SQLiteException
                    MessageBox.Show("Error interacting with database: " & ex.Message & " (Error No.: " & ex.ErrorCode & ")", "Error", MessageBoxButtons.OK)
                End Try
            Catch ex As SQLiteException
                MessageBox.Show("Error connecting to database: " & ex.Message & " (Error No.: " & ex.ErrorCode & ")", "Error", MessageBoxButtons.OK)
            Finally
                LiteConn.Close()
            End Try
        Else
            LiteConnString = "Data Source=" & Path(2) & ";Version=3;"
            SQL = "SELECT CharName FROM CharNames"
            Try
                LiteConn.ConnectionString = LiteConnString
                LiteConn.Open()
                Try
                    LiteCommand.Connection = LiteConn
                    LiteCommand.CommandText = SQL
                    LiteReader = LiteCommand.ExecuteReader

                    If LiteReader.HasRows = False Then
                        NorthClicks = 37
                        EastClicks = 43
                        FirstEdj = 0
                        Form2.ShowDialog()
                    Else
                        While LiteReader.Read
                            CharNames(z) = LiteReader.GetValue(LiteReader.GetOrdinal("CharName"))
                            SelectChar.ListBox1.Items.Add(CharNames(z))
                            z = z + 1
                        End While
                        LiteReader.Close()
                        SelectChar.ShowDialog()
                    End If
                Catch ex As SQLiteException
                    MessageBox.Show("Error reading from database: " & ex.Message & " (Error No.: " & ex.ErrorCode & ")", "Error", MessageBoxButtons.OK)
                End Try
            Catch ex As SQLiteException
                MessageBox.Show("Error connecting to database: " & ex.Message & " (Error No.: " & ex.ErrorCode & ")", "Error", MessageBoxButtons.OK)
            Finally
                LiteConn.Close()
            End Try
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub tolPlayer1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tolPlayer1.Click

    End Sub
End Class



