Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.CodeRush.Core
Imports System.Runtime.CompilerServices

<UserLevel(UserLevel.NewUser)> _
Public Class Options1
    'DXCore-generated code...
#Region " Initialize "
    Protected Overrides Sub Initialize()
        MyBase.Initialize()

        'TODO: Add your initialization code here.
    End Sub
#End Region

#Region " GetCategory "
    Public Shared Function GetCategory() As String
        Return "Editor\Painting"
    End Function
#End Region
#Region " GetPageName "
    Public Shared Function GetPageName() As String
        Return "Metric Shader"
    End Function
#End Region

#Region "Consts"
    Friend Const SETTING_MetricIndex As String = "MetricIndex"
    Friend Const SETTING_MetricMaxWarn As String = "MetricMaxWarn"
    Friend Const SETTING_MetricShader As String = "MetricShader"
    Friend Const SETTING_ShaderEnabled As String = "ShaderEnabled"
    Friend Const SETTING_Boundary1 As String = "Boundary1"
    Friend Const SETTING_Boundary2 As String = "Boundary2"
    Friend Const SETTING_Boundary3 As String = "Boundary3"
    Friend Const SETTING_Opacity1 As String = "Opacity1"
    Friend Const SETTING_Opacity2 As String = "Opacity2"
    Friend Const SETTING_Opacity3 As String = "Opacity3"
    Friend Const SETTING_Color1 As String = "Color1"
    Friend Const SETTING_Color2 As String = "Color2"
    Friend Const SETTING_Color3 As String = "Color3"
    Friend Const SETTING_MODE As String = "Mode"
    Friend Const SETTING_GRADIENT_COLOR As String = "GradientColor"
    Friend Const SETTING_GRADIENT_MAX_OPACITY As String = "GradientMaxOpacity"
    Friend Const SETTING_GRADIENT_LOWER_BOUNDARY As String = "GradientLowerBoundary"

    Friend Const DEFAULT_BOUNDARY1 As Double = 0.25
    Friend Const DEFAULT_BOUNDARY2 As Double = 0.5
    Friend Const DEFAULT_BOUNDARY3 As Double = 0.75
    Friend Const DEFAULT_OPACITY1 As Integer = 30
    Friend Const DEFAULT_OPACITY2 As Integer = 50
    Friend Const DEFAULT_OPACITY3 As Integer = 75
    Friend Const DEFAULT_METRIC_INDEX As Integer = 0
    Friend Const DEFAULT_METRIC_MAXWARN As Integer = 200
    Friend Const DEFAULT_METRIC_ENABLED As Boolean = True
    Friend Shared ReadOnly DEFAULT_COLOR1 As Color = Color.Green
    Friend Shared ReadOnly DEFAULT_COLOR2 As Color = Color.Orange
    Friend Shared ReadOnly DEFAULT_COLOR3 As Color = Color.Red
    Friend Shared ReadOnly DEFAULT_COLOR_GRADIENT As Color = Color.Red

    Friend Const DEFAULT_MODE As String = "MultiColor"
    Friend Const DEFAULT_GRADIENT_OPACITY As Integer = 127
    Friend Const DEFAULT_GRADIENT_LOWER_BOUNDARY As Double = 0.25
    Friend Const MODE_MULTI_COLOR As String = "MultiColor"
    Friend Const MODE_SINGLE_GRADIENT_COLOR As String = "SingleGradientColor"
#End Region

    Friend Shared Function Providers() As ICodeMetricProvider()
        Return CodeRush.Source.GetAllCodeMetricProviders.Where(Function(f) f.MetricGoal <> MetricGoal.Types).ToArray
    End Function
    Private Sub RefreshProviderList()
        cbxMetric.Items.Clear()
        For Each Provider In Providers()
            cbxMetric.Items.Add(Provider.DisplayName)
        Next
    End Sub
    Private Sub Options1_RestoreDefaults(ByVal sender As Object, ByVal ea As OptionsPageEventArgs) Handles Me.RestoreDefaults
        ' Load Default Values
        Call RefreshProviderList()
        cbxMetric.SelectedIndex = DEFAULT_METRIC_INDEX
        udMaxWarn.Value = DEFAULT_METRIC_MAXWARN
        chkEnabled.Checked = True
        Boundary1.Value = 100 * DEFAULT_BOUNDARY1
        Boundary2.Value = 100 * DEFAULT_BOUNDARY2
        Boundary3.Value = 100 * DEFAULT_BOUNDARY3
        ColorPicker1.ColorBase = DEFAULT_COLOR1
        ColorPicker2.ColorBase = DEFAULT_COLOR2
        ColorPicker3.ColorBase = DEFAULT_COLOR3
        ColorPicker1.Opacity = DEFAULT_OPACITY1
        ColorPicker2.Opacity = DEFAULT_OPACITY2
        ColorPicker3.Opacity = DEFAULT_OPACITY3

        optMultiColor.Checked = (DEFAULT_MODE = MODE_MULTI_COLOR)
        optSingleGradientColor.Checked = (DEFAULT_MODE = MODE_SINGLE_GRADIENT_COLOR)
        ColorGradient.ColorBase = DEFAULT_COLOR_GRADIENT
        ColorGradient.Opacity = DEFAULT_GRADIENT_OPACITY
        GradientLowerBoundary.Value = 100 * DEFAULT_GRADIENT_LOWER_BOUNDARY
    End Sub

    Private Sub Options1_PreparePage(ByVal sender As Object, ByVal ea As OptionsPageStorageEventArgs) Handles Me.PreparePage
        Call RefreshProviderList()
        cbxMetric.SelectedIndex = ea.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_MetricIndex, DEFAULT_METRIC_INDEX)
        udMaxWarn.Value = ea.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_MetricMaxWarn, Options1.DEFAULT_METRIC_MAXWARN)
        chkEnabled.Checked = ea.Storage.ReadBoolean(Options1.SETTING_MetricShader, Options1.SETTING_ShaderEnabled, DEFAULT_METRIC_ENABLED)
        Boundary1.Value = 100 * ea.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary1, DEFAULT_BOUNDARY1)
        Boundary2.Value = 100 * ea.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary2, DEFAULT_BOUNDARY2)
        Boundary3.Value = 100 * ea.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary3, DEFAULT_BOUNDARY3)
        ColorPicker1.ColorBase = ea.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_Color1, DEFAULT_COLOR1)
        ColorPicker2.ColorBase = ea.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_Color2, DEFAULT_COLOR2)
        ColorPicker3.ColorBase = ea.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_Color3, DEFAULT_COLOR3)
        ColorPicker1.Opacity = ea.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity1, DEFAULT_OPACITY1)
        ColorPicker2.Opacity = ea.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity2, DEFAULT_OPACITY2)
        ColorPicker3.Opacity = ea.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity3, DEFAULT_OPACITY3)

        optMultiColor.Checked = MODE_MULTI_COLOR = ea.Storage.ReadString(Options1.SETTING_MetricShader, Options1.SETTING_MODE, DEFAULT_MODE)
        optSingleGradientColor.Checked = MODE_SINGLE_GRADIENT_COLOR = ea.Storage.ReadString(Options1.SETTING_MetricShader, Options1.SETTING_MODE, DEFAULT_MODE)
        ColorGradient.ColorBase = ea.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_COLOR, DEFAULT_COLOR_GRADIENT)
        ColorGradient.Opacity = ea.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_MAX_OPACITY, DEFAULT_GRADIENT_OPACITY)
        GradientLowerBoundary.Value = 100 * Math.Max(0, ea.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_LOWER_BOUNDARY, DEFAULT_GRADIENT_LOWER_BOUNDARY))

        Call UpdateMaxLabels()
    End Sub

    Private Sub Options1_CommitChanges(ByVal sender As Object, ByVal ea As CommitChangesEventArgs) Handles Me.CommitChanges
        Using Storage = ea.Storage
            Storage.WriteInt32(SETTING_MetricShader, SETTING_MetricIndex, cbxMetric.SelectedIndex)
            Storage.WriteInt32(SETTING_MetricShader, SETTING_MetricMaxWarn, udMaxWarn.Value)
            Storage.WriteBoolean(SETTING_MetricShader, SETTING_ShaderEnabled, chkEnabled.Checked)
            Storage.WriteDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary1, Boundary1.Value / 100)
            Storage.WriteDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary2, Boundary2.Value / 100)
            Storage.WriteDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary3, Boundary3.Value / 100)
            Storage.WriteColor(Options1.SETTING_MetricShader, Options1.SETTING_Color1, ColorPicker1.ColorBase)
            Storage.WriteColor(Options1.SETTING_MetricShader, Options1.SETTING_Color2, ColorPicker2.ColorBase)
            Storage.WriteColor(Options1.SETTING_MetricShader, Options1.SETTING_Color3, ColorPicker3.ColorBase)
            Storage.WriteInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity1, ColorPicker1.Opacity)
            Storage.WriteInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity2, ColorPicker2.Opacity)
            Storage.WriteInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity3, ColorPicker3.Opacity)

            Storage.WriteString(Options1.SETTING_MetricShader, Options1.SETTING_MODE, If(optMultiColor.Checked, MODE_MULTI_COLOR, MODE_SINGLE_GRADIENT_COLOR))
            Storage.WriteColor(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_COLOR, ColorGradient.ColorBase)
            Storage.WriteInt32(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_MAX_OPACITY, ColorGradient.Opacity)
            Storage.WriteDouble(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_LOWER_BOUNDARY, GradientLowerBoundary.Value / 100)
        End Using
    End Sub

    Private Sub cbxMetric_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxMetric.SelectedIndexChanged
        lblMaxWarn.Text = Providers(cbxMetric.SelectedIndex).WarningValue
    End Sub

    Private Sub Boundary1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boundary1.ValueChanged
        Call UpdateMaxLabels()
    End Sub

    Private Sub Boundary2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boundary2.ValueChanged
        Call UpdateMaxLabels()
    End Sub

    Private Sub Boundary3_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Boundary3.ValueChanged, GradientLowerBoundary.ValueChanged
        Call UpdateMaxLabels()
    End Sub

    Private Sub GradientLowerBoundary_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradientLowerBoundary.Scroll
        Call UpdateMaxLabels()
    End Sub

    Private Sub UpdateMaxLabels()
        lblPCent1.Text = String.Format("{0:0.00}", Boundary1.Value / 100)
        lblPCent2.Text = String.Format("{0:0.00}", Boundary2.Value / 100)
        lblPCent3.Text = String.Format("{0:0.00}", Boundary3.Value / 100)
        lblPCent4.Text = String.Format("{0:0.00}", GradientLowerBoundary.Value / 100)
    End Sub

    Private Sub cmdCopyMaxValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopyMaxValue.Click
        udMaxWarn.Value = lblMaxWarn.Text
    End Sub
End Class
