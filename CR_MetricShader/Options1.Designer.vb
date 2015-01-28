<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options1
	Inherits DevExpress.CodeRush.Core.OptionsPage

	<System.Diagnostics.DebuggerNonUserCode()> _
	Public Sub New()
		MyBase.New()

		'This call is required by the Component Designer.
		InitializeComponent()

	End Sub

	'OptionsPage overrides dispose to clean up the component list.
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
        Me.cbxMetric = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblMaxWarn = New System.Windows.Forms.Label
        Me.chkEnabled = New System.Windows.Forms.CheckBox
        Me.Boundary3 = New System.Windows.Forms.TrackBar
        Me.Boundary2 = New System.Windows.Forms.TrackBar
        Me.Boundary1 = New System.Windows.Forms.TrackBar
        Me.lblPCent1 = New System.Windows.Forms.Label
        Me.lblPCent2 = New System.Windows.Forms.Label
        Me.lblPCent3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ColorPicker3 = New CR_MetricShader.ColorPicker
        Me.ColorPicker2 = New CR_MetricShader.ColorPicker
        Me.ColorPicker1 = New CR_MetricShader.ColorPicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ColorGradient = New CR_MetricShader.ColorPicker
        Me.lblMaxOpacity = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GradientLowerBoundary = New System.Windows.Forms.TrackBar
        Me.optMultiColor = New System.Windows.Forms.RadioButton
        Me.optSingleGradientColor = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblPCent4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.udMaxWarn = New System.Windows.Forms.NumericUpDown
        Me.cmdCopyMaxValue = New System.Windows.Forms.Button
        CType(Me.Boundary3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boundary2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boundary1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradientLowerBoundary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.udMaxWarn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxMetric
        '
        Me.cbxMetric.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMetric.FormattingEnabled = True
        Me.cbxMetric.Location = New System.Drawing.Point(74, 44)
        Me.cbxMetric.Name = "cbxMetric"
        Me.cbxMetric.Size = New System.Drawing.Size(260, 21)
        Me.cbxMetric.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Metric"
        '
        'lblMaxWarn
        '
        Me.lblMaxWarn.AutoSize = True
        Me.lblMaxWarn.Location = New System.Drawing.Point(341, 47)
        Me.lblMaxWarn.Name = "lblMaxWarn"
        Me.lblMaxWarn.Size = New System.Drawing.Size(39, 13)
        Me.lblMaxWarn.TabIndex = 6
        Me.lblMaxWarn.Text = "Label7"
        '
        'chkEnabled
        '
        Me.chkEnabled.AutoSize = True
        Me.chkEnabled.Checked = True
        Me.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEnabled.Location = New System.Drawing.Point(74, 21)
        Me.chkEnabled.Name = "chkEnabled"
        Me.chkEnabled.Size = New System.Drawing.Size(65, 17)
        Me.chkEnabled.TabIndex = 8
        Me.chkEnabled.Text = "Enabled"
        Me.chkEnabled.UseVisualStyleBackColor = True
        '
        'Boundary3
        '
        Me.Boundary3.LargeChange = 10
        Me.Boundary3.Location = New System.Drawing.Point(254, 124)
        Me.Boundary3.Maximum = 100
        Me.Boundary3.Minimum = 1
        Me.Boundary3.Name = "Boundary3"
        Me.Boundary3.Size = New System.Drawing.Size(164, 45)
        Me.Boundary3.SmallChange = 5
        Me.Boundary3.TabIndex = 3
        Me.Boundary3.TickFrequency = 10
        Me.Boundary3.Value = 1
        '
        'Boundary2
        '
        Me.Boundary2.LargeChange = 10
        Me.Boundary2.Location = New System.Drawing.Point(254, 84)
        Me.Boundary2.Maximum = 100
        Me.Boundary2.Minimum = 1
        Me.Boundary2.Name = "Boundary2"
        Me.Boundary2.Size = New System.Drawing.Size(164, 45)
        Me.Boundary2.SmallChange = 5
        Me.Boundary2.TabIndex = 3
        Me.Boundary2.TickFrequency = 10
        Me.Boundary2.Value = 1
        '
        'Boundary1
        '
        Me.Boundary1.LargeChange = 10
        Me.Boundary1.Location = New System.Drawing.Point(254, 40)
        Me.Boundary1.Maximum = 100
        Me.Boundary1.Minimum = 1
        Me.Boundary1.Name = "Boundary1"
        Me.Boundary1.Size = New System.Drawing.Size(164, 45)
        Me.Boundary1.SmallChange = 5
        Me.Boundary1.TabIndex = 3
        Me.Boundary1.TickFrequency = 10
        Me.Boundary1.Value = 1
        '
        'lblPCent1
        '
        Me.lblPCent1.AutoSize = True
        Me.lblPCent1.Location = New System.Drawing.Point(420, 45)
        Me.lblPCent1.Name = "lblPCent1"
        Me.lblPCent1.Size = New System.Drawing.Size(13, 13)
        Me.lblPCent1.TabIndex = 10
        Me.lblPCent1.Text = "1"
        '
        'lblPCent2
        '
        Me.lblPCent2.AutoSize = True
        Me.lblPCent2.Location = New System.Drawing.Point(420, 88)
        Me.lblPCent2.Name = "lblPCent2"
        Me.lblPCent2.Size = New System.Drawing.Size(13, 13)
        Me.lblPCent2.TabIndex = 10
        Me.lblPCent2.Text = "2"
        '
        'lblPCent3
        '
        Me.lblPCent3.AutoSize = True
        Me.lblPCent3.Location = New System.Drawing.Point(420, 132)
        Me.lblPCent3.Name = "lblPCent3"
        Me.lblPCent3.Size = New System.Drawing.Size(13, 13)
        Me.lblPCent3.TabIndex = 10
        Me.lblPCent3.Text = "3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(138, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Opacity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Boundary Percentage"
        '
        'ColorPicker3
        '
        Me.ColorPicker3.AllowOpacity = True
        Me.ColorPicker3.ColorBase = System.Drawing.Color.Empty
        Me.ColorPicker3.LabelWidth = 104
        Me.ColorPicker3.Location = New System.Drawing.Point(-27, 124)
        Me.ColorPicker3.Name = "ColorPicker3"
        Me.ColorPicker3.Opacity = 255
        Me.ColorPicker3.Size = New System.Drawing.Size(264, 31)
        Me.ColorPicker3.TabIndex = 9
        Me.ColorPicker3.Text = "Color3"
        '
        'ColorPicker2
        '
        Me.ColorPicker2.AllowOpacity = True
        Me.ColorPicker2.ColorBase = System.Drawing.Color.Empty
        Me.ColorPicker2.LabelWidth = 104
        Me.ColorPicker2.Location = New System.Drawing.Point(-27, 84)
        Me.ColorPicker2.Name = "ColorPicker2"
        Me.ColorPicker2.Opacity = 255
        Me.ColorPicker2.Size = New System.Drawing.Size(264, 31)
        Me.ColorPicker2.TabIndex = 9
        Me.ColorPicker2.Text = "Color2"
        '
        'ColorPicker1
        '
        Me.ColorPicker1.AllowOpacity = True
        Me.ColorPicker1.ColorBase = System.Drawing.Color.Black
        Me.ColorPicker1.LabelWidth = 104
        Me.ColorPicker1.Location = New System.Drawing.Point(-27, 40)
        Me.ColorPicker1.Name = "ColorPicker1"
        Me.ColorPicker1.Opacity = 255
        Me.ColorPicker1.Size = New System.Drawing.Size(264, 31)
        Me.ColorPicker1.TabIndex = 9
        Me.ColorPicker1.Text = "Color1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Please note: For sanity reasons..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(423, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Please keep Color1, Color2 and Color3's percentage value in ascending numerical o" & _
            "rder."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "m'Kay?"
        '
        'ColorGradient
        '
        Me.ColorGradient.AllowOpacity = True
        Me.ColorGradient.ColorBase = System.Drawing.Color.Red
        Me.ColorGradient.LabelWidth = 104
        Me.ColorGradient.Location = New System.Drawing.Point(-27, 38)
        Me.ColorGradient.Name = "ColorGradient"
        Me.ColorGradient.Opacity = 200
        Me.ColorGradient.Size = New System.Drawing.Size(264, 31)
        Me.ColorGradient.TabIndex = 9
        Me.ColorGradient.Text = "Gradient Color"
        '
        'lblMaxOpacity
        '
        Me.lblMaxOpacity.AutoSize = True
        Me.lblMaxOpacity.Location = New System.Drawing.Point(162, 12)
        Me.lblMaxOpacity.Name = "lblMaxOpacity"
        Me.lblMaxOpacity.Size = New System.Drawing.Size(66, 13)
        Me.lblMaxOpacity.TabIndex = 11
        Me.lblMaxOpacity.Text = "Max Opacity"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(313, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Lower Boundary"
        '
        'GradientLowerBoundary
        '
        Me.GradientLowerBoundary.LargeChange = 10
        Me.GradientLowerBoundary.Location = New System.Drawing.Point(260, 38)
        Me.GradientLowerBoundary.Maximum = 100
        Me.GradientLowerBoundary.Minimum = 1
        Me.GradientLowerBoundary.Name = "GradientLowerBoundary"
        Me.GradientLowerBoundary.Size = New System.Drawing.Size(164, 45)
        Me.GradientLowerBoundary.SmallChange = 5
        Me.GradientLowerBoundary.TabIndex = 3
        Me.GradientLowerBoundary.TickFrequency = 10
        Me.GradientLowerBoundary.Value = 1
        '
        'optMultiColor
        '
        Me.optMultiColor.AutoSize = True
        Me.optMultiColor.Checked = True
        Me.optMultiColor.Location = New System.Drawing.Point(19, 74)
        Me.optMultiColor.Name = "optMultiColor"
        Me.optMultiColor.Size = New System.Drawing.Size(93, 17)
        Me.optMultiColor.TabIndex = 12
        Me.optMultiColor.TabStop = True
        Me.optMultiColor.Text = "Multiple Colors"
        Me.optMultiColor.UseVisualStyleBackColor = True
        '
        'optSingleGradientColor
        '
        Me.optSingleGradientColor.AutoSize = True
        Me.optSingleGradientColor.Location = New System.Drawing.Point(19, 339)
        Me.optSingleGradientColor.Name = "optSingleGradientColor"
        Me.optSingleGradientColor.Size = New System.Drawing.Size(123, 17)
        Me.optSingleGradientColor.TabIndex = 12
        Me.optSingleGradientColor.Text = "Single Gradient color"
        Me.optSingleGradientColor.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPCent4)
        Me.Panel1.Controls.Add(Me.lblMaxOpacity)
        Me.Panel1.Controls.Add(Me.GradientLowerBoundary)
        Me.Panel1.Controls.Add(Me.ColorGradient)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(58, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 107)
        Me.Panel1.TabIndex = 13
        '
        'lblPCent4
        '
        Me.lblPCent4.AutoSize = True
        Me.lblPCent4.Location = New System.Drawing.Point(430, 43)
        Me.lblPCent4.Name = "lblPCent4"
        Me.lblPCent4.Size = New System.Drawing.Size(13, 13)
        Me.lblPCent4.TabIndex = 12
        Me.lblPCent4.Text = "4"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Boundary3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.ColorPicker1)
        Me.Panel2.Controls.Add(Me.lblPCent3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lblPCent2)
        Me.Panel2.Controls.Add(Me.ColorPicker2)
        Me.Panel2.Controls.Add(Me.lblPCent1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.ColorPicker3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Boundary2)
        Me.Panel2.Controls.Add(Me.Boundary1)
        Me.Panel2.Location = New System.Drawing.Point(58, 97)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(454, 236)
        Me.Panel2.TabIndex = 14
        '
        'udMaxWarn
        '
        Me.udMaxWarn.Location = New System.Drawing.Point(435, 45)
        Me.udMaxWarn.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.udMaxWarn.Name = "udMaxWarn"
        Me.udMaxWarn.Size = New System.Drawing.Size(77, 20)
        Me.udMaxWarn.TabIndex = 15
        '
        'cmdCopyMaxValue
        '
        Me.cmdCopyMaxValue.Location = New System.Drawing.Point(386, 41)
        Me.cmdCopyMaxValue.Name = "cmdCopyMaxValue"
        Me.cmdCopyMaxValue.Size = New System.Drawing.Size(32, 25)
        Me.cmdCopyMaxValue.TabIndex = 16
        Me.cmdCopyMaxValue.Text = "->"
        Me.cmdCopyMaxValue.UseVisualStyleBackColor = True
        '
        'Options1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdCopyMaxValue)
        Me.Controls.Add(Me.udMaxWarn)
        Me.Controls.Add(Me.optSingleGradientColor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.optMultiColor)
        Me.Controls.Add(Me.chkEnabled)
        Me.Controls.Add(Me.lblMaxWarn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxMetric)
        Me.Name = "Options1"
        Me.Size = New System.Drawing.Size(765, 480)
        CType(Me.Boundary3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boundary2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boundary1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradientLowerBoundary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.udMaxWarn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public Shared ReadOnly Property Storage() As DevExpress.CodeRush.Core.DecoupledStorage
        Get
            Return DevExpress.CodeRush.Core.CodeRush.Options.GetStorage(GetCategory(), GetPageName())
        End Get
    End Property

    Public Overrides ReadOnly Property Category() As String
        Get
            Return Options1.GetCategory()
        End Get
    End Property

    Public Overrides ReadOnly Property PageName() As String
        Get
            Return Options1.GetPageName()
        End Get
    End Property

    Public Shared Shadows Sub Show()
        DevExpress.CodeRush.Core.CodeRush.Command.Execute("Options", FullPath)
    End Sub
    Friend WithEvents cbxMetric As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblMaxWarn As System.Windows.Forms.Label
    Friend WithEvents chkEnabled As System.Windows.Forms.CheckBox
    Friend WithEvents Boundary3 As System.Windows.Forms.TrackBar
    Friend WithEvents Boundary2 As System.Windows.Forms.TrackBar
    Friend WithEvents Boundary1 As System.Windows.Forms.TrackBar
    Friend WithEvents ColorPicker1 As CR_MetricShader.ColorPicker
    Friend WithEvents ColorPicker2 As CR_MetricShader.ColorPicker
    Friend WithEvents ColorPicker3 As CR_MetricShader.ColorPicker
    Friend WithEvents lblPCent1 As System.Windows.Forms.Label
    Friend WithEvents lblPCent2 As System.Windows.Forms.Label
    Friend WithEvents lblPCent3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ColorGradient As CR_MetricShader.ColorPicker
    Friend WithEvents lblMaxOpacity As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GradientLowerBoundary As System.Windows.Forms.TrackBar
    Friend WithEvents optMultiColor As System.Windows.Forms.RadioButton
    Friend WithEvents optSingleGradientColor As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblPCent4 As System.Windows.Forms.Label
    Friend WithEvents udMaxWarn As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdCopyMaxValue As System.Windows.Forms.Button

	Public Shared ReadOnly Property FullPath() As String
		Get
			Return GetCategory() + "\" + GetPageName()
		End Get
	End Property

End Class
