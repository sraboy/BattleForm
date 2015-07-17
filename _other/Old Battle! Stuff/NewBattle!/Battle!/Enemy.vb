Public Class Enemy

    Private CHealth, THealth, Att, Def, Spd, Lvl, XP As Integer, Nme As String
    'EnemyStats(0) = current health
    'EnemyStats(1) = total health
    'EnemyStats(2) = attack
    'EnemyStats(3) = defense
    'EnemyStats(4) = speed
    'EnemyStats(5) = level
    'EnemyStats(6) = xp

    Public ReadOnly Property TotalHealth() As Integer
        Get
            Return THealth
        End Get
    End Property

    Public ReadOnly Property Attack() As Integer
        Get
            Return Att
        End Get
    End Property

    Public ReadOnly Property Defense() As Integer
        Get
            Return Def
        End Get
    End Property

    Public ReadOnly Property Speed() As Integer
        Get
            Return Spd
        End Get
    End Property

    Public ReadOnly Property Level() As Integer
        Get
            Return Lvl
        End Get
    End Property

    Public ReadOnly Property Experience() As Integer
        Get
            Return XP
        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return nme
        End Get
    End Property

    Public Property CurrentHealth() As Integer
        Get
            Return CHealth
        End Get
        Set(ByVal value As Integer)
            CHealth = value
        End Set
    End Property


    Public Sub FoundEnemy(ByVal hlth As Integer, ByVal atk As Integer, ByVal defc As Integer, ByVal speed As Integer, ByVal level As Integer, ByVal exp As Integer, ByVal ename As String)
        'EnemyStats(0) = current health
        'EnemyStats(1) = total health
        'EnemyStats(2) = attack
        'EnemyStats(3) = defense
        'EnemyStats(4) = speed
        'EnemyStats(5) = level
        'EnemyStats(6) = xp

        THealth = hlth
        Att = atk
        Def = defc
        Spd = speed
        Lvl = level
        XP = exp
        Nme = ename
    End Sub

End Class
