Public Class SytemUpTime
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDays
        '
        Me.lblDays.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDays.Location = New System.Drawing.Point(3, 0)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(32, 14)
        Me.lblDays.TabIndex = 5
        Me.lblDays.Text = "0000"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHours
        '
        Me.lblHours.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHours.Location = New System.Drawing.Point(41, 1)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(24, 13)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "00"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMin
        '
        Me.lblMin.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMin.Location = New System.Drawing.Point(71, 1)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(21, 13)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "00"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSec
        '
        Me.lblSec.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblSec.Location = New System.Drawing.Point(100, 1)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(20, 13)
        Me.lblSec.TabIndex = 8
        Me.lblSec.Text = "00"
        Me.lblSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(32, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "|"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(88, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ":"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(59, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 14)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = ":"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SytemUpTime
        '
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "SytemUpTime"
        Me.Size = New System.Drawing.Size(122, 14)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public ReadOnly Property Hours() As Integer
        Get
            Return CType(lblHours.Text, Integer)
        End Get
    End Property
    Public ReadOnly Property Days() As Integer
        Get
            Return CType(lblDays.Text, Integer)
        End Get
    End Property
    Public ReadOnly Property Minutes() As Integer
        Get
            Return CType(lblMin.Text, Integer)
        End Get
    End Property
    Public ReadOnly Property Seconds() As Integer
        Get
            Return CType(lblSec.Text, Integer)
        End Get
    End Property
    Private Sub ComputeUpTime()
        Dim nTicks As Double
        Dim nDays As Integer
        Dim nHours As Integer
        Dim nMin As Integer
        Dim nSec As Integer
        Dim TimeUp As String
        nTicks = Environment.TickCount
        nTicks = nTicks / 1000
        nDays = Int(nTicks / (3600 * 24))
        nTicks = nTicks - (Int(nTicks / (3600 * 24)) * (3600 * 24))
        nHours = Int(nTicks / 3600)
        nTicks = nTicks - (Int(nTicks / 3600) * 3600)
        nMin = Int(nTicks / 60)
        nTicks = nTicks - (Int(nTicks / 60) * 60)
        nSec = nTicks
        lblDays.Text = Str(nDays)
        lblHours.Text = Str(nHours)
        lblMin.Text = Str(nMin)
        lblSec.Text = Str(nSec)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ComputeUpTime()
    End Sub

    Private Sub SytemUpTime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComputeUpTime()
    End Sub
End Class
