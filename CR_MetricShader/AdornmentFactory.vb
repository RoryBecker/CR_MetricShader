Imports System.Collections.Generic

Imports DevExpress.DXCore.Adornments
Imports DevExpress.DXCore.Platform.Drawing

Imports DevExpress.CodeRush.Core
Imports DevExpress.CodeRush.StructuralParser

Public Class AdornmentFactory
    Inherits TextDocumentAdornment

    ReadOnly mColor As Color
    Public Sub New(ByVal range As SourceRange, ByVal Color As Color)
        MyBase.New(range)
        mColor = Color
    End Sub

    Protected Overrides Function NewAdornment(ByVal feature As String, ByVal frame As IElementFrame) As TextViewAdornment
        Return New CodeHighlighter(feature, frame, mColor)
    End Function
End Class
