Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports Microsoft.Win32
Imports System.Globalization
Imports System.Net.NetworkInformation

Public Class MainForm
    Dim func = New Func
    Public WithEvents Second As New Timer
    Dim time As String
    Dim graph As VerticalProgressBar ''current selected graph
    Dim thisCulture = Globalization.CultureInfo.CurrentCulture
    Public AudioAPI As New SimplifiedAudioAPI
    Private OUT_Muted As Boolean
    Public AudioTimer As Timer
    Private INvScalarValue As Single
    Private OUTvScalarValue As Single
    Private Event InVolumeScalarChanged(ByVal value As Single)
    Private Event OutVolumeScalarChanged(ByVal value As Single)
    Public pcc As New PerformanceCounterCategory("Network Interface")
    Public na As Integer
    Dim total As String = My.Computer.Info.TotalPhysicalMemory
    <DllImport("uxtheme", ExactSpelling:=True, CharSet:=CharSet.Unicode)> _
    Public Shared Function SetWindowTheme(hWnd As IntPtr, textSubAppName As [String], textSubIdList As [String]) As Int32
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        ''Me.BackColor = Color.LimeGreen
        ''Audio
        If AudioAPI.OUT_MUTE = False Then
            OUT_Muted = True : MuteButton.Image = Global.PowerBar.My.Resources.Resources.audio_volume_high
            RightVPB.ForeColor = System.Drawing.Color.Maroon
            LeftVPB.ForeColor = System.Drawing.Color.Maroon
        Else
            OUT_Muted = False : MuteButton.Image = Global.PowerBar.My.Resources.Resources.audio_volume_muted
        End If
        INvScalarValue = AudioAPI.IN_MasterScalar : RaiseEvent InVolumeScalarChanged(INvScalarValue)
        OUTvScalarValue = AudioAPI.OUT_MasterScalar : RaiseEvent OutVolumeScalarChanged(OUTvScalarValue)
        AudioTimer = New Timer(New System.ComponentModel.Container)
        AudioTimer.Interval = My.Settings.VUInterval
        AddHandler AudioTimer.Tick, AddressOf tChecker_Tick
        AudioTimer.Enabled = True

        ''Themes
        SetWindowTheme(Handle, "", "")
        SetWindowTheme(RightVPB.Handle, "", "")
        SetWindowTheme(LeftVPB.Handle, "", "")
        SetWindowTheme(AudioTrackBar.Handle, "", "")
        SetWindowTheme(CPUVPB.Handle, "", "")
        SetWindowTheme(RAMVPB.Handle, "", "")
        ''SetWindowTheme(GraphMenu.Handle, "", "")
        LoadS()

    End Sub

    Private Sub tChecker_Tick()
        If AudioAPI.OUT_MUTE = True And OUT_Muted = False Then
            VToggle(False)
            OUT_Muted = True
        ElseIf AudioAPI.OUT_MUTE = False And OUT_Muted = True Then
            VToggle(True)
            OUT_Muted = False
        End If
        RefreshProgressbarValues()

        If (INvScalarValue = AudioAPI.IN_MasterScalar) = False Then
            INvScalarValue = AudioAPI.IN_MasterScalar
            RaiseEvent InVolumeScalarChanged(INvScalarValue)
        ElseIf (OUTvScalarValue = AudioAPI.OUT_MasterScalar) = False Then
            OUTvScalarValue = AudioAPI.OUT_MasterScalar
            RaiseEvent OutVolumeScalarChanged(OUTvScalarValue)
        End If
    End Sub

    Private Sub ExtOutVolumeChanged(ByVal value As Single) Handles Me.OutVolumeScalarChanged
        AudioTrackBar.Value = CInt(value * 50.0F) ''value is number of positions on track
    End Sub

    Private Sub RefreshProgressbarValues()
        ''VPB_OUT_MASTER.Value = AudioAPI.GetPeakValue(SimplifiedAudioAPI.AudioChannels.GET_OUT_MasterPeak)

        Try
            LeftVPB.Value = AudioAPI.GetPeakValue(SimplifiedAudioAPI.AudioChannels.GET_OUT_LeftPeak)
            RightVPB.Value = AudioAPI.GetPeakValue(SimplifiedAudioAPI.AudioChannels.GET_OUT_RightPeak)
        Catch ex As Exception
            LeftVPB.Value = 0
            RightVPB.Value = 0
        End Try


    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ''Position
        Position()

        'Turn on the time update timer
        Second.Enabled = True
        Second.Start()

        ''CPU Clock Speed
        Dim Str As String = "Hardware\DESCRIPTION\System\CentralProcessor\0"
        Dim strspeed As String = "~MHz"
        CPUSpeedLabel.Text = Math.Round(Integer.Parse(Registry.LocalMachine.OpenSubKey(Str.ToString).GetValue(strspeed.ToString)) / 1024, 2)
        ''Total RAM
        RAMSizeLabel.Text = Math.Round((My.Computer.Info.TotalPhysicalMemory / 1024) / 1024 / 1024, 1)
    End Sub

    Public Sub Position()
        Select Case My.Settings.Position
            Case 0 'Top Left
                Me.Left = Screen.PrimaryScreen.WorkingArea.Left
                Me.Top = Screen.PrimaryScreen.WorkingArea.Top
            Case 1 'Top Right
                Me.Left = Screen.PrimaryScreen.WorkingArea.Right - Me.Width
                Me.Top = Screen.PrimaryScreen.WorkingArea.Top
            Case 2 'Center Left
                Me.Left = Screen.PrimaryScreen.WorkingArea.Left
                Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            Case 3 'Center Right
                Me.Left = (Screen.PrimaryScreen.WorkingArea.Right - Me.Width)
                Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
            Case 4 'Bottom Left
                Me.Left = Screen.PrimaryScreen.WorkingArea.Left
                Me.Top = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height
            Case 5 'Bottom Right
                Me.Left = Screen.PrimaryScreen.WorkingArea.Right - Me.Width
                Me.Top = Screen.PrimaryScreen.WorkingArea.Bottom - Me.Height
        End Select
        Me.SendToBack()
    End Sub

    Private Sub ExitItem_Click(sender As Object, e As EventArgs) Handles ExitItem.Click
        SaveS()
        Application.Exit()
    End Sub

    'Actions to perform on each timer tick:
    Private Sub Second_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Second.Tick
        ''Time
        Try
            time = DateTime.Now.ToString("hh:mm:ss tt")
            TimeLabel.Text = time + vbNewLine + thisCulture.DateTimeFormat.GetDayName(thisCulture.Calendar.GetDayOfWeek(Date.Today)).ToString.Substring(0, 3) & ". " & MonthName(Date.Now.Month, True) & ". " & Date.Now.Day & " " & Date.Now.Year
        Catch ex As Exception
            TimeLabel.Text = "?"
        End Try

        ''CPU
        Try
            CPUVPB.Value = CInt(Fix(CPUPerf.NextValue()))
        Catch ex As Exception
            CPUVPB.Value = 0
        End Try

        ''RAM
        Try
            Dim avail As String = My.Computer.Info.AvailablePhysicalMemory
            RAMVPB.Increment(0)
            RAMVPB.Value = ((total - avail) / total * 100)
        Catch ex As Exception
            RAMVPB.Value = 0
        End Try

        ''Network
        Try
            NetworkUpLabel.Text = "↑ " & func.CalcRate(NetworkSentPerf.NextValue())
            NetworkDownLabel.Text = "↓ " & func.CalcRate(NetworkRecievedPerf.NextValue())
        Catch ex As Exception
            NetworkUpLabel.Text = "↑ ?"
            NetworkDownLabel.Text = "↓ ?"
        End Try

        ''Disk
        Try
            DiskReadLabel.Text = "R " & func.CalcRate(DiskReadPerf.NextValue)
            DiskWriteLabel.Text = "W " & func.CalcRate(DiskWritePerf.NextValue)
        Catch ex As Exception
            DiskReadLabel.Text = "R ?"
            DiskWriteLabel.Text = "W ?"
        End Try

        ''Uptime
        ComputeUpTime()

    End Sub

    ''' <summary>
    ''' Compute computer up time
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ComputeUpTime()
        Dim nTicks As Double
        Dim nDays As Integer
        Dim nHours As Integer
        Dim nMin As Integer
        Dim nSec As Integer
        nTicks = Environment.TickCount
        nTicks = nTicks / 1000
        nDays = Int(nTicks / (3600 * 24))
        nTicks = nTicks - (Int(nTicks / (3600 * 24)) * (3600 * 24))
        nHours = Int(nTicks / 3600)
        nTicks = nTicks - (Int(nTicks / 3600) * 3600)
        nMin = Int(nTicks / 60)
        nTicks = nTicks - (Int(nTicks / 60) * 60)
        nSec = nTicks
        UpTimeLabel.Text = "Up: " & nDays & "d | " & nHours.ToString.PadLeft(2, "0") & ":" & nDays.ToString.PadLeft(2, "0") & ":" & nSec.ToString.PadLeft(2, "0")
    End Sub


    Private Sub MuteButton_Click(sender As Object, e As EventArgs) Handles MuteButton.Click
        If OUT_Muted = True Then
            VToggle(True)
            AudioAPI.OUT_MUTE = False
            OUT_Muted = False
        ElseIf OUT_Muted = False Then
            VToggle(False)
            AudioAPI.OUT_MUTE = True
            OUT_Muted = True
        End If
    End Sub

    ''' <summary>
    ''' Toggle Mute Styling
    ''' </summary>
    ''' <param name="e">Is Muted</param>
    ''' <remarks></remarks>
    Private Sub VToggle(ByVal e As Boolean)
        If e Then
            MuteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
            MuteButton.Image = Global.PowerBar.My.Resources.Resources.audio_volume_high
            RightVPB.ForeColor = System.Drawing.Color.Maroon
            LeftVPB.ForeColor = System.Drawing.Color.Maroon
        Else
            MuteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
            MuteButton.Image = Global.PowerBar.My.Resources.Resources.audio_volume_muted
            RightVPB.ForeColor = System.Drawing.Color.Gray
            LeftVPB.ForeColor = System.Drawing.Color.Gray
        End If
    End Sub

    Private Sub AudioTrackBar_Scroll(sender As Object, e As EventArgs) Handles AudioTrackBar.Scroll
        AudioAPI.OUT_MasterScalar = ((CSng(AudioTrackBar.Value) / 500.0F) * 10.0F)
    End Sub

    Private Sub MainForm_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.SendToBack()
    End Sub

    Private Sub OptionsItem_Click(sender As Object, e As EventArgs) Handles OptionsItem.Click
        Options.Show()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub GraphMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GraphMenu.Opening
        ''Reset Text color
        ''GraphBackgroundCombo.ForeColor = Color.Black
        ''GraphForegroundCombo.ForeColor = Color.Black

        graph = GraphMenu.SourceControl ''Graph that context menu was opened from
        GraphTitleItem.Text = MainTip.GetToolTip(graph) ''Graph name from tooltip
        ''MsgBox(graph.ToString)
        GraphForegroundCombo.Items.Clear()
        GraphBackgroundCombo.Items.Clear()
        ''Load web colors in combos
        Dim i As Integer = 0
        For Each col As KnownColor In [Enum].GetValues(GetType(KnownColor))
            Dim color As Color = color.FromKnownColor(col)
            ' If this is not a system color, add that color to graphforeground combobox
            If Not color.IsSystemColor And Not color = Drawing.Color.Transparent Then
                GraphForegroundCombo.Items.Add(col.ToString())
                GraphBackgroundCombo.Items.Add(col.ToString())
            Else
                ' If this is a system color
            End If
            i = +1
        Next
        ''Get Graph colors
        GraphForegroundCombo.SelectedItem = graph.ForeColor.ToKnownColor.ToString
        GraphBackgroundCombo.SelectedItem = graph.BackColor.ToKnownColor.ToString
    End Sub

    Private Sub GraphForegroundCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GraphForegroundCombo.SelectedIndexChanged
        Dim cc As Color = Color.FromName(GraphForegroundCombo.SelectedItem)
        graph.ForeColor = cc
        GraphForegroundCombo.BackColor = cc
        GraphForegroundCombo.ForeColor = func.InverseColor(cc)
    End Sub

    Private Sub GraphBackgroundCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GraphBackgroundCombo.SelectedIndexChanged
        Dim cc As Color = Color.FromName(GraphBackgroundCombo.SelectedItem)
        graph.BackColor = cc
        GraphBackgroundCombo.BackColor = cc
        GraphBackgroundCombo.ForeColor = func.InverseColor(cc)
    End Sub

    Sub SaveS()
        ''Save graph colors
        My.Settings.RVUFore = RightVPB.ForeColor
        My.Settings.RVUBack = RightVPB.BackColor
        My.Settings.LVUFore = LeftVPB.ForeColor
        My.Settings.LVUFore = LeftVPB.ForeColor
        My.Settings.CPUFore = CPUVPB.ForeColor
        My.Settings.CPUBack = CPUVPB.BackColor
        My.Settings.RAMFore = RAMVPB.ForeColor
        My.Settings.RAMBack = RAMVPB.BackColor
        'RightVPB.ForeColor = My.Settings.RVUFore
        'RightVPB.ForeColor = My.Settings.RVUFore
        'RightVPB.ForeColor = My.Settings.RVUFore
        'RightVPB.ForeColor = My.Settings.RVUFore
        My.Settings.Save()
    End Sub

    Sub LoadS()
        ''Load graph colors
        RightVPB.ForeColor = My.Settings.RVUFore
        RightVPB.BackColor = My.Settings.RVUBack
        LeftVPB.ForeColor = My.Settings.LVUFore
        LeftVPB.ForeColor = My.Settings.LVUFore
        CPUVPB.ForeColor = My.Settings.CPUFore
        CPUVPB.BackColor = My.Settings.CPUBack
        RAMVPB.ForeColor = My.Settings.RAMFore
        RAMVPB.BackColor = My.Settings.RAMBack

        Me.BackColor = My.Settings.Background
        If My.Settings.Transparent Then
            Me.TransparencyKey = My.Settings.Background
            Me.AllowTransparency = True
        End If

        ''Set Foreground colors
        Dim f As Color = My.Settings.Foreground
        TitleLabel.ForeColor = f
        CPULabel.ForeColor = f
        CPUSpeedLabel.ForeColor = f
        RAMLabel.ForeColor = f
        RAMSizeLabel.ForeColor = f
        NetworkLabel.ForeColor = f
        NetworkDownLabel.ForeColor = f
        NetworkUpLabel.ForeColor = f
        DiskLabel.ForeColor = f
        DiskReadLabel.ForeColor = f
        DiskWriteLabel.ForeColor = f
        TimeLabel.ForeColor = f
        UpTimeLabel.ForeColor = f


        'Set the interval for each timer "tick"
        Second.Interval = My.Settings.GeneralInterval

        ''Network Adapter
        If pcc.GetInstanceNames().Length >= My.Settings.NetAdapter Then
            na = My.Settings.NetAdapter
        Else
            MsgBox("Selected network Adapter not found, resetting")
            My.Settings.NetAdapter = 0
            na = My.Settings.NetAdapter
        End If
        NetworkSentPerf.InstanceName = pcc.GetInstanceNames(na)
        NetworkRecievedPerf.InstanceName = pcc.GetInstanceNames(na)
    End Sub

End Class
