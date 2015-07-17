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
        Main.cmdWalkWest.Enabled = True
        Main.cmdWalkSouth.Enabled = True
        Main.cmdWalkNorth.Enabled = True
        Main.cmdWalkEast.Enabled = True
        If NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 0 And EastClicks < 5 Then
            Main.P1.Visible = True
            If NorthClicks = 10 Then Main.cmdWalkSouth.Enabled = False
            If EastClicks = 4 Then Main.cmdWalkEast.Enabled = False
            If EastClicks = 0 Then Main.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 15 And NorthClicks < 20 And EastClicks >= 0 And EastClicks < 5 Then
            Main.P2.Visible = True
            If EastClicks = 0 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 4 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 0 And EastClicks < 10 Then
            Main.P3.Visible = True
            If EastClicks = 0 Then Main.cmdWalkWest.Enabled = False
            If NorthClicks = 24 Then Main.cmdWalkNorth.Enabled = False
            If NorthClicks = 20 And EastClicks >= 5 And EastClicks < 10 Then Main.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P4.Visible = True
            If NorthClicks = 20 Then Main.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 25 And NorthClicks < 35 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P5.Visible = True
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P6.Visible = True
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 40 And NorthClicks < 50 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P7.Visible = True
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 55 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P8.Visible = True
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 55 And NorthClicks < 60 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P9.Visible = True
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 70 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P10.Visible = True
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 14 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 10 And EastClicks < 15 Then
            Main.P11.Visible = True
            If NorthClicks = 74 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 5 And EastClicks < 10 Then
            Main.P12.Visible = True
            If NorthClicks = 70 Then Main.cmdWalkSouth.Enabled = False
            If EastClicks = 5 Then Main.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 75 And NorthClicks < 80 And EastClicks >= 5 And EastClicks < 10 Then
            Main.P13.Visible = True
            If EastClicks = 5 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 9 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 80 And NorthClicks < 85 And EastClicks >= 5 And EastClicks < 10 Then
            Main.P14.Visible = True
            If EastClicks = 5 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 9 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 5 And EastClicks < 10 Then
            Main.P15.Visible = True
            If NorthClicks = 89 Then Main.cmdWalkNorth.Enabled = False
            If EastClicks = 5 Then Main.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 10 And EastClicks < 20 Then
            Main.P16.Visible = True
            If NorthClicks = 85 Then Main.cmdWalkSouth.Enabled = False
            If EastClicks = 19 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 90 And NorthClicks < 100 And EastClicks >= 10 And EastClicks < 20 Then
            Main.P17.Visible = True
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False
            If EastClicks = 10 Then Main.cmdWalkWest.Enabled = False
            If NorthClicks >= 90 And NorthClicks < 95 And EastClicks = 19 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 20 And EastClicks < 25 Then
            Main.P18.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 25 And EastClicks < 30 Then
            Main.P19.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 30 And EastClicks < 37 Then
            Main.P20.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 37 And EastClicks < 45 Then
            Main.P21.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 45 And EastClicks < 52 Then
            Main.P22.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 52 And EastClicks < 60 Then
            Main.P23.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P24.Visible = True
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 65 And EastClicks < 70 Then
            Main.P25.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 70 And EastClicks < 77 Then
            Main.P26.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 77 And EastClicks < 83 Then
            Main.P27.Visible = True
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 95 And NorthClicks < 100 And EastClicks >= 83 And EastClicks < 90 Then
            Main.P28.Visible = True
            If NorthClicks = 95 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 99 Then Main.cmdWalkNorth.Enabled = False
            If EastClicks = 89 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 90 And NorthClicks < 95 And EastClicks >= 77 And EastClicks < 83 Then
            Main.P29.Visible = True
            If EastClicks = 77 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 82 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 77 And EastClicks < 83 Then
            Main.P30.Visible = True
            If EastClicks = 77 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 82 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 80 And NorthClicks < 85 And EastClicks >= 77 And EastClicks < 83 Then
            Main.P31.Visible = True
            If EastClicks = 77 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 82 Then Main.cmdWalkEast.Enabled = False
            If NorthClicks = 80 Then Main.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 80 And EastClicks >= 85 And EastClicks < 90 Then
            Main.P32.Visible = True
            If NorthClicks = 79 Then Main.cmdWalkNorth.Enabled = False
            If EastClicks = 85 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 89 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 65 And NorthClicks < 70 And EastClicks >= 85 And EastClicks < 90 Then
            Main.P33.Visible = True
            If EastClicks = 85 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 89 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 85 And EastClicks < 95 Then
            Main.P34.Visible = True
            If EastClicks = 85 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 94 Then Main.cmdWalkEast.Enabled = False
            If EastClicks >= 90 And EastClicks < 95 And NorthClicks = 64 Then Main.cmdWalkNorth.Enabled = False
            If EastClicks >= 85 And EastClicks < 90 And NorthClicks = 60 Then Main.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 60 And EastClicks >= 90 And EastClicks < 95 Then
            Main.P35.Visible = True
            If EastClicks = 90 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 94 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 90 And EastClicks < 95 Then
            Main.P36.Visible = True
            If NorthClicks = 45 Then Main.cmdWalkSouth.Enabled = False
            If EastClicks = 94 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 80 And EastClicks < 90 Then
            Main.P37.Visible = True
            If NorthClicks = 45 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 49 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 75 And EastClicks < 80 Then
            Main.P38.Visible = True
            If NorthClicks = 45 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 49 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 65 And EastClicks < 75 Then
            Main.P39.Visible = True
            If NorthClicks = 45 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 49 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P40.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 60 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P41.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P42.Visible = True
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 65 And NorthClicks < 70 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P43.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P44.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 75 And NorthClicks < 85 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P45.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 85 And NorthClicks < 90 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P46.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 90 And NorthClicks < 95 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P47.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 40 And NorthClicks < 45 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P48.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P49.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 25 And NorthClicks < 35 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P50.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P51.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 15 And NorthClicks < 20 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P52.Visible = True
            If EastClicks = 60 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 60 And EastClicks < 65 Then
            Main.P53.Visible = True
            If EastClicks = 64 Then Main.cmdWalkEast.Enabled = False
            If NorthClicks = 10 Then Main.cmdWalkSouth.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 53 And EastClicks < 60 Then
            Main.P54.Visible = True
            If NorthClicks = 10 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 14 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 45 And EastClicks < 53 Then
            Main.P55.Visible = True
            If NorthClicks = 10 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 14 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 10 And NorthClicks < 15 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P56.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P57.Visible = True
            If NorthClicks = 5 Then Main.cmdWalkSouth.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 30 And EastClicks < 40 Then
            Main.P58.Visible = True
            If NorthClicks = 5 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 9 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 5 And NorthClicks < 10 And EastClicks >= 25 And EastClicks < 30 Then
            Main.P59.Visible = True
            If EastClicks = 25 Then Main.cmdWalkWest.Enabled = False
            If NorthClicks = 9 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 0 And NorthClicks < 5 And EastClicks >= 25 And EastClicks < 30 Then
            Main.P60.Visible = True
            If NorthClicks = 0 Then Main.cmdWalkSouth.Enabled = False
            If EastClicks = 25 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 29 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 15 And NorthClicks < 20 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P61.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P62.Visible = True
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 25 And NorthClicks < 35 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P63.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 35 And NorthClicks < 40 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P64.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 40 And NorthClicks < 45 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P65.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 45 And NorthClicks < 50 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P66.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 50 And NorthClicks < 60 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P67.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P68.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 45 And EastClicks < 53 Then
            Main.P69.Visible = True
            If NorthClicks = 60 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 64 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 60 And NorthClicks < 65 And EastClicks >= 53 And EastClicks < 60 Then
            Main.P70.Visible = True
            If NorthClicks = 60 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 64 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 65 And NorthClicks < 70 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P71.Visible = True
            If EastClicks = 40 Then Main.cmdWalkWest.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 40 And EastClicks < 45 Then
            Main.P72.Visible = True
            If NorthClicks = 74 Then Main.cmdWalkNorth.Enabled = False
            If EastClicks = 44 Then Main.cmdWalkEast.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 35 And EastClicks < 40 Then
            Main.P73.Visible = True
            If NorthClicks = 70 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 28 And EastClicks < 35 Then
            Main.P74.Visible = True
            If NorthClicks = 70 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 22 And EastClicks < 28 Then
            Main.P75.Visible = True
            If NorthClicks = 70 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 70 And NorthClicks < 75 And EastClicks >= 15 And EastClicks < 22 Then
            Main.P76.Visible = True
            If NorthClicks = 70 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 74 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 15 And EastClicks < 22 Then
            Main.P77.Visible = True
            If NorthClicks = 20 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 22 And EastClicks < 28 Then
            Main.P78.Visible = True
            If NorthClicks = 20 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 28 And EastClicks < 35 Then
            Main.P79.Visible = True
            If NorthClicks = 20 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Main.cmdWalkNorth.Enabled = False

        ElseIf NorthClicks >= 20 And NorthClicks < 25 And EastClicks >= 35 And EastClicks < 40 Then
            Main.P80.Visible = True
            If NorthClicks = 20 Then Main.cmdWalkSouth.Enabled = False
            If NorthClicks = 24 Then Main.cmdWalkNorth.Enabled = False
        End If

    End Sub

    Sub MapClear()
        Main.P1.Visible = False
        Main.P2.Visible = False
        Main.P3.Visible = False
        Main.P4.Visible = False
        Main.P5.Visible = False
        Main.P6.Visible = False
        Main.P7.Visible = False
        Main.P8.Visible = False
        Main.P9.Visible = False
        Main.P10.Visible = False
        Main.P11.Visible = False
        Main.P12.Visible = False
        Main.P13.Visible = False
        Main.P14.Visible = False
        Main.P15.Visible = False
        Main.P16.Visible = False
        Main.P17.Visible = False
        Main.P18.Visible = False
        Main.P19.Visible = False
        Main.P20.Visible = False
        Main.P21.Visible = False
        Main.P22.Visible = False
        Main.P23.Visible = False
        Main.P24.Visible = False
        Main.P25.Visible = False
        Main.P26.Visible = False
        Main.P27.Visible = False
        Main.P28.Visible = False
        Main.P29.Visible = False
        Main.P30.Visible = False
        Main.P31.Visible = False
        Main.P32.Visible = False
        Main.P33.Visible = False
        Main.P34.Visible = False
        Main.P35.Visible = False
        Main.P36.Visible = False
        Main.P37.Visible = False
        Main.P38.Visible = False
        Main.P39.Visible = False
        Main.P40.Visible = False
        Main.P41.Visible = False
        Main.P42.Visible = False
        Main.P43.Visible = False
        Main.P44.Visible = False
        Main.P45.Visible = False
        Main.P46.Visible = False
        Main.P47.Visible = False
        Main.P48.Visible = False
        Main.P49.Visible = False
        Main.P50.Visible = False
        Main.P51.Visible = False
        Main.P52.Visible = False
        Main.P53.Visible = False
        Main.P54.Visible = False
        Main.P55.Visible = False
        Main.P56.Visible = False
        Main.P57.Visible = False
        Main.P58.Visible = False
        Main.P59.Visible = False
        Main.P60.Visible = False
        Main.P61.Visible = False
        Main.P62.Visible = False
        Main.P63.Visible = False
        Main.P64.Visible = False
        Main.P65.Visible = False
        Main.P66.Visible = False
        Main.P67.Visible = False
        Main.P68.Visible = False
        Main.P69.Visible = False
        Main.P70.Visible = False
        Main.P71.Visible = False
        Main.P72.Visible = False
        Main.P73.Visible = False
        Main.P74.Visible = False
        Main.P75.Visible = False
        Main.P76.Visible = False
        Main.P77.Visible = False
        Main.P78.Visible = False
        Main.P79.Visible = False
        Main.P80.Visible = False
    End Sub

    Sub NoMonsterFound()
        Main.imgPlayer.Image = Nothing
        Main.imgEnemy.Image = Nothing
        Main.lblStatement.Text = "Found nothing."
        Main.lblPlayerLevel.Text = ""
        Main.lblPlayerName.Text = ""
        Main.lblEnemyLevel.Text = ""
        Main.prgPlayerLvlProg.Visible = False
        Main.prgPlayerHealth.Visible = False
        Main.prgEnemyHealth.Visible = False
        Main.lblEnemyName.Text = ""
        Main.imgPlayer.Visible = False
        Main.imgEnemy.Visible = False
        Main.Label5.Visible = False
        Main.Label2.Visible = False
        Main.Label6.Visible = False
        Main.Label3.Visible = False
        Main.tolPlayer1.Enabled = False
        Main.tolPlayer2.Enabled = False
        Main.tolPlayer3.Enabled = False
        Main.tolPlayer4.Enabled = False
        Main.tolPLayer5.Enabled = False
        Main.tolPlayer6.Enabled = False
    End Sub

    Sub LoadChar()
        Main.imgPlayer.Image = Main.imgPlayer1.Image
        Main.lblPlayerName.Text = arrPlayerName(1)
        Main.lblPlayerLevel.Text = "LVL: " & arrPlayerLevel(1)
        Main.lblCurrentPlayerHealth.Text = arrCurrentHealth(1) & " / " & arrPlayerHealth(1)
        Main.prgPlayerHealth.Visible = True
        Main.prgPlayerLvlProg.Visible = True
        Main.prgPlayerHealth.Maximum = arrPlayerHealth(1)
        Main.prgPlayerHealth.Value = arrCurrentHealth(1)
        Main.imgPlayer.Visible = True
        Main.imgEnemy.Visible = True
        Main.Label5.Visible = True
        Main.Label2.Visible = True
        Main.Label6.Visible = True
        Main.Label3.Visible = True
        Main.tolPlayer1.Enabled = True
        Main.tolPlayer2.Enabled = True
        Main.tolPlayer3.Enabled = True
        Main.tolPlayer4.Enabled = True
        Main.tolPLayer5.Enabled = True
        Main.tolPlayer6.Enabled = True
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
                    Main.lblEnemyName.Text = "Treep"
                    Main.lblStatement.Text = "I raped your family!"
                    'Main.imgEnemy.Image = Main.imgTreep.Image
                    Main.imgEnemy.Image = My.Resources.textures.Treep

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 389 And x < 489 Then
                    Main.lblEnemyName.Text = "Vinyan"
                    Main.lblStatement.Text = "You found Vinyan!"
                    'Main.imgEnemy.Image = Main.imgVinyan.Image
                    Main.imgEnemy.Image = My.Resources.textures.Vinyan

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 489 And x < 589 Then
                    Main.lblEnemyName.Text = "Scorpo"
                    Main.lblStatement.Text = "You found Scorpo!"
                    'Main.imgEnemy.Image = Main.imgScorpo.Image
                    Main.imgEnemy.Image = My.Resources.textures.Scorpo

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 589 And x < 689 Then
                    Main.lblEnemyName.Text = "Kitticar"
                    Main.lblStatement.Text = "You found Kitticar!"
                    'Main.imgEnemy.Image = Main.imgKitticar.Image
                    Main.imgEnemy.Image = My.Resources.textures.Kitticar

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x >= 689 And x < 789 Then
                    Main.lblEnemyName.Text = "Hiss"
                    Main.lblStatement.Text = "You found Hiss!"
                    'Main.imgEnemy.Image = Main.imgHiss.Image
                    Main.imgEnemy.Image = My.Resources.textures.Hiss

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 789 And x < 889 Then
                    Main.lblEnemyName.Text = "Skyte"
                    Main.lblStatement.Text = "You found Skyte!"
                    'Main.imgEnemy.Image = Main.imgSkyte.Image
                    Main.imgEnemy.Image = My.Resources.textures.Skyte

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 889 And x < 989 Then
                    Main.lblEnemyName.Text = "Oryion"
                    Main.lblStatement.Text = "You found Oryion!"
                    'Main.imgEnemy.Image = Main.imgOryion.Image
                    Main.imgEnemy.Image = My.Resources.textures.Oryion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x > 988 <= 998 Then
                    Main.lblEnemyName.Text = "Toasti"
                    Main.lblStatement.Text = "You found Toasti!"
                    'Main.imgEnemy.Image = Main.imgToasti.Image
                    Main.imgEnemy.Image = My.Resources.textures.Toasti

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Laziclaw"
                    Main.lblStatement.Text = "You found Laziclaw!"
                    'Main.imgEnemy.Image = Main.imgLaziclaw.Image
                    Main.imgEnemy.Image = My.Resources.textures.Laziclaw

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Rockin"
                    Main.lblStatement.Text = "You found Rockin!"
                    'Main.imgEnemy.Image = Main.imgTreep.Image
                    Main.imgEnemy.Image = My.Resources.textures.Rockin

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 11
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 463 And x < 638 Then
                    Main.lblEnemyName.Text = "Pebblia"
                    Main.lblStatement.Text = "You found Pebblia!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Pebblia

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 638 And x < 813 Then
                    Main.lblEnemyName.Text = "Guns"
                    Main.lblStatement.Text = "You found Guns!"
                    'Main.imgEnemy.Image = Main.imgGuns.Image
                    Main.imgEnemy.Image = My.Resources.textures.Guns

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 813 And x < 988 Then
                    Main.lblEnemyName.Text = "Bronze Construct"
                    Main.lblStatement.Text = "You found Bronze Construct!"
                    'Main.imgEnemy.Image = Main.imgBronzeConstruct.Image
                    Main.imgEnemy.Image = My.Resources.textures.BronzeCons

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Main.lblEnemyName.Text = "Orite"
                    Main.lblStatement.Text = "You found Orite!"
                    'Main.imgEnemy.Image = Main.imgOrlite.Image
                    Main.imgEnemy.Image = My.Resources.textures.Orite

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x = 998 Then
                    Main.lblEnemyName.Text = "Roughion"
                    Main.lblStatement.Text = "You found Roughion!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Roughion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 10
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Incubat"
                    Main.lblStatement.Text = "You found Incubat!"
                    'Main.imgEnemy.Image = Main.imgOrlite.Image
                    Main.imgEnemy.Image = My.Resources.textures.Incubat

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 7
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Treep"
                    Main.lblStatement.Text = "I raped your family!"
                    'Main.imgEnemy.Image = Main.imgTreep.Image
                    Main.imgEnemy.Image = My.Resources.textures.Treep

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 409 And x < 523 Then
                    Main.lblEnemyName.Text = "Vinyan"
                    Main.lblStatement.Text = "You found Vinyan!"
                    'Main.imgEnemy.Image = Main.imgVinyan.Image
                    Main.imgEnemy.Image = My.Resources.textures.Vinyan

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 523 And x < 637 Then
                    Main.lblEnemyName.Text = "Scorpo"
                    Main.lblStatement.Text = "You found Scorpo!"
                    'Main.imgEnemy.Image = Main.imgScorpo.Image
                    Main.imgEnemy.Image = My.Resources.textures.Scorpo

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 637 And x < 751 Then
                    Main.lblEnemyName.Text = "Stickum"
                    Main.lblStatement.Text = "You found Stickum!"
                    'Main.imgEnemy.Image = Main.imgKitticar.Image
                    Main.imgEnemy.Image = My.Resources.textures.Kitticar

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 1
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 751 And x < 865 Then
                    Main.lblEnemyName.Text = "Hiss"
                    Main.lblStatement.Text = "You found Hiss!"
                    'Main.imgEnemy.Image = Main.imgHiss.Image
                    Main.imgEnemy.Image = My.Resources.textures.Hiss

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 865 And x < 979 Then
                    Main.lblEnemyName.Text = "Skyte"
                    Main.lblStatement.Text = "You found Skyte!"
                    'Main.imgEnemy.Image = Main.imgSkyte.Image
                    Main.imgEnemy.Image = My.Resources.textures.Skyte

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Main.lblEnemyName.Text = "Volchik"
                    Main.lblStatement.Text = "You found Volchik!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Volchick

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 18
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Main.lblEnemyName.Text = "Cion"
                    Main.lblStatement.Text = "You found Cion!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Cion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 9
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Mantid"
                    Main.lblStatement.Text = "You found Mantid!"
                    'Main.imgEnemy.Image = Main.imgOrlite.Image
                    Main.imgEnemy.Image = My.Resources.textures.mantid

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 9
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Ponder"
                    Main.lblStatement.Text = "You found Ponder!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Ponder

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 435 And x < 571 Then
                    Main.lblEnemyName.Text = "Hermit"
                    Main.lblStatement.Text = "You found Hermit!"
                    'Main.imgEnemy.Image = Main.imgHermit.Image
                    Main.imgEnemy.Image = My.Resources.textures.Hermit

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 571 And x < 707 Then
                    Main.lblEnemyName.Text = "Poliba"
                    Main.lblStatement.Text = "You found Poliba!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Poliba

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 707 And x < 843 Then
                    Main.lblEnemyName.Text = "Floikes"
                    Main.lblStatement.Text = "You found Floikes!"
                    'Main.imgEnemy.Image = Main.imgKitticar.Image
                    Main.imgEnemy.Image = My.Resources.textures.Floikes

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 843 And x < 979 Then
                    Main.lblEnemyName.Text = "Aircrew"
                    Main.lblStatement.Text = "You found Aircrew!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Aircrew

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 21
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Main.lblEnemyName.Text = "Electreel"
                    Main.lblStatement.Text = "You found Electreel!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Electreel

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 15
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Main.lblEnemyName.Text = "Komsaikai"
                    Main.lblStatement.Text = "You found Komsaikai!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Komsaikai

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Icekerzo"
                    Main.lblStatement.Text = "You found Icekerzo!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Icekerzo

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 25
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Snowball"
                    Main.lblStatement.Text = "You found Snowball!"
                    'Main.imgEnemy.Image = Main.imgTreep.Image
                    Main.imgEnemy.Image = My.Resources.textures.Snowball

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 435 And x < 571 Then
                    Main.lblEnemyName.Text = "Pebblia"
                    Main.lblStatement.Text = "You found Pebblia!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Pebblia

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 571 And x < 707 Then
                    Main.lblEnemyName.Text = "Poliba"
                    Main.lblStatement.Text = "You found Poliba!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Poliba

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 707 And x < 843 Then
                    Main.lblEnemyName.Text = "Kitticar"
                    Main.lblStatement.Text = "You found Kitticar!"
                    'Main.imgEnemy.Image = Main.imgKitticar.Image
                    Main.imgEnemy.Image = My.Resources.textures.Kitticar

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x >= 843 And x < 979 Then
                    Main.lblEnemyName.Text = "Oryion"
                    Main.lblStatement.Text = "You found Oryion!"
                    'Main.imgEnemy.Image = Main.imgOryion.Image
                    Main.imgEnemy.Image = My.Resources.textures.Oryion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 6
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Main.lblEnemyName.Text = "Thormion"
                    Main.lblStatement.Text = "You found Thormion!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Thormion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 11
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 1
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Main.lblEnemyName.Text = "Kommion"
                    Main.lblStatement.Text = "You found Kommion!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Kommion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 11
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 7
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 20
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Roughion"
                    Main.lblStatement.Text = "You found Roughion!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Roughion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Ponder"
                    Main.lblStatement.Text = "You found Ponder!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Ponder

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 409 And x < 523 Then
                    Main.lblEnemyName.Text = "Hermit"
                    Main.lblStatement.Text = "You found Hermit!"
                    'Main.imgEnemy.Image = Main.imgHermit.Image
                    Main.imgEnemy.Image = My.Resources.textures.Hermit

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 523 And x < 637 Then
                    Main.lblEnemyName.Text = "Poliba"
                    Main.lblStatement.Text = "You found Poliba!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Poliba

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 637 And x < 751 Then
                    Main.lblEnemyName.Text = "Floikes"
                    Main.lblStatement.Text = "You found Floikes!"
                    'Main.imgEnemy.Image = Main.imgKitticar.Image
                    Main.imgEnemy.Image = My.Resources.textures.Floikes

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 751 And x < 865 Then
                    Main.lblEnemyName.Text = "Aircrew"
                    Main.lblStatement.Text = "You found Aircrew!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Aircrew

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 21
                    LoadChar()
                ElseIf x >= 865 And x < 979 Then
                    Main.lblEnemyName.Text = "Komsaikai"
                    Main.lblStatement.Text = "You found Komsaikai!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Komsaikai

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 4
                    LoadChar()
                ElseIf x >= 979 And x < 989 Then
                    Main.lblEnemyName.Text = "Electreel"
                    Main.lblStatement.Text = "You found Electreel!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Electreel

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 15
                    LoadChar()
                ElseIf x >= 989 And x < 999 Then
                    Main.lblEnemyName.Text = "Waterwing"
                    Main.lblStatement.Text = "You found Waterwing!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Waterwing

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 21
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Icekerzo"
                    Main.lblStatement.Text = "You found Icekerzo!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Icekerzo

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 25
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Scorpo"
                    Main.lblStatement.Text = "You found Scorpo!"
                    'Main.imgEnemy.Image = Main.imgScorpo.Image
                    Main.imgEnemy.Image = My.Resources.textures.Scorpo

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 413 And x < 526 Then
                    Main.lblEnemyName.Text = "Ravipion"
                    Main.lblStatement.Text = "You found Ravipion!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Ravipion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 8
                    EnemySpeed = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 526 And x < 639 Then
                    Main.lblEnemyName.Text = "Hiss"
                    Main.lblStatement.Text = "You found Hiss!"
                    'Main.imgEnemy.Image = Main.imgHiss.Image
                    Main.imgEnemy.Image = My.Resources.textures.Hiss

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 639 And x < 752 Then
                    Main.lblEnemyName.Text = "Skyte"
                    Main.lblStatement.Text = "You found Skyte!"
                    'Main.imgEnemy.Image = Main.imgSkyte.Image
                    Main.imgEnemy.Image = My.Resources.textures.Skyte

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 5
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 752 And x < 865 Then
                    Main.lblEnemyName.Text = "Aires"
                    Main.lblStatement.Text = "You found Aires!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Aires

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 865 And x < 978 Then
                    Main.lblEnemyName.Text = "Guns"
                    Main.lblStatement.Text = "You found Guns!"
                    'Main.imgEnemy.Image = Main.imgGuns.Image
                    Main.imgEnemy.Image = My.Resources.textures.Guns

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Main.lblEnemyName.Text = "Streamain"
                    Main.lblStatement.Text = "You found Streamain!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Streamain

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 22
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Main.lblEnemyName.Text = "Combustor"
                    Main.lblStatement.Text = "You found Combustor!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Combustor

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 10
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                    LoadChar()
                ElseIf x = 998 Then
                    Main.lblEnemyName.Text = "Smogg"
                    Main.lblStatement.Text = "You found Smogg!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Smogg

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 1
                    EnemyDefense = (level * 2) - 1
                    EnemySpeed = (level * 2) - 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    ClassType = 5
                    Beep()
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Cire"
                    Main.lblStatement.Text = "You found Cire!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Cire

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Corpse"
                    Main.lblStatement.Text = "You found Corpse!"
                    'Main.imgEnemy.Image = Main.imgHermit.Image
                    Main.imgEnemy.Image = My.Resources.textures.Corpse

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 11
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    ClassType = 16
                    LoadChar()
                ElseIf x >= 434 And x < 570 Then
                    Main.lblEnemyName.Text = "Hellion"
                    Main.lblStatement.Text = "You found Hellion!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Hellion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 9
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 1
                    EnemyDefense = (level * 1) + 1
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 8
                    LoadChar()
                ElseIf x >= 570 And x < 706 Then
                    Main.lblEnemyName.Text = "Zombones"
                    Main.lblStatement.Text = "You found Zombones!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Zombones

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 4) + 8
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 0
                    EnemySpeed = (level * 1) - 2
                    TotalCount = TotalCount + 1
                    ClassType = 8
                    LoadChar()
                ElseIf x >= 706 And x < 842 Then
                    Main.lblEnemyName.Text = "Rockin"
                    Main.lblStatement.Text = "You found Rockin!"
                    'Main.imgEnemy.Image = Main.imgTreep.Image
                    Main.imgEnemy.Image = My.Resources.textures.Rockin

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 11
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 842 And x < 978 Then
                    Main.lblEnemyName.Text = "Rocky"
                    Main.lblStatement.Text = "You found Rocky!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Rocky

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 22
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 8
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Main.lblEnemyName.Text = "Drift"
                    Main.lblStatement.Text = "You found Drift!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Drift

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 9
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 4
                    EnemyDefense = (level * 2) - 2
                    EnemySpeed = (level * 2) - 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 8
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Main.lblEnemyName.Text = "Volcipeon"
                    Main.lblStatement.Text = "You found Volcipeon!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Volcipeon

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 3
                    LoadChar()
                ElseIf x = 998 Then
                    Main.lblEnemyName.Text = "Wraith"
                    Main.lblStatement.Text = "You found Wraith!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Wraith

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 12
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 2) - 4
                    EnemyDefense = (level * 2) - 2
                    EnemySpeed = (level * 2) + 0
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 8
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Smogg"
                    Main.lblStatement.Text = "You found Smogg!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Smogg

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Treep"
                    Main.lblStatement.Text = "I raped your family!"
                    'Main.imgEnemy.Image = Main.imgTreep.Image
                    Main.imgEnemy.Image = My.Resources.textures.Treep

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 8
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 7
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 396 And x < 493 Then
                    Main.lblEnemyName.Text = "Namu"
                    Main.lblStatement.Text = "You found Namu!"
                    'Main.imgEnemy.Image = Main.imgNamu.Image
                    Main.imgEnemy.Image = My.Resources.textures.Namu

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 1
                    LoadChar()
                ElseIf x >= 493 And x < 590 Then
                    Main.lblEnemyName.Text = "Bronze Construct"
                    Main.lblStatement.Text = "You found Bronze Construct!"
                    'Main.imgEnemy.Image = Main.imgBronzeConstruct.Image
                    Main.imgEnemy.Image = My.Resources.textures.BronzeCons

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 590 And x < 687 Then
                    Main.lblEnemyName.Text = "Iron Construct"
                    Main.lblStatement.Text = "You found Iron Construct!"
                    'Main.imgEnemy.Image = Main.imgIronConstruct.Image
                    Main.imgEnemy.Image = My.Resources.textures.IronCons

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 10
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 687 And x < 784 Then
                    Main.lblEnemyName.Text = "Ravipion"
                    Main.lblStatement.Text = "You found Ravipion!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Ravipion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 10
                    EnemyDefense = (level * 1) + 8
                    EnemySpeed = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    ClassType = 5
                    LoadChar()
                ElseIf x >= 784 And x < 881 Then
                    Main.lblEnemyName.Text = "Orite"
                    Main.lblStatement.Text = "You found Orite!"
                    'Main.imgEnemy.Image = Main.imgOrlite.Image
                    Main.imgEnemy.Image = My.Resources.textures.Orite

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 6
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 881 And x < 978 Then
                    Main.lblEnemyName.Text = "Aurorite"
                    Main.lblStatement.Text = "You found Aurorite!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Aurorite

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 12
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Main.lblEnemyName.Text = "Zapawk"
                    Main.lblStatement.Text = "You found Zapawk!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Zapawk

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 6
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 18
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Main.lblEnemyName.Text = "Excitrik"
                    Main.lblStatement.Text = "You found Excitrik!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Excitrik

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 12
                    LoadChar()
                ElseIf x = 998 Then
                    Main.lblEnemyName.Text = "Volcipeon"
                    Main.lblStatement.Text = "You found Volcipeon!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Volcipeon

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 3
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 3
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 3
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Mantid"
                    Main.lblStatement.Text = "You found Mantid!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.mantid

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 9
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                    Main.lblEnemyName.Text = "Streamain"
                    Main.lblStatement.Text = "You found Streamain!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Streamain

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 10
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 2
                    EnemyDefense = (level * 1) + 3
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 22
                    LoadChar()
                ElseIf x >= 408 And x < 520 Then
                    Main.lblEnemyName.Text = "Boulda"
                    Main.lblStatement.Text = "You found Boulda!"
                    'Main.imgEnemy.Image = Main.imgPonder.Image
                    Main.imgEnemy.Image = My.Resources.textures.Boulda

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 12
                    EnemyDefense = (level * 1) + 12
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 520 And x < 632 Then
                    Main.lblEnemyName.Text = "Snowstrom"
                    Main.lblStatement.Text = "You found Snowstrom!"
                    'Main.imgEnemy.Image = Main.imgKitticar.Image
                    Main.imgEnemy.Image = My.Resources.textures.Snowstrom

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 4
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 7
                    LoadChar()
                ElseIf x >= 632 And x < 744 Then
                    Main.lblEnemyName.Text = "Aires"
                    Main.lblStatement.Text = "You found Aires!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Aires

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 6
                    EnemyDefense = (level * 1) + 2
                    EnemySpeed = (level * 1) + 10
                    TotalCount = TotalCount + 1
                    ClassType = 11
                    LoadChar()
                ElseIf x >= 744 And x < 856 Then
                    Main.lblEnemyName.Text = "Rocky"
                    Main.lblStatement.Text = "You found Rocky!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Rocky

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 22
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 8
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 856 And x < 968 Then
                    Main.lblEnemyName.Text = "Gunnery"
                    Main.lblStatement.Text = "You found Gunnery!"
                    'Main.imgEnemy.Image = Main.imgGunnery.Image
                    Main.imgEnemy.Image = My.Resources.textures.Gunnery

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 12
                    EnemyDefense = (level * 1) + 10
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x >= 968 And x < 978 Then
                    Main.lblEnemyName.Text = "Mountking"
                    Main.lblStatement.Text = "You found Mountking!"
                    'Main.imgEnemy.Image = Main.imgVolchik.Image
                    Main.imgEnemy.Image = My.Resources.textures.Mountking

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 18
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 4
                    EnemyDefense = (level * 1) + 14
                    EnemySpeed = (level * 1) + 2
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 22
                    LoadChar()
                ElseIf x >= 978 And x < 988 Then
                    Main.lblEnemyName.Text = "Roughion"
                    Main.lblStatement.Text = "You found Roughion!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Roughion

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 3) + 16
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 5
                    EnemyDefense = (level * 1) + 5
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 10
                    LoadChar()
                ElseIf x >= 988 And x < 998 Then
                    Main.lblEnemyName.Text = "Tankimnida"
                    Main.lblStatement.Text = "You found Tankimnida!"
                    'Main.imgEnemy.Image = Main.imgTankimnida.Image
                    Main.imgEnemy.Image = My.Resources.textures.Tankimnida

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 40
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 24
                    EnemyDefense = (level * 1) + 20
                    EnemySpeed = (level * 1) + 4
                    TotalCount = TotalCount + 1
                    RareCount = RareCount + 1
                    ClassType = 2
                    LoadChar()
                ElseIf x = 998 Then
                    Main.lblEnemyName.Text = "Supresloth"
                    Main.lblStatement.Text = "You found Supresloth!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Supresloth

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 2) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
                    EnemyAttack = (level * 1) + 18
                    EnemyDefense = (level * 1) + 8
                    EnemySpeed = (level * 1) + 1
                    TotalCount = TotalCount + 1
                    SuperRareCount = SuperRareCount + 1
                    Beep()
                    ClassType = 6
                    LoadChar()
                ElseIf x = 999 Then
                    Main.lblEnemyName.Text = "Cloudd"
                    Main.lblStatement.Text = "You found Cloudd!"
                    'Main.imgEnemy.Image = Main.imgPoliba.Image
                    Main.imgEnemy.Image = My.Resources.textures.Cloudd

                    Main.prgEnemyHealth.Visible = True
                    EnemyHealth = (level * 1) + 20
                    Main.prgEnemyHealth.Maximum = EnemyHealth
                    CurrentEnemyHealth = EnemyHealth
                    Main.prgEnemyHealth.Value = EnemyHealth
                    Main.lblEnemyLevel.Text = "LVL: " & level
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
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 12
                NoMonsterFound()
                CityName = "Raupolis"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 13
                NoMonsterFound()
                CityName = "Jay Town"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 14
                NoMonsterFound()
                CityName = "Ahpville"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 15
                NoMonsterFound()
                CityName = "Eden"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 16
                NoMonsterFound()
                CityName = "Mahogitown"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 17
                NoMonsterFound()
                CityName = "Tirpimo Town"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 18
                NoMonsterFound()
                CityName = "Lirpom"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 19
                NoMonsterFound()
                CityName = "Central"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 20
                NoMonsterFound()
                CityName = "Dawn"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 21
                NoMonsterFound()
                CityName = "Oreville"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
            Case 22
                NoMonsterFound()
                CityName = "Padatka City"
                Main.lblStatement.Text = "Welcome to " & CityName & "!"
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
        Stats.lblRareCount.Text = Str(RareCount)
        Stats.lblSuperRareCount.Text = Str(SuperRareCount)
        Stats.lblTotalCount.Text = Str(TotalCount)
        Stats.lblRarePerc.Text = Format((RareCount / TotalCount), "#,#.###%")
        Stats.lblSuperRarePerc.Text = Format((SuperRareCount / TotalCount), "#,#.###%")
    End Sub


End Module
