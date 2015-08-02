Imports System.Runtime.InteropServices

Public Class Options
    Dim func = New Func

    <DllImport("uxtheme", ExactSpelling:=True, CharSet:=CharSet.Unicode)> _
    Public Shared Function SetWindowTheme(hWnd As IntPtr, textSubAppName As [String], textSubIdList As [String]) As Int32
    End Function

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetWindowTheme(Handle, "", "")
        SetWindowTheme(VUIntervalNumeric.Handle, "", "")
        SetWindowTheme(GeneralIntervalCombo.Handle, "", "")
        SetWindowTheme(NetAdapterCombo.Handle, "", "")
        SetWindowTheme(OpacityCheckBox.Handle, "", "")
        SetWindowTheme(PositionCombo.Handle, "", "")
    End Sub

    Private Sub Options_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim na As String() = MainForm.pcc.GetInstanceNames()
        For Each adapter As String In na
            NetAdapterCombo.Items.Add(adapter)
        Next
        NetAdapterCombo.SelectedIndex = My.Settings.NetAdapter
        Select Case My.Settings.GeneralInterval
            Case 250
                GeneralIntervalCombo.SelectedIndex = 0
            Case 500
                GeneralIntervalCombo.SelectedIndex = 1
            Case 1000
                GeneralIntervalCombo.SelectedIndex = 2
            Case Else
                MsgBox("General Update Interval unknown! Setting to default (0.5s)", MsgBoxStyle.Exclamation)
                GeneralIntervalCombo.SelectedIndex = 1
                My.Settings.GeneralInterval = 500
        End Select


        OpacityCheckBox.Checked = My.Settings.Transparent
        OpaVal()
        ''Set chooser dialog values
        ForegroundColorDialog.Color = My.Settings.Foreground
        BackgroundColorDialog.Color = My.Settings.Background

        PositionCombo.SelectedIndex = My.Settings.Position

        TextCol()
    End Sub

    Private Sub VUIntervalNumeric_ValueChanged(sender As Object, e As EventArgs) Handles VUIntervalNumeric.ValueChanged
        My.Settings.VUInterval = VUIntervalNumeric.Value
        MainForm.AudioTimer.Interval = My.Settings.VUInterval
    End Sub

    Private Sub GeneralIntervalCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GeneralIntervalCombo.SelectedIndexChanged
        Select Case GeneralIntervalCombo.SelectedIndex
            Case 0
                My.Settings.GeneralInterval = 250
            Case 1
                My.Settings.GeneralInterval = 500
            Case 2
                My.Settings.GeneralInterval = 1000
        End Select
        MainForm.Second.Interval = My.Settings.GeneralInterval
    End Sub

    Private Sub NetAdapterCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NetAdapterCombo.SelectedIndexChanged
        My.Settings.NetAdapter = NetAdapterCombo.SelectedIndex
        MainForm.na = My.Settings.NetAdapter
        MainForm.LoadS()
    End Sub

    Private Sub OpacityCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles OpacityCheckBox.CheckedChanged
        OpaVal()
        ''change srt
    End Sub

    Sub OpaVal()
        If OpacityCheckBox.Checked Then
            OpacityCheckBox.Text = "Transparent"
            My.Settings.Transparent = True
            MainForm.AllowTransparency = True
            MainForm.TransparencyKey = My.Settings.Background
        Else
            OpacityCheckBox.Text = "Solid"
            MainForm.AllowTransparency = False
            My.Settings.Transparent = False
            MainForm.BackColor = My.Settings.Background
        End If
    End Sub

    Private Sub FontButton_Click(sender As Object, e As EventArgs)
        FontDialog.ShowDialog()
    End Sub

    Private Sub ForegroundButton_Click(sender As Object, e As EventArgs) Handles ForegroundButton.Click
        ForegroundColorDialog.ShowDialog()
        TextCol()
        My.Settings.Foreground = ForegroundColorDialog.Color
        MainForm.LoadS()
    End Sub

    Private Sub BackgroundButton_Click(sender As Object, e As EventArgs) Handles BackgroundButton.Click
        BackgroundColorDialog.ShowDialog()
        TextCol()
        My.Settings.Background = BackgroundColorDialog.Color
        MainForm.BackColor = My.Settings.Background
    End Sub

    Sub TextCol()
        ForegroundText.Text = ForegroundColorDialog.Color.R & "," & ForegroundColorDialog.Color.G & "," & ForegroundColorDialog.Color.B
        ForegroundText.BackColor = ForegroundColorDialog.Color
        ForegroundText.ForeColor = func.InverseColor(ForegroundColorDialog.Color)

        BackgroundText.Text = BackgroundColorDialog.Color.R & "," & BackgroundColorDialog.Color.G & "," & BackgroundColorDialog.Color.B
        BackgroundText.BackColor = BackgroundColorDialog.Color
        BackgroundText.ForeColor = func.InverseColor(BackgroundColorDialog.Color)

        If My.Settings.Transparent Then
            MainForm.TransparencyKey = BackgroundColorDialog.Color
        End If
    End Sub

    Private Sub PositionCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PositionCombo.SelectedIndexChanged
        My.Settings.Position = PositionCombo.SelectedIndex
        MainForm.Position()
    End Sub
End Class