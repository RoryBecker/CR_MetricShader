Option Strict On
Option Explicit On
Option Infer On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.CodeRush.Core
Imports DevExpress.CodeRush.PlugInCore
Imports DevExpress.CodeRush.StructuralParser
Imports System.Runtime.CompilerServices
Imports System.Reflection
Imports DevExpress.CodeRush.Menus
Imports DevExpress.CodeRush.Extensions
Imports Platform = DevExpress.DXCore.Platform.Drawing

Public Class PlugIn1

    'DXCore-generated code...
#Region " InitializePlugIn "
    Public Overrides Sub InitializePlugIn()
        MyBase.InitializePlugIn()

        'TODO: Add your initialization code here.
        Call LoadSettings()
        'Call CreateVisualizeButton()

    End Sub
#End Region
#Region " FinalizePlugIn "
    Public Overrides Sub FinalizePlugIn()
        'TODO: Add your finalization code here.

        MyBase.FinalizePlugIn()
    End Sub
#End Region

    'Improvements
    ' Done - "Enabled" option
    ' Done - DXCore visualize Toolbar
    ' Configure %ages
    ' Configure Colors
    ' Configure Opacity
    ' Configure Widths

#Region "Fields"
    Private mEnabled As Boolean
    Private mMetric As ICodeMetricProvider
    Private mMetricMaxWarning As Integer = 0
    Private mModeMultiColor As Boolean
    Private mModeSingleGradientColor As Boolean
    Private mVisualizeButton As IMenuButton
    Private mFirstBoundary As Double
    Private mSecondBoundary As Double
    Private mThirdBoundary As Double
    Private mOpacity1 As Integer
    Private mOpacity2 As Integer
    Private mOpacity3 As Integer
    Private mColor1 As Color
    Private mColor2 As Color
    Private mColor3 As Color

    Private mGradientBoundaryPcent As Double
    Private mGradientColor As Color
    Private mGradientMaxOpacity As Integer
#End Region
#Region "Resources"
    Public Function GetBitmapByName(ByVal BitmapName As String) As Bitmap
        Dim Asm As Assembly = Assembly.GetAssembly(Me.GetType)
        Dim stream As IO.Stream = Asm.GetManifestResourceStream(String.Format("CR_MetricShader.{0}", BitmapName))
        Return CType(Bitmap.FromStream(stream), Bitmap)
    End Function
#End Region
#Region "Settings"
    Private Sub LoadSettings()
        mMetric = Options1.Providers(Options1.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_MetricIndex, Options1.DEFAULT_METRIC_INDEX))
        mMetricMaxWarning = Options1.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_MetricMaxWarn, Options1.DEFAULT_METRIC_MAXWARN)
        mEnabled = Options1.Storage.ReadBoolean(Options1.SETTING_MetricShader, Options1.SETTING_ShaderEnabled, Options1.DEFAULT_METRIC_ENABLED)
        mFirstBoundary = Options1.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary1, Options1.DEFAULT_BOUNDARY1)
        mSecondBoundary = Options1.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary2, Options1.DEFAULT_BOUNDARY2)
        mThirdBoundary = Options1.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_Boundary3, Options1.DEFAULT_BOUNDARY3)
        mOpacity1 = Options1.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity1, Options1.DEFAULT_OPACITY1)
        mOpacity2 = Options1.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity2, Options1.DEFAULT_OPACITY2)
        mOpacity3 = Options1.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_Opacity3, Options1.DEFAULT_OPACITY3)
        mColor1 = Options1.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_Color1, Options1.DEFAULT_Color1)
        mColor2 = Options1.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_Color2, Options1.DEFAULT_COLOR2)
        mColor3 = Options1.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_Color3, Options1.DEFAULT_COLOR3)

        mModeMultiColor = Options1.MODE_MULTI_COLOR = Options1.Storage.ReadString(Options1.SETTING_MetricShader, Options1.SETTING_MODE, Options1.DEFAULT_MODE)
        mModeSingleGradientColor = Options1.MODE_SINGLE_GRADIENT_COLOR = Options1.Storage.ReadString(Options1.SETTING_MetricShader, Options1.SETTING_MODE, Options1.DEFAULT_MODE)
        mGradientColor = Options1.Storage.ReadColor(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_COLOR, Options1.DEFAULT_COLOR_GRADIENT)
        mGradientMaxOpacity = Options1.Storage.ReadInt32(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_MAX_OPACITY, Options1.DEFAULT_GRADIENT_OPACITY)
        mGradientBoundaryPcent = Options1.Storage.ReadDouble(Options1.SETTING_MetricShader, Options1.SETTING_GRADIENT_LOWER_BOUNDARY, Options1.DEFAULT_GRADIENT_LOWER_BOUNDARY)

        Call CodeRush.TextViews.Refresh()
        If (mVisualizeButton IsNot Nothing) Then
            mVisualizeButton.IsDown = mEnabled
        End If
    End Sub
#End Region
#Region "Editor Events"
    Private Sub PlugIn1_DecorateLanguageElement(ByVal sender As Object, ByVal args As DecorateLanguageElementEventArgs) Handles Me.DecorateLanguageElement
        If CodeRush.Source.ActiveClass Is Nothing Then
            Exit Sub
        End If
        If Not mEnabled Then
            Exit Sub
        End If
        If Not TypeOf args.LanguageElement Is Member Then
            Exit Sub
        End If
        Dim View As TextView = CodeRush.Documents.ActiveTextView
        Dim Member = TryCast(args.LanguageElement, Member) 'MembersToHighlight.FirstOrDefault
        Dim ViewRange = View.GetRangeFromRectangle(View.Bounds)
        If Not ViewRange.Overlaps(Member.GetFullBlockCutRange) Then
            Exit Sub
        End If
        If Not GetColor(Member).HasValue Then
            Exit Sub
        End If
        Dim HighlightColor = GetColor(Member).Value
        Dim BlockElements As BlockElements = BlockElements.LeadingWhiteSpace _
                                          Or BlockElements.TrailingWhiteSpace _
                                          Or BlockElements.Region _
                                          Or BlockElements.AllSupportElements
        Dim Range As SourceRange = Member.GetFullBlockCutRange(BlockElements)

        Dim Width As Integer = 120 'GetLongestLine(Range) - 1
        Range = New SourceRange(New SourcePoint(Member.StartLine, 1), _
                                New SourcePoint(Range.End.Line - 1, Width))

        Dim PlatformColor = Platform.Color.FromArgb(HighlightColor.A, _
                                            HighlightColor.R, _
                                            HighlightColor.G, _
                                            HighlightColor.B)
        args.AddAdornment(New AdornmentFactory(Range, PlatformColor))
    End Sub

    Private Function GetLongestLine(ByVal Range As SourceRange) As Integer
        Dim Result As Integer = 0
        For line = Range.Start.Line To Range.End.Line
            Dim Length = CodeRush.Documents.ActiveTextDocument.GetCodeOnLine(line).Length
            If Length > Result Then
                Result = Length
            End If
        Next
        Return Result
    End Function
    Private Function GetMembersToHighlight(ByVal View As TextView) As System.Collections.Generic.List(Of Member)
        Dim Members = CodeRush.Source.ActiveClass.AllMembers.OfType(Of Member)()
        Dim ViewRange = View.GetRangeFromRectangle(View.Bounds)
        Dim MembersToHighlight = (From M In Members _
                                    Where ViewRange.Overlaps(M.GetFullBlockCutRange) _
                                        AndAlso GetColor(M).HasValue).ToList
        Return MembersToHighlight
    End Function

    Private Sub PlugIn1_OptionsChanged(ByVal ea As OptionsChangedEventArgs) Handles Me.OptionsChanged
        If ea.OptionsPages.Contains(GetType(Options1)) Then
            LoadSettings()
        End If
    End Sub
#End Region
    '#Region "Visualize Button"
    '    Private Sub CreateVisualizeButton()
    '        If (CodeRush.Menus Is Nothing OrElse CodeRush.Menus.VisualizeToolBar Is Nothing) Then
    '            Return
    '        End If
    '        Dim Image = GetBitmapByName("CR_MetricShader.ico")
    '        mVisualizeButton = CodeRush.Menus.VisualizeToolBar.AddButton(Options1.GetPageName(), Image)
    '        If (mVisualizeButton Is Nothing) Then
    '            Return
    '        End If
    '        mVisualizeButton.Style = ButtonStyle.Icon
    '        mVisualizeButton.SetFace(Image, Image)
    '        mVisualizeButton.IsDown = mEnabled
    '        AddHandler mVisualizeButton.Click, AddressOf VisualizeButton_Click
    '    End Sub

    '    Private Sub VisualizeButton_Click(ByVal sender As Object, ByVal e As MenuButtonClickEventArgs)
    '        ' Toggle Feature
    '        mEnabled = Not mEnabled
    '        Using Storage = Options1.Storage
    '            Storage.WriteBoolean(Options1.SETTING_MetricShader, Options1.SETTING_ShaderEnabled, mEnabled)
    '        End Using
    '        Call LoadSettings()
    '    End Sub
    '#End Region

#Region "Demo Metric"
    Private Sub LineCountDemoMetric_GetMetricValue(ByVal sender As System.Object, ByVal e As GetMetricValueEventArgs) Handles LineCountDemoMetric.GetMetricValue
        e.Value = e.LanguageElement.Range.Height
    End Sub
#End Region

    Private Function GetColor(ByVal Member As Member) As Nullable(Of Color)
        If mModeMultiColor Then
            Select Case mMetric.GetValue(Member)
                Case Is < CInt(mFirstBoundary * mMetricMaxWarning)
                    Return Nothing
                Case Is < CInt(mSecondBoundary * mMetricMaxWarning)
                    Return Color.FromArgb(mOpacity1, mColor1)
                Case Is < CInt(mThirdBoundary * mMetricMaxWarning)
                    Return Color.FromArgb(mOpacity2, mColor2)
                Case Else
                    Return Color.FromArgb(mOpacity3, mColor3)
            End Select
        ElseIf mModeSingleGradientColor Then
            Dim CappedMetricValue As Integer = Math.Min(mMetricMaxWarning, mMetric.GetValue(Member))
            Dim absLowerBoundary As Integer = CInt(mGradientBoundaryPcent * mMetricMaxWarning)
            Select Case CappedMetricValue
                Case Is <= CInt(absLowerBoundary)
                    Return Nothing
                Case Else
                    Dim Pcent As Double = (CappedMetricValue - absLowerBoundary) / mMetricMaxWarning
                    Dim Opacity As Integer = Math.Min(mGradientMaxOpacity, CInt(Pcent * mGradientMaxOpacity))
                    Return Color.FromArgb(Opacity, mGradientColor)
            End Select
        End If
    End Function

End Class
