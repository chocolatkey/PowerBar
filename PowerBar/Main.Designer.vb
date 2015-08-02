<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OptionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.AudioTrackBar = New System.Windows.Forms.TrackBar()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CPULabel = New System.Windows.Forms.Label()
        Me.RAMLabel = New System.Windows.Forms.Label()
        Me.CPUSpeedLabel = New System.Windows.Forms.Label()
        Me.RAMSizeLabel = New System.Windows.Forms.Label()
        Me.CPUPerf = New System.Diagnostics.PerformanceCounter()
        Me.NetworkLabel = New System.Windows.Forms.Label()
        Me.NetworkDownLabel = New System.Windows.Forms.Label()
        Me.NetworkUpLabel = New System.Windows.Forms.Label()
        Me.NetworkSentPerf = New System.Diagnostics.PerformanceCounter()
        Me.NetworkRecievedPerf = New System.Diagnostics.PerformanceCounter()
        Me.DiskWritePerf = New System.Diagnostics.PerformanceCounter()
        Me.DiskReadPerf = New System.Diagnostics.PerformanceCounter()
        Me.DiskLabel = New System.Windows.Forms.Label()
        Me.DiskWriteLabel = New System.Windows.Forms.Label()
        Me.DiskReadLabel = New System.Windows.Forms.Label()
        Me.MainTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MuteButton = New System.Windows.Forms.Button()
        Me.GraphMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GraphTitleItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphForegroundCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.GraphBackgroundCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UpTimeLabel = New System.Windows.Forms.Label()
        Me.RAMVPB = New PowerBar.VerticalProgressBar()
        Me.CPUVPB = New PowerBar.VerticalProgressBar()
        Me.RightVPB = New PowerBar.VerticalProgressBar()
        Me.LeftVPB = New PowerBar.VerticalProgressBar()
        Me.OptionsMenu.SuspendLayout()
        CType(Me.AudioTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPUPerf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetworkSentPerf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NetworkRecievedPerf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiskWritePerf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiskReadPerf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GraphMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionsMenu
        '
        Me.OptionsMenu.BackColor = System.Drawing.Color.Black
        Me.OptionsMenu.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitItem, Me.OptionsItem})
        Me.OptionsMenu.Name = "Options"
        Me.OptionsMenu.ShowImageMargin = False
        Me.OptionsMenu.Size = New System.Drawing.Size(99, 48)
        '
        'ExitItem
        '
        Me.ExitItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitItem.Name = "ExitItem"
        Me.ExitItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitItem.Text = "Exit"
        '
        'OptionsItem
        '
        Me.OptionsItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsItem.ForeColor = System.Drawing.SystemColors.Control
        Me.OptionsItem.Name = "OptionsItem"
        Me.OptionsItem.Size = New System.Drawing.Size(98, 22)
        Me.OptionsItem.Text = "Options"
        '
        'TimeLabel
        '
        Me.TimeLabel.ContextMenuStrip = Me.OptionsMenu
        Me.TimeLabel.Font = New System.Drawing.Font("Consolas", 8.5!)
        Me.TimeLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.TimeLabel.Location = New System.Drawing.Point(12, 356)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(137, 29)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "Loading..."
        Me.TimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MainTip.SetToolTip(Me.TimeLabel, "Date & Time")
        '
        'AudioTrackBar
        '
        Me.AudioTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AudioTrackBar.Location = New System.Drawing.Point(58, 195)
        Me.AudioTrackBar.Maximum = 50
        Me.AudioTrackBar.Name = "AudioTrackBar"
        Me.AudioTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.AudioTrackBar.Size = New System.Drawing.Size(45, 106)
        Me.AudioTrackBar.TabIndex = 3
        Me.AudioTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.MainTip.SetToolTip(Me.AudioTrackBar, "Master Volume")
        '
        'TitleLabel
        '
        Me.TitleLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(137, 16)
        Me.TitleLabel.TabIndex = 6
        Me.TitleLabel.Text = "PowerBar 1.3 Beta"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TitleLabel.Visible = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(84, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'CPULabel
        '
        Me.CPULabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPULabel.ForeColor = System.Drawing.SystemColors.Control
        Me.CPULabel.Location = New System.Drawing.Point(12, 163)
        Me.CPULabel.Name = "CPULabel"
        Me.CPULabel.Size = New System.Drawing.Size(32, 16)
        Me.CPULabel.TabIndex = 10
        Me.CPULabel.Text = "CPU"
        Me.CPULabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RAMLabel
        '
        Me.RAMLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RAMLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.RAMLabel.Location = New System.Drawing.Point(50, 163)
        Me.RAMLabel.Name = "RAMLabel"
        Me.RAMLabel.Size = New System.Drawing.Size(32, 16)
        Me.RAMLabel.TabIndex = 13
        Me.RAMLabel.Text = "RAM"
        Me.RAMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CPUSpeedLabel
        '
        Me.CPUSpeedLabel.Font = New System.Drawing.Font("Consolas", 7.0!)
        Me.CPUSpeedLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.CPUSpeedLabel.Location = New System.Drawing.Point(12, 41)
        Me.CPUSpeedLabel.Name = "CPUSpeedLabel"
        Me.CPUSpeedLabel.Size = New System.Drawing.Size(32, 16)
        Me.CPUSpeedLabel.TabIndex = 14
        Me.CPUSpeedLabel.Text = "..."
        Me.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MainTip.SetToolTip(Me.CPUSpeedLabel, "CPU Clock Speed (GHz)")
        '
        'RAMSizeLabel
        '
        Me.RAMSizeLabel.Font = New System.Drawing.Font("Consolas", 7.0!)
        Me.RAMSizeLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.RAMSizeLabel.Location = New System.Drawing.Point(50, 41)
        Me.RAMSizeLabel.Name = "RAMSizeLabel"
        Me.RAMSizeLabel.Size = New System.Drawing.Size(32, 16)
        Me.RAMSizeLabel.TabIndex = 15
        Me.RAMSizeLabel.Text = "..."
        Me.RAMSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MainTip.SetToolTip(Me.RAMSizeLabel, "Total RAM")
        '
        'CPUPerf
        '
        Me.CPUPerf.CategoryName = "Processor"
        Me.CPUPerf.CounterName = "% Processor Time"
        Me.CPUPerf.InstanceName = "_Total"
        '
        'NetworkLabel
        '
        Me.NetworkLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.NetworkLabel.Location = New System.Drawing.Point(88, 60)
        Me.NetworkLabel.Name = "NetworkLabel"
        Me.NetworkLabel.Size = New System.Drawing.Size(61, 16)
        Me.NetworkLabel.TabIndex = 16
        Me.NetworkLabel.Text = "Network"
        Me.NetworkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NetworkDownLabel
        '
        Me.NetworkDownLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkDownLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.NetworkDownLabel.Location = New System.Drawing.Point(88, 92)
        Me.NetworkDownLabel.Name = "NetworkDownLabel"
        Me.NetworkDownLabel.Size = New System.Drawing.Size(70, 16)
        Me.NetworkDownLabel.TabIndex = 17
        Me.NetworkDownLabel.Text = "↓ ..."
        Me.NetworkDownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainTip.SetToolTip(Me.NetworkDownLabel, "Download rate")
        '
        'NetworkUpLabel
        '
        Me.NetworkUpLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetworkUpLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.NetworkUpLabel.Location = New System.Drawing.Point(88, 76)
        Me.NetworkUpLabel.Name = "NetworkUpLabel"
        Me.NetworkUpLabel.Size = New System.Drawing.Size(70, 16)
        Me.NetworkUpLabel.TabIndex = 18
        Me.NetworkUpLabel.Text = "↑ ..."
        Me.NetworkUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainTip.SetToolTip(Me.NetworkUpLabel, "Upload rate")
        '
        'NetworkSentPerf
        '
        Me.NetworkSentPerf.CategoryName = "Network Interface"
        Me.NetworkSentPerf.CounterName = "Bytes Sent/sec"
        '
        'NetworkRecievedPerf
        '
        Me.NetworkRecievedPerf.CategoryName = "Network Interface"
        Me.NetworkRecievedPerf.CounterName = "Bytes Received/sec"
        '
        'DiskWritePerf
        '
        Me.DiskWritePerf.CategoryName = "LogicalDisk"
        Me.DiskWritePerf.CounterName = "Disk Write Bytes/sec"
        Me.DiskWritePerf.InstanceName = "_Total"
        '
        'DiskReadPerf
        '
        Me.DiskReadPerf.CategoryName = "LogicalDisk"
        Me.DiskReadPerf.CounterName = "Disk Read Bytes/sec"
        Me.DiskReadPerf.InstanceName = "_Total"
        '
        'DiskLabel
        '
        Me.DiskLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiskLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DiskLabel.Location = New System.Drawing.Point(88, 110)
        Me.DiskLabel.Name = "DiskLabel"
        Me.DiskLabel.Size = New System.Drawing.Size(61, 16)
        Me.DiskLabel.TabIndex = 19
        Me.DiskLabel.Text = "Disk"
        Me.DiskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiskWriteLabel
        '
        Me.DiskWriteLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiskWriteLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DiskWriteLabel.Location = New System.Drawing.Point(88, 144)
        Me.DiskWriteLabel.Name = "DiskWriteLabel"
        Me.DiskWriteLabel.Size = New System.Drawing.Size(70, 16)
        Me.DiskWriteLabel.TabIndex = 20
        Me.DiskWriteLabel.Text = "W ..."
        Me.DiskWriteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainTip.SetToolTip(Me.DiskWriteLabel, "Write rate")
        '
        'DiskReadLabel
        '
        Me.DiskReadLabel.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiskReadLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DiskReadLabel.Location = New System.Drawing.Point(88, 126)
        Me.DiskReadLabel.Name = "DiskReadLabel"
        Me.DiskReadLabel.Size = New System.Drawing.Size(70, 16)
        Me.DiskReadLabel.TabIndex = 21
        Me.DiskReadLabel.Text = "R ..."
        Me.DiskReadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainTip.SetToolTip(Me.DiskReadLabel, "Read rate")
        '
        'MainTip
        '
        Me.MainTip.BackColor = System.Drawing.Color.Black
        Me.MainTip.ForeColor = System.Drawing.SystemColors.Control
        Me.MainTip.ShowAlways = True
        Me.MainTip.Tag = "Write Rate"
        Me.MainTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.MainTip.ToolTipTitle = "Description"
        '
        'MuteButton
        '
        Me.MuteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.MuteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.MuteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MuteButton.ForeColor = System.Drawing.SystemColors.Control
        Me.MuteButton.Image = Global.PowerBar.My.Resources.Resources.audio_volume_high
        Me.MuteButton.Location = New System.Drawing.Point(65, 307)
        Me.MuteButton.Name = "MuteButton"
        Me.MuteButton.Size = New System.Drawing.Size(31, 31)
        Me.MuteButton.TabIndex = 2
        Me.MainTip.SetToolTip(Me.MuteButton, "Mute")
        Me.MuteButton.UseVisualStyleBackColor = True
        '
        'GraphMenu
        '
        Me.GraphMenu.BackColor = System.Drawing.Color.Black
        Me.GraphMenu.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GraphTitleItem, Me.GraphForegroundCombo, Me.GraphBackgroundCombo})
        Me.GraphMenu.Name = "GraphMenu"
        Me.GraphMenu.ShowImageMargin = False
        Me.GraphMenu.Size = New System.Drawing.Size(156, 78)
        '
        'GraphTitleItem
        '
        Me.GraphTitleItem.Enabled = False
        Me.GraphTitleItem.ForeColor = System.Drawing.SystemColors.Control
        Me.GraphTitleItem.Name = "GraphTitleItem"
        Me.GraphTitleItem.Size = New System.Drawing.Size(155, 22)
        Me.GraphTitleItem.Text = "Graph"
        '
        'GraphForegroundCombo
        '
        Me.GraphForegroundCombo.BackColor = System.Drawing.Color.Black
        Me.GraphForegroundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GraphForegroundCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GraphForegroundCombo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphForegroundCombo.ForeColor = System.Drawing.Color.White
        Me.GraphForegroundCombo.MaxDropDownItems = 50
        Me.GraphForegroundCombo.Name = "GraphForegroundCombo"
        Me.GraphForegroundCombo.Size = New System.Drawing.Size(120, 22)
        Me.GraphForegroundCombo.ToolTipText = "Foreground"
        '
        'GraphBackgroundCombo
        '
        Me.GraphBackgroundCombo.BackColor = System.Drawing.Color.Black
        Me.GraphBackgroundCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GraphBackgroundCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GraphBackgroundCombo.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraphBackgroundCombo.ForeColor = System.Drawing.Color.White
        Me.GraphBackgroundCombo.MaxDropDownItems = 50
        Me.GraphBackgroundCombo.Name = "GraphBackgroundCombo"
        Me.GraphBackgroundCombo.Size = New System.Drawing.Size(120, 22)
        Me.GraphBackgroundCombo.ToolTipText = "Background"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(0, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 10)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "_______________________________"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(0, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 10)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "_______________________________"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "________________________________"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'UpTimeLabel
        '
        Me.UpTimeLabel.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpTimeLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.UpTimeLabel.Location = New System.Drawing.Point(2, 9)
        Me.UpTimeLabel.Name = "UpTimeLabel"
        Me.UpTimeLabel.Size = New System.Drawing.Size(156, 16)
        Me.UpTimeLabel.TabIndex = 25
        Me.UpTimeLabel.Text = "Uptime: "
        Me.UpTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MainTip.SetToolTip(Me.UpTimeLabel, "Computer Uptime")
        '
        'RAMVPB
        '
        Me.RAMVPB.BackColor = System.Drawing.Color.Black
        Me.RAMVPB.ContextMenuStrip = Me.GraphMenu
        Me.RAMVPB.ForeColor = System.Drawing.Color.Yellow
        Me.RAMVPB.Location = New System.Drawing.Point(50, 60)
        Me.RAMVPB.Name = "RAMVPB"
        Me.RAMVPB.Size = New System.Drawing.Size(32, 100)
        Me.RAMVPB.Step = 1
        Me.RAMVPB.TabIndex = 12
        Me.MainTip.SetToolTip(Me.RAMVPB, "RAM Usage Graph")
        '
        'CPUVPB
        '
        Me.CPUVPB.BackColor = System.Drawing.Color.Black
        Me.CPUVPB.ContextMenuStrip = Me.GraphMenu
        Me.CPUVPB.ForeColor = System.Drawing.Color.Green
        Me.CPUVPB.Location = New System.Drawing.Point(12, 60)
        Me.CPUVPB.Name = "CPUVPB"
        Me.CPUVPB.Size = New System.Drawing.Size(32, 100)
        Me.CPUVPB.Step = 1
        Me.CPUVPB.TabIndex = 8
        Me.MainTip.SetToolTip(Me.CPUVPB, "CPU Usage Graph")
        '
        'RightVPB
        '
        Me.RightVPB.BackColor = System.Drawing.Color.Black
        Me.RightVPB.ContextMenuStrip = Me.GraphMenu
        Me.RightVPB.ForeColor = System.Drawing.Color.Maroon
        Me.RightVPB.Location = New System.Drawing.Point(109, 195)
        Me.RightVPB.MarqueeAnimationSpeed = 0
        Me.RightVPB.Name = "RightVPB"
        Me.RightVPB.Size = New System.Drawing.Size(24, 144)
        Me.RightVPB.TabIndex = 5
        Me.MainTip.SetToolTip(Me.RightVPB, "Right VU Meter")
        '
        'LeftVPB
        '
        Me.LeftVPB.BackColor = System.Drawing.Color.Black
        Me.LeftVPB.ContextMenuStrip = Me.GraphMenu
        Me.LeftVPB.ForeColor = System.Drawing.Color.Maroon
        Me.LeftVPB.Location = New System.Drawing.Point(28, 195)
        Me.LeftVPB.MarqueeAnimationSpeed = 0
        Me.LeftVPB.Name = "LeftVPB"
        Me.LeftVPB.Size = New System.Drawing.Size(24, 144)
        Me.LeftVPB.TabIndex = 4
        Me.MainTip.SetToolTip(Me.LeftVPB, "Left VU Meter")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(161, 393)
        Me.ContextMenuStrip = Me.OptionsMenu
        Me.Controls.Add(Me.UpTimeLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DiskReadLabel)
        Me.Controls.Add(Me.DiskWriteLabel)
        Me.Controls.Add(Me.DiskLabel)
        Me.Controls.Add(Me.NetworkUpLabel)
        Me.Controls.Add(Me.NetworkDownLabel)
        Me.Controls.Add(Me.NetworkLabel)
        Me.Controls.Add(Me.RAMSizeLabel)
        Me.Controls.Add(Me.CPUSpeedLabel)
        Me.Controls.Add(Me.RAMLabel)
        Me.Controls.Add(Me.RAMVPB)
        Me.Controls.Add(Me.CPULabel)
        Me.Controls.Add(Me.CPUVPB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.RightVPB)
        Me.Controls.Add(Me.LeftVPB)
        Me.Controls.Add(Me.AudioTrackBar)
        Me.Controls.Add(Me.MuteButton)
        Me.Controls.Add(Me.TimeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.ShowInTaskbar = False
        Me.Text = "PowerBar"
        Me.MainTip.SetToolTip(Me, "PowerBar 1.4")
        Me.OptionsMenu.ResumeLayout(False)
        CType(Me.AudioTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPUPerf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetworkSentPerf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NetworkRecievedPerf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiskWritePerf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiskReadPerf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GraphMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents OptionsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeLabel As System.Windows.Forms.Label
    Friend WithEvents MuteButton As System.Windows.Forms.Button
    Friend WithEvents AudioTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents LeftVPB As PowerBar.VerticalProgressBar
    Friend WithEvents RightVPB As PowerBar.VerticalProgressBar
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CPUVPB As PowerBar.VerticalProgressBar
    Friend WithEvents CPULabel As System.Windows.Forms.Label
    Friend WithEvents RAMVPB As PowerBar.VerticalProgressBar
    Friend WithEvents RAMLabel As System.Windows.Forms.Label
    Friend WithEvents CPUSpeedLabel As System.Windows.Forms.Label
    Friend WithEvents RAMSizeLabel As System.Windows.Forms.Label
    Friend WithEvents CPUPerf As System.Diagnostics.PerformanceCounter
    Friend WithEvents NetworkLabel As System.Windows.Forms.Label
    Friend WithEvents NetworkDownLabel As System.Windows.Forms.Label
    Friend WithEvents NetworkUpLabel As System.Windows.Forms.Label
    Friend WithEvents NetworkSentPerf As System.Diagnostics.PerformanceCounter
    Friend WithEvents NetworkRecievedPerf As System.Diagnostics.PerformanceCounter
    Friend WithEvents DiskWritePerf As System.Diagnostics.PerformanceCounter
    Friend WithEvents DiskReadPerf As System.Diagnostics.PerformanceCounter
    Friend WithEvents MainTip As System.Windows.Forms.ToolTip
    Friend WithEvents DiskLabel As System.Windows.Forms.Label
    Friend WithEvents DiskWriteLabel As System.Windows.Forms.Label
    Friend WithEvents DiskReadLabel As System.Windows.Forms.Label
    Friend WithEvents GraphMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GraphForegroundCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GraphBackgroundCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GraphTitleItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UpTimeLabel As System.Windows.Forms.Label

End Class
