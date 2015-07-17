Imports System.Data.SQLite

Module Module1
    Public NorthClicks, EastClicks, MonsterTier, PlayerLevel, FirstEdj As Integer
    Public arrCurrentHealth(6) As Integer
    Public G As Integer
    Public CityName, MyName As String, CurrentEdjimon As Integer
    Public CurrentEnemyHealth, RareCount, SuperRareCount, TotalCount As Integer
    Public ClassType As Integer, MonsterAttack(3) As Integer, MonsterAttName(3) As String, MonsterAttCount As Integer

    Public CharNames(99) As String  'When selecting a character
    Public MapSpaces(80) As PictureBox  'Map spaces
    Public Vulns(11) As Single, EnemyStats(4) As Integer, TheEdjimons, Enemies As New Collection
    'Vulns(0) = Grass
    'Vulns(1) = Metal
    'Vulns(2) = Fire
    'Vulns(3) = Water
    'Vulns(4) = Toxic
    'Vulns(5) = Normal
    'Vulns(6) = Ice
    'Vulns(7) = Undead
    'Vulns(8) = Psychic
    'Vulns(9) = RockVuln
    'Vulns(10) = Airborne
    'Vulns(11) = Electric

    'EnemyStats(0) = current health
    'EnemyStats(1) = total health
    'EnemyStats(2) = attack
    'EnemyStats(3) = defense
    'EnemyStats(4) = speed
    'EnemyStats(5) = level
    'EnemyStats(6) = xp
    'EnemyStats(7) = name

    Public LiteConn As SQLiteConnection
    Public LiteConnString As String


    Sub TierDetermine()

        If (NorthClicks >= 40 And NorthClicks < 75 And EastClicks >= 40 And EastClicks < 45) Or (NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 45 And EastClicks < 53) Then
            MonsterTier = 1
        ElseIf NorthClicks >= 15 And NorthClicks < 65 And EastClicks >= 60 And EastClicks < 75 Then
            MonsterTier = 2
        ElseIf (NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 25 And EastClicks < 45) Or (NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 45 And EastClicks < 60) Then
            MonsterTier = 3
        ElseIf (NorthClicks >= 15 And NorthClicks < 35 And EastClicks >= 40 And EastClicks < 45) Or (NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 15 And EastClicks < 40) Or (NorthClicks >= 25 And NorthClicks < 50 And EastClicks >= 10 And EastClicks < 15) Or (NorthClicks >= 55 And NorthClicks < 70 And EastClicks >= 10 And EastClicks < 15) Then
            MonsterTier = 9
        ElseIf NorthClicks >= 10 And NorthClicks < 25 And EastClicks >= 0 And EastClicks < 10 Then
            MonsterTier = 10
        ElseIf (NorthClicks >= 85 And NorthClicks < 100 And EastClicks >= 10 And EastClicks < 35) Or (NorthClicks >= 70 And NorthClicks < 85 And EastClicks >= 5 And EastClicks < 35) Then
            MonsterTier = 8
        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 30 And EastClicks < 60 Then
            MonsterTier = 7
        ElseIf NorthClicks >= 65 And NorthClicks < 95 And EastClicks >= 60 And EastClicks < 65 Then
            MonsterTier = 5
        ElseIf NorthClicks >= 80 And NorthClicks < 100 And EastClicks >= 65 And EastClicks < 90 Then
            MonsterTier = 6
        ElseIf NorthClicks >= 45 And NorthClicks < 80 And EastClicks >= 80 And EastClicks < 95 Then
            MonsterTier = 4
        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 40 And EastClicks < 45 Then
            MonsterTier = 11    '7 on map
        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 53 And EastClicks < 60 Then
            MonsterTier = 12    '10 on map
        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 60 And EastClicks < 65 Then
            MonsterTier = 13    '11 on map
        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 40 And EastClicks < 45 Then
            MonsterTier = 14    '8 on map
        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 75 And EastClicks < 80 Then
            MonsterTier = 15    '12 on map
        ElseIf NorthClicks >= 0 And NorthClicks < 5 And EastClicks >= 25 And EastClicks < 30 Then
            MonsterTier = 16    '5 on map
        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 10 And EastClicks < 15 Then
            MonsterTier = 17    '3 on map
        ElseIf NorthClicks >= 50 And NorthClicks < 55 And EastClicks >= 10 And EastClicks < 15 Then
            MonsterTier = 18    '2 on map
        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 35 And EastClicks < 40 Then
            MonsterTier = 19    '6 on map
        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 5 And EastClicks < 10 Then
            MonsterTier = 20    '1 on map
        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 25 And EastClicks < 30 Then
            MonsterTier = 21    '4 on map
        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 60 And EastClicks < 65 Then
            MonsterTier = 22    '9 on map
        End If
    End Sub

    Sub MapSpot()
        MapClear()
        Form1.cmdWalkWest.Enabled = True
        Form1.cmdWalkSouth.Enabled = True
        Form1.cmdWalkNorth.Enabled = True
        Form1.cmdWalkEast.Enabled = True
        If NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 0 And EastClicks < 5 Then
            frmMap.P1.Visible = True
            If NorthClicks = 10 Then Form1.cmdWalkSouth.Enabled = False
            If EastClicks = 4 Then Form1.cmdWalkEast.Enabled = False
            If EastClicks = 0 Then Form1.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 15 And NorthClicks < 20 And EastClicks >= 0 And EastClicks < 5 Then
            frmMap.P2.Visible = True
            If EastClicks = 0 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 4 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 0 And EastClicks < 10 Then
            frmMap.P3.Visible = True
            If EastClicks = 0 Then Form1.cmdWalkWest.Enabled = False
            If NorthClicks = 24 Then Form1.cmdWalkNorth.Enabled = False
            If NorthClicks = 20 And EastClicks >= 5 And EastClicks < 10 Then Form1.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P4.Visible = True
            If NorthClicks = 20 Then Form1.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 25 And NorthClicks < 35 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P5.Visible = True
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P6.Visible = True
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 40 And NorthClicks < 50 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P7.Visible = True
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 55 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P8.Visible = True
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 55 And NorthClicks < 60 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P9.Visible = True
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 70 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P10.Visible = True
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 10 And EastClicks < 15 Then
            frmMap.P11.Visible = True
            If NorthClicks = 74 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 5 And EastClicks < 10 Then
            frmMap.P12.Visible = True
            If NorthClicks = 70 Then Form1.cmdWalkSouth.Enabled = False
            If EastClicks = 5 Then Form1.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 75 And NorthClicks < 80 And EastClicks >= 5 And EastClicks < 10 Then
            frmMap.P13.Visible = True
            If EastClicks = 5 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 9 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 80 And NorthClicks < 85 And EastClicks >= 5 And EastClicks < 10 Then
            frmMap.P14.Visible = True
            If EastClicks = 5 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 9 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 5 And EastClicks < 10 Then
            frmMap.P15.Visible = True
            If NorthClicks = 89 Then Form1.cmdWalkNorth.Enabled = False
            If EastClicks = 5 Then Form1.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 10 And EastClicks < 20 Then
            frmMap.P16.Visible = True
            If NorthClicks = 85 Then Form1.cmdWalkSouth.Enabled = False
            If EastClicks = 19 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 90 And NorthClicks < 100 And EastClicks >= 10 And EastClicks < 20 Then
            frmMap.P17.Visible = True
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False
            If EastClicks = 10 Then Form1.cmdWalkWest.Enabled = False
            If NorthClicks >= 90 And NorthClicks < 95 And EastClicks = 19 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 20 And EastClicks < 25 Then
            frmMap.P18.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 25 And EastClicks < 30 Then
            frmMap.P19.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 30 And EastClicks < 37 Then
            frmMap.P20.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 37 And EastClicks < 45 Then
            frmMap.P21.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 45 And EastClicks < 52 Then
            frmMap.P22.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 52 And EastClicks < 60 Then
            frmMap.P23.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P24.Visible = True
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 65 And EastClicks < 70 Then
            frmMap.P25.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 70 And EastClicks < 77 Then
            frmMap.P26.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 77 And EastClicks < 83 Then
            frmMap.P27.Visible = True
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 83 And EastClicks < 90 Then
            frmMap.P28.Visible = True
            If NorthClicks = 95 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Form1.cmdWalkNorth.Enabled = False
            If EastClicks = 89 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 90 And NorthClicks < 95 And EastClicks >= 77 And EastClicks < 83 Then
            frmMap.P29.Visible = True
            If EastClicks = 77 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 82 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 77 And EastClicks < 83 Then
            frmMap.P30.Visible = True
            If EastClicks = 77 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 82 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 80 And NorthClicks < 85 And EastClicks >= 77 And EastClicks < 83 Then
            frmMap.P31.Visible = True
            If EastClicks = 77 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 82 Then Form1.cmdWalkEast.Enabled = False
            If NorthClicks = 80 Then Form1.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 80 And EastClicks >= 85 And EastClicks < 90 Then
            frmMap.P32.Visible = True
            If NorthClicks = 79 Then Form1.cmdWalkNorth.Enabled = False
            If EastClicks = 85 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 89 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 65 And NorthClicks < 70 And EastClicks >= 85 And EastClicks < 90 Then
            frmMap.P33.Visible = True
            If EastClicks = 85 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 89 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 85 And EastClicks < 95 Then
            frmMap.P34.Visible = True
            If EastClicks = 85 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 94 Then Form1.cmdWalkEast.Enabled = False
            If EastClicks >= 90 And EastClicks < 95 And NorthClicks = 64 Then Form1.cmdWalkNorth.Enabled = False
            If EastClicks >= 85 And EastClicks < 90 And NorthClicks = 60 Then Form1.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 60 And EastClicks >= 90 And EastClicks < 95 Then
            frmMap.P35.Visible = True
            If EastClicks = 90 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 94 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 90 And EastClicks < 95 Then
            frmMap.P36.Visible = True
            If NorthClicks = 45 Then Form1.cmdWalkSouth.Enabled = False
            If EastClicks = 94 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 80 And EastClicks < 90 Then
            frmMap.P37.Visible = True
            If NorthClicks = 45 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 49 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 75 And EastClicks < 80 Then
            frmMap.P38.Visible = True
            If NorthClicks = 45 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 49 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 65 And EastClicks < 75 Then
            frmMap.P39.Visible = True
            If NorthClicks = 45 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 49 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P40.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 60 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P41.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P42.Visible = True
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 65 And NorthClicks < 70 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P43.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P44.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 75 And NorthClicks < 85 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P45.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P46.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 90 And NorthClicks < 95 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P47.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 40 And NorthClicks < 45 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P48.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P49.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 25 And NorthClicks < 35 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P50.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P51.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 15 And NorthClicks < 20 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P52.Visible = True
            If EastClicks = 60 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 60 And EastClicks < 65 Then
            frmMap.P53.Visible = True
            If EastClicks = 64 Then Form1.cmdWalkEast.Enabled = False
            If NorthClicks = 10 Then Form1.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 53 And EastClicks < 60 Then
            frmMap.P54.Visible = True
            If NorthClicks = 10 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 14 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 45 And EastClicks < 53 Then
            frmMap.P55.Visible = True
            If NorthClicks = 10 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 14 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P56.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P57.Visible = True
            If NorthClicks = 5 Then Form1.cmdWalkSouth.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 30 And EastClicks < 40 Then
            frmMap.P58.Visible = True
            If NorthClicks = 5 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 9 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 25 And EastClicks < 30 Then
            frmMap.P59.Visible = True
            If EastClicks = 25 Then Form1.cmdWalkWest.Enabled = False
            If NorthClicks = 9 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 0 And NorthClicks < 5 And EastClicks >= 25 And EastClicks < 30 Then
            frmMap.P60.Visible = True
            If NorthClicks = 0 Then Form1.cmdWalkSouth.Enabled = False
            If EastClicks = 25 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 29 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 15 And NorthClicks < 20 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P61.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P62.Visible = True
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 25 And NorthClicks < 35 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P63.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P64.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 40 And NorthClicks < 45 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P65.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P66.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 60 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P67.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P68.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 45 And EastClicks < 53 Then
            frmMap.P69.Visible = True
            If NorthClicks = 60 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 64 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 53 And EastClicks < 60 Then
            frmMap.P70.Visible = True
            If NorthClicks = 60 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 64 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 65 And NorthClicks < 70 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P71.Visible = True
            If EastClicks = 40 Then Form1.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 40 And EastClicks < 45 Then
            frmMap.P72.Visible = True
            If NorthClicks = 74 Then Form1.cmdWalkNorth.Enabled = False
            If EastClicks = 44 Then Form1.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 35 And EastClicks < 40 Then
            frmMap.P73.Visible = True
            If NorthClicks = 70 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 28 And EastClicks < 35 Then
            frmMap.P74.Visible = True
            If NorthClicks = 70 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 22 And EastClicks < 28 Then
            frmMap.P75.Visible = True
            If NorthClicks = 70 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 15 And EastClicks < 22 Then
            frmMap.P76.Visible = True
            If NorthClicks = 70 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 15 And EastClicks < 22 Then
            frmMap.P77.Visible = True
            If NorthClicks = 20 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 22 And EastClicks < 28 Then
            frmMap.P78.Visible = True
            If NorthClicks = 20 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 28 And EastClicks < 35 Then
            frmMap.P79.Visible = True
            If NorthClicks = 20 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Form1.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 35 And EastClicks < 40 Then
            frmMap.P80.Visible = True
            If NorthClicks = 20 Then Form1.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Form1.cmdWalkNorth.Enabled = False
        End If

    End Sub

    Sub MaptoArray()
        MapSpaces(1) = frmMap.P1
        MapSpaces(2) = frmMap.P2
        MapSpaces(3) = frmMap.P3
        MapSpaces(4) = frmMap.P4
        MapSpaces(5) = frmMap.P5
        MapSpaces(6) = frmMap.P6
        MapSpaces(7) = frmMap.P7
        MapSpaces(8) = frmMap.P8
        MapSpaces(9) = frmMap.P9
        MapSpaces(10) = frmMap.P10
        MapSpaces(11) = frmMap.P11
        MapSpaces(12) = frmMap.P12
        MapSpaces(13) = frmMap.P13
        MapSpaces(14) = frmMap.P14
        MapSpaces(15) = frmMap.P15
        MapSpaces(16) = frmMap.P16
        MapSpaces(17) = frmMap.P17
        MapSpaces(18) = frmMap.P18
        MapSpaces(19) = frmMap.P19
        MapSpaces(20) = frmMap.P20
        MapSpaces(21) = frmMap.P21
        MapSpaces(22) = frmMap.P22
        MapSpaces(23) = frmMap.P23
        MapSpaces(24) = frmMap.P24
        MapSpaces(25) = frmMap.P25
        MapSpaces(26) = frmMap.P26
        MapSpaces(27) = frmMap.P27
        MapSpaces(28) = frmMap.P28
        MapSpaces(29) = frmMap.P29
        MapSpaces(30) = frmMap.P30
        MapSpaces(31) = frmMap.P31
        MapSpaces(32) = frmMap.P32
        MapSpaces(33) = frmMap.P33
        MapSpaces(34) = frmMap.P34
        MapSpaces(35) = frmMap.P35
        MapSpaces(36) = frmMap.P36
        MapSpaces(37) = frmMap.P37
        MapSpaces(38) = frmMap.P38
        MapSpaces(39) = frmMap.P39
        MapSpaces(40) = frmMap.P40
        MapSpaces(41) = frmMap.P41
        MapSpaces(42) = frmMap.P42
        MapSpaces(43) = frmMap.P43
        MapSpaces(44) = frmMap.P44
        MapSpaces(45) = frmMap.P45
        MapSpaces(46) = frmMap.P46
        MapSpaces(47) = frmMap.P47
        MapSpaces(48) = frmMap.P48
        MapSpaces(49) = frmMap.P49
        MapSpaces(50) = frmMap.P50
        MapSpaces(51) = frmMap.P51
        MapSpaces(52) = frmMap.P52
        MapSpaces(53) = frmMap.P53
        MapSpaces(54) = frmMap.P54
        MapSpaces(55) = frmMap.P55
        MapSpaces(56) = frmMap.P56
        MapSpaces(57) = frmMap.P57
        MapSpaces(58) = frmMap.P58
        MapSpaces(59) = frmMap.P59
        MapSpaces(60) = frmMap.P60
        MapSpaces(61) = frmMap.P61
        MapSpaces(62) = frmMap.P62
        MapSpaces(63) = frmMap.P63
        MapSpaces(64) = frmMap.P64
        MapSpaces(65) = frmMap.P65
        MapSpaces(66) = frmMap.P66
        MapSpaces(67) = frmMap.P67
        MapSpaces(68) = frmMap.P68
        MapSpaces(69) = frmMap.P69
        MapSpaces(70) = frmMap.P70
        MapSpaces(71) = frmMap.P71
        MapSpaces(72) = frmMap.P72
        MapSpaces(73) = frmMap.P73
        MapSpaces(74) = frmMap.P74
        MapSpaces(75) = frmMap.P75
        MapSpaces(76) = frmMap.P76
        MapSpaces(77) = frmMap.P77
        MapSpaces(78) = frmMap.P78
        MapSpaces(79) = frmMap.P79
        MapSpaces(80) = frmMap.P80
    End Sub

    Sub MapClear()
        Dim x As Integer
        For x = 1 To 80
            MapSpaces(x).Visible = False
        Next
    End Sub

    Sub NoMonsterFound()
        Form1.imgPlayer.Image = Nothing
        Form1.imgEnemy.Image = Nothing
        Form1.lblStatement.Text = "Found nothing."
        Form1.lblPlayerLevel.Text = ""
        Form1.lblPlayerName.Text = ""
        Form1.lblEnemyLevel.Text = ""
        Form1.prgPlayerLvlProg.Visible = False
        Form1.prgPlayerHealth.Visible = False
        Form1.prgEnemyHealth.Visible = False
        Form1.lblEnemyName.Text = ""
        Form1.imgPlayer.Visible = False
        Form1.imgEnemy.Visible = False
        Form1.Label5.Visible = False
        Form1.Label2.Visible = False
        Form1.Label6.Visible = False
        Form1.Label3.Visible = False
        Form1.tolPlayer1.Enabled = False
        Form1.tolPlayer2.Enabled = False
        Form1.tolPlayer3.Enabled = False
        Form1.tolPlayer4.Enabled = False
        Form1.tolPLayer5.Enabled = False
        Form1.tolPlayer6.Enabled = False
    End Sub

    Sub LoadChar(ByVal CurEdj As Edjimons)
        Form1.imgPlayer.Image = CurEdj.EdjPic
        Form1.lblPlayerName.Text = CurEdj.EdjName
        Form1.lblPlayerLevel.Text = "LVL: " & CurEdj.PlayerLevel
        Form1.lblCurrentPlayerHealth.Text = CurEdj.CurrentHealth & " / " & CurEdj.PlayerHealth
        Form1.prgPlayerHealth.Visible = True
        Form1.prgPlayerLvlProg.Visible = True
        Form1.prgPlayerHealth.Maximum = CurEdj.PlayerHealth
        Form1.prgPlayerHealth.Value = CurEdj.PlayerHealth
        Form1.imgPlayer.Visible = True
        Form1.imgEnemy.Visible = True
        Form1.Label5.Visible = True
        Form1.Label2.Visible = True
        Form1.Label6.Visible = True
        Form1.Label3.Visible = True
        Form1.tolPlayer1.Enabled = True
        Form1.tolPlayer2.Enabled = True
        Form1.tolPlayer3.Enabled = True
        Form1.tolPlayer4.Enabled = True
        Form1.tolPLayer5.Enabled = True
        Form1.tolPlayer6.Enabled = True
    End Sub

    Sub MonsterDetermine()
        Dim Hlth, Attk, Def, Spd, XP, level, x As Integer
        Dim Name As String
        Dim Edj As Edjimons, CurEnemy As New Enemy

        Select Case MonsterTier
            Case 1
                level = Int(Rnd() * 4) + 3
                x = Int(Rnd() * 1000)
                'changed 12 to 14 on all of them to accomidate more dudes
                If x < 289 Then
                    Name = ""
                ElseIf x >= 289 And x < 389 Then
                    Name = "Treep"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(0)
                    Hlth = (level * 3) + 8
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 389 And x < 489 Then
                    Name = "Vinyan"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(1)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 489 And x < 589 Then
                    Name = "Scorpo"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(2)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 589 And x < 689 Then
                    Name = "Kitticar"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(3)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 6
                ElseIf x >= 689 And x < 789 Then
                    Name = "Hiss"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(4)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 789 And x < 889 Then
                    Name = "Skyte"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(5)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                ElseIf x >= 889 And x < 989 Then
                    Name = "Oryion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(6)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 6
                ElseIf x > 988 <= 998 Then
                    Name = "Toasti"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(7)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                ElseIf x = 999 Then
                    Name = "Laziclaw"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(8)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 9
                    Def = (level * 1) + 4
                    Spd = (level * 1) - 2
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 6
                End If
            Case 2
                level = Int(Rnd() * 6) + 10
                x = Int(Rnd() * 1000)
                If x < 288 Then
                    Name = ""
                ElseIf x >= 288 And x < 463 Then
                    Name = "Rockin"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(19)
                    Hlth = (level * 2) + 11
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 463 And x < 638 Then
                    Name = "Pebblia"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(20)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 6
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 638 And x < 813 Then
                    Name = "Guns"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(10)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 813 And x < 988 Then
                    Name = "Bronze Construct"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(11)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 988 And x < 998 Then
                    Name = "Orite"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(12)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 6
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 2
                ElseIf x = 998 Then
                    Name = "Roughion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(21)
                    Hlth = (level * 3) + 16
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 10
                ElseIf x = 999 Then
                    Name = "Incubat"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(22)
                    Hlth = (level * 1) + 7
                    Attk = (level * 2) - 2
                    Def = (level * 2) - 2
                    Spd = (level * 2) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 9
                End If
            Case 3
                level = Int(Rnd() * 5) + 16
                x = Int(Rnd() * 1000)
                If x < 295 Then
                    Name = ""
                ElseIf x >= 295 And x < 409 Then
                    Name = "Treep"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(0)
                    Hlth = (level * 3) + 8
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 409 And x < 523 Then
                    Name = "Vinyan"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(1)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 523 And x < 637 Then
                    Name = "Scorpo"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(2)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 637 And x < 751 Then
                    Name = "Stickum"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(23)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 1
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 751 And x < 865 Then
                    Name = "Hiss"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(4)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 865 And x < 979 Then
                    Name = "Skyte"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(5)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                ElseIf x >= 979 And x < 989 Then
                    Name = "Volchik"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(13)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 18
                ElseIf x >= 989 And x < 999 Then
                    Name = "Cion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(24)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 9
                ElseIf x = 999 Then
                    Name = "Mantid"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(25)
                    Hlth = (level * 3) + 9
                    Attk = (level * 1) + 7
                    Def = (level * 1) - 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 1
                End If
            Case 4
                level = Int(Rnd() * 6) + 20
                x = Int(Rnd() * 1000)
                If x < 299 Then
                    Name = ""
                ElseIf x >= 299 And x < 435 Then
                    Name = "Ponder"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(14)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                ElseIf x >= 435 And x < 571 Then
                    Name = "Hermit"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(15)
                    Hlth = (level * 3) + 8
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 4
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                ElseIf x >= 571 And x < 707 Then
                    Name = "Poliba"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(9)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                ElseIf x >= 707 And x < 843 Then
                    Name = "Floikes"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(26)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                ElseIf x >= 843 And x < 979 Then
                    Name = "Aircrew"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(27)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 21
                ElseIf x >= 979 And x < 989 Then
                    Name = "Electreel"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(28)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 15
                ElseIf x >= 989 And x < 999 Then
                    Name = "Komsaikai"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(29)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 4
                ElseIf x = 999 Then
                    Name = "Icekerzo"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(30)
                    Hlth = (level * 2) + 25
                    Attk = (level * 1) + 12
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 7
                End If
            Case 5
                level = Int(Rnd() * 5) + 22
                x = Int(Rnd() * 1000)
                If x < 299 Then
                    Name = ""
                ElseIf x >= 299 And x < 435 Then
                    Name = "Snowball"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(31)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 7
                ElseIf x >= 435 And x < 571 Then
                    Name = "Pebblia"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(20)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 6
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 571 And x < 707 Then
                    Name = "Poliba"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(9)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                ElseIf x >= 707 And x < 843 Then
                    Name = "Kitticar"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(3)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 6
                ElseIf x >= 843 And x < 979 Then
                    Name = "Oryion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(6)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 6
                ElseIf x >= 979 And x < 989 Then
                    Name = "Thormion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(32)
                    Hlth = (level * 3) + 11
                    Attk = (level * 1) + 1
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 10
                ElseIf x >= 989 And x < 999 Then
                    Name = "Kommion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(33)
                    Hlth = (level * 3) + 11
                    Attk = (level * 1) + 7
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 20
                ElseIf x = 999 Then
                    Name = "Roughion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(21)
                    Hlth = (level * 3) + 16
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 10
                End If
            Case 6
                level = Int(Rnd() * 6) + 25
                x = Int(Rnd() * 1000)
                If x < 295 Then
                    Name = ""
                ElseIf x >= 295 And x < 409 Then
                    Name = "Ponder"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(14)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                ElseIf x >= 409 And x < 523 Then
                    Name = "Hermit"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(15)
                    Hlth = (level * 3) + 8
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 4
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                ElseIf x >= 523 And x < 637 Then
                    Name = "Poliba"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(9)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                ElseIf x >= 637 And x < 751 Then
                    Name = "Floikes"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(26)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 7
                ElseIf x >= 751 And x < 865 Then
                    Name = "Aircrew"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(27)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 21
                ElseIf x >= 865 And x < 979 Then
                    Name = "Komsaikai"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(29)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                ElseIf x >= 979 And x < 989 Then
                    Name = "Electreel"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(28)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 15
                ElseIf x >= 989 And x < 999 Then
                    Name = "Waterwing"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(34)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 4
                    Spd = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 21
                ElseIf x = 999 Then
                    Name = "Icekerzo"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(30)
                    Hlth = (level * 2) + 25
                    Attk = (level * 1) + 12
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 7
                End If
            Case 7
                level = Int(Rnd() * 6) + 30
                x = Int(Rnd() * 1000)
                If x < 300 Then
                    Name = ""
                ElseIf x >= 300 And x < 413 Then
                    Name = "Scorpo"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(2)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 413 And x < 526 Then
                    Name = "Ravipion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(35)
                    Hlth = (level * 3) + 16
                    Attk = (level * 1) + 10
                    Def = (level * 1) + 8
                    Spd = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 526 And x < 639 Then
                    Name = "Hiss"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(4)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 639 And x < 752 Then
                    Name = "Skyte"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(5)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                ElseIf x >= 752 And x < 865 Then
                    Name = "Aires"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(36)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 11
                ElseIf x >= 865 And x < 978 Then
                    Name = "Guns"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(10)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 978 And x < 988 Then
                    Name = "Streamain"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(37)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 22
                ElseIf x >= 988 And x < 998 Then
                    Name = "Combustor"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(38)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 10
                    Def = (level * 1) + 10
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                ElseIf x = 998 Then
                    Name = "Poliba"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(9)
                    Form1.prgEnemyHealth.Visible = True
                    Hlth = (level * 1) + 10
                    Attk = (level * 2) - 1
                    Def = (level * 2) - 1
                    Spd = (level * 2) - 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    ClassType = 5
                    Beep()
                ElseIf x = 999 Then
                    Name = "Cire"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(39)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 12
                End If
            Case 8
                level = Int(Rnd() * 6) + 35
                x = Int(Rnd() * 1000)
                If x < 298 Then
                    Name = ""
                ElseIf x >= 298 And x < 434 Then
                    Name = "Corpse"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(40)
                    Hlth = (level * 3) + 11
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 16
                ElseIf x >= 434 And x < 570 Then
                    Name = "Hellion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(41)
                    Hlth = (level * 3) + 9
                    Attk = (level * 1) + 1
                    Def = (level * 1) + 1
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 8
                ElseIf x >= 570 And x < 706 Then
                    Name = "Zombones"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(42)
                    Hlth = (level * 4) + 8
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 0
                    Spd = (level * 1) - 2
                    TotalCount = TotalCount + 1
                    ClassType = 8
                ElseIf x >= 706 And x < 842 Then
                    Name = "Rockin"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(19)
                    Hlth = (level * 2) + 11
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 842 And x < 978 Then
                    Name = "Rocky"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(43)
                    Hlth = (level * 2) + 22
                    Attk = (level * 1) + 8
                    Def = (level * 1) + 14
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 978 And x < 988 Then
                    Name = "Drift"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(44)
                    Hlth = (level * 1) + 9
                    Attk = (level * 2) - 4
                    Def = (level * 2) - 2
                    Spd = (level * 2) - 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 8
                ElseIf x >= 988 And x < 998 Then
                    Name = "Volcipeon"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(45)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                ElseIf x = 998 Then
                    Name = "Wraith"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(46)
                    Hlth = (level * 1) + 12
                    Attk = (level * 2) - 4
                    Def = (level * 2) - 2
                    Spd = (level * 2) + 0
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 8
                ElseIf x = 999 Then
                    Name = "Smogg"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(47)
                    Hlth = (level * 1) + 10
                    Attk = (level * 2) - 1
                    Def = (level * 2) - 1
                    Spd = (level * 2) - 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 5
                End If
            Case 9
                level = Int(Rnd() * 6) + 40
                x = Int(Rnd() * 1000)
                If x < 299 Then
                    Name = ""
                ElseIf x >= 299 And x < 396 Then
                    Name = "Treep"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(0)
                    Hlth = (level * 3) + 8
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 7
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 396 And x < 493 Then
                    Name = "Namu"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(48)
                    Hlth = (level * 3) + 16
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 14
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 1
                ElseIf x >= 493 And x < 590 Then
                    Name = "Bronze Construct"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(11)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 590 And x < 687 Then
                    Name = "Iron Construct"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(16)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 10
                    Def = (level * 1) + 10
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 687 And x < 784 Then
                    Name = "Ravipion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(35)
                    Hlth = (level * 3) + 16
                    Attk = (level * 1) + 10
                    Def = (level * 1) + 8
                    Spd = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    ClassType = 5
                ElseIf x >= 784 And x < 881 Then
                    Name = "Orite"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(12)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 6
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 881 And x < 978 Then
                    Name = "Aurorite"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(49)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 12
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 978 And x < 988 Then
                    Name = "Zapawk"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(50)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 4
                    Spd = (level * 1) + 6
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 18
                ElseIf x >= 988 And x < 998 Then
                    Name = "Excitrik"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(51)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 12
                ElseIf x = 998 Then
                    Name = "Volcipeon"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(45)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 3
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 3
                ElseIf x = 999 Then
                    Name = "Mantid"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(25)
                    Hlth = (level * 3) + 9
                    Attk = (level * 1) + 7
                    Def = (level * 1) - 1
                    Spd = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 1
                End If
            Case 10
                level = Int(Rnd() * 10) + 46
                x = Int(Rnd() * 1000)
                If x < 296 Then
                    Name = ""
                ElseIf x >= 296 And x < 408 Then
                    Name = "Streamain"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(37)
                    Hlth = (level * 2) + 10
                    Attk = (level * 1) + 2
                    Def = (level * 1) + 3
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 22
                ElseIf x >= 408 And x < 520 Then
                    Name = "Boulda"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(52)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 12
                    Def = (level * 1) + 12
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 520 And x < 632 Then
                    Name = "Snowstrom"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(53)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 4
                    Spd = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 7
                ElseIf x >= 632 And x < 744 Then
                    Name = "Aires"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(36)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 6
                    Def = (level * 1) + 2
                    Spd = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 11
                ElseIf x >= 744 And x < 856 Then
                    Name = "Rocky"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(43)
                    Hlth = (level * 2) + 22
                    Attk = (level * 1) + 8
                    Def = (level * 1) + 14
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                ElseIf x >= 856 And x < 968 Then
                    Name = "Gunnery"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(17)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 12
                    Def = (level * 1) + 10
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                ElseIf x >= 968 And x < 978 Then
                    Name = "Mountking"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(54)
                    Hlth = (level * 3) + 18
                    Attk = (level * 1) + 4
                    Def = (level * 1) + 14
                    Spd = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 22
                ElseIf x >= 978 And x < 988 Then
                    Name = "Roughion"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(21)
                    Hlth = (level * 3) + 16
                    Attk = (level * 1) + 5
                    Def = (level * 1) + 5
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 10
                ElseIf x >= 988 And x < 998 Then
                    Name = "Tankimnida"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(18)
                    Hlth = (level * 2) + 40
                    Attk = (level * 1) + 24
                    Def = (level * 1) + 20
                    Spd = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 2
                ElseIf x = 998 Then
                    Name = "Supresloth"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(55)
                    Hlth = (level * 2) + 20
                    Attk = (level * 1) + 18
                    Def = (level * 1) + 8
                    Spd = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 6
                ElseIf x = 999 Then
                    Name = "Cloudd"
                    Form1.imgEnemy.Image = Form1.EdjImages.Images.Item(56)
                    Hlth = (level * 1) + 20
                    Attk = (level * 2) + 4
                    Def = (level * 2) + 4
                    Spd = (level * 2) + 2
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 5
                End If
            Case 11
                Name = "CITY"
                CityName = "Shijak Town"
            Case 12
                Name = "CITY"
                CityName = "Raupolis"
            Case 13
                Name = "CITY"
                CityName = "Jay Town"
            Case 14
                Name = "CITY"
                CityName = "Ahpville"
            Case 15
                Name = "CITY"
                CityName = "Eden"
            Case 16
                Name = "CITY"
                CityName = "Mahogitown"
            Case 17
                Name = "CITY"
                CityName = "Tirpimo Town"
            Case 18
                Name = "CITY"
                CityName = "Lirpom"
            Case 19
                Name = "CITY"
                CityName = "Central"
            Case 20
                Name = "CITY"
                CityName = "Dawn"
            Case 21
                Name = "CITY"
                CityName = "Oreville"
            Case 22
                Name = "CITY"
                CityName = "Padatka City"
        End Select

        If Name = "" Or Name = "CITY" Then
            NoMonsterFound()
            If Name = "CITY" Then
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            End If
        Else
            Form1.lblEnemyName.Text = Name
            Form1.lblStatement.Text = "You found " & Name & "!"
            Form1.prgEnemyHealth.Visible = True
            Form1.prgEnemyHealth.Maximum = Hlth
            Form1.prgEnemyHealth.Value = Hlth
            Form1.lblEnemyLevel.Text = "LVL: " & level
            CurEnemy.FoundEnemy(Hlth, Attk, Def, Spd, level, XP, Name)
            Enemies.Add(CurEnemy)
            Edj = TheEdjimons(CurrentEdjimon)
            LoadChar(Edj)
        End If

        StatCalc()
        MonsterVulns()
    End Sub

    Sub MonsterVulns()
        'Vulns(0) = Grass
        'Vulns(1) = Metal
        'Vulns(2) = Fire
        'Vulns(3) = Water
        'Vulns(4) = Toxic
        'Vulns(5) = Normal
        'Vulns(6) = Ice
        'Vulns(7) = Undead
        'Vulns(8) = Psychic
        'Vulns(9) = RockVuln
        'Vulns(10) = Airborne
        'Vulns(11) = Electric

        Select Case ClassType
            Case 1
                Vulns(0) = 0.5
                Vulns(1) = 1
                Vulns(2) = 2
                Vulns(3) = 0.5
                Vulns(4) = 0.5
                Vulns(5) = 1
                Vulns(6) = 1
                Vulns(7) = 1
                Vulns(8) = 1
                Vulns(9) = 1
                Vulns(10) = 2
                Vulns(11) = 0.5
            Case 2
                Vulns(0) = 1
                Vulns(1) = 0.5
                Vulns(2) = 1
                Vulns(3) = 1
                Vulns(4) = 2
                Vulns(5) = 0.5
                Vulns(6) = 0.5
                Vulns(7) = 1
                Vulns(8) = 2
                Vulns(9) = 1
                Vulns(10) = 1
                Vulns(11) = 1
            Case 3
                Vulns(0) = 0.5
                Vulns(1) = 1
                Vulns(2) = 0.5
                Vulns(3) = 2
                Vulns(4) = 1
                Vulns(5) = 1
                Vulns(6) = 0.5
                Vulns(7) = 1
                Vulns(8) = 1
                Vulns(9) = 2
                Vulns(10) = 1
                Vulns(11) = 1
            Case 4
                Vulns(0) = 2
                Vulns(1) = 1
                Vulns(2) = 0.5
                Vulns(3) = 0.5
                Vulns(4) = 2
                Vulns(5) = 1
                Vulns(6) = 1
                Vulns(7) = 1
                Vulns(8) = 1
                Vulns(9) = 0.5
                Vulns(10) = 1
                Vulns(11) = 2
            Case 5
                Vulns(0) = 2
                Vulns(1) = 0.5
                Vulns(2) = 1
                Vulns(3) = 0.5
                Vulns(4) = 2
                Vulns(5) = 1
                Vulns(6) = 1
                Vulns(7) = 1
                Vulns(8) = 1
                Vulns(9) = 1
                Vulns(10) = 1
                Vulns(11) = 1
            Case 6
                Vulns(0) = 1
                Vulns(1) = 2
                Vulns(2) = 1
                Vulns(3) = 1
                Vulns(4) = 1
                Vulns(5) = 1
                Vulns(6) = 1
                Vulns(7) = 0.5
                Vulns(8) = 0.5
                Vulns(9) = 2
                Vulns(10) = 1
                Vulns(11) = 1
            Case 7
                Vulns(0) = 1
                Vulns(1) = 2
                Vulns(2) = 2
                Vulns(3) = 1
                Vulns(4) = 1
                Vulns(5) = 1
                Vulns(6) = 0.5
                Vulns(7) = 1
                Vulns(8) = 1
                Vulns(9) = 1
                Vulns(10) = 0.5
                Vulns(11) = 0.5
            Case 8
                Vulns(0) = 1
                Vulns(1) = 1
                Vulns(2) = 1
                Vulns(3) = 1
                Vulns(4) = 0.5
                Vulns(5) = 2
                Vulns(6) = 1
                Vulns(7) = 0.5
                Vulns(8) = 0.5
                Vulns(9) = 1
                Vulns(10) = 2
                Vulns(11) = 1
            Case 9
                Vulns(0) = 1
                Vulns(1) = 0.5
                Vulns(2) = 1
                Vulns(3) = 1
                Vulns(4) = 1
                Vulns(5) = 2
                Vulns(6) = 1
                Vulns(7) = 2
                Vulns(8) = 0.5
                Vulns(9) = 0.5
                Vulns(0) = 1
                Vulns(11) = 1
            Case 10
                Vulns(0) = 1
                Vulns(1) = 1
                Vulns(2) = 0.5
                Vulns(3) = 2
                Vulns(4) = 1
                Vulns(5) = 0.5
                Vulns(6) = 1
                Vulns(7) = 1
                Vulns(8) = 2
                Vulns(9) = 0.5
                Vulns(10) = 1
                Vulns(11) = 1
            Case 11
                Vulns(0) = 0.5
                Vulns(1) = 1
                Vulns(2) = 1
                Vulns(3) = 1
                Vulns(4) = 1
                Vulns(5) = 1
                Vulns(6) = 2
                Vulns(7) = 0.5
                Vulns(8) = 1
                Vulns(9) = 1
                Vulns(10) = 0.5
                Vulns(11) = 2
            Case 12
                Vulns(0) = 2
                Vulns(1) = 1
                Vulns(2) = 1
                Vulns(3) = 0.5
                Vulns(4) = 1
                Vulns(5) = 1
                Vulns(6) = 2
                Vulns(7) = 1
                Vulns(8) = 1
                Vulns(9) = 1
                Vulns(10) = 0.5
                Vulns(11) = 0.5
        End Select
    End Sub

    Sub MonsterAttacks()

    End Sub

    Sub StatCalc()
        Form3.lblRareCount.Text = Str(RareCount)
        Form3.lblSuperRareCount.Text = Str(SuperRareCount)
        Form3.lblTotalCount.Text = Str(TotalCount)
        Form3.lblRarePerc.Text = Format((RareCount / TotalCount), "#,#.###%")
        Form3.lblSuperRarePerc.Text = Format((SuperRareCount / TotalCount), "#,#.###%")
    End Sub


End Module
