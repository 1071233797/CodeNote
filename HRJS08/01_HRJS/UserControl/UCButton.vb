Imports System.Windows.Forms

Public Class UCButton

#Region "変数"
    Private _ProwerButtonName As String = String.Empty      'ボタンの権限
    Private _FSearchButtonName As String = String.Empty
#End Region

#Region "プロパティ"
    Public Property FSearchButtonName() As String
        Get
            FSearchButtonName = _FSearchButtonName
        End Get
        Set(ByVal value As String)
            _FSearchButtonName = value
        End Set
    End Property

#End Region

#Region "自定義関数"

    Public Sub MyOnclick()

        Call MyBase.OnClick(New EventArgs())

    End Sub

#End Region

#Region "Tab"
    Private intTabKey As Integer = 0
    Private mIntEnterKey As Integer = 0

    ReadOnly Property GeTabKey() As Integer
        Get
            Return intTabKey
        End Get
    End Property

    ReadOnly Property intEnterKey() As Integer
        Get
            Return mIntEnterKey
        End Get
    End Property

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        Const WM_KEYDOWN As Integer = &H100
        Const WM_SYSKEYDOWN As Integer = &H104
        Dim ee As New System.Windows.Forms.KeyEventArgs(keyData)
        If ((msg.Msg = WM_KEYDOWN) Or _
        (msg.Msg = WM_SYSKEYDOWN)) Then
            Select Case (keyData)

                Case (Keys.Tab)
                    intTabKey = 1
                Case (Keys.Enter)
                    mIntEnterKey = 1
                    intTabKey = 2
                Case Keys.Tab + Keys.Shift
                    intTabKey = 3
                Case Keys.Tab + Keys.Enter
                    intTabKey = 4
                Case Else
                    intTabKey = 0

            End Select
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

#End Region

#Region "事件処理"
    Private Sub UCButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click

        Me.Focus()

    End Sub

    Private Sub UCButton_Layout(ByVal sender As Object, ByVal e As LayoutEventArgs) Handles Me.Layout
        Me.Font = ComVariable.CON_FONT
    End Sub
#End Region

End Class
