Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class ColorPicker
    Inherits UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        AllowOpacity = True
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
    Friend WithEvents tbOpacity As System.Windows.Forms.TrackBar
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tbOpacity = New System.Windows.Forms.TrackBar
        Me.lblColor = New System.Windows.Forms.Label
        Me.lblLabel = New System.Windows.Forms.Label
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbOpacity
        '
        Me.tbOpacity.AutoSize = False
        Me.tbOpacity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbOpacity.Location = New System.Drawing.Point(128, 0)
        Me.tbOpacity.Maximum = 255
        Me.tbOpacity.Name = "tbOpacity"
        Me.tbOpacity.Size = New System.Drawing.Size(136, 24)
        Me.tbOpacity.TabIndex = 58
        Me.tbOpacity.TickFrequency = 26
        Me.tbOpacity.Value = 255
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.Color.Blue
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblColor.Location = New System.Drawing.Point(104, 0)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(24, 24)
        Me.lblColor.TabIndex = 57
        '
        'lblLabel
        '
        Me.lblLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblLabel.Location = New System.Drawing.Point(0, 0)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(104, 24)
        Me.lblLabel.TabIndex = 59
        Me.lblLabel.Text = "Label here"
        Me.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ColorPicker
        '
        Me.Controls.Add(Me.tbOpacity)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblLabel)
        Me.Name = "ColorPicker"
        Me.Size = New System.Drawing.Size(264, 24)
        CType(Me.tbOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private mColorBase As Color
    Private mAllowOpacity As Boolean

#Region "Properties"
    <EditorBrowsable(EditorBrowsableState.Always), _
     Browsable(True), _
     DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), _
     Bindable(True)> _
     Public Overrides Property Text() As String
        Get
            Return lblLabel.Text
        End Get
        Set(ByVal Value As String)
            lblLabel.Text = Value
        End Set
    End Property
    Public Property ColorBase() As Color
        Get
            Return mColorBase
        End Get
        Set(ByVal Value As Color)
            mColorBase = Value
            UpdateLabelColor()
        End Set
    End Property
    Private Sub UpdateLabelColor()
        lblColor.BackColor() = Color.FromArgb(tbOpacity.Value, mColorBase)
    End Sub
    Public ReadOnly Property Color() As Color
        Get
            Return lblColor.BackColor
        End Get
    End Property
    Public Property Opacity() As Integer
        Get
            Return tbOpacity.Value
        End Get
        Set(ByVal Value As Integer)
            If AllowOpacity Then
                tbOpacity.Value = Value
                UpdateLabelColor()
            Else
                tbOpacity.Value = 255
            End If
        End Set
    End Property
    Public Property AllowOpacity() As Boolean
        Get
            Return mAllowOpacity
        End Get
        Set(ByVal Value As Boolean)
            mAllowOpacity = Value
            tbOpacity.Visible = Value
            If Not Value Then
                tbOpacity.Value = 255
            End If
        End Set
    End Property
    Public Property LabelWidth() As Integer
        Get
            Return lblLabel.Width
        End Get
        Set(ByVal Value As Integer)
            lblLabel.Width = Value
        End Set
    End Property

#End Region
    Private Function PickColor(ByVal CancelColor As Color) As Color
        Dim MyDialog As New ColorDialog
        MyDialog.AllowFullOpen = False
        MyDialog.Color = CancelColor
        If (MyDialog.ShowDialog() = DialogResult.OK) Then
            Return MyDialog.Color
        Else
            Return CancelColor
        End If
    End Function
    Private Sub tbOpacity_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbOpacity.Scroll
        Opacity = tbOpacity.Value
    End Sub
    Private Sub lblColor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblColor.Click
        ColorBase = PickColor(lblColor.BackColor)
    End Sub
End Class
