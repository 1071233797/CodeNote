Public Class UCText
    Private strIsDigit As Boolean

    Private Sub UCTextEditorO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        UCText.EnterPressedEventArgs(e)
    End Sub



#Region " EnterPressedEventArgs"

    '-----------------------------------------------------------------------------
    '  概要
    '    エンターキーを押す
    '  パラメタ説明
    '    なし
    '  機能説明
    '    無し
    '  戻り値
    '    e           :System.Windows.Forms.KeyEventArgs
    '  作成者
    '    KDC徐鵬［20081201］V0.0.1
    '  備考
    '
    '-----------------------------------------------------------------------------
    Public Shared Sub EnterPressedEventArgs(ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = System.Windows.Forms.Keys.Enter Then

            If e.Shift Then
                System.Windows.Forms.SendKeys.Send("+{TAB}")
            ElseIf Not e.Shift Then
                System.Windows.Forms.SendKeys.Send("{TAB}")
            End If

        End If

    End Sub


#End Region

#Region "负数红色字体"
    'Private Sub UCTextEditorO_ValueChanged(sender As Object, e As EventArgs) Handles Me.ValueChanged

    '    Dim decValue As Decimal

    '    If (Decimal.TryParse(Me.Value, decValue)) Then
    '        If decValue < 0 Then
    '            Me.Appearance.ForeColor = Color.Red
    '        Else
    '            Me.Appearance.ForeColor = Color.Black
    '        End If
    '    End If

    'End Sub
#End Region


    Private Sub UCTextEditorO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If Not IsDigit Then
            Exit Sub
        End If


        If Char.IsDigit(e.KeyChar) OrElse e.KeyChar = Chr(8) OrElse e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If


    End Sub
    Public Property IsDigit()
        Get
            Return strIsDigit
        End Get
        Set(value)
            strIsDigit = value
        End Set
    End Property
End Class
