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

Module SourceRangeExt
    <Extension()> _
    Public Function Overlaps(ByVal Source As SourceRange, ByVal Dest As SourceRange) As Boolean
        Return Source.Intersects(Dest) OrElse Source.Contains(Dest) OrElse Dest.Contains(Source)
    End Function
End Module