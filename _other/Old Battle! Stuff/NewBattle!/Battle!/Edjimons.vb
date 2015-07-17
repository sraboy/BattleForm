Public Class Edjimons

    Private CHealth, PLevel, PHealth, PDefense, PAttack, PSpeed, XP As Integer
    Private PName, AtkNames(3) As String, AtkDamage(3), AtkType(3) As Integer
    Private Pic As Image

    Public Property CurrentHealth() As Integer
        Get
            Return CHealth
        End Get
        Set(ByVal value As Integer)
            CHealth = value
        End Set
    End Property

    Public ReadOnly Property PlayerLevel() As Integer
        Get
            Return PLevel
        End Get
    End Property

    Public ReadOnly Property PlayerHealth() As Integer
        Get
            Return PHealth
        End Get
    End Property

    Public ReadOnly Property PlayerDefense() As Integer
        Get
            Return PHealth
        End Get
    End Property

    Public ReadOnly Property PlayerAttack() As Integer
        Get
            Return PAttack
        End Get
    End Property

    Public ReadOnly Property PlayerSpeed() As Integer
        Get
            Return PSpeed
        End Get
    End Property

    Public Property TotalXP() As Integer
        Get
            Return XP
        End Get
        Set(ByVal value As Integer)
            XP = value
        End Set
    End Property

    Public ReadOnly Property EdjName() As String
        Get
            Return PName
        End Get
    End Property

    Public ReadOnly Property EdjPic() As Image
        Get
            Return Pic
        End Get
    End Property

#Region "Attack Names"

    Public ReadOnly Property Attack1Name() As String
        Get
            Return AtkNames(0)
        End Get
    End Property

    Public ReadOnly Property Attack2Name() As String
        Get
            Return AtkNames(1)
        End Get
    End Property

    Public ReadOnly Property Attack3Name() As String
        Get
            Return AtkNames(2)
        End Get
    End Property

    Public ReadOnly Property Attack4Name() As String
        Get
            Return AtkNames(3)
        End Get
    End Property

#End Region

#Region "Attack Damages"

    Public ReadOnly Property Attack1Damage() As Integer
        Get
            Return AtkDamage(0)
        End Get
    End Property

    Public ReadOnly Property Attack2Damage() As Integer
        Get
            Return AtkDamage(1)
        End Get
    End Property

    Public ReadOnly Property Attack3Damage() As Integer
        Get
            Return AtkDamage(2)
        End Get
    End Property

    Public ReadOnly Property Attack4Damage() As Integer
        Get
            Return AtkDamage(3)
        End Get
    End Property

#End Region

#Region "Attack Types"
    Public ReadOnly Property Attack1Type() As Integer
        Get
            Return AtkType(0)
        End Get
    End Property

    Public ReadOnly Property Attack2Type() As Integer
        Get
            Return AtkType(1)
        End Get
    End Property

    Public ReadOnly Property Attack3Type() As Integer
        Get
            Return AtkType(2)
        End Get
    End Property

    Public ReadOnly Property Attack4Type() As Integer
        Get
            Return AtkType(3)
        End Get
    End Property
#End Region


    Public Sub CreateFirstEdjimon(ByVal EdjName As String, ByVal Att As Integer, ByVal Def As Integer, ByVal Speed As Integer, ByVal Health As Integer, ByVal Level As Integer, ByVal PicNum As Integer, ByVal CXP As Integer)
        PLevel = Level
        PHealth = Health
        PDefense = Def
        PAttack = Att
        PSpeed = Speed
        PName = EdjName
        CHealth = Health
        XP = CXP
        Pic = Form1.EdjImages.Images.Item(PicNum)
    End Sub

    Public Sub SetAttacks(ByVal Name1 As String, ByVal Name2 As String, ByVal Name3 As String, ByVal Name4 As String, ByVal Dmg1 As Integer, ByVal Dmg2 As Integer, ByVal Dmg3 As Integer, ByVal Dmg4 As Integer, ByVal Type1 As Integer, ByVal Type2 As Integer, ByVal Type3 As Integer, ByVal Type4 As Integer)
        AtkNames(0) = Name1
        AtkDamage(0) = Dmg1
        AtkType(0) = Type1

        AtkNames(1) = Name2
        AtkDamage(1) = Dmg2
        AtkType(1) = Type2

        AtkNames(2) = Name3
        AtkDamage(2) = Dmg3
        AtkType(2) = Type3

        AtkNames(3) = Name4
        AtkDamage(3) = Dmg4
        AtkType(3) = Type4
    End Sub

End Class
