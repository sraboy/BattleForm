Module Module1
    Public NorthClicks, EastClicks, MonsterTier, PlayerLevel As Integer
    Public arrCurrentHealth(6) As Integer
    Public arrPlayerName(6) As String, arrPlayerDefense(6), arrPlayerAttack(6), arrPlayerSpeed(6)
    Public arrPlayerLevel(6), arrPlayerHealth(6), G As Integer
    Public CityName As String, x, level As Integer
    Public EnemyHealth, EnemyLevel, EnemyAttack, EnemyDefense, EnemySpeed As Integer
    Public CurrentEnemyHealth, RareCount, SuperRareCount, TotalCount As Integer
    Public ClassType As Integer, MonsterAttack1, MonsterAttack2, MonsterAttack3 As String
    Public MonsterAttack4 As Integer, MonsterAttName1, MonsterAttName2, MonsterAttName3 As String
    Public MonsterAttName4 As String, GrassVuln, MetalVuln, FireVuln, WaterVuln As Single
    Public ToxicVuln, NormalVuln, IceVuln, UndeadVuln, PsychicVuln, RockVuln As Single
    Public AirborneVuln, ElectricVuln As Single, MonsterAttCount As Integer


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

    Sub MapClear()
        frmMap.P1.Visible = False
        frmMap.P2.Visible = False
        frmMap.P3.Visible = False
        frmMap.P4.Visible = False
        frmMap.P5.Visible = False
        frmMap.P6.Visible = False
        frmMap.P7.Visible = False
        frmMap.P8.Visible = False
        frmMap.P9.Visible = False
        frmMap.P10.Visible = False
        frmMap.P11.Visible = False
        frmMap.P12.Visible = False
        frmMap.P13.Visible = False
        frmMap.P14.Visible = False
        frmMap.P15.Visible = False
        frmMap.P16.Visible = False
        frmMap.P17.Visible = False
        frmMap.P18.Visible = False
        frmMap.P19.Visible = False
        frmMap.P20.Visible = False
        frmMap.P21.Visible = False
        frmMap.P22.Visible = False
        frmMap.P23.Visible = False
        frmMap.P24.Visible = False
        frmMap.P25.Visible = False
        frmMap.P26.Visible = False
        frmMap.P27.Visible = False
        frmMap.P28.Visible = False
        frmMap.P29.Visible = False
        frmMap.P30.Visible = False
        frmMap.P31.Visible = False
        frmMap.P32.Visible = False
        frmMap.P33.Visible = False
        frmMap.P34.Visible = False
        frmMap.P35.Visible = False
        frmMap.P36.Visible = False
        frmMap.P37.Visible = False
        frmMap.P38.Visible = False
        frmMap.P39.Visible = False
        frmMap.P40.Visible = False
        frmMap.P41.Visible = False
        frmMap.P42.Visible = False
        frmMap.P43.Visible = False
        frmMap.P44.Visible = False
        frmMap.P45.Visible = False
        frmMap.P46.Visible = False
        frmMap.P47.Visible = False
        frmMap.P48.Visible = False
        frmMap.P49.Visible = False
        frmMap.P50.Visible = False
        frmMap.P51.Visible = False
        frmMap.P52.Visible = False
        frmMap.P53.Visible = False
        frmMap.P54.Visible = False
        frmMap.P55.Visible = False
        frmMap.P56.Visible = False
        frmMap.P57.Visible = False
        frmMap.P58.Visible = False
        frmMap.P59.Visible = False
        frmMap.P60.Visible = False
        frmMap.P61.Visible = False
        frmMap.P62.Visible = False
        frmMap.P63.Visible = False
        frmMap.P64.Visible = False
        frmMap.P65.Visible = False
        frmMap.P66.Visible = False
        frmMap.P67.Visible = False
        frmMap.P68.Visible = False
        frmMap.P69.Visible = False
        frmMap.P70.Visible = False
        frmMap.P71.Visible = False
        frmMap.P72.Visible = False
        frmMap.P73.Visible = False
        frmMap.P74.Visible = False
        frmMap.P75.Visible = False
        frmMap.P76.Visible = False
        frmMap.P77.Visible = False
        frmMap.P78.Visible = False
        frmMap.P79.Visible = False
        frmMap.P80.Visible = False
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

    Sub LoadChar()
        Form1.imgPlayer.Image = Form1.imgPlayer1.Image
        Form1.lblPlayerName.Text = arrPlayerName(1)
        Form1.lblPlayerLevel.Text = "LVL: " & arrPlayerLevel(1)
        Form1.lblCurrentPlayerHealth.Text = arrCurrentHealth(1) & " / " & arrPlayerHealth(1)
        Form1.prgPlayerHealth.Visible = True
        Form1.prgPlayerLvlProg.Visible = True
        Form1.prgPlayerHealth.Maximum = arrPlayerHealth(1)
        Form1.prgPlayerHealth.Value = arrCurrentHealth(1)
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
        Select Case MonsterTier
            Case 1
                level = Int(Rnd() * 4) + 3
                x = Int(Rnd() * 1000)
                'changed 12 to 14 on all of them to accomidate more dudes
                If x < 289 Then
                    NoMonsterFound()
                ElseIf x >= 289 And x < 389 Then
                    Form1.lblEnemyName.Text = "Treep"
                    Form1.lblStatement.Text = "I raped your family!"
                    Form1.imgEnemy.Image = Form1.imgTreep.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 389 And x < 489 Then
                    Form1.lblEnemyName.Text = "Vinyan"
                    Form1.lblStatement.Text = "You found Vinyan!"
                    Form1.imgEnemy.Image = Form1.imgVinyan.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 489 And x < 589 Then
                    Form1.lblEnemyName.Text = "Scorpo"
                    Form1.lblStatement.Text = "You found Scorpo!"
                    Form1.imgEnemy.Image = Form1.imgScorpo.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 589 And x < 689 Then
                    Form1.lblEnemyName.Text = "Kitticar"
                    Form1.lblStatement.Text = "You found Kitticar!"
                    Form1.imgEnemy.Image = Form1.imgKitticar.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x >= 689 And x < 789 Then
                    Form1.lblEnemyName.Text = "Hiss"
                    Form1.lblStatement.Text = "You found Hiss!"
                    Form1.imgEnemy.Image = Form1.imgHiss.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 789 And x < 889 Then
                    Form1.lblEnemyName.Text = "Skyte"
                    Form1.lblStatement.Text = "You found Skyte!"
                    Form1.imgEnemy.Image = Form1.imgSkyte.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 889 And x < 989 Then
                    Form1.lblEnemyName.Text = "Oryion"
                    Form1.lblStatement.Text = "You found Oryion!"
                    Form1.imgEnemy.Image = Form1.imgOryion.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x > 988 <= 998 Then
                    Form1.lblEnemyName.Text = "Toasti"
                    Form1.lblStatement.Text = "You found Toasti!"
                    Form1.imgEnemy.Image = Form1.imgToasti.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Laziclaw"
                    Form1.lblStatement.Text = "You found Laziclaw!"
                    Form1.imgEnemy.Image = Form1.imgLaziclaw.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 9
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) - 2
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 6
                    LoadChar()
                End If
            Case 2
                level = Int(Rnd() * 6) + 10
                x = Int(Rnd() * 1000)
                If x < 288 Then
                    NoMonsterFound()
                ElseIf x >= 288 And x < 463 Then
                    Form1.lblEnemyName.Text = "Rockin"
                    Form1.lblStatement.Text = "You found Rockin!"
                    Form1.imgEnemy.Image = Form1.imgTreep.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 11
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 463 And x < 638 Then
                    Form1.lblEnemyName.Text = "Pebblia"
                    Form1.lblStatement.Text = "You found Pebblia!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 638 And x < 813 Then
                    Form1.lblEnemyName.Text = "Guns"
                    Form1.lblStatement.Text = "You found Guns!"
                    Form1.imgEnemy.Image = Form1.imgGuns.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 813 And x < 988 Then
                    Form1.lblEnemyName.Text = "Bronze Construct"
                    Form1.lblStatement.Text = "You found Bronze Construct!"
                    Form1.imgEnemy.Image = Form1.imgBronzeConstruct.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Form1.lblEnemyName.Text = "Orite"
                    Form1.lblStatement.Text = "You found Orite!"
                    Form1.imgEnemy.Image = Form1.imgOrlite.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x = 998 Then
                    Form1.lblEnemyName.Text = "Roughion"
                    Form1.lblStatement.Text = "You found Roughion!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 10
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Incubat"
                    Form1.lblStatement.Text = "You found Incubat!"
                    Form1.imgEnemy.Image = Form1.imgOrlite.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 7
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 2
                    EnemyDefense = (level * 2) - 2
                    EnemySpeed = (level * 2) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 9
                    LoadChar()
                End If
            Case 3
                level = Int(Rnd() * 5) + 16
                x = Int(Rnd() * 1000)
                If x < 295 Then
                    NoMonsterFound()
                ElseIf x >= 295 And x < 409 Then
                    Form1.lblEnemyName.Text = "Treep"
                    Form1.lblStatement.Text = "I raped your family!"
                    Form1.imgEnemy.Image = Form1.imgTreep.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 409 And x < 523 Then
                    Form1.lblEnemyName.Text = "Vinyan"
                    Form1.lblStatement.Text = "You found Vinyan!"
                    Form1.imgEnemy.Image = Form1.imgVinyan.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 523 And x < 637 Then
                    Form1.lblEnemyName.Text = "Scorpo"
                    Form1.lblStatement.Text = "You found Scorpo!"
                    Form1.imgEnemy.Image = Form1.imgScorpo.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 637 And x < 751 Then
                    Form1.lblEnemyName.Text = "Stickum"
                    Form1.lblStatement.Text = "You found Stickum!"
                    Form1.imgEnemy.Image = Form1.imgKitticar.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 1
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 751 And x < 865 Then
                    Form1.lblEnemyName.Text = "Hiss"
                    Form1.lblStatement.Text = "You found Hiss!"
                    Form1.imgEnemy.Image = Form1.imgHiss.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 865 And x < 979 Then
                    Form1.lblEnemyName.Text = "Skyte"
                    Form1.lblStatement.Text = "You found Skyte!"
                    Form1.imgEnemy.Image = Form1.imgSkyte.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Form1.lblEnemyName.Text = "Volchik"
                    Form1.lblStatement.Text = "You found Volchik!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 18
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Form1.lblEnemyName.Text = "Cion"
                    Form1.lblStatement.Text = "You found Cion!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 9
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Mantid"
                    Form1.lblStatement.Text = "You found Mantid!"
                    Form1.imgEnemy.Image = Form1.imgOrlite.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 9
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 7
                    EnemyDefense = (level * 1) - 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 1
                    LoadChar()
                End If
            Case 4
                level = Int(Rnd() * 6) + 20
                x = Int(Rnd() * 1000)
                If x < 299 Then
                    NoMonsterFound()
                ElseIf x >= 299 And x < 435 Then
                    Form1.lblEnemyName.Text = "Ponder"
                    Form1.lblStatement.Text = "You found Ponder!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 435 And x < 571 Then
                    Form1.lblEnemyName.Text = "Hermit"
                    Form1.lblStatement.Text = "You found Hermit!"
                    Form1.imgEnemy.Image = Form1.imgHermit.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 571 And x < 707 Then
                    Form1.lblEnemyName.Text = "Poliba"
                    Form1.lblStatement.Text = "You found Poliba!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 707 And x < 843 Then
                    Form1.lblEnemyName.Text = "Floikes"
                    Form1.lblStatement.Text = "You found Floikes!"
                    Form1.imgEnemy.Image = Form1.imgKitticar.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 843 And x < 979 Then
                    Form1.lblEnemyName.Text = "Aircrew"
                    Form1.lblStatement.Text = "You found Aircrew!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 21
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Form1.lblEnemyName.Text = "Electreel"
                    Form1.lblStatement.Text = "You found Electreel!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 15
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Form1.lblEnemyName.Text = "Komsaikai"
                    Form1.lblStatement.Text = "You found Komsaikai!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Icekerzo"
                    Form1.lblStatement.Text = "You found Icekerzo!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 25
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 12
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 7
                    LoadChar()
                End If
            Case 5
                level = Int(Rnd() * 5) + 22
                x = Int(Rnd() * 1000)
                If x < 299 Then
                    NoMonsterFound()
                ElseIf x >= 299 And x < 435 Then
                    Form1.lblEnemyName.Text = "Snowball"
                    Form1.lblStatement.Text = "You found Snowball!"
                    Form1.imgEnemy.Image = Form1.imgTreep.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 435 And x < 571 Then
                    Form1.lblEnemyName.Text = "Pebblia"
                    Form1.lblStatement.Text = "You found Pebblia!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 571 And x < 707 Then
                    Form1.lblEnemyName.Text = "Poliba"
                    Form1.lblStatement.Text = "You found Poliba!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 707 And x < 843 Then
                    Form1.lblEnemyName.Text = "Kitticar"
                    Form1.lblStatement.Text = "You found Kitticar!"
                    Form1.imgEnemy.Image = Form1.imgKitticar.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x >= 843 And x < 979 Then
                    Form1.lblEnemyName.Text = "Oryion"
                    Form1.lblStatement.Text = "You found Oryion!"
                    Form1.imgEnemy.Image = Form1.imgOryion.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Form1.lblEnemyName.Text = "Thormion"
                    Form1.lblStatement.Text = "You found Thormion!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 11
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 1
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Form1.lblEnemyName.Text = "Kommion"
                    Form1.lblStatement.Text = "You found Kommion!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 11
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 7
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 20
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Roughion"
                    Form1.lblStatement.Text = "You found Roughion!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 10
                    LoadChar()
                End If
            Case 6
                level = Int(Rnd() * 6) + 25
                x = Int(Rnd() * 1000)
                If x < 295 Then
                    NoMonsterFound()
                ElseIf x >= 295 And x < 409 Then
                    Form1.lblEnemyName.Text = "Ponder"
                    Form1.lblStatement.Text = "You found Ponder!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 409 And x < 523 Then
                    Form1.lblEnemyName.Text = "Hermit"
                    Form1.lblStatement.Text = "You found Hermit!"
                    Form1.imgEnemy.Image = Form1.imgHermit.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 523 And x < 637 Then
                    Form1.lblEnemyName.Text = "Poliba"
                    Form1.lblStatement.Text = "You found Poliba!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 637 And x < 751 Then
                    Form1.lblEnemyName.Text = "Floikes"
                    Form1.lblStatement.Text = "You found Floikes!"
                    Form1.imgEnemy.Image = Form1.imgKitticar.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 751 And x < 865 Then
                    Form1.lblEnemyName.Text = "Aircrew"
                    Form1.lblStatement.Text = "You found Aircrew!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 21
                    LoadChar()
                ElseIf x >= 865 And x < 979 Then
                    Form1.lblEnemyName.Text = "Komsaikai"
                    Form1.lblStatement.Text = "You found Komsaikai!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Form1.lblEnemyName.Text = "Electreel"
                    Form1.lblStatement.Text = "You found Electreel!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 15
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Form1.lblEnemyName.Text = "Waterwing"
                    Form1.lblStatement.Text = "You found Waterwing!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 21
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Icekerzo"
                    Form1.lblStatement.Text = "You found Icekerzo!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 25
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 12
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 7
                    LoadChar()
                End If
            Case 7
                level = Int(Rnd() * 6) + 30
                x = Int(Rnd() * 1000)
                If x < 300 Then
                    NoMonsterFound()
                ElseIf x >= 300 And x < 413 Then
                    Form1.lblEnemyName.Text = "Scorpo"
                    Form1.lblStatement.Text = "You found Scorpo!"
                    Form1.imgEnemy.Image = Form1.imgScorpo.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 413 And x < 526 Then
                    Form1.lblEnemyName.Text = "Ravipion"
                    Form1.lblStatement.Text = "You found Ravipion!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 8
                    EnemySpeed = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 526 And x < 639 Then
                    Form1.lblEnemyName.Text = "Hiss"
                    Form1.lblStatement.Text = "You found Hiss!"
                    Form1.imgEnemy.Image = Form1.imgHiss.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 639 And x < 752 Then
                    Form1.lblEnemyName.Text = "Skyte"
                    Form1.lblStatement.Text = "You found Skyte!"
                    Form1.imgEnemy.Image = Form1.imgSkyte.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 752 And x < 865 Then
                    Form1.lblEnemyName.Text = "Aires"
                    Form1.lblStatement.Text = "You found Aires!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 865 And x < 978 Then
                    Form1.lblEnemyName.Text = "Guns"
                    Form1.lblStatement.Text = "You found Guns!"
                    Form1.imgEnemy.Image = Form1.imgGuns.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Form1.lblEnemyName.Text = "Streamain"
                    Form1.lblStatement.Text = "You found Streamain!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 22
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Form1.lblEnemyName.Text = "Combustor"
                    Form1.lblStatement.Text = "You found Combustor!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 10
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                    LoadChar()
                ElseIf x = 998 Then
                    Form1.lblEnemyName.Text = "Smogg"
                    Form1.lblStatement.Text = "You found Smogg!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 1
                    EnemyDefense = (level * 2) - 1
                    EnemySpeed = (level * 2) - 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    ClassType = 5
                    Beep()
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Cire"
                    Form1.lblStatement.Text = "You found Cire!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 12
                    LoadChar()
                End If
            Case 8
                level = Int(Rnd() * 6) + 35
                x = Int(Rnd() * 1000)
                If x < 298 Then
                    NoMonsterFound()
                ElseIf x >= 298 And x < 434 Then
                    Form1.lblEnemyName.Text = "Corpse"
                    Form1.lblStatement.Text = "You found Corpse!"
                    Form1.imgEnemy.Image = Form1.imgHermit.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 11
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 16
                    LoadChar()
                ElseIf x >= 434 And x < 570 Then
                    Form1.lblEnemyName.Text = "Hellion"
                    Form1.lblStatement.Text = "You found Hellion!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 9
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 1
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 8
                    LoadChar()
                ElseIf x >= 570 And x < 706 Then
                    Form1.lblEnemyName.Text = "Zombones"
                    Form1.lblStatement.Text = "You found Zombones!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 4) + 8
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 0
                    EnemySpeed = (level * 1) - 2
                    TotalCount = TotalCount + 1
                    ClassType = 8
                    LoadChar()
                ElseIf x >= 706 And x < 842 Then
                    Form1.lblEnemyName.Text = "Rockin"
                    Form1.lblStatement.Text = "You found Rockin!"
                    Form1.imgEnemy.Image = Form1.imgTreep.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 11
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 842 And x < 978 Then
                    Form1.lblEnemyName.Text = "Rocky"
                    Form1.lblStatement.Text = "You found Rocky!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 22
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 8
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Form1.lblEnemyName.Text = "Drift"
                    Form1.lblStatement.Text = "You found Drift!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 9
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 4
                    EnemyDefense = (level * 2) - 2
                    EnemySpeed = (level * 2) - 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 8
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Form1.lblEnemyName.Text = "Volcipeon"
                    Form1.lblStatement.Text = "You found Volcipeon!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                    LoadChar()
                ElseIf x = 998 Then
                    Form1.lblEnemyName.Text = "Wraith"
                    Form1.lblStatement.Text = "You found Wraith!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 12
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 4
                    EnemyDefense = (level * 2) - 2
                    EnemySpeed = (level * 2) + 0
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 8
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Smogg"
                    Form1.lblStatement.Text = "You found Smogg!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 1
                    EnemyDefense = (level * 2) - 1
                    EnemySpeed = (level * 2) - 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 5
                    LoadChar()
                End If
            Case 9
                level = Int(Rnd() * 6) + 40
                x = Int(Rnd() * 1000)
                If x < 299 Then
                    NoMonsterFound()
                ElseIf x >= 299 And x < 396 Then
                    Form1.lblEnemyName.Text = "Treep"
                    Form1.lblStatement.Text = "I raped your family!"
                    Form1.imgEnemy.Image = Form1.imgTreep.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 396 And x < 493 Then
                    Form1.lblEnemyName.Text = "Namu"
                    Form1.lblStatement.Text = "You found Namu!"
                    Form1.imgEnemy.Image = Form1.imgNamu.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 493 And x < 590 Then
                    Form1.lblEnemyName.Text = "Bronze Construct"
                    Form1.lblStatement.Text = "You found Bronze Construct!"
                    Form1.imgEnemy.Image = Form1.imgBronzeConstruct.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 590 And x < 687 Then
                    Form1.lblEnemyName.Text = "Iron Construct"
                    Form1.lblStatement.Text = "You found Iron Construct!"
                    Form1.imgEnemy.Image = Form1.imgIronConstruct.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 10
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 687 And x < 784 Then
                    Form1.lblEnemyName.Text = "Ravipion"
                    Form1.lblStatement.Text = "You found Ravipion!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 8
                    EnemySpeed = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 784 And x < 881 Then
                    Form1.lblEnemyName.Text = "Orite"
                    Form1.lblStatement.Text = "You found Orite!"
                    Form1.imgEnemy.Image = Form1.imgOrlite.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 881 And x < 978 Then
                    Form1.lblEnemyName.Text = "Aurorite"
                    Form1.lblStatement.Text = "You found Aurorite!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 12
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Form1.lblEnemyName.Text = "Zapawk"
                    Form1.lblStatement.Text = "You found Zapawk!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 6
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 18
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Form1.lblEnemyName.Text = "Excitrik"
                    Form1.lblStatement.Text = "You found Excitrik!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 12
                    LoadChar()
                ElseIf x = 998 Then
                    Form1.lblEnemyName.Text = "Volcipeon"
                    Form1.lblStatement.Text = "You found Volcipeon!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 3
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Mantid"
                    Form1.lblStatement.Text = "You found Mantid!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 9
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 7
                    EnemyDefense = (level * 1) - 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 1
                    LoadChar()
                End If
            Case 10
                level = Int(Rnd() * 10) + 46
                x = Int(Rnd() * 1000)
                If x < 296 Then
                    NoMonsterFound()
                ElseIf x >= 296 And x < 408 Then
                    Form1.lblEnemyName.Text = "Streamain"
                    Form1.lblStatement.Text = "You found Streamain!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 22
                    LoadChar()
                ElseIf x >= 408 And x < 520 Then
                    Form1.lblEnemyName.Text = "Boulda"
                    Form1.lblStatement.Text = "You found Boulda!"
                    Form1.imgEnemy.Image = Form1.imgPonder.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 12
                    EnemyDefense = (level * 1) + 12
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 520 And x < 632 Then
                    Form1.lblEnemyName.Text = "Snowstrom"
                    Form1.lblStatement.Text = "You found Snowstrom!"
                    Form1.imgEnemy.Image = Form1.imgKitticar.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 632 And x < 744 Then
                    Form1.lblEnemyName.Text = "Aires"
                    Form1.lblStatement.Text = "You found Aires!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 744 And x < 856 Then
                    Form1.lblEnemyName.Text = "Rocky"
                    Form1.lblStatement.Text = "You found Rocky!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 22
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 8
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 856 And x < 968 Then
                    Form1.lblEnemyName.Text = "Gunnery"
                    Form1.lblStatement.Text = "You found Gunnery!"
                    Form1.imgEnemy.Image = Form1.imgGunnery.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 12
                    EnemyDefense = (level * 1) + 10
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 968 And x < 978 Then
                    Form1.lblEnemyName.Text = "Mountking"
                    Form1.lblStatement.Text = "You found Mountking!"
                    Form1.imgEnemy.Image = Form1.imgVolchik.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 18
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 22
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Form1.lblEnemyName.Text = "Roughion"
                    Form1.lblStatement.Text = "You found Roughion!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Form1.lblEnemyName.Text = "Tankimnida"
                    Form1.lblStatement.Text = "You found Tankimnida!"
                    Form1.imgEnemy.Image = Form1.imgTankimnida.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 40
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 24
                    EnemyDefense = (level * 1) + 20
                    EnemySpeed = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x = 998 Then
                    Form1.lblEnemyName.Text = "Supresloth"
                    Form1.lblStatement.Text = "You found Supresloth!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 18
                    EnemyDefense = (level * 1) + 8
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 6
                    LoadChar()
                ElseIf x = 999 Then
                    Form1.lblEnemyName.Text = "Cloudd"
                    Form1.lblStatement.Text = "You found Cloudd!"
                    Form1.imgEnemy.Image = Form1.imgPoliba.Image
                    Form1.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 20
                    Form1.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Form1.prgEnemyHealth.Value = EnemyHealth
                    Form1.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) + 4
                    EnemyDefense = (level * 2) + 4
                    EnemySpeed = (level * 2) + 2
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 5
                    LoadChar()
                End If
            Case 11
                NoMonsterFound()
                CityName = "Shijak Town"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 12
                NoMonsterFound()
                CityName = "Raupolis"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 13
                NoMonsterFound()
                CityName = "Jay Town"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 14
                NoMonsterFound()
                CityName = "Ahpville"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 15
                NoMonsterFound()
                CityName = "Eden"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 16
                NoMonsterFound()
                CityName = "Mahogitown"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 17
                NoMonsterFound()
                CityName = "Tirpimo Town"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 18
                NoMonsterFound()
                CityName = "Lirpom"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 19
                NoMonsterFound()
                CityName = "Central"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 20
                NoMonsterFound()
                CityName = "Dawn"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 21
                NoMonsterFound()
                CityName = "Oreville"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 22
                NoMonsterFound()
                CityName = "Padatka City"
                Form1.lblStatement.Text = "Welcome to " & CityName & "!"
        End Select
        StatCalc()
        MonsterVulns()
    End Sub

    Sub MonsterVulns()
        Select Case ClassType
            Case 1
                GrassVuln = 0.5
                MetalVuln = 1
                FireVuln = 2
                WaterVuln = 0.5
                ToxicVuln = 0.5
                NormalVuln = 1
                IceVuln = 1
                UndeadVuln = 1
                PsychicVuln = 1
                RockVuln = 1
                AirborneVuln = 2
                ElectricVuln = 0.5
            Case 2
                GrassVuln = 1
                MetalVuln = 0.5
                FireVuln = 1
                WaterVuln = 1
                ToxicVuln = 2
                NormalVuln = 0.5
                IceVuln = 0.5
                UndeadVuln = 1
                PsychicVuln = 2
                RockVuln = 1
                AirborneVuln = 1
                ElectricVuln = 1
            Case 3
                GrassVuln = 0.5
                MetalVuln = 1
                FireVuln = 0.5
                WaterVuln = 2
                ToxicVuln = 1
                NormalVuln = 1
                IceVuln = 0.5
                UndeadVuln = 1
                PsychicVuln = 1
                RockVuln = 2
                AirborneVuln = 1
                ElectricVuln = 1
            Case 4
                GrassVuln = 2
                MetalVuln = 1
                FireVuln = 0.5
                WaterVuln = 0.5
                ToxicVuln = 2
                NormalVuln = 1
                IceVuln = 1
                UndeadVuln = 1
                PsychicVuln = 1
                RockVuln = 0.5
                AirborneVuln = 1
                ElectricVuln = 2
            Case 5
                GrassVuln = 2
                MetalVuln = 0.5
                FireVuln = 1
                WaterVuln = 0.5
                ToxicVuln = 2
                NormalVuln = 1
                IceVuln = 1
                UndeadVuln = 1
                PsychicVuln = 1
                RockVuln = 1
                AirborneVuln = 1
                ElectricVuln = 1
            Case 6
                GrassVuln = 1
                MetalVuln = 2
                FireVuln = 1
                WaterVuln = 1
                ToxicVuln = 1
                NormalVuln = 1
                IceVuln = 1
                UndeadVuln = 0.5
                PsychicVuln = 0.5
                RockVuln = 2
                AirborneVuln = 1
                ElectricVuln = 1
            Case 7
                GrassVuln = 1
                MetalVuln = 2
                FireVuln = 2
                WaterVuln = 1
                ToxicVuln = 1
                NormalVuln = 1
                IceVuln = 0.5
                UndeadVuln = 1
                PsychicVuln = 1
                RockVuln = 1
                AirborneVuln = 0.5
                ElectricVuln = 0.5
            Case 8
                GrassVuln = 1
                MetalVuln = 1
                FireVuln = 1
                WaterVuln = 1
                ToxicVuln = 0.5
                NormalVuln = 2
                IceVuln = 1
                UndeadVuln = 0.5
                PsychicVuln = 0.5
                RockVuln = 1
                AirborneVuln = 2
                ElectricVuln = 1
            Case 9
                GrassVuln = 1
                MetalVuln = 0.5
                FireVuln = 1
                WaterVuln = 1
                ToxicVuln = 1
                NormalVuln = 2
                IceVuln = 1
                UndeadVuln = 2
                PsychicVuln = 0.5
                RockVuln = 0.5
                AirborneVuln = 1
                ElectricVuln = 1
            Case 10
                GrassVuln = 1
                MetalVuln = 1
                FireVuln = 0.5
                WaterVuln = 2
                ToxicVuln = 1
                NormalVuln = 0.5
                IceVuln = 1
                UndeadVuln = 1
                PsychicVuln = 2
                RockVuln = 0.5
                AirborneVuln = 1
                ElectricVuln = 1
            Case 11
                GrassVuln = 0.5
                MetalVuln = 1
                FireVuln = 1
                WaterVuln = 1
                ToxicVuln = 1
                NormalVuln = 1
                IceVuln = 2
                UndeadVuln = 0.5
                PsychicVuln = 1
                RockVuln = 1
                AirborneVuln = 0.5
                ElectricVuln = 2
            Case 12
                GrassVuln = 2
                MetalVuln = 1
                FireVuln = 1
                WaterVuln = 0.5
                ToxicVuln = 1
                NormalVuln = 1
                IceVuln = 2
                UndeadVuln = 1
                PsychicVuln = 1
                RockVuln = 1
                AirborneVuln = 0.5
                ElectricVuln = 0.5
        End Select
    End Sub

    Sub MonsterAttacks()
        Select Case ClassType
            Case 2
                If level < 7 Then
                    MonsterAttName1 = "Hit"
                    MonsterAttName2 = ""
                    MonsterAttName3 = ""
                    MonsterAttName4 = ""
                End If
        End Select
    End Sub

    Sub StatCalc()
        Form3.lblRareCount.Text = Str(RareCount)
        Form3.lblSuperRareCount.Text = Str(SuperRareCount)
        Form3.lblTotalCount.Text = Str(TotalCount)
        Form3.lblRarePerc.Text = Format((RareCount / TotalCount), "#,#.###%")
        Form3.lblSuperRarePerc.Text = Format((SuperRareCount / TotalCount), "#,#.###%")
    End Sub


End Module
