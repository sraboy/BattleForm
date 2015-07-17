<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button3 = New System.Windows.Forms.Button
        Me.cmdWalkEast = New System.Windows.Forms.Button
        Me.cmdWalkSouth = New System.Windows.Forms.Button
        Me.cmdWalkWest = New System.Windows.Forms.Button
        Me.cmdWalkNorth = New System.Windows.Forms.Button
        Me.cmdMap = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnSkillFour = New System.Windows.Forms.Button
        Me.btnSkillThree = New System.Windows.Forms.Button
        Me.btnSkillTwo = New System.Windows.Forms.Button
        Me.btnSkillOne = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.tolPlayer1 = New System.Windows.Forms.ToolStripButton
        Me.tolPlayer2 = New System.Windows.Forms.ToolStripButton
        Me.tolPlayer3 = New System.Windows.Forms.ToolStripButton
        Me.tolPlayer4 = New System.Windows.Forms.ToolStripButton
        Me.tolPLayer5 = New System.Windows.Forms.ToolStripButton
        Me.tolPlayer6 = New System.Windows.Forms.ToolStripButton
        Me.prgPlayerHealth = New System.Windows.Forms.ProgressBar
        Me.lblCurrentPlayerHealth = New System.Windows.Forms.Label
        Me.prgPlayerLvlProg = New System.Windows.Forms.ProgressBar
        Me.prgEnemyHealth = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPlayerName = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblEnemyName = New System.Windows.Forms.Label
        Me.imgPlayer = New System.Windows.Forms.PictureBox
        Me.imgEnemy = New System.Windows.Forms.PictureBox
        Me.lblEnemyLevel = New System.Windows.Forms.Label
        Me.lblPlayerLevel = New System.Windows.Forms.Label
        Me.lblStatement = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.EdjImages = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.imgPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.cmdWalkEast)
        Me.Panel1.Controls.Add(Me.cmdWalkSouth)
        Me.Panel1.Controls.Add(Me.cmdWalkWest)
        Me.Panel1.Controls.Add(Me.cmdWalkNorth)
        Me.Panel1.Controls.Add(Me.cmdMap)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSkillFour)
        Me.Panel1.Controls.Add(Me.btnSkillThree)
        Me.Panel1.Controls.Add(Me.btnSkillTwo)
        Me.Panel1.Controls.Add(Me.btnSkillOne)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 255)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 152)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button3.Location = New System.Drawing.Point(221, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 21)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "STATS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmdWalkEast
        '
        Me.cmdWalkEast.BackColor = System.Drawing.Color.Silver
        Me.cmdWalkEast.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdWalkEast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWalkEast.ForeColor = System.Drawing.Color.Black
        Me.cmdWalkEast.Location = New System.Drawing.Point(362, 43)
        Me.cmdWalkEast.Name = "cmdWalkEast"
        Me.cmdWalkEast.Size = New System.Drawing.Size(60, 34)
        Me.cmdWalkEast.TabIndex = 24
        Me.cmdWalkEast.Text = "WALK EAST"
        Me.cmdWalkEast.UseVisualStyleBackColor = False
        '
        'cmdWalkSouth
        '
        Me.cmdWalkSouth.BackColor = System.Drawing.Color.Silver
        Me.cmdWalkSouth.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdWalkSouth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWalkSouth.ForeColor = System.Drawing.Color.Black
        Me.cmdWalkSouth.Location = New System.Drawing.Point(329, 83)
        Me.cmdWalkSouth.Name = "cmdWalkSouth"
        Me.cmdWalkSouth.Size = New System.Drawing.Size(60, 34)
        Me.cmdWalkSouth.TabIndex = 23
        Me.cmdWalkSouth.Text = "WALK SOUTH"
        Me.cmdWalkSouth.UseVisualStyleBackColor = False
        '
        'cmdWalkWest
        '
        Me.cmdWalkWest.BackColor = System.Drawing.Color.Silver
        Me.cmdWalkWest.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdWalkWest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWalkWest.ForeColor = System.Drawing.Color.Black
        Me.cmdWalkWest.Location = New System.Drawing.Point(296, 43)
        Me.cmdWalkWest.Name = "cmdWalkWest"
        Me.cmdWalkWest.Size = New System.Drawing.Size(60, 34)
        Me.cmdWalkWest.TabIndex = 22
        Me.cmdWalkWest.Text = "WALK WEST"
        Me.cmdWalkWest.UseVisualStyleBackColor = False
        '
        'cmdWalkNorth
        '
        Me.cmdWalkNorth.BackColor = System.Drawing.Color.Silver
        Me.cmdWalkNorth.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdWalkNorth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWalkNorth.ForeColor = System.Drawing.Color.Black
        Me.cmdWalkNorth.Location = New System.Drawing.Point(329, 3)
        Me.cmdWalkNorth.Name = "cmdWalkNorth"
        Me.cmdWalkNorth.Size = New System.Drawing.Size(60, 34)
        Me.cmdWalkNorth.TabIndex = 21
        Me.cmdWalkNorth.Text = "WALK NORTH"
        Me.cmdWalkNorth.UseVisualStyleBackColor = False
        '
        'cmdMap
        '
        Me.cmdMap.BackColor = System.Drawing.Color.Silver
        Me.cmdMap.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMap.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cmdMap.Location = New System.Drawing.Point(174, 1)
        Me.cmdMap.Name = "cmdMap"
        Me.cmdMap.Size = New System.Drawing.Size(41, 21)
        Me.cmdMap.TabIndex = 20
        Me.cmdMap.Text = "MAP"
        Me.cmdMap.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button2.Location = New System.Drawing.Point(67, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 21)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "PACK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(123, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 21)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "FLEE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSkillFour
        '
        Me.btnSkillFour.BackColor = System.Drawing.Color.Silver
        Me.btnSkillFour.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSkillFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkillFour.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSkillFour.Location = New System.Drawing.Point(158, 83)
        Me.btnSkillFour.Name = "btnSkillFour"
        Me.btnSkillFour.Size = New System.Drawing.Size(117, 21)
        Me.btnSkillFour.TabIndex = 16
        Me.btnSkillFour.Text = "WATER BEAM"
        Me.btnSkillFour.UseVisualStyleBackColor = False
        '
        'btnSkillThree
        '
        Me.btnSkillThree.BackColor = System.Drawing.Color.Silver
        Me.btnSkillThree.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSkillThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkillThree.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSkillThree.Location = New System.Drawing.Point(34, 83)
        Me.btnSkillThree.Name = "btnSkillThree"
        Me.btnSkillThree.Size = New System.Drawing.Size(117, 21)
        Me.btnSkillThree.TabIndex = 17
        Me.btnSkillThree.Text = "ROYAL FREEZE"
        Me.btnSkillThree.UseVisualStyleBackColor = False
        '
        'btnSkillTwo
        '
        Me.btnSkillTwo.BackColor = System.Drawing.Color.Silver
        Me.btnSkillTwo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSkillTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkillTwo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSkillTwo.Location = New System.Drawing.Point(158, 42)
        Me.btnSkillTwo.Name = "btnSkillTwo"
        Me.btnSkillTwo.Size = New System.Drawing.Size(117, 21)
        Me.btnSkillTwo.TabIndex = 16
        Me.btnSkillTwo.Text = "DETHRONE"
        Me.btnSkillTwo.UseVisualStyleBackColor = False
        '
        'btnSkillOne
        '
        Me.btnSkillOne.BackColor = System.Drawing.Color.Silver
        Me.btnSkillOne.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSkillOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkillOne.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSkillOne.Location = New System.Drawing.Point(34, 42)
        Me.btnSkillOne.Name = "btnSkillOne"
        Me.btnSkillOne.Size = New System.Drawing.Size(117, 21)
        Me.btnSkillOne.TabIndex = 4
        Me.btnSkillOne.Text = "CRAB HAMMER"
        Me.btnSkillOne.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ATTACK"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Silver
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tolPlayer1, Me.tolPlayer2, Me.tolPlayer3, Me.tolPlayer4, Me.tolPLayer5, Me.tolPlayer6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 127)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(443, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "EDJIMON : "
        '
        'tolPlayer1
        '
        Me.tolPlayer1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPlayer1.Enabled = False
        Me.tolPlayer1.ImageTransparentColor = System.Drawing.Color.White
        Me.tolPlayer1.Name = "tolPlayer1"
        Me.tolPlayer1.Size = New System.Drawing.Size(23, 22)
        '
        'tolPlayer2
        '
        Me.tolPlayer2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPlayer2.Enabled = False
        Me.tolPlayer2.ImageTransparentColor = System.Drawing.Color.White
        Me.tolPlayer2.Name = "tolPlayer2"
        Me.tolPlayer2.Size = New System.Drawing.Size(23, 22)
        '
        'tolPlayer3
        '
        Me.tolPlayer3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPlayer3.Enabled = False
        Me.tolPlayer3.ImageTransparentColor = System.Drawing.Color.White
        Me.tolPlayer3.Name = "tolPlayer3"
        Me.tolPlayer3.Size = New System.Drawing.Size(23, 22)
        '
        'tolPlayer4
        '
        Me.tolPlayer4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPlayer4.Enabled = False
        Me.tolPlayer4.ImageTransparentColor = System.Drawing.Color.White
        Me.tolPlayer4.Name = "tolPlayer4"
        Me.tolPlayer4.Size = New System.Drawing.Size(23, 22)
        '
        'tolPLayer5
        '
        Me.tolPLayer5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPLayer5.Enabled = False
        Me.tolPLayer5.ImageTransparentColor = System.Drawing.Color.White
        Me.tolPLayer5.Name = "tolPLayer5"
        Me.tolPLayer5.Size = New System.Drawing.Size(23, 22)
        '
        'tolPlayer6
        '
        Me.tolPlayer6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tolPlayer6.Enabled = False
        Me.tolPlayer6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tolPlayer6.Name = "tolPlayer6"
        Me.tolPlayer6.Size = New System.Drawing.Size(23, 22)
        '
        'prgPlayerHealth
        '
        Me.prgPlayerHealth.Location = New System.Drawing.Point(170, 209)
        Me.prgPlayerHealth.Maximum = 175
        Me.prgPlayerHealth.Name = "prgPlayerHealth"
        Me.prgPlayerHealth.Size = New System.Drawing.Size(110, 23)
        Me.prgPlayerHealth.TabIndex = 1
        Me.prgPlayerHealth.Visible = False
        '
        'lblCurrentPlayerHealth
        '
        Me.lblCurrentPlayerHealth.AutoSize = True
        Me.lblCurrentPlayerHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentPlayerHealth.Location = New System.Drawing.Point(197, 239)
        Me.lblCurrentPlayerHealth.Name = "lblCurrentPlayerHealth"
        Me.lblCurrentPlayerHealth.Size = New System.Drawing.Size(0, 13)
        Me.lblCurrentPlayerHealth.TabIndex = 2
        Me.lblCurrentPlayerHealth.Visible = False
        '
        'prgPlayerLvlProg
        '
        Me.prgPlayerLvlProg.BackColor = System.Drawing.Color.White
        Me.prgPlayerLvlProg.Location = New System.Drawing.Point(141, 193)
        Me.prgPlayerLvlProg.Maximum = 8621
        Me.prgPlayerLvlProg.Name = "prgPlayerLvlProg"
        Me.prgPlayerLvlProg.Size = New System.Drawing.Size(139, 10)
        Me.prgPlayerLvlProg.TabIndex = 3
        Me.prgPlayerLvlProg.Visible = False
        '
        'prgEnemyHealth
        '
        Me.prgEnemyHealth.Location = New System.Drawing.Point(170, 38)
        Me.prgEnemyHealth.Maximum = 640
        Me.prgEnemyHealth.Name = "prgEnemyHealth"
        Me.prgEnemyHealth.Size = New System.Drawing.Size(110, 23)
        Me.prgEnemyHealth.TabIndex = 4
        Me.prgEnemyHealth.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "HP:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "HP"
        Me.Label3.Visible = False
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.Location = New System.Drawing.Point(20, 211)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(0, 13)
        Me.lblPlayerName.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "/-/-/-/-/-/-/-/"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "/-/-/-/-/-/-/-/"
        Me.Label6.Visible = False
        '
        'lblEnemyName
        '
        Me.lblEnemyName.AutoSize = True
        Me.lblEnemyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyName.Location = New System.Drawing.Point(341, 127)
        Me.lblEnemyName.Name = "lblEnemyName"
        Me.lblEnemyName.Size = New System.Drawing.Size(0, 13)
        Me.lblEnemyName.TabIndex = 11
        '
        'imgPlayer
        '
        Me.imgPlayer.InitialImage = CType(resources.GetObject("imgPlayer.InitialImage"), System.Drawing.Image)
        Me.imgPlayer.Location = New System.Drawing.Point(28, 120)
        Me.imgPlayer.Name = "imgPlayer"
        Me.imgPlayer.Size = New System.Drawing.Size(70, 70)
        Me.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgPlayer.TabIndex = 12
        Me.imgPlayer.TabStop = False
        Me.imgPlayer.Visible = False
        '
        'imgEnemy
        '
        Me.imgEnemy.Location = New System.Drawing.Point(339, 39)
        Me.imgEnemy.Name = "imgEnemy"
        Me.imgEnemy.Size = New System.Drawing.Size(70, 70)
        Me.imgEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgEnemy.TabIndex = 13
        Me.imgEnemy.TabStop = False
        Me.imgEnemy.Visible = False
        '
        'lblEnemyLevel
        '
        Me.lblEnemyLevel.AutoSize = True
        Me.lblEnemyLevel.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyLevel.ForeColor = System.Drawing.Color.Firebrick
        Me.lblEnemyLevel.Location = New System.Drawing.Point(351, 140)
        Me.lblEnemyLevel.Name = "lblEnemyLevel"
        Me.lblEnemyLevel.Size = New System.Drawing.Size(0, 18)
        Me.lblEnemyLevel.TabIndex = 15
        '
        'lblPlayerLevel
        '
        Me.lblPlayerLevel.AutoSize = True
        Me.lblPlayerLevel.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerLevel.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPlayerLevel.Location = New System.Drawing.Point(45, 224)
        Me.lblPlayerLevel.Name = "lblPlayerLevel"
        Me.lblPlayerLevel.Size = New System.Drawing.Size(0, 18)
        Me.lblPlayerLevel.TabIndex = 14
        '
        'lblStatement
        '
        Me.lblStatement.AutoSize = True
        Me.lblStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatement.Location = New System.Drawing.Point(8, 16)
        Me.lblStatement.Name = "lblStatement"
        Me.lblStatement.Size = New System.Drawing.Size(0, 13)
        Me.lblStatement.TabIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblStatement)
        Me.GroupBox1.Location = New System.Drawing.Point(119, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 95)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(442, 24)
        Me.MenuStrip1.TabIndex = 49
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.EndToolStripMenuItem.Text = "&End"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EdjImages
        '
        Me.EdjImages.ImageStream = CType(resources.GetObject("EdjImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.EdjImages.TransparentColor = System.Drawing.Color.Transparent
        Me.EdjImages.Images.SetKeyName(0, "")
        Me.EdjImages.Images.SetKeyName(1, "")
        Me.EdjImages.Images.SetKeyName(2, "")
        Me.EdjImages.Images.SetKeyName(3, "")
        Me.EdjImages.Images.SetKeyName(4, "")
        Me.EdjImages.Images.SetKeyName(5, "")
        Me.EdjImages.Images.SetKeyName(6, "")
        Me.EdjImages.Images.SetKeyName(7, "")
        Me.EdjImages.Images.SetKeyName(8, "")
        Me.EdjImages.Images.SetKeyName(9, "")
        Me.EdjImages.Images.SetKeyName(10, "")
        Me.EdjImages.Images.SetKeyName(11, "")
        Me.EdjImages.Images.SetKeyName(12, "")
        Me.EdjImages.Images.SetKeyName(13, "")
        Me.EdjImages.Images.SetKeyName(14, "")
        Me.EdjImages.Images.SetKeyName(15, "")
        Me.EdjImages.Images.SetKeyName(16, "")
        Me.EdjImages.Images.SetKeyName(17, "")
        Me.EdjImages.Images.SetKeyName(18, "")
        Me.EdjImages.Images.SetKeyName(19, "")
        Me.EdjImages.Images.SetKeyName(20, "")
        Me.EdjImages.Images.SetKeyName(21, "")
        Me.EdjImages.Images.SetKeyName(22, "")
        Me.EdjImages.Images.SetKeyName(23, "")
        Me.EdjImages.Images.SetKeyName(24, "")
        Me.EdjImages.Images.SetKeyName(25, "")
        Me.EdjImages.Images.SetKeyName(26, "")
        Me.EdjImages.Images.SetKeyName(27, "")
        Me.EdjImages.Images.SetKeyName(28, "")
        Me.EdjImages.Images.SetKeyName(29, "")
        Me.EdjImages.Images.SetKeyName(30, "")
        Me.EdjImages.Images.SetKeyName(31, "")
        Me.EdjImages.Images.SetKeyName(32, "")
        Me.EdjImages.Images.SetKeyName(33, "")
        Me.EdjImages.Images.SetKeyName(34, "")
        Me.EdjImages.Images.SetKeyName(35, "")
        Me.EdjImages.Images.SetKeyName(36, "")
        Me.EdjImages.Images.SetKeyName(37, "")
        Me.EdjImages.Images.SetKeyName(38, "")
        Me.EdjImages.Images.SetKeyName(39, "")
        Me.EdjImages.Images.SetKeyName(40, "")
        Me.EdjImages.Images.SetKeyName(41, "")
        Me.EdjImages.Images.SetKeyName(42, "")
        Me.EdjImages.Images.SetKeyName(43, "")
        Me.EdjImages.Images.SetKeyName(44, "")
        Me.EdjImages.Images.SetKeyName(45, "")
        Me.EdjImages.Images.SetKeyName(46, "")
        Me.EdjImages.Images.SetKeyName(47, "")
        Me.EdjImages.Images.SetKeyName(48, "")
        Me.EdjImages.Images.SetKeyName(49, "")
        Me.EdjImages.Images.SetKeyName(50, "")
        Me.EdjImages.Images.SetKeyName(51, "")
        Me.EdjImages.Images.SetKeyName(52, "")
        Me.EdjImages.Images.SetKeyName(53, "")
        Me.EdjImages.Images.SetKeyName(54, "")
        Me.EdjImages.Images.SetKeyName(55, "")
        Me.EdjImages.Images.SetKeyName(56, "")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(442, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEnemyLevel)
        Me.Controls.Add(Me.lblPlayerLevel)
        Me.Controls.Add(Me.imgEnemy)
        Me.Controls.Add(Me.imgPlayer)
        Me.Controls.Add(Me.lblEnemyName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.prgEnemyHealth)
        Me.Controls.Add(Me.prgPlayerLvlProg)
        Me.Controls.Add(Me.lblCurrentPlayerHealth)
        Me.Controls.Add(Me.prgPlayerHealth)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Battle!"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.imgPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tolPlayer1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tolPlayer3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tolPlayer4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tolPLayer5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents prgPlayerHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCurrentPlayerHealth As System.Windows.Forms.Label
    Friend WithEvents prgPlayerLvlProg As System.Windows.Forms.ProgressBar
    Friend WithEvents prgEnemyHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblEnemyName As System.Windows.Forms.Label
    Friend WithEvents imgPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents imgEnemy As System.Windows.Forms.PictureBox
    Friend WithEvents lblEnemyLevel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSkillOne As System.Windows.Forms.Button
    Friend WithEvents btnSkillFour As System.Windows.Forms.Button
    Friend WithEvents btnSkillThree As System.Windows.Forms.Button
    Friend WithEvents btnSkillTwo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdMap As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmdWalkNorth As System.Windows.Forms.Button
    Friend WithEvents cmdWalkEast As System.Windows.Forms.Button
    Friend WithEvents cmdWalkSouth As System.Windows.Forms.Button
    Friend WithEvents cmdWalkWest As System.Windows.Forms.Button
    Friend WithEvents tolPlayer6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblPlayerLevel As System.Windows.Forms.Label
    Friend WithEvents lblStatement As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tolPlayer2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EdjImages As System.Windows.Forms.ImageList

End Class
