<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblRareCount = New System.Windows.Forms.Label
        Me.lblRarePerc = New System.Windows.Forms.Label
        Me.lblSuperRareCount = New System.Windows.Forms.Label
        Me.lblSuperRarePerc = New System.Windows.Forms.Label
        Me.lblTotalCount = New System.Windows.Forms.Label
        Me.lblTotalPerc = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rare:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Super Rare:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'lblRareCount
        '
        Me.lblRareCount.AutoSize = True
        Me.lblRareCount.Location = New System.Drawing.Point(99, 18)
        Me.lblRareCount.Name = "lblRareCount"
        Me.lblRareCount.Size = New System.Drawing.Size(0, 13)
        Me.lblRareCount.TabIndex = 3
        '
        'lblRarePerc
        '
        Me.lblRarePerc.AutoSize = True
        Me.lblRarePerc.Location = New System.Drawing.Point(174, 18)
        Me.lblRarePerc.Name = "lblRarePerc"
        Me.lblRarePerc.Size = New System.Drawing.Size(0, 13)
        Me.lblRarePerc.TabIndex = 4
        '
        'lblSuperRareCount
        '
        Me.lblSuperRareCount.AutoSize = True
        Me.lblSuperRareCount.Location = New System.Drawing.Point(99, 43)
        Me.lblSuperRareCount.Name = "lblSuperRareCount"
        Me.lblSuperRareCount.Size = New System.Drawing.Size(0, 13)
        Me.lblSuperRareCount.TabIndex = 5
        '
        'lblSuperRarePerc
        '
        Me.lblSuperRarePerc.AutoSize = True
        Me.lblSuperRarePerc.Location = New System.Drawing.Point(174, 43)
        Me.lblSuperRarePerc.Name = "lblSuperRarePerc"
        Me.lblSuperRarePerc.Size = New System.Drawing.Size(0, 13)
        Me.lblSuperRarePerc.TabIndex = 6
        '
        'lblTotalCount
        '
        Me.lblTotalCount.AutoSize = True
        Me.lblTotalCount.Location = New System.Drawing.Point(99, 93)
        Me.lblTotalCount.Name = "lblTotalCount"
        Me.lblTotalCount.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalCount.TabIndex = 7
        '
        'lblTotalPerc
        '
        Me.lblTotalPerc.AutoSize = True
        Me.lblTotalPerc.Location = New System.Drawing.Point(174, 93)
        Me.lblTotalPerc.Name = "lblTotalPerc"
        Me.lblTotalPerc.Size = New System.Drawing.Size(0, 13)
        Me.lblTotalPerc.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 24)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 154)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotalPerc)
        Me.Controls.Add(Me.lblTotalCount)
        Me.Controls.Add(Me.lblSuperRarePerc)
        Me.Controls.Add(Me.lblSuperRareCount)
        Me.Controls.Add(Me.lblRarePerc)
        Me.Controls.Add(Me.lblRareCount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.Text = "Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRareCount As System.Windows.Forms.Label
    Friend WithEvents lblRarePerc As System.Windows.Forms.Label
    Friend WithEvents lblSuperRareCount As System.Windows.Forms.Label
    Friend WithEvents lblSuperRarePerc As System.Windows.Forms.Label
    Friend WithEvents lblTotalCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalPerc As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
