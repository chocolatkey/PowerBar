<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.ForegroundLabel = New System.Windows.Forms.Label()
        Me.GeneralLabel = New System.Windows.Forms.Label()
        Me.VUMeterLabel = New System.Windows.Forms.Label()
        Me.GeneralIntervalCombo = New System.Windows.Forms.ComboBox()
        Me.VUIntervalNumeric = New System.Windows.Forms.NumericUpDown()
        Me.NetAdapterLabel = New System.Windows.Forms.Label()
        Me.msLabel = New System.Windows.Forms.Label()
        Me.UpdateGroupBox = New System.Windows.Forms.GroupBox()
        Me.NetAdapterCombo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OpacityCheckBox = New System.Windows.Forms.CheckBox()
        Me.ForegroundButton = New System.Windows.Forms.Button()
        Me.BackgroundButton = New System.Windows.Forms.Button()
        Me.ForegroundText = New System.Windows.Forms.TextBox()
        Me.BackgroundText = New System.Windows.Forms.TextBox()
        Me.OpacityLabel = New System.Windows.Forms.Label()
        Me.BackgroundLabel = New System.Windows.Forms.Label()
        Me.ForegroundColorDialog = New System.Windows.Forms.ColorDialog()
        Me.BackgroundColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog3 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.PositionCombo = New System.Windows.Forms.ComboBox()
        Me.PositionLabel = New System.Windows.Forms.Label()
        CType(Me.VUIntervalNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ForegroundLabel
        '
        Me.ForegroundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForegroundLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.ForegroundLabel.Location = New System.Drawing.Point(6, 17)
        Me.ForegroundLabel.Name = "ForegroundLabel"
        Me.ForegroundLabel.Size = New System.Drawing.Size(89, 17)
        Me.ForegroundLabel.TabIndex = 1
        Me.ForegroundLabel.Text = "Forground"
        '
        'GeneralLabel
        '
        Me.GeneralLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.GeneralLabel.Location = New System.Drawing.Point(6, 25)
        Me.GeneralLabel.Name = "GeneralLabel"
        Me.GeneralLabel.Size = New System.Drawing.Size(89, 17)
        Me.GeneralLabel.TabIndex = 2
        Me.GeneralLabel.Text = "General"
        '
        'VUMeterLabel
        '
        Me.VUMeterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VUMeterLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.VUMeterLabel.Location = New System.Drawing.Point(6, 51)
        Me.VUMeterLabel.Name = "VUMeterLabel"
        Me.VUMeterLabel.Size = New System.Drawing.Size(89, 17)
        Me.VUMeterLabel.TabIndex = 3
        Me.VUMeterLabel.Text = "VU Meter"
        '
        'GeneralIntervalCombo
        '
        Me.GeneralIntervalCombo.BackColor = System.Drawing.Color.Black
        Me.GeneralIntervalCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GeneralIntervalCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralIntervalCombo.ForeColor = System.Drawing.SystemColors.Control
        Me.GeneralIntervalCombo.FormattingEnabled = True
        Me.GeneralIntervalCombo.Items.AddRange(New Object() {"Fast (0.25s)", "Normal (0.5s)", "Slow (1s)"})
        Me.GeneralIntervalCombo.Location = New System.Drawing.Point(100, 22)
        Me.GeneralIntervalCombo.Name = "GeneralIntervalCombo"
        Me.GeneralIntervalCombo.Size = New System.Drawing.Size(121, 21)
        Me.GeneralIntervalCombo.TabIndex = 4
        '
        'VUIntervalNumeric
        '
        Me.VUIntervalNumeric.BackColor = System.Drawing.Color.Black
        Me.VUIntervalNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VUIntervalNumeric.ForeColor = System.Drawing.SystemColors.Control
        Me.VUIntervalNumeric.Location = New System.Drawing.Point(101, 49)
        Me.VUIntervalNumeric.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.VUIntervalNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.VUIntervalNumeric.Name = "VUIntervalNumeric"
        Me.VUIntervalNumeric.Size = New System.Drawing.Size(94, 20)
        Me.VUIntervalNumeric.TabIndex = 5
        Me.VUIntervalNumeric.Tag = ""
        Me.VUIntervalNumeric.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'NetAdapterLabel
        '
        Me.NetAdapterLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.NetAdapterLabel.Location = New System.Drawing.Point(7, 91)
        Me.NetAdapterLabel.Name = "NetAdapterLabel"
        Me.NetAdapterLabel.Size = New System.Drawing.Size(89, 17)
        Me.NetAdapterLabel.TabIndex = 6
        Me.NetAdapterLabel.Text = "Net Adapter"
        '
        'msLabel
        '
        Me.msLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.msLabel.Location = New System.Drawing.Point(201, 51)
        Me.msLabel.Name = "msLabel"
        Me.msLabel.Size = New System.Drawing.Size(20, 17)
        Me.msLabel.TabIndex = 7
        Me.msLabel.Text = "ms"
        '
        'UpdateGroupBox
        '
        Me.UpdateGroupBox.Controls.Add(Me.GeneralLabel)
        Me.UpdateGroupBox.Controls.Add(Me.msLabel)
        Me.UpdateGroupBox.Controls.Add(Me.VUMeterLabel)
        Me.UpdateGroupBox.Controls.Add(Me.GeneralIntervalCombo)
        Me.UpdateGroupBox.Controls.Add(Me.VUIntervalNumeric)
        Me.UpdateGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateGroupBox.ForeColor = System.Drawing.SystemColors.Control
        Me.UpdateGroupBox.Location = New System.Drawing.Point(1, 1)
        Me.UpdateGroupBox.Name = "UpdateGroupBox"
        Me.UpdateGroupBox.Size = New System.Drawing.Size(232, 78)
        Me.UpdateGroupBox.TabIndex = 8
        Me.UpdateGroupBox.TabStop = False
        Me.UpdateGroupBox.Text = "Update Interval"
        '
        'NetAdapterCombo
        '
        Me.NetAdapterCombo.BackColor = System.Drawing.Color.Black
        Me.NetAdapterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NetAdapterCombo.ForeColor = System.Drawing.SystemColors.Control
        Me.NetAdapterCombo.FormattingEnabled = True
        Me.NetAdapterCombo.Location = New System.Drawing.Point(101, 88)
        Me.NetAdapterCombo.Name = "NetAdapterCombo"
        Me.NetAdapterCombo.Size = New System.Drawing.Size(121, 21)
        Me.NetAdapterCombo.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OpacityCheckBox)
        Me.GroupBox1.Controls.Add(Me.ForegroundButton)
        Me.GroupBox1.Controls.Add(Me.BackgroundButton)
        Me.GroupBox1.Controls.Add(Me.ForegroundText)
        Me.GroupBox1.Controls.Add(Me.BackgroundText)
        Me.GroupBox1.Controls.Add(Me.OpacityLabel)
        Me.GroupBox1.Controls.Add(Me.BackgroundLabel)
        Me.GroupBox1.Controls.Add(Me.ForegroundLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(1, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 101)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Theme"
        '
        'OpacityCheckBox
        '
        Me.OpacityCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpacityCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpacityCheckBox.Location = New System.Drawing.Point(100, 54)
        Me.OpacityCheckBox.Name = "OpacityCheckBox"
        Me.OpacityCheckBox.Size = New System.Drawing.Size(126, 17)
        Me.OpacityCheckBox.TabIndex = 13
        Me.OpacityCheckBox.Text = "???"
        Me.OpacityCheckBox.UseVisualStyleBackColor = True
        '
        'ForegroundButton
        '
        Me.ForegroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ForegroundButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForegroundButton.Location = New System.Drawing.Point(204, 15)
        Me.ForegroundButton.Name = "ForegroundButton"
        Me.ForegroundButton.Size = New System.Drawing.Size(22, 18)
        Me.ForegroundButton.TabIndex = 12
        Me.ForegroundButton.Text = "..."
        Me.ForegroundButton.UseVisualStyleBackColor = True
        '
        'BackgroundButton
        '
        Me.BackgroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackgroundButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackgroundButton.Location = New System.Drawing.Point(204, 36)
        Me.BackgroundButton.Name = "BackgroundButton"
        Me.BackgroundButton.Size = New System.Drawing.Size(22, 18)
        Me.BackgroundButton.TabIndex = 11
        Me.BackgroundButton.Text = "..."
        Me.BackgroundButton.UseVisualStyleBackColor = True
        '
        'ForegroundText
        '
        Me.ForegroundText.BackColor = System.Drawing.Color.Black
        Me.ForegroundText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForegroundText.ForeColor = System.Drawing.SystemColors.Control
        Me.ForegroundText.Location = New System.Drawing.Point(100, 15)
        Me.ForegroundText.Margin = New System.Windows.Forms.Padding(2)
        Me.ForegroundText.Name = "ForegroundText"
        Me.ForegroundText.ReadOnly = True
        Me.ForegroundText.Size = New System.Drawing.Size(100, 18)
        Me.ForegroundText.TabIndex = 6
        Me.ForegroundText.Text = "#ERROR"
        '
        'BackgroundText
        '
        Me.BackgroundText.BackColor = System.Drawing.Color.Black
        Me.BackgroundText.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackgroundText.ForeColor = System.Drawing.SystemColors.Control
        Me.BackgroundText.Location = New System.Drawing.Point(100, 35)
        Me.BackgroundText.Margin = New System.Windows.Forms.Padding(2)
        Me.BackgroundText.Name = "BackgroundText"
        Me.BackgroundText.ReadOnly = True
        Me.BackgroundText.Size = New System.Drawing.Size(100, 18)
        Me.BackgroundText.TabIndex = 5
        Me.BackgroundText.Text = "#ERROR"
        '
        'OpacityLabel
        '
        Me.OpacityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpacityLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.OpacityLabel.Location = New System.Drawing.Point(6, 56)
        Me.OpacityLabel.Name = "OpacityLabel"
        Me.OpacityLabel.Size = New System.Drawing.Size(89, 17)
        Me.OpacityLabel.TabIndex = 3
        Me.OpacityLabel.Text = "Opacity"
        '
        'BackgroundLabel
        '
        Me.BackgroundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackgroundLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.BackgroundLabel.Location = New System.Drawing.Point(6, 37)
        Me.BackgroundLabel.Name = "BackgroundLabel"
        Me.BackgroundLabel.Size = New System.Drawing.Size(89, 17)
        Me.BackgroundLabel.TabIndex = 2
        Me.BackgroundLabel.Text = "Background"
        '
        'PositionCombo
        '
        Me.PositionCombo.BackColor = System.Drawing.Color.Black
        Me.PositionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PositionCombo.ForeColor = System.Drawing.SystemColors.Control
        Me.PositionCombo.FormattingEnabled = True
        Me.PositionCombo.Items.AddRange(New Object() {"Top Left", "Top Right", "Center Left", "Center Right", "Bottom Left", "Bottom Right"})
        Me.PositionCombo.Location = New System.Drawing.Point(101, 116)
        Me.PositionCombo.Name = "PositionCombo"
        Me.PositionCombo.Size = New System.Drawing.Size(121, 21)
        Me.PositionCombo.TabIndex = 12
        '
        'PositionLabel
        '
        Me.PositionLabel.AutoEllipsis = True
        Me.PositionLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.PositionLabel.Location = New System.Drawing.Point(7, 119)
        Me.PositionLabel.Name = "PositionLabel"
        Me.PositionLabel.Size = New System.Drawing.Size(88, 17)
        Me.PositionLabel.TabIndex = 11
        Me.PositionLabel.Text = "Position"
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(234, 250)
        Me.Controls.Add(Me.PositionCombo)
        Me.Controls.Add(Me.PositionLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NetAdapterCombo)
        Me.Controls.Add(Me.UpdateGroupBox)
        Me.Controls.Add(Me.NetAdapterLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PowerBar Options"
        CType(Me.VUIntervalNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateGroupBox.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ForegroundLabel As System.Windows.Forms.Label
    Friend WithEvents GeneralLabel As System.Windows.Forms.Label
    Friend WithEvents VUMeterLabel As System.Windows.Forms.Label
    Friend WithEvents GeneralIntervalCombo As System.Windows.Forms.ComboBox
    Friend WithEvents VUIntervalNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents NetAdapterLabel As System.Windows.Forms.Label
    Friend WithEvents msLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NetAdapterCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ForegroundText As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundText As System.Windows.Forms.TextBox
    Friend WithEvents OpacityLabel As System.Windows.Forms.Label
    Friend WithEvents BackgroundLabel As System.Windows.Forms.Label
    Friend WithEvents ForegroundColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents BackgroundColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorDialog3 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents ForegroundButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundButton As System.Windows.Forms.Button
    Friend WithEvents OpacityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PositionCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PositionLabel As System.Windows.Forms.Label
End Class
