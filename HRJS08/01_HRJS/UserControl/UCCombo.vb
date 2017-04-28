Public Class UCCombo

    Public Overloads Property [ReadOnly]() As Boolean
        Get
            [ReadOnly] = MyBase.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            MyBase.ReadOnly = value
            MyBase.TabStop = Not value
            If Me.ReadOnly = True Then
                Me.Appearance.BackColor = MUCColor.CommonSilver
            Else
                Me.Appearance.BackColor = MUCColor.CommonLeave
            End If
        End Set
    End Property


    Public Overloads Property [TabStop]() As Boolean
        Get
            [TabStop] = MyBase.TabStop
        End Get
        Set(ByVal value As Boolean)
            MyBase.TabStop = value
        End Set
    End Property

    Private Sub UCCombo_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Enter

        If Not IsDBNull(Me.Value) AndAlso _
            Not Me.Value Is Nothing AndAlso _
             Me.Value.ToString = " " Then
            Me.Text = String.Empty
        End If

        If Not Me.ReadOnly Then
            Me.Appearance.BackColor = MUCColor.CommonEnter
        End If
    End Sub

    Private Sub UCCombo_Invalidated(ByVal sender As Object, ByVal e As Windows.Forms.InvalidateEventArgs) Handles Me.Invalidated
        Me.Font = ComVariable.CON_FONT
    End Sub

    Private Sub UCCombo_KeyDown(ByVal sender As Object, ByVal e As Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'UCUtility.EnterPressedEventArgs(e)
    End Sub

    Private Sub UCCombo_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Validated
        If Not Me.ReadOnly Then
            Me.Appearance.BackColor = MUCColor.CommonLeave
        End If
    End Sub

End Class
