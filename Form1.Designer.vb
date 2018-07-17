<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.MainCar = New System.Windows.Forms.PictureBox()
        Me.Left_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Game_Over = New System.Windows.Forms.Label()
        Me.Score_ = New System.Windows.Forms.Label()
        Me.Restartb = New System.Windows.Forms.Button()
        Me.Speedb = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(61, -36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(11, 78)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Location = New System.Drawing.Point(62, 315)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 77)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox3.Location = New System.Drawing.Point(147, 315)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 77)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox4.Location = New System.Drawing.Point(62, 210)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 78)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox5.Location = New System.Drawing.Point(147, -36)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 78)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox6.Location = New System.Drawing.Point(147, 210)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 78)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox7.Location = New System.Drawing.Point(147, 81)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 80)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox8.Location = New System.Drawing.Point(62, 82)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 79)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'MainCar
        '
        Me.MainCar.Image = CType(resources.GetObject("MainCar.Image"), System.Drawing.Image)
        Me.MainCar.Location = New System.Drawing.Point(97, 287)
        Me.MainCar.Name = "MainCar"
        Me.MainCar.Size = New System.Drawing.Size(28, 48)
        Me.MainCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainCar.TabIndex = 8
        Me.MainCar.TabStop = False
        '
        'Left_Mover
        '
        Me.Left_Mover.Interval = 10
        '
        'Right_Mover
        '
        Me.Right_Mover.Interval = 10
        '
        'EnemyCar2
        '
        Me.EnemyCar2.Image = CType(resources.GetObject("EnemyCar2.Image"), System.Drawing.Image)
        Me.EnemyCar2.Location = New System.Drawing.Point(97, -36)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(23, 47)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 10
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar1
        '
        Me.EnemyCar1.Image = CType(resources.GetObject("EnemyCar1.Image"), System.Drawing.Image)
        Me.EnemyCar1.Location = New System.Drawing.Point(22, 160)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(23, 47)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 14
        Me.EnemyCar1.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.Image = CType(resources.GetObject("EnemyCar3.Image"), System.Drawing.Image)
        Me.EnemyCar3.Location = New System.Drawing.Point(198, 46)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(23, 47)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 15
        Me.EnemyCar3.TabStop = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'Game_Over
        '
        Me.Game_Over.AutoSize = True
        Me.Game_Over.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Game_Over.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Game_Over.ForeColor = System.Drawing.Color.Red
        Me.Game_Over.Location = New System.Drawing.Point(21, 46)
        Me.Game_Over.Name = "Game_Over"
        Me.Game_Over.Size = New System.Drawing.Size(176, 33)
        Me.Game_Over.TabIndex = 16
        Me.Game_Over.Text = "Game Over"
        Me.Game_Over.Visible = False
        '
        'Score_
        '
        Me.Score_.AutoSize = True
        Me.Score_.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Score_.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_.ForeColor = System.Drawing.Color.Cornsilk
        Me.Score_.Location = New System.Drawing.Point(11, 9)
        Me.Score_.Name = "Score_"
        Me.Score_.Size = New System.Drawing.Size(61, 16)
        Me.Score_.TabIndex = 17
        Me.Score_.Text = "Score 0"
        '
        'Restartb
        '
        Me.Restartb.BackColor = System.Drawing.SystemColors.Control
        Me.Restartb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restartb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Restartb.Location = New System.Drawing.Point(75, 163)
        Me.Restartb.Name = "Restartb"
        Me.Restartb.Size = New System.Drawing.Size(69, 25)
        Me.Restartb.TabIndex = 18
        Me.Restartb.Text = "Restart"
        Me.Restartb.UseVisualStyleBackColor = False
        Me.Restartb.Visible = False
        '
        'Speedb
        '
        Me.Speedb.AutoSize = True
        Me.Speedb.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Speedb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speedb.ForeColor = System.Drawing.Color.Cornsilk
        Me.Speedb.Location = New System.Drawing.Point(160, 9)
        Me.Speedb.Name = "Speedb"
        Me.Speedb.Size = New System.Drawing.Size(66, 16)
        Me.Speedb.TabIndex = 19
        Me.Speedb.Text = "Speed 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(224, 361)
        Me.Controls.Add(Me.Speedb)
        Me.Controls.Add(Me.Restartb)
        Me.Controls.Add(Me.Score_)
        Me.Controls.Add(Me.Game_Over)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.MainCar)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents MainCar As PictureBox
    Friend WithEvents Left_Mover As Timer
    Friend WithEvents Right_Mover As Timer
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents Enemy1_Mover As Timer
    Friend WithEvents Enemy2_Mover As Timer
    Friend WithEvents Enemy3_Mover As Timer
    Friend WithEvents Game_Over As Label
    Friend WithEvents Score_ As Label
    Friend WithEvents Restartb As Button
    Friend WithEvents Speedb As Label
End Class
