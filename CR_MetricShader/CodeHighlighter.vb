Imports DevExpress.DXCore.Adornments
Imports DevExpress.DXCore.Platform.Drawing


Public Class CodeHighlighter
    Inherits VisualObjectAdornment

    ReadOnly mInnerColor As Color
    Public Sub New(ByVal feature As String, ByVal frame As IElementFrame, ByVal InnerColor As Color)
        MyBase.New(feature, frame)
        mInnerColor = InnerColor
    End Sub

    Public Overrides Sub Render(ByVal context As IDrawingSurface, ByVal geometry As ElementFrameGeometry)
        context.DrawRectangle(mInnerColor, mInnerColor, geometry.Bounds)

    End Sub
End Class