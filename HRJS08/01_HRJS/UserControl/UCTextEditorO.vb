Public Class UCTextEditorO

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

    Private Sub UCTextEditorO_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        Me.Appearance.BackColor = MUCColor.CommonSilver
        Me.Font = ComVariable.CON_FONT
    End Sub

    Private Sub UCTextEditorO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'UCUtility.EnterPressedEventArgs(e)
    End Sub

End Class
